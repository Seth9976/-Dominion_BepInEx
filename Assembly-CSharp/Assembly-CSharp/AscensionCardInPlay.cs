using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200001A RID: 26
public class AscensionCardInPlay : CardInPlay
{
	// Token: 0x0600041B RID: 1051 RVA: 0x000266C8 File Offset: 0x000248C8
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionCardInPlay()
	{
		Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionCardInPlay");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr);
		AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_CardLocator");
		AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocatorUnderCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_CardLocatorUnderCard");
		AscensionCardInPlay.NativeFieldInfoPtr_m_CardText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_CardText");
		AscensionCardInPlay.NativeFieldInfoPtr_m_SourceUnderCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_SourceUnderCard");
		AscensionCardInPlay.NativeFieldInfoPtr_m_OwnerInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_OwnerInstanceID");
		AscensionCardInPlay.NativeFieldInfoPtr_m_bResetUnderCardPosOnUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_bResetUnderCardPosOnUpdate");
		AscensionCardInPlay.NativeFieldInfoPtr_m_AbilityInstanceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, "m_AbilityInstanceList");
		AscensionCardInPlay.NativeMethodInfoPtr_GetSourceUnderCard_Public_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663582);
		AscensionCardInPlay.NativeMethodInfoPtr_SetSourceCard_Public_Virtual_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663583);
		AscensionCardInPlay.NativeMethodInfoPtr_SetCardTextObject_Public_Void_CardOverlay_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663584);
		AscensionCardInPlay.NativeMethodInfoPtr_GetCardLocator_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663585);
		AscensionCardInPlay.NativeMethodInfoPtr_GetUnderCardLocator_Public_AscensionAnimationLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663586);
		AscensionCardInPlay.NativeMethodInfoPtr_GetOwnerInstanceID_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663587);
		AscensionCardInPlay.NativeMethodInfoPtr_SetOwnerInstanceID_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663588);
		AscensionCardInPlay.NativeMethodInfoPtr_AddAbilityInstance_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663589);
		AscensionCardInPlay.NativeMethodInfoPtr_IsAbilityInstance_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663590);
		AscensionCardInPlay.NativeMethodInfoPtr_SetUnderCard_Public_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663591);
		AscensionCardInPlay.NativeMethodInfoPtr_RemoveUnderCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663592);
		AscensionCardInPlay.NativeMethodInfoPtr_SetResetUnderCardPosOnUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663593);
		AscensionCardInPlay.NativeMethodInfoPtr_PlaceSourceCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663594);
		AscensionCardInPlay.NativeMethodInfoPtr_PlaceUnderCard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663595);
		AscensionCardInPlay.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663596);
		AscensionCardInPlay.NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663597);
		AscensionCardInPlay.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663598);
		AscensionCardInPlay.NativeMethodInfoPtr_RemoveFromAnimationManager_Public_Void_AscensionAnimationManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663599);
		AscensionCardInPlay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr, 100663600);
	}

	// Token: 0x0600041C RID: 1052 RVA: 0x00026900 File Offset: 0x00024B00
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CardObject GetSourceUnderCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_GetSourceUnderCard_Public_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr3) : null;
	}

	// Token: 0x0600041D RID: 1053 RVA: 0x00026940 File Offset: 0x00024B40
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227630, XrefRangeEnd = 227649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void SetSourceCard(CardObject source_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCardInPlay.NativeMethodInfoPtr_SetSourceCard_Public_Virtual_Void_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600041E RID: 1054 RVA: 0x00026990 File Offset: 0x00024B90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227649, XrefRangeEnd = 227657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetCardTextObject(CardOverlay cardText)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cardText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_SetCardTextObject_Public_Void_CardOverlay_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600041F RID: 1055 RVA: 0x000269D4 File Offset: 0x00024BD4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetCardLocator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_GetCardLocator_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x06000420 RID: 1056 RVA: 0x00026A14 File Offset: 0x00024C14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionAnimationLocator GetUnderCardLocator()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_GetUnderCardLocator_Public_AscensionAnimationLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr3) : null;
	}

	// Token: 0x06000421 RID: 1057 RVA: 0x00026A54 File Offset: 0x00024C54
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int GetOwnerInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_GetOwnerInstanceID_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000422 RID: 1058 RVA: 0x00026A90 File Offset: 0x00024C90
	[CallerCount(0)]
	public unsafe void SetOwnerInstanceID(int ownerInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref ownerInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_SetOwnerInstanceID_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000423 RID: 1059 RVA: 0x00026AD0 File Offset: 0x00024CD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227657, XrefRangeEnd = 227669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddAbilityInstance(int abilityInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref abilityInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_AddAbilityInstance_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000424 RID: 1060 RVA: 0x00026B10 File Offset: 0x00024D10
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227669, XrefRangeEnd = 227670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsAbilityInstance(int abilityInstanceID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref abilityInstanceID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_IsAbilityInstance_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000425 RID: 1061 RVA: 0x00026B5C File Offset: 0x00024D5C
	[CallerCount(0)]
	public unsafe void SetUnderCard(CardObject sourceCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sourceCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_SetUnderCard_Public_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000426 RID: 1062 RVA: 0x00026BA0 File Offset: 0x00024DA0
	[CallerCount(0)]
	public unsafe void RemoveUnderCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_RemoveUnderCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000427 RID: 1063 RVA: 0x00026BD4 File Offset: 0x00024DD4
	[CallerCount(0)]
	public unsafe void SetResetUnderCardPosOnUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_SetResetUnderCardPosOnUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000428 RID: 1064 RVA: 0x00026C08 File Offset: 0x00024E08
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227709, RefRangeEnd = 227711, XrefRangeStart = 227670, XrefRangeEnd = 227709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceSourceCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_PlaceSourceCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000429 RID: 1065 RVA: 0x00026C3C File Offset: 0x00024E3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227711, XrefRangeEnd = 227720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlaceUnderCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_PlaceUnderCard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600042A RID: 1066 RVA: 0x00026C70 File Offset: 0x00024E70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227720, XrefRangeEnd = 227731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600042B RID: 1067 RVA: 0x00026CA4 File Offset: 0x00024EA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 227731, XrefRangeEnd = 227788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AscensionCardInPlay.NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600042C RID: 1068 RVA: 0x00026CF0 File Offset: 0x00024EF0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227802, RefRangeEnd = 227804, XrefRangeStart = 227788, XrefRangeEnd = 227802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RebuildAnimationManager(AscensionAnimationManager animation_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600042D RID: 1069 RVA: 0x00026D34 File Offset: 0x00024F34
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 227819, RefRangeEnd = 227821, XrefRangeStart = 227804, XrefRangeEnd = 227819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveFromAnimationManager(AscensionAnimationManager animation_manager)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(animation_manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr_RemoveFromAnimationManager_Public_Void_AscensionAnimationManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600042E RID: 1070 RVA: 0x00026D78 File Offset: 0x00024F78
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionCardInPlay()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionCardInPlay>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionCardInPlay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600042F RID: 1071 RVA: 0x00004580 File Offset: 0x00002780
	public AscensionCardInPlay(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700016F RID: 367
	// (get) Token: 0x06000430 RID: 1072 RVA: 0x00026DB4 File Offset: 0x00024FB4
	// (set) Token: 0x06000431 RID: 1073 RVA: 0x00004589 File Offset: 0x00002789
	public unsafe AscensionAnimationLocator m_CardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000170 RID: 368
	// (get) Token: 0x06000432 RID: 1074 RVA: 0x00026DE4 File Offset: 0x00024FE4
	// (set) Token: 0x06000433 RID: 1075 RVA: 0x000045A8 File Offset: 0x000027A8
	public unsafe AscensionAnimationLocator m_CardLocatorUnderCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocatorUnderCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionAnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardLocatorUnderCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000171 RID: 369
	// (get) Token: 0x06000434 RID: 1076 RVA: 0x00026E14 File Offset: 0x00025014
	// (set) Token: 0x06000435 RID: 1077 RVA: 0x000045C7 File Offset: 0x000027C7
	public unsafe CardOverlay m_CardText
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardText);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardOverlay>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_CardText), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000172 RID: 370
	// (get) Token: 0x06000436 RID: 1078 RVA: 0x00026E44 File Offset: 0x00025044
	// (set) Token: 0x06000437 RID: 1079 RVA: 0x000045E6 File Offset: 0x000027E6
	public unsafe CardObject m_SourceUnderCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_SourceUnderCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_SourceUnderCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000173 RID: 371
	// (get) Token: 0x06000438 RID: 1080 RVA: 0x00026E74 File Offset: 0x00025074
	// (set) Token: 0x06000439 RID: 1081 RVA: 0x00004605 File Offset: 0x00002805
	public unsafe int m_OwnerInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_OwnerInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_OwnerInstanceID)) = value;
		}
	}

	// Token: 0x17000174 RID: 372
	// (get) Token: 0x0600043A RID: 1082 RVA: 0x00026E9C File Offset: 0x0002509C
	// (set) Token: 0x0600043B RID: 1083 RVA: 0x00004620 File Offset: 0x00002820
	public unsafe bool m_bResetUnderCardPosOnUpdate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_bResetUnderCardPosOnUpdate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_bResetUnderCardPosOnUpdate)) = value;
		}
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x0600043C RID: 1084 RVA: 0x00026EC4 File Offset: 0x000250C4
	// (set) Token: 0x0600043D RID: 1085 RVA: 0x0000463B File Offset: 0x0000283B
	public unsafe List<int> m_AbilityInstanceList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_AbilityInstanceList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionCardInPlay.NativeFieldInfoPtr_m_AbilityInstanceList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000293 RID: 659
	private static readonly IntPtr NativeFieldInfoPtr_m_CardLocator;

	// Token: 0x04000294 RID: 660
	private static readonly IntPtr NativeFieldInfoPtr_m_CardLocatorUnderCard;

	// Token: 0x04000295 RID: 661
	private static readonly IntPtr NativeFieldInfoPtr_m_CardText;

	// Token: 0x04000296 RID: 662
	private static readonly IntPtr NativeFieldInfoPtr_m_SourceUnderCard;

	// Token: 0x04000297 RID: 663
	private static readonly IntPtr NativeFieldInfoPtr_m_OwnerInstanceID;

	// Token: 0x04000298 RID: 664
	private static readonly IntPtr NativeFieldInfoPtr_m_bResetUnderCardPosOnUpdate;

	// Token: 0x04000299 RID: 665
	private static readonly IntPtr NativeFieldInfoPtr_m_AbilityInstanceList;

	// Token: 0x0400029A RID: 666
	private static readonly IntPtr NativeMethodInfoPtr_GetSourceUnderCard_Public_CardObject_0;

	// Token: 0x0400029B RID: 667
	private static readonly IntPtr NativeMethodInfoPtr_SetSourceCard_Public_Virtual_Void_CardObject_0;

	// Token: 0x0400029C RID: 668
	private static readonly IntPtr NativeMethodInfoPtr_SetCardTextObject_Public_Void_CardOverlay_0;

	// Token: 0x0400029D RID: 669
	private static readonly IntPtr NativeMethodInfoPtr_GetCardLocator_Public_AscensionAnimationLocator_0;

	// Token: 0x0400029E RID: 670
	private static readonly IntPtr NativeMethodInfoPtr_GetUnderCardLocator_Public_AscensionAnimationLocator_0;

	// Token: 0x0400029F RID: 671
	private static readonly IntPtr NativeMethodInfoPtr_GetOwnerInstanceID_Public_Int32_0;

	// Token: 0x040002A0 RID: 672
	private static readonly IntPtr NativeMethodInfoPtr_SetOwnerInstanceID_Public_Void_Int32_0;

	// Token: 0x040002A1 RID: 673
	private static readonly IntPtr NativeMethodInfoPtr_AddAbilityInstance_Public_Void_Int32_0;

	// Token: 0x040002A2 RID: 674
	private static readonly IntPtr NativeMethodInfoPtr_IsAbilityInstance_Public_Boolean_Int32_0;

	// Token: 0x040002A3 RID: 675
	private static readonly IntPtr NativeMethodInfoPtr_SetUnderCard_Public_Void_CardObject_0;

	// Token: 0x040002A4 RID: 676
	private static readonly IntPtr NativeMethodInfoPtr_RemoveUnderCard_Public_Void_0;

	// Token: 0x040002A5 RID: 677
	private static readonly IntPtr NativeMethodInfoPtr_SetResetUnderCardPosOnUpdate_Public_Void_0;

	// Token: 0x040002A6 RID: 678
	private static readonly IntPtr NativeMethodInfoPtr_PlaceSourceCard_Public_Void_0;

	// Token: 0x040002A7 RID: 679
	private static readonly IntPtr NativeMethodInfoPtr_PlaceUnderCard_Public_Void_0;

	// Token: 0x040002A8 RID: 680
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x040002A9 RID: 681
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Virtual_Void_Boolean_0;

	// Token: 0x040002AA RID: 682
	private static readonly IntPtr NativeMethodInfoPtr_RebuildAnimationManager_Public_Void_AscensionAnimationManager_0;

	// Token: 0x040002AB RID: 683
	private static readonly IntPtr NativeMethodInfoPtr_RemoveFromAnimationManager_Public_Void_AscensionAnimationManager_0;

	// Token: 0x040002AC RID: 684
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
