using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000119 RID: 281
public class RTM_Game_Example : AndroidNativeExampleBase
{
	// Token: 0x06001325 RID: 4901 RVA: 0x000591D8 File Offset: 0x000573D8
	// Note: this type is marked as 'beforefieldinit'.
	static RTM_Game_Example()
	{
		Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "RTM_Game_Example");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr);
		RTM_Game_Example.NativeFieldInfoPtr_avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "avatar");
		RTM_Game_Example.NativeFieldInfoPtr_hi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "hi");
		RTM_Game_Example.NativeFieldInfoPtr_playerLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "playerLabel");
		RTM_Game_Example.NativeFieldInfoPtr_gameState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "gameState");
		RTM_Game_Example.NativeFieldInfoPtr_parisipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "parisipants");
		RTM_Game_Example.NativeFieldInfoPtr_connectButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "connectButton");
		RTM_Game_Example.NativeFieldInfoPtr_helloButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "helloButton");
		RTM_Game_Example.NativeFieldInfoPtr_leaveRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "leaveRoomButton");
		RTM_Game_Example.NativeFieldInfoPtr_showRoomButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "showRoomButton");
		RTM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "ConnectionDependedntButtons");
		RTM_Game_Example.NativeFieldInfoPtr_patricipants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "patricipants");
		RTM_Game_Example.NativeFieldInfoPtr_friends = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "friends");
		RTM_Game_Example.NativeFieldInfoPtr_defaulttexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "defaulttexture");
		RTM_Game_Example.NativeFieldInfoPtr_inviteId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, "inviteId");
		RTM_Game_Example.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665598);
		RTM_Game_Example.NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665599);
		RTM_Game_Example.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665600);
		RTM_Game_Example.NativeMethodInfoPtr_ShowWatingRoom_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665601);
		RTM_Game_Example.NativeMethodInfoPtr_findMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665602);
		RTM_Game_Example.NativeMethodInfoPtr_InviteFriends_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665603);
		RTM_Game_Example.NativeMethodInfoPtr_SendHello_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665604);
		RTM_Game_Example.NativeMethodInfoPtr_LeaveRoomInstance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665605);
		RTM_Game_Example.NativeMethodInfoPtr_DrawParticipants_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665606);
		RTM_Game_Example.NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665607);
		RTM_Game_Example.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665608);
		RTM_Game_Example.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665609);
		RTM_Game_Example.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665610);
		RTM_Game_Example.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665611);
		RTM_Game_Example.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665612);
		RTM_Game_Example.NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665613);
		RTM_Game_Example.NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665614);
		RTM_Game_Example.NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665615);
		RTM_Game_Example.NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665616);
		RTM_Game_Example.NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665617);
		RTM_Game_Example.NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665618);
		RTM_Game_Example.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr, 100665619);
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x000594D8 File Offset: 0x000576D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183831, XrefRangeEnd = 183952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x0005950C File Offset: 0x0005770C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183952, XrefRangeEnd = 183967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void WaitingUIClosed(AndroidActivityResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x00059550 File Offset: 0x00057750
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183967, XrefRangeEnd = 184001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConncetButtonPress()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x00059584 File Offset: 0x00057784
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184001, XrefRangeEnd = 184009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowWatingRoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_ShowWatingRoom_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x000595B8 File Offset: 0x000577B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184009, XrefRangeEnd = 184017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void findMatch()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_findMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x000595EC File Offset: 0x000577EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184017, XrefRangeEnd = 184025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InviteFriends()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_InviteFriends_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x00059620 File Offset: 0x00057820
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendHello()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_SendHello_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x00059654 File Offset: 0x00057854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184025, XrefRangeEnd = 184033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveRoomInstance()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_LeaveRoomInstance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x00059688 File Offset: 0x00057888
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 184079, RefRangeEnd = 184080, XrefRangeStart = 184033, XrefRangeEnd = 184079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DrawParticipants()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_DrawParticipants_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x000596BC File Offset: 0x000578BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184080, XrefRangeEnd = 184082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateGameState(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x00059700 File Offset: 0x00057900
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184082, XrefRangeEnd = 184179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x00059734 File Offset: 0x00057934
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184179, XrefRangeEnd = 184185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x00059768 File Offset: 0x00057968
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184185, XrefRangeEnd = 184218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x0005979C File Offset: 0x0005799C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184218, XrefRangeEnd = 184264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnFriendListLoaded(GooglePlayResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x000597E0 File Offset: 0x000579E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184264, XrefRangeEnd = 184280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectionResult(GooglePlayConnectionResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x00059824 File Offset: 0x00057A24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184280, XrefRangeEnd = 184299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvite(GP_Invite invitation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x00059868 File Offset: 0x00057A68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184299, XrefRangeEnd = 184317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ActionInvitationAccepted(GP_Invite invitation)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(invitation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x000598AC File Offset: 0x00057AAC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184317, XrefRangeEnd = 184325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomCreated(GP_GamesStatusCodes code)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x000598EC File Offset: 0x00057AEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184325, XrefRangeEnd = 184345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvDialogComplete(AndroidDialogResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x0005992C File Offset: 0x00057B2C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184345, XrefRangeEnd = 184352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvManageDialogComplete(AndroidDialogResult result)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x0005996C File Offset: 0x00057B6C
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x000599B0 File Offset: 0x00057BB0
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RTM_Game_Example()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RTM_Game_Example>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTM_Game_Example.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x00009799 File Offset: 0x00007999
	public RTM_Game_Example(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x0600133D RID: 4925 RVA: 0x000599EC File Offset: 0x00057BEC
	// (set) Token: 0x0600133E RID: 4926 RVA: 0x000097A2 File Offset: 0x000079A2
	public unsafe GameObject avatar
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_avatar);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x0600133F RID: 4927 RVA: 0x00059A1C File Offset: 0x00057C1C
	// (set) Token: 0x06001340 RID: 4928 RVA: 0x000097C1 File Offset: 0x000079C1
	public unsafe GameObject hi
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_hi);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_hi), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A2 RID: 1442
	// (get) Token: 0x06001341 RID: 4929 RVA: 0x00059A4C File Offset: 0x00057C4C
	// (set) Token: 0x06001342 RID: 4930 RVA: 0x000097E0 File Offset: 0x000079E0
	public unsafe SA_Label playerLabel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_playerLabel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_playerLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A3 RID: 1443
	// (get) Token: 0x06001343 RID: 4931 RVA: 0x00059A7C File Offset: 0x00057C7C
	// (set) Token: 0x06001344 RID: 4932 RVA: 0x000097FF File Offset: 0x000079FF
	public unsafe SA_Label gameState
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_gameState);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_gameState), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A4 RID: 1444
	// (get) Token: 0x06001345 RID: 4933 RVA: 0x00059AAC File Offset: 0x00057CAC
	// (set) Token: 0x06001346 RID: 4934 RVA: 0x0000981E File Offset: 0x00007A1E
	public unsafe SA_Label parisipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_parisipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Label>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_parisipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A5 RID: 1445
	// (get) Token: 0x06001347 RID: 4935 RVA: 0x00059ADC File Offset: 0x00057CDC
	// (set) Token: 0x06001348 RID: 4936 RVA: 0x0000983D File Offset: 0x00007A3D
	public unsafe DefaultPreviewButton connectButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_connectButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_connectButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A6 RID: 1446
	// (get) Token: 0x06001349 RID: 4937 RVA: 0x00059B0C File Offset: 0x00057D0C
	// (set) Token: 0x0600134A RID: 4938 RVA: 0x0000985C File Offset: 0x00007A5C
	public unsafe DefaultPreviewButton helloButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_helloButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_helloButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A7 RID: 1447
	// (get) Token: 0x0600134B RID: 4939 RVA: 0x00059B3C File Offset: 0x00057D3C
	// (set) Token: 0x0600134C RID: 4940 RVA: 0x0000987B File Offset: 0x00007A7B
	public unsafe DefaultPreviewButton leaveRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_leaveRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_leaveRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A8 RID: 1448
	// (get) Token: 0x0600134D RID: 4941 RVA: 0x00059B6C File Offset: 0x00057D6C
	// (set) Token: 0x0600134E RID: 4942 RVA: 0x0000989A File Offset: 0x00007A9A
	public unsafe DefaultPreviewButton showRoomButton
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_showRoomButton);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultPreviewButton>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_showRoomButton), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A9 RID: 1449
	// (get) Token: 0x0600134F RID: 4943 RVA: 0x00059B9C File Offset: 0x00057D9C
	// (set) Token: 0x06001350 RID: 4944 RVA: 0x000098B9 File Offset: 0x00007AB9
	public unsafe Il2CppReferenceArray<DefaultPreviewButton> ConnectionDependedntButtons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DefaultPreviewButton>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_ConnectionDependedntButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AA RID: 1450
	// (get) Token: 0x06001351 RID: 4945 RVA: 0x00059BCC File Offset: 0x00057DCC
	// (set) Token: 0x06001352 RID: 4946 RVA: 0x000098D8 File Offset: 0x00007AD8
	public unsafe Il2CppReferenceArray<SA_PartisipantUI> patricipants
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_patricipants);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SA_PartisipantUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_patricipants), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AB RID: 1451
	// (get) Token: 0x06001353 RID: 4947 RVA: 0x00059BFC File Offset: 0x00057DFC
	// (set) Token: 0x06001354 RID: 4948 RVA: 0x000098F7 File Offset: 0x00007AF7
	public unsafe Il2CppReferenceArray<SA_FriendUI> friends
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_friends);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SA_FriendUI>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_friends), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AC RID: 1452
	// (get) Token: 0x06001355 RID: 4949 RVA: 0x00059C2C File Offset: 0x00057E2C
	// (set) Token: 0x06001356 RID: 4950 RVA: 0x00009916 File Offset: 0x00007B16
	public unsafe Texture defaulttexture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_defaulttexture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_defaulttexture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x06001357 RID: 4951 RVA: 0x00059C5C File Offset: 0x00057E5C
	// (set) Token: 0x06001358 RID: 4952 RVA: 0x00009935 File Offset: 0x00007B35
	public unsafe string inviteId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_inviteId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RTM_Game_Example.NativeFieldInfoPtr_inviteId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000EA1 RID: 3745
	private static readonly IntPtr NativeFieldInfoPtr_avatar;

	// Token: 0x04000EA2 RID: 3746
	private static readonly IntPtr NativeFieldInfoPtr_hi;

	// Token: 0x04000EA3 RID: 3747
	private static readonly IntPtr NativeFieldInfoPtr_playerLabel;

	// Token: 0x04000EA4 RID: 3748
	private static readonly IntPtr NativeFieldInfoPtr_gameState;

	// Token: 0x04000EA5 RID: 3749
	private static readonly IntPtr NativeFieldInfoPtr_parisipants;

	// Token: 0x04000EA6 RID: 3750
	private static readonly IntPtr NativeFieldInfoPtr_connectButton;

	// Token: 0x04000EA7 RID: 3751
	private static readonly IntPtr NativeFieldInfoPtr_helloButton;

	// Token: 0x04000EA8 RID: 3752
	private static readonly IntPtr NativeFieldInfoPtr_leaveRoomButton;

	// Token: 0x04000EA9 RID: 3753
	private static readonly IntPtr NativeFieldInfoPtr_showRoomButton;

	// Token: 0x04000EAA RID: 3754
	private static readonly IntPtr NativeFieldInfoPtr_ConnectionDependedntButtons;

	// Token: 0x04000EAB RID: 3755
	private static readonly IntPtr NativeFieldInfoPtr_patricipants;

	// Token: 0x04000EAC RID: 3756
	private static readonly IntPtr NativeFieldInfoPtr_friends;

	// Token: 0x04000EAD RID: 3757
	private static readonly IntPtr NativeFieldInfoPtr_defaulttexture;

	// Token: 0x04000EAE RID: 3758
	private static readonly IntPtr NativeFieldInfoPtr_inviteId;

	// Token: 0x04000EAF RID: 3759
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000EB0 RID: 3760
	private static readonly IntPtr NativeMethodInfoPtr_WaitingUIClosed_Private_Void_AndroidActivityResult_0;

	// Token: 0x04000EB1 RID: 3761
	private static readonly IntPtr NativeMethodInfoPtr_ConncetButtonPress_Private_Void_0;

	// Token: 0x04000EB2 RID: 3762
	private static readonly IntPtr NativeMethodInfoPtr_ShowWatingRoom_Private_Void_0;

	// Token: 0x04000EB3 RID: 3763
	private static readonly IntPtr NativeMethodInfoPtr_findMatch_Private_Void_0;

	// Token: 0x04000EB4 RID: 3764
	private static readonly IntPtr NativeMethodInfoPtr_InviteFriends_Private_Void_0;

	// Token: 0x04000EB5 RID: 3765
	private static readonly IntPtr NativeMethodInfoPtr_SendHello_Private_Void_0;

	// Token: 0x04000EB6 RID: 3766
	private static readonly IntPtr NativeMethodInfoPtr_LeaveRoomInstance_Private_Void_0;

	// Token: 0x04000EB7 RID: 3767
	private static readonly IntPtr NativeMethodInfoPtr_DrawParticipants_Private_Void_0;

	// Token: 0x04000EB8 RID: 3768
	private static readonly IntPtr NativeMethodInfoPtr_UpdateGameState_Private_Void_String_0;

	// Token: 0x04000EB9 RID: 3769
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x04000EBA RID: 3770
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x04000EBB RID: 3771
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x04000EBC RID: 3772
	private static readonly IntPtr NativeMethodInfoPtr_OnFriendListLoaded_Private_Void_GooglePlayResult_0;

	// Token: 0x04000EBD RID: 3773
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectionResult_Private_Void_GooglePlayConnectionResult_0;

	// Token: 0x04000EBE RID: 3774
	private static readonly IntPtr NativeMethodInfoPtr_OnInvite_Private_Void_GP_Invite_0;

	// Token: 0x04000EBF RID: 3775
	private static readonly IntPtr NativeMethodInfoPtr_ActionInvitationAccepted_Private_Void_GP_Invite_0;

	// Token: 0x04000EC0 RID: 3776
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomCreated_Private_Void_GP_GamesStatusCodes_0;

	// Token: 0x04000EC1 RID: 3777
	private static readonly IntPtr NativeMethodInfoPtr_OnInvDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x04000EC2 RID: 3778
	private static readonly IntPtr NativeMethodInfoPtr_OnInvManageDialogComplete_Private_Void_AndroidDialogResult_0;

	// Token: 0x04000EC3 RID: 3779
	private static readonly IntPtr NativeMethodInfoPtr_OnGCDataReceived_Private_Void_GP_RTM_Network_Package_0;

	// Token: 0x04000EC4 RID: 3780
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
