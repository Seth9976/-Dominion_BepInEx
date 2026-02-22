using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000037 RID: 55
public class KingdomStack : MonoBehaviour
{
	// Token: 0x060009AE RID: 2478 RVA: 0x00036778 File Offset: 0x00034978
	// Note: this type is marked as 'beforefieldinit'.
	static KingdomStack()
	{
		Il2CppClassPointerStore<KingdomStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "KingdomStack");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr);
		KingdomStack.NativeFieldInfoPtr_m_LocatorKingdomStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_LocatorKingdomStack");
		KingdomStack.NativeFieldInfoPtr_m_LocatorAnnounce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_LocatorAnnounce");
		KingdomStack.NativeFieldInfoPtr_m_StackInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_StackInstanceID");
		KingdomStack.NativeFieldInfoPtr_m_StackDisplayCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_StackDisplayCard");
		KingdomStack.NativeFieldInfoPtr_m_StackSampleCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_StackSampleCard");
		KingdomStack.NativeFieldInfoPtr_m_bIsEndOfRainbowStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_bIsEndOfRainbowStack");
		KingdomStack.NativeFieldInfoPtr_m_QueryBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, "m_QueryBuffer");
		KingdomStack.NativeMethodInfoPtr_IsKingdomStackName_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663960);
		KingdomStack.NativeMethodInfoPtr_GetStackDisplayCard_Public_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663961);
		KingdomStack.NativeMethodInfoPtr_GetStackSampleCard_Public_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663962);
		KingdomStack.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663963);
		KingdomStack.NativeMethodInfoPtr_SetIsEndOfRainbowStack_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663964);
		KingdomStack.NativeMethodInfoPtr_GetIsEndOfRainbowStack_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663965);
		KingdomStack.NativeMethodInfoPtr_GetStackInstanceID_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663966);
		KingdomStack.NativeMethodInfoPtr_SetStackInstanceID_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663967);
		KingdomStack.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AscensionAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663968);
		KingdomStack.NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663969);
		KingdomStack.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663970);
		KingdomStack.NativeMethodInfoPtr_OnPointerClickDisplayCard_Public_Void_AscensionCard_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663971);
		KingdomStack.NativeMethodInfoPtr_SetStackDisplayCard_Public_Void_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663972);
		KingdomStack.NativeMethodInfoPtr_SetStackSampleCard_Public_Boolean_AscensionCard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663973);
		KingdomStack.NativeMethodInfoPtr_PlaceSampleCardOnLocator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663974);
		KingdomStack.NativeMethodInfoPtr_MagnifySampleCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663975);
		KingdomStack.NativeMethodInfoPtr_UpdateKingdomStack_Public_Void_AscensionCardManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663976);
		KingdomStack.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663977);
		KingdomStack.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663978);
		KingdomStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr, 100663979);
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x000369C4 File Offset: 0x00034BC4
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235866, RefRangeEnd = 235869, XrefRangeStart = 235862, XrefRangeEnd = 235866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsKingdomStackName(string stack_name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stack_name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_IsKingdomStackName_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x00036A14 File Offset: 0x00034C14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCard GetStackDisplayCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_GetStackDisplayCard_Public_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x00036A54 File Offset: 0x00034C54
	[CallerCount(0)]
	public unsafe AscensionCard GetStackSampleCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_GetStackSampleCard_Public_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr3) : null;
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x00036A94 File Offset: 0x00034C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235869, XrefRangeEnd = 235880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x00036AC8 File Offset: 0x00034CC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235884, RefRangeEnd = 235885, XrefRangeStart = 235880, XrefRangeEnd = 235884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetIsEndOfRainbowStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetIsEndOfRainbowStack_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009B4 RID: 2484 RVA: 0x00036AFC File Offset: 0x00034CFC
	[CallerCount(0)]
	public unsafe bool GetIsEndOfRainbowStack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_GetIsEndOfRainbowStack_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009B5 RID: 2485 RVA: 0x00036B38 File Offset: 0x00034D38
	[CallerCount(0)]
	public unsafe ushort GetStackInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_GetStackInstanceID_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060009B6 RID: 2486 RVA: 0x00036B74 File Offset: 0x00034D74
	[CallerCount(0)]
	public unsafe void SetStackInstanceID(ushort stack_instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref stack_instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetStackInstanceID_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B7 RID: 2487 RVA: 0x00036BB4 File Offset: 0x00034DB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235889, RefRangeEnd = 235890, XrefRangeStart = 235885, XrefRangeEnd = 235889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetAnimationManager(AscensionAnimationManager manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetAnimationManager_Public_Void_AscensionAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B8 RID: 2488 RVA: 0x00036BF8 File Offset: 0x00034DF8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235894, RefRangeEnd = 235895, XrefRangeStart = 235890, XrefRangeEnd = 235894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOverridePlaceLocator(AscensionAnimationLocator locator)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009B9 RID: 2489 RVA: 0x00036C3C File Offset: 0x00034E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235895, XrefRangeEnd = 235908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void BeginDragCallback(DragObject dragObject, PointerEventData eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BA RID: 2490 RVA: 0x00036C90 File Offset: 0x00034E90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235908, XrefRangeEnd = 235912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPointerClickDisplayCard(AscensionCard clickCard, PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clickCard);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_OnPointerClickDisplayCard_Public_Void_AscensionCard_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BB RID: 2491 RVA: 0x00036CE4 File Offset: 0x00034EE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 235955, RefRangeEnd = 235956, XrefRangeStart = 235912, XrefRangeEnd = 235955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetStackDisplayCard(AscensionCard display_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(display_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetStackDisplayCard_Public_Void_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009BC RID: 2492 RVA: 0x00036D28 File Offset: 0x00034F28
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 235977, RefRangeEnd = 235980, XrefRangeStart = 235956, XrefRangeEnd = 235977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool SetStackSampleCard(AscensionCard sample_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sample_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_SetStackSampleCard_Public_Boolean_AscensionCard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060009BD RID: 2493 RVA: 0x00036D78 File Offset: 0x00034F78
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 235995, RefRangeEnd = 236000, XrefRangeStart = 235980, XrefRangeEnd = 235995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceSampleCardOnLocator(bool bIgnoreOverride = false)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bIgnoreOverride;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_PlaceSampleCardOnLocator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009BE RID: 2494 RVA: 0x00036DB8 File Offset: 0x00034FB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 236010, RefRangeEnd = 236012, XrefRangeStart = 236000, XrefRangeEnd = 236010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void MagnifySampleCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_MagnifySampleCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009BF RID: 2495 RVA: 0x00036DEC File Offset: 0x00034FEC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236035, RefRangeEnd = 236036, XrefRangeStart = 236012, XrefRangeEnd = 236035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateKingdomStack(AscensionCardManager card_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(card_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_UpdateKingdomStack_Public_Void_AscensionCardManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C0 RID: 2496 RVA: 0x00036E30 File Offset: 0x00035030
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236062, RefRangeEnd = 236063, XrefRangeStart = 236036, XrefRangeEnd = 236062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C1 RID: 2497 RVA: 0x00036E70 File Offset: 0x00035070
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 236075, RefRangeEnd = 236076, XrefRangeStart = 236063, XrefRangeEnd = 236075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager(AnimationManager animation_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060009C2 RID: 2498 RVA: 0x00036EB4 File Offset: 0x000350B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236076, XrefRangeEnd = 236080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe KingdomStack()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KingdomStack>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KingdomStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009C3 RID: 2499 RVA: 0x00007F10 File Offset: 0x00006110
	public KingdomStack(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000360 RID: 864
	// (get) Token: 0x060009C4 RID: 2500 RVA: 0x00036EF0 File Offset: 0x000350F0
	// (set) Token: 0x060009C5 RID: 2501 RVA: 0x00007F19 File Offset: 0x00006119
	public unsafe AscensionAnimationLocator m_LocatorKingdomStack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_LocatorKingdomStack);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_LocatorKingdomStack), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000361 RID: 865
	// (get) Token: 0x060009C6 RID: 2502 RVA: 0x00036F20 File Offset: 0x00035120
	// (set) Token: 0x060009C7 RID: 2503 RVA: 0x00007F38 File Offset: 0x00006138
	public unsafe AscensionAnimationLocator m_LocatorAnnounce
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_LocatorAnnounce);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_LocatorAnnounce), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000362 RID: 866
	// (get) Token: 0x060009C8 RID: 2504 RVA: 0x00036F50 File Offset: 0x00035150
	// (set) Token: 0x060009C9 RID: 2505 RVA: 0x00007F57 File Offset: 0x00006157
	public unsafe ushort m_StackInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackInstanceID)) = value;
		}
	}

	// Token: 0x17000363 RID: 867
	// (get) Token: 0x060009CA RID: 2506 RVA: 0x00036F78 File Offset: 0x00035178
	// (set) Token: 0x060009CB RID: 2507 RVA: 0x00007F72 File Offset: 0x00006172
	public unsafe AscensionCard m_StackDisplayCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackDisplayCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackDisplayCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000364 RID: 868
	// (get) Token: 0x060009CC RID: 2508 RVA: 0x00036FA8 File Offset: 0x000351A8
	// (set) Token: 0x060009CD RID: 2509 RVA: 0x00007F91 File Offset: 0x00006191
	public unsafe AscensionCard m_StackSampleCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackSampleCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCard>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_StackSampleCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000365 RID: 869
	// (get) Token: 0x060009CE RID: 2510 RVA: 0x00036FD8 File Offset: 0x000351D8
	// (set) Token: 0x060009CF RID: 2511 RVA: 0x00007FB0 File Offset: 0x000061B0
	public unsafe bool m_bIsEndOfRainbowStack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_bIsEndOfRainbowStack);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_bIsEndOfRainbowStack)) = value;
		}
	}

	// Token: 0x17000366 RID: 870
	// (get) Token: 0x060009D0 RID: 2512 RVA: 0x00037000 File Offset: 0x00035200
	// (set) Token: 0x060009D1 RID: 2513 RVA: 0x00007FCB File Offset: 0x000061CB
	public unsafe Il2CppStructArray<QueryCardState> m_QueryBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_QueryBuffer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<QueryCardState>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KingdomStack.NativeFieldInfoPtr_m_QueryBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000602 RID: 1538
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorKingdomStack;

	// Token: 0x04000603 RID: 1539
	private static readonly IntPtr NativeFieldInfoPtr_m_LocatorAnnounce;

	// Token: 0x04000604 RID: 1540
	private static readonly IntPtr NativeFieldInfoPtr_m_StackInstanceID;

	// Token: 0x04000605 RID: 1541
	private static readonly IntPtr NativeFieldInfoPtr_m_StackDisplayCard;

	// Token: 0x04000606 RID: 1542
	private static readonly IntPtr NativeFieldInfoPtr_m_StackSampleCard;

	// Token: 0x04000607 RID: 1543
	private static readonly IntPtr NativeFieldInfoPtr_m_bIsEndOfRainbowStack;

	// Token: 0x04000608 RID: 1544
	private static readonly IntPtr NativeFieldInfoPtr_m_QueryBuffer;

	// Token: 0x04000609 RID: 1545
	private static readonly IntPtr NativeMethodInfoPtr_IsKingdomStackName_Public_Boolean_String_0;

	// Token: 0x0400060A RID: 1546
	private static readonly IntPtr NativeMethodInfoPtr_GetStackDisplayCard_Public_AscensionCard_0;

	// Token: 0x0400060B RID: 1547
	private static readonly IntPtr NativeMethodInfoPtr_GetStackSampleCard_Public_AscensionCard_0;

	// Token: 0x0400060C RID: 1548
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x0400060D RID: 1549
	private static readonly IntPtr NativeMethodInfoPtr_SetIsEndOfRainbowStack_Public_Void_0;

	// Token: 0x0400060E RID: 1550
	private static readonly IntPtr NativeMethodInfoPtr_GetIsEndOfRainbowStack_Public_Boolean_0;

	// Token: 0x0400060F RID: 1551
	private static readonly IntPtr NativeMethodInfoPtr_GetStackInstanceID_Public_UInt16_0;

	// Token: 0x04000610 RID: 1552
	private static readonly IntPtr NativeMethodInfoPtr_SetStackInstanceID_Public_Void_UInt16_0;

	// Token: 0x04000611 RID: 1553
	private static readonly IntPtr NativeMethodInfoPtr_SetAnimationManager_Public_Void_AscensionAnimationManager_0;

	// Token: 0x04000612 RID: 1554
	private static readonly IntPtr NativeMethodInfoPtr_SetOverridePlaceLocator_Public_Void_AscensionAnimationLocator_0;

	// Token: 0x04000613 RID: 1555
	private static readonly IntPtr NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000614 RID: 1556
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerClickDisplayCard_Public_Void_AscensionCard_PointerEventData_0;

	// Token: 0x04000615 RID: 1557
	private static readonly IntPtr NativeMethodInfoPtr_SetStackDisplayCard_Public_Void_AscensionCard_0;

	// Token: 0x04000616 RID: 1558
	private static readonly IntPtr NativeMethodInfoPtr_SetStackSampleCard_Public_Boolean_AscensionCard_0;

	// Token: 0x04000617 RID: 1559
	private static readonly IntPtr NativeMethodInfoPtr_PlaceSampleCardOnLocator_Public_Void_Boolean_0;

	// Token: 0x04000618 RID: 1560
	private static readonly IntPtr NativeMethodInfoPtr_MagnifySampleCard_Public_Void_0;

	// Token: 0x04000619 RID: 1561
	private static readonly IntPtr NativeMethodInfoPtr_UpdateKingdomStack_Public_Void_AscensionCardManager_0;

	// Token: 0x0400061A RID: 1562
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0;

	// Token: 0x0400061B RID: 1563
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AnimationManager_0;

	// Token: 0x0400061C RID: 1564
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
