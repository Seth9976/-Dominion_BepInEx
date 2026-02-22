using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x0200014C RID: 332
	public static class SteamFriends : Object
	{
		// Token: 0x06001893 RID: 6291 RVA: 0x0006C7D4 File Offset: 0x0006A9D4
		// Note: this type is marked as 'beforefieldinit'.
		static SteamFriends()
		{
			Il2CppClassPointerStore<SteamFriends>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamFriends");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr);
			SteamFriends.NativeMethodInfoPtr_GetPersonaName_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666327);
			SteamFriends.NativeMethodInfoPtr_SetPersonaName_Public_Static_SteamAPICall_t_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666328);
			SteamFriends.NativeMethodInfoPtr_GetPersonaState_Public_Static_EPersonaState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666329);
			SteamFriends.NativeMethodInfoPtr_GetFriendCount_Public_Static_Int32_EFriendFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666330);
			SteamFriends.NativeMethodInfoPtr_GetFriendByIndex_Public_Static_CSteamID_Int32_EFriendFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666331);
			SteamFriends.NativeMethodInfoPtr_GetFriendRelationship_Public_Static_EFriendRelationship_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666332);
			SteamFriends.NativeMethodInfoPtr_GetFriendPersonaState_Public_Static_EPersonaState_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666333);
			SteamFriends.NativeMethodInfoPtr_GetFriendPersonaName_Public_Static_String_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666334);
			SteamFriends.NativeMethodInfoPtr_GetFriendGamePlayed_Public_Static_Boolean_CSteamID_byref_FriendGameInfo_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666335);
			SteamFriends.NativeMethodInfoPtr_GetFriendPersonaNameHistory_Public_Static_String_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666336);
			SteamFriends.NativeMethodInfoPtr_GetFriendSteamLevel_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666337);
			SteamFriends.NativeMethodInfoPtr_GetPlayerNickname_Public_Static_String_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666338);
			SteamFriends.NativeMethodInfoPtr_GetFriendsGroupCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666339);
			SteamFriends.NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Public_Static_FriendsGroupID_t_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666340);
			SteamFriends.NativeMethodInfoPtr_GetFriendsGroupName_Public_Static_String_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666341);
			SteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersCount_Public_Static_Int32_FriendsGroupID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666342);
			SteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersList_Public_Static_Void_FriendsGroupID_t_Il2CppStructArray_1_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666343);
			SteamFriends.NativeMethodInfoPtr_HasFriend_Public_Static_Boolean_CSteamID_EFriendFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666344);
			SteamFriends.NativeMethodInfoPtr_GetClanCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666345);
			SteamFriends.NativeMethodInfoPtr_GetClanByIndex_Public_Static_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666346);
			SteamFriends.NativeMethodInfoPtr_GetClanName_Public_Static_String_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666347);
			SteamFriends.NativeMethodInfoPtr_GetClanTag_Public_Static_String_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666348);
			SteamFriends.NativeMethodInfoPtr_GetClanActivityCounts_Public_Static_Boolean_CSteamID_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666349);
			SteamFriends.NativeMethodInfoPtr_DownloadClanActivityCounts_Public_Static_SteamAPICall_t_Il2CppStructArray_1_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666350);
			SteamFriends.NativeMethodInfoPtr_GetFriendCountFromSource_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666351);
			SteamFriends.NativeMethodInfoPtr_GetFriendFromSourceByIndex_Public_Static_CSteamID_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666352);
			SteamFriends.NativeMethodInfoPtr_IsUserInSource_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666353);
			SteamFriends.NativeMethodInfoPtr_SetInGameVoiceSpeaking_Public_Static_Void_CSteamID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666354);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666355);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToUser_Public_Static_Void_String_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666356);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Public_Static_Void_String_EActivateGameOverlayToWebPageMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666357);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToStore_Public_Static_Void_AppId_t_EOverlayToStoreFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666358);
			SteamFriends.NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666359);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666360);
			SteamFriends.NativeMethodInfoPtr_GetSmallFriendAvatar_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666361);
			SteamFriends.NativeMethodInfoPtr_GetMediumFriendAvatar_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666362);
			SteamFriends.NativeMethodInfoPtr_GetLargeFriendAvatar_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666363);
			SteamFriends.NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_CSteamID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666364);
			SteamFriends.NativeMethodInfoPtr_RequestClanOfficerList_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666365);
			SteamFriends.NativeMethodInfoPtr_GetClanOwner_Public_Static_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666366);
			SteamFriends.NativeMethodInfoPtr_GetClanOfficerCount_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666367);
			SteamFriends.NativeMethodInfoPtr_GetClanOfficerByIndex_Public_Static_CSteamID_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666368);
			SteamFriends.NativeMethodInfoPtr_GetUserRestrictions_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666369);
			SteamFriends.NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666370);
			SteamFriends.NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666371);
			SteamFriends.NativeMethodInfoPtr_GetFriendRichPresence_Public_Static_String_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666372);
			SteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666373);
			SteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Public_Static_String_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666374);
			SteamFriends.NativeMethodInfoPtr_RequestFriendRichPresence_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666375);
			SteamFriends.NativeMethodInfoPtr_InviteUserToGame_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666376);
			SteamFriends.NativeMethodInfoPtr_GetCoplayFriendCount_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666377);
			SteamFriends.NativeMethodInfoPtr_GetCoplayFriend_Public_Static_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666378);
			SteamFriends.NativeMethodInfoPtr_GetFriendCoplayTime_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666379);
			SteamFriends.NativeMethodInfoPtr_GetFriendCoplayGame_Public_Static_AppId_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666380);
			SteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666381);
			SteamFriends.NativeMethodInfoPtr_LeaveClanChatRoom_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666382);
			SteamFriends.NativeMethodInfoPtr_GetClanChatMemberCount_Public_Static_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666383);
			SteamFriends.NativeMethodInfoPtr_GetChatMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666384);
			SteamFriends.NativeMethodInfoPtr_SendClanChatMessage_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666385);
			SteamFriends.NativeMethodInfoPtr_GetClanChatMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_byref_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666386);
			SteamFriends.NativeMethodInfoPtr_IsClanChatAdmin_Public_Static_Boolean_CSteamID_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666387);
			SteamFriends.NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666388);
			SteamFriends.NativeMethodInfoPtr_OpenClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666389);
			SteamFriends.NativeMethodInfoPtr_CloseClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666390);
			SteamFriends.NativeMethodInfoPtr_SetListenForFriendsMessages_Public_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666391);
			SteamFriends.NativeMethodInfoPtr_ReplyToFriendMessage_Public_Static_Boolean_CSteamID_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666392);
			SteamFriends.NativeMethodInfoPtr_GetFriendMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666393);
			SteamFriends.NativeMethodInfoPtr_GetFollowerCount_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666394);
			SteamFriends.NativeMethodInfoPtr_IsFollowing_Public_Static_SteamAPICall_t_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666395);
			SteamFriends.NativeMethodInfoPtr_EnumerateFollowingList_Public_Static_SteamAPICall_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666396);
			SteamFriends.NativeMethodInfoPtr_IsClanPublic_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666397);
			SteamFriends.NativeMethodInfoPtr_IsClanOfficialGameGroup_Public_Static_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666398);
			SteamFriends.NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666399);
			SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Public_Static_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666400);
			SteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamFriends>.NativeClassPtr, 100666401);
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195679, XrefRangeEnd = 195684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPersonaName()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetPersonaName_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x0006CE0C File Offset: 0x0006B00C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195684, XrefRangeEnd = 195699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t SetPersonaName(string pchPersonaName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchPersonaName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetPersonaName_Public_Static_SteamAPICall_t_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0006CE50 File Offset: 0x0006B050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195699, XrefRangeEnd = 195703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EPersonaState GetPersonaState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetPersonaState_Public_Static_EPersonaState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x0006CE80 File Offset: 0x0006B080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195703, XrefRangeEnd = 195707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendCount(EFriendFlags iFriendFlags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFriendFlags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendCount_Public_Static_Int32_EFriendFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x0006CEC0 File Offset: 0x0006B0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195707, XrefRangeEnd = 195715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetFriendByIndex(int iFriend, EFriendFlags iFriendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendByIndex_Public_Static_CSteamID_Int32_EFriendFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x0006CF0C File Offset: 0x0006B10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195715, XrefRangeEnd = 195719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EFriendRelationship GetFriendRelationship(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendRelationship_Public_Static_EFriendRelationship_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x0006CF4C File Offset: 0x0006B14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195719, XrefRangeEnd = 195723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EPersonaState GetFriendPersonaState(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendPersonaState_Public_Static_EPersonaState_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0006CF8C File Offset: 0x0006B18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195723, XrefRangeEnd = 195728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendPersonaName(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendPersonaName_Public_Static_String_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0006CFC4 File Offset: 0x0006B1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195728, XrefRangeEnd = 195732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetFriendGamePlayed(CSteamID steamIDFriend, out FriendGameInfo_t pFriendGameInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pFriendGameInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendGamePlayed_Public_Static_Boolean_CSteamID_byref_FriendGameInfo_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x0006D010 File Offset: 0x0006B210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195732, XrefRangeEnd = 195737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendPersonaNameHistory(CSteamID steamIDFriend, int iPersonaName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iPersonaName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendPersonaNameHistory_Public_Static_String_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x0006D058 File Offset: 0x0006B258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195737, XrefRangeEnd = 195741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendSteamLevel(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendSteamLevel_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0006D098 File Offset: 0x0006B298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195741, XrefRangeEnd = 195746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPlayerNickname(CSteamID steamIDPlayer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDPlayer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetPlayerNickname_Public_Static_String_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0006D0D0 File Offset: 0x0006B2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195746, XrefRangeEnd = 195750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendsGroupCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsGroupCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x0006D100 File Offset: 0x0006B300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195750, XrefRangeEnd = 195758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FriendsGroupID_t GetFriendsGroupIDByIndex(int iFG)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iFG;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Public_Static_FriendsGroupID_t_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x0006D140 File Offset: 0x0006B340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195758, XrefRangeEnd = 195763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendsGroupName(FriendsGroupID_t friendsGroupID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsGroupName_Public_Static_String_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x0006D178 File Offset: 0x0006B378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195763, XrefRangeEnd = 195767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendsGroupMembersCount(FriendsGroupID_t friendsGroupID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersCount_Public_Static_Int32_FriendsGroupID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x0006D1B8 File Offset: 0x0006B3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195767, XrefRangeEnd = 195771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetFriendsGroupMembersList(FriendsGroupID_t friendsGroupID, Il2CppStructArray<CSteamID> pOutSteamIDMembers, int nMembersCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref friendsGroupID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pOutSteamIDMembers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nMembersCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendsGroupMembersList_Public_Static_Void_FriendsGroupID_t_Il2CppStructArray_1_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0006D20C File Offset: 0x0006B40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195771, XrefRangeEnd = 195775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasFriend(CSteamID steamIDFriend, EFriendFlags iFriendFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriendFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_HasFriend_Public_Static_Boolean_CSteamID_EFriendFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x0006D258 File Offset: 0x0006B458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195775, XrefRangeEnd = 195779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClanCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0006D288 File Offset: 0x0006B488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195779, XrefRangeEnd = 195787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetClanByIndex(int iClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanByIndex_Public_Static_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195787, XrefRangeEnd = 195792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClanName(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanName_Public_Static_String_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x0006D300 File Offset: 0x0006B500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195792, XrefRangeEnd = 195797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetClanTag(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanTag_Public_Static_String_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x0006D338 File Offset: 0x0006B538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195797, XrefRangeEnd = 195801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetClanActivityCounts(CSteamID steamIDClan, out int pnOnline, out int pnInGame, out int pnChatting)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnOnline;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnInGame;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pnChatting;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanActivityCounts_Public_Static_Boolean_CSteamID_byref_Int32_byref_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x0006D3A0 File Offset: 0x0006B5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195801, XrefRangeEnd = 195808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t DownloadClanActivityCounts(Il2CppStructArray<CSteamID> psteamIDClans, int cClansToRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(psteamIDClans);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cClansToRequest;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_DownloadClanActivityCounts_Public_Static_SteamAPICall_t_Il2CppStructArray_1_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x0006D3F0 File Offset: 0x0006B5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195808, XrefRangeEnd = 195812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendCountFromSource(CSteamID steamIDSource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDSource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendCountFromSource_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x0006D430 File Offset: 0x0006B630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195812, XrefRangeEnd = 195820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetFriendFromSourceByIndex(CSteamID steamIDSource, int iFriend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDSource;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iFriend;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendFromSourceByIndex_Public_Static_CSteamID_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x0006D47C File Offset: 0x0006B67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195820, XrefRangeEnd = 195824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsUserInSource(CSteamID steamIDUser, CSteamID steamIDSource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDSource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsUserInSource_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0006D4C8 File Offset: 0x0006B6C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195824, XrefRangeEnd = 195828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetInGameVoiceSpeaking(CSteamID steamIDUser, bool bSpeaking)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bSpeaking;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetInGameVoiceSpeaking_Public_Static_Void_CSteamID_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0006D508 File Offset: 0x0006B708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195828, XrefRangeEnd = 195840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlay(string pchDialog)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x0006D540 File Offset: 0x0006B740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195840, XrefRangeEnd = 195852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlayToUser(string pchDialog, CSteamID steamID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchDialog);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToUser_Public_Static_Void_String_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x0006D584 File Offset: 0x0006B784
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195852, XrefRangeEnd = 195864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlayToWebPage(string pchURL, EActivateGameOverlayToWebPageMode eMode = EActivateGameOverlayToWebPageMode.k_EActivateGameOverlayToWebPageMode_Default)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchURL);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Public_Static_Void_String_EActivateGameOverlayToWebPageMode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x0006D5C8 File Offset: 0x0006B7C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 195868, RefRangeEnd = 195869, XrefRangeStart = 195864, XrefRangeEnd = 195868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlayToStore(AppId_t nAppID, EOverlayToStoreFlag eFlag)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nAppID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eFlag;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayToStore_Public_Static_Void_AppId_t_EOverlayToStoreFlag_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x0006D608 File Offset: 0x0006B808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195869, XrefRangeEnd = 195873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPlayedWith(CSteamID steamIDUserPlayedWith)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUserPlayedWith;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x0006D63C File Offset: 0x0006B83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195873, XrefRangeEnd = 195877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlayInviteDialog(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x0006D670 File Offset: 0x0006B870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195877, XrefRangeEnd = 195881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSmallFriendAvatar(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetSmallFriendAvatar_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0006D6B0 File Offset: 0x0006B8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195881, XrefRangeEnd = 195885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMediumFriendAvatar(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetMediumFriendAvatar_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0006D6F0 File Offset: 0x0006B8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195885, XrefRangeEnd = 195889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetLargeFriendAvatar(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetLargeFriendAvatar_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x0006D730 File Offset: 0x0006B930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195889, XrefRangeEnd = 195893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestUserInformation(CSteamID steamIDUser, bool bRequireNameOnly)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bRequireNameOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_CSteamID_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x0006D77C File Offset: 0x0006B97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195893, XrefRangeEnd = 195900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t RequestClanOfficerList(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RequestClanOfficerList_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0006D7BC File Offset: 0x0006B9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195900, XrefRangeEnd = 195908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetClanOwner(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanOwner_Public_Static_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0006D7FC File Offset: 0x0006B9FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195908, XrefRangeEnd = 195912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClanOfficerCount(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanOfficerCount_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0006D83C File Offset: 0x0006BA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195912, XrefRangeEnd = 195920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetClanOfficerByIndex(CSteamID steamIDClan, int iOfficer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iOfficer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanOfficerByIndex_Public_Static_CSteamID_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0006D888 File Offset: 0x0006BA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195920, XrefRangeEnd = 195924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetUserRestrictions()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetUserRestrictions_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195924, XrefRangeEnd = 195943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetRichPresence(string pchKey, string pchValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0006D90C File Offset: 0x0006BB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195943, XrefRangeEnd = 195947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearRichPresence()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0006D934 File Offset: 0x0006BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195947, XrefRangeEnd = 195960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendRichPresence(CSteamID steamIDFriend, string pchKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendRichPresence_Public_Static_String_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0006D980 File Offset: 0x0006BB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195960, XrefRangeEnd = 195964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendRichPresenceKeyCount(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0006D9C0 File Offset: 0x0006BBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195964, XrefRangeEnd = 195969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetFriendRichPresenceKeyByIndex(CSteamID steamIDFriend, int iKey)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iKey;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Public_Static_String_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0006DA08 File Offset: 0x0006BC08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195969, XrefRangeEnd = 195973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestFriendRichPresence(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RequestFriendRichPresence_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x0006DA3C File Offset: 0x0006BC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195973, XrefRangeEnd = 195985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InviteUserToGame(CSteamID steamIDFriend, string pchConnectString)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchConnectString);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_InviteUserToGame_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x0006DA8C File Offset: 0x0006BC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195985, XrefRangeEnd = 195989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetCoplayFriendCount()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetCoplayFriendCount_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x0006DABC File Offset: 0x0006BCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195989, XrefRangeEnd = 195997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetCoplayFriend(int iCoplayFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCoplayFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetCoplayFriend_Public_Static_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C8 RID: 6344 RVA: 0x0006DAFC File Offset: 0x0006BCFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195997, XrefRangeEnd = 196001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendCoplayTime(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendCoplayTime_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018C9 RID: 6345 RVA: 0x0006DB3C File Offset: 0x0006BD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196001, XrefRangeEnd = 196009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AppId_t GetFriendCoplayGame(CSteamID steamIDFriend)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendCoplayGame_Public_Static_AppId_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CA RID: 6346 RVA: 0x0006DB7C File Offset: 0x0006BD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196009, XrefRangeEnd = 196016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t JoinClanChatRoom(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0006DBBC File Offset: 0x0006BDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196016, XrefRangeEnd = 196020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LeaveClanChatRoom(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_LeaveClanChatRoom_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x0006DBFC File Offset: 0x0006BDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196020, XrefRangeEnd = 196024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClanChatMemberCount(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanChatMemberCount_Public_Static_Int32_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0006DC3C File Offset: 0x0006BE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196024, XrefRangeEnd = 196032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CSteamID GetChatMemberByIndex(CSteamID steamIDClan, int iUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetChatMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x0006DC88 File Offset: 0x0006BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196032, XrefRangeEnd = 196044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SendClanChatMessage(CSteamID steamIDClanChat, string pchText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SendClanChatMessage_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x0006DCD8 File Offset: 0x0006BED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196044, XrefRangeEnd = 196056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetClanChatMessage(CSteamID steamIDClanChat, int iMessage, out string prgchText, int cchTextMax, out EChatEntryType peChatEntryType, out CSteamID psteamidChatter)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessage;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cchTextMax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &psteamidChatter;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetClanChatMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_byref_CSteamID_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			prgchText = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060018D0 RID: 6352 RVA: 0x0006DD6C File Offset: 0x0006BF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196056, XrefRangeEnd = 196060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClanChatAdmin(CSteamID steamIDClanChat, CSteamID steamIDUser)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref steamIDUser;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsClanChatAdmin_Public_Static_Boolean_CSteamID_CSteamID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D1 RID: 6353 RVA: 0x0006DDB8 File Offset: 0x0006BFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196060, XrefRangeEnd = 196064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClanChatWindowOpenInSteam(CSteamID steamIDClanChat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x0006DDF8 File Offset: 0x0006BFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196064, XrefRangeEnd = 196068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool OpenClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_OpenClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x0006DE38 File Offset: 0x0006C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196068, XrefRangeEnd = 196072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CloseClanChatWindowInSteam(CSteamID steamIDClanChat)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClanChat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_CloseClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x0006DE78 File Offset: 0x0006C078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196072, XrefRangeEnd = 196076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetListenForFriendsMessages(bool bInterceptEnabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bInterceptEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_SetListenForFriendsMessages_Public_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x0006DEB8 File Offset: 0x0006C0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196076, XrefRangeEnd = 196088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReplyToFriendMessage(CSteamID steamIDFriend, string pchMsgToSend)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pchMsgToSend);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ReplyToFriendMessage_Public_Static_Boolean_CSteamID_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x0006DF08 File Offset: 0x0006C108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196088, XrefRangeEnd = 196100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetFriendMessage(CSteamID steamIDFriend, int iMessageID, out string pvData, int cubData, out EChatEntryType peChatEntryType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDFriend;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iMessageID;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cubData;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &peChatEntryType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFriendMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			pvData = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x0006DF8C File Offset: 0x0006C18C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196100, XrefRangeEnd = 196107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t GetFollowerCount(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetFollowerCount_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x0006DFCC File Offset: 0x0006C1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196107, XrefRangeEnd = 196114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t IsFollowing(CSteamID steamID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsFollowing_Public_Static_SteamAPICall_t_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x0006E00C File Offset: 0x0006C20C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196114, XrefRangeEnd = 196121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SteamAPICall_t EnumerateFollowingList(uint unStartIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unStartIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_EnumerateFollowingList_Public_Static_SteamAPICall_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x0006E04C File Offset: 0x0006C24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196121, XrefRangeEnd = 196125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClanPublic(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsClanPublic_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0006E08C File Offset: 0x0006C28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196125, XrefRangeEnd = 196129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsClanOfficialGameGroup(CSteamID steamIDClan)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDClan;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_IsClanOfficialGameGroup_Public_Static_Boolean_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196129, XrefRangeEnd = 196133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNumChatsWithUnreadPriorityMessages()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0006E0FC File Offset: 0x0006C2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196133, XrefRangeEnd = 196137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ActivateGameOverlayRemotePlayTogetherInviteDialog(CSteamID steamIDLobby)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref steamIDLobby;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Public_Static_Void_CSteamID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x0006E130 File Offset: 0x0006C330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196137, XrefRangeEnd = 196149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RegisterProtocolInOverlayBrowser(string pchProtocol)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pchProtocol);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamFriends.NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000BA0C File Offset: 0x00009C0C
		public SteamFriends(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040012A3 RID: 4771
		private static readonly IntPtr NativeMethodInfoPtr_GetPersonaName_Public_Static_String_0;

		// Token: 0x040012A4 RID: 4772
		private static readonly IntPtr NativeMethodInfoPtr_SetPersonaName_Public_Static_SteamAPICall_t_String_0;

		// Token: 0x040012A5 RID: 4773
		private static readonly IntPtr NativeMethodInfoPtr_GetPersonaState_Public_Static_EPersonaState_0;

		// Token: 0x040012A6 RID: 4774
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCount_Public_Static_Int32_EFriendFlags_0;

		// Token: 0x040012A7 RID: 4775
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendByIndex_Public_Static_CSteamID_Int32_EFriendFlags_0;

		// Token: 0x040012A8 RID: 4776
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRelationship_Public_Static_EFriendRelationship_CSteamID_0;

		// Token: 0x040012A9 RID: 4777
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaState_Public_Static_EPersonaState_CSteamID_0;

		// Token: 0x040012AA RID: 4778
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaName_Public_Static_String_CSteamID_0;

		// Token: 0x040012AB RID: 4779
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendGamePlayed_Public_Static_Boolean_CSteamID_byref_FriendGameInfo_t_0;

		// Token: 0x040012AC RID: 4780
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendPersonaNameHistory_Public_Static_String_CSteamID_Int32_0;

		// Token: 0x040012AD RID: 4781
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendSteamLevel_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012AE RID: 4782
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayerNickname_Public_Static_String_CSteamID_0;

		// Token: 0x040012AF RID: 4783
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupCount_Public_Static_Int32_0;

		// Token: 0x040012B0 RID: 4784
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupIDByIndex_Public_Static_FriendsGroupID_t_Int32_0;

		// Token: 0x040012B1 RID: 4785
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupName_Public_Static_String_FriendsGroupID_t_0;

		// Token: 0x040012B2 RID: 4786
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupMembersCount_Public_Static_Int32_FriendsGroupID_t_0;

		// Token: 0x040012B3 RID: 4787
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendsGroupMembersList_Public_Static_Void_FriendsGroupID_t_Il2CppStructArray_1_CSteamID_Int32_0;

		// Token: 0x040012B4 RID: 4788
		private static readonly IntPtr NativeMethodInfoPtr_HasFriend_Public_Static_Boolean_CSteamID_EFriendFlags_0;

		// Token: 0x040012B5 RID: 4789
		private static readonly IntPtr NativeMethodInfoPtr_GetClanCount_Public_Static_Int32_0;

		// Token: 0x040012B6 RID: 4790
		private static readonly IntPtr NativeMethodInfoPtr_GetClanByIndex_Public_Static_CSteamID_Int32_0;

		// Token: 0x040012B7 RID: 4791
		private static readonly IntPtr NativeMethodInfoPtr_GetClanName_Public_Static_String_CSteamID_0;

		// Token: 0x040012B8 RID: 4792
		private static readonly IntPtr NativeMethodInfoPtr_GetClanTag_Public_Static_String_CSteamID_0;

		// Token: 0x040012B9 RID: 4793
		private static readonly IntPtr NativeMethodInfoPtr_GetClanActivityCounts_Public_Static_Boolean_CSteamID_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x040012BA RID: 4794
		private static readonly IntPtr NativeMethodInfoPtr_DownloadClanActivityCounts_Public_Static_SteamAPICall_t_Il2CppStructArray_1_CSteamID_Int32_0;

		// Token: 0x040012BB RID: 4795
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCountFromSource_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012BC RID: 4796
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendFromSourceByIndex_Public_Static_CSteamID_CSteamID_Int32_0;

		// Token: 0x040012BD RID: 4797
		private static readonly IntPtr NativeMethodInfoPtr_IsUserInSource_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x040012BE RID: 4798
		private static readonly IntPtr NativeMethodInfoPtr_SetInGameVoiceSpeaking_Public_Static_Void_CSteamID_Boolean_0;

		// Token: 0x040012BF RID: 4799
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlay_Public_Static_Void_String_0;

		// Token: 0x040012C0 RID: 4800
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToUser_Public_Static_Void_String_CSteamID_0;

		// Token: 0x040012C1 RID: 4801
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToWebPage_Public_Static_Void_String_EActivateGameOverlayToWebPageMode_0;

		// Token: 0x040012C2 RID: 4802
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayToStore_Public_Static_Void_AppId_t_EOverlayToStoreFlag_0;

		// Token: 0x040012C3 RID: 4803
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayedWith_Public_Static_Void_CSteamID_0;

		// Token: 0x040012C4 RID: 4804
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayInviteDialog_Public_Static_Void_CSteamID_0;

		// Token: 0x040012C5 RID: 4805
		private static readonly IntPtr NativeMethodInfoPtr_GetSmallFriendAvatar_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012C6 RID: 4806
		private static readonly IntPtr NativeMethodInfoPtr_GetMediumFriendAvatar_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012C7 RID: 4807
		private static readonly IntPtr NativeMethodInfoPtr_GetLargeFriendAvatar_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012C8 RID: 4808
		private static readonly IntPtr NativeMethodInfoPtr_RequestUserInformation_Public_Static_Boolean_CSteamID_Boolean_0;

		// Token: 0x040012C9 RID: 4809
		private static readonly IntPtr NativeMethodInfoPtr_RequestClanOfficerList_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040012CA RID: 4810
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOwner_Public_Static_CSteamID_CSteamID_0;

		// Token: 0x040012CB RID: 4811
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOfficerCount_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012CC RID: 4812
		private static readonly IntPtr NativeMethodInfoPtr_GetClanOfficerByIndex_Public_Static_CSteamID_CSteamID_Int32_0;

		// Token: 0x040012CD RID: 4813
		private static readonly IntPtr NativeMethodInfoPtr_GetUserRestrictions_Public_Static_UInt32_0;

		// Token: 0x040012CE RID: 4814
		private static readonly IntPtr NativeMethodInfoPtr_SetRichPresence_Public_Static_Boolean_String_String_0;

		// Token: 0x040012CF RID: 4815
		private static readonly IntPtr NativeMethodInfoPtr_ClearRichPresence_Public_Static_Void_0;

		// Token: 0x040012D0 RID: 4816
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresence_Public_Static_String_CSteamID_String_0;

		// Token: 0x040012D1 RID: 4817
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresenceKeyCount_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012D2 RID: 4818
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendRichPresenceKeyByIndex_Public_Static_String_CSteamID_Int32_0;

		// Token: 0x040012D3 RID: 4819
		private static readonly IntPtr NativeMethodInfoPtr_RequestFriendRichPresence_Public_Static_Void_CSteamID_0;

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeMethodInfoPtr_InviteUserToGame_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeMethodInfoPtr_GetCoplayFriendCount_Public_Static_Int32_0;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeMethodInfoPtr_GetCoplayFriend_Public_Static_CSteamID_Int32_0;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCoplayTime_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendCoplayGame_Public_Static_AppId_t_CSteamID_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_JoinClanChatRoom_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClanChatRoom_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_GetClanChatMemberCount_Public_Static_Int32_CSteamID_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_GetChatMemberByIndex_Public_Static_CSteamID_CSteamID_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_SendClanChatMessage_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_GetClanChatMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_byref_CSteamID_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_IsClanChatAdmin_Public_Static_Boolean_CSteamID_CSteamID_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_IsClanChatWindowOpenInSteam_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_OpenClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr_CloseClanChatWindowInSteam_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_SetListenForFriendsMessages_Public_Static_Boolean_Boolean_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_ReplyToFriendMessage_Public_Static_Boolean_CSteamID_String_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_GetFriendMessage_Public_Static_Int32_CSteamID_Int32_byref_String_Int32_byref_EChatEntryType_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_GetFollowerCount_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_IsFollowing_Public_Static_SteamAPICall_t_CSteamID_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_EnumerateFollowingList_Public_Static_SteamAPICall_t_UInt32_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_IsClanPublic_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_IsClanOfficialGameGroup_Public_Static_Boolean_CSteamID_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_GetNumChatsWithUnreadPriorityMessages_Public_Static_Int32_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_ActivateGameOverlayRemotePlayTogetherInviteDialog_Public_Static_Void_CSteamID_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_RegisterProtocolInOverlayBrowser_Public_Static_Boolean_String_0;
	}
}
