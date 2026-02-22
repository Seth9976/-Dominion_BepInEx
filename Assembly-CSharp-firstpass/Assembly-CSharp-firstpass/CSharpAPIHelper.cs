using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000118 RID: 280
public class CSharpAPIHelper : MonoBehaviour
{
	// Token: 0x0600131F RID: 4895 RVA: 0x00059080 File Offset: 0x00057280
	// Note: this type is marked as 'beforefieldinit'.
	static CSharpAPIHelper()
	{
		Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "CSharpAPIHelper");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr);
		CSharpAPIHelper.NativeMethodInfoPtr_ConnectToPlaySertivce_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr, 100665594);
		CSharpAPIHelper.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr, 100665595);
		CSharpAPIHelper.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr, 100665596);
		CSharpAPIHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr, 100665597);
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x00059100 File Offset: 0x00057300
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183783, XrefRangeEnd = 183821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ConnectToPlaySertivce()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSharpAPIHelper.NativeMethodInfoPtr_ConnectToPlaySertivce_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001321 RID: 4897 RVA: 0x00059134 File Offset: 0x00057334
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183821, XrefRangeEnd = 183826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSharpAPIHelper.NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x00059168 File Offset: 0x00057368
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183826, XrefRangeEnd = 183831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnPlayerDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSharpAPIHelper.NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x0005919C File Offset: 0x0005739C
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CSharpAPIHelper()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CSharpAPIHelper>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CSharpAPIHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x00009790 File Offset: 0x00007990
	public CSharpAPIHelper(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000E9D RID: 3741
	private static readonly IntPtr NativeMethodInfoPtr_ConnectToPlaySertivce_Public_Void_0;

	// Token: 0x04000E9E RID: 3742
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerConnected_Private_Void_0;

	// Token: 0x04000E9F RID: 3743
	private static readonly IntPtr NativeMethodInfoPtr_OnPlayerDisconnected_Private_Void_0;

	// Token: 0x04000EA0 RID: 3744
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
