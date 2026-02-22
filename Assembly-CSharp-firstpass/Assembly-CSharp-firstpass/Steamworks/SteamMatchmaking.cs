using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200015C RID: 348
	public static class SteamMatchmaking : Object
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x0007AAB4 File Offset: 0x00078CB4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMatchmaking()
		{
			Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamMatchmaking");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr);
			SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGameCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666914);
			SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGame_Public_Static_Boolean_Int32_byref_AppId_t_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666915);
			SteamMatchmaking.NativeMethodInfoPtr_AddFavoriteGame_Public_Static_Int32_AppId_t_UInt32_UInt16_UInt16_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666916);
			SteamMatchmaking.NativeMethodInfoPtr_RemoveFavoriteGame_Public_Static_Boolean_AppId_t_UInt32_UInt16_UInt16_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666917);
			SteamMatchmaking.NativeMethodInfoPtr_RequestLobbyList_Public_Static_SteamAPICall_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666918);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Public_Static_Void_String_String_ELobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666919);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Public_Static_Void_String_Int32_ELobbyComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666920);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666921);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666922);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Public_Static_Void_ELobbyDistanceFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666923);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666924);
			SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666925);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyByIndex_Public_Static_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666926);
			SteamMatchmaking.NativeMethodInfoPtr_CreateLobby_Public_Static_SteamAPICall_t_ELobbyType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666927);
			SteamMatchmaking.NativeMethodInfoPtr_JoinLobby_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666928);
			SteamMatchmaking.NativeMethodInfoPtr_LeaveLobby_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666929);
			SteamMatchmaking.NativeMethodInfoPtr_InviteUserToLobby_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666930);
			SteamMatchmaking.NativeMethodInfoPtr_GetNumLobbyMembers_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666931);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666932);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyData_Public_Static_String_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666933);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyData_Public_Static_Boolean_CSteamID_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666934);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataCount_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666935);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataByIndex_Public_Static_Boolean_CSteamID_Int32_byref_String_Int32_byref_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666936);
			SteamMatchmaking.NativeMethodInfoPtr_DeleteLobbyData_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666937);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberData_Public_Static_String_CSteamID_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666938);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberData_Public_Static_Void_CSteamID_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666939);
			SteamMatchmaking.NativeMethodInfoPtr_SendLobbyChatMsg_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666940);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyChatEntry_Public_Static_Int32_CSteamID_Int32_byref_CSteamID_Il2CppStructArray_1_Byte_Int32_byref_EChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666941);
			SteamMatchmaking.NativeMethodInfoPtr_RequestLobbyData_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666942);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyGameServer_Public_Static_Void_CSteamID_UInt32_UInt16_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666943);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyGameServer_Public_Static_Boolean_CSteamID_byref_UInt32_byref_UInt16_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666944);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberLimit_Public_Static_Boolean_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666945);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberLimit_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666946);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyType_Public_Static_Boolean_CSteamID_ELobbyType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666947);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyJoinable_Public_Static_Boolean_CSteamID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666948);
			SteamMatchmaking.NativeMethodInfoPtr_GetLobbyOwner_Public_Static_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666949);
			SteamMatchmaking.NativeMethodInfoPtr_SetLobbyOwner_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666950);
			SteamMatchmaking.NativeMethodInfoPtr_SetLinkedLobby_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMatchmaking>.NativeClassPtr, 100666951);
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0007ADDC File Offset: 0x00078FDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199760, XrefRangeEnd = 199764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFavoriteGameCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGameCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0007AE0C File Offset: 0x0007900C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199764, XrefRangeEnd = 199768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFavoriteGame(int iGame, out AppId_t pnAppID, out uint pnIP, out ushort pnConnPort, out ushort pnQueryPort, out uint punFlags, out uint pRTime32LastPlayedOnServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iGame;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnAppID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnIP;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnConnPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnQueryPort;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punFlags;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pRTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetFavoriteGame_Public_Static_Boolean_Int32_byref_AppId_t_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0007AEA0 File Offset: 0x000790A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199768, XrefRangeEnd = 199772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int AddFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags, uint rTime32LastPlayedOnServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rTime32LastPlayedOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddFavoriteGame_Public_Static_Int32_AppId_t_UInt32_UInt16_UInt16_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0007AF24 File Offset: 0x00079124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199772, XrefRangeEnd = 199776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RemoveFavoriteGame(AppId_t nAppID, uint nIP, ushort nConnPort, ushort nQueryPort, uint unFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nConnPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nQueryPort;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_RemoveFavoriteGame_Public_Static_Boolean_AppId_t_UInt32_UInt16_UInt16_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0007AF9C File Offset: 0x0007919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199776, XrefRangeEnd = 199784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestLobbyList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_RequestLobbyList_Public_Static_SteamAPICall_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0007AFCC File Offset: 0x000791CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199784, XrefRangeEnd = 199803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListStringFilter(string pchKeyToMatch, string pchValueToMatch, ELobbyComparison eComparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValueToMatch);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Public_Static_Void_String_String_ELobbyComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0007B024 File Offset: 0x00079224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199803, XrefRangeEnd = 199815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListNumericalFilter(string pchKeyToMatch, int nValueToMatch, ELobbyComparison eComparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToMatch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eComparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Public_Static_Void_String_Int32_ELobbyComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0007B078 File Offset: 0x00079278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199815, XrefRangeEnd = 199827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListNearValueFilter(string pchKeyToMatch, int nValueToBeCloseTo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKeyToMatch);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nValueToBeCloseTo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0007B0BC File Offset: 0x000792BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199827, XrefRangeEnd = 199831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListFilterSlotsAvailable(int nSlotsAvailable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSlotsAvailable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0007B0F0 File Offset: 0x000792F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199831, XrefRangeEnd = 199835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListDistanceFilter(ELobbyDistanceFilter eLobbyDistanceFilter)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eLobbyDistanceFilter;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Public_Static_Void_ELobbyDistanceFilter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x0007B124 File Offset: 0x00079324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199835, XrefRangeEnd = 199839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListResultCountFilter(int cMaxResults)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cMaxResults;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x0007B158 File Offset: 0x00079358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199839, XrefRangeEnd = 199843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AddRequestLobbyListCompatibleMembersFilter(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x0007B18C File Offset: 0x0007938C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199843, XrefRangeEnd = 199851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetLobbyByIndex(int iLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyByIndex_Public_Static_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0007B1CC File Offset: 0x000793CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199851, XrefRangeEnd = 199859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t CreateLobby(ELobbyType eLobbyType, int cMaxMembers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eLobbyType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_CreateLobby_Public_Static_SteamAPICall_t_ELobbyType_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0007B218 File Offset: 0x00079418
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199859, XrefRangeEnd = 199867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t JoinLobby(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_JoinLobby_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x0007B258 File Offset: 0x00079458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199867, XrefRangeEnd = 199871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LeaveLobby(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_LeaveLobby_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x0007B28C File Offset: 0x0007948C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199871, XrefRangeEnd = 199875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InviteUserToLobby(CSteamID steamIDLobby, CSteamID steamIDInvitee)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDInvitee;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_InviteUserToLobby_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x0007B2D8 File Offset: 0x000794D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199875, XrefRangeEnd = 199879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumLobbyMembers(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetNumLobbyMembers_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x0007B318 File Offset: 0x00079518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199879, XrefRangeEnd = 199887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetLobbyMemberByIndex(CSteamID steamIDLobby, int iMember)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMember;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x0007B364 File Offset: 0x00079564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199887, XrefRangeEnd = 199900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyData_Public_Static_String_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x0007B3B0 File Offset: 0x000795B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199900, XrefRangeEnd = 199919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLobbyData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyData_Public_Static_Boolean_CSteamID_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x0007B414 File Offset: 0x00079614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199919, XrefRangeEnd = 199923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLobbyDataCount(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataCount_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x0007B454 File Offset: 0x00079654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199923, XrefRangeEnd = 199941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetLobbyDataByIndex(CSteamID steamIDLobby, int iLobbyData, out string pchKey, int cchKeyBufferSize, out string pchValue, int cchValueBufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iLobbyData;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchKeyBufferSize;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchValueBufferSize;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyDataByIndex_Public_Static_Boolean_CSteamID_Int32_byref_String_Int32_byref_String_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			pchKey = IL2CPP.Il2CppStringToManaged(intPtr);
			pchValue = IL2CPP.Il2CppStringToManaged(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x0007B4F4 File Offset: 0x000796F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199941, XrefRangeEnd = 199953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DeleteLobbyData(CSteamID steamIDLobby, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_DeleteLobbyData_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x0007B544 File Offset: 0x00079744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199953, XrefRangeEnd = 199966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetLobbyMemberData(CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberData_Public_Static_String_CSteamID_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x0007B59C File Offset: 0x0007979C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199966, XrefRangeEnd = 199985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLobbyMemberData(CSteamID steamIDLobby, string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberData_Public_Static_Void_CSteamID_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x0007B5F4 File Offset: 0x000797F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199985, XrefRangeEnd = 199989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendLobbyChatMsg(CSteamID steamIDLobby, Il2CppStructArray<byte> pvMsgBody, int cubMsgBody)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvMsgBody);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubMsgBody;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SendLobbyChatMsg_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x0007B654 File Offset: 0x00079854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199989, XrefRangeEnd = 199993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLobbyChatEntry(CSteamID steamIDLobby, int iChatID, out CSteamID pSteamIDUser, Il2CppStructArray<byte> pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iChatID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pSteamIDUser;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pvData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyChatEntry_Public_Static_Int32_CSteamID_Int32_byref_CSteamID_Il2CppStructArray_1_Byte_Int32_byref_EChatEntryType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x0007B6DC File Offset: 0x000798DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199993, XrefRangeEnd = 199997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestLobbyData(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_RequestLobbyData_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x0007B71C File Offset: 0x0007991C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199997, XrefRangeEnd = 200001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetLobbyGameServer(CSteamID steamIDLobby, uint unGameServerIP, ushort unGameServerPort, CSteamID steamIDGameServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unGameServerPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyGameServer_Public_Static_Void_CSteamID_UInt32_UInt16_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x0007B778 File Offset: 0x00079978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200001, XrefRangeEnd = 200005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetLobbyGameServer(CSteamID steamIDLobby, out uint punGameServerIP, out ushort punGameServerPort, out CSteamID psteamIDGameServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerIP;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &punGameServerPort;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamIDGameServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyGameServer_Public_Static_Boolean_CSteamID_byref_UInt32_byref_UInt16_byref_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x0007B7E0 File Offset: 0x000799E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200005, XrefRangeEnd = 200009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLobbyMemberLimit(CSteamID steamIDLobby, int cMaxMembers)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cMaxMembers;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyMemberLimit_Public_Static_Boolean_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x0007B82C File Offset: 0x00079A2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200009, XrefRangeEnd = 200013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLobbyMemberLimit(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyMemberLimit_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x0007B86C File Offset: 0x00079A6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200013, XrefRangeEnd = 200017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLobbyType(CSteamID steamIDLobby, ELobbyType eLobbyType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eLobbyType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyType_Public_Static_Boolean_CSteamID_ELobbyType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B21 RID: 6945 RVA: 0x0007B8B8 File Offset: 0x00079AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200017, XrefRangeEnd = 200021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLobbyJoinable(CSteamID steamIDLobby, bool bLobbyJoinable)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bLobbyJoinable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyJoinable_Public_Static_Boolean_CSteamID_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x0007B904 File Offset: 0x00079B04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200021, XrefRangeEnd = 200029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetLobbyOwner(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_GetLobbyOwner_Public_Static_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x0007B944 File Offset: 0x00079B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200029, XrefRangeEnd = 200033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLobbyOwner(CSteamID steamIDLobby, CSteamID steamIDNewOwner)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDNewOwner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLobbyOwner_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x0007B990 File Offset: 0x00079B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200033, XrefRangeEnd = 200037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetLinkedLobby(CSteamID steamIDLobby, CSteamID steamIDLobbyDependent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDLobbyDependent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMatchmaking.NativeMethodInfoPtr_SetLinkedLobby_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001B25 RID: 6949 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public SteamMatchmaking(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_GetFavoriteGameCount_Public_Static_Int32_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_GetFavoriteGame_Public_Static_Boolean_Int32_byref_AppId_t_byref_UInt32_byref_UInt16_byref_UInt16_byref_UInt32_byref_UInt32_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_AddFavoriteGame_Public_Static_Int32_AppId_t_UInt32_UInt16_UInt16_UInt32_UInt32_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFavoriteGame_Public_Static_Boolean_AppId_t_UInt32_UInt16_UInt16_UInt32_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_RequestLobbyList_Public_Static_SteamAPICall_t_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListStringFilter_Public_Static_Void_String_String_ELobbyComparison_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListNumericalFilter_Public_Static_Void_String_Int32_ELobbyComparison_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListNearValueFilter_Public_Static_Void_String_Int32_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListFilterSlotsAvailable_Public_Static_Void_Int32_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListDistanceFilter_Public_Static_Void_ELobbyDistanceFilter_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListResultCountFilter_Public_Static_Void_Int32_0;

		// Token: 0x040014F9 RID: 5369
		private static readonly IntPtr NativeMethodInfoPtr_AddRequestLobbyListCompatibleMembersFilter_Public_Static_Void_CSteamID_0;

		// Token: 0x040014FA RID: 5370
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyByIndex_Public_Static_CSteamID_Int32_0;

		// Token: 0x040014FB RID: 5371
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Public_Static_SteamAPICall_t_ELobbyType_Int32_0;

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeMethodInfoPtr_JoinLobby_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Static_Void_CSteamID_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr_InviteUserToLobby_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeMethodInfoPtr_GetNumLobbyMembers_Public_Static_Int32_CSteamID_0;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyData_Public_Static_String_CSteamID_String_0;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Static_Boolean_CSteamID_String_String_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyDataCount_Public_Static_Int32_CSteamID_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyDataByIndex_Public_Static_Boolean_CSteamID_Int32_byref_String_Int32_byref_String_Int32_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLobbyData_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberData_Public_Static_String_CSteamID_CSteamID_String_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyMemberData_Public_Static_Void_CSteamID_String_String_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyChatMsg_Public_Static_Boolean_CSteamID_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyChatEntry_Public_Static_Int32_CSteamID_Int32_byref_CSteamID_Il2CppStructArray_1_Byte_Int32_byref_EChatEntryType_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_RequestLobbyData_Public_Static_Boolean_CSteamID_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyGameServer_Public_Static_Void_CSteamID_UInt32_UInt16_CSteamID_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyGameServer_Public_Static_Boolean_CSteamID_byref_UInt32_byref_UInt16_byref_CSteamID_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyMemberLimit_Public_Static_Boolean_CSteamID_Int32_0;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyMemberLimit_Public_Static_Int32_CSteamID_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyType_Public_Static_Boolean_CSteamID_ELobbyType_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyJoinable_Public_Static_Boolean_CSteamID_Boolean_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_GetLobbyOwner_Public_Static_CSteamID_CSteamID_0;

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyOwner_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeMethodInfoPtr_SetLinkedLobby_Public_Static_Boolean_CSteamID_CSteamID_0;
	}
}
