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

#ifndef __BLUETOOTH_CHAT_H__
#define __BLUETOOTH_CHAT_H__

#include <app.h>
#include <tizen.h>
#include <Elementary.h>
#include <system_settings.h>
#include <bluetooth_type.h>
#include <efl_extension.h>
#include <dlog.h>
#include <stdbool.h>
#include <efl_extension.h>
#include <sensor.h>
#include <device/haptic.h>
#include "log.h"

#if !defined(PACKAGE)
#define PACKAGE "BLUETOOTHCHAT"
#endif

#define FORMAT "%d/%b/%Y%H:%M"
#define EDJ_FILE "edje/bt_chat.edj"
#define CREATE_SERVER "edje/create_server.edj"
#define GRP_MAIN "main"

#define HAPI __attribute__((visibility("hidden")))


class XYZ{
public:
	float x;
	float y;
	float z;
};

typedef struct sensor_{
	float x;
	float y;
	float z;
} sensor_values;

typedef struct appdata{
	Evas_Object* win;
	Evas_Object* navi;
	Evas_Object* conform;
	Evas_Object *layout;
	Evas_Object *gesture_button;
	Evas_Object *accuracy;
	Evas_Object *state;
	Evas_Object *gestrue;
	Eext_Circle_Surface *circle_surface;

	//timer
	Evas_Object *time;
	Ecore_Timer* timer;
	int minutes;
	int seconds;
	bool start;
	Evas_Object *label;
	Evas_Object *datetime;
	struct tm saved_time;

	bool bt;
	int socket_fd;
	int server_socket_fd;
	bt_socket_role_e role;

	int win_w;
	int win_h;

	//Gesture data queue

	bool use_gesture;

	int frequency;
	sensor_values gyroValue[10];
	sensor_values accValue[10];
	int gyroCount;
	int accCount;

	// 데이터충분한지
	bool gyroEnoughData;
	bool accEnoughData;

	// 모션을 받아들일 준비가 되었는지
	bool acceptMotion;
	int acceptCount;

	// 남아있는 시간동안 처리 가능한지
	int restTime;

	// 리스너들
    sensor_listener_h gyro_listener;
    sensor_listener_h accel_listener;

    //Haptic
    haptic_device_h handle;
    haptic_effect_h effect_handle;

} appdata_s;

typedef enum {
	CS_MAIN = 0x00,
	CS_PREPARE,
	CS_CHAT,
} current_state_e;

typedef enum {
	MOVE,
	STOP
}gesture_state;

void app_resource_get(const char *edj_file_in, char *edj_path_out, int edj_path_max);
void cr_layout(appdata_s *ad);


#endif /* __BLUETOOTH_CHAT_H__ */
