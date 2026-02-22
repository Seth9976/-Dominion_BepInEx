using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x02000167 RID: 359
	public static class SteamRemotePlay : Object
	{
		// Token: 0x06001BEE RID: 7150 RVA: 0x000800CC File Offset: 0x0007E2CC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamRemotePlay()
		{
			Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamRemotePlay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr);
			SteamRemotePlay.NativeMethodInfoPtr_GetSessionCount_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667132);
			SteamRemotePlay.NativeMethodInfoPtr_GetSessionID_Public_Static_RemotePlaySessionID_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667133);
			SteamRemotePlay.NativeMethodInfoPtr_GetSessionSteamID_Public_Static_CSteamID_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667134);
			SteamRemotePlay.NativeMethodInfoPtr_GetSessionClientName_Public_Static_String_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667135);
			SteamRemotePlay.NativeMethodInfoPtr_GetSessionClientFormFactor_Public_Static_ESteamDeviceFormFactor_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667136);
			SteamRemotePlay.NativeMethodInfoPtr_BGetSessionClientResolution_Public_Static_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667137);
			SteamRemotePlay.NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamRemotePlay>.NativeClassPtr, 100667138);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00080188 File Offset: 0x0007E388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201081, XrefRangeEnd = 201085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetSessionCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSessionCount_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x000801B8 File Offset: 0x0007E3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201085, XrefRangeEnd = 201090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RemotePlaySessionID_t GetSessionID(int iSessionIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iSessionIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSessionID_Public_Static_RemotePlaySessionID_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x000801F8 File Offset: 0x0007E3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201090, XrefRangeEnd = 201098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetSessionSteamID(RemotePlaySessionID_t unSessionID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSessionSteamID_Public_Static_CSteamID_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00080238 File Offset: 0x0007E438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201098, XrefRangeEnd = 201103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSessionClientName(RemotePlaySessionID_t unSessionID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSessionClientName_Public_Static_String_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001BF3 RID: 7155 RVA: 0x00080270 File Offset: 0x0007E470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201103, XrefRangeEnd = 201107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ESteamDeviceFormFactor GetSessionClientFormFactor(RemotePlaySessionID_t unSessionID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_GetSessionClientFormFactor_Public_Static_ESteamDeviceFormFactor_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x000802B0 File Offset: 0x0007E4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201107, XrefRangeEnd = 201111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BGetSessionClientResolution(RemotePlaySessionID_t unSessionID, out int pnResolutionX, out int pnResolutionY)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unSessionID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionX;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnResolutionY;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_BGetSessionClientResolution_Public_Static_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x0008030C File Offset: 0x0007E50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 201111, XrefRangeEnd = 201115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool BSendRemotePlayTogetherInvite(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamRemotePlay.NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x0000BAFF File Offset: 0x00009CFF
		public SteamRemotePlay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040015C8 RID: 5576
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionCount_Public_Static_UInt32_0;

		// Token: 0x040015C9 RID: 5577
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionID_Public_Static_RemotePlaySessionID_t_Int32_0;

		// Token: 0x040015CA RID: 5578
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionSteamID_Public_Static_CSteamID_RemotePlaySessionID_t_0;

		// Token: 0x040015CB RID: 5579
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionClientName_Public_Static_String_RemotePlaySessionID_t_0;

		// Token: 0x040015CC RID: 5580
		private static readonly IntPtr NativeMethodInfoPtr_GetSessionClientFormFactor_Public_Static_ESteamDeviceFormFactor_RemotePlaySessionID_t_0;

		// Token: 0x040015CD RID: 5581
		private static readonly IntPtr NativeMethodInfoPtr_BGetSessionClientResolution_Public_Static_Boolean_RemotePlaySessionID_t_byref_Int32_byref_Int32_0;

		// Token: 0x040015CE RID: 5582
		private static readonly IntPtr NativeMethodInfoPtr_BSendRemotePlayTogetherInvite_Public_Static_Boolean_CSteamID_0;
	}
}
