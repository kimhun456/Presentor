S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.4
Build-Number: R735SKSU1BPD1
Build-Date: 2016.04.06 15:13:39

Crash Information
Process Name: presentor
PID: 5282
Date: 2016-06-06 02:27:43+0900
Executable File Path: /opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 5282, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbeb4ee7c
r2   = 0x00000fe4, r3   = 0xb6b9fc4c
r4   = 0xb6f4d351, r5   = 0xc28f3852
r6   = 0xbeb4eebc, r7   = 0xbeb4ee98
r8   = 0x00000041, r9   = 0xb68ad824
r10  = 0xb8b23d58, fp   = 0x00000000
ip   = 0xb6b6f629, sp   = 0xbeb4ee40
lr   = 0xb6f4d3d1, pc   = 0xb6f4d3d2
cpsr = 0x60000030

Memory Information
MemTotal:   407572 KB
MemFree:      7240 KB
Buffers:     16356 KB
Cached:      83208 KB
VmPeak:     114096 KB
VmSize:     110244 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       25428 KB
VmRSS:       25428 KB
VmData:      38100 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       65452 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 5282 TID = 5282
5282 5284 5296 5297 

Maps Information
b0880000 b0884000 r-xp /usr/lib/libogg.so.0.7.1
b088b000 b088c000 rwxp /usr/lib/libogg.so.0.7.1
b088c000 b08ae000 r-xp /usr/lib/libvorbis.so.0.4.3
b08b5000 b08b6000 rwxp /usr/lib/libvorbis.so.0.4.3
b08b6000 b08be000 r-xp /usr/lib/libmdm-common.so.1.0.89
b08be000 b08bf000 rwxp /usr/lib/libmdm-common.so.1.0.89
b08bf000 b0902000 r-xp /usr/lib/libsndfile.so.1.0.25
b0909000 b090b000 rwxp /usr/lib/libsndfile.so.1.0.25
b090f000 b0957000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b0957000 b0958000 rwxp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b0958000 b095d000 r-xp /usr/lib/libjson.so.0.0.1
b0964000 b0965000 rwxp /usr/lib/libjson.so.0.0.1
b0965000 b0996000 r-xp /usr/lib/libmdm.so.1.1.85
b099d000 b099e000 rwxp /usr/lib/libmdm.so.1.1.85
b099e000 b09a6000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b09ad000 b09ae000 rwxp /usr/lib/lib_DNSe_NRSS_ver225.so
b09b5000 b09c5000 r-xp /usr/lib/lib_SamsungRec_TizenV04015.so
b09c5000 b09c9000 rwxp /usr/lib/lib_SamsungRec_TizenV04015.so
b09e6000 b09e9000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b09f0000 b09f1000 rwxp /usr/lib/libsyspopup_caller.so.0.1.0
b09f1000 b0a29000 r-xp /usr/lib/libpulse.so.0.16.2
b0a29000 b0a2a000 rwxp /usr/lib/libpulse.so.0.16.2
b0a2a000 b0a8b000 r-xp /usr/lib/libasound.so.2.0.0
b0a92000 b0a95000 rwxp /usr/lib/libasound.so.2.0.0
b0a95000 b0a98000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b0a9f000 b0aa0000 rwxp /usr/lib/libpulse-simple.so.0.0.4
b0aa0000 b0aa5000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b0aac000 b0aad000 rwxp /usr/lib/libascenario-0.2.so.0.0.0
b0aad000 b0ac6000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b0ace000 b0acf000 rwxp /usr/lib/libavsysaudio.so.0.0.1
b0acf000 b0ad3000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b0adb000 b0adc000 rwxp /usr/lib/libmmfsoundcommon.so.0.0.0
b0adc000 b0ae6000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b0aee000 b0aef000 rwxp /usr/lib/libaudio-session-mgr.so.0.0.0
b0af2000 b0af7000 r-xp /usr/lib/libmmfsession.so.0.0.0
b0afe000 b0aff000 rwxp /usr/lib/libmmfsession.so.0.0.0
b0aff000 b0b15000 r-xp /usr/lib/libmmfsound.so.0.1.0
b0b1d000 b0b1e000 rwxp /usr/lib/libmmfsound.so.0.1.0
b0b27000 b0b2e000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b0b35000 b0b36000 rwxp /usr/lib/libmmfcommon.so.0.0.0
b0b36000 b0b40000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.1.50
b0b47000 b0b48000 rwxp /usr/lib/libcapi-media-sound-manager.so.0.1.50
b0b48000 b0b4a000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.10
b0b51000 b0b52000 rwxp /usr/lib/libcapi-media-wav-player.so.0.1.10
b0b52000 b0b53000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b0b5a000 b0b5b000 rwxp /usr/lib/libmmfkeysound.so.0.0.0
b0b5b000 b0b62000 r-xp /usr/lib/libfeedback.so.0.1.4
b0b6a000 b0b6b000 rwxp /usr/lib/libfeedback.so.0.1.4
b0b6c000 b136b000 rwxp [stack:5297]
b136b000 b13f2000 rwxs anon_inode:dmabuf
b13f2000 b1479000 rwxs anon_inode:dmabuf
b1479000 b1500000 rwxs anon_inode:dmabuf
b1500000 b1520000 rwxs /dev/kgsl-3d0
b1520000 b1560000 rwxs /dev/kgsl-3d0
b1560000 b1561000 rwxs /dev/kgsl-3d0
b1561000 b1562000 rwxs /dev/kgsl-3d0
b1562000 b1563000 rwxs /dev/kgsl-3d0
b1563000 b1564000 rwxs /dev/kgsl-3d0
b1564000 b1565000 rwxs /dev/kgsl-3d0
b1565000 b1566000 rwxs /dev/kgsl-3d0
b1566000 b1567000 rwxs /dev/kgsl-3d0
b1567000 b15ee000 rwxs anon_inode:dmabuf
b15ee000 b1675000 rwxs anon_inode:dmabuf
b1675000 b1700000 r-xp /usr/share/fonts/BreezeSans-MediumCondensed.ttf
b181a000 b181b000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b1822000 b1823000 rwxp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b1823000 b182a000 r-xs /usr/lib/gconv/gconv-modules.cache
b182a000 b184a000 rwxs /dev/kgsl-3d0
b184a000 b184e000 rwxs /dev/kgsl-3d0
b184e000 b18da000 r-xp /usr/share/fonts/BreezeSans-RegularCondensed.ttf
b18da000 b18e9000 r-xs /opt/var/cache/fontconfig/cdc77cde135ce87b641818a103cc9edb-le32d8.cache-5
b18e9000 b18ed000 r-xs /opt/var/cache/fontconfig/a307fb9815d691addd7f142e617ee37c-le32d8.cache-5
b18ed000 b18f0000 r-xs /opt/var/cache/fontconfig/3830d5c3ddfd5cd38a049b759396e72e-le32d8.cache-5
b18f0000 b18f1000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b18f8000 b18f9000 rwxp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b197a000 b2179000 rwxp [stack:5296]
b2179000 b217b000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b2182000 b2183000 rwxp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b2183000 b219a000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b21a2000 b21a7000 rwxp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b21a7000 b2346000 r-xs /usr/share/elementary/themes/tizen-2.3-wearable-circle-HVGA.edj
b2346000 b2348000 r-xp /usr/share/locale/ko_KR/LC_MESSAGES/elementary.mo
b2348000 b234c000 rwxs /dev/kgsl-3d0
b234c000 b2350000 rwxs /dev/kgsl-3d0
b2350000 b2351000 rwxs /dev/kgsl-3d0
b2351000 b2352000 rwxs /dev/kgsl-3d0
b2352000 b2353000 rwxs /dev/kgsl-3d0
b2353000 b2354000 rwxs /dev/kgsl-3d0
b2354000 b2355000 rwxs /dev/kgsl-3d0
b2355000 b2356000 rwxs /dev/kgsl-3d0
b2356000 b2357000 rwxs /dev/kgsl-3d0
b2357000 b2358000 rwxs /dev/kgsl-3d0
b2358000 b2359000 rwxs /dev/kgsl-3d0
b2359000 b235a000 rwxs /dev/kgsl-3d0
b235a000 b235b000 rwxs /dev/kgsl-3d0
b235b000 b235c000 rwxs /dev/kgsl-3d0
b235c000 b235d000 rwxs /dev/kgsl-3d0
b235d000 b235e000 rwxs /dev/kgsl-3d0
b235e000 b235f000 rwxs /dev/kgsl-3d0
b235f000 b2360000 rwxs /dev/kgsl-3d0
b2360000 b2361000 rwxs /dev/kgsl-3d0
b2361000 b2362000 rwxs /dev/kgsl-3d0
b2362000 b2363000 rwxs /dev/kgsl-3d0
b2363000 b2364000 rwxs /dev/kgsl-3d0
b2364000 b2365000 rwxs /dev/kgsl-3d0
b2365000 b2366000 rwxs /dev/kgsl-3d0
b2366000 b2367000 rwxs /dev/kgsl-3d0
b2367000 b2368000 rwxs /dev/kgsl-3d0
b2368000 b2369000 rwxs /dev/kgsl-3d0
b2369000 b236a000 rwxs /dev/kgsl-3d0
b236a000 b236b000 rwxs /dev/kgsl-3d0
b236b000 b236c000 rwxs /dev/kgsl-3d0
b236c000 b236d000 rwxs /dev/kgsl-3d0
b236d000 b236e000 rwxs /dev/kgsl-3d0
b236e000 b236f000 rwxs /dev/kgsl-3d0
b236f000 b2370000 rwxs /dev/kgsl-3d0
b2370000 b2371000 rwxs /dev/kgsl-3d0
b2371000 b2372000 rwxs /dev/kgsl-3d0
b2372000 b2373000 rwxs /dev/kgsl-3d0
b2373000 b2374000 rwxs /dev/kgsl-3d0
b2374000 b2375000 rwxs /dev/kgsl-3d0
b2375000 b2376000 rwxs /dev/kgsl-3d0
b2376000 b2377000 rwxs /dev/kgsl-3d0
b2377000 b2378000 rwxs /dev/kgsl-3d0
b2378000 b2379000 rwxs /dev/kgsl-3d0
b2379000 b237a000 rwxs /dev/kgsl-3d0
b237a000 b237b000 rwxs /dev/kgsl-3d0
b237b000 b237c000 rwxs /dev/kgsl-3d0
b237c000 b237d000 rwxs /dev/kgsl-3d0
b237d000 b237e000 rwxs /dev/kgsl-3d0
b237e000 b237f000 rwxs /dev/kgsl-3d0
b237f000 b2380000 rwxs /dev/kgsl-3d0
b2380000 b2381000 rwxs /dev/kgsl-3d0
b2381000 b2382000 rwxs /dev/kgsl-3d0
b2382000 b2383000 rwxs /dev/kgsl-3d0
b2383000 b2384000 rwxs /dev/kgsl-3d0
b2384000 b2385000 rwxs /dev/kgsl-3d0
b2385000 b2386000 rwxs /dev/kgsl-3d0
b2386000 b2387000 rwxs /dev/kgsl-3d0
b2387000 b2388000 rwxs /dev/kgsl-3d0
b2388000 b2389000 rwxs /dev/kgsl-3d0
b2389000 b238a000 rwxs /dev/kgsl-3d0
b238a000 b238b000 rwxs /dev/kgsl-3d0
b238b000 b238c000 rwxs /dev/kgsl-3d0
b238c000 b238d000 rwxs /dev/kgsl-3d0
b238d000 b238e000 rwxs /dev/kgsl-3d0
b238e000 b238f000 rwxs /dev/kgsl-3d0
b238f000 b2390000 rwxs /dev/kgsl-3d0
b2390000 b2391000 rwxs /dev/kgsl-3d0
b2391000 b2392000 rwxs /dev/kgsl-3d0
b2392000 b2393000 rwxs /dev/kgsl-3d0
b2393000 b2394000 rwxs /dev/kgsl-3d0
b2394000 b2395000 rwxs /dev/kgsl-3d0
b2395000 b2396000 rwxs /dev/kgsl-3d0
b2396000 b2397000 rwxs /dev/kgsl-3d0
b2397000 b2398000 rwxs /dev/kgsl-3d0
b2398000 b2399000 rwxs /dev/kgsl-3d0
b2399000 b239a000 rwxs /dev/kgsl-3d0
b239a000 b239b000 rwxs /dev/kgsl-3d0
b239b000 b239c000 rwxs /dev/kgsl-3d0
b239c000 b239d000 rwxs /dev/kgsl-3d0
b239d000 b239e000 rwxs /dev/kgsl-3d0
b239e000 b239f000 rwxs /dev/kgsl-3d0
b239f000 b23a0000 rwxs /dev/kgsl-3d0
b23a0000 b23a1000 rwxs /dev/kgsl-3d0
b23a1000 b23a2000 rwxs /dev/kgsl-3d0
b23a2000 b23a3000 rwxs /dev/kgsl-3d0
b23a3000 b23a4000 rwxs /dev/kgsl-3d0
b23a4000 b23a5000 rwxs /dev/kgsl-3d0
b23a5000 b23ba000 r-xs /opt/home/app/.cache/evas_gl_common_caches/Qualcomm::OpenGL
b23bb000 b2bba000 rwxp [stack:5284]
b2bba000 b2bca000 rwxs /dev/kgsl-3d0
b2bca000 b34f6000 r-xp /usr/lib/libsc-a3xx.so
b34fe000 b3532000 rwxp /usr/lib/libsc-a3xx.so
b3743000 b3745000 r-xp /usr/lib/libgenlock.so
b374c000 b374d000 rwxp /usr/lib/libgenlock.so
b374d000 b374e000 rwxs /dev/kgsl-3d0
b374e000 b374f000 rwxs /dev/kgsl-3d0
b374f000 b3750000 rwxs /dev/kgsl-3d0
b3750000 b3754000 rwxs /dev/kgsl-3d0
b3755000 b3756000 rwxs /dev/kgsl-3d0
b3756000 b3757000 rwxs /dev/kgsl-3d0
b3757000 b3758000 rwxs /dev/kgsl-3d0
b3758000 b3759000 rwxs /dev/kgsl-3d0
b3759000 b375a000 rwxs /dev/kgsl-3d0
b375a000 b375b000 rwxs /dev/kgsl-3d0
b375b000 b375c000 rwxs /dev/kgsl-3d0
b375c000 b375d000 rwxs /dev/kgsl-3d0
b375d000 b375e000 rwxs /dev/kgsl-3d0
b375e000 b375f000 rwxs /dev/kgsl-3d0
b375f000 b3761000 rwxs /dev/kgsl-3d0
b3761000 b3763000 rwxs /dev/kgsl-3d0
b3763000 b3767000 r-xp /usr/lib/libxcb-xfixes.so.0.0.0
b376e000 b376f000 rwxp /usr/lib/libxcb-xfixes.so.0.0.0
b376f000 b3772000 r-xp /usr/lib/libxcb-dri2.so.0.0.0
b3779000 b377a000 rwxp /usr/lib/libxcb-dri2.so.0.0.0
b377a000 b377b000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b3782000 b3783000 rwxp /usr/lib/libX11-xcb.so.1.0.0
b3783000 b3786000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b378d000 b378e000 rwxp /usr/lib/libnative-buffer.so.0.1.0
b378e000 b378f000 rwxs /dev/kgsl-3d0
b378f000 b3793000 rwxs /dev/kgsl-3d0
b3793000 b3797000 rwxs /dev/kgsl-3d0
b3797000 b379c000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b37a3000 b37a4000 rwxp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b37a4000 b38df000 r-xp /usr/lib/egl/libGLESv2.so
b38e6000 b391a000 rwxp /usr/lib/egl/libGLESv2.so
b391b000 b391d000 r-xp /usr/lib/libadreno_utils.so
b3924000 b3925000 rwxp /usr/lib/libadreno_utils.so
b3927000 b394e000 r-xp /usr/lib/libgsl.so
b3955000 b3957000 rwxp /usr/lib/libgsl.so
b3957000 b3958000 rwxs /dev/kgsl-3d0
b3958000 b3959000 rwxs /dev/kgsl-3d0
b3959000 b395d000 rwxs /dev/kgsl-3d0
b395d000 b395e000 rwxs /dev/kgsl-3d0
b395e000 b3965000 r-xp /usr/lib/egl/eglsubX11.so
b396c000 b396d000 rwxp /usr/lib/egl/eglsubX11.so
b396d000 b398f000 r-xp /usr/lib/egl/libEGL.so
b3997000 b3998000 rwxp /usr/lib/egl/libEGL.so
b3998000 b3a0f000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b3a17000 b3a19000 rwxp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b3a1f000 b3b50000 r-xp /usr/share/locale/locale-archive
b3b50000 b3d50000 r-xp /usr/share/locale/locale-archive
b3d50000 b3d5a000 r-xp /lib/libnss_files-2.13.so
b3d61000 b3d62000 r-xp /lib/libnss_files-2.13.so
b3d62000 b3d63000 rwxp /lib/libnss_files-2.13.so
b3d63000 b3e32000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b3e39000 b3e48000 rwxp /usr/lib/libscim-1.0.so.8.2.3
b3e48000 b3e6c000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b3e73000 b3e75000 rwxp /usr/lib/ecore/immodules/libisf-imf-module.so
b3e75000 b3f3f000 r-xp /usr/lib/libCOREGL.so.4.0
b3f46000 b3f48000 rwxp /usr/lib/libCOREGL.so.4.0
b3f57000 b3f5c000 r-xp /usr/lib/libcapi-media-tool.so.0.1.5
b3f63000 b3f64000 rwxp /usr/lib/libcapi-media-tool.so.0.1.5
b3f64000 b3f85000 r-xp /usr/lib/libexif.so.12.3.3
b3f8c000 b3f98000 rwxp /usr/lib/libexif.so.12.3.3
b3f98000 b3f9b000 r-xp /lib/libattr.so.1.1.0
b3fa2000 b3fa3000 rwxp /lib/libattr.so.1.1.0
b3fa4000 b3fa9000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3fb0000 b3fb1000 rwxp /usr/lib/libmmutil_imgp.so.0.0.0
b3fb1000 b3fb6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fbe000 b3fbf000 rwxp /usr/lib/libmmutil_jpeg.so.0.0.0
b3fbf000 b3fc8000 r-xp /usr/lib/libresourced.so.0.2.86
b3fcf000 b3fd0000 rwxp /usr/lib/libresourced.so.0.2.86
b3fd0000 b3fd1000 r-xp /usr/lib/librd-network.so.0.2.86
b3fd8000 b3fd9000 rwxp /usr/lib/librd-network.so.0.2.86
b3fda000 b5559000 r-xp /usr/lib/libicudata.so.51.1
b5560000 b5561000 rwxp /usr/lib/libicudata.so.51.1
b5561000 b556e000 r-xp /usr/lib/libail.so.0.1.0
b5576000 b5577000 rwxp /usr/lib/libail.so.0.1.0
b5577000 b557e000 r-xp /usr/lib/libminizip.so.1.0.0
b5585000 b5586000 rwxp /usr/lib/libminizip.so.1.0.0
b5586000 b5588000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b558f000 b5590000 rwxp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b5590000 b5597000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b559f000 b55a0000 rwxp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b55a1000 b55a8000 r-xp /lib/libcrypt-2.13.so
b55af000 b55b0000 r-xp /lib/libcrypt-2.13.so
b55b0000 b55b1000 rwxp /lib/libcrypt-2.13.so
b55d8000 b55db000 r-xp /lib/libcap.so.2.21
b55e2000 b55e3000 rwxp /lib/libcap.so.2.21
b55e3000 b55e5000 r-xp /usr/lib/libiri.so
b55ec000 b55ed000 rwxp /usr/lib/libiri.so
b55ed000 b55f8000 r-xp /usr/lib/libgpg-error.so.0.15.0
b55ff000 b5600000 rwxp /usr/lib/libgpg-error.so.0.15.0
b5600000 b57a8000 r-xp /usr/lib/libcrypto.so.1.0.0
b57a8000 b57bd000 rwxp /usr/lib/libcrypto.so.1.0.0
b57c2000 b580f000 r-xp /usr/lib/libssl.so.1.0.0
b5816000 b581b000 rwxp /usr/lib/libssl.so.1.0.0
b581b000 b5849000 r-xp /usr/lib/libidn.so.11.5.44
b5850000 b5851000 rwxp /usr/lib/libidn.so.11.5.44
b5851000 b585a000 r-xp /usr/lib/libcares.so.2.1.0
b5862000 b5863000 rwxp /usr/lib/libcares.so.2.1.0
b5863000 b5865000 r-xp /usr/lib/libXau.so.6.0.0
b586c000 b586d000 rwxp /usr/lib/libXau.so.6.0.0
b586d000 b586f000 r-xp /usr/lib/libdri2.so.0.0.0
b5876000 b5877000 rwxp /usr/lib/libdri2.so.0.0.0
b5878000 b5880000 r-xp /usr/lib/libdrm.so.2.4.0
b5887000 b5888000 rwxp /usr/lib/libdrm.so.2.4.0
b5888000 b5889000 r-xp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5891000 b5892000 rwxp /usr/lib/libsecurity-privilege-checker.so.1.0.1
b5892000 b5895000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.5
b589c000 b589d000 rwxp /usr/lib/libcapi-media-image-util.so.0.3.5
b589d000 b5981000 r-xp /usr/lib/libicuuc.so.51.1
b5988000 b5992000 rwxp /usr/lib/libicuuc.so.51.1
b5996000 b5ad3000 r-xp /usr/lib/libicui18n.so.51.1
b5adb000 b5ae3000 rwxp /usr/lib/libicui18n.so.51.1
b5ae4000 b5b00000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b5b08000 b5b09000 rwxp /usr/lib/libpkgmgr-client.so.0.1.68
b5b09000 b5b0b000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5b12000 b5b13000 rwxp /usr/lib/libgmodule-2.0.so.0.3200.3
b5b13000 b5b30000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b5b37000 b5b38000 rwxp /usr/lib/libsecurity-server-commons.so.1.0.0
b5b39000 b5b3c000 r-xp /usr/lib/libsmack.so.1.0.0
b5b43000 b5b44000 rwxp /usr/lib/libsmack.so.1.0.0
b5b44000 b5b49000 r-xp /usr/lib/libffi.so.5.0.10
b5b50000 b5b51000 rwxp /usr/lib/libffi.so.5.0.10
b5b51000 b5b52000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5b59000 b5b5a000 rwxp /usr/lib/libgthread-2.0.so.0.3200.3
b5b5a000 b5b5c000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5b63000 b5b64000 rwxp /usr/lib/journal/libjournal.so.0.1.0
b5b64000 b5b74000 r-xp /lib/libresolv-2.13.so
b5b74000 b5b75000 r-xp /lib/libresolv-2.13.so
b5b75000 b5b76000 rwxp /lib/libresolv-2.13.so
b5b79000 b5bf5000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5bfc000 b5c01000 rwxp /usr/lib/libgcrypt.so.20.0.3
b5c01000 b5c19000 r-xp /usr/lib/liblzma.so.5.0.3
b5c20000 b5c21000 rwxp /usr/lib/liblzma.so.5.0.3
b5c21000 b5c65000 r-xp /usr/lib/libcurl.so.4.3.0
b5c6c000 b5c6e000 rwxp /usr/lib/libcurl.so.4.3.0
b5c6e000 b5c91000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c98000 b5c99000 rwxp /usr/lib/libjpeg.so.8.0.2
b5caa000 b5cbd000 r-xp /usr/lib/libxcb.so.1.1.0
b5cc5000 b5cc6000 rwxp /usr/lib/libxcb.so.1.1.0
b5cc6000 b5ccc000 r-xp /usr/lib/libxcb-render.so.0.0.0
b5cd3000 b5cd4000 rwxp /usr/lib/libxcb-render.so.0.0.0
b5cd4000 b5cd5000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b5cdd000 b5cde000 rwxp /usr/lib/libxcb-shm.so.0.0.0
b5cde000 b5cf6000 r-xp /usr/lib/libpng12.so.0.50.0
b5cfd000 b5cfe000 rwxp /usr/lib/libpng12.so.0.50.0
b5cfe000 b5d01000 r-xp /usr/lib/libEGL.so.1.4
b5d08000 b5d09000 rwxp /usr/lib/libEGL.so.1.4
b5d0a000 b5d18000 r-xp /usr/lib/libGLESv2.so.2.0
b5d20000 b5d21000 rwxp /usr/lib/libGLESv2.so.2.0
b5d21000 b5d22000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5d29000 b5d2a000 rwxp /usr/lib/libecore_imf_evas.so.1.7.99
b5d2a000 b5d41000 r-xp /usr/lib/liblua-5.1.so
b5d49000 b5d4a000 rwxp /usr/lib/liblua-5.1.so
b5d4a000 b5d51000 r-xp /usr/lib/libembryo.so.1.7.99
b5d58000 b5d59000 rwxp /usr/lib/libembryo.so.1.7.99
b5d59000 b5d60000 r-xp /usr/lib/libtbm.so.1.0.0
b5d67000 b5d68000 rwxp /usr/lib/libtbm.so.1.0.0
b5d69000 b5d8a000 r-xp /usr/lib/libui-extension.so.0.1.0
b5d92000 b5d93000 rwxp /usr/lib/libui-extension.so.0.1.0
b5d93000 b5da5000 r-xp /usr/lib/libtts.so
b5dac000 b5dad000 rwxp /usr/lib/libtts.so
b5dad000 b5dc3000 r-xp /lib/libz.so.1.2.5
b5dca000 b5dcb000 rwxp /lib/libz.so.1.2.5
b5dcb000 b5de1000 r-xp /lib/libexpat.so.1.5.2
b5de9000 b5deb000 rwxp /lib/libexpat.so.1.5.2
b5deb000 b5dee000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5df5000 b5df6000 rwxp /usr/lib/libecore_input_evas.so.1.7.99
b5df7000 b5dfb000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5e03000 b5e04000 rwxp /usr/lib/libecore_ipc.so.1.7.99
b5e04000 b5e09000 r-xp /usr/lib/libecore_fb.so.1.7.99
b5e10000 b5e12000 rwxp /usr/lib/libecore_fb.so.1.7.99
b5e12000 b5e1c000 r-xp /usr/lib/libXext.so.6.4.0
b5e24000 b5e25000 rwxp /usr/lib/libXext.so.6.4.0
b5e25000 b5e29000 r-xp /usr/lib/libXtst.so.6.1.0
b5e30000 b5e31000 rwxp /usr/lib/libXtst.so.6.1.0
b5e31000 b5e37000 r-xp /usr/lib/libXrender.so.1.3.0
b5e3e000 b5e3f000 rwxp /usr/lib/libXrender.so.1.3.0
b5e40000 b5e46000 r-xp /usr/lib/libXrandr.so.2.2.0
b5e4d000 b5e4e000 rwxp /usr/lib/libXrandr.so.2.2.0
b5e4e000 b5e4f000 r-xp /usr/lib/libXinerama.so.1.0.0
b5e57000 b5e58000 rwxp /usr/lib/libXinerama.so.1.0.0
b5e58000 b5e5b000 r-xp /usr/lib/libXfixes.so.3.1.0
b5e62000 b5e63000 rwxp /usr/lib/libXfixes.so.3.1.0
b5e63000 b5e65000 r-xp /usr/lib/libXgesture.so.7.0.0
b5e6c000 b5e6d000 rwxp /usr/lib/libXgesture.so.7.0.0
b5e6d000 b5e6f000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5e76000 b5e77000 rwxp /usr/lib/libXcomposite.so.1.0.0
b5e77000 b5e79000 r-xp /usr/lib/libXdamage.so.1.1.0
b5e80000 b5e81000 rwxp /usr/lib/libXdamage.so.1.1.0
b5e82000 b5e89000 r-xp /usr/lib/libXcursor.so.1.0.2
b5e90000 b5e91000 rwxp /usr/lib/libXcursor.so.1.0.2
b5e91000 b5e98000 r-xp /usr/lib/libsensord-share.so
b5e9f000 b5ea0000 rwxp /usr/lib/libsensord-share.so
b5ea0000 b5ea8000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b5eaf000 b5eb0000 rwxp /usr/lib/libcapi-appfw-package-manager.so.0.0.59
b5eb0000 b5eb6000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b5ebd000 b5ebe000 rwxp /usr/lib/libcapi-appfw-app-manager.so.0.2.8
b5ebe000 b5ec0000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5ec8000 b5ec9000 rwxp /usr/lib/libSLP-db-util.so.0.1.0
b5eca000 b5f9d000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b5fa4000 b5fa8000 rwxp /usr/lib/libgio-2.0.so.0.3200.3
b5fa8000 b5fd3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b5fda000 b5fdb000 rwxp /usr/lib/libsecurity-server-client.so.1.0.1
b5fdb000 b5fdd000 r-xp /usr/lib/libiniparser.so.0
b5fe5000 b5fe6000 rwxp /usr/lib/libiniparser.so.0
b5fe6000 b601a000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6021000 b6023000 rwxp /usr/lib/libgobject-2.0.so.0.3200.3
b6023000 b6029000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6030000 b6031000 rwxp /usr/lib/libecore_imf.so.1.7.99
b6032000 b6038000 r-xp /usr/lib/libappsvc.so.0.1.0
b603f000 b6040000 rwxp /usr/lib/libappsvc.so.0.1.0
b6040000 b60b5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b60bc000 b60bf000 rwxp /usr/lib/libsqlite3.so.0.8.6
b60bf000 b60d5000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b60dc000 b60dd000 rwxp /usr/lib/libpkgmgr_parser.so.0.1.0
b60dd000 b60e0000 r-xp /usr/lib/libproc-stat.so.0.2.86
b60e7000 b60e8000 rwxp /usr/lib/libproc-stat.so.0.2.86
b60e8000 b6124000 r-xp /usr/lib/libsystemd.so.0.4.0
b612b000 b612c000 r-xp /usr/lib/libsystemd.so.0.4.0
b612c000 b612d000 rwxp /usr/lib/libsystemd.so.0.4.0
b612e000 b6133000 r-xp /usr/lib/libxdgmime.so.1.1.0
b613a000 b613b000 rwxp /usr/lib/libxdgmime.so.1.1.0
b613b000 b6152000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6159000 b615a000 rwxp /usr/lib/libdbus-glib-1.so.2.2.2
b615a000 b615d000 r-xp /usr/lib/libbundle.so.0.1.22
b6164000 b6165000 rwxp /usr/lib/libbundle.so.0.1.22
b6165000 b61bb000 r-xp /usr/lib/libpixman-1.so.0.28.2
b61c3000 b61c8000 rwxp /usr/lib/libpixman-1.so.0.28.2
b61c8000 b621e000 r-xp /usr/lib/libfreetype.so.6.11.3
b6226000 b622a000 rwxp /usr/lib/libfreetype.so.6.11.3
b622b000 b6268000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b626f000 b6270000 rwxp /usr/lib/libharfbuzz.so.0.940.0
b6271000 b6284000 r-xp /usr/lib/libfribidi.so.0.3.1
b628b000 b628c000 rwxp /usr/lib/libfribidi.so.0.3.1
b628c000 b62a6000 r-xp /usr/lib/libecore_con.so.1.7.99
b62ad000 b62ae000 rwxp /usr/lib/libecore_con.so.1.7.99
b62af000 b62d9000 r-xp /usr/lib/libdbus-1.so.3.8.12
b62e1000 b62e2000 rwxp /usr/lib/libdbus-1.so.3.8.12
b62e2000 b62eb000 r-xp /usr/lib/libedbus.so.1.7.99
b62f2000 b62f3000 rwxp /usr/lib/libedbus.so.1.7.99
b62f4000 b6305000 r-xp /usr/lib/libecore_input.so.1.7.99
b630c000 b630d000 rwxp /usr/lib/libecore_input.so.1.7.99
b630d000 b6312000 r-xp /usr/lib/libecore_file.so.1.7.99
b6319000 b631a000 rwxp /usr/lib/libecore_file.so.1.7.99
b631a000 b6333000 r-xp /usr/lib/libeet.so.1.7.99
b633b000 b633c000 rwxp /usr/lib/libeet.so.1.7.99
b6344000 b634d000 r-xp /usr/lib/libXi.so.6.1.0
b6354000 b6355000 rwxp /usr/lib/libXi.so.6.1.0
b6355000 b6436000 r-xp /usr/lib/libX11.so.6.3.0
b643d000 b6441000 rwxp /usr/lib/libX11.so.6.3.0
b6442000 b64fa000 r-xp /usr/lib/libcairo.so.2.11200.14
b6501000 b6504000 rwxp /usr/lib/libcairo.so.2.11200.14
b6505000 b6562000 r-xp /usr/lib/libedje.so.1.7.99
b656a000 b656c000 rwxp /usr/lib/libedje.so.1.7.99
b656c000 b6572000 r-xp /lib/librt-2.13.so
b6579000 b657a000 r-xp /lib/librt-2.13.so
b657a000 b657b000 rwxp /lib/librt-2.13.so
b657b000 b658d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b6594000 b6595000 rwxp /usr/lib/libefl-assist.so.0.1.0
b6595000 b6661000 r-xp /usr/lib/libxml2.so.2.7.8
b6668000 b666d000 rwxp /usr/lib/libxml2.so.2.7.8
b666e000 b6696000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6696000 b6697000 rwxp /usr/lib/libfontconfig.so.1.8.0
b6698000 b669c000 r-xp /usr/lib/libvconf.so.0.2.45
b66a3000 b66a4000 rwxp /usr/lib/libvconf.so.0.2.45
b66a4000 b66c6000 r-xp /usr/lib/libecore_evas.so.1.7.99
b66cd000 b66cf000 rwxp /usr/lib/libecore_evas.so.1.7.99
b66cf000 b671f000 r-xp /usr/lib/libecore_x.so.1.7.99
b671f000 b6721000 rwxp /usr/lib/libecore_x.so.1.7.99
b6721000 b678a000 r-xp /lib/libm-2.13.so
b6791000 b6792000 r-xp /lib/libm-2.13.so
b6792000 b6793000 rwxp /lib/libm-2.13.so
b6793000 b67b1000 r-xp /usr/lib/libsensor.so.1.1.0
b67b9000 b67ba000 rwxp /usr/lib/libsensor.so.1.1.0
b67bc000 b67d5000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.7
b67dc000 b67dd000 rwxp /usr/lib/libprivacy-manager-client.so.0.0.7
b67dd000 b68ad000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b68ad000 b68ae000 rwxp /usr/lib/libglib-2.0.so.0.3200.3
b68ae000 b68b4000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68bc000 b68bd000 rwxp /usr/lib/libcapi-base-common.so.0.1.8
b68bd000 b68f5000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b68f5000 b68f6000 rwxp /usr/lib/libbluetooth-api.so.1.0.0
b68f6000 b68fb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b6902000 b6903000 rwxp /usr/lib/libcapi-system-info.so.0.2.0
b6903000 b6908000 r-xp /usr/lib/libappcore-common.so.1.1
b690f000 b6910000 rwxp /usr/lib/libappcore-common.so.1.1
b6910000 b6915000 r-xp /usr/lib/libappcore-efl.so.1.1
b691c000 b691d000 rwxp /usr/lib/libappcore-efl.so.1.1
b691d000 b6921000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b6929000 b692a000 rwxp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b692a000 b693e000 r-xp /lib/libpthread-2.13.so
b6945000 b6946000 r-xp /lib/libpthread-2.13.so
b6946000 b6947000 rwxp /lib/libpthread-2.13.so
b6949000 b696b000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6972000 b6973000 rwxp /usr/lib/libpkgmgr-info.so.0.0.17
b6973000 b697f000 r-xp /usr/lib/libaul.so.0.1.0
b6987000 b6988000 rwxp /usr/lib/libaul.so.0.1.0
b6989000 b698b000 r-xp /lib/libdl-2.13.so
b6992000 b6993000 r-xp /lib/libdl-2.13.so
b6993000 b6994000 rwxp /lib/libdl-2.13.so
b6994000 b699f000 r-xp /lib/libunwind.so.8.0.1
b69a6000 b69a7000 rwxp /lib/libunwind.so.8.0.1
b69cc000 b69d4000 r-xp /lib/libgcc_s-4.6.so.1
b69d4000 b69d5000 rwxp /lib/libgcc_s-4.6.so.1
b69d5000 b6af0000 r-xp /lib/libc-2.13.so
b6af8000 b6afa000 r-xp /lib/libc-2.13.so
b6afa000 b6afb000 rwxp /lib/libc-2.13.so
b6afe000 b6b92000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b9a000 b6b9d000 r-xp /usr/lib/libstdc++.so.6.0.16
b6b9d000 b6b9f000 rwxp /usr/lib/libstdc++.so.6.0.16
b6ba5000 b6c73000 r-xp /usr/lib/libevas.so.1.7.99
b6c7b000 b6c85000 rwxp /usr/lib/libevas.so.1.7.99
b6c98000 b6dd3000 r-xp /usr/lib/libelementary.so.1.7.99
b6dda000 b6de2000 rwxp /usr/lib/libelementary.so.1.7.99
b6de9000 b6e2a000 r-xp /usr/lib/libeina.so.1.7.99
b6e31000 b6e33000 rwxp /usr/lib/libeina.so.1.7.99
b6e33000 b6e54000 r-xp /usr/lib/libefl-extension.so.0.1.0
b6e5b000 b6e5c000 rwxp /usr/lib/libefl-extension.so.0.1.0
b6e5c000 b6e73000 r-xp /usr/lib/libecore.so.1.7.99
b6e7b000 b6e7c000 rwxp /usr/lib/libecore.so.1.7.99
b6e8a000 b6e8c000 r-xp /usr/lib/libdlog.so.0.0.0
b6e93000 b6e94000 rwxp /usr/lib/libdlog.so.0.0.0
b6e94000 b6e9c000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6e9c000 b6e9d000 rwxp /usr/lib/libcapi-system-system-settings.so.0.0.2
b6e9d000 b6ea1000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.18
b6ea9000 b6eaa000 rwxp /usr/lib/libcapi-system-sensor.so.0.1.18
b6eaa000 b6edf000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.54
b6ee6000 b6ee7000 rwxp /usr/lib/libcapi-network-bluetooth.so.0.1.54
b6ee7000 b6eeb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6ef2000 b6ef3000 rwxp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b6ef3000 b6ef5000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6efd000 b6efe000 rwxp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b6efe000 b6f00000 r-xs /dev/kgsl-3d0
b6f00000 b6f0b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f13000 b6f14000 rwxp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b6f14000 b6f18000 r-xp /usr/lib/libsys-assert.so
b6f20000 b6f21000 rwxp /usr/lib/libsys-assert.so
b6f21000 b6f3e000 r-xp /lib/ld-2.13.so
b6f45000 b6f46000 r-xp /lib/ld-2.13.so
b6f46000 b6f47000 rwxp /lib/ld-2.13.so
b6f47000 b6f4f000 r-xp /opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor
b6f4f000 b6f50000 rwxp /opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor
b8b16000 b8e23000 rwxp [heap]
beb2f000 beb50000 rwxp [stack]
beb2f000 beb50000 rwxp [stack]
End of Maps Information

