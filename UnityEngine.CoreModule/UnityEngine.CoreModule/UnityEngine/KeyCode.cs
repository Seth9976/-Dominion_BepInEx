using System;

namespace UnityEngine
{
	// Token: 0x0200007A RID: 122
	public enum KeyCode
	{
		// Token: 0x04000885 RID: 2181
		None,
		// Token: 0x04000886 RID: 2182
		Backspace = 8,
		// Token: 0x04000887 RID: 2183
		Delete = 127,
		// Token: 0x04000888 RID: 2184
		Tab = 9,
		// Token: 0x04000889 RID: 2185
		Clear = 12,
		// Token: 0x0400088A RID: 2186
		Return,
		// Token: 0x0400088B RID: 2187
		Pause = 19,
		// Token: 0x0400088C RID: 2188
		Escape = 27,
		// Token: 0x0400088D RID: 2189
		Space = 32,
		// Token: 0x0400088E RID: 2190
		Keypad0 = 256,
		// Token: 0x0400088F RID: 2191
		Keypad1,
		// Token: 0x04000890 RID: 2192
		Keypad2,
		// Token: 0x04000891 RID: 2193
		Keypad3,
		// Token: 0x04000892 RID: 2194
		Keypad4,
		// Token: 0x04000893 RID: 2195
		Keypad5,
		// Token: 0x04000894 RID: 2196
		Keypad6,
		// Token: 0x04000895 RID: 2197
		Keypad7,
		// Token: 0x04000896 RID: 2198
		Keypad8,
		// Token: 0x04000897 RID: 2199
		Keypad9,
		// Token: 0x04000898 RID: 2200
		KeypadPeriod,
		// Token: 0x04000899 RID: 2201
		KeypadDivide,
		// Token: 0x0400089A RID: 2202
		KeypadMultiply,
		// Token: 0x0400089B RID: 2203
		KeypadMinus,
		// Token: 0x0400089C RID: 2204
		KeypadPlus,
		// Token: 0x0400089D RID: 2205
		KeypadEnter,
		// Token: 0x0400089E RID: 2206
		KeypadEquals,
		// Token: 0x0400089F RID: 2207
		UpArrow,
		// Token: 0x040008A0 RID: 2208
		DownArrow,
		// Token: 0x040008A1 RID: 2209
		RightArrow,
		// Token: 0x040008A2 RID: 2210
		LeftArrow,
		// Token: 0x040008A3 RID: 2211
		Insert,
		// Token: 0x040008A4 RID: 2212
		Home,
		// Token: 0x040008A5 RID: 2213
		End,
		// Token: 0x040008A6 RID: 2214
		PageUp,
		// Token: 0x040008A7 RID: 2215
		PageDown,
		// Token: 0x040008A8 RID: 2216
		F1,
		// Token: 0x040008A9 RID: 2217
		F2,
		// Token: 0x040008AA RID: 2218
		F3,
		// Token: 0x040008AB RID: 2219
		F4,
		// Token: 0x040008AC RID: 2220
		F5,
		// Token: 0x040008AD RID: 2221
		F6,
		// Token: 0x040008AE RID: 2222
		F7,
		// Token: 0x040008AF RID: 2223
		F8,
		// Token: 0x040008B0 RID: 2224
		F9,
		// Token: 0x040008B1 RID: 2225
		F10,
		// Token: 0x040008B2 RID: 2226
		F11,
		// Token: 0x040008B3 RID: 2227
		F12,
		// Token: 0x040008B4 RID: 2228
		F13,
		// Token: 0x040008B5 RID: 2229
		F14,
		// Token: 0x040008B6 RID: 2230
		F15,
		// Token: 0x040008B7 RID: 2231
		Alpha0 = 48,
		// Token: 0x040008B8 RID: 2232
		Alpha1,
		// Token: 0x040008B9 RID: 2233
		Alpha2,
		// Token: 0x040008BA RID: 2234
		Alpha3,
		// Token: 0x040008BB RID: 2235
		Alpha4,
		// Token: 0x040008BC RID: 2236
		Alpha5,
		// Token: 0x040008BD RID: 2237
		Alpha6,
		// Token: 0x040008BE RID: 2238
		Alpha7,
		// Token: 0x040008BF RID: 2239
		Alpha8,
		// Token: 0x040008C0 RID: 2240
		Alpha9,
		// Token: 0x040008C1 RID: 2241
		Exclaim = 33,
		// Token: 0x040008C2 RID: 2242
		DoubleQuote,
		// Token: 0x040008C3 RID: 2243
		Hash,
		// Token: 0x040008C4 RID: 2244
		Dollar,
		// Token: 0x040008C5 RID: 2245
		Percent,
		// Token: 0x040008C6 RID: 2246
		Ampersand,
		// Token: 0x040008C7 RID: 2247
		Quote,
		// Token: 0x040008C8 RID: 2248
		LeftParen,
		// Token: 0x040008C9 RID: 2249
		RightParen,
		// Token: 0x040008CA RID: 2250
		Asterisk,
		// Token: 0x040008CB RID: 2251
		Plus,
		// Token: 0x040008CC RID: 2252
		Comma,
		// Token: 0x040008CD RID: 2253
		Minus,
		// Token: 0x040008CE RID: 2254
		Period,
		// Token: 0x040008CF RID: 2255
		Slash,
		// Token: 0x040008D0 RID: 2256
		Colon = 58,
		// Token: 0x040008D1 RID: 2257
		Semicolon,
		// Token: 0x040008D2 RID: 2258
		Less,
		// Token: 0x040008D3 RID: 2259
		Equals,
		// Token: 0x040008D4 RID: 2260
		Greater,
		// Token: 0x040008D5 RID: 2261
		Question,
		// Token: 0x040008D6 RID: 2262
		At,
		// Token: 0x040008D7 RID: 2263
		LeftBracket = 91,
		// Token: 0x040008D8 RID: 2264
		Backslash,
		// Token: 0x040008D9 RID: 2265
		RightBracket,
		// Token: 0x040008DA RID: 2266
		Caret,
		// Token: 0x040008DB RID: 2267
		Underscore,
		// Token: 0x040008DC RID: 2268
		BackQuote,
		// Token: 0x040008DD RID: 2269
		A,
		// Token: 0x040008DE RID: 2270
		B,
		// Token: 0x040008DF RID: 2271
		C,
		// Token: 0x040008E0 RID: 2272
		D,
		// Token: 0x040008E1 RID: 2273
		E,
		// Token: 0x040008E2 RID: 2274
		F,
		// Token: 0x040008E3 RID: 2275
		G,
		// Token: 0x040008E4 RID: 2276
		H,
		// Token: 0x040008E5 RID: 2277
		I,
		// Token: 0x040008E6 RID: 2278
		J,
		// Token: 0x040008E7 RID: 2279
		K,
		// Token: 0x040008E8 RID: 2280
		L,
		// Token: 0x040008E9 RID: 2281
		M,
		// Token: 0x040008EA RID: 2282
		N,
		// Token: 0x040008EB RID: 2283
		O,
		// Token: 0x040008EC RID: 2284
		P,
		// Token: 0x040008ED RID: 2285
		Q,
		// Token: 0x040008EE RID: 2286
		R,
		// Token: 0x040008EF RID: 2287
		S,
		// Token: 0x040008F0 RID: 2288
		T,
		// Token: 0x040008F1 RID: 2289
		U,
		// Token: 0x040008F2 RID: 2290
		V,
		// Token: 0x040008F3 RID: 2291
		W,
		// Token: 0x040008F4 RID: 2292
		X,
		// Token: 0x040008F5 RID: 2293
		Y,
		// Token: 0x040008F6 RID: 2294
		Z,
		// Token: 0x040008F7 RID: 2295
		LeftCurlyBracket,
		// Token: 0x040008F8 RID: 2296
		Pipe,
		// Token: 0x040008F9 RID: 2297
		RightCurlyBracket,
		// Token: 0x040008FA RID: 2298
		Tilde,
		// Token: 0x040008FB RID: 2299
		Numlock = 300,
		// Token: 0x040008FC RID: 2300
		CapsLock,
		// Token: 0x040008FD RID: 2301
		ScrollLock,
		// Token: 0x040008FE RID: 2302
		RightShift,
		// Token: 0x040008FF RID: 2303
		LeftShift,
		// Token: 0x04000900 RID: 2304
		RightControl,
		// Token: 0x04000901 RID: 2305
		LeftControl,
		// Token: 0x04000902 RID: 2306
		RightAlt,
		// Token: 0x04000903 RID: 2307
		LeftAlt,
		// Token: 0x04000904 RID: 2308
		LeftCommand = 310,
		// Token: 0x04000905 RID: 2309
		LeftApple = 310,
		// Token: 0x04000906 RID: 2310
		LeftWindows,
		// Token: 0x04000907 RID: 2311
		RightCommand = 309,
		// Token: 0x04000908 RID: 2312
		RightApple = 309,
		// Token: 0x04000909 RID: 2313
		RightWindows = 312,
		// Token: 0x0400090A RID: 2314
		AltGr,
		// Token: 0x0400090B RID: 2315
		Help = 315,
		// Token: 0x0400090C RID: 2316
		Print,
		// Token: 0x0400090D RID: 2317
		SysReq,
		// Token: 0x0400090E RID: 2318
		Break,
		// Token: 0x0400090F RID: 2319
		Menu,
		// Token: 0x04000910 RID: 2320
		Mouse0 = 323,
		// Token: 0x04000911 RID: 2321
		Mouse1,
		// Token: 0x04000912 RID: 2322
		Mouse2,
		// Token: 0x04000913 RID: 2323
		Mouse3,
		// Token: 0x04000914 RID: 2324
		Mouse4,
		// Token: 0x04000915 RID: 2325
		Mouse5,
		// Token: 0x04000916 RID: 2326
		Mouse6,
		// Token: 0x04000917 RID: 2327
		JoystickButton0,
		// Token: 0x04000918 RID: 2328
		JoystickButton1,
		// Token: 0x04000919 RID: 2329
		JoystickButton2,
		// Token: 0x0400091A RID: 2330
		JoystickButton3,
		// Token: 0x0400091B RID: 2331
		JoystickButton4,
		// Token: 0x0400091C RID: 2332
		JoystickButton5,
		// Token: 0x0400091D RID: 2333
		JoystickButton6,
		// Token: 0x0400091E RID: 2334
		JoystickButton7,
		// Token: 0x0400091F RID: 2335
		JoystickButton8,
		// Token: 0x04000920 RID: 2336
		JoystickButton9,
		// Token: 0x04000921 RID: 2337
		JoystickButton10,
		// Token: 0x04000922 RID: 2338
		JoystickButton11,
		// Token: 0x04000923 RID: 2339
		JoystickButton12,
		// Token: 0x04000924 RID: 2340
		JoystickButton13,
		// Token: 0x04000925 RID: 2341
		JoystickButton14,
		// Token: 0x04000926 RID: 2342
		JoystickButton15,
		// Token: 0x04000927 RID: 2343
		JoystickButton16,
		// Token: 0x04000928 RID: 2344
		JoystickButton17,
		// Token: 0x04000929 RID: 2345
		JoystickButton18,
		// Token: 0x0400092A RID: 2346
		JoystickButton19,
		// Token: 0x0400092B RID: 2347
		Joystick1Button0,
		// Token: 0x0400092C RID: 2348
		Joystick1Button1,
		// Token: 0x0400092D RID: 2349
		Joystick1Button2,
		// Token: 0x0400092E RID: 2350
		Joystick1Button3,
		// Token: 0x0400092F RID: 2351
		Joystick1Button4,
		// Token: 0x04000930 RID: 2352
		Joystick1Button5,
		// Token: 0x04000931 RID: 2353
		Joystick1Button6,
		// Token: 0x04000932 RID: 2354
		Joystick1Button7,
		// Token: 0x04000933 RID: 2355
		Joystick1Button8,
		// Token: 0x04000934 RID: 2356
		Joystick1Button9,
		// Token: 0x04000935 RID: 2357
		Joystick1Button10,
		// Token: 0x04000936 RID: 2358
		Joystick1Button11,
		// Token: 0x04000937 RID: 2359
		Joystick1Button12,
		// Token: 0x04000938 RID: 2360
		Joystick1Button13,
		// Token: 0x04000939 RID: 2361
		Joystick1Button14,
		// Token: 0x0400093A RID: 2362
		Joystick1Button15,
		// Token: 0x0400093B RID: 2363
		Joystick1Button16,
		// Token: 0x0400093C RID: 2364
		Joystick1Button17,
		// Token: 0x0400093D RID: 2365
		Joystick1Button18,
		// Token: 0x0400093E RID: 2366
		Joystick1Button19,
		// Token: 0x0400093F RID: 2367
		Joystick2Button0,
		// Token: 0x04000940 RID: 2368
		Joystick2Button1,
		// Token: 0x04000941 RID: 2369
		Joystick2Button2,
		// Token: 0x04000942 RID: 2370
		Joystick2Button3,
		// Token: 0x04000943 RID: 2371
		Joystick2Button4,
		// Token: 0x04000944 RID: 2372
		Joystick2Button5,
		// Token: 0x04000945 RID: 2373
		Joystick2Button6,
		// Token: 0x04000946 RID: 2374
		Joystick2Button7,
		// Token: 0x04000947 RID: 2375
		Joystick2Button8,
		// Token: 0x04000948 RID: 2376
		Joystick2Button9,
		// Token: 0x04000949 RID: 2377
		Joystick2Button10,
		// Token: 0x0400094A RID: 2378
		Joystick2Button11,
		// Token: 0x0400094B RID: 2379
		Joystick2Button12,
		// Token: 0x0400094C RID: 2380
		Joystick2Button13,
		// Token: 0x0400094D RID: 2381
		Joystick2Button14,
		// Token: 0x0400094E RID: 2382
		Joystick2Button15,
		// Token: 0x0400094F RID: 2383
		Joystick2Button16,
		// Token: 0x04000950 RID: 2384
		Joystick2Button17,
		// Token: 0x04000951 RID: 2385
		Joystick2Button18,
		// Token: 0x04000952 RID: 2386
		Joystick2Button19,
		// Token: 0x04000953 RID: 2387
		Joystick3Button0,
		// Token: 0x04000954 RID: 2388
		Joystick3Button1,
		// Token: 0x04000955 RID: 2389
		Joystick3Button2,
		// Token: 0x04000956 RID: 2390
		Joystick3Button3,
		// Token: 0x04000957 RID: 2391
		Joystick3Button4,
		// Token: 0x04000958 RID: 2392
		Joystick3Button5,
		// Token: 0x04000959 RID: 2393
		Joystick3Button6,
		// Token: 0x0400095A RID: 2394
		Joystick3Button7,
		// Token: 0x0400095B RID: 2395
		Joystick3Button8,
		// Token: 0x0400095C RID: 2396
		Joystick3Button9,
		// Token: 0x0400095D RID: 2397
		Joystick3Button10,
		// Token: 0x0400095E RID: 2398
		Joystick3Button11,
		// Token: 0x0400095F RID: 2399
		Joystick3Button12,
		// Token: 0x04000960 RID: 2400
		Joystick3Button13,
		// Token: 0x04000961 RID: 2401
		Joystick3Button14,
		// Token: 0x04000962 RID: 2402
		Joystick3Button15,
		// Token: 0x04000963 RID: 2403
		Joystick3Button16,
		// Token: 0x04000964 RID: 2404
		Joystick3Button17,
		// Token: 0x04000965 RID: 2405
		Joystick3Button18,
		// Token: 0x04000966 RID: 2406
		Joystick3Button19,
		// Token: 0x04000967 RID: 2407
		Joystick4Button0,
		// Token: 0x04000968 RID: 2408
		Joystick4Button1,
		// Token: 0x04000969 RID: 2409
		Joystick4Button2,
		// Token: 0x0400096A RID: 2410
		Joystick4Button3,
		// Token: 0x0400096B RID: 2411
		Joystick4Button4,
		// Token: 0x0400096C RID: 2412
		Joystick4Button5,
		// Token: 0x0400096D RID: 2413
		Joystick4Button6,
		// Token: 0x0400096E RID: 2414
		Joystick4Button7,
		// Token: 0x0400096F RID: 2415
		Joystick4Button8,
		// Token: 0x04000970 RID: 2416
		Joystick4Button9,
		// Token: 0x04000971 RID: 2417
		Joystick4Button10,
		// Token: 0x04000972 RID: 2418
		Joystick4Button11,
		// Token: 0x04000973 RID: 2419
		Joystick4Button12,
		// Token: 0x04000974 RID: 2420
		Joystick4Button13,
		// Token: 0x04000975 RID: 2421
		Joystick4Button14,
		// Token: 0x04000976 RID: 2422
		Joystick4Button15,
		// Token: 0x04000977 RID: 2423
		Joystick4Button16,
		// Token: 0x04000978 RID: 2424
		Joystick4Button17,
		// Token: 0x04000979 RID: 2425
		Joystick4Button18,
		// Token: 0x0400097A RID: 2426
		Joystick4Button19,
		// Token: 0x0400097B RID: 2427
		Joystick5Button0,
		// Token: 0x0400097C RID: 2428
		Joystick5Button1,
		// Token: 0x0400097D RID: 2429
		Joystick5Button2,
		// Token: 0x0400097E RID: 2430
		Joystick5Button3,
		// Token: 0x0400097F RID: 2431
		Joystick5Button4,
		// Token: 0x04000980 RID: 2432
		Joystick5Button5,
		// Token: 0x04000981 RID: 2433
		Joystick5Button6,
		// Token: 0x04000982 RID: 2434
		Joystick5Button7,
		// Token: 0x04000983 RID: 2435
		Joystick5Button8,
		// Token: 0x04000984 RID: 2436
		Joystick5Button9,
		// Token: 0x04000985 RID: 2437
		Joystick5Button10,
		// Token: 0x04000986 RID: 2438
		Joystick5Button11,
		// Token: 0x04000987 RID: 2439
		Joystick5Button12,
		// Token: 0x04000988 RID: 2440
		Joystick5Button13,
		// Token: 0x04000989 RID: 2441
		Joystick5Button14,
		// Token: 0x0400098A RID: 2442
		Joystick5Button15,
		// Token: 0x0400098B RID: 2443
		Joystick5Button16,
		// Token: 0x0400098C RID: 2444
		Joystick5Button17,
		// Token: 0x0400098D RID: 2445
		Joystick5Button18,
		// Token: 0x0400098E RID: 2446
		Joystick5Button19,
		// Token: 0x0400098F RID: 2447
		Joystick6Button0,
		// Token: 0x04000990 RID: 2448
		Joystick6Button1,
		// Token: 0x04000991 RID: 2449
		Joystick6Button2,
		// Token: 0x04000992 RID: 2450
		Joystick6Button3,
		// Token: 0x04000993 RID: 2451
		Joystick6Button4,
		// Token: 0x04000994 RID: 2452
		Joystick6Button5,
		// Token: 0x04000995 RID: 2453
		Joystick6Button6,
		// Token: 0x04000996 RID: 2454
		Joystick6Button7,
		// Token: 0x04000997 RID: 2455
		Joystick6Button8,
		// Token: 0x04000998 RID: 2456
		Joystick6Button9,
		// Token: 0x04000999 RID: 2457
		Joystick6Button10,
		// Token: 0x0400099A RID: 2458
		Joystick6Button11,
		// Token: 0x0400099B RID: 2459
		Joystick6Button12,
		// Token: 0x0400099C RID: 2460
		Joystick6Button13,
		// Token: 0x0400099D RID: 2461
		Joystick6Button14,
		// Token: 0x0400099E RID: 2462
		Joystick6Button15,
		// Token: 0x0400099F RID: 2463
		Joystick6Button16,
		// Token: 0x040009A0 RID: 2464
		Joystick6Button17,
		// Token: 0x040009A1 RID: 2465
		Joystick6Button18,
		// Token: 0x040009A2 RID: 2466
		Joystick6Button19,
		// Token: 0x040009A3 RID: 2467
		Joystick7Button0,
		// Token: 0x040009A4 RID: 2468
		Joystick7Button1,
		// Token: 0x040009A5 RID: 2469
		Joystick7Button2,
		// Token: 0x040009A6 RID: 2470
		Joystick7Button3,
		// Token: 0x040009A7 RID: 2471
		Joystick7Button4,
		// Token: 0x040009A8 RID: 2472
		Joystick7Button5,
		// Token: 0x040009A9 RID: 2473
		Joystick7Button6,
		// Token: 0x040009AA RID: 2474
		Joystick7Button7,
		// Token: 0x040009AB RID: 2475
		Joystick7Button8,
		// Token: 0x040009AC RID: 2476
		Joystick7Button9,
		// Token: 0x040009AD RID: 2477
		Joystick7Button10,
		// Token: 0x040009AE RID: 2478
		Joystick7Button11,
		// Token: 0x040009AF RID: 2479
		Joystick7Button12,
		// Token: 0x040009B0 RID: 2480
		Joystick7Button13,
		// Token: 0x040009B1 RID: 2481
		Joystick7Button14,
		// Token: 0x040009B2 RID: 2482
		Joystick7Button15,
		// Token: 0x040009B3 RID: 2483
		Joystick7Button16,
		// Token: 0x040009B4 RID: 2484
		Joystick7Button17,
		// Token: 0x040009B5 RID: 2485
		Joystick7Button18,
		// Token: 0x040009B6 RID: 2486
		Joystick7Button19,
		// Token: 0x040009B7 RID: 2487
		Joystick8Button0,
		// Token: 0x040009B8 RID: 2488
		Joystick8Button1,
		// Token: 0x040009B9 RID: 2489
		Joystick8Button2,
		// Token: 0x040009BA RID: 2490
		Joystick8Button3,
		// Token: 0x040009BB RID: 2491
		Joystick8Button4,
		// Token: 0x040009BC RID: 2492
		Joystick8Button5,
		// Token: 0x040009BD RID: 2493
		Joystick8Button6,
		// Token: 0x040009BE RID: 2494
		Joystick8Button7,
		// Token: 0x040009BF RID: 2495
		Joystick8Button8,
		// Token: 0x040009C0 RID: 2496
		Joystick8Button9,
		// Token: 0x040009C1 RID: 2497
		Joystick8Button10,
		// Token: 0x040009C2 RID: 2498
		Joystick8Button11,
		// Token: 0x040009C3 RID: 2499
		Joystick8Button12,
		// Token: 0x040009C4 RID: 2500
		Joystick8Button13,
		// Token: 0x040009C5 RID: 2501
		Joystick8Button14,
		// Token: 0x040009C6 RID: 2502
		Joystick8Button15,
		// Token: 0x040009C7 RID: 2503
		Joystick8Button16,
		// Token: 0x040009C8 RID: 2504
		Joystick8Button17,
		// Token: 0x040009C9 RID: 2505
		Joystick8Button18,
		// Token: 0x040009CA RID: 2506
		Joystick8Button19
	}
}
