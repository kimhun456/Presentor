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

#ifndef __BT_CHAT_ROOM_H__
#define __BT_CHAT_ROOM_H__

#include "Launcher.h"

void bt_chat_room_layout_create(appdata_s *ad);
void bt_button_layout_create(appdata_s *ad);

void _next_message_send(appdata_s *ad);
void _prev_message_send(appdata_s *ad);


#endif /* __CHAT_ROOM_H__ */
