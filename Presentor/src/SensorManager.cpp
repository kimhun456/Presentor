/*
 * SensorManager.cpp
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#include "Sender.h"

using namespace std;

bool isStop(sensor_values value){

	float x = value.x;
	float y = value.y;

	 if(-7.5 > y && y >  -12.5 && x>-2.5 && x <2.5){

		 return true;

	 }
	 else{

		 return false;
	 }

}

/**
 * 	return value == 1
 *
 * 	HOLD상태
 *
 * 	RETURN value == 0
 *
 * 	MOVING
 *
 *
 */
int getCurrentState(appdata_s * ad){


	int rest = ad->restTime;
	ad->restTime--;
	if(rest > 0){
		return 0;
	}

	int count = ad->gyroCount;
	sensor_values value[5];
	bool stop_flags[5];
	for(int i=0;i<5;i++){
		value[i] = ad->gyroValue[((count-i-1)+10)%10];
		stop_flags[i] = isStop(value[i]);
	}

	bool flag = true;
	for(int i=0;i<5;i++){
		if(!stop_flags[i])
			flag = false;
	}

	if(flag){
		return 1;
	}else{
		return 0;
	}
}



void
gyro_events_handler(sensor_h sensor, sensor_event_s *event, void *user_data)
{
   // Select a specific sensor with a sensor handle
   // This example uses the sensor type, assuming there is only 1 sensor for each type

	appdata_s *ad = (appdata_s *) user_data;
	sensor_values value;
	value.x = event->values[0];
	value.y = event->values[1];
	value.z = event->values[2];

	if(ad->gyroCount == 10){
		ad->gyroEnoughData = true;
		ad->gyroCount = 0;
	}

	ad->gyroValue[ad->gyroCount] = value;
	ad->gyroCount++;

	int state = getCurrentState(ad);

	if(state == 1){

		_D(" HOLD POSITION");

		ad->acceptCount = 3;
		ad->acceptMotion = true;
	}else{
		if(ad->acceptCount >0){
			ad->acceptCount--;
		}else{
			ad->acceptMotion = false;
		}
	}

}



int
getAccelData(appdata_s * ad){

	int count = ad->accCount;
	sensor_values value[3];

	for(int i=0;i<3;i++){
		value[i] = ad->accValue[((count-i-1)+10)%10];
	}

	if(ad->acceptMotion){
		bool right = true;
		bool left = true;

		for(int i=0;i<3;i++){
			if(value[i].y <40){
				right = false;
			}
			if(value[i].y > -40){
				left = false;
			}
		}

		if(right){
			return 1;
		}

		if(left){
			return -1;
		}
	}

	return 0;
}



void
accel_events_handler(sensor_h sensor, sensor_event_s *event, void *user_data)
{
   // Select a specific sensor with a sensor handle
   // This example uses the sensor type, assuming there is only 1 sensor for each type

	appdata_s *ad = (appdata_s *) user_data;

	int state = 0;
	sensor_values value;
	value.x = event->values[0];
	value.y = event->values[1];
	value.z = event->values[2];

	if(ad->accCount == 10){
		ad->accEnoughData = true;
		ad->accCount = 0;
	}

	ad->accValue[ad->accCount] = value;
	ad->accCount++;

	if(ad->accEnoughData){
		state = getAccelData(ad);
	}

	if(state== 1){
		ad->restTime = 10;
		ad->acceptMotion = false;
		ad->acceptCount = 0;
		_D("right");

		_next_message_send(ad);



	}else if(state == -1){
		ad->restTime=10;
		ad->acceptMotion = false;
		ad->acceptCount = 0;
		_D("left");


		_prev_message_send(ad);


	}


//	_D(" ACC : %.4f %.4f %.4f", value.x, value.y, value.z);


}

void Accelerometer_use (appdata_s *ad)
{

    sensor_type_e     type;
	sensor_h          sensor;

	type = SENSOR_ACCELEROMETER;

	sensor_get_default_sensor (type, &sensor);
	sensor_create_listener (sensor, &ad->accel_listener);
	// 모듈 생성

	bool supported = false;
	sensor_is_supported (type, &supported);
	if ( supported )
	{// 장비 지원 여부 확인
		sensor_error_e ison = SENSOR_ERROR_NONE;
		ison =(sensor_error_e) sensor_listener_start (ad->accel_listener);
		if ( ison == SENSOR_ERROR_NONE )
		{//장비 켜기
			sensor_error_e errorcode;
			errorcode = (sensor_error_e) sensor_listener_set_event_cb(ad->accel_listener, ad->frequency, gyro_events_handler, ad);
		}
	}

}

void Gyroscope_use (appdata_s *ad)
{
    sensor_type_e     type;
    sensor_h          sensor;

    type = SENSOR_GYROSCOPE;

    sensor_get_default_sensor (type, &sensor);
    sensor_create_listener (sensor, &ad->gyro_listener);
    // 모듈 생성

    bool supported = false;
    sensor_is_supported (type, &supported);
    if ( supported )
    {// 장비 지원 여부 확인
        sensor_error_e ison = SENSOR_ERROR_NONE;
        ison =(sensor_error_e) sensor_listener_start (ad->gyro_listener);
        if ( ison == SENSOR_ERROR_NONE )
        {//장비 켜기
            sensor_error_e errorcode;
            errorcode = (sensor_error_e) sensor_listener_set_event_cb(ad->gyro_listener, ad->frequency, accel_events_handler, ad);
        }
    }

}


void init_sensor(void *data){

	appdata_s *ad = (appdata_s *) data;
	_D("INIT sensor");

	// getSensorData
	ad->gyroEnoughData = false;
	ad->accEnoughData = false;
	ad->acceptMotion = false;

	ad->restTime = 0;

	// 100ms로 센싱
	ad->frequency = 100;
	ad->gyroCount=0;
	ad->accCount=0;
	Gyroscope_use(ad);
	Accelerometer_use(ad);
}




void
destroy_sensor(void *data){


	_D("Destroy sensor");
	appdata_s *ad = (appdata_s *) data;

    sensor_listener_unset_event_cb (ad->accel_listener);
    sensor_listener_stop (ad->accel_listener);
    sensor_destroy_listener (ad->accel_listener);

    sensor_listener_unset_event_cb (ad->gyro_listener);
    sensor_listener_stop (ad->gyro_listener);
    sensor_destroy_listener (ad->gyro_listener);

}
void
_opened_cb(void *data, Evas_Object *obj, void *event_info)
{
   dlog_print(DLOG_INFO, LOG_TAG, "Open the More Option\n");
}



