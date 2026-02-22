using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200001F RID: 31
public class AscensionDrawPile : DragObject
{
	// Token: 0x060005B8 RID: 1464 RVA: 0x0002B120 File Offset: 0x00029320
	// Note: this type is marked as 'beforefieldinit'.
	static AscensionDrawPile()
	{
		Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "AscensionDrawPile");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr);
		AscensionDrawPile.NativeFieldInfoPtr_m_CardManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, "m_CardManager");
		AscensionDrawPile.NativeFieldInfoPtr_m_SelectableGlowObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, "m_SelectableGlowObject");
		AscensionDrawPile.NativeFieldInfoPtr_m_DrawPileInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, "m_DrawPileInstanceID");
		AscensionDrawPile.NativeMethodInfoPtr_SetDrawPileInstanceID_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663683);
		AscensionDrawPile.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663684);
		AscensionDrawPile.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663685);
		AscensionDrawPile.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663686);
		AscensionDrawPile.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663687);
		AscensionDrawPile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr, 100663688);
	}

	// Token: 0x060005B9 RID: 1465 RVA: 0x0002B204 File Offset: 0x00029404
	[CallerCount(0)]
	public unsafe void SetDrawPileInstanceID(ushort instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr_SetDrawPileInstanceID_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005BA RID: 1466 RVA: 0x0002B244 File Offset: 0x00029444
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229598, XrefRangeEnd = 229610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005BB RID: 1467 RVA: 0x0002B278 File Offset: 0x00029478
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 229652, RefRangeEnd = 229655, XrefRangeStart = 229610, XrefRangeEnd = 229652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpdateSelectionState(bool bHighlight)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref bHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060005BC RID: 1468 RVA: 0x0002B2B8 File Offset: 0x000294B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229655, XrefRangeEnd = 229714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005BD RID: 1469 RVA: 0x0002B30C File Offset: 0x0002950C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229714, XrefRangeEnd = 229732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void EndDragCallback(DragObject dragObject, PointerEventData eventData)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005BE RID: 1470 RVA: 0x0002B360 File Offset: 0x00029560
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 229732, XrefRangeEnd = 229733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AscensionDrawPile()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AscensionDrawPile>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AscensionDrawPile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060005BF RID: 1471 RVA: 0x000056A7 File Offset: 0x000038A7
	public AscensionDrawPile(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000206 RID: 518
	// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0002B39C File Offset: 0x0002959C
	// (set) Token: 0x060005C1 RID: 1473 RVA: 0x000056B0 File Offset: 0x000038B0
	public unsafe AscensionCardManager m_CardManager
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_CardManager);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AscensionCardManager>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_CardManager), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000207 RID: 519
	// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002B3CC File Offset: 0x000295CC
	// (set) Token: 0x060005C3 RID: 1475 RVA: 0x000056CF File Offset: 0x000038CF
	public unsafe GameObject m_SelectableGlowObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_SelectableGlowObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_SelectableGlowObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000208 RID: 520
	// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0002B3FC File Offset: 0x000295FC
	// (set) Token: 0x060005C5 RID: 1477 RVA: 0x000056EE File Offset: 0x000038EE
	public unsafe ushort m_DrawPileInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_DrawPileInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AscensionDrawPile.NativeFieldInfoPtr_m_DrawPileInstanceID)) = value;
		}
	}

	// Token: 0x0400038F RID: 911
	private static readonly IntPtr NativeFieldInfoPtr_m_CardManager;

	// Token: 0x04000390 RID: 912
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectableGlowObject;

	// Token: 0x04000391 RID: 913
	private static readonly IntPtr NativeFieldInfoPtr_m_DrawPileInstanceID;

	// Token: 0x04000392 RID: 914
	private static readonly IntPtr NativeMethodInfoPtr_SetDrawPileInstanceID_Public_Void_UInt16_0;

	// Token: 0x04000393 RID: 915
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000394 RID: 916
	private static readonly IntPtr NativeMethodInfoPtr_UpdateSelectionState_Public_Void_Boolean_0;

	// Token: 0x04000395 RID: 917
	private static readonly IntPtr NativeMethodInfoPtr_BeginDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000396 RID: 918
	private static readonly IntPtr NativeMethodInfoPtr_EndDragCallback_Private_Void_DragObject_PointerEventData_0;

	// Token: 0x04000397 RID: 919
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
