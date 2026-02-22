using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200012F RID: 303
public class RealTimeMultiplayerTab : FeatureTab
{
	// Token: 0x060015CF RID: 5583 RVA: 0x00061F90 File Offset: 0x00060190
	// Note: this type is marked as 'beforefieldinit'.
	static RealTimeMultiplayerTab()
	{
		Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RealTimeMultiplayerTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr);
		RealTimeMultiplayerTab.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "avatar");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "defaulttexture");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_logo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "logo");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "hi");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "playerLabel");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "gameState");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_parisipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "parisipants");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "connectButton");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "connectButtonLabel");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_helloButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "helloButton");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_leaveRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "leaveRoomButton");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_showRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "showRoomButton");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "ConnectionDependedntButtons");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_patricipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "patricipants");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "friends");
		RealTimeMultiplayerTab.NativeFieldInfoPtr_inviteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, "inviteId");
		RealTimeMultiplayerTab.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665914);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665915);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665916);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_ShowWatingRoom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665917);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_findMatch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665918);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_InviteFriends_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665919);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_SendHello_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665920);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_LeaveRoomInstance_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665921);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_DrawParticipants_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665922);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665923);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665924);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665925);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665926);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665927);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665928);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665929);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665930);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665931);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665932);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665933);
		RealTimeMultiplayerTab.NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665934);
		RealTimeMultiplayerTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr, 100665935);
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x000622B8 File Offset: 0x000604B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190805, XrefRangeEnd = 190919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x000622EC File Offset: 0x000604EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190919, XrefRangeEnd = 190934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WaitingUIClosed(AndroidActivityResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x00062330 File Offset: 0x00060530
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190934, XrefRangeEnd = 190968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x00062364 File Offset: 0x00060564
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190968, XrefRangeEnd = 190976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowWatingRoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_ShowWatingRoom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x00062398 File Offset: 0x00060598
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190976, XrefRangeEnd = 190984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findMatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_findMatch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x000623CC File Offset: 0x000605CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190984, XrefRangeEnd = 190992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InviteFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_InviteFriends_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x00062400 File Offset: 0x00060600
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendHello()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_SendHello_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00062434 File Offset: 0x00060634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190992, XrefRangeEnd = 191000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveRoomInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_LeaveRoomInstance_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x00062468 File Offset: 0x00060668
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 191044, RefRangeEnd = 191045, XrefRangeStart = 191000, XrefRangeEnd = 191044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawParticipants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_DrawParticipants_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x0006249C File Offset: 0x0006069C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191045, XrefRangeEnd = 191046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGameState(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000624E0 File Offset: 0x000606E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191046, XrefRangeEnd = 191138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x00062514 File Offset: 0x00060714
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191138, XrefRangeEnd = 191143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x00062548 File Offset: 0x00060748
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191143, XrefRangeEnd = 191175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x0006257C File Offset: 0x0006077C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191175, XrefRangeEnd = 191221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFriendListLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x000625C0 File Offset: 0x000607C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191221, XrefRangeEnd = 191237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x00062604 File Offset: 0x00060804
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191237, XrefRangeEnd = 191256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvite(GP_Invite invitation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x00062648 File Offset: 0x00060848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191256, XrefRangeEnd = 191274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionInvitationAccepted(GP_Invite invitation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0006268C File Offset: 0x0006088C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191274, XrefRangeEnd = 191282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomCreated(GP_GamesStatusCodes code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x000626CC File Offset: 0x000608CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191282, XrefRangeEnd = 191302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvDialogComplete(AndroidDialogResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0006270C File Offset: 0x0006090C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 191302, XrefRangeEnd = 191309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvManageDialogComplete(AndroidDialogResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x0006274C File Offset: 0x0006094C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGCDataReceived(GP_RTM_Network_Package package)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(package);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00062790 File Offset: 0x00060990
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RealTimeMultiplayerTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RealTimeMultiplayerTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RealTimeMultiplayerTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x0000AB5A File Offset: 0x00008D5A
	public RealTimeMultiplayerTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000641 RID: 1601
	// (get) Token: 0x060015E7 RID: 5607 RVA: 0x000627CC File Offset: 0x000609CC
	// (set) Token: 0x060015E8 RID: 5608 RVA: 0x0000AB63 File Offset: 0x00008D63
	public unsafe Image avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000642 RID: 1602
	// (get) Token: 0x060015E9 RID: 5609 RVA: 0x000627FC File Offset: 0x000609FC
	// (set) Token: 0x060015EA RID: 5610 RVA: 0x0000AB82 File Offset: 0x00008D82
	public unsafe Sprite defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000643 RID: 1603
	// (get) Token: 0x060015EB RID: 5611 RVA: 0x0006282C File Offset: 0x00060A2C
	// (set) Token: 0x060015EC RID: 5612 RVA: 0x0000ABA1 File Offset: 0x00008DA1
	public unsafe Sprite logo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_logo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_logo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000644 RID: 1604
	// (get) Token: 0x060015ED RID: 5613 RVA: 0x0006285C File Offset: 0x00060A5C
	// (set) Token: 0x060015EE RID: 5614 RVA: 0x0000ABC0 File Offset: 0x00008DC0
	public unsafe GameObject hi
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_hi);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_hi), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000645 RID: 1605
	// (get) Token: 0x060015EF RID: 5615 RVA: 0x0006288C File Offset: 0x00060A8C
	// (set) Token: 0x060015F0 RID: 5616 RVA: 0x0000ABDF File Offset: 0x00008DDF
	public unsafe Text playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000646 RID: 1606
	// (get) Token: 0x060015F1 RID: 5617 RVA: 0x000628BC File Offset: 0x00060ABC
	// (set) Token: 0x060015F2 RID: 5618 RVA: 0x0000ABFE File Offset: 0x00008DFE
	public unsafe Text gameState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_gameState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_gameState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000647 RID: 1607
	// (get) Token: 0x060015F3 RID: 5619 RVA: 0x000628EC File Offset: 0x00060AEC
	// (set) Token: 0x060015F4 RID: 5620 RVA: 0x0000AC1D File Offset: 0x00008E1D
	public unsafe Text parisipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_parisipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_parisipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000648 RID: 1608
	// (get) Token: 0x060015F5 RID: 5621 RVA: 0x0006291C File Offset: 0x00060B1C
	// (set) Token: 0x060015F6 RID: 5622 RVA: 0x0000AC3C File Offset: 0x00008E3C
	public unsafe Button connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000649 RID: 1609
	// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0006294C File Offset: 0x00060B4C
	// (set) Token: 0x060015F8 RID: 5624 RVA: 0x0000AC5B File Offset: 0x00008E5B
	public unsafe Text connectButtonLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButtonLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_connectButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064A RID: 1610
	// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0006297C File Offset: 0x00060B7C
	// (set) Token: 0x060015FA RID: 5626 RVA: 0x0000AC7A File Offset: 0x00008E7A
	public unsafe Button helloButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_helloButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_helloButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064B RID: 1611
	// (get) Token: 0x060015FB RID: 5627 RVA: 0x000629AC File Offset: 0x00060BAC
	// (set) Token: 0x060015FC RID: 5628 RVA: 0x0000AC99 File Offset: 0x00008E99
	public unsafe Button leaveRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_leaveRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_leaveRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064C RID: 1612
	// (get) Token: 0x060015FD RID: 5629 RVA: 0x000629DC File Offset: 0x00060BDC
	// (set) Token: 0x060015FE RID: 5630 RVA: 0x0000ACB8 File Offset: 0x00008EB8
	public unsafe Button showRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_showRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_showRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064D RID: 1613
	// (get) Token: 0x060015FF RID: 5631 RVA: 0x00062A0C File Offset: 0x00060C0C
	// (set) Token: 0x06001600 RID: 5632 RVA: 0x0000ACD7 File Offset: 0x00008ED7
	public unsafe Il2CppReferenceArray<Button> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064E RID: 1614
	// (get) Token: 0x06001601 RID: 5633 RVA: 0x00062A3C File Offset: 0x00060C3C
	// (set) Token: 0x06001602 RID: 5634 RVA: 0x0000ACF6 File Offset: 0x00008EF6
	public unsafe Il2CppReferenceArray<ParticipantPresenter> patricipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_patricipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticipantPresenter>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_patricipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700064F RID: 1615
	// (get) Token: 0x06001603 RID: 5635 RVA: 0x00062A6C File Offset: 0x00060C6C
	// (set) Token: 0x06001604 RID: 5636 RVA: 0x0000AD15 File Offset: 0x00008F15
	public unsafe Il2CppReferenceArray<FriendPresenter> friends
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_friends);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FriendPresenter>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000650 RID: 1616
	// (get) Token: 0x06001605 RID: 5637 RVA: 0x00062A9C File Offset: 0x00060C9C
	// (set) Token: 0x06001606 RID: 5638 RVA: 0x0000AD34 File Offset: 0x00008F34
	public unsafe string inviteId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_inviteId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RealTimeMultiplayerTab.NativeFieldInfoPtr_inviteId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x0400107E RID: 4222
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x0400107F RID: 4223
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04001080 RID: 4224
	private static readonly IntPtr NativeFieldInfoPtr_logo;

	// Token: 0x04001081 RID: 4225
	private static readonly IntPtr NativeFieldInfoPtr_hi;

	// Token: 0x04001082 RID: 4226
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04001083 RID: 4227
	private static readonly IntPtr NativeFieldInfoPtr_gameState;

	// Token: 0x04001084 RID: 4228
	private static readonly IntPtr NativeFieldInfoPtr_parisipants;

	// Token: 0x04001085 RID: 4229
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04001086 RID: 4230
	private static readonly IntPtr NativeFieldInfoPtr_connectButtonLabel;

	// Token: 0x04001087 RID: 4231
	private static readonly IntPtr NativeFieldInfoPtr_helloButton;

	// Token: 0x04001088 RID: 4232
	private static readonly IntPtr NativeFieldInfoPtr_leaveRoomButton;

	// Token: 0x04001089 RID: 4233
	private static readonly IntPtr NativeFieldInfoPtr_showRoomButton;

	// Token: 0x0400108A RID: 4234
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x0400108B RID: 4235
	private static readonly IntPtr NativeFieldInfoPtr_patricipants;

	// Token: 0x0400108C RID: 4236
	private static readonly IntPtr NativeFieldInfoPtr_friends;

	// Token: 0x0400108D RID: 4237
	private static readonly IntPtr NativeFieldInfoPtr_inviteId;

	// Token: 0x0400108E RID: 4238
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400108F RID: 4239
	private static readonly IntPtr NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0;

	// Token: 0x04001090 RID: 4240
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Public_Void_0;

	// Token: 0x04001091 RID: 4241
	private static readonly IntPtr NativeMethodInfoPtr_ShowWatingRoom_Public_Void_0;

	// Token: 0x04001092 RID: 4242
	private static readonly IntPtr NativeMethodInfoPtr_findMatch_Public_Void_0;

	// Token: 0x04001093 RID: 4243
	private static readonly IntPtr NativeMethodInfoPtr_InviteFriends_Public_Void_0;

	// Token: 0x04001094 RID: 4244
	private static readonly IntPtr NativeMethodInfoPtr_SendHello_Public_Void_0;

	// Token: 0x04001095 RID: 4245
	private static readonly IntPtr NativeMethodInfoPtr_LeaveRoomInstance_Public_Void_0;

	// Token: 0x04001096 RID: 4246
	private static readonly IntPtr NativeMethodInfoPtr_DrawParticipants_Private_Void_0;

	// Token: 0x04001097 RID: 4247
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0;

	// Token: 0x04001098 RID: 4248
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04001099 RID: 4249
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x0400109A RID: 4250
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x0400109B RID: 4251
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x0400109C RID: 4252
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x0400109D RID: 4253
	private static readonly IntPtr NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0;

	// Token: 0x0400109E RID: 4254
	private static readonly IntPtr NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0;

	// Token: 0x0400109F RID: 4255
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0;

	// Token: 0x040010A0 RID: 4256
	private static readonly IntPtr NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x040010A1 RID: 4257
	private static readonly IntPtr NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x040010A2 RID: 4258
	private static readonly IntPtr NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0;

	// Token: 0x040010A3 RID: 4259
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
