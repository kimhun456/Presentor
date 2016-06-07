/*
 * StopWatch.h
 *
 *  Created on: Jun 5, 2016
 *      Author: HyunJae
 */

#ifndef STOPWATCH_H_
#define STOPWATCH_H_

#include "Launcher.h"


#include <string>
#include <device/haptic.h>


// init_timer
void
init_timer(appdata_s *ad);


void
set_clock_layout(appdata_s *ad);

void
haptic(int count);

#endif /* STOPWATCH_H_ */
