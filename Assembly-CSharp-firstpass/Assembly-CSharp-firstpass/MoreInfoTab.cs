using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000120 RID: 288
public sealed class MoreInfoTab : FeatureTab
{
	// Token: 0x060013DD RID: 5085 RVA: 0x0005B9C8 File Offset: 0x00059BC8
	// Note: this type is marked as 'beforefieldinit'.
	static MoreInfoTab()
	{
		Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "MoreInfoTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr);
		MoreInfoTab.NativeMethodInfoPtr_OnAskQuestionsClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr, 100665694);
		MoreInfoTab.NativeMethodInfoPtr_OnGetPluginsClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr, 100665695);
		MoreInfoTab.NativeMethodInfoPtr_OnDocumentationClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr, 100665696);
		MoreInfoTab.NativeMethodInfoPtr_OnMorePluginsClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr, 100665697);
		MoreInfoTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr, 100665698);
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x0005BA5C File Offset: 0x00059C5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185845, XrefRangeEnd = 185857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnAskQuestionsClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreInfoTab.NativeMethodInfoPtr_OnAskQuestionsClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x0005BA90 File Offset: 0x00059C90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185857, XrefRangeEnd = 185860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGetPluginsClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreInfoTab.NativeMethodInfoPtr_OnGetPluginsClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E0 RID: 5088 RVA: 0x0005BAC4 File Offset: 0x00059CC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185860, XrefRangeEnd = 185863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDocumentationClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreInfoTab.NativeMethodInfoPtr_OnDocumentationClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x0005BAF8 File Offset: 0x00059CF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 185863, XrefRangeEnd = 185866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMorePluginsClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreInfoTab.NativeMethodInfoPtr_OnMorePluginsClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x0005BB2C File Offset: 0x00059D2C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MoreInfoTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoreInfoTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MoreInfoTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x00009C53 File Offset: 0x00007E53
	public MoreInfoTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000F26 RID: 3878
	private static readonly IntPtr NativeMethodInfoPtr_OnAskQuestionsClick_Public_Void_0;

	// Token: 0x04000F27 RID: 3879
	private static readonly IntPtr NativeMethodInfoPtr_OnGetPluginsClick_Public_Void_0;

	// Token: 0x04000F28 RID: 3880
	private static readonly IntPtr NativeMethodInfoPtr_OnDocumentationClick_Public_Void_0;

	// Token: 0x04000F29 RID: 3881
	private static readonly IntPtr NativeMethodInfoPtr_OnMorePluginsClick_Public_Void_0;

	// Token: 0x04000F2A RID: 3882
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
