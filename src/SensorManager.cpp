/*
 * SensorManager.cpp
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#include "SensorManager.h"
#include "log.h"
#include "Launcher.h"
#include <string>

using namespace std;

void
gyro_events_handler(sensor_h sensor, sensor_event_s *event, void *user_data)
{
   // Select a specific sensor with a sensor handle
   // This example uses the sensor type, assuming there is only 1 sensor for each type

	appdata_s *ad = (appdata_s *) user_data;


	string result;

	result = to_string(event->values[0]) + " , " +to_string(event->values[1]) + " , " +to_string(event->values[2]);

	_D(" %d %d %d", event->values[0], event->values[1], event->values[2]);

	elm_object_text_set(ad->accuracy, result.c_str());
	evas_object_show(ad->accuracy);

}
void Accelerometer_use ()
{
    sensor_type_e     type;
    sensor_h          sensor;
    sensor_listener_h listener;

    type = SENSOR_ACCELEROMETER;

    sensor_get_default_sensor (type, &sensor);
    sensor_create_listener (sensor, &listener);
    // 모듈 생성

    bool supported = false;
    sensor_is_supported (type, &supported);
    if ( supported )
    {// 장비 지원 여부 확인
        sensor_error_e ison = SENSOR_ERROR_NONE;
        ison = (sensor_error_e)sensor_listener_start (listener);
        if ( ison == SENSOR_ERROR_NONE )
        {//장비 켜기
            sensor_error_e errorcode;
            sensor_event_s data;
            errorcode = (sensor_error_e)sensor_listener_read_data (listener, &data);
            //데이터 수신
            if ( errorcode == SENSOR_ERROR_NONE )
            {
                dlog_print (DLOG_INFO, "DIT", "x : %f, y : %f, z : %f", data.values[0], data.values[1], data.values[2]);
                //데이터 출력
                sensor_listener_stop (listener);
                //장비 끄기
            }
        }
    }

    sensor_listener_unset_event_cb (listener);
    sensor_listener_stop (listener);
    sensor_destroy_listener (listener);
    // 모듈 삭제
}

void Gyroscope_use (appdata_s *ad)
{
    sensor_type_e     type;
    sensor_h          sensor;
    sensor_listener_h listener;

    type = SENSOR_GYROSCOPE;

    sensor_get_default_sensor (type, &sensor);
    sensor_create_listener (sensor, &listener);
    // 모듈 생성

    bool supported = false;
    sensor_is_supported (type, &supported);
    if ( supported )
    {// 장비 지원 여부 확인
        sensor_error_e ison = SENSOR_ERROR_NONE;
        ison =(sensor_error_e) sensor_listener_start (listener);
        if ( ison == SENSOR_ERROR_NONE )
        {//장비 켜기
            sensor_error_e errorcode;
            errorcode = (sensor_error_e) sensor_listener_set_event_cb(listener, 200, gyro_events_handler, ad);
        }
    }
//
//    sensor_listener_unset_event_cb (listener);
//    sensor_listener_stop (listener);
//    sensor_destroy_listener (listener);
    // 모듈 삭제
}

void
create_sensor_info_layout(void * data ){
	appdata_s *ad = (appdata_s *) data;
	Evas_Object *nv = ad->navi;
	Evas_Object *button, *layout;

	layout = elm_layout_add(nv);
	elm_layout_theme_set(layout, "layout", "bottom_button", "default");
	evas_object_show(layout);

	ad->accuracy = elm_label_add(layout);
	evas_object_size_hint_weight_set(ad->accuracy, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_object_text_set(ad->accuracy, "Set Time");
	evas_object_show(ad->accuracy);
	elm_object_part_content_set(layout, "elm.swallow.content",ad->accuracy);

	// 여기 수정 nv -> layout
	button = elm_button_add(layout);
	elm_object_style_set(button, "bottom");
	elm_object_text_set(button, "Setting");
	elm_object_part_content_set(layout, "elm.swallow.button", button);
	evas_object_show(button);

	elm_naviframe_item_push(nv, "Gesture Setting", NULL, NULL, layout, NULL);
	Gyroscope_use(ad);
	Accelerometer_use();

}
