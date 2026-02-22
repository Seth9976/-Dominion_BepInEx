using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000093 RID: 147
public class MagnifyManager : MonoBehaviour
{
	// Token: 0x060011D6 RID: 4566 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
	// Note: this type is marked as 'beforefieldinit'.
	static MagnifyManager()
	{
		Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "MagnifyManager");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr);
		MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_MagnifyCardPanel");
		MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanelOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_MagnifyCardPanelOverride");
		MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardLocator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_MagnifyCardLocator");
		MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_MagnifyCardOverrideLayer");
		MagnifyManager.NativeFieldInfoPtr_m_MagnifiedCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_MagnifiedCard");
		MagnifyManager.NativeFieldInfoPtr_m_bUseOverrideLayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_bUseOverrideLayer");
		MagnifyManager.NativeFieldInfoPtr_m_OnMagnifyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_OnMagnifyCallback");
		MagnifyManager.NativeFieldInfoPtr_m_OnUnmagnifyCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "m_OnUnmagnifyCallback");
		MagnifyManager.NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_New_AnimationLocator_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664669);
		MagnifyManager.NativeMethodInfoPtr_GetMagnifiedCard_Public_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664670);
		MagnifyManager.NativeMethodInfoPtr_AddOnMagnifyCallback_Public_Void_MagnifyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664671);
		MagnifyManager.NativeMethodInfoPtr_RemoveOnMagnifyCallback_Public_Void_MagnifyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664672);
		MagnifyManager.NativeMethodInfoPtr_AddOnUnmagnifyCallback_Public_Void_MagnifyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664673);
		MagnifyManager.NativeMethodInfoPtr_RemoveOnUnmagnifyCallback_Public_Void_MagnifyCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664674);
		MagnifyManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664675);
		MagnifyManager.NativeMethodInfoPtr_PauseForMagnifyManager_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664676);
		MagnifyManager.NativeMethodInfoPtr_SetOverrideLayerObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664677);
		MagnifyManager.NativeMethodInfoPtr_SetOverridePanelObject_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664678);
		MagnifyManager.NativeMethodInfoPtr_SetUseOverrideLayer_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664679);
		MagnifyManager.NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_New_Boolean_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664680);
		MagnifyManager.NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_New_Boolean_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664681);
		MagnifyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, 100664682);
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x0004FAB8 File Offset: 0x0004DCB8
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual AnimationLocator GetMagnifyCardLocator(CardObject magnifyCard)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MagnifyManager.NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_New_AnimationLocator_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr3) : null;
		}
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x0004FB14 File Offset: 0x0004DD14
	[CallerCount(0)]
	public unsafe CardObject GetMagnifiedCard()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_GetMagnifiedCard_Public_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr3) : null;
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x0004FB54 File Offset: 0x0004DD54
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 242958, RefRangeEnd = 242961, XrefRangeStart = 242955, XrefRangeEnd = 242958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnMagnifyCallback(MagnifyManager.MagnifyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_AddOnMagnifyCallback_Public_Void_MagnifyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x0004FB98 File Offset: 0x0004DD98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242961, XrefRangeEnd = 242964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnMagnifyCallback(MagnifyManager.MagnifyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_RemoveOnMagnifyCallback_Public_Void_MagnifyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x0004FBDC File Offset: 0x0004DDDC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 242967, RefRangeEnd = 242970, XrefRangeStart = 242964, XrefRangeEnd = 242967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AddOnUnmagnifyCallback(MagnifyManager.MagnifyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_AddOnUnmagnifyCallback_Public_Void_MagnifyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x0004FC20 File Offset: 0x0004DE20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242970, XrefRangeEnd = 242973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveOnUnmagnifyCallback(MagnifyManager.MagnifyCallback callback)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_RemoveOnUnmagnifyCallback_Public_Void_MagnifyCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x0004FC64 File Offset: 0x0004DE64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242973, XrefRangeEnd = 242978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x0004FC98 File Offset: 0x0004DE98
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 242982, RefRangeEnd = 242983, XrefRangeStart = 242978, XrefRangeEnd = 242982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool PauseForMagnifyManager()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_PauseForMagnifyManager_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x0004FCD4 File Offset: 0x0004DED4
	[CallerCount(0)]
	public unsafe void SetOverrideLayerObject(GameObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_SetOverrideLayerObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x0004FD18 File Offset: 0x0004DF18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetOverridePanelObject(GameObject obj)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_SetOverridePanelObject_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x0004FD5C File Offset: 0x0004DF5C
	[CallerCount(0)]
	public unsafe void SetUseOverrideLayer(bool bUseLayer)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bUseLayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr_SetUseOverrideLayer_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x0004FD9C File Offset: 0x0004DF9C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243007, RefRangeEnd = 243008, XrefRangeStart = 242983, XrefRangeEnd = 243007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool StartMagnifyCard(CardObject magnify_card)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnify_card);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MagnifyManager.NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_New_Boolean_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x0004FDF4 File Offset: 0x0004DFF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 243042, RefRangeEnd = 243043, XrefRangeStart = 243008, XrefRangeEnd = 243042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual bool RemoveMagnifiedCard(CardObject magnify)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnify);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MagnifyManager.NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_New_Boolean_CardObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x0004FE4C File Offset: 0x0004E04C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MagnifyManager()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x0000BFFE File Offset: 0x0000A1FE
	public MagnifyManager(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C5 RID: 1477
	// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004FE88 File Offset: 0x0004E088
	// (set) Token: 0x060011E7 RID: 4583 RVA: 0x0000C007 File Offset: 0x0000A207
	public unsafe GameObject m_MagnifyCardPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C6 RID: 1478
	// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0004FEB8 File Offset: 0x0004E0B8
	// (set) Token: 0x060011E9 RID: 4585 RVA: 0x0000C026 File Offset: 0x0000A226
	public unsafe GameObject m_MagnifyCardPanelOverride
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanelOverride);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardPanelOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C7 RID: 1479
	// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004FEE8 File Offset: 0x0004E0E8
	// (set) Token: 0x060011EB RID: 4587 RVA: 0x0000C045 File Offset: 0x0000A245
	public unsafe AnimationLocator m_MagnifyCardLocator
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardLocator);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationLocator>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardLocator), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C8 RID: 1480
	// (get) Token: 0x060011EC RID: 4588 RVA: 0x0004FF18 File Offset: 0x0004E118
	// (set) Token: 0x060011ED RID: 4589 RVA: 0x0000C064 File Offset: 0x0000A264
	public unsafe GameObject m_MagnifyCardOverrideLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardOverrideLayer);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifyCardOverrideLayer), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x060011EE RID: 4590 RVA: 0x0004FF48 File Offset: 0x0004E148
	// (set) Token: 0x060011EF RID: 4591 RVA: 0x0000C083 File Offset: 0x0000A283
	public unsafe CardObject m_MagnifiedCard
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifiedCard);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CardObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_MagnifiedCard), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0004FF78 File Offset: 0x0004E178
	// (set) Token: 0x060011F1 RID: 4593 RVA: 0x0000C0A2 File Offset: 0x0000A2A2
	public unsafe bool m_bUseOverrideLayer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_bUseOverrideLayer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_bUseOverrideLayer)) = value;
		}
	}

	// Token: 0x170005CB RID: 1483
	// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0004FFA0 File Offset: 0x0004E1A0
	// (set) Token: 0x060011F3 RID: 4595 RVA: 0x0000C0BD File Offset: 0x0000A2BD
	public unsafe MagnifyManager.MagnifyCallback m_OnMagnifyCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_OnMagnifyCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MagnifyManager.MagnifyCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_OnMagnifyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CC RID: 1484
	// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0004FFD0 File Offset: 0x0004E1D0
	// (set) Token: 0x060011F5 RID: 4597 RVA: 0x0000C0DC File Offset: 0x0000A2DC
	public unsafe MagnifyManager.MagnifyCallback m_OnUnmagnifyCallback
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_OnUnmagnifyCallback);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MagnifyManager.MagnifyCallback>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MagnifyManager.NativeFieldInfoPtr_m_OnUnmagnifyCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C80 RID: 3200
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyCardPanel;

	// Token: 0x04000C81 RID: 3201
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyCardPanelOverride;

	// Token: 0x04000C82 RID: 3202
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyCardLocator;

	// Token: 0x04000C83 RID: 3203
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifyCardOverrideLayer;

	// Token: 0x04000C84 RID: 3204
	private static readonly IntPtr NativeFieldInfoPtr_m_MagnifiedCard;

	// Token: 0x04000C85 RID: 3205
	private static readonly IntPtr NativeFieldInfoPtr_m_bUseOverrideLayer;

	// Token: 0x04000C86 RID: 3206
	private static readonly IntPtr NativeFieldInfoPtr_m_OnMagnifyCallback;

	// Token: 0x04000C87 RID: 3207
	private static readonly IntPtr NativeFieldInfoPtr_m_OnUnmagnifyCallback;

	// Token: 0x04000C88 RID: 3208
	private static readonly IntPtr NativeMethodInfoPtr_GetMagnifyCardLocator_Public_Virtual_New_AnimationLocator_CardObject_0;

	// Token: 0x04000C89 RID: 3209
	private static readonly IntPtr NativeMethodInfoPtr_GetMagnifiedCard_Public_CardObject_0;

	// Token: 0x04000C8A RID: 3210
	private static readonly IntPtr NativeMethodInfoPtr_AddOnMagnifyCallback_Public_Void_MagnifyCallback_0;

	// Token: 0x04000C8B RID: 3211
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnMagnifyCallback_Public_Void_MagnifyCallback_0;

	// Token: 0x04000C8C RID: 3212
	private static readonly IntPtr NativeMethodInfoPtr_AddOnUnmagnifyCallback_Public_Void_MagnifyCallback_0;

	// Token: 0x04000C8D RID: 3213
	private static readonly IntPtr NativeMethodInfoPtr_RemoveOnUnmagnifyCallback_Public_Void_MagnifyCallback_0;

	// Token: 0x04000C8E RID: 3214
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000C8F RID: 3215
	private static readonly IntPtr NativeMethodInfoPtr_PauseForMagnifyManager_Public_Boolean_0;

	// Token: 0x04000C90 RID: 3216
	private static readonly IntPtr NativeMethodInfoPtr_SetOverrideLayerObject_Public_Void_GameObject_0;

	// Token: 0x04000C91 RID: 3217
	private static readonly IntPtr NativeMethodInfoPtr_SetOverridePanelObject_Public_Void_GameObject_0;

	// Token: 0x04000C92 RID: 3218
	private static readonly IntPtr NativeMethodInfoPtr_SetUseOverrideLayer_Public_Void_Boolean_0;

	// Token: 0x04000C93 RID: 3219
	private static readonly IntPtr NativeMethodInfoPtr_StartMagnifyCard_Public_Virtual_New_Boolean_CardObject_0;

	// Token: 0x04000C94 RID: 3220
	private static readonly IntPtr NativeMethodInfoPtr_RemoveMagnifiedCard_Public_Virtual_New_Boolean_CardObject_0;

	// Token: 0x04000C95 RID: 3221
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000199 RID: 409
	public sealed class MagnifyCallback : MulticastDelegate
	{
		// Token: 0x060024A7 RID: 9383 RVA: 0x00088308 File Offset: 0x00086508
		// Note: this type is marked as 'beforefieldinit'.
		static MagnifyCallback()
		{
			Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MagnifyManager>.NativeClassPtr, "MagnifyCallback");
			MagnifyManager.MagnifyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr, 100666212);
			MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CardObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr, 100666213);
			MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CardObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr, 100666214);
			MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr, 100666215);
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0008837C File Offset: 0x0008657C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MagnifyCallback(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MagnifyManager.MagnifyCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.MagnifyCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x000883D8 File Offset: 0x000865D8
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(CardObject magnifyCard)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CardObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0008841C File Offset: 0x0008661C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(CardObject magnifyCard, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(magnifyCard);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CardObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x00088490 File Offset: 0x00086690
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MagnifyManager.MagnifyCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x00016C31 File Offset: 0x00014E31
		public MagnifyCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x00016C3A File Offset: 0x00014E3A
		public static implicit operator MagnifyManager.MagnifyCallback(Action<CardObject> A_0)
		{
			return DelegateSupport.ConvertDelegate<MagnifyManager.MagnifyCallback>(A_0);
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x00016C42 File Offset: 0x00014E42
		public static MagnifyManager.MagnifyCallback operator +(MagnifyManager.MagnifyCallback A_0, MagnifyManager.MagnifyCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MagnifyManager.MagnifyCallback>();
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x00016C50 File Offset: 0x00014E50
		public static MagnifyManager.MagnifyCallback operator -(MagnifyManager.MagnifyCallback A_0, MagnifyManager.MagnifyCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MagnifyManager.MagnifyCallback>();
			}
			return delegate2;
		}

		// Token: 0x04001966 RID: 6502
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04001967 RID: 6503
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_CardObject_0;

		// Token: 0x04001968 RID: 6504
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_CardObject_AsyncCallback_Object_0;

		// Token: 0x04001969 RID: 6505
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
