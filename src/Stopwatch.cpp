/*
 * Stopwatch.cpp
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#include "StopWatch.h"
#include <string>

using namespace std;


Eina_Bool
time_tic_toc(void *data){

	appdata_s *ad = (appdata_s *) data;

	string header = "<align=center><font_size=80>";
	string footer = "</font_size></align>";

	string minute_seconds ;

	ad->milliseconds +=100;

	int miillisec = ad->milliseconds;

	string min,sec;
	int seconds = miillisec / 1000;
	int minute = seconds / 60;

	seconds %=60;
	minute %=60;
	miillisec %=1000;

	if(minute < 10){
		min = "0"+to_string(minute);
	}else{
		min = to_string(minute);
	}

	if(seconds < 10){
		sec = "0"+to_string(seconds);
	}else{
		sec = to_string(seconds);
	}

	minute_seconds = header + min + ":" + sec + footer;

	elm_object_text_set(ad->time,minute_seconds.c_str());

	return EINA_TRUE;
}

static Evas_Event_Flags
longClick(void *data, void *event_info)
{
	appdata_s *ad = (appdata_s *) data;

	ad->milliseconds = 0;
	ecore_timer_freeze(ad->timer);
	ad->start = false;

	elm_object_text_set(ad->time, "<align=center><font_size=80>00:00</font_size></align>");
	evas_object_show(ad->time);

   return EVAS_EVENT_FLAG_ON_HOLD;
}



static Evas_Event_Flags
tap(void *data, void *event_info)
{
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

	Evas_Object *gesture;
	gesture = elm_gesture_layer_add(ad->time);

	elm_gesture_layer_attach(gesture,ad->time );

	elm_gesture_layer_cb_set(gesture, ELM_GESTURE_N_TAPS, ELM_GESTURE_STATE_START,
	                         tap,  ad);

	elm_gesture_layer_cb_set(gesture, ELM_GESTURE_N_DOUBLE_TAPS, ELM_GESTURE_STATE_END,
	                         longClick, ad);

	elm_object_text_set(ad->time, "<align=center><font_size=80>00:00</font_size></align>");

	evas_object_show(ad->time);
}

void
init_timer(appdata_s *ad){

	ad->milliseconds = 0;

	// timer add 100 millisecond
	ad->timer =  ecore_timer_add(0.1, time_tic_toc, ad);
	ecore_timer_freeze(ad->timer);
	ad->start = false;


	set_clock_layout(ad);
}
