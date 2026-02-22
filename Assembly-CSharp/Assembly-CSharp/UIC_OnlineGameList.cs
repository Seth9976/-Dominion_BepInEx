using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000B2 RID: 178
[Serializable]
public class UIC_OnlineGameList : global::Il2CppSystem.Object
{
	// Token: 0x060014F1 RID: 5361 RVA: 0x00059ADC File Offset: 0x00057CDC
	// Note: this type is marked as 'beforefieldinit'.
	static UIC_OnlineGameList()
	{
		Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UIC_OnlineGameList");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr);
		UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlotPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_gameSlotPrefab");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_contentContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_contentContainer");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_scrollView");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_noGamesDisplay");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_noGamesText");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_minDialogDisplayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_minDialogDisplayTime");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_maxOnlineStatusRequest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_maxOnlineStatusRequest");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_gameSlots");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_clickCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_clickCallback");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_network");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_monoBehaviourInstance");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollRectCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_scrollRectCoroutine");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_requestOnlineStatusArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_requestOnlineStatusArray");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_hUserDataBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_hUserDataBuffer");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollChangeCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_scrollChangeCounter");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_bCheckingForEndScroll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_bCheckingForEndScroll");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_findGameFilterFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_findGameFilterFlags");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_bGameListEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_bGameListEnabled");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowCompletedGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_bShowCompletedGames");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowFindGames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_bShowFindGames");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_bBuildAvailableGameList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_bBuildAvailableGameList");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisiblePlayerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_availableListVisiblePlayerFlags");
		UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisibleTimerFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "m_availableListVisibleTimerFlags");
		UIC_OnlineGameList.NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664990);
		UIC_OnlineGameList.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664991);
		UIC_OnlineGameList.NativeMethodInfoPtr_UpdateNoGameDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664992);
		UIC_OnlineGameList.NativeMethodInfoPtr_EnableGameList_Public_Void_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664993);
		UIC_OnlineGameList.NativeMethodInfoPtr_RemoveGameSlotFromList_Public_Void_UIP_GameSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664994);
		UIC_OnlineGameList.NativeMethodInfoPtr_UpdateRect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664995);
		UIC_OnlineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664996);
		UIC_OnlineGameList.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664997);
		UIC_OnlineGameList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664998);
		UIC_OnlineGameList.NativeMethodInfoPtr_SetFindGameFilterFlags_Public_Void_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100664999);
		UIC_OnlineGameList.NativeMethodInfoPtr_ClearGameList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665000);
		UIC_OnlineGameList.NativeMethodInfoPtr_RefreshGameList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665001);
		UIC_OnlineGameList.NativeMethodInfoPtr_RefreshOnlineStatus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665002);
		UIC_OnlineGameList.NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665003);
		UIC_OnlineGameList.NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665004);
		UIC_OnlineGameList.NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665005);
		UIC_OnlineGameList.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665006);
		UIC_OnlineGameList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, 100665007);
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00059E40 File Offset: 0x00058040
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246653, RefRangeEnd = 246655, XrefRangeStart = 246604, XrefRangeEnd = 246653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Initialize(Network network, UIC_OnlineGameList.ClickCallback cb, MonoBehaviour monoBehaviourInstance)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F3 RID: 5363 RVA: 0x00059EA8 File Offset: 0x000580A8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246669, RefRangeEnd = 246671, XrefRangeStart = 246655, XrefRangeEnd = 246669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Destroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00059EDC File Offset: 0x000580DC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246699, RefRangeEnd = 246702, XrefRangeStart = 246671, XrefRangeEnd = 246699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateNoGameDisplay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_UpdateNoGameDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00059F10 File Offset: 0x00058110
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 246723, RefRangeEnd = 246730, XrefRangeStart = 246702, XrefRangeEnd = 246723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EnableGameList(bool bEnable, bool bShowCompletedGames = false, bool bShowFindGameList = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bEnable;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bShowCompletedGames;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bShowFindGameList;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_EnableGameList_Public_Void_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F6 RID: 5366 RVA: 0x00059F6C File Offset: 0x0005816C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246730, XrefRangeEnd = 246739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveGameSlotFromList(UIP_GameSlot slot)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_RemoveGameSlotFromList_Public_Void_UIP_GameSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00059FB0 File Offset: 0x000581B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246739, XrefRangeEnd = 246743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator UpdateRect()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_UpdateRect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00059FF0 File Offset: 0x000581F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246743, XrefRangeEnd = 246744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleClickOnSlot(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x0005A040 File Offset: 0x00058240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246744, XrefRangeEnd = 246745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x0005A08C File Offset: 0x0005828C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246745, XrefRangeEnd = 246749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ProcessDelayTime(float totalDelayTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref totalDelayTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}
	}

	// Token: 0x060014FB RID: 5371 RVA: 0x0005A0D8 File Offset: 0x000582D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246749, RefRangeEnd = 246750, XrefRangeStart = 246749, XrefRangeEnd = 246749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetFindGameFilterFlags(uint playerFlags, uint timerFlags)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref playerFlags;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timerFlags;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_SetFindGameFilterFlags_Public_Void_UInt32_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x0005A124 File Offset: 0x00058324
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 246763, RefRangeEnd = 246767, XrefRangeStart = 246750, XrefRangeEnd = 246763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_ClearGameList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x0005A158 File Offset: 0x00058358
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 246831, RefRangeEnd = 246834, XrefRangeStart = 246767, XrefRangeEnd = 246831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshGameList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_RefreshGameList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x0005A18C File Offset: 0x0005838C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246855, RefRangeEnd = 246856, XrefRangeStart = 246834, XrefRangeEnd = 246855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RefreshOnlineStatus(bool bIgnoreVisibility)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIgnoreVisibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_RefreshOnlineStatus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x0005A1CC File Offset: 0x000583CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246856, XrefRangeEnd = 246860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator CheckForEndScroll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x0005A20C File Offset: 0x0005840C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 246866, RefRangeEnd = 246868, XrefRangeStart = 246860, XrefRangeEnd = 246866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginCheckingForOnlineStatusRefresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x0005A240 File Offset: 0x00058440
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246868, XrefRangeEnd = 246869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ScrollRectChanged(Vector2 data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref data;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x0005A280 File Offset: 0x00058480
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 246873, RefRangeEnd = 246874, XrefRangeStart = 246869, XrefRangeEnd = 246873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator ResetScrollPosition()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x0005A2C0 File Offset: 0x000584C0
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe UIC_OnlineGameList()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0000D8AF File Offset: 0x0000BAAF
	public UIC_OnlineGameList(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005A2FC File Offset: 0x000584FC
	// (set) Token: 0x06001506 RID: 5382 RVA: 0x0000D8B8 File Offset: 0x0000BAB8
	public unsafe GameObject m_gameSlotPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlotPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlotPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06001507 RID: 5383 RVA: 0x0005A32C File Offset: 0x0005852C
	// (set) Token: 0x06001508 RID: 5384 RVA: 0x0000D8D7 File Offset: 0x0000BAD7
	public unsafe Transform m_contentContainer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_contentContainer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_contentContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x06001509 RID: 5385 RVA: 0x0005A35C File Offset: 0x0005855C
	// (set) Token: 0x0600150A RID: 5386 RVA: 0x0000D8F6 File Offset: 0x0000BAF6
	public unsafe ScrollRect m_scrollView
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollView);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollView), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x0600150B RID: 5387 RVA: 0x0005A38C File Offset: 0x0005858C
	// (set) Token: 0x0600150C RID: 5388 RVA: 0x0000D915 File Offset: 0x0000BB15
	public unsafe GameObject m_noGamesDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x0600150D RID: 5389 RVA: 0x0005A3BC File Offset: 0x000585BC
	// (set) Token: 0x0600150E RID: 5390 RVA: 0x0000D934 File Offset: 0x0000BB34
	public unsafe TextMeshProUGUI m_noGamesText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_noGamesText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x0600150F RID: 5391 RVA: 0x0005A3EC File Offset: 0x000585EC
	// (set) Token: 0x06001510 RID: 5392 RVA: 0x0000D953 File Offset: 0x0000BB53
	public unsafe float m_minDialogDisplayTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_minDialogDisplayTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_minDialogDisplayTime)) = value;
		}
	}

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x06001511 RID: 5393 RVA: 0x0005A414 File Offset: 0x00058614
	// (set) Token: 0x06001512 RID: 5394 RVA: 0x0000D96E File Offset: 0x0000BB6E
	public unsafe static int m_maxOnlineStatusRequest
	{
		get
		{
			int num;
			IL2CPP.il2cpp_field_static_get_value(UIC_OnlineGameList.NativeFieldInfoPtr_m_maxOnlineStatusRequest, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(UIC_OnlineGameList.NativeFieldInfoPtr_m_maxOnlineStatusRequest, (void*)(&value));
		}
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x06001513 RID: 5395 RVA: 0x0005A430 File Offset: 0x00058630
	// (set) Token: 0x06001514 RID: 5396 RVA: 0x0000D97C File Offset: 0x0000BB7C
	public unsafe List<UIP_GameSlot> m_gameSlots
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlots);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UIP_GameSlot>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_gameSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x06001515 RID: 5397 RVA: 0x0005A460 File Offset: 0x00058660
	// (set) Token: 0x06001516 RID: 5398 RVA: 0x0000D99B File Offset: 0x0000BB9B
	public unsafe UIC_OnlineGameList.ClickCallback m_clickCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_clickCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList.ClickCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_clickCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x06001517 RID: 5399 RVA: 0x0005A490 File Offset: 0x00058690
	// (set) Token: 0x06001518 RID: 5400 RVA: 0x0000D9BA File Offset: 0x0000BBBA
	public unsafe Network m_network
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_network);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Network>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_network), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x06001519 RID: 5401 RVA: 0x0005A4C0 File Offset: 0x000586C0
	// (set) Token: 0x0600151A RID: 5402 RVA: 0x0000D9D9 File Offset: 0x0000BBD9
	public unsafe MonoBehaviour m_monoBehaviourInstance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoBehaviour>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_monoBehaviourInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x0600151B RID: 5403 RVA: 0x0005A4F0 File Offset: 0x000586F0
	// (set) Token: 0x0600151C RID: 5404 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
	public unsafe Coroutine m_scrollRectCoroutine
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollRectCoroutine);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollRectCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x0600151D RID: 5405 RVA: 0x0005A520 File Offset: 0x00058720
	// (set) Token: 0x0600151E RID: 5406 RVA: 0x0000DA17 File Offset: 0x0000BC17
	public unsafe Il2CppStructArray<uint> m_requestOnlineStatusArray
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_requestOnlineStatusArray);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_requestOnlineStatusArray), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005A550 File Offset: 0x00058750
	// (set) Token: 0x06001520 RID: 5408 RVA: 0x0000DA36 File Offset: 0x0000BC36
	public unsafe GCHandle m_hUserDataBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_hUserDataBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_hUserDataBuffer)) = value;
		}
	}

	// Token: 0x170006A9 RID: 1705
	// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005A578 File Offset: 0x00058778
	// (set) Token: 0x06001522 RID: 5410 RVA: 0x0000DA51 File Offset: 0x0000BC51
	public unsafe uint m_scrollChangeCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollChangeCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_scrollChangeCounter)) = value;
		}
	}

	// Token: 0x170006AA RID: 1706
	// (get) Token: 0x06001523 RID: 5411 RVA: 0x0005A5A0 File Offset: 0x000587A0
	// (set) Token: 0x06001524 RID: 5412 RVA: 0x0000DA6C File Offset: 0x0000BC6C
	public unsafe bool m_bCheckingForEndScroll
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bCheckingForEndScroll);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bCheckingForEndScroll)) = value;
		}
	}

	// Token: 0x170006AB RID: 1707
	// (get) Token: 0x06001525 RID: 5413 RVA: 0x0005A5C8 File Offset: 0x000587C8
	// (set) Token: 0x06001526 RID: 5414 RVA: 0x0000DA87 File Offset: 0x0000BC87
	public unsafe int m_findGameFilterFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_findGameFilterFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_findGameFilterFlags)) = value;
		}
	}

	// Token: 0x170006AC RID: 1708
	// (get) Token: 0x06001527 RID: 5415 RVA: 0x0005A5F0 File Offset: 0x000587F0
	// (set) Token: 0x06001528 RID: 5416 RVA: 0x0000DAA2 File Offset: 0x0000BCA2
	public unsafe bool m_bGameListEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bGameListEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bGameListEnabled)) = value;
		}
	}

	// Token: 0x170006AD RID: 1709
	// (get) Token: 0x06001529 RID: 5417 RVA: 0x0005A618 File Offset: 0x00058818
	// (set) Token: 0x0600152A RID: 5418 RVA: 0x0000DABD File Offset: 0x0000BCBD
	public unsafe bool m_bShowCompletedGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowCompletedGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowCompletedGames)) = value;
		}
	}

	// Token: 0x170006AE RID: 1710
	// (get) Token: 0x0600152B RID: 5419 RVA: 0x0005A640 File Offset: 0x00058840
	// (set) Token: 0x0600152C RID: 5420 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
	public unsafe bool m_bShowFindGames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowFindGames);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bShowFindGames)) = value;
		}
	}

	// Token: 0x170006AF RID: 1711
	// (get) Token: 0x0600152D RID: 5421 RVA: 0x0005A668 File Offset: 0x00058868
	// (set) Token: 0x0600152E RID: 5422 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
	public unsafe bool m_bBuildAvailableGameList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bBuildAvailableGameList);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_bBuildAvailableGameList)) = value;
		}
	}

	// Token: 0x170006B0 RID: 1712
	// (get) Token: 0x0600152F RID: 5423 RVA: 0x0005A690 File Offset: 0x00058890
	// (set) Token: 0x06001530 RID: 5424 RVA: 0x0000DB0E File Offset: 0x0000BD0E
	public unsafe uint m_availableListVisiblePlayerFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisiblePlayerFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisiblePlayerFlags)) = value;
		}
	}

	// Token: 0x170006B1 RID: 1713
	// (get) Token: 0x06001531 RID: 5425 RVA: 0x0005A6B8 File Offset: 0x000588B8
	// (set) Token: 0x06001532 RID: 5426 RVA: 0x0000DB29 File Offset: 0x0000BD29
	public unsafe uint m_availableListVisibleTimerFlags
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisibleTimerFlags);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList.NativeFieldInfoPtr_m_availableListVisibleTimerFlags)) = value;
		}
	}

	// Token: 0x04000E92 RID: 3730
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSlotPrefab;

	// Token: 0x04000E93 RID: 3731
	private static readonly IntPtr NativeFieldInfoPtr_m_contentContainer;

	// Token: 0x04000E94 RID: 3732
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollView;

	// Token: 0x04000E95 RID: 3733
	private static readonly IntPtr NativeFieldInfoPtr_m_noGamesDisplay;

	// Token: 0x04000E96 RID: 3734
	private static readonly IntPtr NativeFieldInfoPtr_m_noGamesText;

	// Token: 0x04000E97 RID: 3735
	private static readonly IntPtr NativeFieldInfoPtr_m_minDialogDisplayTime;

	// Token: 0x04000E98 RID: 3736
	private static readonly IntPtr NativeFieldInfoPtr_m_maxOnlineStatusRequest;

	// Token: 0x04000E99 RID: 3737
	private static readonly IntPtr NativeFieldInfoPtr_m_gameSlots;

	// Token: 0x04000E9A RID: 3738
	private static readonly IntPtr NativeFieldInfoPtr_m_clickCallback;

	// Token: 0x04000E9B RID: 3739
	private static readonly IntPtr NativeFieldInfoPtr_m_network;

	// Token: 0x04000E9C RID: 3740
	private static readonly IntPtr NativeFieldInfoPtr_m_monoBehaviourInstance;

	// Token: 0x04000E9D RID: 3741
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollRectCoroutine;

	// Token: 0x04000E9E RID: 3742
	private static readonly IntPtr NativeFieldInfoPtr_m_requestOnlineStatusArray;

	// Token: 0x04000E9F RID: 3743
	private static readonly IntPtr NativeFieldInfoPtr_m_hUserDataBuffer;

	// Token: 0x04000EA0 RID: 3744
	private static readonly IntPtr NativeFieldInfoPtr_m_scrollChangeCounter;

	// Token: 0x04000EA1 RID: 3745
	private static readonly IntPtr NativeFieldInfoPtr_m_bCheckingForEndScroll;

	// Token: 0x04000EA2 RID: 3746
	private static readonly IntPtr NativeFieldInfoPtr_m_findGameFilterFlags;

	// Token: 0x04000EA3 RID: 3747
	private static readonly IntPtr NativeFieldInfoPtr_m_bGameListEnabled;

	// Token: 0x04000EA4 RID: 3748
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowCompletedGames;

	// Token: 0x04000EA5 RID: 3749
	private static readonly IntPtr NativeFieldInfoPtr_m_bShowFindGames;

	// Token: 0x04000EA6 RID: 3750
	private static readonly IntPtr NativeFieldInfoPtr_m_bBuildAvailableGameList;

	// Token: 0x04000EA7 RID: 3751
	private static readonly IntPtr NativeFieldInfoPtr_m_availableListVisiblePlayerFlags;

	// Token: 0x04000EA8 RID: 3752
	private static readonly IntPtr NativeFieldInfoPtr_m_availableListVisibleTimerFlags;

	// Token: 0x04000EA9 RID: 3753
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Network_ClickCallback_MonoBehaviour_0;

	// Token: 0x04000EAA RID: 3754
	private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

	// Token: 0x04000EAB RID: 3755
	private static readonly IntPtr NativeMethodInfoPtr_UpdateNoGameDisplay_Private_Void_0;

	// Token: 0x04000EAC RID: 3756
	private static readonly IntPtr NativeMethodInfoPtr_EnableGameList_Public_Void_Boolean_Boolean_Boolean_0;

	// Token: 0x04000EAD RID: 3757
	private static readonly IntPtr NativeMethodInfoPtr_RemoveGameSlotFromList_Public_Void_UIP_GameSlot_0;

	// Token: 0x04000EAE RID: 3758
	private static readonly IntPtr NativeMethodInfoPtr_UpdateRect_Private_IEnumerator_0;

	// Token: 0x04000EAF RID: 3759
	private static readonly IntPtr NativeMethodInfoPtr_HandleClickOnSlot_Private_Void_UIP_GameSlot_ClickEventType_0;

	// Token: 0x04000EB0 RID: 3760
	private static readonly IntPtr NativeMethodInfoPtr_NetworkEventCallback_Private_Void_EventType_Int32_0;

	// Token: 0x04000EB1 RID: 3761
	private static readonly IntPtr NativeMethodInfoPtr_ProcessDelayTime_Private_IEnumerator_Single_0;

	// Token: 0x04000EB2 RID: 3762
	private static readonly IntPtr NativeMethodInfoPtr_SetFindGameFilterFlags_Public_Void_UInt32_UInt32_0;

	// Token: 0x04000EB3 RID: 3763
	private static readonly IntPtr NativeMethodInfoPtr_ClearGameList_Private_Void_0;

	// Token: 0x04000EB4 RID: 3764
	private static readonly IntPtr NativeMethodInfoPtr_RefreshGameList_Private_Void_0;

	// Token: 0x04000EB5 RID: 3765
	private static readonly IntPtr NativeMethodInfoPtr_RefreshOnlineStatus_Private_Void_Boolean_0;

	// Token: 0x04000EB6 RID: 3766
	private static readonly IntPtr NativeMethodInfoPtr_CheckForEndScroll_Private_IEnumerator_0;

	// Token: 0x04000EB7 RID: 3767
	private static readonly IntPtr NativeMethodInfoPtr_BeginCheckingForOnlineStatusRefresh_Private_Void_0;

	// Token: 0x04000EB8 RID: 3768
	private static readonly IntPtr NativeMethodInfoPtr_ScrollRectChanged_Private_Void_Vector2_0;

	// Token: 0x04000EB9 RID: 3769
	private static readonly IntPtr NativeMethodInfoPtr_ResetScrollPosition_Private_IEnumerator_0;

	// Token: 0x04000EBA RID: 3770
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020001C3 RID: 451
	public sealed class ClickCallback : MulticastDelegate
	{
		// Token: 0x0600262D RID: 9773 RVA: 0x0008C55C File Offset: 0x0008A75C
		// Note: this type is marked as 'beforefieldinit'.
		static ClickCallback()
		{
			Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "ClickCallback");
			UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr, 100666318);
			UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr, 100666319);
			UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr, 100666320);
			UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr, 100666321);
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x0008C5D0 File Offset: 0x0008A7D0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClickCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList.ClickCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x0008C62C File Offset: 0x0008A82C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 79669, RefRangeEnd = 79680, XrefRangeStart = 79669, XrefRangeEnd = 79680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x0008C67C File Offset: 0x0008A87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246558, XrefRangeEnd = 246562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(UIP_GameSlot slot, UIP_GameSlot.ClickEventType evt, AsyncCallback callback, global::Il2CppSystem.Object @object)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x0008C700 File Offset: 0x0008A900
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList.ClickCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x00017A05 File Offset: 0x00015C05
		public ClickCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x00017A0E File Offset: 0x00015C0E
		public static implicit operator UIC_OnlineGameList.ClickCallback(Action<UIP_GameSlot, UIP_GameSlot.ClickEventType> A_0)
		{
			return DelegateSupport.ConvertDelegate<UIC_OnlineGameList.ClickCallback>(A_0);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x00017A16 File Offset: 0x00015C16
		public static UIC_OnlineGameList.ClickCallback operator +(UIC_OnlineGameList.ClickCallback A_0, UIC_OnlineGameList.ClickCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UIC_OnlineGameList.ClickCallback>();
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x00017A24 File Offset: 0x00015C24
		public static UIC_OnlineGameList.ClickCallback operator -(UIC_OnlineGameList.ClickCallback A_0, UIC_OnlineGameList.ClickCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UIC_OnlineGameList.ClickCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001A4F RID: 6735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001A50 RID: 6736
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_UIP_GameSlot_ClickEventType_0;

		// Token: 0x04001A51 RID: 6737
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_UIP_GameSlot_ClickEventType_AsyncCallback_Object_0;

		// Token: 0x04001A52 RID: 6738
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x020001C4 RID: 452
	[ObfuscatedName("UIC_OnlineGameList+<UpdateRect>d__29")]
	public sealed class _UpdateRect_d__29 : global::Il2CppSystem.Object
	{
		// Token: 0x06002636 RID: 9782 RVA: 0x0008C744 File Offset: 0x0008A944
		// Note: this type is marked as 'beforefieldinit'.
		static _UpdateRect_d__29()
		{
			Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "<UpdateRect>d__29");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr);
			UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, "<>1__state");
			UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, "<>2__current");
			UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, "<>4__this");
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666322);
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666323);
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666324);
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666325);
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666326);
			UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr, 100666327);
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x0008C824 File Offset: 0x0008AA24
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _UpdateRect_d__29(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList._UpdateRect_d__29>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x0008C86C File Offset: 0x0008AA6C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x0008C8A0 File Offset: 0x0008AAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246562, XrefRangeEnd = 246566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x0600263A RID: 9786 RVA: 0x0008C8DC File Offset: 0x0008AADC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x0008C91C File Offset: 0x0008AB1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246566, XrefRangeEnd = 246571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x0008C950 File Offset: 0x0008AB50
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._UpdateRect_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00017A35 File Offset: 0x00015C35
		public _UpdateRect_d__29(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600263E RID: 9790 RVA: 0x0008C990 File Offset: 0x0008AB90
		// (set) Token: 0x0600263F RID: 9791 RVA: 0x00017A3E File Offset: 0x00015C3E
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002640 RID: 9792 RVA: 0x0008C9B8 File Offset: 0x0008ABB8
		// (set) Token: 0x06002641 RID: 9793 RVA: 0x00017A59 File Offset: 0x00015C59
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002642 RID: 9794 RVA: 0x0008C9E8 File Offset: 0x0008ABE8
		// (set) Token: 0x06002643 RID: 9795 RVA: 0x00017A78 File Offset: 0x00015C78
		public unsafe UIC_OnlineGameList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._UpdateRect_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A53 RID: 6739
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A54 RID: 6740
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A55 RID: 6741
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A56 RID: 6742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A57 RID: 6743
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A58 RID: 6744
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A59 RID: 6745
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A5A RID: 6746
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A5B RID: 6747
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001C5 RID: 453
	[ObfuscatedName("UIC_OnlineGameList+<ProcessDelayTime>d__32")]
	public sealed class _ProcessDelayTime_d__32 : global::Il2CppSystem.Object
	{
		// Token: 0x06002644 RID: 9796 RVA: 0x0008CA18 File Offset: 0x0008AC18
		// Note: this type is marked as 'beforefieldinit'.
		static _ProcessDelayTime_d__32()
		{
			Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "<ProcessDelayTime>d__32");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "<>1__state");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "<>2__current");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "totalDelayTime");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "<>4__this");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "<accumulatedTime>5__2");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, "<previousTime>5__3");
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666328);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666329);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666330);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666331);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666332);
			UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr, 100666333);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x0008CB34 File Offset: 0x0008AD34
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ProcessDelayTime_d__32(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList._ProcessDelayTime_d__32>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0008CB7C File Offset: 0x0008AD7C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x0008CBB0 File Offset: 0x0008ADB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246571, XrefRangeEnd = 246579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x0008CBEC File Offset: 0x0008ADEC
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x0008CC2C File Offset: 0x0008AE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246579, XrefRangeEnd = 246584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x0008CC60 File Offset: 0x0008AE60
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x00017A97 File Offset: 0x00015C97
		public _ProcessDelayTime_d__32(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0008CCA0 File Offset: 0x0008AEA0
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00017AA0 File Offset: 0x00015CA0
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x0008CCC8 File Offset: 0x0008AEC8
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x00017ABB File Offset: 0x00015CBB
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x0008CCF8 File Offset: 0x0008AEF8
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x00017ADA File Offset: 0x00015CDA
		public unsafe float totalDelayTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr_totalDelayTime)) = value;
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x0008CD20 File Offset: 0x0008AF20
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x00017AF5 File Offset: 0x00015CF5
		public unsafe UIC_OnlineGameList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0008CD50 File Offset: 0x0008AF50
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x00017B14 File Offset: 0x00015D14
		public unsafe float _accumulatedTime_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__accumulatedTime_5__2)) = value;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x0008CD78 File Offset: 0x0008AF78
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x00017B2F File Offset: 0x00015D2F
		public unsafe float _previousTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ProcessDelayTime_d__32.NativeFieldInfoPtr__previousTime_5__3)) = value;
			}
		}

		// Token: 0x04001A5C RID: 6748
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A5D RID: 6749
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_totalDelayTime;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr__accumulatedTime_5__2;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr__previousTime_5__3;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001C6 RID: 454
	[ObfuscatedName("UIC_OnlineGameList+<CheckForEndScroll>d__37")]
	public sealed class _CheckForEndScroll_d__37 : global::Il2CppSystem.Object
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x0008CDA0 File Offset: 0x0008AFA0
		// Note: this type is marked as 'beforefieldinit'.
		static _CheckForEndScroll_d__37()
		{
			Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "<CheckForEndScroll>d__37");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, "<>1__state");
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, "<>2__current");
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, "<>4__this");
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__lastChangeValue_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, "<lastChangeValue>5__2");
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__sameCount_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, "<sameCount>5__3");
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666334);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666335);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666336);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666337);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666338);
			UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr, 100666339);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x0008CEA8 File Offset: 0x0008B0A8
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _CheckForEndScroll_d__37(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList._CheckForEndScroll_d__37>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x0008CEF0 File Offset: 0x0008B0F0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0008CF24 File Offset: 0x0008B124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246584, XrefRangeEnd = 246590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x0008CF60 File Offset: 0x0008B160
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x0008CFA0 File Offset: 0x0008B1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246590, XrefRangeEnd = 246595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x0008CFD4 File Offset: 0x0008B1D4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00017B4A File Offset: 0x00015D4A
		public _CheckForEndScroll_d__37(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x0008D014 File Offset: 0x0008B214
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x00017B53 File Offset: 0x00015D53
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x0008D03C File Offset: 0x0008B23C
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x00017B6E File Offset: 0x00015D6E
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002664 RID: 9828 RVA: 0x0008D06C File Offset: 0x0008B26C
		// (set) Token: 0x06002665 RID: 9829 RVA: 0x00017B8D File Offset: 0x00015D8D
		public unsafe UIC_OnlineGameList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002666 RID: 9830 RVA: 0x0008D09C File Offset: 0x0008B29C
		// (set) Token: 0x06002667 RID: 9831 RVA: 0x00017BAC File Offset: 0x00015DAC
		public unsafe uint _lastChangeValue_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__lastChangeValue_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__lastChangeValue_5__2)) = value;
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002668 RID: 9832 RVA: 0x0008D0C4 File Offset: 0x0008B2C4
		// (set) Token: 0x06002669 RID: 9833 RVA: 0x00017BC7 File Offset: 0x00015DC7
		public unsafe int _sameCount_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__sameCount_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._CheckForEndScroll_d__37.NativeFieldInfoPtr__sameCount_5__3)) = value;
			}
		}

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeFieldInfoPtr__lastChangeValue_5__2;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeFieldInfoPtr__sameCount_5__3;

		// Token: 0x04001A6D RID: 6765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A6E RID: 6766
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A6F RID: 6767
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A70 RID: 6768
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A71 RID: 6769
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A72 RID: 6770
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020001C7 RID: 455
	[ObfuscatedName("UIC_OnlineGameList+<ResetScrollPosition>d__40")]
	public sealed class _ResetScrollPosition_d__40 : global::Il2CppSystem.Object
	{
		// Token: 0x0600266A RID: 9834 RVA: 0x0008D0EC File Offset: 0x0008B2EC
		// Note: this type is marked as 'beforefieldinit'.
		static _ResetScrollPosition_d__40()
		{
			Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UIC_OnlineGameList>.NativeClassPtr, "<ResetScrollPosition>d__40");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, "<>1__state");
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, "<>2__current");
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, "<>4__this");
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666340);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666341);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666342);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666343);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666344);
			UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr, 100666345);
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x0008D1CC File Offset: 0x0008B3CC
		[CallerCount(208)]
		[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _ResetScrollPosition_d__40(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIC_OnlineGameList._ResetScrollPosition_d__40>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x0008D214 File Offset: 0x0008B414
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x0008D248 File Offset: 0x0008B448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246595, XrefRangeEnd = 246599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x0600266E RID: 9838 RVA: 0x0008D284 File Offset: 0x0008B484
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600266F RID: 9839 RVA: 0x0008D2C4 File Offset: 0x0008B4C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 246599, XrefRangeEnd = 246604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002670 RID: 9840 RVA: 0x0008D2F8 File Offset: 0x0008B4F8
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x00017BE2 File Offset: 0x00015DE2
		public _ResetScrollPosition_d__40(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06002672 RID: 9842 RVA: 0x0008D338 File Offset: 0x0008B538
		// (set) Token: 0x06002673 RID: 9843 RVA: 0x00017BEB File Offset: 0x00015DEB
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0008D360 File Offset: 0x0008B560
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00017C06 File Offset: 0x00015E06
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002676 RID: 9846 RVA: 0x0008D390 File Offset: 0x0008B590
		// (set) Token: 0x06002677 RID: 9847 RVA: 0x00017C25 File Offset: 0x00015E25
		public unsafe UIC_OnlineGameList __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIC_OnlineGameList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIC_OnlineGameList._ResetScrollPosition_d__40.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A73 RID: 6771
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001A74 RID: 6772
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001A75 RID: 6773
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001A76 RID: 6774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001A77 RID: 6775
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A78 RID: 6776
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001A79 RID: 6777
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001A7A RID: 6778
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001A7B RID: 6779
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
