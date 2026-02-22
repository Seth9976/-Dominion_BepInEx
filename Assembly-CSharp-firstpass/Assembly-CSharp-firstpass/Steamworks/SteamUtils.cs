using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200016D RID: 365
	public static class SteamUtils : Object
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x00085A98 File Offset: 0x00083C98
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUtils()
		{
			Il2CppClassPointerStore<SteamUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr);
			SteamUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667359);
			SteamUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667360);
			SteamUtils.NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667361);
			SteamUtils.NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667362);
			SteamUtils.NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667363);
			SteamUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667364);
			SteamUtils.NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667365);
			SteamUtils.NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667366);
			SteamUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667367);
			SteamUtils.NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667368);
			SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667369);
			SteamUtils.NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667370);
			SteamUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667371);
			SteamUtils.NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667372);
			SteamUtils.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667373);
			SteamUtils.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667374);
			SteamUtils.NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667375);
			SteamUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667376);
			SteamUtils.NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667377);
			SteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667378);
			SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667379);
			SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667380);
			SteamUtils.NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667381);
			SteamUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667382);
			SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667383);
			SteamUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667384);
			SteamUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667385);
			SteamUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667386);
			SteamUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667387);
			SteamUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667388);
			SteamUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667389);
			SteamUtils.NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667390);
			SteamUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUtils>.NativeClassPtr, 100667391);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00085D5C File Offset: 0x00083F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203079, XrefRangeEnd = 203083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSecondsSinceAppActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00085D8C File Offset: 0x00083F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203083, XrefRangeEnd = 203087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSecondsSinceComputerActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x00085DBC File Offset: 0x00083FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203087, XrefRangeEnd = 203091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EUniverse GetConnectedUniverse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE1 RID: 7393 RVA: 0x00085DEC File Offset: 0x00083FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203091, XrefRangeEnd = 203095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetServerRealTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00085E1C File Offset: 0x0008401C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203095, XrefRangeEnd = 203100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetIPCountry()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00085E48 File Offset: 0x00084048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203100, XrefRangeEnd = 203104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetImageSize(int iImage, out uint pnWidth, out uint pnHeight)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iImage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnWidth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00085EA4 File Offset: 0x000840A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203104, XrefRangeEnd = 203108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetImageRGBA(int iImage, Il2CppStructArray<byte> pubDest, int nDestBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iImage;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pubDest);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDestBufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00085F04 File Offset: 0x00084104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203108, XrefRangeEnd = 203112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetCSERIPPort(out uint unIP, out ushort usPort)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &unIP;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &usPort;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x00085F50 File Offset: 0x00084150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203112, XrefRangeEnd = 203116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetCurrentBatteryPower()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x00085F80 File Offset: 0x00084180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203124, RefRangeEnd = 203125, XrefRangeStart = 203116, XrefRangeEnd = 203124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppId_t GetAppID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00085FB0 File Offset: 0x000841B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203125, XrefRangeEnd = 203129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eNotificationPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x00085FE4 File Offset: 0x000841E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203129, XrefRangeEnd = 203133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAPICallCompleted(SteamAPICall_t hSteamAPICall, out bool pbFailed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x00086030 File Offset: 0x00084230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203133, XrefRangeEnd = 203137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00086070 File Offset: 0x00084270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203137, XrefRangeEnd = 203141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAPICallResult(SteamAPICall_t hSteamAPICall, IntPtr pCallback, int cubCallback, int iCallbackExpected, out bool pbFailed)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pCallback;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubCallback;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iCallbackExpected;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pbFailed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000860E8 File Offset: 0x000842E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203141, XrefRangeEnd = 203145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetIPCCallCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x00086118 File Offset: 0x00084318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203145, XrefRangeEnd = 203149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00086150 File Offset: 0x00084350
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203153, RefRangeEnd = 203154, XrefRangeStart = 203149, XrefRangeEnd = 203153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOverlayEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00086180 File Offset: 0x00084380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203154, XrefRangeEnd = 203158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BOverlayNeedsPresent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000861B0 File Offset: 0x000843B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203158, XrefRangeEnd = 203174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(szFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000861F4 File Offset: 0x000843F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203174, XrefRangeEnd = 203193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShowGamepadTextInput(EGamepadTextInputMode eInputMode, EGamepadTextInputLineMode eLineInputMode, string pchDescription, uint unCharMax, string pchExistingText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eInputMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLineInputMode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchDescription);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unCharMax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExistingText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00086274 File Offset: 0x00084474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203193, XrefRangeEnd = 203197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetEnteredGamepadTextLength()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000862A4 File Offset: 0x000844A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203197, XrefRangeEnd = 203210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEnteredGamepadTextInput(out string pchText, uint cchText)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchText;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000862FC File Offset: 0x000844FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203210, XrefRangeEnd = 203215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSteamUILanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00086328 File Offset: 0x00084528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203215, XrefRangeEnd = 203219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamRunningInVR()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00086358 File Offset: 0x00084558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203219, XrefRangeEnd = 203223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOverlayNotificationInset(int nHorizontalInset, int nVerticalInset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nHorizontalInset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nVerticalInset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00086398 File Offset: 0x00084598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203223, XrefRangeEnd = 203227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamInBigPictureMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000863C8 File Offset: 0x000845C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203227, XrefRangeEnd = 203231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartVRDashboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000863F0 File Offset: 0x000845F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203231, XrefRangeEnd = 203235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVRHeadsetStreamingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00086420 File Offset: 0x00084620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203235, XrefRangeEnd = 203239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00086454 File Offset: 0x00084654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203239, XrefRangeEnd = 203243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamChinaLauncher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00086484 File Offset: 0x00084684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203243, XrefRangeEnd = 203247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitFilterText(uint unFilterOptions = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unFilterOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x000864C4 File Offset: 0x000846C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203247, XrefRangeEnd = 203268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FilterText(ETextFilteringContext eContext, CSteamID sourceSteamID, string pchInputMessage, out string pchOutFilteredText, uint nByteSizeOutFilteredText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eContext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sourceSteamID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchInputMessage);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nByteSizeOutFilteredText;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchOutFilteredText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x0008654C File Offset: 0x0008474C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203268, XrefRangeEnd = 203272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eProtocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x0000BB35 File Offset: 0x00009D35
		public SteamUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0;

		// Token: 0x040016BC RID: 5820
		private static readonly IntPtr NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0;

		// Token: 0x040016BD RID: 5821
		private static readonly IntPtr NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x040016BE RID: 5822
		private static readonly IntPtr NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0;

		// Token: 0x040016BF RID: 5823
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0;

		// Token: 0x040016C0 RID: 5824
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0;

		// Token: 0x040016C1 RID: 5825
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0;

		// Token: 0x040016C2 RID: 5826
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0;

		// Token: 0x040016C3 RID: 5827
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0;

		// Token: 0x040016C4 RID: 5828
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0;

		// Token: 0x040016C5 RID: 5829
		private static readonly IntPtr NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0;

		// Token: 0x040016C6 RID: 5830
		private static readonly IntPtr NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0;

		// Token: 0x040016C7 RID: 5831
		private static readonly IntPtr NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0;

		// Token: 0x040016C8 RID: 5832
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0;

		// Token: 0x040016C9 RID: 5833
		private static readonly IntPtr NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0;

		// Token: 0x040016CA RID: 5834
		private static readonly IntPtr NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0;

		// Token: 0x040016CB RID: 5835
		private static readonly IntPtr NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0;
	}
}
