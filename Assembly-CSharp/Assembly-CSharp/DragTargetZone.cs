using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x02000088 RID: 136
public class DragTargetZone : MonoBehaviour
{
	// Token: 0x0600112A RID: 4394 RVA: 0x0004D3D0 File Offset: 0x0004B5D0
	// Note: this type is marked as 'beforefieldinit'.
	static DragTargetZone()
	{
		Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DragTargetZone");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr);
		DragTargetZone.NativeFieldInfoPtr_m_DragTargetInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, "m_DragTargetInstanceID");
		DragTargetZone.NativeFieldInfoPtr_m_DragSelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, "m_DragSelectionHint");
		DragTargetZone.NativeFieldInfoPtr_m_DragSelectionOverrideID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, "m_DragSelectionOverrideID");
		DragTargetZone.NativeFieldInfoPtr_m_TargetGlowObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, "m_TargetGlowObject");
		DragTargetZone.NativeFieldInfoPtr_m_ActivateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, "m_ActivateList");
		DragTargetZone.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664591);
		DragTargetZone.NativeMethodInfoPtr_GetDragTargetInstanceID_Public_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664592);
		DragTargetZone.NativeMethodInfoPtr_SetDragTargetInstanceID_Public_Void_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664593);
		DragTargetZone.NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_Color_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664594);
		DragTargetZone.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664595);
		DragTargetZone.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664596);
		DragTargetZone.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664597);
		DragTargetZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr, 100664598);
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x0004D504 File Offset: 0x0004B704
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242245, XrefRangeEnd = 242247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x0004D538 File Offset: 0x0004B738
	[CallerCount(0)]
	public unsafe ushort GetDragTargetInstanceID()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_GetDragTargetInstanceID_Public_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x0004D574 File Offset: 0x0004B774
	[CallerCount(0)]
	public unsafe void SetDragTargetInstanceID(ushort instance_id)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref instance_id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_SetDragTargetInstanceID_Public_Void_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x0004D5B4 File Offset: 0x0004B7B4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 242261, RefRangeEnd = 242267, XrefRangeStart = 242247, XrefRangeEnd = 242261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetDragSelectionHint(ushort hint, Color hintColor, ushort overrideID = 0)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref hint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hintColor;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideID;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_Color_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x0004D610 File Offset: 0x0004B810
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242267, XrefRangeEnd = 242278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerEnter(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x0004D654 File Offset: 0x0004B854
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242278, XrefRangeEnd = 242289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnPointerExit(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x0004D698 File Offset: 0x0004B898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242289, XrefRangeEnd = 242300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrop(PointerEventData eventData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x0004D6DC File Offset: 0x0004B8DC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragTargetZone()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragTargetZone>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragTargetZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x0000BB69 File Offset: 0x00009D69
	public DragTargetZone(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700059D RID: 1437
	// (get) Token: 0x06001134 RID: 4404 RVA: 0x0004D718 File Offset: 0x0004B918
	// (set) Token: 0x06001135 RID: 4405 RVA: 0x0000BB72 File Offset: 0x00009D72
	public unsafe ushort m_DragTargetInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragTargetInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragTargetInstanceID)) = value;
		}
	}

	// Token: 0x1700059E RID: 1438
	// (get) Token: 0x06001136 RID: 4406 RVA: 0x0004D740 File Offset: 0x0004B940
	// (set) Token: 0x06001137 RID: 4407 RVA: 0x0000BB8D File Offset: 0x00009D8D
	public unsafe ushort m_DragSelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragSelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragSelectionHint)) = value;
		}
	}

	// Token: 0x1700059F RID: 1439
	// (get) Token: 0x06001138 RID: 4408 RVA: 0x0004D768 File Offset: 0x0004B968
	// (set) Token: 0x06001139 RID: 4409 RVA: 0x0000BBA8 File Offset: 0x00009DA8
	public unsafe ushort m_DragSelectionOverrideID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragSelectionOverrideID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_DragSelectionOverrideID)) = value;
		}
	}

	// Token: 0x170005A0 RID: 1440
	// (get) Token: 0x0600113A RID: 4410 RVA: 0x0004D790 File Offset: 0x0004B990
	// (set) Token: 0x0600113B RID: 4411 RVA: 0x0000BBC3 File Offset: 0x00009DC3
	public unsafe GameObject m_TargetGlowObject
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_TargetGlowObject);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_TargetGlowObject), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005A1 RID: 1441
	// (get) Token: 0x0600113C RID: 4412 RVA: 0x0004D7C0 File Offset: 0x0004B9C0
	// (set) Token: 0x0600113D RID: 4413 RVA: 0x0000BBE2 File Offset: 0x00009DE2
	public unsafe Il2CppReferenceArray<GameObject> m_ActivateList
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_ActivateList);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragTargetZone.NativeFieldInfoPtr_m_ActivateList), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000C04 RID: 3076
	private static readonly IntPtr NativeFieldInfoPtr_m_DragTargetInstanceID;

	// Token: 0x04000C05 RID: 3077
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionHint;

	// Token: 0x04000C06 RID: 3078
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionOverrideID;

	// Token: 0x04000C07 RID: 3079
	private static readonly IntPtr NativeFieldInfoPtr_m_TargetGlowObject;

	// Token: 0x04000C08 RID: 3080
	private static readonly IntPtr NativeFieldInfoPtr_m_ActivateList;

	// Token: 0x04000C09 RID: 3081
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

	// Token: 0x04000C0A RID: 3082
	private static readonly IntPtr NativeMethodInfoPtr_GetDragTargetInstanceID_Public_UInt16_0;

	// Token: 0x04000C0B RID: 3083
	private static readonly IntPtr NativeMethodInfoPtr_SetDragTargetInstanceID_Public_Void_UInt16_0;

	// Token: 0x04000C0C RID: 3084
	private static readonly IntPtr NativeMethodInfoPtr_SetDragSelectionHint_Public_Void_UInt16_Color_UInt16_0;

	// Token: 0x04000C0D RID: 3085
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerEnter_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000C0E RID: 3086
	private static readonly IntPtr NativeMethodInfoPtr_OnPointerExit_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000C0F RID: 3087
	private static readonly IntPtr NativeMethodInfoPtr_OnDrop_Public_Virtual_Final_New_Void_PointerEventData_0;

	// Token: 0x04000C10 RID: 3088
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
