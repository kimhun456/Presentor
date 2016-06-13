

/*
	  Bluetooth 매니저


*/
#include "Launcher.h"
#include "BluetoothManager.h"
#include "Notice.h"
#include "Sender.h"

#define MAX_NUM_PENDING 1
static struct _s_info {
	Evas_Object *noti;
} s_info = {
	.noti = NULL,
};

static void _socket_conn_state_changed_cb(int result, bt_socket_connection_state_e connection_state, bt_socket_connection_s *connection, void *user_data)
{
	appdata_s *ad = (appdata_s *) user_data;
	ret_if(!ad);

	ret_if(result != BT_ERROR_NONE);

	if (connection_state == BT_SOCKET_CONNECTED) {
		if (connection != NULL) {
			_D("Connected %d %d", ad->socket_fd, connection->socket_fd);
			ad->role = connection->local_role;
			ad->socket_fd = connection->socket_fd;

			// 연결완료시 레이아웃 생성.
			bt_button_layout_create(ad);
			if (s_info.noti) {
				evas_object_del(s_info.noti);
				s_info.noti = NULL;
			}
		} else {
			_D("No connection data");
		}
	} else {
		ad->socket_fd = -1;
		_D("Disconnected");
	}
}




static void _server_create(appdata_s *ad)
{
	int server_socket_fd = -1;
	int ret = 0;

	ret = bt_socket_create_rfcomm(BT_MGR_UUID, &server_socket_fd);
	ret_if(ret != BT_ERROR_NONE);

	ad->server_socket_fd = server_socket_fd;
	_D("[bt_socket_create_rfcomm] socket %d", server_socket_fd);

	ret = bt_socket_set_connection_state_changed_cb(_socket_conn_state_changed_cb, ad);
	ret_if(ret != BT_ERROR_NONE);

	ret = bt_socket_listen_and_accept_rfcomm(server_socket_fd, MAX_NUM_PENDING);
	if (ret != BT_ERROR_NONE) {
		_E("[bt_socket_listen_and_accept_rfcomm] Failed");
	}
}

static void _server_layout_create(appdata_s *ad)
{
	Evas_Object *layout = NULL;
	Evas_Object *progress = NULL;
	Elm_Object_Item *navi_it = NULL;
	char edj_path[PATH_MAX] = { 0, };

	ad->role = BT_SOCKET_SERVER;

	app_resource_get(CREATE_SERVER, edj_path, (int)PATH_MAX);
	layout = elm_layout_add(ad->navi);
	goto_if(!layout, ERROR);
	elm_layout_file_set(layout, edj_path, "create_server");
	evas_object_size_hint_align_set(layout, EVAS_HINT_FILL, 0.5);
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	progress = elm_progressbar_add(layout);
	elm_object_style_set(progress, "process/popup/small");
	evas_object_size_hint_align_set(progress, EVAS_HINT_FILL, 0.5);
	evas_object_size_hint_weight_set(progress, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_progressbar_pulse(progress, EINA_TRUE);
	evas_object_show(progress);

	elm_object_part_content_set(layout, "progress", progress);

	navi_it = elm_naviframe_item_push(ad->navi, "Wait a Computer..", NULL, NULL, layout, NULL);
	elm_naviframe_item_title_enabled_set(navi_it, EINA_FALSE, EINA_FALSE);

	_server_create(ad);

	return;

ERROR:
	_E("Failed to create server layout");

	if (layout) {
		evas_object_del(layout);
		layout = NULL;
	}

	if (progress) {
		evas_object_del(progress);
		progress = NULL;
	}

	return;
}


// 초기화
HAPI void bt_mgr_initialize(void *data, bt_mgr_type type)
{
	appdata_s *ad = NULL;
	bt_adapter_state_e bt_ad_state = BT_ADAPTER_DISABLED;
	int ret = 0;

	ad = (appdata_s *) data;
	ret_if(!ad);

	ret = bt_initialize();
	ret_if(ret != BT_ERROR_NONE);

	ret = bt_adapter_get_state(&bt_ad_state);
	ret_if(ret != BT_ERROR_NONE);

	if (bt_ad_state == BT_ADAPTER_DISABLED) {
		Evas_Object *noti = bt_noti_popup_create(ad->navi, "Bluetooth is OFF");
		if (!noti) {
			_E("Failed to create popup noti");
		} else {
			s_info.noti = noti;
		}
	} else {
		switch (type) {

			break;
		case BT_MGR_WAIT:
			_server_layout_create(ad);
			break;
		}
	}
}

HAPI void bt_mgr_release(void)
{

	bt_adapter_unset_state_changed_cb();
	bt_adapter_unset_device_discovery_state_changed_cb();
	bt_device_unset_service_searched_cb();
	bt_socket_unset_data_received_cb();
	bt_socket_unset_connection_state_changed_cb();
	bt_deinitialize();
}
