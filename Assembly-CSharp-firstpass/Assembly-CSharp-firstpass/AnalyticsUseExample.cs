using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200011C RID: 284
public class AnalyticsUseExample : MonoBehaviour
{
	// Token: 0x06001396 RID: 5014 RVA: 0x0005A7E4 File Offset: 0x000589E4
	// Note: this type is marked as 'beforefieldinit'.
	static AnalyticsUseExample()
	{
		Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AnalyticsUseExample");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr);
		AnalyticsUseExample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr, 100665641);
		AnalyticsUseExample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr, 100665642);
		AnalyticsUseExample.NativeMethodInfoPtr_PurchaseTackingExample_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr, 100665643);
		AnalyticsUseExample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr, 100665644);
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x0005A864 File Offset: 0x00058A64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184703, XrefRangeEnd = 184711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsUseExample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x0005A898 File Offset: 0x00058A98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184711, XrefRangeEnd = 184779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsUseExample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x0005A8CC File Offset: 0x00058ACC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184779, XrefRangeEnd = 184803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PurchaseTackingExample()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsUseExample.NativeMethodInfoPtr_PurchaseTackingExample_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x0005A900 File Offset: 0x00058B00
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AnalyticsUseExample()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnalyticsUseExample>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnalyticsUseExample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x00009B94 File Offset: 0x00007D94
	public AnalyticsUseExample(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000EEC RID: 3820
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000EED RID: 3821
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000EEE RID: 3822
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseTackingExample_Public_Void_0;

	// Token: 0x04000EEF RID: 3823
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
