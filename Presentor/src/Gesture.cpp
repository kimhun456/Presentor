/*
 * Gesture.cpp
 *
 *  Created on: Jun 7, 2016
 *      Author: HyunJae
 */


#include "Gesture.h"

void gesture_cb(gesture_type_e type, const gesture_data_h data, double timestamp, gesture_error_e error, void *user_data)

{
	int result;
	gesture_event_e event;

	_D("SHAKE");

	if (error != GESTURE_ERROR_NONE) {
		// An error occurred. Do necessary error handling here.
		return;
	}

	if (type == GESTURE_WRIST_UP) {
		// More than one gestures can be started using the same callback function.

		result = gesture_get_event(data, &event);

		_D("SHAKE");

	}
}





void
setGesture(void * data){

	appdata_s *ad = (appdata_s *) data;
	bool supported = false;
	gesture_is_supported(GESTURE_WRIST_UP, &supported);

	if (!supported) {
	// Not supported in the current device.
		_D("Gesture not support");
	}else{
		_D("Gesture support");
	}
	gesture_h handle;
	gesture_error_e result;
	result = (gesture_error_e)gesture_create(&handle);

	if (result != GESTURE_ERROR_NONE) {

		_D("Gesture Error");

	}

	result =  (gesture_error_e)gesture_start_recognition(handle, GESTURE_SHAKE, GESTURE_OPTION_DEFAULT, gesture_cb, NULL);

	if (result != GESTURE_ERROR_NONE) {
		// An error occurred. Do necessary error handling here.
	}



}


void
create_exam_layout(void * data ){
	appdata_s *ad = (appdata_s *) data;
	Evas_Object *nv = ad->navi;
	Evas_Object *button, *layout;

	layout = elm_layout_add(nv);
	elm_layout_theme_set(layout, "layout", "bottom_button", "default");
	evas_object_show(layout);

	ad->state = elm_label_add(layout);
	evas_object_size_hint_weight_set(ad->state, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_text_set(ad->state, "noooooo");
	evas_object_show(ad->state);
	elm_object_part_content_set(layout, "elm.swallow.content",ad->state);

	// 여기 수정 nv -> layout
	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "Setting");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_show(button);

	elm_naviframe_item_push(nv, "Gesture Setting", NULL, NULL, layout, NULL);
	setGesture(ad);

}
