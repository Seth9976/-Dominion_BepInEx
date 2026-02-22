using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200006B RID: 107
public class Network : MonoBehaviour
{
	// Token: 0x06000DD8 RID: 3544 RVA: 0x0004206C File Offset: 0x0004026C
	// Note: this type is marked as 'beforefieldinit'.
	static Network()
	{
		Il2CppClassPointerStore<Network>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Network");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Network>.NativeClassPtr);
		Network.NativeFieldInfoPtr_k_maxGamePlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "k_maxGamePlayers");
		Network.NativeFieldInfoPtr_k_maxActiveGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "k_maxActiveGames");
		Network.NativeFieldInfoPtr_k_maxAvailableGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "k_maxAvailableGames");
		Network.NativeFieldInfoPtr_k_maxFriendListSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "k_maxFriendListSize");
		Network.NativeFieldInfoPtr_k_maxMatchmakingGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "k_maxMatchmakingGames");
		Network.NativeFieldInfoPtr_m_Network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_Network");
		Network.NativeFieldInfoPtr_m_bPausedDuringNetworkSession = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bPausedDuringNetworkSession");
		Network.NativeFieldInfoPtr_m_loginName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_loginName");
		Network.NativeFieldInfoPtr_m_loginPassword = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_loginPassword");
		Network.NativeFieldInfoPtr_m_asmodeeAccessToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_asmodeeAccessToken");
		Network.NativeFieldInfoPtr_m_NetworkEventListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_NetworkEventListeners");
		Network.NativeFieldInfoPtr_m_LastNetworkStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_LastNetworkStatus");
		Network.NativeFieldInfoPtr_m_bConnectedToServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bConnectedToServer");
		Network.NativeFieldInfoPtr_m_bLoggedInToServer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bLoggedInToServer");
		Network.NativeFieldInfoPtr_m_bServerConnectionLost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bServerConnectionLost");
		Network.NativeFieldInfoPtr_m_bServerDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bServerDisconnected");
		Network.NativeFieldInfoPtr_m_bCreateAccount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bCreateAccount");
		Network.NativeFieldInfoPtr_networkEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "networkEvents");
		Network.NativeFieldInfoPtr_m_bNewAvailableGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bNewAvailableGames");
		Network.NativeFieldInfoPtr_m_bRequestRefreshAvailableGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Network>.NativeClassPtr, "m_bRequestRefreshAvailableGames");
		Network.NativeMethodInfoPtr_add_m_NetworkEventListeners_Private_add_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664238);
		Network.NativeMethodInfoPtr_remove_m_NetworkEventListeners_Private_rem_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664239);
		Network.NativeMethodInfoPtr_IsCreateAccount_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664240);
		Network.NativeMethodInfoPtr_AddNetworkEventHandler_Public_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664241);
		Network.NativeMethodInfoPtr_RemoveNetworkEventHandler_Public_Void_NetworkEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664242);
		Network.NativeMethodInfoPtr_ClearNetworkEventHandlerList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664243);
		Network.NativeMethodInfoPtr_RaiseNetworkEvent_Private_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664244);
		Network.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664245);
		Network.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664246);
		Network.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664247);
		Network.NativeMethodInfoPtr_Create_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664248);
		Network.NativeMethodInfoPtr_Login_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664249);
		Network.NativeMethodInfoPtr_SetLogin_Public_Static_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664250);
		Network.NativeMethodInfoPtr_RetryLogin_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664251);
		Network.NativeMethodInfoPtr_CreateAccount_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664252);
		Network.NativeMethodInfoPtr_SetCreateAccount_Public_Static_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664253);
		Network.NativeMethodInfoPtr_Connect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664254);
		Network.NativeMethodInfoPtr_ConnectAsmodee_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664255);
		Network.NativeMethodInfoPtr_Disconnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664256);
		Network.NativeMethodInfoPtr_PrepareForReconnect_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664257);
		Network.NativeMethodInfoPtr_Destroy_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664258);
		Network.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664259);
		Network.NativeMethodInfoPtr_GetActiveGameList_Public_Static_List_1_ShortSaveStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664260);
		Network.NativeMethodInfoPtr_GetCompletedGameList_Public_Static_List_1_ShortSaveStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664261);
		Network.NativeMethodInfoPtr_GetGamePlayerTimers_Public_Static_List_1_GamePlayerTimer_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664262);
		Network.NativeMethodInfoPtr_NewAvailableGames_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664263);
		Network.NativeMethodInfoPtr_RefreshAvailableGames_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664264);
		Network.NativeMethodInfoPtr_GetAvailableGameList_Public_Static_List_1_ShortSaveStruct_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664265);
		Network.NativeMethodInfoPtr_CreateGame_Public_Static_Void_UInt32_Il2CppStructArray_1_UInt32_UInt32_GameParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664266);
		Network.NativeMethodInfoPtr_GetFriendsList_Public_Static_List_1_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664267);
		Network.NativeMethodInfoPtr_GetUserOnlineStatus_Public_Static_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664268);
		Network.NativeMethodInfoPtr_RequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664269);
		Network.NativeMethodInfoPtr_SetMonitorGame_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664270);
		Network.NativeMethodInfoPtr_ClearMonitorGame_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664271);
		Network.NativeMethodInfoPtr_AddFriendFromUsername_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664272);
		Network.NativeMethodInfoPtr_AddFriendFromEmail_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664273);
		Network.NativeMethodInfoPtr_RemoveFriendWithUserId_Public_Static_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664274);
		Network.NativeMethodInfoPtr_RequestNetworkPlayerProfile_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664275);
		Network.NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664276);
		Network.NativeMethodInfoPtr_GetRemotePlayerProfileInfo_Public_Static_Void_Int32_byref_NetworkPlayerProfileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664277);
		Network.NativeMethodInfoPtr_GetLocalPlayerProfileInfo_Public_Static_Void_byref_NetworkPlayerProfileInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664278);
		Network.NativeMethodInfoPtr_SendLocalAvatarIndex_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664279);
		Network.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network>.NativeClassPtr, 100664280);
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x00042588 File Offset: 0x00040788
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 238262, RefRangeEnd = 238267, XrefRangeStart = 238258, XrefRangeEnd = 238262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_m_NetworkEventListeners(Network.NetworkEventDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_add_m_NetworkEventListeners_Private_add_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x000425CC File Offset: 0x000407CC
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 238271, RefRangeEnd = 238277, XrefRangeStart = 238267, XrefRangeEnd = 238271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_m_NetworkEventListeners(Network.NetworkEventDelegate value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_remove_m_NetworkEventListeners_Private_rem_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00042610 File Offset: 0x00040810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238277, XrefRangeEnd = 238283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsCreateAccount()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_IsCreateAccount_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x00042640 File Offset: 0x00040840
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 238262, RefRangeEnd = 238267, XrefRangeStart = 238262, XrefRangeEnd = 238267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddNetworkEventHandler(Network.NetworkEventDelegate h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_AddNetworkEventHandler_Public_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00042684 File Offset: 0x00040884
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 238271, RefRangeEnd = 238277, XrefRangeStart = 238271, XrefRangeEnd = 238277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveNetworkEventHandler(Network.NetworkEventDelegate h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(h);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RemoveNetworkEventHandler_Public_Void_NetworkEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x000426C8 File Offset: 0x000408C8
	[CallerCount(0)]
	public unsafe void ClearNetworkEventHandlerList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_ClearNetworkEventHandlerList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x000426FC File Offset: 0x000408FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238283, XrefRangeEnd = 238284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RaiseNetworkEvent(NetworkEvent.EventType eventType, int data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RaiseNetworkEvent_Private_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00042748 File Offset: 0x00040948
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238284, XrefRangeEnd = 238325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x0004277C File Offset: 0x0004097C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x000427B0 File Offset: 0x000409B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238325, XrefRangeEnd = 238326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x000427E4 File Offset: 0x000409E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238326, XrefRangeEnd = 238339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Create_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x0004280C File Offset: 0x00040A0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238339, XrefRangeEnd = 238361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Login(string user, string password)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(user);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Login_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x00042854 File Offset: 0x00040A54
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238375, RefRangeEnd = 238376, XrefRangeStart = 238361, XrefRangeEnd = 238375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetLogin(string user, string password)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(user);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_SetLogin_Public_Static_Void_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x0004289C File Offset: 0x00040A9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238390, RefRangeEnd = 238391, XrefRangeStart = 238376, XrefRangeEnd = 238390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RetryLogin()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RetryLogin_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x000428C4 File Offset: 0x00040AC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238391, XrefRangeEnd = 238418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateAccount(string email, string password, string username)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(email);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_CreateAccount_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00042920 File Offset: 0x00040B20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238435, RefRangeEnd = 238436, XrefRangeStart = 238418, XrefRangeEnd = 238435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCreateAccount(string email, string password, string username)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(email);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_SetCreateAccount_Public_Static_Void_String_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0004297C File Offset: 0x00040B7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238436, XrefRangeEnd = 238459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Connect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Connect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x000429A4 File Offset: 0x00040BA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238459, XrefRangeEnd = 238476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ConnectAsmodee()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_ConnectAsmodee_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x000429CC File Offset: 0x00040BCC
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 238497, RefRangeEnd = 238503, XrefRangeStart = 238476, XrefRangeEnd = 238497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Disconnect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Disconnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x000429F4 File Offset: 0x00040BF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238503, XrefRangeEnd = 238514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PrepareForReconnect()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_PrepareForReconnect_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x00042A1C File Offset: 0x00040C1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238514, XrefRangeEnd = 238527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Destroy()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_Destroy_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00042A44 File Offset: 0x00040C44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238527, XrefRangeEnd = 238576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FixedUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00042A78 File Offset: 0x00040C78
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238614, RefRangeEnd = 238616, XrefRangeStart = 238576, XrefRangeEnd = 238614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ShortSaveStruct> GetActiveGameList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetActiveGameList_Public_Static_List_1_ShortSaveStruct_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShortSaveStruct>>(intPtr3) : null;
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x00042AAC File Offset: 0x00040CAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238654, RefRangeEnd = 238655, XrefRangeStart = 238616, XrefRangeEnd = 238654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ShortSaveStruct> GetCompletedGameList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetCompletedGameList_Public_Static_List_1_ShortSaveStruct_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShortSaveStruct>>(intPtr3) : null;
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00042AE0 File Offset: 0x00040CE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238693, RefRangeEnd = 238694, XrefRangeStart = 238655, XrefRangeEnd = 238693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<GamePlayerTimer> GetGamePlayerTimers(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetGamePlayerTimers_Public_Static_List_1_GamePlayerTimer_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<GamePlayerTimer>>(intPtr3) : null;
		}
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00042B20 File Offset: 0x00040D20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238694, XrefRangeEnd = 238696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool NewAvailableGames()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_NewAvailableGames_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00042B50 File Offset: 0x00040D50
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238700, RefRangeEnd = 238701, XrefRangeStart = 238696, XrefRangeEnd = 238700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RefreshAvailableGames()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RefreshAvailableGames_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00042B78 File Offset: 0x00040D78
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238741, RefRangeEnd = 238742, XrefRangeStart = 238701, XrefRangeEnd = 238741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<ShortSaveStruct> GetAvailableGameList(uint playerFilterFlags, uint timerFilterFlags)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerFilterFlags;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timerFilterFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetAvailableGameList_Public_Static_List_1_ShortSaveStruct_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ShortSaveStruct>>(intPtr3) : null;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00042BC8 File Offset: 0x00040DC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238762, RefRangeEnd = 238763, XrefRangeStart = 238742, XrefRangeEnd = 238762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateGame(uint maxPlayerCount, Il2CppStructArray<uint> inviteIDs, uint startPlayerTimer, GameParameters gameParams)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref maxPlayerCount;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inviteIDs);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPlayerTimer;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref gameParams;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_CreateGame_Public_Static_Void_UInt32_Il2CppStructArray_1_UInt32_UInt32_GameParameters_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00042C28 File Offset: 0x00040E28
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238801, RefRangeEnd = 238803, XrefRangeStart = 238763, XrefRangeEnd = 238801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static List<FriendInfo> GetFriendsList()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetFriendsList_Public_Static_List_1_FriendInfo_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FriendInfo>>(intPtr3) : null;
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00042C5C File Offset: 0x00040E5C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238804, RefRangeEnd = 238806, XrefRangeStart = 238803, XrefRangeEnd = 238804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetUserOnlineStatus(uint userID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetUserOnlineStatus_Public_Static_Int32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x00042C9C File Offset: 0x00040E9C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238807, RefRangeEnd = 238810, XrefRangeStart = 238806, XrefRangeEnd = 238807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestUsersOnlineStatus(IntPtr usersArray, int numUsers)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref usersArray;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numUsers;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00042CDC File Offset: 0x00040EDC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238810, XrefRangeEnd = 238811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMonitorGame(uint gameID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref gameID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_SetMonitorGame_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00042D10 File Offset: 0x00040F10
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238812, RefRangeEnd = 238813, XrefRangeStart = 238811, XrefRangeEnd = 238812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearMonitorGame()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_ClearMonitorGame_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x00042D38 File Offset: 0x00040F38
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238816, RefRangeEnd = 238819, XrefRangeStart = 238813, XrefRangeEnd = 238816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddFriendFromUsername(string username)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_AddFriendFromUsername_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00042D7C File Offset: 0x00040F7C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238822, RefRangeEnd = 238823, XrefRangeStart = 238819, XrefRangeEnd = 238822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int AddFriendFromEmail(string email)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(email);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_AddFriendFromEmail_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00042DC0 File Offset: 0x00040FC0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238826, RefRangeEnd = 238827, XrefRangeStart = 238823, XrefRangeEnd = 238826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RemoveFriendWithUserId(uint userID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RemoveFriendWithUserId_Public_Static_Boolean_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00042E00 File Offset: 0x00041000
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 238828, RefRangeEnd = 238834, XrefRangeStart = 238827, XrefRangeEnd = 238828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RequestNetworkPlayerProfile(uint userID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_RequestNetworkPlayerProfile_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00042E34 File Offset: 0x00041034
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238835, RefRangeEnd = 238837, XrefRangeStart = 238834, XrefRangeEnd = 238835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static uint NetworkGetLocalID()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00042E64 File Offset: 0x00041064
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 238860, RefRangeEnd = 238861, XrefRangeStart = 238837, XrefRangeEnd = 238860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetRemotePlayerProfileInfo(int remotePlayerID, out NetworkPlayerProfileInfo profile)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref remotePlayerID;
		}
		ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr = 0;
		ptr2 = &intPtr;
		IntPtr intPtr3;
		IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetRemotePlayerProfileInfo_Public_Static_Void_Int32_byref_NetworkPlayerProfileInfo_0, 0, (void**)ptr, ref intPtr3);
		Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		IntPtr intPtr4 = intPtr;
		profile = ((intPtr4 == 0) ? null : new NetworkPlayerProfileInfo(intPtr4));
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00042EB8 File Offset: 0x000410B8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 238884, RefRangeEnd = 238886, XrefRangeStart = 238861, XrefRangeEnd = 238884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetLocalPlayerProfileInfo(out NetworkPlayerProfileInfo profile)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_GetLocalPlayerProfileInfo_Public_Static_Void_byref_NetworkPlayerProfileInfo_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			profile = ((intPtr4 == 0) ? null : new NetworkPlayerProfileInfo(intPtr4));
		}
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00042F00 File Offset: 0x00041100
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 238887, RefRangeEnd = 238890, XrefRangeStart = 238886, XrefRangeEnd = 238887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SendLocalAvatarIndex(uint avatarIndex)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref avatarIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr_SendLocalAvatarIndex_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00042F34 File Offset: 0x00041134
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Network()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Network>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x0000A2AF File Offset: 0x000084AF
	public Network(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170004BC RID: 1212
	// (get) Token: 0x06000E05 RID: 3589 RVA: 0x00042F70 File Offset: 0x00041170
	// (set) Token: 0x06000E06 RID: 3590 RVA: 0x0000A2B8 File Offset: 0x000084B8
	public unsafe static int k_maxGamePlayers
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_k_maxGamePlayers, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_k_maxGamePlayers, (void*)(&value));
		}
	}

	// Token: 0x170004BD RID: 1213
	// (get) Token: 0x06000E07 RID: 3591 RVA: 0x00042F8C File Offset: 0x0004118C
	// (set) Token: 0x06000E08 RID: 3592 RVA: 0x0000A2C6 File Offset: 0x000084C6
	public unsafe static int k_maxActiveGames
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_k_maxActiveGames, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_k_maxActiveGames, (void*)(&value));
		}
	}

	// Token: 0x170004BE RID: 1214
	// (get) Token: 0x06000E09 RID: 3593 RVA: 0x00042FA8 File Offset: 0x000411A8
	// (set) Token: 0x06000E0A RID: 3594 RVA: 0x0000A2D4 File Offset: 0x000084D4
	public unsafe static int k_maxAvailableGames
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_k_maxAvailableGames, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_k_maxAvailableGames, (void*)(&value));
		}
	}

	// Token: 0x170004BF RID: 1215
	// (get) Token: 0x06000E0B RID: 3595 RVA: 0x00042FC4 File Offset: 0x000411C4
	// (set) Token: 0x06000E0C RID: 3596 RVA: 0x0000A2E2 File Offset: 0x000084E2
	public unsafe static int k_maxFriendListSize
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_k_maxFriendListSize, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_k_maxFriendListSize, (void*)(&value));
		}
	}

	// Token: 0x170004C0 RID: 1216
	// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00042FE0 File Offset: 0x000411E0
	// (set) Token: 0x06000E0E RID: 3598 RVA: 0x0000A2F0 File Offset: 0x000084F0
	public unsafe static int k_maxMatchmakingGames
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_k_maxMatchmakingGames, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_k_maxMatchmakingGames, (void*)(&value));
		}
	}

	// Token: 0x170004C1 RID: 1217
	// (get) Token: 0x06000E0F RID: 3599 RVA: 0x00042FFC File Offset: 0x000411FC
	// (set) Token: 0x06000E10 RID: 3600 RVA: 0x0000A2FE File Offset: 0x000084FE
	public unsafe static Network m_Network
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_m_Network, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Network>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_m_Network, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004C2 RID: 1218
	// (get) Token: 0x06000E11 RID: 3601 RVA: 0x00043024 File Offset: 0x00041224
	// (set) Token: 0x06000E12 RID: 3602 RVA: 0x0000A310 File Offset: 0x00008510
	public unsafe static bool m_bPausedDuringNetworkSession
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_m_bPausedDuringNetworkSession, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_m_bPausedDuringNetworkSession, (void*)(&value));
		}
	}

	// Token: 0x170004C3 RID: 1219
	// (get) Token: 0x06000E13 RID: 3603 RVA: 0x00043040 File Offset: 0x00041240
	// (set) Token: 0x06000E14 RID: 3604 RVA: 0x0000A31E File Offset: 0x0000851E
	public unsafe static string m_loginName
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_m_loginName, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_m_loginName, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004C4 RID: 1220
	// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00043060 File Offset: 0x00041260
	// (set) Token: 0x06000E16 RID: 3606 RVA: 0x0000A330 File Offset: 0x00008530
	public unsafe static string m_loginPassword
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_m_loginPassword, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_m_loginPassword, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004C5 RID: 1221
	// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00043080 File Offset: 0x00041280
	// (set) Token: 0x06000E18 RID: 3608 RVA: 0x0000A342 File Offset: 0x00008542
	public unsafe static string m_asmodeeAccessToken
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(Network.NativeFieldInfoPtr_m_asmodeeAccessToken, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(Network.NativeFieldInfoPtr_m_asmodeeAccessToken, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004C6 RID: 1222
	// (get) Token: 0x06000E19 RID: 3609 RVA: 0x000430A0 File Offset: 0x000412A0
	// (set) Token: 0x06000E1A RID: 3610 RVA: 0x0000A354 File Offset: 0x00008554
	public unsafe Network.NetworkEventDelegate m_NetworkEventListeners
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_NetworkEventListeners);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Network.NetworkEventDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_NetworkEventListeners), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004C7 RID: 1223
	// (get) Token: 0x06000E1B RID: 3611 RVA: 0x000430D0 File Offset: 0x000412D0
	// (set) Token: 0x06000E1C RID: 3612 RVA: 0x0000A373 File Offset: 0x00008573
	public unsafe string m_LastNetworkStatus
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_LastNetworkStatus);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_LastNetworkStatus), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x170004C8 RID: 1224
	// (get) Token: 0x06000E1D RID: 3613 RVA: 0x000430F8 File Offset: 0x000412F8
	// (set) Token: 0x06000E1E RID: 3614 RVA: 0x0000A392 File Offset: 0x00008592
	public unsafe bool m_bConnectedToServer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bConnectedToServer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bConnectedToServer)) = value;
		}
	}

	// Token: 0x170004C9 RID: 1225
	// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00043120 File Offset: 0x00041320
	// (set) Token: 0x06000E20 RID: 3616 RVA: 0x0000A3AD File Offset: 0x000085AD
	public unsafe bool m_bLoggedInToServer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bLoggedInToServer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bLoggedInToServer)) = value;
		}
	}

	// Token: 0x170004CA RID: 1226
	// (get) Token: 0x06000E21 RID: 3617 RVA: 0x00043148 File Offset: 0x00041348
	// (set) Token: 0x06000E22 RID: 3618 RVA: 0x0000A3C8 File Offset: 0x000085C8
	public unsafe bool m_bServerConnectionLost
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bServerConnectionLost);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bServerConnectionLost)) = value;
		}
	}

	// Token: 0x170004CB RID: 1227
	// (get) Token: 0x06000E23 RID: 3619 RVA: 0x00043170 File Offset: 0x00041370
	// (set) Token: 0x06000E24 RID: 3620 RVA: 0x0000A3E3 File Offset: 0x000085E3
	public unsafe bool m_bServerDisconnected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bServerDisconnected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bServerDisconnected)) = value;
		}
	}

	// Token: 0x170004CC RID: 1228
	// (get) Token: 0x06000E25 RID: 3621 RVA: 0x00043198 File Offset: 0x00041398
	// (set) Token: 0x06000E26 RID: 3622 RVA: 0x0000A3FE File Offset: 0x000085FE
	public unsafe bool m_bCreateAccount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bCreateAccount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bCreateAccount)) = value;
		}
	}

	// Token: 0x170004CD RID: 1229
	// (get) Token: 0x06000E27 RID: 3623 RVA: 0x000431C0 File Offset: 0x000413C0
	// (set) Token: 0x06000E28 RID: 3624 RVA: 0x0000A419 File Offset: 0x00008619
	public unsafe Il2CppStructArray<NetworkEvent> networkEvents
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_networkEvents);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NetworkEvent>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_networkEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170004CE RID: 1230
	// (get) Token: 0x06000E29 RID: 3625 RVA: 0x000431F0 File Offset: 0x000413F0
	// (set) Token: 0x06000E2A RID: 3626 RVA: 0x0000A438 File Offset: 0x00008638
	public unsafe bool m_bNewAvailableGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bNewAvailableGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bNewAvailableGames)) = value;
		}
	}

	// Token: 0x170004CF RID: 1231
	// (get) Token: 0x06000E2B RID: 3627 RVA: 0x00043218 File Offset: 0x00041418
	// (set) Token: 0x06000E2C RID: 3628 RVA: 0x0000A453 File Offset: 0x00008653
	public unsafe bool m_bRequestRefreshAvailableGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bRequestRefreshAvailableGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Network.NativeFieldInfoPtr_m_bRequestRefreshAvailableGames)) = value;
		}
	}

	// Token: 0x04000974 RID: 2420
	private static readonly IntPtr NativeFieldInfoPtr_k_maxGamePlayers;

	// Token: 0x04000975 RID: 2421
	private static readonly IntPtr NativeFieldInfoPtr_k_maxActiveGames;

	// Token: 0x04000976 RID: 2422
	private static readonly IntPtr NativeFieldInfoPtr_k_maxAvailableGames;

	// Token: 0x04000977 RID: 2423
	private static readonly IntPtr NativeFieldInfoPtr_k_maxFriendListSize;

	// Token: 0x04000978 RID: 2424
	private static readonly IntPtr NativeFieldInfoPtr_k_maxMatchmakingGames;

	// Token: 0x04000979 RID: 2425
	private static readonly IntPtr NativeFieldInfoPtr_m_Network;

	// Token: 0x0400097A RID: 2426
	private static readonly IntPtr NativeFieldInfoPtr_m_bPausedDuringNetworkSession;

	// Token: 0x0400097B RID: 2427
	private static readonly IntPtr NativeFieldInfoPtr_m_loginName;

	// Token: 0x0400097C RID: 2428
	private static readonly IntPtr NativeFieldInfoPtr_m_loginPassword;

	// Token: 0x0400097D RID: 2429
	private static readonly IntPtr NativeFieldInfoPtr_m_asmodeeAccessToken;

	// Token: 0x0400097E RID: 2430
	private static readonly IntPtr NativeFieldInfoPtr_m_NetworkEventListeners;

	// Token: 0x0400097F RID: 2431
	private static readonly IntPtr NativeFieldInfoPtr_m_LastNetworkStatus;

	// Token: 0x04000980 RID: 2432
	private static readonly IntPtr NativeFieldInfoPtr_m_bConnectedToServer;

	// Token: 0x04000981 RID: 2433
	private static readonly IntPtr NativeFieldInfoPtr_m_bLoggedInToServer;

	// Token: 0x04000982 RID: 2434
	private static readonly IntPtr NativeFieldInfoPtr_m_bServerConnectionLost;

	// Token: 0x04000983 RID: 2435
	private static readonly IntPtr NativeFieldInfoPtr_m_bServerDisconnected;

	// Token: 0x04000984 RID: 2436
	private static readonly IntPtr NativeFieldInfoPtr_m_bCreateAccount;

	// Token: 0x04000985 RID: 2437
	private static readonly IntPtr NativeFieldInfoPtr_networkEvents;

	// Token: 0x04000986 RID: 2438
	private static readonly IntPtr NativeFieldInfoPtr_m_bNewAvailableGames;

	// Token: 0x04000987 RID: 2439
	private static readonly IntPtr NativeFieldInfoPtr_m_bRequestRefreshAvailableGames;

	// Token: 0x04000988 RID: 2440
	private static readonly IntPtr NativeMethodInfoPtr_add_m_NetworkEventListeners_Private_add_Void_NetworkEventDelegate_0;

	// Token: 0x04000989 RID: 2441
	private static readonly IntPtr NativeMethodInfoPtr_remove_m_NetworkEventListeners_Private_rem_Void_NetworkEventDelegate_0;

	// Token: 0x0400098A RID: 2442
	private static readonly IntPtr NativeMethodInfoPtr_IsCreateAccount_Public_Static_Boolean_0;

	// Token: 0x0400098B RID: 2443
	private static readonly IntPtr NativeMethodInfoPtr_AddNetworkEventHandler_Public_Void_NetworkEventDelegate_0;

	// Token: 0x0400098C RID: 2444
	private static readonly IntPtr NativeMethodInfoPtr_RemoveNetworkEventHandler_Public_Void_NetworkEventDelegate_0;

	// Token: 0x0400098D RID: 2445
	private static readonly IntPtr NativeMethodInfoPtr_ClearNetworkEventHandlerList_Public_Void_0;

	// Token: 0x0400098E RID: 2446
	private static readonly IntPtr NativeMethodInfoPtr_RaiseNetworkEvent_Private_Void_EventType_Int32_0;

	// Token: 0x0400098F RID: 2447
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000990 RID: 2448
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000991 RID: 2449
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000992 RID: 2450
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Void_0;

	// Token: 0x04000993 RID: 2451
	private static readonly IntPtr NativeMethodInfoPtr_Login_Public_Static_Void_String_String_0;

	// Token: 0x04000994 RID: 2452
	private static readonly IntPtr NativeMethodInfoPtr_SetLogin_Public_Static_Void_String_String_0;

	// Token: 0x04000995 RID: 2453
	private static readonly IntPtr NativeMethodInfoPtr_RetryLogin_Public_Static_Void_0;

	// Token: 0x04000996 RID: 2454
	private static readonly IntPtr NativeMethodInfoPtr_CreateAccount_Public_Static_Void_String_String_String_0;

	// Token: 0x04000997 RID: 2455
	private static readonly IntPtr NativeMethodInfoPtr_SetCreateAccount_Public_Static_Void_String_String_String_0;

	// Token: 0x04000998 RID: 2456
	private static readonly IntPtr NativeMethodInfoPtr_Connect_Public_Static_Void_0;

	// Token: 0x04000999 RID: 2457
	private static readonly IntPtr NativeMethodInfoPtr_ConnectAsmodee_Public_Static_Void_0;

	// Token: 0x0400099A RID: 2458
	private static readonly IntPtr NativeMethodInfoPtr_Disconnect_Public_Static_Void_0;

	// Token: 0x0400099B RID: 2459
	private static readonly IntPtr NativeMethodInfoPtr_PrepareForReconnect_Public_Static_Void_0;

	// Token: 0x0400099C RID: 2460
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Static_Void_0;

	// Token: 0x0400099D RID: 2461
	private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

	// Token: 0x0400099E RID: 2462
	private static readonly IntPtr NativeMethodInfoPtr_GetActiveGameList_Public_Static_List_1_ShortSaveStruct_0;

	// Token: 0x0400099F RID: 2463
	private static readonly IntPtr NativeMethodInfoPtr_GetCompletedGameList_Public_Static_List_1_ShortSaveStruct_0;

	// Token: 0x040009A0 RID: 2464
	private static readonly IntPtr NativeMethodInfoPtr_GetGamePlayerTimers_Public_Static_List_1_GamePlayerTimer_UInt32_0;

	// Token: 0x040009A1 RID: 2465
	private static readonly IntPtr NativeMethodInfoPtr_NewAvailableGames_Public_Static_Boolean_0;

	// Token: 0x040009A2 RID: 2466
	private static readonly IntPtr NativeMethodInfoPtr_RefreshAvailableGames_Public_Static_Void_0;

	// Token: 0x040009A3 RID: 2467
	private static readonly IntPtr NativeMethodInfoPtr_GetAvailableGameList_Public_Static_List_1_ShortSaveStruct_UInt32_UInt32_0;

	// Token: 0x040009A4 RID: 2468
	private static readonly IntPtr NativeMethodInfoPtr_CreateGame_Public_Static_Void_UInt32_Il2CppStructArray_1_UInt32_UInt32_GameParameters_0;

	// Token: 0x040009A5 RID: 2469
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendsList_Public_Static_List_1_FriendInfo_0;

	// Token: 0x040009A6 RID: 2470
	private static readonly IntPtr NativeMethodInfoPtr_GetUserOnlineStatus_Public_Static_Int32_UInt32_0;

	// Token: 0x040009A7 RID: 2471
	private static readonly IntPtr NativeMethodInfoPtr_RequestUsersOnlineStatus_Public_Static_Void_IntPtr_Int32_0;

	// Token: 0x040009A8 RID: 2472
	private static readonly IntPtr NativeMethodInfoPtr_SetMonitorGame_Public_Static_Void_UInt32_0;

	// Token: 0x040009A9 RID: 2473
	private static readonly IntPtr NativeMethodInfoPtr_ClearMonitorGame_Public_Static_Void_0;

	// Token: 0x040009AA RID: 2474
	private static readonly IntPtr NativeMethodInfoPtr_AddFriendFromUsername_Public_Static_Int32_String_0;

	// Token: 0x040009AB RID: 2475
	private static readonly IntPtr NativeMethodInfoPtr_AddFriendFromEmail_Public_Static_Int32_String_0;

	// Token: 0x040009AC RID: 2476
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFriendWithUserId_Public_Static_Boolean_UInt32_0;

	// Token: 0x040009AD RID: 2477
	private static readonly IntPtr NativeMethodInfoPtr_RequestNetworkPlayerProfile_Public_Static_Void_UInt32_0;

	// Token: 0x040009AE RID: 2478
	private static readonly IntPtr NativeMethodInfoPtr_NetworkGetLocalID_Public_Static_UInt32_0;

	// Token: 0x040009AF RID: 2479
	private static readonly IntPtr NativeMethodInfoPtr_GetRemotePlayerProfileInfo_Public_Static_Void_Int32_byref_NetworkPlayerProfileInfo_0;

	// Token: 0x040009B0 RID: 2480
	private static readonly IntPtr NativeMethodInfoPtr_GetLocalPlayerProfileInfo_Public_Static_Void_byref_NetworkPlayerProfileInfo_0;

	// Token: 0x040009B1 RID: 2481
	private static readonly IntPtr NativeMethodInfoPtr_SendLocalAvatarIndex_Public_Static_Void_UInt32_0;

	// Token: 0x040009B2 RID: 2482
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000187 RID: 391
	[Serializable]
	public sealed class NetworkEventDelegate : MulticastDelegate
	{
		// Token: 0x060023FF RID: 9215 RVA: 0x000863F4 File Offset: 0x000845F4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkEventDelegate()
		{
			Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Network>.NativeClassPtr, "NetworkEventDelegate");
			Network.NetworkEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr, 100666156);
			Network.NetworkEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr, 100666157);
			Network.NetworkEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventType_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr, 100666158);
			Network.NetworkEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr, 100666159);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x00086468 File Offset: 0x00084668
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkEventDelegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Network.NetworkEventDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NetworkEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002401 RID: 9217 RVA: 0x000864C4 File Offset: 0x000846C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 237075, RefRangeEnd = 237079, XrefRangeStart = 237075, XrefRangeEnd = 237079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(NetworkEvent.EventType eventType, int eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NetworkEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00086510 File Offset: 0x00084710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238251, XrefRangeEnd = 238258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(NetworkEvent.EventType eventType, int eventData, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref eventType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventData;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NetworkEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventType_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00086590 File Offset: 0x00084790
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Network.NetworkEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0001670C File Offset: 0x0001490C
		public NetworkEventDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00016715 File Offset: 0x00014915
		public static implicit operator Network.NetworkEventDelegate(Action<NetworkEvent.EventType, int> A_0)
		{
			return DelegateSupport.ConvertDelegate<Network.NetworkEventDelegate>(A_0);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0001671D File Offset: 0x0001491D
		public static Network.NetworkEventDelegate operator +(Network.NetworkEventDelegate A_0, Network.NetworkEventDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Network.NetworkEventDelegate>();
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0001672B File Offset: 0x0001492B
		public static Network.NetworkEventDelegate operator -(Network.NetworkEventDelegate A_0, Network.NetworkEventDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Network.NetworkEventDelegate>();
			}
			return delegate2;
		}

		// Token: 0x040018FE RID: 6398
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040018FF RID: 6399
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_EventType_Int32_0;

		// Token: 0x04001900 RID: 6400
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_EventType_Int32_AsyncCallback_Object_0;

		// Token: 0x04001901 RID: 6401
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
