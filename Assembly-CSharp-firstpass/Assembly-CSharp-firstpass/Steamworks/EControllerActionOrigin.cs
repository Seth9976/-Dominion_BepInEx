using System;

namespace Steamworks
{
	// Token: 0x02000241 RID: 577
	public enum EControllerActionOrigin
	{
		// Token: 0x04001FED RID: 8173
		k_EControllerActionOrigin_None,
		// Token: 0x04001FEE RID: 8174
		k_EControllerActionOrigin_A,
		// Token: 0x04001FEF RID: 8175
		k_EControllerActionOrigin_B,
		// Token: 0x04001FF0 RID: 8176
		k_EControllerActionOrigin_X,
		// Token: 0x04001FF1 RID: 8177
		k_EControllerActionOrigin_Y,
		// Token: 0x04001FF2 RID: 8178
		k_EControllerActionOrigin_LeftBumper,
		// Token: 0x04001FF3 RID: 8179
		k_EControllerActionOrigin_RightBumper,
		// Token: 0x04001FF4 RID: 8180
		k_EControllerActionOrigin_LeftGrip,
		// Token: 0x04001FF5 RID: 8181
		k_EControllerActionOrigin_RightGrip,
		// Token: 0x04001FF6 RID: 8182
		k_EControllerActionOrigin_Start,
		// Token: 0x04001FF7 RID: 8183
		k_EControllerActionOrigin_Back,
		// Token: 0x04001FF8 RID: 8184
		k_EControllerActionOrigin_LeftPad_Touch,
		// Token: 0x04001FF9 RID: 8185
		k_EControllerActionOrigin_LeftPad_Swipe,
		// Token: 0x04001FFA RID: 8186
		k_EControllerActionOrigin_LeftPad_Click,
		// Token: 0x04001FFB RID: 8187
		k_EControllerActionOrigin_LeftPad_DPadNorth,
		// Token: 0x04001FFC RID: 8188
		k_EControllerActionOrigin_LeftPad_DPadSouth,
		// Token: 0x04001FFD RID: 8189
		k_EControllerActionOrigin_LeftPad_DPadWest,
		// Token: 0x04001FFE RID: 8190
		k_EControllerActionOrigin_LeftPad_DPadEast,
		// Token: 0x04001FFF RID: 8191
		k_EControllerActionOrigin_RightPad_Touch,
		// Token: 0x04002000 RID: 8192
		k_EControllerActionOrigin_RightPad_Swipe,
		// Token: 0x04002001 RID: 8193
		k_EControllerActionOrigin_RightPad_Click,
		// Token: 0x04002002 RID: 8194
		k_EControllerActionOrigin_RightPad_DPadNorth,
		// Token: 0x04002003 RID: 8195
		k_EControllerActionOrigin_RightPad_DPadSouth,
		// Token: 0x04002004 RID: 8196
		k_EControllerActionOrigin_RightPad_DPadWest,
		// Token: 0x04002005 RID: 8197
		k_EControllerActionOrigin_RightPad_DPadEast,
		// Token: 0x04002006 RID: 8198
		k_EControllerActionOrigin_LeftTrigger_Pull,
		// Token: 0x04002007 RID: 8199
		k_EControllerActionOrigin_LeftTrigger_Click,
		// Token: 0x04002008 RID: 8200
		k_EControllerActionOrigin_RightTrigger_Pull,
		// Token: 0x04002009 RID: 8201
		k_EControllerActionOrigin_RightTrigger_Click,
		// Token: 0x0400200A RID: 8202
		k_EControllerActionOrigin_LeftStick_Move,
		// Token: 0x0400200B RID: 8203
		k_EControllerActionOrigin_LeftStick_Click,
		// Token: 0x0400200C RID: 8204
		k_EControllerActionOrigin_LeftStick_DPadNorth,
		// Token: 0x0400200D RID: 8205
		k_EControllerActionOrigin_LeftStick_DPadSouth,
		// Token: 0x0400200E RID: 8206
		k_EControllerActionOrigin_LeftStick_DPadWest,
		// Token: 0x0400200F RID: 8207
		k_EControllerActionOrigin_LeftStick_DPadEast,
		// Token: 0x04002010 RID: 8208
		k_EControllerActionOrigin_Gyro_Move,
		// Token: 0x04002011 RID: 8209
		k_EControllerActionOrigin_Gyro_Pitch,
		// Token: 0x04002012 RID: 8210
		k_EControllerActionOrigin_Gyro_Yaw,
		// Token: 0x04002013 RID: 8211
		k_EControllerActionOrigin_Gyro_Roll,
		// Token: 0x04002014 RID: 8212
		k_EControllerActionOrigin_PS4_X,
		// Token: 0x04002015 RID: 8213
		k_EControllerActionOrigin_PS4_Circle,
		// Token: 0x04002016 RID: 8214
		k_EControllerActionOrigin_PS4_Triangle,
		// Token: 0x04002017 RID: 8215
		k_EControllerActionOrigin_PS4_Square,
		// Token: 0x04002018 RID: 8216
		k_EControllerActionOrigin_PS4_LeftBumper,
		// Token: 0x04002019 RID: 8217
		k_EControllerActionOrigin_PS4_RightBumper,
		// Token: 0x0400201A RID: 8218
		k_EControllerActionOrigin_PS4_Options,
		// Token: 0x0400201B RID: 8219
		k_EControllerActionOrigin_PS4_Share,
		// Token: 0x0400201C RID: 8220
		k_EControllerActionOrigin_PS4_LeftPad_Touch,
		// Token: 0x0400201D RID: 8221
		k_EControllerActionOrigin_PS4_LeftPad_Swipe,
		// Token: 0x0400201E RID: 8222
		k_EControllerActionOrigin_PS4_LeftPad_Click,
		// Token: 0x0400201F RID: 8223
		k_EControllerActionOrigin_PS4_LeftPad_DPadNorth,
		// Token: 0x04002020 RID: 8224
		k_EControllerActionOrigin_PS4_LeftPad_DPadSouth,
		// Token: 0x04002021 RID: 8225
		k_EControllerActionOrigin_PS4_LeftPad_DPadWest,
		// Token: 0x04002022 RID: 8226
		k_EControllerActionOrigin_PS4_LeftPad_DPadEast,
		// Token: 0x04002023 RID: 8227
		k_EControllerActionOrigin_PS4_RightPad_Touch,
		// Token: 0x04002024 RID: 8228
		k_EControllerActionOrigin_PS4_RightPad_Swipe,
		// Token: 0x04002025 RID: 8229
		k_EControllerActionOrigin_PS4_RightPad_Click,
		// Token: 0x04002026 RID: 8230
		k_EControllerActionOrigin_PS4_RightPad_DPadNorth,
		// Token: 0x04002027 RID: 8231
		k_EControllerActionOrigin_PS4_RightPad_DPadSouth,
		// Token: 0x04002028 RID: 8232
		k_EControllerActionOrigin_PS4_RightPad_DPadWest,
		// Token: 0x04002029 RID: 8233
		k_EControllerActionOrigin_PS4_RightPad_DPadEast,
		// Token: 0x0400202A RID: 8234
		k_EControllerActionOrigin_PS4_CenterPad_Touch,
		// Token: 0x0400202B RID: 8235
		k_EControllerActionOrigin_PS4_CenterPad_Swipe,
		// Token: 0x0400202C RID: 8236
		k_EControllerActionOrigin_PS4_CenterPad_Click,
		// Token: 0x0400202D RID: 8237
		k_EControllerActionOrigin_PS4_CenterPad_DPadNorth,
		// Token: 0x0400202E RID: 8238
		k_EControllerActionOrigin_PS4_CenterPad_DPadSouth,
		// Token: 0x0400202F RID: 8239
		k_EControllerActionOrigin_PS4_CenterPad_DPadWest,
		// Token: 0x04002030 RID: 8240
		k_EControllerActionOrigin_PS4_CenterPad_DPadEast,
		// Token: 0x04002031 RID: 8241
		k_EControllerActionOrigin_PS4_LeftTrigger_Pull,
		// Token: 0x04002032 RID: 8242
		k_EControllerActionOrigin_PS4_LeftTrigger_Click,
		// Token: 0x04002033 RID: 8243
		k_EControllerActionOrigin_PS4_RightTrigger_Pull,
		// Token: 0x04002034 RID: 8244
		k_EControllerActionOrigin_PS4_RightTrigger_Click,
		// Token: 0x04002035 RID: 8245
		k_EControllerActionOrigin_PS4_LeftStick_Move,
		// Token: 0x04002036 RID: 8246
		k_EControllerActionOrigin_PS4_LeftStick_Click,
		// Token: 0x04002037 RID: 8247
		k_EControllerActionOrigin_PS4_LeftStick_DPadNorth,
		// Token: 0x04002038 RID: 8248
		k_EControllerActionOrigin_PS4_LeftStick_DPadSouth,
		// Token: 0x04002039 RID: 8249
		k_EControllerActionOrigin_PS4_LeftStick_DPadWest,
		// Token: 0x0400203A RID: 8250
		k_EControllerActionOrigin_PS4_LeftStick_DPadEast,
		// Token: 0x0400203B RID: 8251
		k_EControllerActionOrigin_PS4_RightStick_Move,
		// Token: 0x0400203C RID: 8252
		k_EControllerActionOrigin_PS4_RightStick_Click,
		// Token: 0x0400203D RID: 8253
		k_EControllerActionOrigin_PS4_RightStick_DPadNorth,
		// Token: 0x0400203E RID: 8254
		k_EControllerActionOrigin_PS4_RightStick_DPadSouth,
		// Token: 0x0400203F RID: 8255
		k_EControllerActionOrigin_PS4_RightStick_DPadWest,
		// Token: 0x04002040 RID: 8256
		k_EControllerActionOrigin_PS4_RightStick_DPadEast,
		// Token: 0x04002041 RID: 8257
		k_EControllerActionOrigin_PS4_DPad_North,
		// Token: 0x04002042 RID: 8258
		k_EControllerActionOrigin_PS4_DPad_South,
		// Token: 0x04002043 RID: 8259
		k_EControllerActionOrigin_PS4_DPad_West,
		// Token: 0x04002044 RID: 8260
		k_EControllerActionOrigin_PS4_DPad_East,
		// Token: 0x04002045 RID: 8261
		k_EControllerActionOrigin_PS4_Gyro_Move,
		// Token: 0x04002046 RID: 8262
		k_EControllerActionOrigin_PS4_Gyro_Pitch,
		// Token: 0x04002047 RID: 8263
		k_EControllerActionOrigin_PS4_Gyro_Yaw,
		// Token: 0x04002048 RID: 8264
		k_EControllerActionOrigin_PS4_Gyro_Roll,
		// Token: 0x04002049 RID: 8265
		k_EControllerActionOrigin_XBoxOne_A,
		// Token: 0x0400204A RID: 8266
		k_EControllerActionOrigin_XBoxOne_B,
		// Token: 0x0400204B RID: 8267
		k_EControllerActionOrigin_XBoxOne_X,
		// Token: 0x0400204C RID: 8268
		k_EControllerActionOrigin_XBoxOne_Y,
		// Token: 0x0400204D RID: 8269
		k_EControllerActionOrigin_XBoxOne_LeftBumper,
		// Token: 0x0400204E RID: 8270
		k_EControllerActionOrigin_XBoxOne_RightBumper,
		// Token: 0x0400204F RID: 8271
		k_EControllerActionOrigin_XBoxOne_Menu,
		// Token: 0x04002050 RID: 8272
		k_EControllerActionOrigin_XBoxOne_View,
		// Token: 0x04002051 RID: 8273
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Pull,
		// Token: 0x04002052 RID: 8274
		k_EControllerActionOrigin_XBoxOne_LeftTrigger_Click,
		// Token: 0x04002053 RID: 8275
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Pull,
		// Token: 0x04002054 RID: 8276
		k_EControllerActionOrigin_XBoxOne_RightTrigger_Click,
		// Token: 0x04002055 RID: 8277
		k_EControllerActionOrigin_XBoxOne_LeftStick_Move,
		// Token: 0x04002056 RID: 8278
		k_EControllerActionOrigin_XBoxOne_LeftStick_Click,
		// Token: 0x04002057 RID: 8279
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadNorth,
		// Token: 0x04002058 RID: 8280
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadSouth,
		// Token: 0x04002059 RID: 8281
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadWest,
		// Token: 0x0400205A RID: 8282
		k_EControllerActionOrigin_XBoxOne_LeftStick_DPadEast,
		// Token: 0x0400205B RID: 8283
		k_EControllerActionOrigin_XBoxOne_RightStick_Move,
		// Token: 0x0400205C RID: 8284
		k_EControllerActionOrigin_XBoxOne_RightStick_Click,
		// Token: 0x0400205D RID: 8285
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadNorth,
		// Token: 0x0400205E RID: 8286
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadSouth,
		// Token: 0x0400205F RID: 8287
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadWest,
		// Token: 0x04002060 RID: 8288
		k_EControllerActionOrigin_XBoxOne_RightStick_DPadEast,
		// Token: 0x04002061 RID: 8289
		k_EControllerActionOrigin_XBoxOne_DPad_North,
		// Token: 0x04002062 RID: 8290
		k_EControllerActionOrigin_XBoxOne_DPad_South,
		// Token: 0x04002063 RID: 8291
		k_EControllerActionOrigin_XBoxOne_DPad_West,
		// Token: 0x04002064 RID: 8292
		k_EControllerActionOrigin_XBoxOne_DPad_East,
		// Token: 0x04002065 RID: 8293
		k_EControllerActionOrigin_XBox360_A,
		// Token: 0x04002066 RID: 8294
		k_EControllerActionOrigin_XBox360_B,
		// Token: 0x04002067 RID: 8295
		k_EControllerActionOrigin_XBox360_X,
		// Token: 0x04002068 RID: 8296
		k_EControllerActionOrigin_XBox360_Y,
		// Token: 0x04002069 RID: 8297
		k_EControllerActionOrigin_XBox360_LeftBumper,
		// Token: 0x0400206A RID: 8298
		k_EControllerActionOrigin_XBox360_RightBumper,
		// Token: 0x0400206B RID: 8299
		k_EControllerActionOrigin_XBox360_Start,
		// Token: 0x0400206C RID: 8300
		k_EControllerActionOrigin_XBox360_Back,
		// Token: 0x0400206D RID: 8301
		k_EControllerActionOrigin_XBox360_LeftTrigger_Pull,
		// Token: 0x0400206E RID: 8302
		k_EControllerActionOrigin_XBox360_LeftTrigger_Click,
		// Token: 0x0400206F RID: 8303
		k_EControllerActionOrigin_XBox360_RightTrigger_Pull,
		// Token: 0x04002070 RID: 8304
		k_EControllerActionOrigin_XBox360_RightTrigger_Click,
		// Token: 0x04002071 RID: 8305
		k_EControllerActionOrigin_XBox360_LeftStick_Move,
		// Token: 0x04002072 RID: 8306
		k_EControllerActionOrigin_XBox360_LeftStick_Click,
		// Token: 0x04002073 RID: 8307
		k_EControllerActionOrigin_XBox360_LeftStick_DPadNorth,
		// Token: 0x04002074 RID: 8308
		k_EControllerActionOrigin_XBox360_LeftStick_DPadSouth,
		// Token: 0x04002075 RID: 8309
		k_EControllerActionOrigin_XBox360_LeftStick_DPadWest,
		// Token: 0x04002076 RID: 8310
		k_EControllerActionOrigin_XBox360_LeftStick_DPadEast,
		// Token: 0x04002077 RID: 8311
		k_EControllerActionOrigin_XBox360_RightStick_Move,
		// Token: 0x04002078 RID: 8312
		k_EControllerActionOrigin_XBox360_RightStick_Click,
		// Token: 0x04002079 RID: 8313
		k_EControllerActionOrigin_XBox360_RightStick_DPadNorth,
		// Token: 0x0400207A RID: 8314
		k_EControllerActionOrigin_XBox360_RightStick_DPadSouth,
		// Token: 0x0400207B RID: 8315
		k_EControllerActionOrigin_XBox360_RightStick_DPadWest,
		// Token: 0x0400207C RID: 8316
		k_EControllerActionOrigin_XBox360_RightStick_DPadEast,
		// Token: 0x0400207D RID: 8317
		k_EControllerActionOrigin_XBox360_DPad_North,
		// Token: 0x0400207E RID: 8318
		k_EControllerActionOrigin_XBox360_DPad_South,
		// Token: 0x0400207F RID: 8319
		k_EControllerActionOrigin_XBox360_DPad_West,
		// Token: 0x04002080 RID: 8320
		k_EControllerActionOrigin_XBox360_DPad_East,
		// Token: 0x04002081 RID: 8321
		k_EControllerActionOrigin_SteamV2_A,
		// Token: 0x04002082 RID: 8322
		k_EControllerActionOrigin_SteamV2_B,
		// Token: 0x04002083 RID: 8323
		k_EControllerActionOrigin_SteamV2_X,
		// Token: 0x04002084 RID: 8324
		k_EControllerActionOrigin_SteamV2_Y,
		// Token: 0x04002085 RID: 8325
		k_EControllerActionOrigin_SteamV2_LeftBumper,
		// Token: 0x04002086 RID: 8326
		k_EControllerActionOrigin_SteamV2_RightBumper,
		// Token: 0x04002087 RID: 8327
		k_EControllerActionOrigin_SteamV2_LeftGrip_Lower,
		// Token: 0x04002088 RID: 8328
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper,
		// Token: 0x04002089 RID: 8329
		k_EControllerActionOrigin_SteamV2_RightGrip_Lower,
		// Token: 0x0400208A RID: 8330
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper,
		// Token: 0x0400208B RID: 8331
		k_EControllerActionOrigin_SteamV2_LeftBumper_Pressure,
		// Token: 0x0400208C RID: 8332
		k_EControllerActionOrigin_SteamV2_RightBumper_Pressure,
		// Token: 0x0400208D RID: 8333
		k_EControllerActionOrigin_SteamV2_LeftGrip_Pressure,
		// Token: 0x0400208E RID: 8334
		k_EControllerActionOrigin_SteamV2_RightGrip_Pressure,
		// Token: 0x0400208F RID: 8335
		k_EControllerActionOrigin_SteamV2_LeftGrip_Upper_Pressure,
		// Token: 0x04002090 RID: 8336
		k_EControllerActionOrigin_SteamV2_RightGrip_Upper_Pressure,
		// Token: 0x04002091 RID: 8337
		k_EControllerActionOrigin_SteamV2_Start,
		// Token: 0x04002092 RID: 8338
		k_EControllerActionOrigin_SteamV2_Back,
		// Token: 0x04002093 RID: 8339
		k_EControllerActionOrigin_SteamV2_LeftPad_Touch,
		// Token: 0x04002094 RID: 8340
		k_EControllerActionOrigin_SteamV2_LeftPad_Swipe,
		// Token: 0x04002095 RID: 8341
		k_EControllerActionOrigin_SteamV2_LeftPad_Click,
		// Token: 0x04002096 RID: 8342
		k_EControllerActionOrigin_SteamV2_LeftPad_Pressure,
		// Token: 0x04002097 RID: 8343
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadNorth,
		// Token: 0x04002098 RID: 8344
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadSouth,
		// Token: 0x04002099 RID: 8345
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadWest,
		// Token: 0x0400209A RID: 8346
		k_EControllerActionOrigin_SteamV2_LeftPad_DPadEast,
		// Token: 0x0400209B RID: 8347
		k_EControllerActionOrigin_SteamV2_RightPad_Touch,
		// Token: 0x0400209C RID: 8348
		k_EControllerActionOrigin_SteamV2_RightPad_Swipe,
		// Token: 0x0400209D RID: 8349
		k_EControllerActionOrigin_SteamV2_RightPad_Click,
		// Token: 0x0400209E RID: 8350
		k_EControllerActionOrigin_SteamV2_RightPad_Pressure,
		// Token: 0x0400209F RID: 8351
		k_EControllerActionOrigin_SteamV2_RightPad_DPadNorth,
		// Token: 0x040020A0 RID: 8352
		k_EControllerActionOrigin_SteamV2_RightPad_DPadSouth,
		// Token: 0x040020A1 RID: 8353
		k_EControllerActionOrigin_SteamV2_RightPad_DPadWest,
		// Token: 0x040020A2 RID: 8354
		k_EControllerActionOrigin_SteamV2_RightPad_DPadEast,
		// Token: 0x040020A3 RID: 8355
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Pull,
		// Token: 0x040020A4 RID: 8356
		k_EControllerActionOrigin_SteamV2_LeftTrigger_Click,
		// Token: 0x040020A5 RID: 8357
		k_EControllerActionOrigin_SteamV2_RightTrigger_Pull,
		// Token: 0x040020A6 RID: 8358
		k_EControllerActionOrigin_SteamV2_RightTrigger_Click,
		// Token: 0x040020A7 RID: 8359
		k_EControllerActionOrigin_SteamV2_LeftStick_Move,
		// Token: 0x040020A8 RID: 8360
		k_EControllerActionOrigin_SteamV2_LeftStick_Click,
		// Token: 0x040020A9 RID: 8361
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadNorth,
		// Token: 0x040020AA RID: 8362
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadSouth,
		// Token: 0x040020AB RID: 8363
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadWest,
		// Token: 0x040020AC RID: 8364
		k_EControllerActionOrigin_SteamV2_LeftStick_DPadEast,
		// Token: 0x040020AD RID: 8365
		k_EControllerActionOrigin_SteamV2_Gyro_Move,
		// Token: 0x040020AE RID: 8366
		k_EControllerActionOrigin_SteamV2_Gyro_Pitch,
		// Token: 0x040020AF RID: 8367
		k_EControllerActionOrigin_SteamV2_Gyro_Yaw,
		// Token: 0x040020B0 RID: 8368
		k_EControllerActionOrigin_SteamV2_Gyro_Roll,
		// Token: 0x040020B1 RID: 8369
		k_EControllerActionOrigin_Switch_A,
		// Token: 0x040020B2 RID: 8370
		k_EControllerActionOrigin_Switch_B,
		// Token: 0x040020B3 RID: 8371
		k_EControllerActionOrigin_Switch_X,
		// Token: 0x040020B4 RID: 8372
		k_EControllerActionOrigin_Switch_Y,
		// Token: 0x040020B5 RID: 8373
		k_EControllerActionOrigin_Switch_LeftBumper,
		// Token: 0x040020B6 RID: 8374
		k_EControllerActionOrigin_Switch_RightBumper,
		// Token: 0x040020B7 RID: 8375
		k_EControllerActionOrigin_Switch_Plus,
		// Token: 0x040020B8 RID: 8376
		k_EControllerActionOrigin_Switch_Minus,
		// Token: 0x040020B9 RID: 8377
		k_EControllerActionOrigin_Switch_Capture,
		// Token: 0x040020BA RID: 8378
		k_EControllerActionOrigin_Switch_LeftTrigger_Pull,
		// Token: 0x040020BB RID: 8379
		k_EControllerActionOrigin_Switch_LeftTrigger_Click,
		// Token: 0x040020BC RID: 8380
		k_EControllerActionOrigin_Switch_RightTrigger_Pull,
		// Token: 0x040020BD RID: 8381
		k_EControllerActionOrigin_Switch_RightTrigger_Click,
		// Token: 0x040020BE RID: 8382
		k_EControllerActionOrigin_Switch_LeftStick_Move,
		// Token: 0x040020BF RID: 8383
		k_EControllerActionOrigin_Switch_LeftStick_Click,
		// Token: 0x040020C0 RID: 8384
		k_EControllerActionOrigin_Switch_LeftStick_DPadNorth,
		// Token: 0x040020C1 RID: 8385
		k_EControllerActionOrigin_Switch_LeftStick_DPadSouth,
		// Token: 0x040020C2 RID: 8386
		k_EControllerActionOrigin_Switch_LeftStick_DPadWest,
		// Token: 0x040020C3 RID: 8387
		k_EControllerActionOrigin_Switch_LeftStick_DPadEast,
		// Token: 0x040020C4 RID: 8388
		k_EControllerActionOrigin_Switch_RightStick_Move,
		// Token: 0x040020C5 RID: 8389
		k_EControllerActionOrigin_Switch_RightStick_Click,
		// Token: 0x040020C6 RID: 8390
		k_EControllerActionOrigin_Switch_RightStick_DPadNorth,
		// Token: 0x040020C7 RID: 8391
		k_EControllerActionOrigin_Switch_RightStick_DPadSouth,
		// Token: 0x040020C8 RID: 8392
		k_EControllerActionOrigin_Switch_RightStick_DPadWest,
		// Token: 0x040020C9 RID: 8393
		k_EControllerActionOrigin_Switch_RightStick_DPadEast,
		// Token: 0x040020CA RID: 8394
		k_EControllerActionOrigin_Switch_DPad_North,
		// Token: 0x040020CB RID: 8395
		k_EControllerActionOrigin_Switch_DPad_South,
		// Token: 0x040020CC RID: 8396
		k_EControllerActionOrigin_Switch_DPad_West,
		// Token: 0x040020CD RID: 8397
		k_EControllerActionOrigin_Switch_DPad_East,
		// Token: 0x040020CE RID: 8398
		k_EControllerActionOrigin_Switch_ProGyro_Move,
		// Token: 0x040020CF RID: 8399
		k_EControllerActionOrigin_Switch_ProGyro_Pitch,
		// Token: 0x040020D0 RID: 8400
		k_EControllerActionOrigin_Switch_ProGyro_Yaw,
		// Token: 0x040020D1 RID: 8401
		k_EControllerActionOrigin_Switch_ProGyro_Roll,
		// Token: 0x040020D2 RID: 8402
		k_EControllerActionOrigin_Switch_RightGyro_Move,
		// Token: 0x040020D3 RID: 8403
		k_EControllerActionOrigin_Switch_RightGyro_Pitch,
		// Token: 0x040020D4 RID: 8404
		k_EControllerActionOrigin_Switch_RightGyro_Yaw,
		// Token: 0x040020D5 RID: 8405
		k_EControllerActionOrigin_Switch_RightGyro_Roll,
		// Token: 0x040020D6 RID: 8406
		k_EControllerActionOrigin_Switch_LeftGyro_Move,
		// Token: 0x040020D7 RID: 8407
		k_EControllerActionOrigin_Switch_LeftGyro_Pitch,
		// Token: 0x040020D8 RID: 8408
		k_EControllerActionOrigin_Switch_LeftGyro_Yaw,
		// Token: 0x040020D9 RID: 8409
		k_EControllerActionOrigin_Switch_LeftGyro_Roll,
		// Token: 0x040020DA RID: 8410
		k_EControllerActionOrigin_Switch_LeftGrip_Lower,
		// Token: 0x040020DB RID: 8411
		k_EControllerActionOrigin_Switch_LeftGrip_Upper,
		// Token: 0x040020DC RID: 8412
		k_EControllerActionOrigin_Switch_RightGrip_Lower,
		// Token: 0x040020DD RID: 8413
		k_EControllerActionOrigin_Switch_RightGrip_Upper,
		// Token: 0x040020DE RID: 8414
		k_EControllerActionOrigin_PS4_DPad_Move,
		// Token: 0x040020DF RID: 8415
		k_EControllerActionOrigin_XBoxOne_DPad_Move,
		// Token: 0x040020E0 RID: 8416
		k_EControllerActionOrigin_XBox360_DPad_Move,
		// Token: 0x040020E1 RID: 8417
		k_EControllerActionOrigin_Switch_DPad_Move,
		// Token: 0x040020E2 RID: 8418
		k_EControllerActionOrigin_Count,
		// Token: 0x040020E3 RID: 8419
		k_EControllerActionOrigin_MaximumPossibleValue = 32767
	}
}
