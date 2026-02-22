using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000138 RID: 312
public class GD_DocDataRertivalExamle : MonoBehaviour
{
	// Token: 0x06001722 RID: 5922 RVA: 0x00066814 File Offset: 0x00064A14
	// Note: this type is marked as 'beforefieldinit'.
	static GD_DocDataRertivalExamle()
	{
		Il2CppClassPointerStore<GD_DocDataRertivalExamle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GD_DocDataRertivalExamle");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GD_DocDataRertivalExamle>.NativeClassPtr);
		GD_DocDataRertivalExamle.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocDataRertivalExamle>.NativeClassPtr, 100666090);
		GD_DocDataRertivalExamle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GD_DocDataRertivalExamle>.NativeClassPtr, 100666091);
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x0006686C File Offset: 0x00064A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193891, XrefRangeEnd = 193949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocDataRertivalExamle.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x000668A0 File Offset: 0x00064AA0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GD_DocDataRertivalExamle()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GD_DocDataRertivalExamle>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GD_DocDataRertivalExamle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x0000B40C File Offset: 0x0000960C
	public GD_DocDataRertivalExamle(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04001175 RID: 4469
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04001176 RID: 4470
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
