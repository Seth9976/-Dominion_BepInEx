using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x0200010B RID: 267
public class AndroidAdMobBannerInterstitial : MonoBehaviour
{
	// Token: 0x06001232 RID: 4658 RVA: 0x00056434 File Offset: 0x00054634
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidAdMobBannerInterstitial()
	{
		Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidAdMobBannerInterstitial");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr);
		AndroidAdMobBannerInterstitial.NativeFieldInfoPtr_InterstitialUnityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, "InterstitialUnityId");
		AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, 100665499);
		AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, 100665500);
		AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_ShowBanner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, 100665501);
		AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, 100665502);
		AndroidAdMobBannerInterstitial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr, 100665503);
	}

	// Token: 0x06001233 RID: 4659 RVA: 0x000564DC File Offset: 0x000546DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182578, XrefRangeEnd = 182589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001234 RID: 4660 RVA: 0x00056510 File Offset: 0x00054710
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182589, XrefRangeEnd = 182590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001235 RID: 4661 RVA: 0x00056544 File Offset: 0x00054744
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182618, RefRangeEnd = 182619, XrefRangeStart = 182590, XrefRangeEnd = 182618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowBanner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_ShowBanner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000561 RID: 1377
	// (get) Token: 0x06001236 RID: 4662 RVA: 0x00056578 File Offset: 0x00054778
	public unsafe string sceneBannerId
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182619, XrefRangeEnd = 182629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBannerInterstitial.NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001237 RID: 4663 RVA: 0x000565B0 File Offset: 0x000547B0
	[CallerCount(53)]
	[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidAdMobBannerInterstitial()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAdMobBannerInterstitial>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBannerInterstitial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001238 RID: 4664 RVA: 0x0000909F File Offset: 0x0000729F
	public AndroidAdMobBannerInterstitial(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000560 RID: 1376
	// (get) Token: 0x06001239 RID: 4665 RVA: 0x000565EC File Offset: 0x000547EC
	// (set) Token: 0x0600123A RID: 4666 RVA: 0x000090A8 File Offset: 0x000072A8
	public unsafe string InterstitialUnityId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBannerInterstitial.NativeFieldInfoPtr_InterstitialUnityId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBannerInterstitial.NativeFieldInfoPtr_InterstitialUnityId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000E05 RID: 3589
	private static readonly IntPtr NativeFieldInfoPtr_InterstitialUnityId;

	// Token: 0x04000E06 RID: 3590
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000E07 RID: 3591
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000E08 RID: 3592
	private static readonly IntPtr NativeMethodInfoPtr_ShowBanner_Public_Void_0;

	// Token: 0x04000E09 RID: 3593
	private static readonly IntPtr NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0;

	// Token: 0x04000E0A RID: 3594
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
