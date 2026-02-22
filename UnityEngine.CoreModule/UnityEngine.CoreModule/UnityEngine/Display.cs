using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200004B RID: 75
	public class Display : Object
	{
		// Token: 0x06000502 RID: 1282 RVA: 0x00022494 File Offset: 0x00020694
		// Note: this type is marked as 'beforefieldinit'.
		static Display()
		{
			Il2CppClassPointerStore<Display>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Display");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Display>.NativeClassPtr);
			Display.NativeFieldInfoPtr_nativeDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "nativeDisplay");
			Display.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "displays");
			Display.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "_mainDisplay");
			Display.NativeFieldInfoPtr_onDisplaysUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Display>.NativeClassPtr, "onDisplaysUpdated");
			Display.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663583);
			Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663585);
			Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663586);
			Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663587);
			Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663588);
			Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663589);
			Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663590);
			Display.NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663591);
			Display.NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663592);
			Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663593);
			Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663594);
			Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display>.NativeClassPtr, 100663595);
			Display.SetRenderingResolutionImplDelegateField = IL2CPP.ResolveICall<Display.SetRenderingResolutionImplDelegate>("UnityEngine.Display::SetRenderingResolutionImpl");
			Display.ActivateDisplayImplDelegateField = IL2CPP.ResolveICall<Display.ActivateDisplayImplDelegate>("UnityEngine.Display::ActivateDisplayImpl");
			Display.SetParamsImplDelegateField = IL2CPP.ResolveICall<Display.SetParamsImplDelegate>("UnityEngine.Display::SetParamsImpl");
			Display.GetActiveImplDelegateField = IL2CPP.ResolveICall<Display.GetActiveImplDelegate>("UnityEngine.Display::GetActiveImpl");
			Display.RequiresBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresBlitToBackbufferImpl");
			Display.RequiresSrgbBlitToBackbufferImplDelegateField = IL2CPP.ResolveICall<Display.RequiresSrgbBlitToBackbufferImplDelegate>("UnityEngine.Display::RequiresSrgbBlitToBackbufferImpl");
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00022660 File Offset: 0x00020860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62499, XrefRangeEnd = 62501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Display()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000504 RID: 1284 RVA: 0x0002269C File Offset: 0x0002089C
		public unsafe int renderingWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62506, RefRangeEnd = 62508, XrefRangeStart = 62501, XrefRangeEnd = 62506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000505 RID: 1285 RVA: 0x000226D8 File Offset: 0x000208D8
		public unsafe int renderingHeight
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 62513, RefRangeEnd = 62518, XrefRangeStart = 62508, XrefRangeEnd = 62513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000506 RID: 1286 RVA: 0x00022714 File Offset: 0x00020914
		public unsafe int systemWidth
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 62523, RefRangeEnd = 62525, XrefRangeStart = 62518, XrefRangeEnd = 62523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000507 RID: 1287 RVA: 0x00022750 File Offset: 0x00020950
		public unsafe int systemHeight
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62530, RefRangeEnd = 62536, XrefRangeStart = 62525, XrefRangeEnd = 62530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0002278C File Offset: 0x0002098C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 62541, RefRangeEnd = 62548, XrefRangeStart = 62536, XrefRangeEnd = 62541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inputMouseCoordinates;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000509 RID: 1289 RVA: 0x000227CC File Offset: 0x000209CC
		public unsafe static Display main
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 62552, RefRangeEnd = 62558, XrefRangeStart = 62548, XrefRangeEnd = 62552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_get_main_Public_Static_get_Display_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Display>(intPtr3) : null;
			}
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00022800 File Offset: 0x00020A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62558, XrefRangeEnd = 62575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RecreateDisplayList(Il2CppStructArray<IntPtr> nativeDisplay)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeDisplay);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00022838 File Offset: 0x00020A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62575, XrefRangeEnd = 62582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FireDisplaysUpdated()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00022860 File Offset: 0x00020A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62582, XrefRangeEnd = 62584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000228B0 File Offset: 0x00020AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62584, XrefRangeEnd = 62586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeDisplay;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &w;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &h;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00022900 File Offset: 0x00020B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 62586, XrefRangeEnd = 62588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &rx;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ry;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00004EFD File Offset: 0x000030FD
		public Display(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x00022968 File Offset: 0x00020B68
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00004F06 File Offset: 0x00003106
		public unsafe IntPtr nativeDisplay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Display.NativeFieldInfoPtr_nativeDisplay)) = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000512 RID: 1298 RVA: 0x00022990 File Offset: 0x00020B90
		// (set) Token: 0x06000513 RID: 1299 RVA: 0x00004F21 File Offset: 0x00003121
		public unsafe static Il2CppReferenceArray<Display> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Display>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000514 RID: 1300 RVA: 0x000229B8 File Offset: 0x00020BB8
		// (set) Token: 0x06000515 RID: 1301 RVA: 0x00004F33 File Offset: 0x00003133
		public unsafe static Display _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000229E0 File Offset: 0x00020BE0
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00004F45 File Offset: 0x00003145
		public unsafe static Display.DisplaysUpdatedDelegate onDisplaysUpdated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Display.DisplaysUpdatedDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Display.NativeFieldInfoPtr_onDisplaysUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x00022A08 File Offset: 0x00020C08
		public bool active
		{
			get
			{
				return Display.GetActiveImpl(this.nativeDisplay);
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x00004F57 File Offset: 0x00003157
		public bool requiresBlitToBackbuffer
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x00022A28 File Offset: 0x00020C28
		public bool requiresSrgbBlitToBackbuffer
		{
			get
			{
				return Display.RequiresSrgbBlitToBackbufferImpl(this.nativeDisplay);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004F64 File Offset: 0x00003164
		public void Activate()
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, 0, 0, 60);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004F77 File Offset: 0x00003177
		public void Activate(int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImpl(this.nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00004F89 File Offset: 0x00003189
		public void SetParams(int width, int height, int x, int y)
		{
			Display.SetParamsImpl(this.nativeDisplay, width, height, x, y);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00004F9D File Offset: 0x0000319D
		public void SetRenderingResolution(int w, int h)
		{
			Display.SetRenderingResolutionImpl(this.nativeDisplay, w, h);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00022A48 File Offset: 0x00020C48
		public static bool MultiDisplayLicense()
		{
			return true;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00004FAE File Offset: 0x000031AE
		public static void add_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00004FBB File Offset: 0x000031BB
		public static void remove_onDisplaysUpdated(Display.DisplaysUpdatedDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00004FC8 File Offset: 0x000031C8
		public static void SetRenderingResolutionImpl(IntPtr nativeDisplay, int w, int h)
		{
			Display.SetRenderingResolutionImplDelegateField(nativeDisplay, w, h);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00004FD7 File Offset: 0x000031D7
		public static void ActivateDisplayImpl(IntPtr nativeDisplay, int width, int height, int refreshRate)
		{
			Display.ActivateDisplayImplDelegateField(nativeDisplay, width, height, refreshRate);
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00004FE7 File Offset: 0x000031E7
		public static void SetParamsImpl(IntPtr nativeDisplay, int width, int height, int x, int y)
		{
			Display.SetParamsImplDelegateField(nativeDisplay, width, height, x, y);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00004FF9 File Offset: 0x000031F9
		public static bool GetActiveImpl(IntPtr nativeDisplay)
		{
			return Display.GetActiveImplDelegateField(nativeDisplay);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00005006 File Offset: 0x00003206
		public static bool RequiresBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00005013 File Offset: 0x00003213
		public static bool RequiresSrgbBlitToBackbufferImpl(IntPtr nativeDisplay)
		{
			return Display.RequiresSrgbBlitToBackbufferImplDelegateField(nativeDisplay);
		}

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_nativeDisplay;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_onDisplaysUpdated;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingWidth_Public_get_Int32_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_get_renderingHeight_Public_get_Int32_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_get_systemWidth_Public_get_Int32_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_get_systemHeight_Public_get_Int32_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAt_Public_Static_Vector3_Vector3_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_Display_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_RecreateDisplayList_Private_Static_Void_Il2CppStructArray_1_IntPtr_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_FireDisplaysUpdated_Private_Static_Void_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_GetSystemExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderingExtImpl_Private_Static_Void_IntPtr_byref_Int32_byref_Int32_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_RelativeMouseAtImpl_Private_Static_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x0400036B RID: 875
		private static readonly Display.SetRenderingResolutionImplDelegate SetRenderingResolutionImplDelegateField;

		// Token: 0x0400036C RID: 876
		private static readonly Display.ActivateDisplayImplDelegate ActivateDisplayImplDelegateField;

		// Token: 0x0400036D RID: 877
		private static readonly Display.SetParamsImplDelegate SetParamsImplDelegateField;

		// Token: 0x0400036E RID: 878
		private static readonly Display.GetActiveImplDelegate GetActiveImplDelegateField;

		// Token: 0x0400036F RID: 879
		private static readonly Display.RequiresBlitToBackbufferImplDelegate RequiresBlitToBackbufferImplDelegateField;

		// Token: 0x04000370 RID: 880
		private static readonly Display.RequiresSrgbBlitToBackbufferImplDelegate RequiresSrgbBlitToBackbufferImplDelegateField;

		// Token: 0x02000456 RID: 1110
		public sealed class DisplaysUpdatedDelegate : MulticastDelegate
		{
			// Token: 0x06002675 RID: 9845 RVA: 0x000152C0 File Offset: 0x000134C0
			// Note: this type is marked as 'beforefieldinit'.
			static DisplaysUpdatedDelegate()
			{
				Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Display>.NativeClassPtr, "DisplaysUpdatedDelegate");
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663597);
				Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr, 100663598);
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x0006B8B4 File Offset: 0x00069AB4
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DisplaysUpdatedDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Display.DisplaysUpdatedDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x0006B910 File Offset: 0x00069B10
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Display.DisplaysUpdatedDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002678 RID: 9848 RVA: 0x000152FE File Offset: 0x000134FE
			public DisplaysUpdatedDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002679 RID: 9849 RVA: 0x00015307 File Offset: 0x00013507
			public static implicit operator Display.DisplaysUpdatedDelegate(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Display.DisplaysUpdatedDelegate>(A_0);
			}

			// Token: 0x0600267A RID: 9850 RVA: 0x0001530F File Offset: 0x0001350F
			public static Display.DisplaysUpdatedDelegate operator +(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Display.DisplaysUpdatedDelegate>();
			}

			// Token: 0x0600267B RID: 9851 RVA: 0x0001531D File Offset: 0x0001351D
			public static Display.DisplaysUpdatedDelegate operator -(Display.DisplaysUpdatedDelegate A_0, Display.DisplaysUpdatedDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Display.DisplaysUpdatedDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001C64 RID: 7268
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C65 RID: 7269
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}

		// Token: 0x02000457 RID: 1111
		// (Invoke) Token: 0x0600267D RID: 9853
		private delegate void SetRenderingResolutionImplDelegate(IntPtr nativeDisplay, int w, int h);

		// Token: 0x02000458 RID: 1112
		// (Invoke) Token: 0x0600267F RID: 9855
		private delegate void ActivateDisplayImplDelegate(IntPtr nativeDisplay, int width, int height, int refreshRate);

		// Token: 0x02000459 RID: 1113
		// (Invoke) Token: 0x06002681 RID: 9857
		private delegate void SetParamsImplDelegate(IntPtr nativeDisplay, int width, int height, int x, int y);

		// Token: 0x0200045A RID: 1114
		// (Invoke) Token: 0x06002683 RID: 9859
		private delegate bool GetActiveImplDelegate(IntPtr nativeDisplay);

		// Token: 0x0200045B RID: 1115
		// (Invoke) Token: 0x06002685 RID: 9861
		private delegate bool RequiresBlitToBackbufferImplDelegate(IntPtr nativeDisplay);

		// Token: 0x0200045C RID: 1116
		// (Invoke) Token: 0x06002687 RID: 9863
		private delegate bool RequiresSrgbBlitToBackbufferImplDelegate(IntPtr nativeDisplay);
	}
}
