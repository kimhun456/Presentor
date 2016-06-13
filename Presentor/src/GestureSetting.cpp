/*
 * GestureSetting.cpp
 *
 *  Created on: Jun 13, 2016
 *      Author: HyunJae
 */


#include "GestureSetting.h"


static void
gesture_change(void *data, Evas_Object *obj, void *event_info)
{

	appdata_s *ad = (appdata_s *) data;


	if(ad->use_gesture){

		ad->use_gesture = false;

		elm_object_text_set(ad->layout, "<align=center><font_size=60>Gesture OFF</font_size></align>");

		elm_object_text_set(ad->gesture_button, "ON");
	}else{

		ad->use_gesture = true;
		elm_object_text_set(ad->layout, "<align=center><font_size=60>Gesture ON</font_size></align>");
		elm_object_text_set(ad->gesture_button, "OFF");

	}


}

void
create_gesture_setting_ui(void * data ){
	appdata_s *ad = (appdata_s *) data;
	Evas_Object *nv = ad->navi;
	Evas_Object *layout;
	layout = elm_layout_add(nv);
	elm_layout_theme_set(layout, "layout", "bottom_button", "default");
	evas_object_show(layout);

	ad->layout = elm_label_add(layout);
	evas_object_size_hint_weight_set(ad->layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	if(ad->use_gesture){
		elm_object_text_set(ad->layout, "<align=center><font_size=60>Gesture ON</font_size></align>");
	}else{
		elm_object_text_set(ad->layout, "<align=center><font_size=60>Gesture OFF</font_size></align>");
	}

	evas_object_show(ad->layout);
	elm_object_part_content_set(layout, "elm.swallow.content",ad->layout);

	// 여기 수정 nv -> layout
	ad->gesture_button = elm_button_add(layout);
	elm_object_style_set( ad->gesture_button, "bottom");
	if(ad->use_gesture){
		elm_object_text_set( ad->gesture_button, "OFF");
	}else{
		elm_object_text_set( ad->gesture_button, "ON");
	}
	elm_object_part_content_set(layout, "elm.swallow.button", ad->gesture_button);
	evas_object_smart_callback_add( ad->gesture_button, "clicked", gesture_change, ad);
	evas_object_show(ad->gesture_button);

	elm_naviframe_item_push(nv, "Gesture Setting", NULL, NULL, layout, NULL);

}
