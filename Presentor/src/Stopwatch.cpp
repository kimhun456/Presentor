/*
 * Stopwatch.cpp
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#include "StopWatch.h"

using namespace std;

Eina_Bool
time_tic_toc(void *data){

	appdata_s *ad = (appdata_s *) data;

	string header = "<align=center><font_size=80>";
	string footer = "</font_size></align>";

	int min = ad->minutes;
	int sec = ad->seconds;

	if(sec == 0){
		if(min >0){
			min--;
			sec = 59;
		}

		else{
			ecore_timer_freeze(ad->timer);
			ad->start = false;
		}
	}
	else{
		sec--;
	}

	ad->minutes = min;
	ad->seconds = sec;
	_D(" min : %d", min);
	_D(" sec : %d", sec);

	string m;
	string s;
	if(min < 10){
		m = "0" + to_string(min);
	}else{
		m = to_string(min);
	}

	if(sec<10){
		s = "0"+ to_string(sec);
	}else{
		s = to_string(sec);
	}

	string result = header + m + ":" + s + footer;

	elm_object_text_set(ad->time, result.c_str());
	int error;


	//5분
	if(min == 5 && sec == 0){

		error = device_haptic_vibrate(ad->handle, 2000, 55, &ad->effect_handle);
	}
	// 1분
	else if(min == 1 && sec ==0){

		error = device_haptic_vibrate(ad->handle, 2000, 77, &ad->effect_handle);
	}
	// 끝났을 경우
	else if(min ==0 && sec == 0){
		error = device_haptic_vibrate(ad->handle, 4000, 99, &ad->effect_handle);
	}


	return EINA_TRUE;
}

static Evas_Event_Flags
doubleClick(void *data, void *event_info)
{
	_D("DOUBLE TAP");

	appdata_s *ad = (appdata_s *) data;

	ad->minutes = 0;
	ad->seconds = 0;
	ecore_timer_freeze(ad->timer);
	ad->start = false;

	elm_object_text_set(ad->time, "<align=center><font_size=80>00:00</font_size></align>");
	evas_object_show(ad->time);

   return EVAS_EVENT_FLAG_ON_HOLD;
}

static Evas_Event_Flags
tap(void *data, void *event_info)
{

	_D("TAP");
	appdata_s *ad = (appdata_s *) data;

	if(ad->start){
		ecore_timer_freeze(ad->timer);
		ad->start = false;
	}else{
		ecore_timer_thaw(ad->timer);
		ad->start = true;
	}

   return EVAS_EVENT_FLAG_ON_HOLD;
}

void
set_clock_layout(appdata_s *ad){

	Evas_Object *gesture = ad->gestrue;

	gesture = elm_gesture_layer_add(ad->time);
	elm_gesture_layer_attach(gesture,ad->time );

	elm_gesture_layer_cb_set(gesture, ELM_GESTURE_N_TAPS, ELM_GESTURE_STATE_START,
	                         tap,  ad);

	elm_gesture_layer_cb_set(gesture, ELM_GESTURE_N_DOUBLE_TAPS, ELM_GESTURE_STATE_END,
							doubleClick, ad);

}
void
init_haptic(appdata_s *ad){

	int error;
	error = device_haptic_open(0, &ad->handle);
	dlog_print(DLOG_INFO, LOG_TAG, "[device_haptic_open] error:%d",error);
}


void
init_timer(appdata_s *ad){

	ecore_timer_del(ad->timer);

	// timer add 1 second
	ad->timer =  ecore_timer_add(1, time_tic_toc, ad);
	ecore_timer_freeze(ad->timer);
	ad->start = false;
	init_haptic(ad);


}

