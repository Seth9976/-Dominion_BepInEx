using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200001D RID: 29
public class AscensionCenterRow : MonoBehaviour
{
	// Token: 0x06000546 RID: 1350 RVA: 0x00029B9C File Offset: 0x00027D9C
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCenterRow()
	{
		Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCenterRow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr);
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorCenterRow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorCenterRow");
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTopCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorTopCard");
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTreasure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorTreasure");
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorUnderneath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorUnderneath");
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorRats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorRats");
		AscensionCenterRow.NativeFieldInfoPtr_m_LocatorAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_LocatorAnnounce");
		AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_EnergyShardLocator");
		AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_EnergyShardPrefab");
		AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_DarkEnergyShardLocator");
		AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_DarkEnergyShardPrefab");
		AscensionCenterRow.NativeFieldInfoPtr_m_DragTargetZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_DragTargetZone");
		AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AnnounceTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_Slot6AnnounceTransform");
		AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AdjustedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_Slot6AdjustedPosition");
		AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCountDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_EnergyShardCountDisplay");
		AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCountDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_DarkEnergyShardCountDisplay");
		AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_EnergyShardCount");
		AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_DarkEnergyShardCount");
		AscensionCenterRow.NativeFieldInfoPtr_m_CenterRowIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_CenterRowIndex");
		AscensionCenterRow.NativeFieldInfoPtr_m_AvailableChampionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_AvailableChampionIndex");
		AscensionCenterRow.NativeFieldInfoPtr_m_QueryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, "m_QueryBuffer");
		AscensionCenterRow.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663649);
		AscensionCenterRow.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663650);
		AscensionCenterRow.NativeMethodInfoPtr_GetCenterRowIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663651);
		AscensionCenterRow.NativeMethodInfoPtr_GetLocatorTopCard_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663652);
		AscensionCenterRow.NativeMethodInfoPtr_GetLocatorTreasure_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663653);
		AscensionCenterRow.NativeMethodInfoPtr_GetLocatorUnderneath_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663654);
		AscensionCenterRow.NativeMethodInfoPtr_GetLocatorRats_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663655);
		AscensionCenterRow.NativeMethodInfoPtr_SetCenterRowIndex_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663656);
		AscensionCenterRow.NativeMethodInfoPtr_FindCenterRowCardByName_Public_AscensionCard_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663657);
		AscensionCenterRow.NativeMethodInfoPtr_UpdateCardDisplay_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663658);
		AscensionCenterRow.NativeMethodInfoPtr_BeginEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663659);
		AscensionCenterRow.NativeMethodInfoPtr_BeginDarkEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663660);
		AscensionCenterRow.NativeMethodInfoPtr_EndEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663661);
		AscensionCenterRow.NativeMethodInfoPtr_SetEnergyShardCountDisplay_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663662);
		AscensionCenterRow.NativeMethodInfoPtr_SetDarkEnergyShardCountDisplay_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663663);
		AscensionCenterRow.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663664);
		AscensionCenterRow.NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663665);
		AscensionCenterRow.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663666);
		AscensionCenterRow.NativeMethodInfoPtr_RebuildDragManager_Public_Void_DragManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663667);
		AscensionCenterRow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr, 100663668);
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x00029EEC File Offset: 0x000280EC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228869, XrefRangeEnd = 228875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x00029F20 File Offset: 0x00028120
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228875, XrefRangeEnd = 228880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x00029F54 File Offset: 0x00028154
	[CallerCount(0)]
	public unsafe int GetCenterRowIndex()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_GetCenterRowIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x00029F90 File Offset: 0x00028190
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetLocatorTopCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_GetLocatorTopCard_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x00029FD0 File Offset: 0x000281D0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetLocatorTreasure()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_GetLocatorTreasure_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0002A010 File Offset: 0x00028210
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetLocatorUnderneath()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_GetLocatorUnderneath_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0002A050 File Offset: 0x00028250
	[CallerCount(0)]
	public unsafe AscensionAnimationLocator GetLocatorRats()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_GetLocatorRats_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0002A090 File Offset: 0x00028290
	[CallerCount(0)]
	public unsafe void SetCenterRowIndex(int centerrow_index, int champion_index = -1)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref centerrow_index;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref champion_index;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_SetCenterRowIndex_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0002A0DC File Offset: 0x000282DC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228902, RefRangeEnd = 228903, XrefRangeStart = 228880, XrefRangeEnd = 228902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard FindCenterRowCardByName(string card_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(card_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_FindCenterRowCardByName_Public_AscensionCard_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0002A12C File Offset: 0x0002832C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 228996, RefRangeEnd = 228997, XrefRangeStart = 228903, XrefRangeEnd = 228996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateCardDisplay(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_UpdateCardDisplay_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0002A170 File Offset: 0x00028370
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228997, XrefRangeEnd = 229058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginEnergyShardDragCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_BeginEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0002A1C4 File Offset: 0x000283C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229058, XrefRangeEnd = 229119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDarkEnergyShardDragCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_BeginDarkEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0002A218 File Offset: 0x00028418
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229119, XrefRangeEnd = 229131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndEnergyShardDragCallback(DragObject dragObject, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragObject);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_EndEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0002A26C File Offset: 0x0002846C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229170, RefRangeEnd = 229171, XrefRangeStart = 229131, XrefRangeEnd = 229170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetEnergyShardCountDisplay(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_SetEnergyShardCountDisplay_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0002A2AC File Offset: 0x000284AC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229210, RefRangeEnd = 229211, XrefRangeStart = 229171, XrefRangeEnd = 229210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDarkEnergyShardCountDisplay(int count)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_SetDarkEnergyShardCountDisplay_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0002A2EC File Offset: 0x000284EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 229250, RefRangeEnd = 229253, XrefRangeStart = 229211, XrefRangeEnd = 229250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0002A32C File Offset: 0x0002852C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 229404, RefRangeEnd = 229406, XrefRangeStart = 229253, XrefRangeEnd = 229404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildCenterRow(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0002A370 File Offset: 0x00028570
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229437, RefRangeEnd = 229438, XrefRangeStart = 229406, XrefRangeEnd = 229437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager(AscensionAnimationManager animation_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0002A3B4 File Offset: 0x000285B4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 229446, RefRangeEnd = 229447, XrefRangeStart = 229438, XrefRangeEnd = 229446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildDragManager(DragManager drag_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(drag_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr_RebuildDragManager_Public_Void_DragManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0002A3F8 File Offset: 0x000285F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229447, XrefRangeEnd = 229451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCenterRow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCenterRow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCenterRow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0000523B File Offset: 0x0000343B
	public AscensionCenterRow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170001E0 RID: 480
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x0002A434 File Offset: 0x00028634
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x00005244 File Offset: 0x00003444
	public unsafe AscensionAnimationLocator m_LocatorCenterRow
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorCenterRow);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorCenterRow), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E1 RID: 481
	// (get) Token: 0x0600055E RID: 1374 RVA: 0x0002A464 File Offset: 0x00028664
	// (set) Token: 0x0600055F RID: 1375 RVA: 0x00005263 File Offset: 0x00003463
	public unsafe AscensionAnimationLocator m_LocatorTopCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTopCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTopCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E2 RID: 482
	// (get) Token: 0x06000560 RID: 1376 RVA: 0x0002A494 File Offset: 0x00028694
	// (set) Token: 0x06000561 RID: 1377 RVA: 0x00005282 File Offset: 0x00003482
	public unsafe AscensionAnimationLocator m_LocatorTreasure
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTreasure);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorTreasure), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E3 RID: 483
	// (get) Token: 0x06000562 RID: 1378 RVA: 0x0002A4C4 File Offset: 0x000286C4
	// (set) Token: 0x06000563 RID: 1379 RVA: 0x000052A1 File Offset: 0x000034A1
	public unsafe AscensionAnimationLocator m_LocatorUnderneath
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorUnderneath);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorUnderneath), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E4 RID: 484
	// (get) Token: 0x06000564 RID: 1380 RVA: 0x0002A4F4 File Offset: 0x000286F4
	// (set) Token: 0x06000565 RID: 1381 RVA: 0x000052C0 File Offset: 0x000034C0
	public unsafe AscensionAnimationLocator m_LocatorRats
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorRats);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorRats), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E5 RID: 485
	// (get) Token: 0x06000566 RID: 1382 RVA: 0x0002A524 File Offset: 0x00028724
	// (set) Token: 0x06000567 RID: 1383 RVA: 0x000052DF File Offset: 0x000034DF
	public unsafe AscensionAnimationLocator m_LocatorAnnounce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorAnnounce);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_LocatorAnnounce), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E6 RID: 486
	// (get) Token: 0x06000568 RID: 1384 RVA: 0x0002A554 File Offset: 0x00028754
	// (set) Token: 0x06000569 RID: 1385 RVA: 0x000052FE File Offset: 0x000034FE
	public unsafe GameObject m_EnergyShardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E7 RID: 487
	// (get) Token: 0x0600056A RID: 1386 RVA: 0x0002A584 File Offset: 0x00028784
	// (set) Token: 0x0600056B RID: 1387 RVA: 0x0000531D File Offset: 0x0000351D
	public unsafe GameObject m_EnergyShardPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E8 RID: 488
	// (get) Token: 0x0600056C RID: 1388 RVA: 0x0002A5B4 File Offset: 0x000287B4
	// (set) Token: 0x0600056D RID: 1389 RVA: 0x0000533C File Offset: 0x0000353C
	public unsafe GameObject m_DarkEnergyShardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001E9 RID: 489
	// (get) Token: 0x0600056E RID: 1390 RVA: 0x0002A5E4 File Offset: 0x000287E4
	// (set) Token: 0x0600056F RID: 1391 RVA: 0x0000535B File Offset: 0x0000355B
	public unsafe GameObject m_DarkEnergyShardPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EA RID: 490
	// (get) Token: 0x06000570 RID: 1392 RVA: 0x0002A614 File Offset: 0x00028814
	// (set) Token: 0x06000571 RID: 1393 RVA: 0x0000537A File Offset: 0x0000357A
	public unsafe DragTargetZone m_DragTargetZone
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DragTargetZone);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DragTargetZone>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DragTargetZone), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EB RID: 491
	// (get) Token: 0x06000572 RID: 1394 RVA: 0x0002A644 File Offset: 0x00028844
	// (set) Token: 0x06000573 RID: 1395 RVA: 0x00005399 File Offset: 0x00003599
	public unsafe RectTransform m_Slot6AnnounceTransform
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AnnounceTransform);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AnnounceTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EC RID: 492
	// (get) Token: 0x06000574 RID: 1396 RVA: 0x0002A674 File Offset: 0x00028874
	// (set) Token: 0x06000575 RID: 1397 RVA: 0x000053B8 File Offset: 0x000035B8
	public unsafe Vector3 m_Slot6AdjustedPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AdjustedPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_Slot6AdjustedPosition)) = value;
		}
	}

	// Token: 0x170001ED RID: 493
	// (get) Token: 0x06000576 RID: 1398 RVA: 0x0002A69C File Offset: 0x0002889C
	// (set) Token: 0x06000577 RID: 1399 RVA: 0x000053D3 File Offset: 0x000035D3
	public unsafe AscensionResource m_EnergyShardCountDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCountDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionResource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCountDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EE RID: 494
	// (get) Token: 0x06000578 RID: 1400 RVA: 0x0002A6CC File Offset: 0x000288CC
	// (set) Token: 0x06000579 RID: 1401 RVA: 0x000053F2 File Offset: 0x000035F2
	public unsafe AscensionResource m_DarkEnergyShardCountDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCountDisplay);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionResource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCountDisplay), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170001EF RID: 495
	// (get) Token: 0x0600057A RID: 1402 RVA: 0x0002A6FC File Offset: 0x000288FC
	// (set) Token: 0x0600057B RID: 1403 RVA: 0x00005411 File Offset: 0x00003611
	public unsafe int m_EnergyShardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_EnergyShardCount)) = value;
		}
	}

	// Token: 0x170001F0 RID: 496
	// (get) Token: 0x0600057C RID: 1404 RVA: 0x0002A724 File Offset: 0x00028924
	// (set) Token: 0x0600057D RID: 1405 RVA: 0x0000542C File Offset: 0x0000362C
	public unsafe int m_DarkEnergyShardCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_DarkEnergyShardCount)) = value;
		}
	}

	// Token: 0x170001F1 RID: 497
	// (get) Token: 0x0600057E RID: 1406 RVA: 0x0002A74C File Offset: 0x0002894C
	// (set) Token: 0x0600057F RID: 1407 RVA: 0x00005447 File Offset: 0x00003647
	public unsafe int m_CenterRowIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_CenterRowIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_CenterRowIndex)) = value;
		}
	}

	// Token: 0x170001F2 RID: 498
	// (get) Token: 0x06000580 RID: 1408 RVA: 0x0002A774 File Offset: 0x00028974
	// (set) Token: 0x06000581 RID: 1409 RVA: 0x00005462 File Offset: 0x00003662
	public unsafe int m_AvailableChampionIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_AvailableChampionIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_AvailableChampionIndex)) = value;
		}
	}

	// Token: 0x170001F3 RID: 499
	// (get) Token: 0x06000582 RID: 1410 RVA: 0x0002A79C File Offset: 0x0002899C
	// (set) Token: 0x06000583 RID: 1411 RVA: 0x0000547D File Offset: 0x0000367D
	public unsafe Il2CppStructArray<QueryCardState> m_QueryBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_QueryBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<QueryCardState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCenterRow.NativeFieldInfoPtr_m_QueryBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000347 RID: 839
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorCenterRow;

	// Token: 0x04000348 RID: 840
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorTopCard;

	// Token: 0x04000349 RID: 841
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorTreasure;

	// Token: 0x0400034A RID: 842
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorUnderneath;

	// Token: 0x0400034B RID: 843
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorRats;

	// Token: 0x0400034C RID: 844
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAnnounce;

	// Token: 0x0400034D RID: 845
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyShardLocator;

	// Token: 0x0400034E RID: 846
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyShardPrefab;

	// Token: 0x0400034F RID: 847
	private static readonly IntPtr NativeFieldInfoPtr_m_DarkEnergyShardLocator;

	// Token: 0x04000350 RID: 848
	private static readonly IntPtr NativeFieldInfoPtr_m_DarkEnergyShardPrefab;

	// Token: 0x04000351 RID: 849
	private static readonly IntPtr NativeFieldInfoPtr_m_DragTargetZone;

	// Token: 0x04000352 RID: 850
	private static readonly IntPtr NativeFieldInfoPtr_m_Slot6AnnounceTransform;

	// Token: 0x04000353 RID: 851
	private static readonly IntPtr NativeFieldInfoPtr_m_Slot6AdjustedPosition;

	// Token: 0x04000354 RID: 852
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyShardCountDisplay;

	// Token: 0x04000355 RID: 853
	private static readonly IntPtr NativeFieldInfoPtr_m_DarkEnergyShardCountDisplay;

	// Token: 0x04000356 RID: 854
	private static readonly IntPtr NativeFieldInfoPtr_m_EnergyShardCount;

	// Token: 0x04000357 RID: 855
	private static readonly IntPtr NativeFieldInfoPtr_m_DarkEnergyShardCount;

	// Token: 0x04000358 RID: 856
	private static readonly IntPtr NativeFieldInfoPtr_m_CenterRowIndex;

	// Token: 0x04000359 RID: 857
	private static readonly IntPtr NativeFieldInfoPtr_m_AvailableChampionIndex;

	// Token: 0x0400035A RID: 858
	private static readonly IntPtr NativeFieldInfoPtr_m_QueryBuffer;

	// Token: 0x0400035B RID: 859
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x0400035C RID: 860
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400035D RID: 861
	private static readonly IntPtr NativeMethodInfoPtr_GetCenterRowIndex_Public_Int32_0;

	// Token: 0x0400035E RID: 862
	private static readonly IntPtr NativeMethodInfoPtr_GetLocatorTopCard_Public_AscensionAnimationLocator_0;

	// Token: 0x0400035F RID: 863
	private static readonly IntPtr NativeMethodInfoPtr_GetLocatorTreasure_Public_AscensionAnimationLocator_0;

	// Token: 0x04000360 RID: 864
	private static readonly IntPtr NativeMethodInfoPtr_GetLocatorUnderneath_Public_AscensionAnimationLocator_0;

	// Token: 0x04000361 RID: 865
	private static readonly IntPtr NativeMethodInfoPtr_GetLocatorRats_Public_AscensionAnimationLocator_0;

	// Token: 0x04000362 RID: 866
	private static readonly IntPtr NativeMethodInfoPtr_SetCenterRowIndex_Public_Void_Int32_Int32_0;

	// Token: 0x04000363 RID: 867
	private static readonly IntPtr NativeMethodInfoPtr_FindCenterRowCardByName_Public_AscensionCard_String_0;

	// Token: 0x04000364 RID: 868
	private static readonly IntPtr NativeMethodInfoPtr_UpdateCardDisplay_Public_Void_AscensionCardManager_0;

	// Token: 0x04000365 RID: 869
	private static readonly IntPtr NativeMethodInfoPtr_BeginEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000366 RID: 870
	private static readonly IntPtr NativeMethodInfoPtr_BeginDarkEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000367 RID: 871
	private static readonly IntPtr NativeMethodInfoPtr_EndEnergyShardDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000368 RID: 872
	private static readonly IntPtr NativeMethodInfoPtr_SetEnergyShardCountDisplay_Private_Void_Int32_0;

	// Token: 0x04000369 RID: 873
	private static readonly IntPtr NativeMethodInfoPtr_SetDarkEnergyShardCountDisplay_Private_Void_Int32_0;

	// Token: 0x0400036A RID: 874
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0;

	// Token: 0x0400036B RID: 875
	private static readonly IntPtr NativeMethodInfoPtr_RebuildCenterRow_Public_Void_AscensionCardManager_0;

	// Token: 0x0400036C RID: 876
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0;

	// Token: 0x0400036D RID: 877
	private static readonly IntPtr NativeMethodInfoPtr_RebuildDragManager_Public_Void_DragManager_0;

	// Token: 0x0400036E RID: 878
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
