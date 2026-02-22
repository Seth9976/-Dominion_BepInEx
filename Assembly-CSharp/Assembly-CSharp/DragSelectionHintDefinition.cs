using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000035 RID: 53
public class DragSelectionHintDefinition : global::Il2CppSystem.Object
{
	// Token: 0x06000994 RID: 2452 RVA: 0x00036368 File Offset: 0x00034568
	// Note: this type is marked as 'beforefieldinit'.
	static DragSelectionHintDefinition()
	{
		Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DragSelectionHintDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr);
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_SelectionHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_SelectionHint");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_DragTargetZoneIndex");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneShortcut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_DragTargetZoneShortcut");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_bUseTargetZoneInstanceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_bUseTargetZoneInstanceID");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_bDragReturnOnSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_bDragReturnOnSelection");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_HighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_HighlightColor");
		DragSelectionHintDefinition.NativeFieldInfoPtr_m_OptionTextDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, "m_OptionTextDisplay");
		DragSelectionHintDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_Color_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr, 100663955);
	}

	// Token: 0x06000995 RID: 2453 RVA: 0x00036438 File Offset: 0x00034638
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235800, XrefRangeEnd = 235801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DragSelectionHintDefinition(int selectionHint, int dragTargetZoneIndex, int dragTargetZoneShortcut, bool bUseTargetZoneInstanceID, bool bDragReturnOnSelection, Color highlightColor, string optionTextDisplay)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DragSelectionHintDefinition>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragTargetZoneIndex;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dragTargetZoneShortcut;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseTargetZoneInstanceID;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bDragReturnOnSelection;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref highlightColor;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(optionTextDisplay);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DragSelectionHintDefinition.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_Color_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000996 RID: 2454 RVA: 0x00007E19 File Offset: 0x00006019
	public DragSelectionHintDefinition(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000357 RID: 855
	// (get) Token: 0x06000997 RID: 2455 RVA: 0x000364D8 File Offset: 0x000346D8
	// (set) Token: 0x06000998 RID: 2456 RVA: 0x00007E22 File Offset: 0x00006022
	public unsafe int m_SelectionHint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_SelectionHint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_SelectionHint)) = value;
		}
	}

	// Token: 0x17000358 RID: 856
	// (get) Token: 0x06000999 RID: 2457 RVA: 0x00036500 File Offset: 0x00034700
	// (set) Token: 0x0600099A RID: 2458 RVA: 0x00007E3D File Offset: 0x0000603D
	public unsafe int m_DragTargetZoneIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneIndex)) = value;
		}
	}

	// Token: 0x17000359 RID: 857
	// (get) Token: 0x0600099B RID: 2459 RVA: 0x00036528 File Offset: 0x00034728
	// (set) Token: 0x0600099C RID: 2460 RVA: 0x00007E58 File Offset: 0x00006058
	public unsafe int m_DragTargetZoneShortcut
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneShortcut);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_DragTargetZoneShortcut)) = value;
		}
	}

	// Token: 0x1700035A RID: 858
	// (get) Token: 0x0600099D RID: 2461 RVA: 0x00036550 File Offset: 0x00034750
	// (set) Token: 0x0600099E RID: 2462 RVA: 0x00007E73 File Offset: 0x00006073
	public unsafe bool m_bUseTargetZoneInstanceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_bUseTargetZoneInstanceID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_bUseTargetZoneInstanceID)) = value;
		}
	}

	// Token: 0x1700035B RID: 859
	// (get) Token: 0x0600099F RID: 2463 RVA: 0x00036578 File Offset: 0x00034778
	// (set) Token: 0x060009A0 RID: 2464 RVA: 0x00007E8E File Offset: 0x0000608E
	public unsafe bool m_bDragReturnOnSelection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_bDragReturnOnSelection);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_bDragReturnOnSelection)) = value;
		}
	}

	// Token: 0x1700035C RID: 860
	// (get) Token: 0x060009A1 RID: 2465 RVA: 0x000365A0 File Offset: 0x000347A0
	// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00007EA9 File Offset: 0x000060A9
	public unsafe Color m_HighlightColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_HighlightColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_HighlightColor)) = value;
		}
	}

	// Token: 0x1700035D RID: 861
	// (get) Token: 0x060009A3 RID: 2467 RVA: 0x000365C8 File Offset: 0x000347C8
	// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00007EC4 File Offset: 0x000060C4
	public unsafe string m_OptionTextDisplay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_OptionTextDisplay);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DragSelectionHintDefinition.NativeFieldInfoPtr_m_OptionTextDisplay), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040005F5 RID: 1525
	private static readonly IntPtr NativeFieldInfoPtr_m_SelectionHint;

	// Token: 0x040005F6 RID: 1526
	private static readonly IntPtr NativeFieldInfoPtr_m_DragTargetZoneIndex;

	// Token: 0x040005F7 RID: 1527
	private static readonly IntPtr NativeFieldInfoPtr_m_DragTargetZoneShortcut;

	// Token: 0x040005F8 RID: 1528
	private static readonly IntPtr NativeFieldInfoPtr_m_bUseTargetZoneInstanceID;

	// Token: 0x040005F9 RID: 1529
	private static readonly IntPtr NativeFieldInfoPtr_m_bDragReturnOnSelection;

	// Token: 0x040005FA RID: 1530
	private static readonly IntPtr NativeFieldInfoPtr_m_HighlightColor;

	// Token: 0x040005FB RID: 1531
	private static readonly IntPtr NativeFieldInfoPtr_m_OptionTextDisplay;

	// Token: 0x040005FC RID: 1532
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Boolean_Boolean_Color_String_0;
}
