using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000157 RID: 343
	public static class SteamGameServerUtils : Object
	{
		// Token: 0x06001A4C RID: 6732 RVA: 0x00076B74 File Offset: 0x00074D74
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameServerUtils()
		{
			Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameServerUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr);
			SteamGameServerUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666746);
			SteamGameServerUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666747);
			SteamGameServerUtils.NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666748);
			SteamGameServerUtils.NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666749);
			SteamGameServerUtils.NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666750);
			SteamGameServerUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666751);
			SteamGameServerUtils.NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666752);
			SteamGameServerUtils.NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666753);
			SteamGameServerUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666754);
			SteamGameServerUtils.NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666755);
			SteamGameServerUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666756);
			SteamGameServerUtils.NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666757);
			SteamGameServerUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666758);
			SteamGameServerUtils.NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666759);
			SteamGameServerUtils.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666760);
			SteamGameServerUtils.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666761);
			SteamGameServerUtils.NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666762);
			SteamGameServerUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666763);
			SteamGameServerUtils.NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666764);
			SteamGameServerUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666765);
			SteamGameServerUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666766);
			SteamGameServerUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666767);
			SteamGameServerUtils.NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666768);
			SteamGameServerUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666769);
			SteamGameServerUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666770);
			SteamGameServerUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666771);
			SteamGameServerUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666772);
			SteamGameServerUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666773);
			SteamGameServerUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666774);
			SteamGameServerUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666775);
			SteamGameServerUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666776);
			SteamGameServerUtils.NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666777);
			SteamGameServerUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameServerUtils>.NativeClassPtr, 100666778);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00076E38 File Offset: 0x00075038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198680, XrefRangeEnd = 198684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSecondsSinceAppActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x00076E68 File Offset: 0x00075068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198684, XrefRangeEnd = 198688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSecondsSinceComputerActive()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x00076E98 File Offset: 0x00075098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198688, XrefRangeEnd = 198692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EUniverse GetConnectedUniverse()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x00076EC8 File Offset: 0x000750C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198692, XrefRangeEnd = 198696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetServerRealTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00076EF8 File Offset: 0x000750F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198696, XrefRangeEnd = 198701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetIPCountry()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00076F24 File Offset: 0x00075124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198701, XrefRangeEnd = 198705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x00076F80 File Offset: 0x00075180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198705, XrefRangeEnd = 198709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x00076FE0 File Offset: 0x000751E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198709, XrefRangeEnd = 198713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0007702C File Offset: 0x0007522C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198713, XrefRangeEnd = 198717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static byte GetCurrentBatteryPower()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0007705C File Offset: 0x0007525C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198717, XrefRangeEnd = 198725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppId_t GetAppID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0007708C File Offset: 0x0007528C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198725, XrefRangeEnd = 198729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOverlayNotificationPosition(ENotificationPosition eNotificationPosition)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eNotificationPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x000770C0 File Offset: 0x000752C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198729, XrefRangeEnd = 198733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0007710C File Offset: 0x0007530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198733, XrefRangeEnd = 198737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamAPICallFailure GetAPICallFailureReason(SteamAPICall_t hSteamAPICall)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hSteamAPICall;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0007714C File Offset: 0x0007534C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198737, XrefRangeEnd = 198741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000771C4 File Offset: 0x000753C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198741, XrefRangeEnd = 198745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetIPCCallCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000771F4 File Offset: 0x000753F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198745, XrefRangeEnd = 198749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetWarningMessageHook(SteamAPIWarningMessageHook_t pFunction)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pFunction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0007722C File Offset: 0x0007542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198749, XrefRangeEnd = 198753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsOverlayEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0007725C File Offset: 0x0007545C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198753, XrefRangeEnd = 198757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BOverlayNeedsPresent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0007728C File Offset: 0x0007548C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198757, XrefRangeEnd = 198773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CheckFileSignature(string szFileName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(szFileName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x000772D0 File Offset: 0x000754D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198773, XrefRangeEnd = 198792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x00077350 File Offset: 0x00075550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198792, XrefRangeEnd = 198796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetEnteredGamepadTextLength()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x00077380 File Offset: 0x00075580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198796, XrefRangeEnd = 198809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000773D8 File Offset: 0x000755D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198809, XrefRangeEnd = 198814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSteamUILanguage()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x00077404 File Offset: 0x00075604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198814, XrefRangeEnd = 198818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamRunningInVR()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x00077434 File Offset: 0x00075634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198818, XrefRangeEnd = 198822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x00077474 File Offset: 0x00075674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198822, XrefRangeEnd = 198826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamInBigPictureMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x000774A4 File Offset: 0x000756A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198826, XrefRangeEnd = 198830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartVRDashboard()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x000774CC File Offset: 0x000756CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198830, XrefRangeEnd = 198834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVRHeadsetStreamingEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x000774FC File Offset: 0x000756FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198834, XrefRangeEnd = 198838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetVRHeadsetStreamingEnabled(bool bEnabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x00077530 File Offset: 0x00075730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198838, XrefRangeEnd = 198842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSteamChinaLauncher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x00077560 File Offset: 0x00075760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198842, XrefRangeEnd = 198846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitFilterText(uint unFilterOptions = 0U)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unFilterOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x000775A0 File Offset: 0x000757A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198846, XrefRangeEnd = 198867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchOutFilteredText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x00077628 File Offset: 0x00075828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198867, XrefRangeEnd = 198871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamIPv6ConnectivityState GetIPv6ConnectivityState(ESteamIPv6ConnectivityProtocol eProtocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eProtocol;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameServerUtils.NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0000BA6F File Offset: 0x00009C6F
		public SteamGameServerUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceAppActive_Public_Static_UInt32_0;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeMethodInfoPtr_GetSecondsSinceComputerActive_Public_Static_UInt32_0;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeMethodInfoPtr_GetConnectedUniverse_Public_Static_EUniverse_0;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeMethodInfoPtr_GetServerRealTime_Public_Static_UInt32_0;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCountry_Public_Static_String_0;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeMethodInfoPtr_GetImageSize_Public_Static_Boolean_Int32_byref_UInt32_byref_UInt32_0;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_GetImageRGBA_Public_Static_Boolean_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_GetCSERIPPort_Public_Static_Boolean_byref_UInt32_byref_UInt16_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentBatteryPower_Public_Static_Byte_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_GetAppID_Public_Static_AppId_t_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationPosition_Public_Static_Void_ENotificationPosition_0;

		// Token: 0x04001451 RID: 5201
		private static readonly IntPtr NativeMethodInfoPtr_IsAPICallCompleted_Public_Static_Boolean_SteamAPICall_t_byref_Boolean_0;

		// Token: 0x04001452 RID: 5202
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallFailureReason_Public_Static_ESteamAPICallFailure_SteamAPICall_t_0;

		// Token: 0x04001453 RID: 5203
		private static readonly IntPtr NativeMethodInfoPtr_GetAPICallResult_Public_Static_Boolean_SteamAPICall_t_IntPtr_Int32_Int32_byref_Boolean_0;

		// Token: 0x04001454 RID: 5204
		private static readonly IntPtr NativeMethodInfoPtr_GetIPCCallCount_Public_Static_UInt32_0;

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeMethodInfoPtr_SetWarningMessageHook_Public_Static_Void_SteamAPIWarningMessageHook_t_0;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_IsOverlayEnabled_Public_Static_Boolean_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_BOverlayNeedsPresent_Public_Static_Boolean_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr_CheckFileSignature_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x04001459 RID: 5209
		private static readonly IntPtr NativeMethodInfoPtr_ShowGamepadTextInput_Public_Static_Boolean_EGamepadTextInputMode_EGamepadTextInputLineMode_String_UInt32_String_0;

		// Token: 0x0400145A RID: 5210
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextLength_Public_Static_UInt32_0;

		// Token: 0x0400145B RID: 5211
		private static readonly IntPtr NativeMethodInfoPtr_GetEnteredGamepadTextInput_Public_Static_Boolean_byref_String_UInt32_0;

		// Token: 0x0400145C RID: 5212
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamUILanguage_Public_Static_String_0;

		// Token: 0x0400145D RID: 5213
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamRunningInVR_Public_Static_Boolean_0;

		// Token: 0x0400145E RID: 5214
		private static readonly IntPtr NativeMethodInfoPtr_SetOverlayNotificationInset_Public_Static_Void_Int32_Int32_0;

		// Token: 0x0400145F RID: 5215
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamInBigPictureMode_Public_Static_Boolean_0;

		// Token: 0x04001460 RID: 5216
		private static readonly IntPtr NativeMethodInfoPtr_StartVRDashboard_Public_Static_Void_0;

		// Token: 0x04001461 RID: 5217
		private static readonly IntPtr NativeMethodInfoPtr_IsVRHeadsetStreamingEnabled_Public_Static_Boolean_0;

		// Token: 0x04001462 RID: 5218
		private static readonly IntPtr NativeMethodInfoPtr_SetVRHeadsetStreamingEnabled_Public_Static_Void_Boolean_0;

		// Token: 0x04001463 RID: 5219
		private static readonly IntPtr NativeMethodInfoPtr_IsSteamChinaLauncher_Public_Static_Boolean_0;

		// Token: 0x04001464 RID: 5220
		private static readonly IntPtr NativeMethodInfoPtr_InitFilterText_Public_Static_Boolean_UInt32_0;

		// Token: 0x04001465 RID: 5221
		private static readonly IntPtr NativeMethodInfoPtr_FilterText_Public_Static_Int32_ETextFilteringContext_CSteamID_String_byref_String_UInt32_0;

		// Token: 0x04001466 RID: 5222
		private static readonly IntPtr NativeMethodInfoPtr_GetIPv6ConnectivityState_Public_Static_ESteamIPv6ConnectivityState_ESteamIPv6ConnectivityProtocol_0;
	}
}
