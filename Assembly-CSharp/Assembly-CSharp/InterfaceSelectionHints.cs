using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000036 RID: 54
public class InterfaceSelectionHints : MonoBehaviour
{
	// Token: 0x060009A5 RID: 2469 RVA: 0x000365F0 File Offset: 0x000347F0
	// Note: this type is marked as 'beforefieldinit'.
	static InterfaceSelectionHints()
	{
		Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "InterfaceSelectionHints");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr);
		InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr, "m_DragSelectionHintMapping");
		InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr, "m_DragSelectionHintDictionary");
		InterfaceSelectionHints.NativeMethodInfoPtr_BuildDictionary_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr, 100663956);
		InterfaceSelectionHints.NativeMethodInfoPtr_FindSelectionHintDefinition_Public_Static_DragSelectionHintDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr, 100663957);
		InterfaceSelectionHints.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr, 100663958);
	}

	// Token: 0x060009A6 RID: 2470 RVA: 0x00036684 File Offset: 0x00034884
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235801, XrefRangeEnd = 235821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void BuildDictionary()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceSelectionHints.NativeMethodInfoPtr_BuildDictionary_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009A7 RID: 2471 RVA: 0x000366AC File Offset: 0x000348AC
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 235851, RefRangeEnd = 235862, XrefRangeStart = 235821, XrefRangeEnd = 235851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static DragSelectionHintDefinition FindSelectionHintDefinition(int selectionHint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref selectionHint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceSelectionHints.NativeMethodInfoPtr_FindSelectionHintDefinition_Public_Static_DragSelectionHintDefinition_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DragSelectionHintDefinition>(intPtr3) : null;
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x000366EC File Offset: 0x000348EC
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe InterfaceSelectionHints()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InterfaceSelectionHints>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InterfaceSelectionHints.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x00007EE3 File Offset: 0x000060E3
	public InterfaceSelectionHints(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700035E RID: 862
	// (get) Token: 0x060009AA RID: 2474 RVA: 0x00036728 File Offset: 0x00034928
	// (set) Token: 0x060009AB RID: 2475 RVA: 0x00007EEC File Offset: 0x000060EC
	public unsafe static Il2CppReferenceArray<DragSelectionHintDefinition> m_DragSelectionHintMapping
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintMapping, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DragSelectionHintDefinition>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintMapping, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700035F RID: 863
	// (get) Token: 0x060009AC RID: 2476 RVA: 0x00036750 File Offset: 0x00034950
	// (set) Token: 0x060009AD RID: 2477 RVA: 0x00007EFE File Offset: 0x000060FE
	public unsafe static Dictionary<int, DragSelectionHintDefinition> m_DragSelectionHintDictionary
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintDictionary, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DragSelectionHintDefinition>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(InterfaceSelectionHints.NativeFieldInfoPtr_m_DragSelectionHintDictionary, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040005FD RID: 1533
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionHintMapping;

	// Token: 0x040005FE RID: 1534
	private static readonly IntPtr NativeFieldInfoPtr_m_DragSelectionHintDictionary;

	// Token: 0x040005FF RID: 1535
	private static readonly IntPtr NativeMethodInfoPtr_BuildDictionary_Private_Static_Void_0;

	// Token: 0x04000600 RID: 1536
	private static readonly IntPtr NativeMethodInfoPtr_FindSelectionHintDefinition_Public_Static_DragSelectionHintDefinition_Int32_0;

	// Token: 0x04000601 RID: 1537
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
