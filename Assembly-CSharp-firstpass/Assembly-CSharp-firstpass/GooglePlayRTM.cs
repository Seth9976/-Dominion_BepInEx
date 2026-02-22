using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000064 RID: 100
public class GooglePlayRTM : Singleton<GooglePlayRTM>
{
	// Token: 0x0600073B RID: 1851 RVA: 0x0002F93C File Offset: 0x0002DB3C
	// Note: this type is marked as 'beforefieldinit'.
	static GooglePlayRTM()
	{
		Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GooglePlayRTM");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr);
		GooglePlayRTM.NativeFieldInfoPtr_ActionDataRecieved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionDataRecieved");
		GooglePlayRTM.NativeFieldInfoPtr_ActionRoomUpdated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionRoomUpdated");
		GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageSent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionReliableMessageSent");
		GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageDelivered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionReliableMessageDelivered");
		GooglePlayRTM.NativeFieldInfoPtr_ActionConnectedToRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionConnectedToRoom");
		GooglePlayRTM.NativeFieldInfoPtr_ActionDisconnectedFromRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionDisconnectedFromRoom");
		GooglePlayRTM.NativeFieldInfoPtr_ActionP2PConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionP2PConnected");
		GooglePlayRTM.NativeFieldInfoPtr_ActionP2PDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionP2PDisconnected");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeerDeclined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeerDeclined");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeerInvitedToRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeerInvitedToRoom");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeerJoined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeerJoined");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeerLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeerLeft");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeersConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeersConnected");
		GooglePlayRTM.NativeFieldInfoPtr_ActionPeersDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionPeersDisconnected");
		GooglePlayRTM.NativeFieldInfoPtr_ActionRoomAutomatching = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionRoomAutomatching");
		GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnecting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionRoomConnecting");
		GooglePlayRTM.NativeFieldInfoPtr_ActionJoinedRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionJoinedRoom");
		GooglePlayRTM.NativeFieldInfoPtr_ActionLeftRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionLeftRoom");
		GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionRoomConnected");
		GooglePlayRTM.NativeFieldInfoPtr_ActionRoomCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionRoomCreated");
		GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationBoxUIClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionInvitationBoxUIClosed");
		GooglePlayRTM.NativeFieldInfoPtr_ActionWatingRoomIntentClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionWatingRoomIntentClosed");
		GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionInvitationAccepted");
		GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionInvitationReceived");
		GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationRemoved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "ActionInvitationRemoved");
		GooglePlayRTM.NativeFieldInfoPtr_BYTE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "BYTE_LIMIT");
		GooglePlayRTM.NativeFieldInfoPtr__currentRoom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "_currentRoom");
		GooglePlayRTM.NativeFieldInfoPtr__invitations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "_invitations");
		GooglePlayRTM.NativeFieldInfoPtr__ReliableMassageListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "_ReliableMassageListeners");
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionDataRecieved_Public_Static_add_Void_Action_1_GP_RTM_Network_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664154);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionDataRecieved_Public_Static_rem_Void_Action_1_GP_RTM_Network_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664155);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomUpdated_Public_Static_add_Void_Action_1_GP_RTM_Room_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664156);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomUpdated_Public_Static_rem_Void_Action_1_GP_RTM_Room_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664157);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionReliableMessageSent_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageSentResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664158);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionReliableMessageSent_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageSentResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664159);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionReliableMessageDelivered_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664160);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionReliableMessageDelivered_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664161);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionConnectedToRoom_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664162);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionConnectedToRoom_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664163);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionDisconnectedFromRoom_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664164);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionDisconnectedFromRoom_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664165);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionP2PConnected_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664166);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionP2PConnected_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664167);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionP2PDisconnected_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664168);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionP2PDisconnected_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664169);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerDeclined_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664170);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerDeclined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664171);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerInvitedToRoom_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664172);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerInvitedToRoom_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664173);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerJoined_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664174);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerJoined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664175);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerLeft_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664176);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerLeft_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664177);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeersConnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664178);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeersConnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664179);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeersDisconnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664180);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeersDisconnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664181);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomAutomatching_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664182);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomAutomatching_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664183);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomConnecting_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664184);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomConnecting_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664185);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionJoinedRoom_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664186);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionJoinedRoom_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664187);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionLeftRoom_Public_Static_add_Void_Action_1_GP_RTM_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664188);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionLeftRoom_Public_Static_rem_Void_Action_1_GP_RTM_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664189);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomConnected_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664190);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomConnected_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664191);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomCreated_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664192);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomCreated_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664193);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationBoxUIClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664194);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationBoxUIClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664195);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionWatingRoomIntentClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664196);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionWatingRoomIntentClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664197);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664198);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664199);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664200);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664201);
		GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664202);
		GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664203);
		GooglePlayRTM.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664204);
		GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664205);
		GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppReferenceArray_1_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664206);
		GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664207);
		GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppReferenceArray_1_GooglePlayerTemplate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664208);
		GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664209);
		GooglePlayRTM.NativeMethodInfoPtr_SendDataToAll_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664210);
		GooglePlayRTM.NativeMethodInfoPtr_SendDataToPlayers_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664211);
		GooglePlayRTM.NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664212);
		GooglePlayRTM.NativeMethodInfoPtr_OpenInvitationBoxUI_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664213);
		GooglePlayRTM.NativeMethodInfoPtr_LeaveRoom_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664214);
		GooglePlayRTM.NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664215);
		GooglePlayRTM.NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664216);
		GooglePlayRTM.NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664217);
		GooglePlayRTM.NativeMethodInfoPtr_OpenInvitationInBoxUI_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664218);
		GooglePlayRTM.NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664219);
		GooglePlayRTM.NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664220);
		GooglePlayRTM.NativeMethodInfoPtr_ClearReliableMessageListener_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664221);
		GooglePlayRTM.NativeMethodInfoPtr_get_currentRoom_Public_get_GP_RTM_Room_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664222);
		GooglePlayRTM.NativeMethodInfoPtr_get_invitations_Public_get_List_1_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664223);
		GooglePlayRTM.NativeMethodInfoPtr_OnWatingRoomIntentClosed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664224);
		GooglePlayRTM.NativeMethodInfoPtr_OnRoomUpdate_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664225);
		GooglePlayRTM.NativeMethodInfoPtr_OnReliableMessageSent_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664226);
		GooglePlayRTM.NativeMethodInfoPtr_OnReliableMessageDelivered_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664227);
		GooglePlayRTM.NativeMethodInfoPtr_OnMatchDataRecieved_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664228);
		GooglePlayRTM.NativeMethodInfoPtr_OnConnectedToRoom_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664229);
		GooglePlayRTM.NativeMethodInfoPtr_OnDisconnectedFromRoom_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664230);
		GooglePlayRTM.NativeMethodInfoPtr_OnP2PConnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664231);
		GooglePlayRTM.NativeMethodInfoPtr_OnP2PDisconnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664232);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeerDeclined_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664233);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeerInvitedToRoom_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664234);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeerJoined_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664235);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeerLeft_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664236);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeersConnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664237);
		GooglePlayRTM.NativeMethodInfoPtr_OnPeersDisconnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664238);
		GooglePlayRTM.NativeMethodInfoPtr_OnRoomAutoMatching_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664239);
		GooglePlayRTM.NativeMethodInfoPtr_OnRoomConnecting_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664240);
		GooglePlayRTM.NativeMethodInfoPtr_OnJoinedRoom_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664241);
		GooglePlayRTM.NativeMethodInfoPtr_OnLeftRoom_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664242);
		GooglePlayRTM.NativeMethodInfoPtr_OnRoomConnected_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664243);
		GooglePlayRTM.NativeMethodInfoPtr_OnRoomCreated_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664244);
		GooglePlayRTM.NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664245);
		GooglePlayRTM.NativeMethodInfoPtr_OnInvitationReceived_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664246);
		GooglePlayRTM.NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664247);
		GooglePlayRTM.NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664248);
		GooglePlayRTM.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, 100664249);
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00030330 File Offset: 0x0002E530
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167081, RefRangeEnd = 167083, XrefRangeStart = 167070, XrefRangeEnd = 167081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionDataRecieved(Action<GP_RTM_Network_Package> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionDataRecieved_Public_Static_add_Void_Action_1_GP_RTM_Network_Package_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00030368 File Offset: 0x0002E568
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167083, XrefRangeEnd = 167094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionDataRecieved(Action<GP_RTM_Network_Package> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionDataRecieved_Public_Static_rem_Void_Action_1_GP_RTM_Network_Package_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x000303A0 File Offset: 0x0002E5A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167094, XrefRangeEnd = 167105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRoomUpdated(Action<GP_RTM_Room> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomUpdated_Public_Static_add_Void_Action_1_GP_RTM_Room_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600073F RID: 1855 RVA: 0x000303D8 File Offset: 0x0002E5D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167105, XrefRangeEnd = 167116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRoomUpdated(Action<GP_RTM_Room> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomUpdated_Public_Static_rem_Void_Action_1_GP_RTM_Room_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000740 RID: 1856 RVA: 0x00030410 File Offset: 0x0002E610
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167116, XrefRangeEnd = 167127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionReliableMessageSent(Action<GP_RTM_ReliableMessageSentResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionReliableMessageSent_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageSentResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000741 RID: 1857 RVA: 0x00030448 File Offset: 0x0002E648
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167127, XrefRangeEnd = 167138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionReliableMessageSent(Action<GP_RTM_ReliableMessageSentResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionReliableMessageSent_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageSentResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000742 RID: 1858 RVA: 0x00030480 File Offset: 0x0002E680
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167138, XrefRangeEnd = 167149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionReliableMessageDelivered(Action<GP_RTM_ReliableMessageDeliveredResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionReliableMessageDelivered_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000743 RID: 1859 RVA: 0x000304B8 File Offset: 0x0002E6B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167149, XrefRangeEnd = 167160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionReliableMessageDelivered(Action<GP_RTM_ReliableMessageDeliveredResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionReliableMessageDelivered_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000744 RID: 1860 RVA: 0x000304F0 File Offset: 0x0002E6F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167160, XrefRangeEnd = 167171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionConnectedToRoom(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionConnectedToRoom_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000745 RID: 1861 RVA: 0x00030528 File Offset: 0x0002E728
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167171, XrefRangeEnd = 167182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionConnectedToRoom(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionConnectedToRoom_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000746 RID: 1862 RVA: 0x00030560 File Offset: 0x0002E760
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167182, XrefRangeEnd = 167193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionDisconnectedFromRoom(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionDisconnectedFromRoom_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000747 RID: 1863 RVA: 0x00030598 File Offset: 0x0002E798
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167193, XrefRangeEnd = 167204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionDisconnectedFromRoom(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionDisconnectedFromRoom_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000748 RID: 1864 RVA: 0x000305D0 File Offset: 0x0002E7D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167204, XrefRangeEnd = 167215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionP2PConnected(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionP2PConnected_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000749 RID: 1865 RVA: 0x00030608 File Offset: 0x0002E808
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167215, XrefRangeEnd = 167226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionP2PConnected(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionP2PConnected_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074A RID: 1866 RVA: 0x00030640 File Offset: 0x0002E840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167226, XrefRangeEnd = 167237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionP2PDisconnected(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionP2PDisconnected_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074B RID: 1867 RVA: 0x00030678 File Offset: 0x0002E878
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167237, XrefRangeEnd = 167248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionP2PDisconnected(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionP2PDisconnected_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074C RID: 1868 RVA: 0x000306B0 File Offset: 0x0002E8B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167248, XrefRangeEnd = 167259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeerDeclined(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerDeclined_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074D RID: 1869 RVA: 0x000306E8 File Offset: 0x0002E8E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167259, XrefRangeEnd = 167270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeerDeclined(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerDeclined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074E RID: 1870 RVA: 0x00030720 File Offset: 0x0002E920
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167270, XrefRangeEnd = 167281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeerInvitedToRoom(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerInvitedToRoom_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600074F RID: 1871 RVA: 0x00030758 File Offset: 0x0002E958
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167281, XrefRangeEnd = 167292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeerInvitedToRoom(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerInvitedToRoom_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000750 RID: 1872 RVA: 0x00030790 File Offset: 0x0002E990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167292, XrefRangeEnd = 167303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeerJoined(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerJoined_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000751 RID: 1873 RVA: 0x000307C8 File Offset: 0x0002E9C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167303, XrefRangeEnd = 167314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeerJoined(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerJoined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000752 RID: 1874 RVA: 0x00030800 File Offset: 0x0002EA00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167314, XrefRangeEnd = 167325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeerLeft(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeerLeft_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000753 RID: 1875 RVA: 0x00030838 File Offset: 0x0002EA38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167325, XrefRangeEnd = 167336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeerLeft(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeerLeft_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000754 RID: 1876 RVA: 0x00030870 File Offset: 0x0002EA70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167336, XrefRangeEnd = 167347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeersConnected(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeersConnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000755 RID: 1877 RVA: 0x000308A8 File Offset: 0x0002EAA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167347, XrefRangeEnd = 167358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeersConnected(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeersConnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000756 RID: 1878 RVA: 0x000308E0 File Offset: 0x0002EAE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167358, XrefRangeEnd = 167369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionPeersDisconnected(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionPeersDisconnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000757 RID: 1879 RVA: 0x00030918 File Offset: 0x0002EB18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167369, XrefRangeEnd = 167380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionPeersDisconnected(Action<Il2CppStringArray> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionPeersDisconnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000758 RID: 1880 RVA: 0x00030950 File Offset: 0x0002EB50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167380, XrefRangeEnd = 167391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRoomAutomatching(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomAutomatching_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000759 RID: 1881 RVA: 0x00030988 File Offset: 0x0002EB88
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167391, XrefRangeEnd = 167402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRoomAutomatching(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomAutomatching_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075A RID: 1882 RVA: 0x000309C0 File Offset: 0x0002EBC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167402, XrefRangeEnd = 167413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRoomConnecting(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomConnecting_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075B RID: 1883 RVA: 0x000309F8 File Offset: 0x0002EBF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167413, XrefRangeEnd = 167424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRoomConnecting(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomConnecting_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075C RID: 1884 RVA: 0x00030A30 File Offset: 0x0002EC30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167424, XrefRangeEnd = 167435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionJoinedRoom(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionJoinedRoom_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075D RID: 1885 RVA: 0x00030A68 File Offset: 0x0002EC68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167435, XrefRangeEnd = 167446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionJoinedRoom(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionJoinedRoom_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075E RID: 1886 RVA: 0x00030AA0 File Offset: 0x0002ECA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167446, XrefRangeEnd = 167457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionLeftRoom(Action<GP_RTM_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionLeftRoom_Public_Static_add_Void_Action_1_GP_RTM_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600075F RID: 1887 RVA: 0x00030AD8 File Offset: 0x0002ECD8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167457, XrefRangeEnd = 167468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionLeftRoom(Action<GP_RTM_Result> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionLeftRoom_Public_Static_rem_Void_Action_1_GP_RTM_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000760 RID: 1888 RVA: 0x00030B10 File Offset: 0x0002ED10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167468, XrefRangeEnd = 167479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRoomConnected(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomConnected_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000761 RID: 1889 RVA: 0x00030B48 File Offset: 0x0002ED48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167479, XrefRangeEnd = 167490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRoomConnected(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomConnected_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000762 RID: 1890 RVA: 0x00030B80 File Offset: 0x0002ED80
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167501, RefRangeEnd = 167503, XrefRangeStart = 167490, XrefRangeEnd = 167501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionRoomCreated(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionRoomCreated_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000763 RID: 1891 RVA: 0x00030BB8 File Offset: 0x0002EDB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167503, XrefRangeEnd = 167514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionRoomCreated(Action<GP_GamesStatusCodes> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionRoomCreated_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000764 RID: 1892 RVA: 0x00030BF0 File Offset: 0x0002EDF0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167514, XrefRangeEnd = 167525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationBoxUIClosed(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationBoxUIClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000765 RID: 1893 RVA: 0x00030C28 File Offset: 0x0002EE28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167525, XrefRangeEnd = 167536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationBoxUIClosed(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationBoxUIClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000766 RID: 1894 RVA: 0x00030C60 File Offset: 0x0002EE60
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167547, RefRangeEnd = 167549, XrefRangeStart = 167536, XrefRangeEnd = 167547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionWatingRoomIntentClosed(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionWatingRoomIntentClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000767 RID: 1895 RVA: 0x00030C98 File Offset: 0x0002EE98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167549, XrefRangeEnd = 167560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionWatingRoomIntentClosed(Action<AndroidActivityResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionWatingRoomIntentClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000768 RID: 1896 RVA: 0x00030CD0 File Offset: 0x0002EED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167560, XrefRangeEnd = 167571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationAccepted(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000769 RID: 1897 RVA: 0x00030D08 File Offset: 0x0002EF08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167571, XrefRangeEnd = 167582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationAccepted(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600076A RID: 1898 RVA: 0x00030D40 File Offset: 0x0002EF40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167582, XrefRangeEnd = 167593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationReceived(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600076B RID: 1899 RVA: 0x00030D78 File Offset: 0x0002EF78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167593, XrefRangeEnd = 167604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationReceived(Action<GP_Invite> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600076C RID: 1900 RVA: 0x00030DB0 File Offset: 0x0002EFB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167604, XrefRangeEnd = 167615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInvitationRemoved(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600076D RID: 1901 RVA: 0x00030DE8 File Offset: 0x0002EFE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167615, XrefRangeEnd = 167626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInvitationRemoved(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600076E RID: 1902 RVA: 0x00030E20 File Offset: 0x0002F020
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167626, XrefRangeEnd = 167677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600076F RID: 1903 RVA: 0x00030E54 File Offset: 0x0002F054
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167681, RefRangeEnd = 167683, XrefRangeStart = 167677, XrefRangeEnd = 167681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMatch(int minPlayers, int maxPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000770 RID: 1904 RVA: 0x00030EA0 File Offset: 0x0002F0A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167683, XrefRangeEnd = 167700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMatch(int minPlayers, int maxPlayers, [Optional] Il2CppReferenceArray<GooglePlayerTemplate> playersToInvite)
	{
		if (playersToInvite == null)
		{
			playersToInvite = new Il2CppReferenceArray<GooglePlayerTemplate>(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersToInvite);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppReferenceArray_1_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00030F0C File Offset: 0x0002F10C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167701, RefRangeEnd = 167703, XrefRangeStart = 167700, XrefRangeEnd = 167701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMatch(int minPlayers, int maxPlayers, [Optional] Il2CppStringArray playersToInvite)
	{
		if (playersToInvite == null)
		{
			playersToInvite = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playersToInvite);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00030F78 File Offset: 0x0002F178
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167703, XrefRangeEnd = 167720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMatch(Il2CppReferenceArray<GooglePlayerTemplate> playersToInvite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playersToInvite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppReferenceArray_1_GooglePlayerTemplate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00030FBC File Offset: 0x0002F1BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167720, XrefRangeEnd = 167721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FindMatch(Il2CppStringArray playersToInvite)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playersToInvite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00031000 File Offset: 0x0002F200
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167721, XrefRangeEnd = 167734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendDataToAll(Il2CppStructArray<byte> data, GP_RTM_PackageType sendType)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_SendDataToAll_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00031050 File Offset: 0x0002F250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167734, XrefRangeEnd = 167751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SendDataToPlayers(Il2CppStructArray<byte> data, GP_RTM_PackageType sendType, [Optional] Il2CppStringArray players)
	{
		if (players == null)
		{
			players = new Il2CppStringArray(0L);
		}
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(players);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_SendDataToPlayers_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000776 RID: 1910 RVA: 0x000310C0 File Offset: 0x0002F2C0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167973, RefRangeEnd = 167975, XrefRangeStart = 167751, XrefRangeEnd = 167973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowWaitingRoomIntent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000777 RID: 1911 RVA: 0x000310F4 File Offset: 0x0002F2F4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167976, RefRangeEnd = 167978, XrefRangeStart = 167975, XrefRangeEnd = 167976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenInvitationBoxUI(int minPlayers, int maxPlayers)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref minPlayers;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPlayers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OpenInvitationBoxUI_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000778 RID: 1912 RVA: 0x00031140 File Offset: 0x0002F340
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 167979, RefRangeEnd = 167981, XrefRangeStart = 167978, XrefRangeEnd = 167979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LeaveRoom()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_LeaveRoom_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000779 RID: 1913 RVA: 0x00031174 File Offset: 0x0002F374
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 167982, RefRangeEnd = 167986, XrefRangeStart = 167981, XrefRangeEnd = 167982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AcceptInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600077A RID: 1914 RVA: 0x000311B8 File Offset: 0x0002F3B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167986, XrefRangeEnd = 167987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DeclineInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600077B RID: 1915 RVA: 0x000311FC File Offset: 0x0002F3FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167987, XrefRangeEnd = 167988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DismissInvitation(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600077C RID: 1916 RVA: 0x00031240 File Offset: 0x0002F440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167988, XrefRangeEnd = 167989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenInvitationInBoxUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OpenInvitationInBoxUI_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600077D RID: 1917 RVA: 0x00031274 File Offset: 0x0002F474
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167989, XrefRangeEnd = 167990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVariant(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600077E RID: 1918 RVA: 0x000312B4 File Offset: 0x0002F4B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167990, XrefRangeEnd = 167991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetExclusiveBitMask(int val)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x000312F4 File Offset: 0x0002F4F4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 168005, RefRangeEnd = 168006, XrefRangeStart = 167991, XrefRangeEnd = 168005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearReliableMessageListener(int dataTokenId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dataTokenId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_ClearReliableMessageListener_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x17000295 RID: 661
	// (get) Token: 0x06000780 RID: 1920 RVA: 0x00031334 File Offset: 0x0002F534
	public unsafe GP_RTM_Room currentRoom
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_get_currentRoom_Public_get_GP_RTM_Room_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GP_RTM_Room>(intPtr3) : null;
		}
	}

	// Token: 0x17000296 RID: 662
	// (get) Token: 0x06000781 RID: 1921 RVA: 0x00031374 File Offset: 0x0002F574
	public unsafe List<GP_Invite> invitations
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_get_invitations_Public_get_List_1_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GP_Invite>>(intPtr3) : null;
		}
	}

	// Token: 0x06000782 RID: 1922 RVA: 0x000313B4 File Offset: 0x0002F5B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168006, XrefRangeEnd = 168038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnWatingRoomIntentClosed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnWatingRoomIntentClosed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000783 RID: 1923 RVA: 0x000313F8 File Offset: 0x0002F5F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168038, XrefRangeEnd = 168113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomUpdate(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnRoomUpdate_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000784 RID: 1924 RVA: 0x0003143C File Offset: 0x0002F63C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168113, XrefRangeEnd = 168144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnReliableMessageSent(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnReliableMessageSent_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000785 RID: 1925 RVA: 0x00031480 File Offset: 0x0002F680
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168144, XrefRangeEnd = 168175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnReliableMessageDelivered(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnReliableMessageDelivered_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000786 RID: 1926 RVA: 0x000314C4 File Offset: 0x0002F6C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168175, XrefRangeEnd = 168214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMatchDataRecieved(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnMatchDataRecieved_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000787 RID: 1927 RVA: 0x00031508 File Offset: 0x0002F708
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168214, XrefRangeEnd = 168227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnectedToRoom(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnConnectedToRoom_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000788 RID: 1928 RVA: 0x0003154C File Offset: 0x0002F74C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168227, XrefRangeEnd = 168240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisconnectedFromRoom(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnDisconnectedFromRoom_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000789 RID: 1929 RVA: 0x00031590 File Offset: 0x0002F790
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168240, XrefRangeEnd = 168255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnP2PConnected(string participantId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(participantId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnP2PConnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078A RID: 1930 RVA: 0x000315D4 File Offset: 0x0002F7D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168255, XrefRangeEnd = 168270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnP2PDisconnected(string participantId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(participantId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnP2PDisconnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078B RID: 1931 RVA: 0x00031618 File Offset: 0x0002F818
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168270, XrefRangeEnd = 168294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeerDeclined(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeerDeclined_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078C RID: 1932 RVA: 0x0003165C File Offset: 0x0002F85C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168294, XrefRangeEnd = 168318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeerInvitedToRoom(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeerInvitedToRoom_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078D RID: 1933 RVA: 0x000316A0 File Offset: 0x0002F8A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168318, XrefRangeEnd = 168342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeerJoined(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeerJoined_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078E RID: 1934 RVA: 0x000316E4 File Offset: 0x0002F8E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168342, XrefRangeEnd = 168366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeerLeft(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeerLeft_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600078F RID: 1935 RVA: 0x00031728 File Offset: 0x0002F928
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168366, XrefRangeEnd = 168390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeersConnected(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeersConnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000790 RID: 1936 RVA: 0x0003176C File Offset: 0x0002F96C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168390, XrefRangeEnd = 168414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPeersDisconnected(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnPeersDisconnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000791 RID: 1937 RVA: 0x000317B0 File Offset: 0x0002F9B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168414, XrefRangeEnd = 168427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomAutoMatching(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnRoomAutoMatching_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000792 RID: 1938 RVA: 0x000317F4 File Offset: 0x0002F9F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168427, XrefRangeEnd = 168440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomConnecting(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnRoomConnecting_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000793 RID: 1939 RVA: 0x00031838 File Offset: 0x0002FA38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168440, XrefRangeEnd = 168459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnJoinedRoom(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnJoinedRoom_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000794 RID: 1940 RVA: 0x0003187C File Offset: 0x0002FA7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168459, XrefRangeEnd = 168499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLeftRoom(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnLeftRoom_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000795 RID: 1941 RVA: 0x000318C0 File Offset: 0x0002FAC0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168499, XrefRangeEnd = 168518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomConnected(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnRoomConnected_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000796 RID: 1942 RVA: 0x00031904 File Offset: 0x0002FB04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168518, XrefRangeEnd = 168537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRoomCreated(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnRoomCreated_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000797 RID: 1943 RVA: 0x00031948 File Offset: 0x0002FB48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168537, XrefRangeEnd = 168569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationBoxUiClosed(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000798 RID: 1944 RVA: 0x0003198C File Offset: 0x0002FB8C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168569, XrefRangeEnd = 168579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationReceived(GP_Invite inv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnInvitationReceived_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000799 RID: 1945 RVA: 0x000319D0 File Offset: 0x0002FBD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168579, XrefRangeEnd = 168613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationRemoved(string invitationId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(invitationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600079A RID: 1946 RVA: 0x00031A14 File Offset: 0x0002FC14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168613, XrefRangeEnd = 168621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInvitationAccepted(GP_Invite inv)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(inv);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600079B RID: 1947 RVA: 0x00031A58 File Offset: 0x0002FC58
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168621, XrefRangeEnd = 168643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GooglePlayRTM()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600079C RID: 1948 RVA: 0x00005012 File Offset: 0x00003212
	public void FindMatch(int minPlayers, int maxPlayers, params GooglePlayerTemplate[] playersToInvite)
	{
		this.FindMatch(minPlayers, maxPlayers, new Il2CppReferenceArray<GooglePlayerTemplate>(playersToInvite));
	}

	// Token: 0x0600079D RID: 1949 RVA: 0x00005022 File Offset: 0x00003222
	public void FindMatch(int minPlayers, int maxPlayers, params string[] playersToInvite)
	{
		this.FindMatch(minPlayers, maxPlayers, new Il2CppStringArray(playersToInvite));
	}

	// Token: 0x0600079E RID: 1950 RVA: 0x00005032 File Offset: 0x00003232
	public void SendDataToPlayers(Il2CppStructArray<byte> data, GP_RTM_PackageType sendType, params string[] players)
	{
		this.SendDataToPlayers(data, sendType, new Il2CppStringArray(players));
	}

	// Token: 0x0600079F RID: 1951 RVA: 0x00005042 File Offset: 0x00003242
	public GooglePlayRTM(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000278 RID: 632
	// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00031A94 File Offset: 0x0002FC94
	// (set) Token: 0x060007A1 RID: 1953 RVA: 0x0000504B File Offset: 0x0000324B
	public unsafe static Action<GP_RTM_Network_Package> ActionDataRecieved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionDataRecieved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RTM_Network_Package>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionDataRecieved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000279 RID: 633
	// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00031ABC File Offset: 0x0002FCBC
	// (set) Token: 0x060007A3 RID: 1955 RVA: 0x0000505D File Offset: 0x0000325D
	public unsafe static Action<GP_RTM_Room> ActionRoomUpdated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomUpdated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RTM_Room>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomUpdated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027A RID: 634
	// (get) Token: 0x060007A4 RID: 1956 RVA: 0x00031AE4 File Offset: 0x0002FCE4
	// (set) Token: 0x060007A5 RID: 1957 RVA: 0x0000506F File Offset: 0x0000326F
	public unsafe static Action<GP_RTM_ReliableMessageSentResult> ActionReliableMessageSent
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageSent, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RTM_ReliableMessageSentResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageSent, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027B RID: 635
	// (get) Token: 0x060007A6 RID: 1958 RVA: 0x00031B0C File Offset: 0x0002FD0C
	// (set) Token: 0x060007A7 RID: 1959 RVA: 0x00005081 File Offset: 0x00003281
	public unsafe static Action<GP_RTM_ReliableMessageDeliveredResult> ActionReliableMessageDelivered
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageDelivered, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RTM_ReliableMessageDeliveredResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionReliableMessageDelivered, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027C RID: 636
	// (get) Token: 0x060007A8 RID: 1960 RVA: 0x00031B34 File Offset: 0x0002FD34
	// (set) Token: 0x060007A9 RID: 1961 RVA: 0x00005093 File Offset: 0x00003293
	public unsafe static Action ActionConnectedToRoom
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionConnectedToRoom, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionConnectedToRoom, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027D RID: 637
	// (get) Token: 0x060007AA RID: 1962 RVA: 0x00031B5C File Offset: 0x0002FD5C
	// (set) Token: 0x060007AB RID: 1963 RVA: 0x000050A5 File Offset: 0x000032A5
	public unsafe static Action ActionDisconnectedFromRoom
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionDisconnectedFromRoom, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionDisconnectedFromRoom, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027E RID: 638
	// (get) Token: 0x060007AC RID: 1964 RVA: 0x00031B84 File Offset: 0x0002FD84
	// (set) Token: 0x060007AD RID: 1965 RVA: 0x000050B7 File Offset: 0x000032B7
	public unsafe static Action<string> ActionP2PConnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionP2PConnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionP2PConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700027F RID: 639
	// (get) Token: 0x060007AE RID: 1966 RVA: 0x00031BAC File Offset: 0x0002FDAC
	// (set) Token: 0x060007AF RID: 1967 RVA: 0x000050C9 File Offset: 0x000032C9
	public unsafe static Action<string> ActionP2PDisconnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionP2PDisconnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionP2PDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000280 RID: 640
	// (get) Token: 0x060007B0 RID: 1968 RVA: 0x00031BD4 File Offset: 0x0002FDD4
	// (set) Token: 0x060007B1 RID: 1969 RVA: 0x000050DB File Offset: 0x000032DB
	public unsafe static Action<Il2CppStringArray> ActionPeerDeclined
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerDeclined, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerDeclined, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000281 RID: 641
	// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00031BFC File Offset: 0x0002FDFC
	// (set) Token: 0x060007B3 RID: 1971 RVA: 0x000050ED File Offset: 0x000032ED
	public unsafe static Action<Il2CppStringArray> ActionPeerInvitedToRoom
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerInvitedToRoom, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerInvitedToRoom, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x060007B4 RID: 1972 RVA: 0x00031C24 File Offset: 0x0002FE24
	// (set) Token: 0x060007B5 RID: 1973 RVA: 0x000050FF File Offset: 0x000032FF
	public unsafe static Action<Il2CppStringArray> ActionPeerJoined
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerJoined, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerJoined, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000283 RID: 643
	// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00031C4C File Offset: 0x0002FE4C
	// (set) Token: 0x060007B7 RID: 1975 RVA: 0x00005111 File Offset: 0x00003311
	public unsafe static Action<Il2CppStringArray> ActionPeerLeft
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerLeft, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeerLeft, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000284 RID: 644
	// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00031C74 File Offset: 0x0002FE74
	// (set) Token: 0x060007B9 RID: 1977 RVA: 0x00005123 File Offset: 0x00003323
	public unsafe static Action<Il2CppStringArray> ActionPeersConnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeersConnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeersConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000285 RID: 645
	// (get) Token: 0x060007BA RID: 1978 RVA: 0x00031C9C File Offset: 0x0002FE9C
	// (set) Token: 0x060007BB RID: 1979 RVA: 0x00005135 File Offset: 0x00003335
	public unsafe static Action<Il2CppStringArray> ActionPeersDisconnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeersDisconnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Il2CppStringArray>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionPeersDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000286 RID: 646
	// (get) Token: 0x060007BC RID: 1980 RVA: 0x00031CC4 File Offset: 0x0002FEC4
	// (set) Token: 0x060007BD RID: 1981 RVA: 0x00005147 File Offset: 0x00003347
	public unsafe static Action ActionRoomAutomatching
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomAutomatching, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomAutomatching, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060007BE RID: 1982 RVA: 0x00031CEC File Offset: 0x0002FEEC
	// (set) Token: 0x060007BF RID: 1983 RVA: 0x00005159 File Offset: 0x00003359
	public unsafe static Action ActionRoomConnecting
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnecting, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnecting, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00031D14 File Offset: 0x0002FF14
	// (set) Token: 0x060007C1 RID: 1985 RVA: 0x0000516B File Offset: 0x0000336B
	public unsafe static Action<GP_GamesStatusCodes> ActionJoinedRoom
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionJoinedRoom, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_GamesStatusCodes>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionJoinedRoom, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00031D3C File Offset: 0x0002FF3C
	// (set) Token: 0x060007C3 RID: 1987 RVA: 0x0000517D File Offset: 0x0000337D
	public unsafe static Action<GP_RTM_Result> ActionLeftRoom
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionLeftRoom, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_RTM_Result>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionLeftRoom, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00031D64 File Offset: 0x0002FF64
	// (set) Token: 0x060007C5 RID: 1989 RVA: 0x0000518F File Offset: 0x0000338F
	public unsafe static Action<GP_GamesStatusCodes> ActionRoomConnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_GamesStatusCodes>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00031D8C File Offset: 0x0002FF8C
	// (set) Token: 0x060007C7 RID: 1991 RVA: 0x000051A1 File Offset: 0x000033A1
	public unsafe static Action<GP_GamesStatusCodes> ActionRoomCreated
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomCreated, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_GamesStatusCodes>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionRoomCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00031DB4 File Offset: 0x0002FFB4
	// (set) Token: 0x060007C9 RID: 1993 RVA: 0x000051B3 File Offset: 0x000033B3
	public unsafe static Action<AndroidActivityResult> ActionInvitationBoxUIClosed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationBoxUIClosed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidActivityResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationBoxUIClosed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060007CA RID: 1994 RVA: 0x00031DDC File Offset: 0x0002FFDC
	// (set) Token: 0x060007CB RID: 1995 RVA: 0x000051C5 File Offset: 0x000033C5
	public unsafe static Action<AndroidActivityResult> ActionWatingRoomIntentClosed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionWatingRoomIntentClosed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AndroidActivityResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionWatingRoomIntentClosed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060007CC RID: 1996 RVA: 0x00031E04 File Offset: 0x00030004
	// (set) Token: 0x060007CD RID: 1997 RVA: 0x000051D7 File Offset: 0x000033D7
	public unsafe static Action<GP_Invite> ActionInvitationAccepted
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationAccepted, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_Invite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationAccepted, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060007CE RID: 1998 RVA: 0x00031E2C File Offset: 0x0003002C
	// (set) Token: 0x060007CF RID: 1999 RVA: 0x000051E9 File Offset: 0x000033E9
	public unsafe static Action<GP_Invite> ActionInvitationReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_Invite>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000290 RID: 656
	// (get) Token: 0x060007D0 RID: 2000 RVA: 0x00031E54 File Offset: 0x00030054
	// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000051FB File Offset: 0x000033FB
	public unsafe static Action<string> ActionInvitationRemoved
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationRemoved, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_ActionInvitationRemoved, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000291 RID: 657
	// (get) Token: 0x060007D2 RID: 2002 RVA: 0x00031E7C File Offset: 0x0003007C
	// (set) Token: 0x060007D3 RID: 2003 RVA: 0x0000520D File Offset: 0x0000340D
	public unsafe static int BYTE_LIMIT
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.NativeFieldInfoPtr_BYTE_LIMIT, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.NativeFieldInfoPtr_BYTE_LIMIT, (void*)(&value));
		}
	}

	// Token: 0x17000292 RID: 658
	// (get) Token: 0x060007D4 RID: 2004 RVA: 0x00031E98 File Offset: 0x00030098
	// (set) Token: 0x060007D5 RID: 2005 RVA: 0x0000521B File Offset: 0x0000341B
	public unsafe GP_RTM_Room _currentRoom
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__currentRoom);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GP_RTM_Room>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__currentRoom), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000293 RID: 659
	// (get) Token: 0x060007D6 RID: 2006 RVA: 0x00031EC8 File Offset: 0x000300C8
	// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0000523A File Offset: 0x0000343A
	public unsafe List<GP_Invite> _invitations
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__invitations);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GP_Invite>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__invitations), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000294 RID: 660
	// (get) Token: 0x060007D8 RID: 2008 RVA: 0x00031EF8 File Offset: 0x000300F8
	// (set) Token: 0x060007D9 RID: 2009 RVA: 0x00005259 File Offset: 0x00003459
	public unsafe Dictionary<int, GP_RTM_ReliableMessageListener> _ReliableMassageListeners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__ReliableMassageListeners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GP_RTM_ReliableMessageListener>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePlayRTM.NativeFieldInfoPtr__ReliableMassageListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005E6 RID: 1510
	private static readonly IntPtr NativeFieldInfoPtr_ActionDataRecieved;

	// Token: 0x040005E7 RID: 1511
	private static readonly IntPtr NativeFieldInfoPtr_ActionRoomUpdated;

	// Token: 0x040005E8 RID: 1512
	private static readonly IntPtr NativeFieldInfoPtr_ActionReliableMessageSent;

	// Token: 0x040005E9 RID: 1513
	private static readonly IntPtr NativeFieldInfoPtr_ActionReliableMessageDelivered;

	// Token: 0x040005EA RID: 1514
	private static readonly IntPtr NativeFieldInfoPtr_ActionConnectedToRoom;

	// Token: 0x040005EB RID: 1515
	private static readonly IntPtr NativeFieldInfoPtr_ActionDisconnectedFromRoom;

	// Token: 0x040005EC RID: 1516
	private static readonly IntPtr NativeFieldInfoPtr_ActionP2PConnected;

	// Token: 0x040005ED RID: 1517
	private static readonly IntPtr NativeFieldInfoPtr_ActionP2PDisconnected;

	// Token: 0x040005EE RID: 1518
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeerDeclined;

	// Token: 0x040005EF RID: 1519
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeerInvitedToRoom;

	// Token: 0x040005F0 RID: 1520
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeerJoined;

	// Token: 0x040005F1 RID: 1521
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeerLeft;

	// Token: 0x040005F2 RID: 1522
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeersConnected;

	// Token: 0x040005F3 RID: 1523
	private static readonly IntPtr NativeFieldInfoPtr_ActionPeersDisconnected;

	// Token: 0x040005F4 RID: 1524
	private static readonly IntPtr NativeFieldInfoPtr_ActionRoomAutomatching;

	// Token: 0x040005F5 RID: 1525
	private static readonly IntPtr NativeFieldInfoPtr_ActionRoomConnecting;

	// Token: 0x040005F6 RID: 1526
	private static readonly IntPtr NativeFieldInfoPtr_ActionJoinedRoom;

	// Token: 0x040005F7 RID: 1527
	private static readonly IntPtr NativeFieldInfoPtr_ActionLeftRoom;

	// Token: 0x040005F8 RID: 1528
	private static readonly IntPtr NativeFieldInfoPtr_ActionRoomConnected;

	// Token: 0x040005F9 RID: 1529
	private static readonly IntPtr NativeFieldInfoPtr_ActionRoomCreated;

	// Token: 0x040005FA RID: 1530
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationBoxUIClosed;

	// Token: 0x040005FB RID: 1531
	private static readonly IntPtr NativeFieldInfoPtr_ActionWatingRoomIntentClosed;

	// Token: 0x040005FC RID: 1532
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationAccepted;

	// Token: 0x040005FD RID: 1533
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationReceived;

	// Token: 0x040005FE RID: 1534
	private static readonly IntPtr NativeFieldInfoPtr_ActionInvitationRemoved;

	// Token: 0x040005FF RID: 1535
	private static readonly IntPtr NativeFieldInfoPtr_BYTE_LIMIT;

	// Token: 0x04000600 RID: 1536
	private static readonly IntPtr NativeFieldInfoPtr__currentRoom;

	// Token: 0x04000601 RID: 1537
	private static readonly IntPtr NativeFieldInfoPtr__invitations;

	// Token: 0x04000602 RID: 1538
	private static readonly IntPtr NativeFieldInfoPtr__ReliableMassageListeners;

	// Token: 0x04000603 RID: 1539
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionDataRecieved_Public_Static_add_Void_Action_1_GP_RTM_Network_Package_0;

	// Token: 0x04000604 RID: 1540
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionDataRecieved_Public_Static_rem_Void_Action_1_GP_RTM_Network_Package_0;

	// Token: 0x04000605 RID: 1541
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRoomUpdated_Public_Static_add_Void_Action_1_GP_RTM_Room_0;

	// Token: 0x04000606 RID: 1542
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRoomUpdated_Public_Static_rem_Void_Action_1_GP_RTM_Room_0;

	// Token: 0x04000607 RID: 1543
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionReliableMessageSent_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageSentResult_0;

	// Token: 0x04000608 RID: 1544
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionReliableMessageSent_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageSentResult_0;

	// Token: 0x04000609 RID: 1545
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionReliableMessageDelivered_Public_Static_add_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0;

	// Token: 0x0400060A RID: 1546
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionReliableMessageDelivered_Public_Static_rem_Void_Action_1_GP_RTM_ReliableMessageDeliveredResult_0;

	// Token: 0x0400060B RID: 1547
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionConnectedToRoom_Public_Static_add_Void_Action_0;

	// Token: 0x0400060C RID: 1548
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionConnectedToRoom_Public_Static_rem_Void_Action_0;

	// Token: 0x0400060D RID: 1549
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionDisconnectedFromRoom_Public_Static_add_Void_Action_0;

	// Token: 0x0400060E RID: 1550
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionDisconnectedFromRoom_Public_Static_rem_Void_Action_0;

	// Token: 0x0400060F RID: 1551
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionP2PConnected_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000610 RID: 1552
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionP2PConnected_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000611 RID: 1553
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionP2PDisconnected_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000612 RID: 1554
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionP2PDisconnected_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000613 RID: 1555
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeerDeclined_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000614 RID: 1556
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeerDeclined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000615 RID: 1557
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeerInvitedToRoom_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000616 RID: 1558
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeerInvitedToRoom_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000617 RID: 1559
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeerJoined_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000618 RID: 1560
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeerJoined_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x04000619 RID: 1561
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeerLeft_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061A RID: 1562
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeerLeft_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061B RID: 1563
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeersConnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061C RID: 1564
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeersConnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061D RID: 1565
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionPeersDisconnected_Public_Static_add_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061E RID: 1566
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionPeersDisconnected_Public_Static_rem_Void_Action_1_Il2CppStringArray_0;

	// Token: 0x0400061F RID: 1567
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRoomAutomatching_Public_Static_add_Void_Action_0;

	// Token: 0x04000620 RID: 1568
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRoomAutomatching_Public_Static_rem_Void_Action_0;

	// Token: 0x04000621 RID: 1569
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRoomConnecting_Public_Static_add_Void_Action_0;

	// Token: 0x04000622 RID: 1570
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRoomConnecting_Public_Static_rem_Void_Action_0;

	// Token: 0x04000623 RID: 1571
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionJoinedRoom_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x04000624 RID: 1572
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionJoinedRoom_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x04000625 RID: 1573
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionLeftRoom_Public_Static_add_Void_Action_1_GP_RTM_Result_0;

	// Token: 0x04000626 RID: 1574
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionLeftRoom_Public_Static_rem_Void_Action_1_GP_RTM_Result_0;

	// Token: 0x04000627 RID: 1575
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRoomConnected_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x04000628 RID: 1576
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRoomConnected_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x04000629 RID: 1577
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionRoomCreated_Public_Static_add_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x0400062A RID: 1578
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionRoomCreated_Public_Static_rem_Void_Action_1_GP_GamesStatusCodes_0;

	// Token: 0x0400062B RID: 1579
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationBoxUIClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x0400062C RID: 1580
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationBoxUIClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x0400062D RID: 1581
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionWatingRoomIntentClosed_Public_Static_add_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x0400062E RID: 1582
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionWatingRoomIntentClosed_Public_Static_rem_Void_Action_1_AndroidActivityResult_0;

	// Token: 0x0400062F RID: 1583
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationAccepted_Public_Static_add_Void_Action_1_GP_Invite_0;

	// Token: 0x04000630 RID: 1584
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationAccepted_Public_Static_rem_Void_Action_1_GP_Invite_0;

	// Token: 0x04000631 RID: 1585
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationReceived_Public_Static_add_Void_Action_1_GP_Invite_0;

	// Token: 0x04000632 RID: 1586
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationReceived_Public_Static_rem_Void_Action_1_GP_Invite_0;

	// Token: 0x04000633 RID: 1587
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInvitationRemoved_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x04000634 RID: 1588
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInvitationRemoved_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x04000635 RID: 1589
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000636 RID: 1590
	private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_0;

	// Token: 0x04000637 RID: 1591
	private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppReferenceArray_1_GooglePlayerTemplate_0;

	// Token: 0x04000638 RID: 1592
	private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Public_Void_Int32_Int32_Il2CppStringArray_0;

	// Token: 0x04000639 RID: 1593
	private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppReferenceArray_1_GooglePlayerTemplate_0;

	// Token: 0x0400063A RID: 1594
	private static readonly IntPtr NativeMethodInfoPtr_FindMatch_Public_Void_Il2CppStringArray_0;

	// Token: 0x0400063B RID: 1595
	private static readonly IntPtr NativeMethodInfoPtr_SendDataToAll_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_0;

	// Token: 0x0400063C RID: 1596
	private static readonly IntPtr NativeMethodInfoPtr_SendDataToPlayers_Public_Void_Il2CppStructArray_1_Byte_GP_RTM_PackageType_Il2CppStringArray_0;

	// Token: 0x0400063D RID: 1597
	private static readonly IntPtr NativeMethodInfoPtr_ShowWaitingRoomIntent_Public_Void_0;

	// Token: 0x0400063E RID: 1598
	private static readonly IntPtr NativeMethodInfoPtr_OpenInvitationBoxUI_Public_Void_Int32_Int32_0;

	// Token: 0x0400063F RID: 1599
	private static readonly IntPtr NativeMethodInfoPtr_LeaveRoom_Public_Void_0;

	// Token: 0x04000640 RID: 1600
	private static readonly IntPtr NativeMethodInfoPtr_AcceptInvitation_Public_Void_String_0;

	// Token: 0x04000641 RID: 1601
	private static readonly IntPtr NativeMethodInfoPtr_DeclineInvitation_Public_Void_String_0;

	// Token: 0x04000642 RID: 1602
	private static readonly IntPtr NativeMethodInfoPtr_DismissInvitation_Public_Void_String_0;

	// Token: 0x04000643 RID: 1603
	private static readonly IntPtr NativeMethodInfoPtr_OpenInvitationInBoxUI_Public_Void_0;

	// Token: 0x04000644 RID: 1604
	private static readonly IntPtr NativeMethodInfoPtr_SetVariant_Public_Void_Int32_0;

	// Token: 0x04000645 RID: 1605
	private static readonly IntPtr NativeMethodInfoPtr_SetExclusiveBitMask_Public_Void_Int32_0;

	// Token: 0x04000646 RID: 1606
	private static readonly IntPtr NativeMethodInfoPtr_ClearReliableMessageListener_Public_Void_Int32_0;

	// Token: 0x04000647 RID: 1607
	private static readonly IntPtr NativeMethodInfoPtr_get_currentRoom_Public_get_GP_RTM_Room_0;

	// Token: 0x04000648 RID: 1608
	private static readonly IntPtr NativeMethodInfoPtr_get_invitations_Public_get_List_1_GP_Invite_0;

	// Token: 0x04000649 RID: 1609
	private static readonly IntPtr NativeMethodInfoPtr_OnWatingRoomIntentClosed_Private_Void_String_0;

	// Token: 0x0400064A RID: 1610
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomUpdate_Private_Void_String_0;

	// Token: 0x0400064B RID: 1611
	private static readonly IntPtr NativeMethodInfoPtr_OnReliableMessageSent_Private_Void_String_0;

	// Token: 0x0400064C RID: 1612
	private static readonly IntPtr NativeMethodInfoPtr_OnReliableMessageDelivered_Private_Void_String_0;

	// Token: 0x0400064D RID: 1613
	private static readonly IntPtr NativeMethodInfoPtr_OnMatchDataRecieved_Private_Void_String_0;

	// Token: 0x0400064E RID: 1614
	private static readonly IntPtr NativeMethodInfoPtr_OnConnectedToRoom_Private_Void_String_0;

	// Token: 0x0400064F RID: 1615
	private static readonly IntPtr NativeMethodInfoPtr_OnDisconnectedFromRoom_Private_Void_String_0;

	// Token: 0x04000650 RID: 1616
	private static readonly IntPtr NativeMethodInfoPtr_OnP2PConnected_Private_Void_String_0;

	// Token: 0x04000651 RID: 1617
	private static readonly IntPtr NativeMethodInfoPtr_OnP2PDisconnected_Private_Void_String_0;

	// Token: 0x04000652 RID: 1618
	private static readonly IntPtr NativeMethodInfoPtr_OnPeerDeclined_Private_Void_String_0;

	// Token: 0x04000653 RID: 1619
	private static readonly IntPtr NativeMethodInfoPtr_OnPeerInvitedToRoom_Private_Void_String_0;

	// Token: 0x04000654 RID: 1620
	private static readonly IntPtr NativeMethodInfoPtr_OnPeerJoined_Private_Void_String_0;

	// Token: 0x04000655 RID: 1621
	private static readonly IntPtr NativeMethodInfoPtr_OnPeerLeft_Private_Void_String_0;

	// Token: 0x04000656 RID: 1622
	private static readonly IntPtr NativeMethodInfoPtr_OnPeersConnected_Private_Void_String_0;

	// Token: 0x04000657 RID: 1623
	private static readonly IntPtr NativeMethodInfoPtr_OnPeersDisconnected_Private_Void_String_0;

	// Token: 0x04000658 RID: 1624
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomAutoMatching_Private_Void_String_0;

	// Token: 0x04000659 RID: 1625
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomConnecting_Private_Void_String_0;

	// Token: 0x0400065A RID: 1626
	private static readonly IntPtr NativeMethodInfoPtr_OnJoinedRoom_Private_Void_String_0;

	// Token: 0x0400065B RID: 1627
	private static readonly IntPtr NativeMethodInfoPtr_OnLeftRoom_Private_Void_String_0;

	// Token: 0x0400065C RID: 1628
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomConnected_Private_Void_String_0;

	// Token: 0x0400065D RID: 1629
	private static readonly IntPtr NativeMethodInfoPtr_OnRoomCreated_Private_Void_String_0;

	// Token: 0x0400065E RID: 1630
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationBoxUiClosed_Private_Void_String_0;

	// Token: 0x0400065F RID: 1631
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationReceived_Private_Void_GP_Invite_0;

	// Token: 0x04000660 RID: 1632
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationRemoved_Private_Void_String_0;

	// Token: 0x04000661 RID: 1633
	private static readonly IntPtr NativeMethodInfoPtr_OnInvitationAccepted_Private_Void_GP_Invite_0;

	// Token: 0x04000662 RID: 1634
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000375 RID: 885
	[ObfuscatedName("GooglePlayRTM+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060034EC RID: 13548 RVA: 0x000DA718 File Offset: 0x000D8918
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GooglePlayRTM>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr);
			GooglePlayRTM.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, "<>9");
			GooglePlayRTM.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670031);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_0_Internal_Void_GP_RTM_Network_Package_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670032);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_1_Internal_Void_GP_RTM_Room_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670033);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_2_Internal_Void_GP_RTM_ReliableMessageSentResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670034);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_3_Internal_Void_GP_RTM_ReliableMessageDeliveredResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670035);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670036);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670037);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_6_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670038);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_7_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670039);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_8_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670040);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_9_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670041);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_10_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670042);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_11_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670043);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_12_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670044);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_13_Internal_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670045);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670046);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_15_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670047);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_16_Internal_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670048);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_17_Internal_Void_GP_RTM_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670049);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_18_Internal_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670050);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_19_Internal_Void_GP_GamesStatusCodes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670051);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_20_Internal_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670052);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_21_Internal_Void_AndroidActivityResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670053);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_22_Internal_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670054);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_23_Internal_Void_GP_Invite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670055);
			GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_24_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr, 100670056);
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x000DA960 File Offset: 0x000D8B60
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePlayRTM.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x000DA99C File Offset: 0x000D8B9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_0(GP_RTM_Network_Package <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_0_Internal_Void_GP_RTM_Network_Package_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x000DA9E0 File Offset: 0x000D8BE0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_1(GP_RTM_Room <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_1_Internal_Void_GP_RTM_Room_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x000DAA24 File Offset: 0x000D8C24
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_2(GP_RTM_ReliableMessageSentResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_2_Internal_Void_GP_RTM_ReliableMessageSentResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x000DAA68 File Offset: 0x000D8C68
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_3(GP_RTM_ReliableMessageDeliveredResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_3_Internal_Void_GP_RTM_ReliableMessageDeliveredResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x000DAAAC File Offset: 0x000D8CAC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x000DAAE0 File Offset: 0x000D8CE0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x000DAB14 File Offset: 0x000D8D14
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_6(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_6_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x000DAB58 File Offset: 0x000D8D58
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_7(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_7_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x000DAB9C File Offset: 0x000D8D9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_8(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_8_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x000DABE0 File Offset: 0x000D8DE0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_9(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_9_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x000DAC24 File Offset: 0x000D8E24
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_10(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_10_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x000DAC68 File Offset: 0x000D8E68
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_11(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_11_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x000DACAC File Offset: 0x000D8EAC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_12(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_12_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x000DACF0 File Offset: 0x000D8EF0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_13(Il2CppStringArray <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_13_Internal_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x000DAD34 File Offset: 0x000D8F34
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_14()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x000DAD68 File Offset: 0x000D8F68
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_15()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_15_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x000DAD9C File Offset: 0x000D8F9C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_16(GP_GamesStatusCodes <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_16_Internal_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x000DADDC File Offset: 0x000D8FDC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_17(GP_RTM_Result <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_17_Internal_Void_GP_RTM_Result_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x000DAE20 File Offset: 0x000D9020
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_18(GP_GamesStatusCodes <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_18_Internal_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x000DAE60 File Offset: 0x000D9060
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_19(GP_GamesStatusCodes <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_19_Internal_Void_GP_GamesStatusCodes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x000DAEA0 File Offset: 0x000D90A0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_20(AndroidActivityResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_20_Internal_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x000DAEE4 File Offset: 0x000D90E4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_21(AndroidActivityResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_21_Internal_Void_AndroidActivityResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x000DAF28 File Offset: 0x000D9128
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_22(GP_Invite <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_22_Internal_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x000DAF6C File Offset: 0x000D916C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_23(GP_Invite <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_23_Internal_Void_GP_Invite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x000DAFB0 File Offset: 0x000D91B0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__127_24(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePlayRTM.__c.NativeMethodInfoPtr___cctor_b__127_24_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x000149C7 File Offset: 0x00012BC7
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06003508 RID: 13576 RVA: 0x000DAFF4 File Offset: 0x000D91F4
		// (set) Token: 0x06003509 RID: 13577 RVA: 0x000149D0 File Offset: 0x00012BD0
		public unsafe static GooglePlayRTM.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GooglePlayRTM.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GooglePlayRTM.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GooglePlayRTM.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030D7 RID: 12503
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x040030D8 RID: 12504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040030D9 RID: 12505
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_0_Internal_Void_GP_RTM_Network_Package_0;

		// Token: 0x040030DA RID: 12506
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_1_Internal_Void_GP_RTM_Room_0;

		// Token: 0x040030DB RID: 12507
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_2_Internal_Void_GP_RTM_ReliableMessageSentResult_0;

		// Token: 0x040030DC RID: 12508
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_3_Internal_Void_GP_RTM_ReliableMessageDeliveredResult_0;

		// Token: 0x040030DD RID: 12509
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_4_Internal_Void_0;

		// Token: 0x040030DE RID: 12510
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_5_Internal_Void_0;

		// Token: 0x040030DF RID: 12511
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_6_Internal_Void_String_0;

		// Token: 0x040030E0 RID: 12512
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_7_Internal_Void_String_0;

		// Token: 0x040030E1 RID: 12513
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_8_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E2 RID: 12514
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_9_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E3 RID: 12515
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_10_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E4 RID: 12516
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_11_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E5 RID: 12517
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_12_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E6 RID: 12518
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_13_Internal_Void_Il2CppStringArray_0;

		// Token: 0x040030E7 RID: 12519
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_14_Internal_Void_0;

		// Token: 0x040030E8 RID: 12520
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_15_Internal_Void_0;

		// Token: 0x040030E9 RID: 12521
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_16_Internal_Void_GP_GamesStatusCodes_0;

		// Token: 0x040030EA RID: 12522
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_17_Internal_Void_GP_RTM_Result_0;

		// Token: 0x040030EB RID: 12523
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_18_Internal_Void_GP_GamesStatusCodes_0;

		// Token: 0x040030EC RID: 12524
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_19_Internal_Void_GP_GamesStatusCodes_0;

		// Token: 0x040030ED RID: 12525
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_20_Internal_Void_AndroidActivityResult_0;

		// Token: 0x040030EE RID: 12526
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_21_Internal_Void_AndroidActivityResult_0;

		// Token: 0x040030EF RID: 12527
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_22_Internal_Void_GP_Invite_0;

		// Token: 0x040030F0 RID: 12528
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_23_Internal_Void_GP_Invite_0;

		// Token: 0x040030F1 RID: 12529
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__127_24_Internal_Void_String_0;
	}
}
