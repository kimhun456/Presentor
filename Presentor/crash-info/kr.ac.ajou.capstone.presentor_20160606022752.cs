S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.4
Build-Number: R735SKSU1BPD1
Build-Date: 2016.04.06 15:13:39

Crash Information
Process Name: presentor
PID: 5281
Date: 2016-06-06 02:27:52+0900
Executable File Path: /opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5281, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbe855ef4
r2   = 0x00000fe4, r3   = 0xb605dc4c
r4   = 0xb5baf351, r5   = 0x401ccccd
r6   = 0xbe855f34, r7   = 0xbe855f10
r8   = 0x00000041, r9   = 0xb6c71824
r10  = 0xb8eea780, fp   = 0x00000000
ip   = 0xb602d629, sp   = 0xbe855eb8
lr   = 0xb5baf3d1, pc   = 0xb5baf3d2
cpsr = 0x60000030

Memory Information
MemTotal:   407572 KB
MemFree:      8972 KB
Buffers:     17516 KB
Cached:      84060 KB
VmPeak:      85828 KB
VmSize:      83664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18264 KB
VmRSS:       18264 KB
VmData:      23728 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       25724 KB
VmPTE:          58 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 5281 TID = 5281
5281 5362 5363 

Maps Information
b2053000 b2057000 r-xp /usr/lib/libogg.so.0.7.1
b205f000 b2081000 r-xp /usr/lib/libvorbis.so.0.4.3
b2089000 b2091000 r-xp /usr/lib/libmdm-common.so.1.0.89
b2092000 b20d5000 r-xp /usr/lib/libsndfile.so.1.0.25
b20e2000 b212a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b212b000 b2130000 r-xp /usr/lib/libjson.so.0.0.1
b2138000 b2169000 r-xp /usr/lib/libmdm.so.1.1.85
b2171000 b2179000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b2188000 b2198000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
b21b9000 b21bc000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b21c4000 b21fc000 r-xp /usr/lib/libpulse.so.0.16.2
b21fd000 b225e000 r-xp /usr/lib/libasound.so.2.0.0
b2268000 b226b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b2273000 b2278000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b2280000 b2299000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b22a2000 b22a6000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b22af000 b22b9000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b22c5000 b22ca000 r-xp /usr/lib/libmmfsession.so.0.0.0
b22d2000 b22e8000 r-xp /usr/lib/libmmfsound.so.0.1.0
b22fa000 b2301000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2309000 b2313000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.50
b231b000 b231d000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
b2325000 b2326000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b232e000 b2335000 r-xp /usr/lib/libfeedback.so.0.1.4
b233e000 b233f000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b2348000 b2b47000 rwxp [stack:5363]
b2b4e000 b2bd5000 rw-s anon_inode:dmabuf
b2bd5000 b2c5c000 rw-s anon_inode:dmabuf
b2c5c000 b2ce3000 rw-s anon_inode:dmabuf
b2ce3000 b2d6a000 rw-s anon_inode:dmabuf
b30a8000 b38a7000 rwxp [stack:5362]
b38a7000 b38be000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b38cb000 b38cd000 r-xp /usr/lib/libgenlock.so
b38d6000 b38d7000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b38df000 b38e1000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b38eb000 b38f0000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b38f8000 b3903000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3c3d000 b3d07000 r-xp /usr/lib/libCOREGL.so.4.0
b3d18000 b3d1d000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3d25000 b3d46000 r-xp /usr/lib/libexif.so.12.3.3
b3d59000 b3d5e000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3d66000 b3d6b000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3d74000 b3d7d000 r-xp /usr/lib/libresourced.so.0.2.86
b3d85000 b3d86000 r-xp /usr/lib/librd-network.so.0.2.86
b5315000 b5322000 r-xp /usr/lib/libail.so.0.1.0
b532b000 b5332000 r-xp /usr/lib/libminizip.so.1.0.0
b533a000 b533c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b5344000 b534b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b5354000 b5356000 r-xp /usr/lib/libdri2.so.0.0.0
b535e000 b5366000 r-xp /usr/lib/libdrm.so.2.4.0
b536e000 b536f000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5378000 b537b000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b5383000 b5467000 r-xp /usr/lib/libicuuc.so.51.1
b547c000 b55b9000 r-xp /usr/lib/libicui18n.so.51.1
b55c9000 b55e5000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b55ee000 b55f4000 r-xp /usr/lib/libxcb-render.so.0.0.0
b55fc000 b55fd000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5606000 b5609000 r-xp /usr/lib/libEGL.so.1.4
b5611000 b561f000 r-xp /usr/lib/libGLESv2.so.2.0
b5628000 b562f000 r-xp /usr/lib/libtbm.so.1.0.0
b5637000 b5658000 r-xp /usr/lib/libui-extension.so.0.1.0
b5661000 b5673000 r-xp /usr/lib/libtts.so
b567b000 b5682000 r-xp /usr/lib/libsensord-share.so
b568a000 b5692000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b569a000 b56a0000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b56a8000 b5760000 r-xp /usr/lib/libcairo.so.2.11200.14
b576b000 b577d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b5785000 b57a3000 r-xp /usr/lib/libsensor.so.1.1.0
b57ad000 b57c6000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b57ce000 b5806000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b5807000 b580c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b5814000 b5835000 r-xp /usr/lib/libefl-extension.so.0.1.0
b583d000 b5845000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b5846000 b584a000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b5853000 b5888000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
b5a2f000 b5a39000 r-xp /lib/libnss_files-2.13.so
b5a42000 b5b11000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5b27000 b5b4b000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5b54000 b5b5a000 r-xp /usr/lib/libappsvc.so.0.1.0
b5b62000 b5b64000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5b6d000 b5b71000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b7d000 b5b88000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b5b90000 b5b92000 r-xp /usr/lib/libiniparser.so.0
b5b9b000 b5ba0000 r-xp /usr/lib/libappcore-common.so.1.1
b5ba9000 b5bb1000 r-xp /opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor
b5bb2000 b5bb6000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5bc3000 b5bc5000 r-xp /usr/lib/libXau.so.6.0.0
b5bce000 b5bd5000 r-xp /lib/libcrypt-2.13.so
b5c05000 b5c07000 r-xp /usr/lib/libiri.so
b5c0f000 b5db7000 r-xp /usr/lib/libcrypto.so.1.0.0
b5dd0000 b5e1d000 r-xp /usr/lib/libssl.so.1.0.0
b5e2a000 b5e58000 r-xp /usr/lib/libidn.so.11.5.44
b5e60000 b5e69000 r-xp /usr/lib/libcares.so.2.1.0
b5e72000 b5e85000 r-xp /usr/lib/libxcb.so.1.1.0
b5e8e000 b5e90000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e99000 b5e9b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ea4000 b5f70000 r-xp /usr/lib/libxml2.so.2.7.8
b5f7d000 b5f7f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f87000 b5f8c000 r-xp /usr/lib/libffi.so.5.0.10
b5f94000 b5f95000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f9e000 b5fa9000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5fb1000 b5fb4000 r-xp /lib/libattr.so.1.1.0
b5fbc000 b6050000 r-xp /usr/lib/libstdc++.so.6.0.16
b6063000 b6080000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b6088000 b60a0000 r-xp /usr/lib/libpng12.so.0.50.0
b60a9000 b60bf000 r-xp /lib/libexpat.so.1.5.2
b60c9000 b610d000 r-xp /usr/lib/libcurl.so.4.3.0
b6116000 b6120000 r-xp /usr/lib/libXext.so.6.4.0
b6129000 b612d000 r-xp /usr/lib/libXtst.so.6.1.0
b6135000 b613b000 r-xp /usr/lib/libXrender.so.1.3.0
b6144000 b614a000 r-xp /usr/lib/libXrandr.so.2.2.0
b6152000 b6153000 r-xp /usr/lib/libXinerama.so.1.0.0
b615c000 b6165000 r-xp /usr/lib/libXi.so.6.1.0
b616d000 b6170000 r-xp /usr/lib/libXfixes.so.3.1.0
b6178000 b617a000 r-xp /usr/lib/libXgesture.so.7.0.0
b6182000 b6184000 r-xp /usr/lib/libXcomposite.so.1.0.0
b618d000 b618f000 r-xp /usr/lib/libXdamage.so.1.1.0
b6197000 b619e000 r-xp /usr/lib/libXcursor.so.1.0.2
b61a6000 b61a9000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61b1000 b61b5000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61be000 b61c3000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61cd000 b62ae000 r-xp /usr/lib/libX11.so.6.3.0
b62b9000 b62dc000 r-xp /usr/lib/libjpeg.so.8.0.2
b62f4000 b630a000 r-xp /lib/libz.so.1.2.5
b6312000 b6387000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6391000 b63a7000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b63b0000 b63e4000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b63ed000 b64c0000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b64cb000 b64db000 r-xp /lib/libresolv-2.13.so
b64df000 b655b000 r-xp /usr/lib/libgcrypt.so.20.0.3
b6567000 b657f000 r-xp /usr/lib/liblzma.so.5.0.3
b6588000 b658b000 r-xp /lib/libcap.so.2.21
b6593000 b65be000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b65c6000 b65c7000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b65cf000 b65d5000 r-xp /usr/lib/libecore_imf.so.1.7.99
b65dd000 b65f4000 r-xp /usr/lib/liblua-5.1.so
b65fe000 b6605000 r-xp /usr/lib/libembryo.so.1.7.99
b660d000 b6613000 r-xp /lib/librt-2.13.so
b661c000 b6672000 r-xp /usr/lib/libpixman-1.so.0.28.2
b667f000 b66d5000 r-xp /usr/lib/libfreetype.so.6.11.3
b66e1000 b6709000 r-xp /usr/lib/libfontconfig.so.1.8.0
b670b000 b6748000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6751000 b6764000 r-xp /usr/lib/libfribidi.so.0.3.1
b676c000 b6786000 r-xp /usr/lib/libecore_con.so.1.7.99
b678f000 b6798000 r-xp /usr/lib/libedbus.so.1.7.99
b67a0000 b67f0000 r-xp /usr/lib/libecore_x.so.1.7.99
b67f3000 b67f7000 r-xp /usr/lib/libvconf.so.0.2.45
b67ff000 b6810000 r-xp /usr/lib/libecore_input.so.1.7.99
b6818000 b681d000 r-xp /usr/lib/libecore_file.so.1.7.99
b6825000 b6847000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6850000 b6891000 r-xp /usr/lib/libeina.so.1.7.99
b689a000 b68b3000 r-xp /usr/lib/libeet.so.1.7.99
b68c4000 b692d000 r-xp /lib/libm-2.13.so
b6936000 b693c000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b6945000 b6948000 r-xp /usr/lib/libproc-stat.so.0.2.86
b6950000 b6972000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b697a000 b697f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6987000 b69b1000 r-xp /usr/lib/libdbus-1.so.3.8.12
b69ba000 b69d1000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b69d9000 b69e4000 r-xp /lib/libunwind.so.8.0.1
b6a11000 b6a4d000 r-xp /usr/lib/libsystemd.so.0.4.0
b6a56000 b6b71000 r-xp /lib/libc-2.13.so
b6b7f000 b6b87000 r-xp /lib/libgcc_s-4.6.so.1
b6b88000 b6b8b000 r-xp /usr/lib/libsmack.so.1.0.0
b6b93000 b6b99000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ba1000 b6c71000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6c72000 b6ccf000 r-xp /usr/lib/libedje.so.1.7.99
b6cd9000 b6cf0000 r-xp /usr/lib/libecore.so.1.7.99
b6d07000 b6dd5000 r-xp /usr/lib/libevas.so.1.7.99
b6dfa000 b6f35000 r-xp /usr/lib/libelementary.so.1.7.99
b6f4b000 b6f5f000 r-xp /lib/libpthread-2.13.so
b6f6a000 b6f6c000 r-xp /usr/lib/libdlog.so.0.0.0
b6f74000 b6f77000 r-xp /usr/lib/libbundle.so.0.1.22
b6f7f000 b6f81000 r-xp /lib/libdl-2.13.so
b6f8a000 b6f96000 r-xp /usr/lib/libaul.so.0.1.0
b6fa8000 b6fad000 r-xp /usr/lib/libappcore-efl.so.1.1
b6fb6000 b6fba000 r-xp /usr/lib/libsys-assert.so
b6fc3000 b6fe0000 r-xp /lib/ld-2.13.so
b6fe9000 b6fee000 r-xp /usr/bin/launchpad-loader
b8dfa000 b9058000 rw-p [heap]
be836000 be857000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5281)
Call Stack Count: 15
 0: on_sensor_event(void*, sensor_event_s*, void*) + 0x81 (0xb5baf3d2) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x63d2
 1: (0xb5847775) [/usr/lib/libcapi-system-sensor.so.0] + 0x1775
 2: (0xb5795a89) [/usr/lib/libsensor.so.1] + 0x10a89
 3: (0xb6bd4fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 4: g_main_context_dispatch + 0xbc (0xb6bd67a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 5: (0xb6ce9d57) [/usr/lib/libecore.so.1] + 0x10d57
 6: (0xb6ce4b8f) [/usr/lib/libecore.so.1] + 0xbb8f
 7: (0xb6ce5541) [/usr/lib/libecore.so.1] + 0xc541
 8: ecore_main_loop_begin + 0x30 (0xb6ce58b9) [/usr/lib/libecore.so.1] + 0xc8b9
 9: appcore_efl_main + 0x20e (0xb6fab503) [/usr/lib/libappcore-efl.so.1] + 0x3503
10: ui_app_main + 0xb0 (0xb5bb4421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
11: main + 0x11a (0xb5bacf4f) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x3f4f
12: (0xb6fea99b) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x199b
13: __libc_start_main + 0x114 (0xb6a6d82c) [/lib/libc.so.6] + 0x1782c
14: (0xb6fead10) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x1d10
End of Call Stack

Package Information
Package Name: kr.ac.ajou.capstone.presentor
Package ID : kr.ac.ajou.capstone.presentor
Version: 1.0.0
Package Type: rpm
App Name: Presentor
App ID: kr.ac.ajou.capstone.presentor
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
-06 02:27:43.780+0900 W/WATCH_CORE( 1247): appcore-watch.c: __signal_process_manager_handler(1164) > process_manager_signal
06-06 02:27:43.780+0900 I/WATCH_CORE( 1247): appcore-watch.c: __signal_process_manager_handler(1180) > Call the time_tick_cb
06-06 02:27:43.780+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:43.780+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:43.780+0900 I/watchface-app( 1247): watchface.cpp: OnAppTimeTick(626) > set force update!!
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(0)
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(458) > state: 0 -> 1
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): main.c: _window_visibility_cb(1200) > Window [0x2A00003] is now visible(0)
06-06 02:27:43.800+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: RESUME State: PAUSED
06-06 02:27:43.800+0900 I/CAPI_APPFW_APPLICATION( 1197): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): main.c: _appcore_resume_cb(683) > appcore resume
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): main.c: home_resume(735) > clock/widget resumed
06-06 02:27:43.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:43.800+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 0
06-06 02:27:43.800+0900 E/wnotib  ( 1197): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-06 02:27:43.800+0900 W/wnotib  ( 1197): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-06 02:27:43.800+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
06-06 02:27:43.810+0900 W/WATCH_CORE( 1247): appcore-watch.c: __widget_resume(1013) > widget_resume
06-06 02:27:43.810+0900 E/watchface-app( 1247): watchface.cpp: OnAppResume(595) > 
06-06 02:27:43.810+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:43.810+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:44.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:44.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:44.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.800+0900 E/CAPI_APPFW_APP_CONTROL( 1400): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-06 02:27:44.800+0900 W/MUSIC_CONTROL_SERVICE( 1400): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1400]   [com.samsung.w-home]register msg port [true][0m
06-06 02:27:44.800+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 14
06-06 02:27:44.810+0900 W/AUL_AMD (  921): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1197
06-06 02:27:44.810+0900 W/MUSIC_CONTROL_SERVICE( 1400): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1400]   [MUSIC_PLAYER_EVENT][0m
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:44.830+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.830+0900 W/MUSIC_CONTROL_SERVICE( 1400): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1400]   [MUSIC_PLAYER_EVENT][0m
06-06 02:27:44.830+0900 W/W_HOME  ( 1197): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-06 02:27:44.830+0900 E/W_HOME  ( 1197): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.840+0900 W/W_HOME  ( 1197): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
06-06 02:27:44.840+0900 E/W_HOME  ( 1197): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
06-06 02:27:44.840+0900 I/TIZEN_N_SOUND_MANAGER( 1400): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=7, ret=0x0
06-06 02:27:44.840+0900 W/TIZEN_N_SOUND_MANAGER( 1400): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.840+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:44.850+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:45.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:45.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:46.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:46.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:46.540+0900 I/GESTURE (  236): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-06 02:27:46.580+0900 W/W_HOME  ( 1197): home_navigation.c: _is_rightedge(188) > (360 360) not right edge: 0 0 0xb86d0c18 -> 360 0 0xafd762b0
06-06 02:27:46.580+0900 W/W_HOME  ( 1197): event_manager.c: _home_scroll_cb(564) > scroll,start
06-06 02:27:46.590+0900 W/W_HOME  ( 1197): event_manager.c: _clock_view_obscured_cb(621) > state: 1 -> 0
06-06 02:27:46.590+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 1, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:46.590+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.590+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.610+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-06 02:27:46.630+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.630+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.630+0900 W/W_HOME  ( 1197): index.c: index_show(299) > is_paused:0 show VI:1 visibility:0 vi:(nil)
06-06 02:27:46.640+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.640+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.660+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.660+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.690+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.690+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.700+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.700+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.710+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.710+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.730+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.730+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.750+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(2955) > tobj_item_01 is null
06-06 02:27:46.750+0900 I/ELM_RPANEL( 1197): elm-rpanel.c: _panel_swap_effect(3010) > tobj_item_02 is null
06-06 02:27:46.750+0900 W/wnotib  ( 1197): w-notification-board-noti-manager.c: wnotib_noti_manager_do_postponed_job(1699) > No postponed update.
06-06 02:27:46.750+0900 I/efl-extension( 1197): efl_extension_circle_object_scroller.c: _eext_circle_object_scroller_scroll_animatioin_stop_cb(501) > [0xb8665cc8 : elm_scroller] CurrentPage(2)
06-06 02:27:46.770+0900 W/WATCH_CORE( 1247): appcore-watch.c: __widget_pause(1002) > widget_pause
06-06 02:27:46.770+0900 E/watchface-app( 1247): watchface.cpp: OnAppPause(587) > 
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.770+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:46.880+0900 W/W_HOME  ( 1197): event_manager.c: _home_scroll_cb(564) > scroll,done
06-06 02:27:47.270+0900 E/EFL     ( 1269): evas_main<1269> evas_object_main.c:1358 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 02:27:47.270+0900 E/EFL     ( 1269): evas_main<1269> evas_object_main.c:1363 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 02:27:47.270+0900 E/EFL     ( 1269): evas_main<1269> evas_object_main.c:1368 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 02:27:47.340+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 0
06-06 02:27:47.340+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(1702) > caller pid : 1269
06-06 02:27:47.340+0900 I/AUL_AMD (  921): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
06-06 02:27:47.350+0900 W/AUL_AMD (  921): amd_launch.c: __nofork_processing(1145) > __nofork_processing, cmd: 0, pid: 1197
06-06 02:27:47.350+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: RESET State: RUNNING
06-06 02:27:47.350+0900 I/CAPI_APPFW_APPLICATION( 1197): app_main.c: app_appcore_reset(245) > app_appcore_reset
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): main.c: _app_control(1737) > Service value : launch_apps
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): move.c: move_move_to_apps(216) > move to apps
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): rotary.c: rotary_attach(138) > rotary_attach:0xb8726048
06-06 02:27:47.350+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8726048, elm_layout, _activated_obj : 0xb8668180, activated : 1
06-06 02:27:47.350+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): event_manager.c: _move_module_anim_start_cb(635) > state: 0 -> 1
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.350+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.360+0900 W/AUL_AMD (  921): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(1197), cmd(0)
06-06 02:27:47.360+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(479) > Legacy lifecycle: 1
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): event_manager.c: _apptray_visibility_cb(578) > apps,show,start
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 0
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): noti_broker.c: _apptray_visibility_cb(793) > apps,show,start
06-06 02:27:47.360+0900 W/W_HOME  ( 1197): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80002
06-06 02:27:47.360+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80002
06-06 02:27:47.360+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_view_event_handler(1291) > Unhandled type: 0x80002
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _move_module_anim_end_cb(649) > state: 1 -> 0
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:3, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): rotary.c: rotary_deattach(156) > rotary_deattach:0xb8726048
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xb8726048, elm_layout, func : 0xb6e94709
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8668180, elm_box, _activated_obj : 0xb8726048, activated : 1
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-06 02:27:47.650+0900 E/wnotib  ( 1197): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-06 02:27:47.650+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _apptray_visibility_cb(578) > apps,show
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _apptray_visibility_cb(596) > state: 1 -> 1
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): main.c: home_pause(762) > clock/widget paused
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:47.650+0900 W/APPS    ( 1197): apps_main.c: _time_changed_cb(295) >  date : 6->6
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): rotary.c: rotary_attach(138) > rotary_attach:0xafd4d1e8
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xafd4d1e8, elm_layout, _activated_obj : 0xb8668180, activated : 1
06-06 02:27:47.650+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): noti_broker.c: _apptray_visibility_cb(793) > apps,show
06-06 02:27:47.650+0900 W/W_HOME  ( 1197): noti_broker.c: noti_broker_event_fire_to_plugin(1011) > source:1 event:80000
06-06 02:27:47.650+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_view_event_handler(1202) > Home view event: 0x80000
06-06 02:27:47.650+0900 I/wnotib  ( 1197): w-notification-board-noti-manager.c: wnotib_noti_manager_app_tray_changed(1705) > is_app_tray_displayed: 1
06-06 02:27:47.650+0900 E/APPS    ( 1197): apps_main.c: apps_main_resume(627) >  resumed already
06-06 02:27:47.660+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
06-06 02:27:47.660+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
06-06 02:27:47.660+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
06-06 02:27:47.660+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
06-06 02:27:47.820+0900 W/W_HOME  ( 1197): index.c: index_hide(337) > hide VI:1 visibility:1 vi:(nil)
06-06 02:27:48.300+0900 I/GESTURE (  236): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=0, disable_apps_back_gesture=1, disable back key!!!
06-06 02:27:48.300+0900 W/APPS    ( 1197): AppsViewNecklace.cpp: touchPressed(1264) >  TOUCH [181, 213]
06-06 02:27:48.350+0900 W/AUL_AMD (  921): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-06 02:27:48.350+0900 W/AUL_AMD (  921): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
06-06 02:27:48.440+0900 W/APPS    ( 1197): AppsViewNecklace.cpp: touchReleased(1583) >  TOUCH [181, 213]->[180, 208]
06-06 02:27:48.440+0900 W/APPS    ( 1197): AppsItem.cpp: onItemClicked(390) >  onItemClicked[0,30]
06-06 02:27:48.440+0900 E/APPS    ( 1197): effect.c: apps_effect_play_sound(86) >  effect_info.sound_status: [0]
06-06 02:27:48.440+0900 W/APPS    ( 1197): AppsItem.cpp: onItemClicked(410) >  item(Presentor) launched, open(0)
06-06 02:27:48.440+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 0
06-06 02:27:48.450+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(1702) > caller pid : 1197
06-06 02:27:48.450+0900 I/AUL_AMD (  921): amd_launch.c: __check_app_control_privilege(1592) > Skip the privilege check in case of preloaded apps
06-06 02:27:48.460+0900 E/RESOURCED(  926): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data kr.ac.ajou.capstone.presentor, table num : 2
06-06 02:27:48.460+0900 E/RESOURCED(  926): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-06 02:27:48.460+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(2080) > pad pid(-5)
06-06 02:27:48.460+0900 W/AUL_PAD ( 1703): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
06-06 02:27:48.460+0900 W/AUL_PAD ( 1703): launchpad.c: __send_result_to_caller(272) > Check app launching
06-06 02:27:48.510+0900 I/efl-extension( 5281): efl_extension.c: eext_mod_init(40) > Init
06-06 02:27:48.510+0900 I/UXT     ( 5281): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-06 02:27:48.510+0900 I/CAPI_APPFW_APPLICATION( 5281): app_main.c: ui_app_main(704) > app_efl_main
06-06 02:27:48.520+0900 I/CAPI_APPFW_APPLICATION( 5281): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-06 02:27:48.570+0900 E/AUL     (  921): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-06 02:27:48.570+0900 E/RESOURCED(  926): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : kr.ac.ajou.capstone.presentor
06-06 02:27:48.630+0900 D/PRESENTOR( 5281): window size : 360x360(0, 0)
06-06 02:27:48.680+0900 I/efl-extension( 5281): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb8f26a08]'s widget[0xb8f38a88] to elm_conformant widget[0xb8f04098]
06-06 02:27:48.680+0900 I/efl-extension( 5281): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb8f26a08 = w: 0 h: 0  obj 0xb8f38a88 w: 1 h: 1
06-06 02:27:48.810+0900 E/E17     (  557): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x05200002)
06-06 02:27:48.830+0900 W/W_HOME  ( 1197): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
06-06 02:27:48.830+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.830+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.830+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.830+0900 W/W_HOME  ( 1197): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 0
06-06 02:27:48.830+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4505) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=1, Apps display 
06-06 02:27:48.830+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
06-06 02:27:48.860+0900 I/APP_CORE( 5281): appcore-efl.c: __do_app(429) > [APP 5281] Event: RESET State: CREATED
06-06 02:27:48.860+0900 I/CAPI_APPFW_APPLICATION( 5281): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-06 02:27:48.870+0900 I/APP_CORE( 5281): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
06-06 02:27:48.870+0900 I/APP_CORE( 5281): appcore-efl.c: __do_app(474) > [APP 5281] Initial Launching, call the resume_cb
06-06 02:27:48.870+0900 I/CAPI_APPFW_APPLICATION( 5281): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-06 02:27:48.870+0900 D/PRESENTOR( 5281): RESUMED AND BT_MGR_RELEASE
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-adapter.c: bt_adapter_unset_state_changed_cb(842) > [bt_adapter_unset_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-adapter.c: bt_adapter_unset_device_discovery_state_changed_cb(898) > [bt_adapter_unset_device_discovery_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-device.c: bt_device_unset_service_searched_cb(369) > [bt_device_unset_service_searched_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-socket.c: bt_socket_unset_data_received_cb(270) > [bt_socket_unset_data_received_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-socket.c: bt_socket_unset_connection_state_changed_cb(304) > [bt_socket_unset_connection_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.870+0900 E/CAPI_NETWORK_BLUETOOTH( 5281): bluetooth-common.c: bt_deinitialize(82) > [bt_deinitialize] NOT_INITIALIZED(0xfe400101)
06-06 02:27:48.880+0900 W/APP_CORE( 5281): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:5200002
06-06 02:27:48.880+0900 I/efl-extension( 5281): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb8f26a08 = w: 0 h: 0  obj 0xb8f38a88 w: 360 h: 360
06-06 02:27:48.880+0900 I/efl-extension( 5281): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
06-06 02:27:48.920+0900 I/APP_CORE( 5281): appcore-efl.c: __do_app(429) > [APP 5281] Event: RESUME State: RUNNING
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(1)
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): main.c: _window_visibility_cb(1200) > Window [0x2A00003] is now visible(1)
06-06 02:27:48.920+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: PAUSE State: RUNNING
06-06 02:27:48.920+0900 I/CAPI_APPFW_APPLICATION( 1197): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): main.c: _appcore_pause_cb(692) > appcore pause
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:0 clock_visible:0 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 0, apptray visibility : 1, apptray edit visibility : 0
06-06 02:27:48.920+0900 W/W_HOME  ( 1197): rotary.c: rotary_deattach(156) > rotary_deattach:0xafd4d1e8
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(235) > In
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(240) > callback del 0xafd4d1e8, elm_layout, func : 0xb6e94709
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(248) > Removed cb from callbacks
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(266) > Freed cb
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_callback_del(273) > done
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(283) > eext_rotary_object_event_activated_set : 0xb8668180, elm_box, _activated_obj : 0xafd4d1e8, activated : 1
06-06 02:27:48.920+0900 I/efl-extension( 1197): efl_extension_rotary.c: eext_rotary_object_event_activated_set(291) > Activation delete!!!!
06-06 02:27:48.920+0900 E/wnotib  ( 1197): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-06 02:27:48.920+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_scroller_event_handler(1121) > No second depth view available.
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:48.950+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:48.950+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
06-06 02:27:48.950+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4510) > [BackGestureSetProperty] atom=_E_MOVE_ENABLE_DISABLE_BACK_GESTURE, value=0, No apps display 
06-06 02:27:48.980+0900 E/CAPI_APPFW_APP_CONTROL( 1400): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-06 02:27:48.990+0900 W/MUSIC_CONTROL_SERVICE( 1400): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1400]   [com.samsung.w-home]register msg port [false][0m
06-06 02:27:49.030+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
06-06 02:27:49.030+0900 E/wnotib  ( 1197): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-06 02:27:49.050+0900 W/APPS    ( 1197): AppsViewNecklace.cpp: onPausedIdlerCb(4559) >  elm_cache_all_flush
06-06 02:27:49.320+0900 E/AUL     (  921): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-06 02:27:49.450+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: MEM_FLUSH State: PAUSED
06-06 02:27:49.620+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 14
06-06 02:27:49.650+0900 W/AUL_AMD (  921): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5281
06-06 02:27:49.650+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 12
06-06 02:27:49.840+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-06 02:27:49.840+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-06 02:27:49.860+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-06 02:27:49.860+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-06 02:27:49.890+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-06 02:27:49.890+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-06 02:27:49.890+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-06 02:27:49.890+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-06 02:27:49.890+0900 E/EFL     ( 5334): elementary<5334> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-06 02:27:49.920+0900 E/EFL     ( 5334): elementary<5334> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-06 02:27:49.930+0900 E/EFL     ( 5334): elementary<5334> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-06 02:27:49.930+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-06 02:27:49.970+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-06 02:27:49.980+0900 E/EFL     ( 5334): elementary<5334> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-06 02:27:49.980+0900 I/AUL_PAD ( 5334): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-06 02:27:52.190+0900 D/PRESENTOR( 5281): _gestrue_cb
06-06 02:27:52.510+0900 D/PRESENTOR( 5281): 11
06-06 02:27:52.650+0900 W/CRASH_MANAGER( 5303): worker.c: worker_job(1199) > 1105281707265146514767
