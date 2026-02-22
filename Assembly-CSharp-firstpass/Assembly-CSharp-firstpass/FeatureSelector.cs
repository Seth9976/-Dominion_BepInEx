using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000113 RID: 275
public class FeatureSelector : MonoBehaviour
{
	// Token: 0x060012E5 RID: 4837 RVA: 0x000586A0 File Offset: 0x000568A0
	// Note: this type is marked as 'beforefieldinit'.
	static FeatureSelector()
	{
		Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FeatureSelector");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr);
		FeatureSelector.NativeFieldInfoPtr_Selector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr, "Selector");
		FeatureSelector.NativeFieldInfoPtr_Tab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr, "Tab");
		FeatureSelector.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr, 100665578);
		FeatureSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr, 100665579);
		FeatureSelector.NativeMethodInfoPtr__Start_b__2_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr, 100665580);
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x00058734 File Offset: 0x00056934
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183679, XrefRangeEnd = 183694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureSelector.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x00058768 File Offset: 0x00056968
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FeatureSelector()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureSelector>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x000587A4 File Offset: 0x000569A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183694, XrefRangeEnd = 183699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Start_b__2_0(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureSelector.NativeMethodInfoPtr__Start_b__2_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0000957B File Offset: 0x0000777B
	public FeatureSelector(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x060012EA RID: 4842 RVA: 0x000587E4 File Offset: 0x000569E4
	// (set) Token: 0x060012EB RID: 4843 RVA: 0x00009584 File Offset: 0x00007784
	public unsafe Toggle Selector
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureSelector.NativeFieldInfoPtr_Selector);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureSelector.NativeFieldInfoPtr_Selector), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000591 RID: 1425
	// (get) Token: 0x060012EC RID: 4844 RVA: 0x00058814 File Offset: 0x00056A14
	// (set) Token: 0x060012ED RID: 4845 RVA: 0x000095A3 File Offset: 0x000077A3
	public unsafe FeatureTab Tab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureSelector.NativeFieldInfoPtr_Tab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FeatureTab>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FeatureSelector.NativeFieldInfoPtr_Tab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000E7D RID: 3709
	private static readonly IntPtr NativeFieldInfoPtr_Selector;

	// Token: 0x04000E7E RID: 3710
	private static readonly IntPtr NativeFieldInfoPtr_Tab;

	// Token: 0x04000E7F RID: 3711
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000E80 RID: 3712
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000E81 RID: 3713
	private static readonly IntPtr NativeMethodInfoPtr__Start_b__2_0_Private_Void_Boolean_0;
}
