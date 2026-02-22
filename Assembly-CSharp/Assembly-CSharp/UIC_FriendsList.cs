using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Token: 0x020000B0 RID: 176
[Serializable]
public class UIC_FriendsList : global::Il2CppSystem.Object
{
	// Token: 0x06001480 RID: 5248 RVA: 0x000582DC File Offset: 0x000564DC
	// Note: this type is marked as 'beforefieldinit'.
	static UIC_FriendsList()
	{
		Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIC_FriendsList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr);
		UIC_FriendsList.NativeFieldInfoPtr_m_friendSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_friendSlotPrefab");
		UIC_FriendsList.NativeFieldInfoPtr_m_friendListBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_friendListBase");
		UIC_FriendsList.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_contentContainer");
		UIC_FriendsList.NativeFieldInfoPtr_m_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_scrollView");
		UIC_FriendsList.NativeFieldInfoPtr_m_allowDragDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_allowDragDrop");
		UIC_FriendsList.NativeFieldInfoPtr_m_isChatPlayerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_isChatPlayerList");
		UIC_FriendsList.NativeFieldInfoPtr_m_dragCanvasOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_dragCanvasOverride");
		UIC_FriendsList.NativeFieldInfoPtr_m_OnBeginDragEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_OnBeginDragEvent");
		UIC_FriendsList.NativeFieldInfoPtr_m_OnEndDragEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_OnEndDragEvent");
		UIC_FriendsList.NativeFieldInfoPtr_m_bWasDragSuccessful = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_bWasDragSuccessful");
		UIC_FriendsList.NativeFieldInfoPtr_m_maxOnlineStatusRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_maxOnlineStatusRequest");
		UIC_FriendsList.NativeFieldInfoPtr_m_selectedIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_selectedIndex");
		UIC_FriendsList.NativeFieldInfoPtr_m_offlineProfileManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_offlineProfileManager");
		UIC_FriendsList.NativeFieldInfoPtr_m_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_network");
		UIC_FriendsList.NativeFieldInfoPtr_m_clickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_clickCallback");
		UIC_FriendsList.NativeFieldInfoPtr_m_monoBehaviourInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_monoBehaviourInstance");
		UIC_FriendsList.NativeFieldInfoPtr_m_friendSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_friendSlots");
		UIC_FriendsList.NativeFieldInfoPtr_m_requestOnlineStatusArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_requestOnlineStatusArray");
		UIC_FriendsList.NativeFieldInfoPtr_m_hUserDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_hUserDataBuffer");
		UIC_FriendsList.NativeFieldInfoPtr_m_scrollRectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_scrollRectCoroutine");
		UIC_FriendsList.NativeFieldInfoPtr_m_scrollChangeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_scrollChangeCounter");
		UIC_FriendsList.NativeFieldInfoPtr_m_maxSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_maxSelected");
		UIC_FriendsList.NativeFieldInfoPtr_m_bCheckingForEndScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "m_bCheckingForEndScroll");
		UIC_FriendsList.NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664942);
		UIC_FriendsList.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664943);
		UIC_FriendsList.NativeMethodInfoPtr_GetSlotSelected_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664944);
		UIC_FriendsList.NativeMethodInfoPtr_SetMaxSelected_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664945);
		UIC_FriendsList.NativeMethodInfoPtr_UnhideAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664946);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByDisplayName_Public_UIP_Profile_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664947);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByNameAndAvatar_Public_UIP_Profile_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664948);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByUserID_Public_UIP_Profile_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664949);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByIndex_Public_UIP_Profile_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664950);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664951);
		UIC_FriendsList.NativeMethodInfoPtr_SetAllInteractable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664952);
		UIC_FriendsList.NativeMethodInfoPtr_Remove_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664953);
		UIC_FriendsList.NativeMethodInfoPtr_ClearSelected_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664954);
		UIC_FriendsList.NativeMethodInfoPtr_SetSelectedSlot_Public_Void_UIP_Profile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664955);
		UIC_FriendsList.NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664956);
		UIC_FriendsList.NativeMethodInfoPtr_GetIsSelected_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664957);
		UIC_FriendsList.NativeMethodInfoPtr_ToggleSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664958);
		UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnBeginDrag_Private_Void_UI_DragSource_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664959);
		UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnDragging_Private_Void_UI_DragSource_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664960);
		UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnEndDrag_Private_Void_UI_DragSource_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664961);
		UIC_FriendsList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664962);
		UIC_FriendsList.NativeMethodInfoPtr_RebuildOfflineList_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664963);
		UIC_FriendsList.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664964);
		UIC_FriendsList.NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664965);
		UIC_FriendsList.NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664966);
		UIC_FriendsList.NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664967);
		UIC_FriendsList.NativeMethodInfoPtr_RefreshOnlineStatus_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664968);
		UIC_FriendsList.NativeMethodInfoPtr_ClearFriendList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664969);
		UIC_FriendsList.NativeMethodInfoPtr_BuildFriendList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664970);
		UIC_FriendsList.NativeMethodInfoPtr_GetFriendsListItemIndex_Private_Int32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664971);
		UIC_FriendsList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, 100664972);
	}

	// Token: 0x06001481 RID: 5249 RVA: 0x00058744 File Offset: 0x00056944
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 245961, RefRangeEnd = 245965, XrefRangeStart = 245921, XrefRangeEnd = 245961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(Network network, UIC_FriendsList.ClickCallback cb, MonoBehaviour monoBehaviourInstance)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(network);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cb);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(monoBehaviourInstance);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001482 RID: 5250 RVA: 0x000587AC File Offset: 0x000569AC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 245978, RefRangeEnd = 245982, XrefRangeStart = 245965, XrefRangeEnd = 245978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001483 RID: 5251 RVA: 0x000587E0 File Offset: 0x000569E0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetSlotSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetSlotSelected_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06001484 RID: 5252 RVA: 0x0005881C File Offset: 0x00056A1C
	[CallerCount(0)]
	public unsafe void SetMaxSelected(uint maxSelected)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref maxSelected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_SetMaxSelected_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001485 RID: 5253 RVA: 0x0005885C File Offset: 0x00056A5C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 245988, RefRangeEnd = 245989, XrefRangeStart = 245982, XrefRangeEnd = 245988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnhideAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_UnhideAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001486 RID: 5254 RVA: 0x00058890 File Offset: 0x00056A90
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246001, RefRangeEnd = 246002, XrefRangeStart = 245989, XrefRangeEnd = 246001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_Profile GetFriendSlotByDisplayName(string displayName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByDisplayName_Public_UIP_Profile_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_Profile>(intPtr3) : null;
		}
	}

	// Token: 0x06001487 RID: 5255 RVA: 0x000588E0 File Offset: 0x00056AE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246002, XrefRangeEnd = 246018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_Profile GetFriendSlotByNameAndAvatar(string displayName, int avatarIndex)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(displayName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref avatarIndex;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByNameAndAvatar_Public_UIP_Profile_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_Profile>(intPtr3) : null;
	}

	// Token: 0x06001488 RID: 5256 RVA: 0x00058940 File Offset: 0x00056B40
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246022, RefRangeEnd = 246025, XrefRangeStart = 246018, XrefRangeEnd = 246022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_Profile GetFriendSlotByUserID(uint userID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByUserID_Public_UIP_Profile_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_Profile>(intPtr3) : null;
		}
	}

	// Token: 0x06001489 RID: 5257 RVA: 0x0005898C File Offset: 0x00056B8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246027, RefRangeEnd = 246028, XrefRangeStart = 246025, XrefRangeEnd = 246027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIP_Profile GetFriendSlotByIndex(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendSlotByIndex_Public_UIP_Profile_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIP_Profile>(intPtr3) : null;
		}
	}

	// Token: 0x0600148A RID: 5258 RVA: 0x000589D8 File Offset: 0x00056BD8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246029, RefRangeEnd = 246030, XrefRangeStart = 246028, XrefRangeEnd = 246029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFriendCount()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600148B RID: 5259 RVA: 0x00058A14 File Offset: 0x00056C14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246030, XrefRangeEnd = 246039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAllInteractable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_SetAllInteractable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600148C RID: 5260 RVA: 0x00058A48 File Offset: 0x00056C48
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246052, RefRangeEnd = 246053, XrefRangeStart = 246039, XrefRangeEnd = 246052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Remove(uint friendUserID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref friendUserID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_Remove_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600148D RID: 5261 RVA: 0x00058A88 File Offset: 0x00056C88
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246058, RefRangeEnd = 246060, XrefRangeStart = 246053, XrefRangeEnd = 246058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_ClearSelected_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600148E RID: 5262 RVA: 0x00058ABC File Offset: 0x00056CBC
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 246068, RefRangeEnd = 246073, XrefRangeStart = 246060, XrefRangeEnd = 246068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelectedSlot(UIP_Profile slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_SetSelectedSlot_Public_Void_UIP_Profile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600148F RID: 5263 RVA: 0x00058B00 File Offset: 0x00056D00
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246078, RefRangeEnd = 246081, XrefRangeStart = 246073, XrefRangeEnd = 246078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetSelected(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001490 RID: 5264 RVA: 0x00058B40 File Offset: 0x00056D40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246081, XrefRangeEnd = 246085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetIsSelected(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetIsSelected_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06001491 RID: 5265 RVA: 0x00058B8C File Offset: 0x00056D8C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246096, RefRangeEnd = 246097, XrefRangeStart = 246085, XrefRangeEnd = 246096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ToggleSelected(int index)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_ToggleSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001492 RID: 5266 RVA: 0x00058BCC File Offset: 0x00056DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246097, XrefRangeEnd = 246104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSlotOnBeginDrag(UI_DragSource e, PointerEventData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnBeginDrag_Private_Void_UI_DragSource_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001493 RID: 5267 RVA: 0x00058C20 File Offset: 0x00056E20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246104, XrefRangeEnd = 246108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSlotOnDragging(UI_DragSource e, PointerEventData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnDragging_Private_Void_UI_DragSource_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001494 RID: 5268 RVA: 0x00058C74 File Offset: 0x00056E74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246108, XrefRangeEnd = 246119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleSlotOnEndDrag(UI_DragSource e, PointerEventData a)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(a);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_HandleSlotOnEndDrag_Private_Void_UI_DragSource_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001495 RID: 5269 RVA: 0x00058CC8 File Offset: 0x00056EC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246119, XrefRangeEnd = 246120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_Profile slot, UIP_Profile.ClickEventType evt)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001496 RID: 5270 RVA: 0x00058D18 File Offset: 0x00056F18
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 246175, RefRangeEnd = 246180, XrefRangeStart = 246120, XrefRangeEnd = 246175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildOfflineList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_RebuildOfflineList_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001497 RID: 5271 RVA: 0x00058D4C File Offset: 0x00056F4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246180, XrefRangeEnd = 246189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void NetworkEventCallback(NetworkEvent.EventType eventType, int eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001498 RID: 5272 RVA: 0x00058D98 File Offset: 0x00056F98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246189, XrefRangeEnd = 246193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckForEndScroll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001499 RID: 5273 RVA: 0x00058DD8 File Offset: 0x00056FD8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246199, RefRangeEnd = 246200, XrefRangeStart = 246193, XrefRangeEnd = 246199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginCheckingForOnlineStatusRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149A RID: 5274 RVA: 0x00058E0C File Offset: 0x0005700C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246200, XrefRangeEnd = 246201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollRectChanged(Vector2 data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600149B RID: 5275 RVA: 0x00058E4C File Offset: 0x0005704C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246224, RefRangeEnd = 246225, XrefRangeStart = 246201, XrefRangeEnd = 246224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshOnlineStatus()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_RefreshOnlineStatus_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149C RID: 5276 RVA: 0x00058E80 File Offset: 0x00057080
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246237, RefRangeEnd = 246240, XrefRangeStart = 246225, XrefRangeEnd = 246237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearFriendList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_ClearFriendList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149D RID: 5277 RVA: 0x00058EB4 File Offset: 0x000570B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246240, XrefRangeEnd = 246318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BuildFriendList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_BuildFriendList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600149E RID: 5278 RVA: 0x00058EE8 File Offset: 0x000570E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246318, XrefRangeEnd = 246322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetFriendsListItemIndex(uint userID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref userID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr_GetFriendsListItemIndex_Private_Int32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600149F RID: 5279 RVA: 0x00058F34 File Offset: 0x00057134
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246322, XrefRangeEnd = 246330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIC_FriendsList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014A0 RID: 5280 RVA: 0x0000D51E File Offset: 0x0000B71E
	public UIC_FriendsList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700067C RID: 1660
	// (get) Token: 0x060014A1 RID: 5281 RVA: 0x00058F70 File Offset: 0x00057170
	// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000D527 File Offset: 0x0000B727
	public unsafe GameObject m_friendSlotPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendSlotPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067D RID: 1661
	// (get) Token: 0x060014A3 RID: 5283 RVA: 0x00058FA0 File Offset: 0x000571A0
	// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0000D546 File Offset: 0x0000B746
	public unsafe GameObject m_friendListBase
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendListBase);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendListBase), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067E RID: 1662
	// (get) Token: 0x060014A5 RID: 5285 RVA: 0x00058FD0 File Offset: 0x000571D0
	// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0000D565 File Offset: 0x0000B765
	public unsafe Transform m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700067F RID: 1663
	// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00059000 File Offset: 0x00057200
	// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0000D584 File Offset: 0x0000B784
	public unsafe ScrollRect m_scrollView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000680 RID: 1664
	// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00059030 File Offset: 0x00057230
	// (set) Token: 0x060014AA RID: 5290 RVA: 0x0000D5A3 File Offset: 0x0000B7A3
	public unsafe bool m_allowDragDrop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_allowDragDrop);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_allowDragDrop)) = value;
		}
	}

	// Token: 0x17000681 RID: 1665
	// (get) Token: 0x060014AB RID: 5291 RVA: 0x00059058 File Offset: 0x00057258
	// (set) Token: 0x060014AC RID: 5292 RVA: 0x0000D5BE File Offset: 0x0000B7BE
	public unsafe bool m_isChatPlayerList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_isChatPlayerList);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_isChatPlayerList)) = value;
		}
	}

	// Token: 0x17000682 RID: 1666
	// (get) Token: 0x060014AD RID: 5293 RVA: 0x00059080 File Offset: 0x00057280
	// (set) Token: 0x060014AE RID: 5294 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
	public unsafe Canvas m_dragCanvasOverride
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_dragCanvasOverride);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_dragCanvasOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000683 RID: 1667
	// (get) Token: 0x060014AF RID: 5295 RVA: 0x000590B0 File Offset: 0x000572B0
	// (set) Token: 0x060014B0 RID: 5296 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
	public unsafe UIC_FriendsList.OnDragEvent m_OnBeginDragEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_OnBeginDragEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList.OnDragEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_OnBeginDragEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000684 RID: 1668
	// (get) Token: 0x060014B1 RID: 5297 RVA: 0x000590E0 File Offset: 0x000572E0
	// (set) Token: 0x060014B2 RID: 5298 RVA: 0x0000D617 File Offset: 0x0000B817
	public unsafe UIC_FriendsList.OnDragEvent m_OnEndDragEvent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_OnEndDragEvent);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList.OnDragEvent>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_OnEndDragEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000685 RID: 1669
	// (get) Token: 0x060014B3 RID: 5299 RVA: 0x00059110 File Offset: 0x00057310
	// (set) Token: 0x060014B4 RID: 5300 RVA: 0x0000D636 File Offset: 0x0000B836
	public unsafe bool m_bWasDragSuccessful
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_bWasDragSuccessful);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_bWasDragSuccessful)) = value;
		}
	}

	// Token: 0x17000686 RID: 1670
	// (get) Token: 0x060014B5 RID: 5301 RVA: 0x00059138 File Offset: 0x00057338
	// (set) Token: 0x060014B6 RID: 5302 RVA: 0x0000D651 File Offset: 0x0000B851
	public unsafe static int m_maxOnlineStatusRequest
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(UIC_FriendsList.NativeFieldInfoPtr_m_maxOnlineStatusRequest, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIC_FriendsList.NativeFieldInfoPtr_m_maxOnlineStatusRequest, (void*)(&value));
		}
	}

	// Token: 0x17000687 RID: 1671
	// (get) Token: 0x060014B7 RID: 5303 RVA: 0x00059154 File Offset: 0x00057354
	// (set) Token: 0x060014B8 RID: 5304 RVA: 0x0000D65F File Offset: 0x0000B85F
	public unsafe int m_selectedIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_selectedIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_selectedIndex)) = value;
		}
	}

	// Token: 0x17000688 RID: 1672
	// (get) Token: 0x060014B9 RID: 5305 RVA: 0x0005917C File Offset: 0x0005737C
	// (set) Token: 0x060014BA RID: 5306 RVA: 0x0000D67A File Offset: 0x0000B87A
	public unsafe ProfileManager m_offlineProfileManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_offlineProfileManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_offlineProfileManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000689 RID: 1673
	// (get) Token: 0x060014BB RID: 5307 RVA: 0x000591AC File Offset: 0x000573AC
	// (set) Token: 0x060014BC RID: 5308 RVA: 0x0000D699 File Offset: 0x0000B899
	public unsafe Network m_network
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_network);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Network>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_network), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068A RID: 1674
	// (get) Token: 0x060014BD RID: 5309 RVA: 0x000591DC File Offset: 0x000573DC
	// (set) Token: 0x060014BE RID: 5310 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
	public unsafe UIC_FriendsList.ClickCallback m_clickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_clickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_clickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068B RID: 1675
	// (get) Token: 0x060014BF RID: 5311 RVA: 0x0005920C File Offset: 0x0005740C
	// (set) Token: 0x060014C0 RID: 5312 RVA: 0x0000D6D7 File Offset: 0x0000B8D7
	public unsafe MonoBehaviour m_monoBehaviourInstance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_monoBehaviourInstance);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_monoBehaviourInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x060014C1 RID: 5313 RVA: 0x0005923C File Offset: 0x0005743C
	// (set) Token: 0x060014C2 RID: 5314 RVA: 0x0000D6F6 File Offset: 0x0000B8F6
	public unsafe List<UIP_Profile> m_friendSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIP_Profile>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_friendSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0005926C File Offset: 0x0005746C
	// (set) Token: 0x060014C4 RID: 5316 RVA: 0x0000D715 File Offset: 0x0000B915
	public unsafe Il2CppStructArray<uint> m_requestOnlineStatusArray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_requestOnlineStatusArray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_requestOnlineStatusArray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x060014C5 RID: 5317 RVA: 0x0005929C File Offset: 0x0005749C
	// (set) Token: 0x060014C6 RID: 5318 RVA: 0x0000D734 File Offset: 0x0000B934
	public unsafe GCHandle m_hUserDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_hUserDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_hUserDataBuffer)) = value;
		}
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x060014C7 RID: 5319 RVA: 0x000592C4 File Offset: 0x000574C4
	// (set) Token: 0x060014C8 RID: 5320 RVA: 0x0000D74F File Offset: 0x0000B94F
	public unsafe Coroutine m_scrollRectCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollRectCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollRectCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x060014C9 RID: 5321 RVA: 0x000592F4 File Offset: 0x000574F4
	// (set) Token: 0x060014CA RID: 5322 RVA: 0x0000D76E File Offset: 0x0000B96E
	public unsafe uint m_scrollChangeCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollChangeCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_scrollChangeCounter)) = value;
		}
	}

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x060014CB RID: 5323 RVA: 0x0005931C File Offset: 0x0005751C
	// (set) Token: 0x060014CC RID: 5324 RVA: 0x0000D789 File Offset: 0x0000B989
	public unsafe uint m_maxSelected
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_maxSelected);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_maxSelected)) = value;
		}
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x060014CD RID: 5325 RVA: 0x00059344 File Offset: 0x00057544
	// (set) Token: 0x060014CE RID: 5326 RVA: 0x0000D7A4 File Offset: 0x0000B9A4
	public unsafe bool m_bCheckingForEndScroll
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_bCheckingForEndScroll);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList.NativeFieldInfoPtr_m_bCheckingForEndScroll)) = value;
		}
	}

	// Token: 0x04000E44 RID: 3652
	private static readonly IntPtr NativeFieldInfoPtr_m_friendSlotPrefab;

	// Token: 0x04000E45 RID: 3653
	private static readonly IntPtr NativeFieldInfoPtr_m_friendListBase;

	// Token: 0x04000E46 RID: 3654
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x04000E47 RID: 3655
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollView;

	// Token: 0x04000E48 RID: 3656
	private static readonly IntPtr NativeFieldInfoPtr_m_allowDragDrop;

	// Token: 0x04000E49 RID: 3657
	private static readonly IntPtr NativeFieldInfoPtr_m_isChatPlayerList;

	// Token: 0x04000E4A RID: 3658
	private static readonly IntPtr NativeFieldInfoPtr_m_dragCanvasOverride;

	// Token: 0x04000E4B RID: 3659
	private static readonly IntPtr NativeFieldInfoPtr_m_OnBeginDragEvent;

	// Token: 0x04000E4C RID: 3660
	private static readonly IntPtr NativeFieldInfoPtr_m_OnEndDragEvent;

	// Token: 0x04000E4D RID: 3661
	private static readonly IntPtr NativeFieldInfoPtr_m_bWasDragSuccessful;

	// Token: 0x04000E4E RID: 3662
	private static readonly IntPtr NativeFieldInfoPtr_m_maxOnlineStatusRequest;

	// Token: 0x04000E4F RID: 3663
	private static readonly IntPtr NativeFieldInfoPtr_m_selectedIndex;

	// Token: 0x04000E50 RID: 3664
	private static readonly IntPtr NativeFieldInfoPtr_m_offlineProfileManager;

	// Token: 0x04000E51 RID: 3665
	private static readonly IntPtr NativeFieldInfoPtr_m_network;

	// Token: 0x04000E52 RID: 3666
	private static readonly IntPtr NativeFieldInfoPtr_m_clickCallback;

	// Token: 0x04000E53 RID: 3667
	private static readonly IntPtr NativeFieldInfoPtr_m_monoBehaviourInstance;

	// Token: 0x04000E54 RID: 3668
	private static readonly IntPtr NativeFieldInfoPtr_m_friendSlots;

	// Token: 0x04000E55 RID: 3669
	private static readonly IntPtr NativeFieldInfoPtr_m_requestOnlineStatusArray;

	// Token: 0x04000E56 RID: 3670
	private static readonly IntPtr NativeFieldInfoPtr_m_hUserDataBuffer;

	// Token: 0x04000E57 RID: 3671
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRectCoroutine;

	// Token: 0x04000E58 RID: 3672
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollChangeCounter;

	// Token: 0x04000E59 RID: 3673
	private static readonly IntPtr NativeFieldInfoPtr_m_maxSelected;

	// Token: 0x04000E5A RID: 3674
	private static readonly IntPtr NativeFieldInfoPtr_m_bCheckingForEndScroll;

	// Token: 0x04000E5B RID: 3675
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0;

	// Token: 0x04000E5C RID: 3676
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

	// Token: 0x04000E5D RID: 3677
	private static readonly IntPtr NativeMethodInfoPtr_GetSlotSelected_Public_Int32_0;

	// Token: 0x04000E5E RID: 3678
	private static readonly IntPtr NativeMethodInfoPtr_SetMaxSelected_Public_Void_UInt32_0;

	// Token: 0x04000E5F RID: 3679
	private static readonly IntPtr NativeMethodInfoPtr_UnhideAll_Public_Void_0;

	// Token: 0x04000E60 RID: 3680
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendSlotByDisplayName_Public_UIP_Profile_String_0;

	// Token: 0x04000E61 RID: 3681
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendSlotByNameAndAvatar_Public_UIP_Profile_String_Int32_0;

	// Token: 0x04000E62 RID: 3682
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendSlotByUserID_Public_UIP_Profile_UInt32_0;

	// Token: 0x04000E63 RID: 3683
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendSlotByIndex_Public_UIP_Profile_Int32_0;

	// Token: 0x04000E64 RID: 3684
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendCount_Public_Int32_0;

	// Token: 0x04000E65 RID: 3685
	private static readonly IntPtr NativeMethodInfoPtr_SetAllInteractable_Public_Void_0;

	// Token: 0x04000E66 RID: 3686
	private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_UInt32_0;

	// Token: 0x04000E67 RID: 3687
	private static readonly IntPtr NativeMethodInfoPtr_ClearSelected_Public_Void_0;

	// Token: 0x04000E68 RID: 3688
	private static readonly IntPtr NativeMethodInfoPtr_SetSelectedSlot_Public_Void_UIP_Profile_0;

	// Token: 0x04000E69 RID: 3689
	private static readonly IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_Int32_0;

	// Token: 0x04000E6A RID: 3690
	private static readonly IntPtr NativeMethodInfoPtr_GetIsSelected_Public_Boolean_Int32_0;

	// Token: 0x04000E6B RID: 3691
	private static readonly IntPtr NativeMethodInfoPtr_ToggleSelected_Public_Void_Int32_0;

	// Token: 0x04000E6C RID: 3692
	private static readonly IntPtr NativeMethodInfoPtr_HandleSlotOnBeginDrag_Private_Void_UI_DragSource_PointerEventData_0;

	// Token: 0x04000E6D RID: 3693
	private static readonly IntPtr NativeMethodInfoPtr_HandleSlotOnDragging_Private_Void_UI_DragSource_PointerEventData_0;

	// Token: 0x04000E6E RID: 3694
	private static readonly IntPtr NativeMethodInfoPtr_HandleSlotOnEndDrag_Private_Void_UI_DragSource_PointerEventData_0;

	// Token: 0x04000E6F RID: 3695
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_Profile_ClickEventType_0;

	// Token: 0x04000E70 RID: 3696
	private static readonly IntPtr NativeMethodInfoPtr_RebuildOfflineList_Public_Void_0;

	// Token: 0x04000E71 RID: 3697
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0;

	// Token: 0x04000E72 RID: 3698
	private static readonly IntPtr NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0;

	// Token: 0x04000E73 RID: 3699
	private static readonly IntPtr NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0;

	// Token: 0x04000E74 RID: 3700
	private static readonly IntPtr NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0;

	// Token: 0x04000E75 RID: 3701
	private static readonly IntPtr NativeMethodInfoPtr_RefreshOnlineStatus_Public_Void_0;

	// Token: 0x04000E76 RID: 3702
	private static readonly IntPtr NativeMethodInfoPtr_ClearFriendList_Private_Void_0;

	// Token: 0x04000E77 RID: 3703
	private static readonly IntPtr NativeMethodInfoPtr_BuildFriendList_Private_Void_0;

	// Token: 0x04000E78 RID: 3704
	private static readonly IntPtr NativeMethodInfoPtr_GetFriendsListItemIndex_Private_Int32_UInt32_0;

	// Token: 0x04000E79 RID: 3705
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001BC RID: 444
	[Serializable]
	public class OnDragEvent : UnityEvent<UI_DragSource>
	{
		// Token: 0x060025E7 RID: 9703 RVA: 0x00017811 File Offset: 0x00015A11
		// Note: this type is marked as 'beforefieldinit'.
		static OnDragEvent()
		{
			Il2CppClassPointerStore<UIC_FriendsList.OnDragEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "OnDragEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_FriendsList.OnDragEvent>.NativeClassPtr);
			UIC_FriendsList.OnDragEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.OnDragEvent>.NativeClassPtr, 100666290);
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x0008B7D4 File Offset: 0x000899D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 245900, RefRangeEnd = 245902, XrefRangeStart = 245897, XrefRangeEnd = 245900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OnDragEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList.OnDragEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.OnDragEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x00017845 File Offset: 0x00015A45
		public OnDragEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A2A RID: 6698
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}

	// Token: 0x020001BD RID: 445
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x060025EA RID: 9706 RVA: 0x0008B810 File Offset: 0x00089A10
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "ClickCallback");
			UIC_FriendsList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr, 100666291);
			UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr, 100666292);
			UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr, 100666293);
			UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr, 100666294);
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x0008B884 File Offset: 0x00089A84
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x0008B8E0 File Offset: 0x00089AE0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_Profile slot, UIP_Profile.ClickEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x0008B930 File Offset: 0x00089B30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245902, XrefRangeEnd = 245906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_Profile slot, UIP_Profile.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x0008B9B4 File Offset: 0x00089BB4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x0001784E File Offset: 0x00015A4E
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00017857 File Offset: 0x00015A57
		public static implicit operator UIC_FriendsList.ClickCallback(Action<UIP_Profile, UIP_Profile.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIC_FriendsList.ClickCallback>(A_0);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x0001785F File Offset: 0x00015A5F
		public static UIC_FriendsList.ClickCallback operator +(UIC_FriendsList.ClickCallback A_0, UIC_FriendsList.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIC_FriendsList.ClickCallback>();
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0001786D File Offset: 0x00015A6D
		public static UIC_FriendsList.ClickCallback operator -(UIC_FriendsList.ClickCallback A_0, UIC_FriendsList.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIC_FriendsList.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001A2B RID: 6699
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A2C RID: 6700
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0;

		// Token: 0x04001A2D RID: 6701
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001A2E RID: 6702
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001BE RID: 446
	public sealed class DragCallback : MulticastDelegate
	{
		// Token: 0x060025F3 RID: 9715 RVA: 0x0008B9F8 File Offset: 0x00089BF8
		// Note: this type is marked as 'beforefieldinit'.
		static DragCallback()
		{
			Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "DragCallback");
			UIC_FriendsList.DragCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr, 100666295);
			UIC_FriendsList.DragCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr, 100666296);
			UIC_FriendsList.DragCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr, 100666297);
			UIC_FriendsList.DragCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr, 100666298);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0008BA6C File Offset: 0x00089C6C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DragCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList.DragCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.DragCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x0008BAC8 File Offset: 0x00089CC8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_Profile slot, UIP_Profile.ClickEventType evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.DragCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025F6 RID: 9718 RVA: 0x0008BB18 File Offset: 0x00089D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245906, XrefRangeEnd = 245910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_Profile slot, UIP_Profile.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.DragCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x0008BB9C File Offset: 0x00089D9C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.DragCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0001787E File Offset: 0x00015A7E
		public DragCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00017887 File Offset: 0x00015A87
		public static implicit operator UIC_FriendsList.DragCallback(Action<UIP_Profile, UIP_Profile.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIC_FriendsList.DragCallback>(A_0);
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0001788F File Offset: 0x00015A8F
		public static UIC_FriendsList.DragCallback operator +(UIC_FriendsList.DragCallback A_0, UIC_FriendsList.DragCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIC_FriendsList.DragCallback>();
		}

		// Token: 0x060025FB RID: 9723 RVA: 0x0001789D File Offset: 0x00015A9D
		public static UIC_FriendsList.DragCallback operator -(UIC_FriendsList.DragCallback A_0, UIC_FriendsList.DragCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIC_FriendsList.DragCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001A2F RID: 6703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_Profile_ClickEventType_0;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_Profile_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001BF RID: 447
	[ObfuscatedName("UIC_FriendsList+<CheckForEndScroll>d__49")]
	public sealed class _CheckForEndScroll_d__49 : global::Il2CppSystem.Object
	{
		// Token: 0x060025FC RID: 9724 RVA: 0x0008BBE0 File Offset: 0x00089DE0
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckForEndScroll_d__49()
		{
			Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "<CheckForEndScroll>d__49");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, "<>1__state");
			UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, "<>2__current");
			UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, "<>4__this");
			UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__lastChangeValue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, "<lastChangeValue>5__2");
			UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__sameCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, "<sameCount>5__3");
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666299);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666300);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666301);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666302);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666303);
			UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr, 100666304);
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x0008BCE8 File Offset: 0x00089EE8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckForEndScroll_d__49(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList._CheckForEndScroll_d__49>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x0008BD30 File Offset: 0x00089F30
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060025FF RID: 9727 RVA: 0x0008BD64 File Offset: 0x00089F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245910, XrefRangeEnd = 245916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x0008BDA0 File Offset: 0x00089FA0
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002601 RID: 9729 RVA: 0x0008BDE0 File Offset: 0x00089FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 245916, XrefRangeEnd = 245921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x0008BE14 File Offset: 0x0008A014
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList._CheckForEndScroll_d__49.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x000178AE File Offset: 0x00015AAE
		public _CheckForEndScroll_d__49(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x0008BE54 File Offset: 0x0008A054
		// (set) Token: 0x06002605 RID: 9733 RVA: 0x000178B7 File Offset: 0x00015AB7
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x0008BE7C File Offset: 0x0008A07C
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000178D2 File Offset: 0x00015AD2
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x0008BEAC File Offset: 0x0008A0AC
		// (set) Token: 0x06002609 RID: 9737 RVA: 0x000178F1 File Offset: 0x00015AF1
		public unsafe UIC_FriendsList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x0008BEDC File Offset: 0x0008A0DC
		// (set) Token: 0x0600260B RID: 9739 RVA: 0x00017910 File Offset: 0x00015B10
		public unsafe uint _lastChangeValue_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__lastChangeValue_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__lastChangeValue_5__2)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x0008BF04 File Offset: 0x0008A104
		// (set) Token: 0x0600260D RID: 9741 RVA: 0x0001792B File Offset: 0x00015B2B
		public unsafe int _sameCount_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__sameCount_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_FriendsList._CheckForEndScroll_d__49.NativeFieldInfoPtr__sameCount_5__3)) = value;
			}
		}

		// Token: 0x04001A33 RID: 6707
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A34 RID: 6708
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A35 RID: 6709
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A36 RID: 6710
		private static readonly IntPtr NativeFieldInfoPtr__lastChangeValue_5__2;

		// Token: 0x04001A37 RID: 6711
		private static readonly IntPtr NativeFieldInfoPtr__sameCount_5__3;

		// Token: 0x04001A38 RID: 6712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A39 RID: 6713
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A3A RID: 6714
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A3B RID: 6715
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A3C RID: 6716
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A3D RID: 6717
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001C0 RID: 448
	[ObfuscatedName("UIC_FriendsList+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x0600260E RID: 9742 RVA: 0x0008BF2C File Offset: 0x0008A12C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_FriendsList>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr);
			UIC_FriendsList.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr, "<>9");
			UIC_FriendsList.__c.NativeFieldInfoPtr___9__54_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr, "<>9__54_0");
			UIC_FriendsList.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr, 100666306);
			UIC_FriendsList.__c.NativeMethodInfoPtr__BuildFriendList_b__54_0_Internal_Int32_FriendInfo_FriendInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr, 100666307);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x0008BFA8 File Offset: 0x0008A1A8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_FriendsList.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x0008BFE4 File Offset: 0x0008A1E4
		[CallerCount(0)]
		public unsafe int _BuildFriendList_b__54_0(FriendInfo x, FriendInfo y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_FriendsList.__c.NativeMethodInfoPtr__BuildFriendList_b__54_0_Internal_Int32_FriendInfo_FriendInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x00017946 File Offset: 0x00015B46
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0008C050 File Offset: 0x0008A250
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0001794F File Offset: 0x00015B4F
		public unsafe static UIC_FriendsList.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIC_FriendsList.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_FriendsList.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIC_FriendsList.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0008C078 File Offset: 0x0008A278
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x00017961 File Offset: 0x00015B61
		public unsafe static Comparison<FriendInfo> __9__54_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIC_FriendsList.__c.NativeFieldInfoPtr___9__54_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<FriendInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIC_FriendsList.__c.NativeFieldInfoPtr___9__54_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A3E RID: 6718
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001A3F RID: 6719
		private static readonly IntPtr NativeFieldInfoPtr___9__54_0;

		// Token: 0x04001A40 RID: 6720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001A41 RID: 6721
		private static readonly IntPtr NativeMethodInfoPtr__BuildFriendList_b__54_0_Internal_Int32_FriendInfo_FriendInfo_0;
	}
}
