using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200004D RID: 77
	public sealed class Screen : Object
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x00022A5C File Offset: 0x00020C5C
		// Note: this type is marked as 'beforefieldinit'.
		static Screen()
		{
			Il2CppClassPointerStore<Screen>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Screen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Screen>.NativeClassPtr);
			Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663599);
			Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663600);
			Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663601);
			Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663602);
			Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663603);
			Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663604);
			Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663605);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663606);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663607);
			Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663608);
			Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Screen>.NativeClassPtr, 100663609);
			Screen.RequestOrientationDelegateField = IL2CPP.ResolveICall<Screen.RequestOrientationDelegate>("UnityEngine.Screen::RequestOrientation");
			Screen.get_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.get_sleepTimeoutDelegate>("UnityEngine.Screen::get_sleepTimeout");
			Screen.set_sleepTimeoutDelegateField = IL2CPP.ResolveICall<Screen.set_sleepTimeoutDelegate>("UnityEngine.Screen::set_sleepTimeout");
			Screen.IsOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.IsOrientationEnabledDelegate>("UnityEngine.Screen::IsOrientationEnabled");
			Screen.SetOrientationEnabledDelegateField = IL2CPP.ResolveICall<Screen.SetOrientationEnabledDelegate>("UnityEngine.Screen::SetOrientationEnabled");
			Screen.set_fullScreenDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenDelegate>("UnityEngine.Screen::set_fullScreen");
			Screen.set_fullScreenModeDelegateField = IL2CPP.ResolveICall<Screen.set_fullScreenModeDelegate>("UnityEngine.Screen::set_fullScreenMode");
			Screen.get_cutoutsDelegateField = IL2CPP.ResolveICall<Screen.get_cutoutsDelegate>("UnityEngine.Screen::get_cutouts");
			Screen.get_brightnessDelegateField = IL2CPP.ResolveICall<Screen.get_brightnessDelegate>("UnityEngine.Screen::get_brightness");
			Screen.set_brightnessDelegateField = IL2CPP.ResolveICall<Screen.set_brightnessDelegate>("UnityEngine.Screen::set_brightness");
			Screen.get_currentResolution_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_currentResolution_InjectedDelegate>("UnityEngine.Screen::get_currentResolution_Injected");
			Screen.get_safeArea_InjectedDelegateField = IL2CPP.ResolveICall<Screen.get_safeArea_InjectedDelegate>("UnityEngine.Screen::get_safeArea_Injected");
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x00022C1C File Offset: 0x00020E1C
		public unsafe static int width
		{
			[CallerCount(47)]
			[CachedScanResults(RefRangeStart = 62590, RefRangeEnd = 62637, XrefRangeStart = 62588, XrefRangeEnd = 62590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600052A RID: 1322 RVA: 0x00022C4C File Offset: 0x00020E4C
		public unsafe static int height
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 62639, RefRangeEnd = 62694, XrefRangeStart = 62637, XrefRangeEnd = 62639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x00022C7C File Offset: 0x00020E7C
		public unsafe static float dpi
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 62696, RefRangeEnd = 62700, XrefRangeStart = 62694, XrefRangeEnd = 62696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00022CAC File Offset: 0x00020EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 62702, RefRangeEnd = 62703, XrefRangeStart = 62700, XrefRangeEnd = 62702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScreenOrientation GetScreenOrientation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00022CDC File Offset: 0x00020EDC
		// (set) Token: 0x06000536 RID: 1334 RVA: 0x00022EA8 File Offset: 0x000210A8
		public unsafe static ScreenOrientation orientation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62702, RefRangeEnd = 62703, XrefRangeStart = 62702, XrefRangeEnd = 62703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				bool flag = value == ScreenOrientation.Unknown;
				if (flag)
				{
					Debug.Log("ScreenOrientation.Unknown is deprecated. Please use ScreenOrientation.AutoRotation");
					value = ScreenOrientation.AutoRotation;
				}
				Screen.RequestOrientation(value);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600052E RID: 1326 RVA: 0x00022D0C File Offset: 0x00020F0C
		// (set) Token: 0x06000544 RID: 1348 RVA: 0x00005096 File Offset: 0x00003296
		public unsafe static bool fullScreen
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62705, RefRangeEnd = 62707, XrefRangeStart = 62703, XrefRangeEnd = 62705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Screen.set_fullScreenDelegateField(value);
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00022D3C File Offset: 0x00020F3C
		// (set) Token: 0x06000545 RID: 1349 RVA: 0x000050A3 File Offset: 0x000032A3
		public unsafe static FullScreenMode fullScreenMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62709, RefRangeEnd = 62710, XrefRangeStart = 62707, XrefRangeEnd = 62709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				Screen.set_fullScreenModeDelegateField(value);
			}
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00022D6C File Offset: 0x00020F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62710, XrefRangeEnd = 62712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, FullScreenMode fullscreenMode, int preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreenMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00022DC8 File Offset: 0x00020FC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62712, XrefRangeEnd = 62714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preferredRefreshRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00022E24 File Offset: 0x00021024
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 62716, RefRangeEnd = 62718, XrefRangeStart = 62714, XrefRangeEnd = 62716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetResolution(int width, int height, bool fullscreen)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fullscreen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00022E74 File Offset: 0x00021074
		public unsafe static Il2CppStructArray<Resolution> resolutions
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 62720, RefRangeEnd = 62721, XrefRangeStart = 62718, XrefRangeEnd = 62720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Screen.NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr3) : null;
			}
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00005020 File Offset: 0x00003220
		public Screen(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00005029 File Offset: 0x00003229
		public static void RequestOrientation(ScreenOrientation orient)
		{
			Screen.RequestOrientationDelegateField(orient);
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000537 RID: 1335 RVA: 0x00005036 File Offset: 0x00003236
		// (set) Token: 0x06000538 RID: 1336 RVA: 0x00005042 File Offset: 0x00003242
		public static int sleepTimeout
		{
			get
			{
				return Screen.get_sleepTimeoutDelegateField();
			}
			set
			{
				Screen.set_sleepTimeoutDelegateField(value);
			}
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x0000504F File Offset: 0x0000324F
		public static bool IsOrientationEnabled(EnabledOrientation orient)
		{
			return Screen.IsOrientationEnabledDelegateField(orient);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x0000505C File Offset: 0x0000325C
		public static void SetOrientationEnabled(EnabledOrientation orient, bool enabled)
		{
			Screen.SetOrientationEnabledDelegateField(orient, enabled);
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00022ED8 File Offset: 0x000210D8
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000506A File Offset: 0x0000326A
		public static bool autorotateToPortrait
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortrait);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortrait, value);
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00022EF0 File Offset: 0x000210F0
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x00005075 File Offset: 0x00003275
		public static bool autorotateToPortraitUpsideDown
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToPortraitUpsideDown, value);
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00022F08 File Offset: 0x00021108
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x00005080 File Offset: 0x00003280
		public static bool autorotateToLandscapeLeft
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeLeft, value);
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x00022F20 File Offset: 0x00021120
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x0000508B File Offset: 0x0000328B
		public static bool autorotateToLandscapeRight
		{
			get
			{
				return Screen.IsOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight);
			}
			set
			{
				Screen.SetOrientationEnabled(EnabledOrientation.kAutorotateToLandscapeRight, value);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000543 RID: 1347 RVA: 0x00022F38 File Offset: 0x00021138
		public static Resolution currentResolution
		{
			get
			{
				Resolution resolution;
				Screen.get_currentResolution_Injected(out resolution);
				return resolution;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00022F50 File Offset: 0x00021150
		public static Rect safeArea
		{
			get
			{
				Rect rect;
				Screen.get_safeArea_Injected(out rect);
				return rect;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000547 RID: 1351 RVA: 0x00022F68 File Offset: 0x00021168
		public static Il2CppStructArray<Rect> cutouts
		{
			get
			{
				IntPtr intPtr = Screen.get_cutoutsDelegateField();
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Rect>>(intPtr2) : null;
			}
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x000050B0 File Offset: 0x000032B0
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode)
		{
			Screen.SetResolution(width, height, fullscreenMode, 0);
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x000050BD File Offset: 0x000032BD
		// (set) Token: 0x0600054A RID: 1354 RVA: 0x000050C9 File Offset: 0x000032C9
		public static float brightness
		{
			get
			{
				return Screen.get_brightnessDelegateField();
			}
			set
			{
				Screen.set_brightnessDelegateField(value);
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00022F90 File Offset: 0x00021190
		// (set) Token: 0x0600054C RID: 1356 RVA: 0x00022FAC File Offset: 0x000211AC
		public static bool lockCursor
		{
			get
			{
				return CursorLockMode.Locked == Cursor.lockState;
			}
			set
			{
				if (value)
				{
					Cursor.visible = false;
					Cursor.lockState = CursorLockMode.Locked;
				}
				else
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x000050D6 File Offset: 0x000032D6
		public static void get_currentResolution_Injected(out Resolution ret)
		{
			Screen.get_currentResolution_InjectedDelegateField(out ret);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x000050E3 File Offset: 0x000032E3
		public static void get_safeArea_Injected(out Rect ret)
		{
			Screen.get_safeArea_InjectedDelegateField(out ret);
		}

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Static_get_Int32_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Static_get_Int32_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_get_dpi_Public_Static_get_Single_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_GetScreenOrientation_Private_Static_ScreenOrientation_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Public_Static_get_ScreenOrientation_0;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreen_Public_Static_get_Boolean_0;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeMethodInfoPtr_get_fullScreenMode_Public_Static_get_FullScreenMode_0;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_FullScreenMode_Int32_0;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_Int32_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_SetResolution_Public_Static_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_get_resolutions_Public_Static_get_Il2CppStructArray_1_Resolution_0;

		// Token: 0x04000381 RID: 897
		private static readonly Screen.RequestOrientationDelegate RequestOrientationDelegateField;

		// Token: 0x04000382 RID: 898
		private static readonly Screen.get_sleepTimeoutDelegate get_sleepTimeoutDelegateField;

		// Token: 0x04000383 RID: 899
		private static readonly Screen.set_sleepTimeoutDelegate set_sleepTimeoutDelegateField;

		// Token: 0x04000384 RID: 900
		private static readonly Screen.IsOrientationEnabledDelegate IsOrientationEnabledDelegateField;

		// Token: 0x04000385 RID: 901
		private static readonly Screen.SetOrientationEnabledDelegate SetOrientationEnabledDelegateField;

		// Token: 0x04000386 RID: 902
		private static readonly Screen.set_fullScreenDelegate set_fullScreenDelegateField;

		// Token: 0x04000387 RID: 903
		private static readonly Screen.set_fullScreenModeDelegate set_fullScreenModeDelegateField;

		// Token: 0x04000388 RID: 904
		private static readonly Screen.get_cutoutsDelegate get_cutoutsDelegateField;

		// Token: 0x04000389 RID: 905
		private static readonly Screen.get_brightnessDelegate get_brightnessDelegateField;

		// Token: 0x0400038A RID: 906
		private static readonly Screen.set_brightnessDelegate set_brightnessDelegateField;

		// Token: 0x0400038B RID: 907
		private static readonly Screen.get_currentResolution_InjectedDelegate get_currentResolution_InjectedDelegateField;

		// Token: 0x0400038C RID: 908
		private static readonly Screen.get_safeArea_InjectedDelegate get_safeArea_InjectedDelegateField;

		// Token: 0x0200045D RID: 1117
		// (Invoke) Token: 0x06002689 RID: 9865
		private delegate void RequestOrientationDelegate(ScreenOrientation orient);

		// Token: 0x0200045E RID: 1118
		// (Invoke) Token: 0x0600268B RID: 9867
		private delegate int get_sleepTimeoutDelegate();

		// Token: 0x0200045F RID: 1119
		// (Invoke) Token: 0x0600268D RID: 9869
		private delegate void set_sleepTimeoutDelegate(int value);

		// Token: 0x02000460 RID: 1120
		// (Invoke) Token: 0x0600268F RID: 9871
		private delegate bool IsOrientationEnabledDelegate(EnabledOrientation orient);

		// Token: 0x02000461 RID: 1121
		// (Invoke) Token: 0x06002691 RID: 9873
		private delegate void SetOrientationEnabledDelegate(EnabledOrientation orient, bool enabled);

		// Token: 0x02000462 RID: 1122
		// (Invoke) Token: 0x06002693 RID: 9875
		private delegate void set_fullScreenDelegate(bool value);

		// Token: 0x02000463 RID: 1123
		// (Invoke) Token: 0x06002695 RID: 9877
		private delegate void set_fullScreenModeDelegate(FullScreenMode value);

		// Token: 0x02000464 RID: 1124
		// (Invoke) Token: 0x06002697 RID: 9879
		private delegate IntPtr get_cutoutsDelegate();

		// Token: 0x02000465 RID: 1125
		// (Invoke) Token: 0x06002699 RID: 9881
		private delegate float get_brightnessDelegate();

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x0600269B RID: 9883
		private delegate void set_brightnessDelegate(float value);

		// Token: 0x02000467 RID: 1127
		// (Invoke) Token: 0x0600269D RID: 9885
		private delegate void get_currentResolution_InjectedDelegate([Out] IntPtr ret);

		// Token: 0x02000468 RID: 1128
		// (Invoke) Token: 0x0600269F RID: 9887
		private delegate void get_safeArea_InjectedDelegate([Out] IntPtr ret);
	}
}
