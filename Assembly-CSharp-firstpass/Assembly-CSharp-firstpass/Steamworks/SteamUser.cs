using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200016B RID: 363
	public static class SteamUser : Object
	{
		// Token: 0x06001C8C RID: 7308 RVA: 0x00083D5C File Offset: 0x00081F5C
		// Note: this type is marked as 'beforefieldinit'.
		static SteamUser()
		{
			Il2CppClassPointerStore<SteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamUser>.NativeClassPtr);
			SteamUser.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667282);
			SteamUser.NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667283);
			SteamUser.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667284);
			SteamUser.NativeMethodInfoPtr_InitiateGameConnection_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_CSteamID_UInt32_UInt16_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667285);
			SteamUser.NativeMethodInfoPtr_TerminateGameConnection_Public_Static_Void_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667286);
			SteamUser.NativeMethodInfoPtr_TrackAppUsageEvent_Public_Static_Void_CGameID_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667287);
			SteamUser.NativeMethodInfoPtr_GetUserDataFolder_Public_Static_Boolean_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667288);
			SteamUser.NativeMethodInfoPtr_StartVoiceRecording_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667289);
			SteamUser.NativeMethodInfoPtr_StopVoiceRecording_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667290);
			SteamUser.NativeMethodInfoPtr_GetAvailableVoice_Public_Static_EVoiceResult_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667291);
			SteamUser.NativeMethodInfoPtr_GetVoice_Public_Static_EVoiceResult_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667292);
			SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_EVoiceResult_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667293);
			SteamUser.NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667294);
			SteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667295);
			SteamUser.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667296);
			SteamUser.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667297);
			SteamUser.NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667298);
			SteamUser.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667299);
			SteamUser.NativeMethodInfoPtr_BIsBehindNAT_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667300);
			SteamUser.NativeMethodInfoPtr_AdvertiseGame_Public_Static_Void_CSteamID_UInt32_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667301);
			SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicket_Public_Static_SteamAPICall_t_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667302);
			SteamUser.NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667303);
			SteamUser.NativeMethodInfoPtr_GetGameBadgeLevel_Public_Static_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667304);
			SteamUser.NativeMethodInfoPtr_GetPlayerSteamLevel_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667305);
			SteamUser.NativeMethodInfoPtr_RequestStoreAuthURL_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667306);
			SteamUser.NativeMethodInfoPtr_BIsPhoneVerified_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667307);
			SteamUser.NativeMethodInfoPtr_BIsTwoFactorEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667308);
			SteamUser.NativeMethodInfoPtr_BIsPhoneIdentifying_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667309);
			SteamUser.NativeMethodInfoPtr_BIsPhoneRequiringVerification_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667310);
			SteamUser.NativeMethodInfoPtr_GetMarketEligibility_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667311);
			SteamUser.NativeMethodInfoPtr_GetDurationControl_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667312);
			SteamUser.NativeMethodInfoPtr_BSetDurationControlOnlineState_Public_Static_Boolean_EDurationControlOnlineState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamUser>.NativeClassPtr, 100667313);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0008400C File Offset: 0x0008220C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202447, XrefRangeEnd = 202452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HSteamUser GetHSteamUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0008403C File Offset: 0x0008223C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202452, XrefRangeEnd = 202456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BLoggedOn()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0008406C File Offset: 0x0008226C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202464, RefRangeEnd = 202466, XrefRangeStart = 202456, XrefRangeEnd = 202464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetSteamID()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0008409C File Offset: 0x0008229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202466, XrefRangeEnd = 202470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InitiateGameConnection(Il2CppStructArray<byte> pAuthBlob, int cbMaxAuthBlob, CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer, bool bSecure)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pAuthBlob);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxAuthBlob;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSecure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_InitiateGameConnection_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_CSteamID_UInt32_UInt16_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x00084124 File Offset: 0x00082324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202470, XrefRangeEnd = 202474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TerminateGameConnection(uint unIPServer, ushort usPortServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unIPServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_TerminateGameConnection_Public_Static_Void_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00084164 File Offset: 0x00082364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202474, XrefRangeEnd = 202486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackAppUsageEvent(CGameID gameID, int eAppUsageEvent, string pchExtraInfo = "")
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref gameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eAppUsageEvent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchExtraInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_TrackAppUsageEvent_Public_Static_Void_CGameID_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x000841B8 File Offset: 0x000823B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202486, XrefRangeEnd = 202499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetUserDataFolder(out string pchBuffer, int cubBuffer)
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
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubBuffer;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetUserDataFolder_Public_Static_Boolean_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchBuffer = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00084210 File Offset: 0x00082410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202499, XrefRangeEnd = 202503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StartVoiceRecording()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_StartVoiceRecording_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00084238 File Offset: 0x00082438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202503, XrefRangeEnd = 202507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void StopVoiceRecording()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_StopVoiceRecording_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00084260 File Offset: 0x00082460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202507, XrefRangeEnd = 202512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EVoiceResult GetAvailableVoice(out uint pcbCompressed)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pcbCompressed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetAvailableVoice_Public_Static_EVoiceResult_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x000842A0 File Offset: 0x000824A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202512, XrefRangeEnd = 202517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EVoiceResult GetVoice(bool bWantCompressed, Il2CppStructArray<byte> pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bWantCompressed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pDestBuffer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetVoice_Public_Static_EVoiceResult_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0008430C File Offset: 0x0008250C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202517, XrefRangeEnd = 202521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EVoiceResult DecompressVoice(Il2CppStructArray<byte> pCompressed, uint cbCompressed, Il2CppStructArray<byte> pDestBuffer, uint cbDestBufferSize, out uint nBytesWritten, uint nDesiredSampleRate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pCompressed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbCompressed;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pDestBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDestBufferSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nBytesWritten;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nDesiredSampleRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_DecompressVoice_Public_Static_EVoiceResult_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00084398 File Offset: 0x00082598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202521, XrefRangeEnd = 202525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetVoiceOptimalSampleRate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000843C8 File Offset: 0x000825C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202525, XrefRangeEnd = 202533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HAuthTicket GetAuthSessionTicket(Il2CppStructArray<byte> pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pTicket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00084428 File Offset: 0x00082628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202533, XrefRangeEnd = 202537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EBeginAuthSessionResult BeginAuthSession(Il2CppStructArray<byte> pAuthTicket, int cbAuthTicket, CSteamID steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pAuthTicket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbAuthTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00084488 File Offset: 0x00082688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202537, XrefRangeEnd = 202541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndAuthSession(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x000844BC File Offset: 0x000826BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202541, XrefRangeEnd = 202545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancelAuthTicket(HAuthTicket hAuthTicket)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hAuthTicket;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x000844F0 File Offset: 0x000826F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202545, XrefRangeEnd = 202549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EUserHasLicenseForAppResult UserHasLicenseForApp(CSteamID steamID, AppId_t appID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref appID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0008453C File Offset: 0x0008273C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202549, XrefRangeEnd = 202553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsBehindNAT()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BIsBehindNAT_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0008456C File Offset: 0x0008276C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202553, XrefRangeEnd = 202557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdvertiseGame(CSteamID steamIDGameServer, uint unIPServer, ushort usPortServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDGameServer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unIPServer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref usPortServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_AdvertiseGame_Public_Static_Void_CSteamID_UInt32_UInt16_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000845BC File Offset: 0x000827BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202557, XrefRangeEnd = 202565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestEncryptedAppTicket(Il2CppStructArray<byte> pDataToInclude, int cbDataToInclude)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pDataToInclude);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbDataToInclude;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_RequestEncryptedAppTicket_Public_Static_SteamAPICall_t_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0008460C File Offset: 0x0008280C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202565, XrefRangeEnd = 202569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetEncryptedAppTicket(Il2CppStructArray<byte> pTicket, int cbMaxTicket, out uint pcbTicket)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pTicket);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cbMaxTicket;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pcbTicket;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0008466C File Offset: 0x0008286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202569, XrefRangeEnd = 202573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetGameBadgeLevel(int nSeries, bool bFoil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeries;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bFoil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetGameBadgeLevel_Public_Static_Int32_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x000846B8 File Offset: 0x000828B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202573, XrefRangeEnd = 202577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetPlayerSteamLevel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetPlayerSteamLevel_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x000846E8 File Offset: 0x000828E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202577, XrefRangeEnd = 202593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestStoreAuthURL(string pchRedirectURL)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchRedirectURL);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_RequestStoreAuthURL_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0008472C File Offset: 0x0008292C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202593, XrefRangeEnd = 202597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsPhoneVerified()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BIsPhoneVerified_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x0008475C File Offset: 0x0008295C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202597, XrefRangeEnd = 202601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsTwoFactorEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BIsTwoFactorEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x0008478C File Offset: 0x0008298C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202601, XrefRangeEnd = 202605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsPhoneIdentifying()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BIsPhoneIdentifying_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000847BC File Offset: 0x000829BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202605, XrefRangeEnd = 202609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BIsPhoneRequiringVerification()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BIsPhoneRequiringVerification_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x000847EC File Offset: 0x000829EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202609, XrefRangeEnd = 202617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetMarketEligibility()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetMarketEligibility_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x0008481C File Offset: 0x00082A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202617, XrefRangeEnd = 202625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetDurationControl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_GetDurationControl_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x0008484C File Offset: 0x00082A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202625, XrefRangeEnd = 202629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BSetDurationControlOnlineState(EDurationControlOnlineState eNewState)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eNewState;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamUser.NativeMethodInfoPtr_BSetDurationControlOnlineState_Public_Static_Boolean_EDurationControlOnlineState_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0000BB23 File Offset: 0x00009D23
		public SteamUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr_GetHSteamUser_Public_Static_HSteamUser_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_BLoggedOn_Public_Static_Boolean_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_GetSteamID_Public_Static_CSteamID_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_InitiateGameConnection_Public_Static_Int32_Il2CppStructArray_1_Byte_Int32_CSteamID_UInt32_UInt16_Boolean_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_TerminateGameConnection_Public_Static_Void_UInt32_UInt16_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_TrackAppUsageEvent_Public_Static_Void_CGameID_Int32_String_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_GetUserDataFolder_Public_Static_Boolean_byref_String_Int32_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_StartVoiceRecording_Public_Static_Void_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_StopVoiceRecording_Public_Static_Void_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailableVoice_Public_Static_EVoiceResult_byref_UInt32_0;

		// Token: 0x04001668 RID: 5736
		private static readonly IntPtr NativeMethodInfoPtr_GetVoice_Public_Static_EVoiceResult_Boolean_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_0;

		// Token: 0x04001669 RID: 5737
		private static readonly IntPtr NativeMethodInfoPtr_DecompressVoice_Public_Static_EVoiceResult_Il2CppStructArray_1_Byte_UInt32_Il2CppStructArray_1_Byte_UInt32_byref_UInt32_UInt32_0;

		// Token: 0x0400166A RID: 5738
		private static readonly IntPtr NativeMethodInfoPtr_GetVoiceOptimalSampleRate_Public_Static_UInt32_0;

		// Token: 0x0400166B RID: 5739
		private static readonly IntPtr NativeMethodInfoPtr_GetAuthSessionTicket_Public_Static_HAuthTicket_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

		// Token: 0x0400166C RID: 5740
		private static readonly IntPtr NativeMethodInfoPtr_BeginAuthSession_Public_Static_EBeginAuthSessionResult_Il2CppStructArray_1_Byte_Int32_CSteamID_0;

		// Token: 0x0400166D RID: 5741
		private static readonly IntPtr NativeMethodInfoPtr_EndAuthSession_Public_Static_Void_CSteamID_0;

		// Token: 0x0400166E RID: 5742
		private static readonly IntPtr NativeMethodInfoPtr_CancelAuthTicket_Public_Static_Void_HAuthTicket_0;

		// Token: 0x0400166F RID: 5743
		private static readonly IntPtr NativeMethodInfoPtr_UserHasLicenseForApp_Public_Static_EUserHasLicenseForAppResult_CSteamID_AppId_t_0;

		// Token: 0x04001670 RID: 5744
		private static readonly IntPtr NativeMethodInfoPtr_BIsBehindNAT_Public_Static_Boolean_0;

		// Token: 0x04001671 RID: 5745
		private static readonly IntPtr NativeMethodInfoPtr_AdvertiseGame_Public_Static_Void_CSteamID_UInt32_UInt16_0;

		// Token: 0x04001672 RID: 5746
		private static readonly IntPtr NativeMethodInfoPtr_RequestEncryptedAppTicket_Public_Static_SteamAPICall_t_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001673 RID: 5747
		private static readonly IntPtr NativeMethodInfoPtr_GetEncryptedAppTicket_Public_Static_Boolean_Il2CppStructArray_1_Byte_Int32_byref_UInt32_0;

		// Token: 0x04001674 RID: 5748
		private static readonly IntPtr NativeMethodInfoPtr_GetGameBadgeLevel_Public_Static_Int32_Int32_Boolean_0;

		// Token: 0x04001675 RID: 5749
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerSteamLevel_Public_Static_Int32_0;

		// Token: 0x04001676 RID: 5750
		private static readonly IntPtr NativeMethodInfoPtr_RequestStoreAuthURL_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x04001677 RID: 5751
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneVerified_Public_Static_Boolean_0;

		// Token: 0x04001678 RID: 5752
		private static readonly IntPtr NativeMethodInfoPtr_BIsTwoFactorEnabled_Public_Static_Boolean_0;

		// Token: 0x04001679 RID: 5753
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneIdentifying_Public_Static_Boolean_0;

		// Token: 0x0400167A RID: 5754
		private static readonly IntPtr NativeMethodInfoPtr_BIsPhoneRequiringVerification_Public_Static_Boolean_0;

		// Token: 0x0400167B RID: 5755
		private static readonly IntPtr NativeMethodInfoPtr_GetMarketEligibility_Public_Static_SteamAPICall_t_0;

		// Token: 0x0400167C RID: 5756
		private static readonly IntPtr NativeMethodInfoPtr_GetDurationControl_Public_Static_SteamAPICall_t_0;

		// Token: 0x0400167D RID: 5757
		private static readonly IntPtr NativeMethodInfoPtr_BSetDurationControlOnlineState_Public_Static_Boolean_EDurationControlOnlineState_0;
	}
}
