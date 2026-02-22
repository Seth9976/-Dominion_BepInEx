using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000114 RID: 276
public class FeatureTab : MonoBehaviour
{
	// Token: 0x060012EE RID: 4846 RVA: 0x00058844 File Offset: 0x00056A44
	// Note: this type is marked as 'beforefieldinit'.
	static FeatureTab()
	{
		Il2CppClassPointerStore<FeatureTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "FeatureTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeatureTab>.NativeClassPtr);
		FeatureTab.NativeMethodInfoPtr_Show_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureTab>.NativeClassPtr, 100665581);
		FeatureTab.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureTab>.NativeClassPtr, 100665582);
		FeatureTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeatureTab>.NativeClassPtr, 100665583);
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x000588B0 File Offset: 0x00056AB0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 183702, RefRangeEnd = 183706, XrefRangeStart = 183699, XrefRangeEnd = 183702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureTab.NativeMethodInfoPtr_Show_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x000588E4 File Offset: 0x00056AE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 183709, RefRangeEnd = 183710, XrefRangeStart = 183706, XrefRangeEnd = 183709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureTab.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x00058918 File Offset: 0x00056B18
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FeatureTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeatureTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeatureTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x000095C2 File Offset: 0x000077C2
	public FeatureTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000E82 RID: 3714
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Void_0;

	// Token: 0x04000E83 RID: 3715
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

	// Token: 0x04000E84 RID: 3716
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