Callstack Information (PID:5282)
Call Stack Count: 14
 0: on_sensor_event(void*, sensor_event_s*, void*) + 0x81 (0xb6f4d3d2) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x63d2
 1: (0xb6e9e775) [/usr/lib/libcapi-system-sensor.so.0] + 0x1775
 2: (0xb67a3a89) [/usr/lib/libsensor.so.1] + 0x10a89
 3: (0xb6810fcf) [/usr/lib/libglib-2.0.so.0] + 0x33fcf
 4: g_main_context_dispatch + 0xbc (0xb68127a9) [/usr/lib/libglib-2.0.so.0] + 0x357a9
 5: (0xb6e6cd57) [/usr/lib/libecore.so.1] + 0x10d57
 6: (0xb6e67b8f) [/usr/lib/libecore.so.1] + 0xbb8f
 7: (0xb6e68541) [/usr/lib/libecore.so.1] + 0xc541
 8: ecore_main_loop_begin + 0x30 (0xb6e688b9) [/usr/lib/libecore.so.1] + 0xc8b9
 9: appcore_efl_main + 0x20e (0xb6913503) [/usr/lib/libappcore-efl.so.1] + 0x3503
10: ui_app_main + 0xb0 (0xb6ee9421) [/usr/lib/libcapi-appfw-application.so.0] + 0x2421
11: main + 0x11a (0xb6f4af4f) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x3f4f
12: __libc_start_main + 0x114 (0xb69ec82c) [/lib/libc.so.6] + 0x1782c
13: (0xb6f49d74) [/opt/usr/apps/kr.ac.ajou.capstone.presentor/bin/presentor] + 0x2d74
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
e_tick
06-06 02:26:46.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_add_capacity(1168) > [heart_battery_add_capacity,1168] 47 -> 46 1465147606 91
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 563 285 432
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 0 0 1004
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 572 348 439
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 188 5 144
06-06 02:26:46.580+0900 I/RESOURCED(  926): heart-battery.c: heart_battery_calculate_prediction(1137) > [heart_battery_calculate_prediction,1137] TimeToEmpty: 46 422 27 324
06-06 02:26:47.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:47.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:48.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:48.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:49.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:49.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:50.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:50.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:51.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:51.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:52.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:52.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:53.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:53.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:54.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:54.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:55.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:55.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:56.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:56.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:57.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:57.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:58.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:58.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:26:59.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:26:59.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:00.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:00.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:01.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:01.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:02.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:02.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:03.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:03.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:04.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:04.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:05.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:05.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:06.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:06.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:07.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:07.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:08.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:08.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:09.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:09.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:09.920+0900 I/GESTURE (  236): gesture.c: GestureRecognize(2940) > disable_home_back_gesture=1, disable_apps_back_gesture=0, disable back key!!!
06-06 02:27:10.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:10.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:10.610+0900 W/W_HOME  ( 1197): index.c: index_hide(337) > hide VI:1 visibility:0 vi:(nil)
06-06 02:27:11.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:11.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:11.580+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_wearonoff_monitor(20193) > wear_monitor_status update[0] = 2 -> 1
06-06 02:27:11.580+0900 E/WMS     (  929): wms_msg_broker.c: wms_msg_broker_send(1743) > 
06-06 02:27:11.580+0900 E/WMS     (  929): ==========
06-06 02:27:11.580+0900 E/WMS     (  929): ##WMS SEND : mgr_gear_wear_onoff_req
06-06 02:27:11.580+0900 E/WMS     (  929): ==========
06-06 02:27:11.580+0900 E/WMS     (  929): wms_msg_broker.c: wms_msg_broker_send(1759) > Data size: 52 MAX Buffer Size: 61440
06-06 02:27:11.640+0900 W/SHealth_Service( 1607): ContextRestingHeartrateProxy.cpp: OnRestingHrUpdatedCB(325) > [1;40;33mhrValue: 1007[0;m
06-06 02:27:11.730+0900 E/SHealth_Service( 1607): RestingHeartrateController.cpp: OnAutoHrDetected(83) > [0;40;31minvalid parameter[0;m
06-06 02:27:12.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:12.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:13.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:13.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:13.490+0900 E/SHealth_Common( 1607): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
06-06 02:27:14.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:14.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:15.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:15.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:15.180+0900 E/PKGMGR_SERVER( 5109): pkgmgr-server.c: main(2131) > package manager server start
06-06 02:27:15.240+0900 E/PKGMGR_SERVER( 5109): pkgmgr-server.c: req_cb(650) > req_id=[kr.ac.ajou.capstone.presentor_1146407686], req_type=[12], pkg_type=[rpm], pkgid=[kr.ac.ajou.capstone.presentor], args=[], cookie=[Ba6Ej/AT075VYw4snbZMcp23N/o=], backend_flag=[0]
06-06 02:27:15.250+0900 E/PKGMGR_SERVER( 5110): pkgmgr-server.c: queue_job(1949) > KILL/CHECK APP, pkgid=[kr.ac.ajou.capstone.presentor]
06-06 02:27:15.250+0900 E/PKGMGR  ( 5107): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/kr.ac.ajou.capstone.presentor, -1]
06-06 02:27:15.320+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 14
06-06 02:27:15.330+0900 W/AUL_AMD (  921): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
06-06 02:27:15.330+0900 E/PKGMGR_SERVER( 5110): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
06-06 02:27:15.340+0900 E/PKGMGR_SERVER( 5109): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5110]
06-06 02:27:16.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:16.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:17.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:17.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:17.580+0900 E/PKGMGR_SERVER( 5109): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-06 02:27:17.580+0900 E/PKGMGR_SERVER( 5109): pkgmgr-server.c: main(2185) > package manager server terminated.
06-06 02:27:18.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:18.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:19.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:19.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:20.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:20.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:21.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:21.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:22.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:22.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:23.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:23.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:24.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:24.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:25.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:25.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:26.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:26.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:27.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:27.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:27.730+0900 E/PKGMGR  ( 5207): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
06-06 02:27:27.870+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: main(2131) > package manager server start
06-06 02:27:27.940+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: req_cb(650) > req_id=[kr.ac.ajou.capstone.presentor_1159094834], req_type=[1], pkg_type=[rpm], pkgid=[kr.ac.ajou.capstone.presentor], args=[/usr/etc/package-manager/backend/rpm '-k' 'kr.ac.ajou.capstone.presentor_1159094834' '-r' 'kr.ac.ajou.capstone.presentor'], cookie=[zT+NfLppImFXo4zRi/TRbhyfB4c=], backend_flag=[0]
06-06 02:27:27.940+0900 E/PKGMGR  ( 5214): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [kr.ac.ajou.capstone.presentor]
06-06 02:27:27.940+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for kr.ac.ajou.capstone.presentor 
06-06 02:27:27.940+0900 E/PKGMGR_SERVER( 5215): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[kr.ac.ajou.capstone.presentor]
06-06 02:27:27.940+0900 E/PKGMGR  ( 5207): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[52070002]
06-06 02:27:28.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:28.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:28.080+0900 I/watchface-app( 1247): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-06 02:27:28.080+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
06-06 02:27:28.090+0900 W/AUL_AMD (  921): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
06-06 02:27:28.100+0900 I/watchface-app( 1247): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-06 02:27:28.100+0900 W/W_HOME  ( 1197): clock_event.c: _pkgmgr_event_cb(209) > Pkg:kr.ac.ajou.capstone.presentor is being updateded:1
06-06 02:27:28.110+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
06-06 02:27:28.360+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
06-06 02:27:28.360+0900 I/watchface-app( 1247): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-06 02:27:28.360+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 105
06-06 02:27:28.360+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 105
06-06 02:27:28.370+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 28 3
06-06 02:27:28.370+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 29 5
06-06 02:27:28.370+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 30 5
06-06 02:27:28.370+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 31 3
06-06 02:27:28.370+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
06-06 02:27:28.390+0900 E/PKGMGR_CERT( 5215): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
06-06 02:27:28.570+0900 I/AUL_AMD (  921): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4945
06-06 02:27:28.690+0900 I/AUL_AMD (  921): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4946
06-06 02:27:28.750+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-06 02:27:28.750+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-06 02:27:28.780+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-06 02:27:28.780+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-06 02:27:28.840+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-06 02:27:28.840+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-06 02:27:28.840+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-06 02:27:28.840+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-06 02:27:28.850+0900 E/EFL     ( 5217): elementary<5217> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-06 02:27:28.860+0900 E/EFL     ( 5217): elementary<5217> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-06 02:27:28.870+0900 E/EFL     ( 5217): elementary<5217> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-06 02:27:28.870+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-06 02:27:28.920+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-06 02:27:28.930+0900 E/EFL     ( 5217): elementary<5217> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-06 02:27:28.930+0900 I/AUL_PAD ( 5217): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-06 02:27:29.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:29.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:29.160+0900 I/AUL_AMD (  921): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 5217
06-06 02:27:29.160+0900 I/efl-extension( 5218): efl_extension.c: eext_mod_init(40) > Init
06-06 02:27:29.190+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-06 02:27:29.200+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-06 02:27:29.230+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-06 02:27:29.230+0900 I/UXT     ( 5218): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-06 02:27:29.230+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-06 02:27:29.270+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-06 02:27:29.270+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-06 02:27:29.270+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-06 02:27:29.280+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-06 02:27:29.280+0900 E/EFL     ( 5218): elementary<5218> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-06 02:27:29.300+0900 E/EFL     ( 5218): elementary<5218> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-06 02:27:29.300+0900 E/EFL     ( 5218): elementary<5218> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-06 02:27:29.310+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-06 02:27:29.340+0900 E/EFL     ( 5218): elementary<5218> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-06 02:27:29.350+0900 E/EFL     ( 5218): elementary<5218> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-06 02:27:29.350+0900 I/AUL_PAD ( 5218): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): OpenGL ES Shader Compiler Version: E031.24.00.16
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): Build Date: 09/02/15 Wed
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): Local Branch: 
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): Remote Branch: 
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): Local Patches: 
06-06 02:27:29.380+0900 I/Adreno-EGL( 5218): Reconstruct Branch: 
06-06 02:27:29.960+0900 I/RESOURCED(  926): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
06-06 02:27:29.960+0900 I/RESOURCED(  926): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
06-06 02:27:30.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:30.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:30.480+0900 E/rpm-installer( 5215): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
06-06 02:27:30.580+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-06 02:27:31.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:31.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:32.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:32.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:32.580+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
06-06 02:27:33.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:33.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:34.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:34.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:34.040+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: sighandler(409) > child NORMAL exit [5215]
06-06 02:27:34.040+0900 I/watchface-app( 1247): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-06 02:27:34.050+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
06-06 02:27:34.070+0900 I/watchface-app( 1247): watchface-package-control.cpp: onPackageManagerEvent(120) > it is not my package
06-06 02:27:34.070+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
06-06 02:27:34.070+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
06-06 02:27:34.070+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
06-06 02:27:34.070+0900 E/WMS     (  929): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
06-06 02:27:34.100+0900 W/W_HOME  ( 1197): clock_event.c: _pkgmgr_event_cb(238) > Pkg:kr.ac.ajou.capstone.presentor is updated, need to check validation
06-06 02:27:34.100+0900 W/W_HOME  ( 1197): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:com.watchface.SamWatch_Basic
06-06 02:27:34.170+0900 W/APPS    ( 1197): pkgmgr.c: _update_app(732) >  old order:[30]
06-06 02:27:34.190+0900 E/STARTER ( 1159): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
06-06 02:27:34.210+0900 E/PKGMGR_INFO(  924): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-06 02:27:34.240+0900 E/EFL     ( 1197): elementary<1197> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb8723d08 into part 'elm.swallow.event.0'
06-06 02:27:34.250+0900 E/APPS    ( 1197): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[31]
06-06 02:27:34.580+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
06-06 02:27:34.580+0900 E/PKGMGR_SERVER( 5214): pkgmgr-server.c: main(2185) > package manager server terminated.
06-06 02:27:34.590+0900 E/Vi::Animations( 1197): result Vi::Animations::_AnimationManager::addAnimation(Vi::Animations::Visual&, const string*, Vi::Animations::Animation&)(288) > [E_OBJ_ALREADY_EXIST] Animation with keyName already exists. key name = hide
06-06 02:27:34.590+0900 I/Vi::Animations( 1197): result Vi::Animations::_VisualImpl::addAnimation(const string*, Vi::Animations::Animation&)(6999) > [E_OBJ_ALREADY_EXIST] Propagating.
06-06 02:27:34.600+0900 E/EFL     ( 1197): elementary<1197> elm_layout.c:1020 _elm_layout_smart_content_set() could not swallow 0xb8723d08 into part 'elm.swallow.event.0'
06-06 02:27:34.600+0900 E/APPS    ( 1197): AppsViewNecklace.cpp: onShow(597) >  AppsItemList[32]
06-06 02:27:35.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:35.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:35.120+0900 W/APPS    ( 1197): pkgmgr.c: _update_app_cb(711) >  Update apps order
06-06 02:27:35.120+0900 W/APPS    ( 1197): AppsViewNecklace.cpp: onTouchEventCancel(4360) >  touch cancel
06-06 02:27:36.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:36.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:37.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:37.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:38.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:38.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:39.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:39.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:40.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:40.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:40.840+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 0
06-06 02:27:40.850+0900 I/AUL_AMD (  921): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/launch_app, ret : 0
06-06 02:27:40.860+0900 I/AUL_AMD (  921): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /bin/bash, ret : 0
06-06 02:27:40.860+0900 E/AUL_AMD (  921): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
06-06 02:27:40.860+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(1702) > caller pid : 5276
06-06 02:27:40.890+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(2080) > pad pid(-5)
06-06 02:27:40.890+0900 W/AUL_PAD ( 1703): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
06-06 02:27:40.890+0900 W/AUL_PAD ( 1703): launchpad.c: __send_result_to_caller(272) > Check app launching
06-06 02:27:40.890+0900 W/AUL_AMD (  921): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
06-06 02:27:40.890+0900 E/RESOURCED(  926): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data kr.ac.ajou.capstone.presentor, table num : 2
06-06 02:27:40.890+0900 E/RESOURCED(  926): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
06-06 02:27:40.890+0900 W/AUL_AMD (  921): amd_launch.c: start_process(580) > child process: 5282
06-06 02:27:40.940+0900 W/AUL_AMD (  921): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 5282
06-06 02:27:40.940+0900 E/RESOURCED(  926): proc-main.c: proc_add_program_list(233) > [proc_add_program_list,233] not found ppi : kr.ac.ajou.capstone.presentor
06-06 02:27:40.970+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 14
06-06 02:27:40.980+0900 W/AUL_AMD (  921): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 5282
06-06 02:27:40.980+0900 W/AUL_AMD (  921): amd_request.c: __request_handler(646) > __request_handler: 12
06-06 02:27:41.000+0900 I/CAPI_WATCH_APPLICATION( 1247): watch_app_main.c: _watch_core_time_tick(306) > _watch_core_time_tick
06-06 02:27:41.000+0900 E/watchface-app( 1247): watchface.cpp: OnAppTimeTick(614) > 
06-06 02:27:41.040+0900 I/efl-extension( 5282): efl_extension.c: eext_mod_init(40) > Init
06-06 02:27:41.060+0900 I/CAPI_APPFW_APPLICATION( 5282): app_main.c: ui_app_main(704) > app_efl_main
06-06 02:27:41.070+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-06 02:27:41.070+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-06 02:27:41.090+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:558 elm_quicklaunch_init() eet_init done.
06-06 02:27:41.090+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
06-06 02:27:41.100+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-06 02:27:41.100+0900 I/UXT     ( 5282): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
06-06 02:27:41.100+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-06 02:27:41.130+0900 E/EFL     ( 5282): elementary<5282> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-06 02:27:41.130+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
06-06 02:27:41.150+0900 E/EFL     ( 5282): elementary<5282> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-06 02:27:41.150+0900 E/EFL     ( 5282): elementary<5282> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-06 02:27:41.150+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-06 02:27:41.180+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
06-06 02:27:41.180+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
06-06 02:27:41.180+0900 E/EFL     ( 5282): elementary<5282> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5281): elementary<5281> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-06 02:27:41.190+0900 E/EFL     ( 5282): elementary<5282> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-06 02:27:41.210+0900 E/EFL     ( 5281): elementary<5281> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
06-06 02:27:41.220+0900 E/EFL     ( 5281): elementary<5281> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
06-06 02:27:41.220+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
06-06 02:27:41.240+0900 I/CAPI_APPFW_APPLICATION( 5282): app_main.c: _ui_app_appcore_create(563) > app_appcore_create
06-06 02:27:41.260+0900 E/EFL     ( 5281): elementary<5281> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
06-06 02:27:41.270+0900 E/EFL     ( 5281): elementary<5281> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
06-06 02:27:41.270+0900 I/AUL_PAD ( 5281): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): OpenGL ES Shader Compiler Version: E031.24.00.16
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): Build Date: 09/02/15 Wed
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): Local Branch: 
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): Remote Branch: 
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): Local Patches: 
06-06 02:27:41.310+0900 I/Adreno-EGL( 5282): Reconstruct Branch: 
06-06 02:27:41.520+0900 D/PRESENTOR( 5282): window size : 360x360(0, 0)
06-06 02:27:41.570+0900 I/efl-extension( 5282): efl_extension_circle_surface.c: eext_circle_surface_conformant_add(1245) > Put the surface[0xb8ddd020]'s widget[0xb8dee220] to elm_conformant widget[0xb8d4fea0]
06-06 02:27:41.570+0900 I/efl-extension( 5282): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb8ddd020 = w: 0 h: 0  obj 0xb8dee220 w: 1 h: 1
06-06 02:27:41.680+0900 E/E17     (  557): e_manager.c: _e_manager_cb_window_show_request(1128) > Show request(0x04c00003)
06-06 02:27:41.680+0900 I/APP_CORE( 5282): appcore-efl.c: __do_app(429) > [APP 5282] Event: RESET State: CREATED
06-06 02:27:41.680+0900 I/CAPI_APPFW_APPLICATION( 5282): app_main.c: _ui_app_appcore_reset(645) > app_appcore_reset
06-06 02:27:41.700+0900 W/W_HOME  ( 1197): event_manager.c: _ecore_x_message_cb(403) > state: 0 -> 1
06-06 02:27:41.700+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.700+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.710+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:1(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.710+0900 W/W_HOME  ( 1197): main.c: _ecore_x_message_cb(1233) > main_info.is_win_on_top: 0
06-06 02:27:41.710+0900 I/GESTURE (  236): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
06-06 02:27:41.740+0900 I/APP_CORE( 5282): appcore-efl.c: __do_app(472) > Legacy lifecycle: 0
06-06 02:27:41.740+0900 I/APP_CORE( 5282): appcore-efl.c: __do_app(474) > [APP 5282] Initial Launching, call the resume_cb
06-06 02:27:41.740+0900 I/CAPI_APPFW_APPLICATION( 5282): app_main.c: _ui_app_appcore_resume(628) > app_appcore_resume
06-06 02:27:41.740+0900 D/PRESENTOR( 5282): RESUMED AND BT_MGR_RELEASE
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-adapter.c: bt_adapter_unset_state_changed_cb(842) > [bt_adapter_unset_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-adapter.c: bt_adapter_unset_device_discovery_state_changed_cb(898) > [bt_adapter_unset_device_discovery_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-device.c: bt_device_unset_service_searched_cb(369) > [bt_device_unset_service_searched_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-socket.c: bt_socket_unset_data_received_cb(270) > [bt_socket_unset_data_received_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-socket.c: bt_socket_unset_connection_state_changed_cb(304) > [bt_socket_unset_connection_state_changed_cb] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.740+0900 E/CAPI_NETWORK_BLUETOOTH( 5282): bluetooth-common.c: bt_deinitialize(82) > [bt_deinitialize] NOT_INITIALIZED(0xfe400101)
06-06 02:27:41.750+0900 W/APP_CORE( 5282): appcore-efl.c: __show_cb(787) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00003
06-06 02:27:41.750+0900 I/efl-extension( 5282): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(642) > surface 0xb8ddd020 = w: 0 h: 0  obj 0xb8dee220 w: 360 h: 360
06-06 02:27:41.760+0900 I/efl-extension( 5282): efl_extension_circle_surface.c: _eext_circle_surface_resize_cb(666) > Surface will be initialized! surface->w= 360 surface->h = 360
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(448) > Window [0x2A00003] is now visible(1)
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _window_visibility_cb(458) > state: 1 -> 0
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): main.c: _window_visibility_cb(1200) > Window [0x2A00003] is now visible(1)
06-06 02:27:41.800+0900 I/APP_CORE( 5282): appcore-efl.c: __do_app(429) > [APP 5282] Event: RESUME State: RUNNING
06-06 02:27:41.800+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: PAUSE State: RUNNING
06-06 02:27:41.800+0900 I/CAPI_APPFW_APPLICATION( 1197): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): main.c: _appcore_pause_cb(692) > appcore pause
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): main.c: home_pause(762) > clock/widget paused
06-06 02:27:41.800+0900 W/W_HOME  ( 1197): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:1(0) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:41.800+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:41.810+0900 W/AUL_AMD (  921): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
06-06 02:27:41.810+0900 W/AUL_AMD (  921): amd_launch.c: __e17_status_handler(2248) > back key ungrab error
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
06-06 02:27:41.810+0900 I/MESSAGE_PORT(  870): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
06-06 02:27:41.810+0900 E/CAPI_APPFW_APP_CONTROL( 1400): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
06-06 02:27:41.810+0900 W/MUSIC_CONTROL_SERVICE( 1400): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1400]   [com.samsung.w-home]register msg port [false][0m
06-06 02:27:41.890+0900 I/wnotib  ( 1197): w-notification-board-broker-main.c: _wnotib_ecore_x_event_visibility_changed_cb(701) > fully_obscured: 1
06-06 02:27:41.890+0900 E/wnotib  ( 1197): w-notification-board-action-drawer.c: wnotib_action_drawer_hidden_get(4550) > [NULL==g_wnotib_action_drawer_data] msg Drawer not initialized.
06-06 02:27:41.900+0900 W/WATCH_CORE( 1247): appcore-watch.c: __widget_pause(1002) > widget_pause
06-06 02:27:41.900+0900 E/watchface-app( 1247): watchface.cpp: OnAppPause(587) > 
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:41.900+0900 E/watchface-viewer( 1247): viewer-group.cpp: RenewClickDownState(493) > Clear all ClickDownState as initial value
06-06 02:27:42.210+0900 E/AUL     (  921): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
06-06 02:27:42.310+0900 I/APP_CORE( 1197): appcore-efl.c: __do_app(429) > [APP 1197] Event: MEM_FLUSH State: PAUSED
06-06 02:27:42.950+0900 D/PRESENTOR( 5282): _gestrue_cb
06-06 02:27:43.290+0900 D/PRESENTOR( 5282): 11
06-06 02:27:43.590+0900 W/CRASH_MANAGER( 5303): worker.c: worker_job(1199) > 1105282707265146514766
