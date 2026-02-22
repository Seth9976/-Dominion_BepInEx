using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015E RID: 350
	public static class SteamGameSearch : Object
	{
		// Token: 0x06001B39 RID: 6969 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
		// Note: this type is marked as 'beforefieldinit'.
		static SteamGameSearch()
		{
			Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamGameSearch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr);
			SteamGameSearch.NativeMethodInfoPtr_AddGameSearchParams_Public_Static_EGameSearchErrorCode_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666969);
			SteamGameSearch.NativeMethodInfoPtr_SearchForGameWithLobby_Public_Static_EGameSearchErrorCode_t_CSteamID_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666970);
			SteamGameSearch.NativeMethodInfoPtr_SearchForGameSolo_Public_Static_EGameSearchErrorCode_t_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666971);
			SteamGameSearch.NativeMethodInfoPtr_AcceptGame_Public_Static_EGameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666972);
			SteamGameSearch.NativeMethodInfoPtr_DeclineGame_Public_Static_EGameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666973);
			SteamGameSearch.NativeMethodInfoPtr_RetrieveConnectionDetails_Public_Static_EGameSearchErrorCode_t_CSteamID_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666974);
			SteamGameSearch.NativeMethodInfoPtr_EndGameSearch_Public_Static_EGameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666975);
			SteamGameSearch.NativeMethodInfoPtr_SetGameHostParams_Public_Static_EGameSearchErrorCode_t_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666976);
			SteamGameSearch.NativeMethodInfoPtr_SetConnectionDetails_Public_Static_EGameSearchErrorCode_t_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666977);
			SteamGameSearch.NativeMethodInfoPtr_RequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666978);
			SteamGameSearch.NativeMethodInfoPtr_HostConfirmGameStart_Public_Static_EGameSearchErrorCode_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666979);
			SteamGameSearch.NativeMethodInfoPtr_CancelRequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666980);
			SteamGameSearch.NativeMethodInfoPtr_SubmitPlayerResult_Public_Static_EGameSearchErrorCode_t_UInt64_CSteamID_EPlayerResult_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666981);
			SteamGameSearch.NativeMethodInfoPtr_EndGame_Public_Static_EGameSearchErrorCode_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamGameSearch>.NativeClassPtr, 100666982);
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0007C228 File Offset: 0x0007A428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200187, XrefRangeEnd = 200206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t AddGameSearchParams(string pchKeyToFind, string pchValuesToFind)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToFind);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValuesToFind);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_AddGameSearchParams_Public_Static_EGameSearchErrorCode_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x0007C27C File Offset: 0x0007A47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200206, XrefRangeEnd = 200210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t SearchForGameWithLobby(CSteamID steamIDLobby, int nPlayerMin, int nPlayerMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_SearchForGameWithLobby_Public_Static_EGameSearchErrorCode_t_CSteamID_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x0007C2D8 File Offset: 0x0007A4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200210, XrefRangeEnd = 200214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t SearchForGameSolo(int nPlayerMin, int nPlayerMax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPlayerMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_SearchForGameSolo_Public_Static_EGameSearchErrorCode_t_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x0007C324 File Offset: 0x0007A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200214, XrefRangeEnd = 200218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t AcceptGame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_AcceptGame_Public_Static_EGameSearchErrorCode_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x0007C354 File Offset: 0x0007A554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200218, XrefRangeEnd = 200222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t DeclineGame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_DeclineGame_Public_Static_EGameSearchErrorCode_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x0007C384 File Offset: 0x0007A584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200222, XrefRangeEnd = 200234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t RetrieveConnectionDetails(CSteamID steamIDHost, out string pchConnectionDetails, int cubConnectionDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDHost;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubConnectionDetails;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_RetrieveConnectionDetails_Public_Static_EGameSearchErrorCode_t_CSteamID_byref_String_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pchConnectionDetails = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x0007C3EC File Offset: 0x0007A5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200234, XrefRangeEnd = 200238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t EndGameSearch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_EndGameSearch_Public_Static_EGameSearchErrorCode_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x0007C41C File Offset: 0x0007A61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200238, XrefRangeEnd = 200257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t SetGameHostParams(string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_SetGameHostParams_Public_Static_EGameSearchErrorCode_t_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x0007C470 File Offset: 0x0007A670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200257, XrefRangeEnd = 200269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t SetConnectionDetails(string pchConnectionDetails, int cubConnectionDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchConnectionDetails);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubConnectionDetails;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_SetConnectionDetails_Public_Static_EGameSearchErrorCode_t_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x0007C4C0 File Offset: 0x0007A6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200269, XrefRangeEnd = 200273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t RequestPlayersForGame(int nPlayerMin, int nPlayerMax, int nMaxTeamSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nPlayerMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nPlayerMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMaxTeamSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_RequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x0007C51C File Offset: 0x0007A71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200273, XrefRangeEnd = 200277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t HostConfirmGameStart(ulong ullUniqueGameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_HostConfirmGameStart_Public_Static_EGameSearchErrorCode_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x0007C55C File Offset: 0x0007A75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200277, XrefRangeEnd = 200281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t CancelRequestPlayersForGame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_CancelRequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x0007C58C File Offset: 0x0007A78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200281, XrefRangeEnd = 200285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t SubmitPlayerResult(ulong ullUniqueGameID, CSteamID steamIDPlayer, EPlayerResult_t EPlayerResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDPlayer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref EPlayerResult;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_SubmitPlayerResult_Public_Static_EGameSearchErrorCode_t_UInt64_CSteamID_EPlayerResult_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x0007C5E8 File Offset: 0x0007A7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200285, XrefRangeEnd = 200289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EGameSearchErrorCode_t EndGame(ulong ullUniqueGameID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ullUniqueGameID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamGameSearch.NativeMethodInfoPtr_EndGame_Public_Static_EGameSearchErrorCode_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x0000BAAE File Offset: 0x00009CAE
		public SteamGameSearch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_AddGameSearchParams_Public_Static_EGameSearchErrorCode_t_String_String_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_SearchForGameWithLobby_Public_Static_EGameSearchErrorCode_t_CSteamID_Int32_Int32_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_SearchForGameSolo_Public_Static_EGameSearchErrorCode_t_Int32_Int32_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_AcceptGame_Public_Static_EGameSearchErrorCode_t_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_DeclineGame_Public_Static_EGameSearchErrorCode_t_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveConnectionDetails_Public_Static_EGameSearchErrorCode_t_CSteamID_byref_String_Int32_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_EndGameSearch_Public_Static_EGameSearchErrorCode_t_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_SetGameHostParams_Public_Static_EGameSearchErrorCode_t_String_String_0;

		// Token: 0x0400152D RID: 5421
		private static readonly IntPtr NativeMethodInfoPtr_SetConnectionDetails_Public_Static_EGameSearchErrorCode_t_String_Int32_0;

		// Token: 0x0400152E RID: 5422
		private static readonly IntPtr NativeMethodInfoPtr_RequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_Int32_Int32_Int32_0;

		// Token: 0x0400152F RID: 5423
		private static readonly IntPtr NativeMethodInfoPtr_HostConfirmGameStart_Public_Static_EGameSearchErrorCode_t_UInt64_0;

		// Token: 0x04001530 RID: 5424
		private static readonly IntPtr NativeMethodInfoPtr_CancelRequestPlayersForGame_Public_Static_EGameSearchErrorCode_t_0;

		// Token: 0x04001531 RID: 5425
		private static readonly IntPtr NativeMethodInfoPtr_SubmitPlayerResult_Public_Static_EGameSearchErrorCode_t_UInt64_CSteamID_EPlayerResult_t_0;

		// Token: 0x04001532 RID: 5426
		private static readonly IntPtr NativeMethodInfoPtr_EndGame_Public_Static_EGameSearchErrorCode_t_UInt64_0;
	}
}
