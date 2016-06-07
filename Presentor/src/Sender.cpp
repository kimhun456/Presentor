/*
 * Samsung API
 * Copyright (c) 2009-2015 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/license/
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


#include "Launcher.h"
#include "BluetoothManager.h"
#include "Notice.h"
#include "MenuList.h"
#include "StopWatch.h"


Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev);

static void _next_message_send(appdata_s *ad)
{

	Evas_Object *noti = NULL;
	int ret = 0;

	ret_if(!ad);

	char message[100] = "next";

	ret = bt_socket_send_data(ad->socket_fd, message, strlen(message) + 1);
	if (ret == -1) {
		_E("[bt_socket_send_data] send to fail : %s", message);
		noti = bt_noti_popup_create(ad->navi, "Send Failed");
		if (!noti) {
			_E("Failed to create popup noti");
		}
	}
}

static void _prev_message_send(appdata_s *ad)
{

	Evas_Object *noti = NULL;
	int ret = 0;

	ret_if(!ad);

	char message[100] = "prev";

	ret = bt_socket_send_data(ad->socket_fd, message, strlen(message) + 1);
	if (ret == -1) {
		_E("[bt_socket_send_data] send to fail : %s", message);
		noti = bt_noti_popup_create(ad->navi, "Send Failed");
		if (!noti) {
			_E("Failed to create popup noti");
		}
	}
}

// 로타리 핸들러
Eina_Bool _rotary_handler_cb(void *data, Eext_Rotary_Event_Info *ev)
{
	appdata_s * ad = (appdata_s *) data;
   if (ev->direction == EEXT_ROTARY_DIRECTION_CLOCKWISE)
   {
	   _next_message_send(ad);
   }
   else
   {
	   _prev_message_send(ad);
   }

   return EINA_FALSE;
}

static void _socket_conn_state_changed_cb(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data)
{
	Evas_Object *noti = NULL;
	appdata_s *ad = NULL;

	ad = (appdata_s *) user_data;
	ret_if(!ad);
	ret_if(result != BT_ERROR_NONE);

	_D("[_socket_conn_state_changed_cb] Changed");

	//disconnect된다면
	if (connection_state == BT_SOCKET_DISCONNECTED) {
		_I("[_socket_conn_state_changed_cb] Disconnected");
		ad->socket_fd = -1;
		eext_rotary_event_handler_del(_rotary_handler_cb);
		noti = bt_noti_popup_create(ad->navi, "Disconnected with the Friend");
		if (!noti) {
			_E("Failed to create popup noti");
		}
	}
}

// 아직 구현할꺼 ㄴㄴ
static void _my_socket_data_received_cb(bt_socket_received_data_s *data, void *user_data){

	/*
	 *
	 *  데이터가 넘어왔을 때 처리하는 부분.
	 */



}

// 텍스트를 바꾼다.
static void
label_text_set(Evas_Object *label, struct tm t)
{
	char buf[200] = {0};
	char text_buf[PATH_MAX];

	//Time gets from tm struct and set as text value
	strftime(buf, sizeof(buf), "%M:%S", &t);
	snprintf(text_buf, sizeof(text_buf), "<align=center><font_size=80>%s</font_size></align>", buf);
	elm_object_text_set(label, text_buf);
}

// 셋버튼이 클릭되었을 때.
static void
set_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s*)data;
	// 다시추가해준다.
	eext_rotary_event_handler_add(_rotary_handler_cb, ad);

	elm_datetime_value_get(ad->datetime, &ad->saved_time);
	label_text_set(ad->time, ad->saved_time);

	ad->minutes = ad->saved_time.tm_min;
	ad->seconds = ad->saved_time.tm_sec;
	init_timer(ad);

	//View changed to main view.
	elm_naviframe_item_pop(ad->navi);
}

// 버튼이 클릭되었을 때
static void
time_setting_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info)
{
	// rotary_event를 제거한다.
	eext_rotary_event_handler_del(_rotary_handler_cb);
	appdata_s * ad = (appdata_s *) data;

	Evas_Object *button, *layout, *circle_datetime;
	Elm_Object_Item *nf_it = NULL;

	layout = elm_layout_add(ad->navi);
	elm_layout_theme_set(layout, "layout", "circle", "datetime");

	// 셋 버튼
	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "SET");
	elm_object_part_content_set(layout, "elm.swallow.btn", button);
	evas_object_smart_callback_add(button, "clicked", set_clicked_cb, ad);
	elm_object_part_text_set(layout, "elm.text", "Set Time");

	// 데이트 타임 에드
	ad->datetime = elm_datetime_add(layout);

	//eext circle datetime add for circular feature of datetime.
	circle_datetime = eext_circle_object_datetime_add(ad->datetime, ad->circle_surface);
	//eext rotary event activated to circle datetime for gets rotary event.
	eext_rotary_object_event_activated_set(circle_datetime, EINA_TRUE);

	elm_datetime_format_set(ad->datetime, FORMAT);
	elm_datetime_value_set(ad->datetime, &ad->saved_time);

	elm_object_style_set(ad->datetime, "timepicker/circle");
	elm_object_part_content_set(layout, "elm.swallow.content", ad->datetime);

	nf_it = elm_naviframe_item_push(ad->navi, "Time picker", NULL, NULL, layout, NULL);
	elm_naviframe_item_title_enabled_set(nf_it, EINA_FALSE, EINA_FALSE);

}

// 채팅룸 대신에 버튼 하나만 있는 것을 만들어 보쟈!
HAPI void
bt_button_layout_create(appdata_s *ad)
{
	Evas_Object *nv = ad->navi;
	Evas_Object *button, *layout;

	int ret = 0;
	bt_socket_set_data_received_cb(_my_socket_data_received_cb, NULL);

	eext_rotary_event_handler_add(_rotary_handler_cb, ad);

	ret = bt_socket_unset_connection_state_changed_cb();
	ret_if(ret != BT_ERROR_NONE);

	// 소켓의 상태가 바뀌면
	ret = bt_socket_set_connection_state_changed_cb(_socket_conn_state_changed_cb, ad);
	ret_if(ret != BT_ERROR_NONE);

	layout = elm_layout_add(nv);
	elm_layout_theme_set(layout, "layout", "bottom_button", "default");
	evas_object_show(layout);

	ad->time = elm_label_add(layout);
	evas_object_size_hint_weight_set(ad->time, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	label_text_set(ad->time, ad->saved_time);
	evas_object_show(ad->time);
	elm_object_part_content_set(layout, "elm.swallow.content",ad->time);

	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "Set Timer");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_smart_callback_add(button, "clicked", time_setting_btn_clicked_cb, ad);
	evas_object_show(button);
	elm_naviframe_item_push(nv, "Presentor", NULL, NULL, layout, NULL);


	set_clock_layout(ad);

}
