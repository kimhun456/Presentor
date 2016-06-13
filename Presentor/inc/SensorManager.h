/*
 * SensorManager.h
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#ifndef SENSORMANAGER_H_
#define SENSORMANAGER_H_

#include <string>
#include "SensorManager.h"
#include "log.h"
#include "Launcher.h"
#include "StopWatch.h"
#include <device/haptic.h>

void create_sensor_info_layout(void *);
void init_sensor(void *data);
void destroy_sensor(void *data);

#endif /* SENSORMANAGER_H_ */
