using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200010A RID: 266
public class AndroidAdMobBanner : MonoBehaviour
{
	// Token: 0x06001220 RID: 4640 RVA: 0x000560C8 File Offset: 0x000542C8
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidAdMobBanner()
	{
		Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidAdMobBanner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr);
		AndroidAdMobBanner.NativeFieldInfoPtr_BannersUnityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, "BannersUnityId");
		AndroidAdMobBanner.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, "size");
		AndroidAdMobBanner.NativeFieldInfoPtr_anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, "anchor");
		AndroidAdMobBanner.NativeFieldInfoPtr__refisterdBanners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, "_refisterdBanners");
		AndroidAdMobBanner.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665490);
		AndroidAdMobBanner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665491);
		AndroidAdMobBanner.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665492);
		AndroidAdMobBanner.NativeMethodInfoPtr_ShowBanner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665493);
		AndroidAdMobBanner.NativeMethodInfoPtr_HideBanner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665494);
		AndroidAdMobBanner.NativeMethodInfoPtr_get_registerdBanners_Public_Static_get_Dictionary_2_String_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665495);
		AndroidAdMobBanner.NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665496);
		AndroidAdMobBanner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr, 100665497);
	}

	// Token: 0x06001221 RID: 4641 RVA: 0x000561E8 File Offset: 0x000543E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182452, XrefRangeEnd = 182463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001222 RID: 4642 RVA: 0x0005621C File Offset: 0x0005441C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182463, XrefRangeEnd = 182464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001223 RID: 4643 RVA: 0x00056250 File Offset: 0x00054450
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182464, XrefRangeEnd = 182465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001224 RID: 4644 RVA: 0x00056284 File Offset: 0x00054484
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182519, RefRangeEnd = 182520, XrefRangeStart = 182465, XrefRangeEnd = 182519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowBanner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_ShowBanner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001225 RID: 4645 RVA: 0x000562B8 File Offset: 0x000544B8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 182540, RefRangeEnd = 182541, XrefRangeStart = 182520, XrefRangeEnd = 182540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideBanner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_HideBanner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x1700055E RID: 1374
	// (get) Token: 0x06001226 RID: 4646 RVA: 0x000562EC File Offset: 0x000544EC
	public unsafe static Dictionary<string, GoogleMobileAdBanner> registerdBanners
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182557, RefRangeEnd = 182562, XrefRangeStart = 182541, XrefRangeEnd = 182557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_get_registerdBanners_Public_Static_get_Dictionary_2_String_GoogleMobileAdBanner_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GoogleMobileAdBanner>>(intPtr3) : null;
		}
	}

	// Token: 0x1700055F RID: 1375
	// (get) Token: 0x06001227 RID: 4647 RVA: 0x00056320 File Offset: 0x00054520
	public unsafe string sceneBannerId
	{
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182572, RefRangeEnd = 182577, XrefRangeStart = 182562, XrefRangeEnd = 182572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06001228 RID: 4648 RVA: 0x00056358 File Offset: 0x00054558
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182577, XrefRangeEnd = 182578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidAdMobBanner()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidAdMobBanner>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidAdMobBanner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001229 RID: 4649 RVA: 0x0000902F File Offset: 0x0000722F
	public AndroidAdMobBanner(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700055A RID: 1370
	// (get) Token: 0x0600122A RID: 4650 RVA: 0x00056394 File Offset: 0x00054594
	// (set) Token: 0x0600122B RID: 4651 RVA: 0x00009038 File Offset: 0x00007238
	public unsafe string BannersUnityId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_BannersUnityId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_BannersUnityId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700055B RID: 1371
	// (get) Token: 0x0600122C RID: 4652 RVA: 0x000563BC File Offset: 0x000545BC
	// (set) Token: 0x0600122D RID: 4653 RVA: 0x00009057 File Offset: 0x00007257
	public unsafe GADBannerSize size
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_size);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_size)) = value;
		}
	}

	// Token: 0x1700055C RID: 1372
	// (get) Token: 0x0600122E RID: 4654 RVA: 0x000563E4 File Offset: 0x000545E4
	// (set) Token: 0x0600122F RID: 4655 RVA: 0x00009072 File Offset: 0x00007272
	public unsafe TextAnchor anchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_anchor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidAdMobBanner.NativeFieldInfoPtr_anchor)) = value;
		}
	}

	// Token: 0x1700055D RID: 1373
	// (get) Token: 0x06001230 RID: 4656 RVA: 0x0005640C File Offset: 0x0005460C
	// (set) Token: 0x06001231 RID: 4657 RVA: 0x0000908D File Offset: 0x0000728D
	public unsafe static Dictionary<string, GoogleMobileAdBanner> _refisterdBanners
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AndroidAdMobBanner.NativeFieldInfoPtr__refisterdBanners, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AndroidAdMobBanner.NativeFieldInfoPtr__refisterdBanners, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000DF9 RID: 3577
	private static readonly IntPtr NativeFieldInfoPtr_BannersUnityId;

	// Token: 0x04000DFA RID: 3578
	private static readonly IntPtr NativeFieldInfoPtr_size;

	// Token: 0x04000DFB RID: 3579
	private static readonly IntPtr NativeFieldInfoPtr_anchor;

	// Token: 0x04000DFC RID: 3580
	private static readonly IntPtr NativeFieldInfoPtr__refisterdBanners;

	// Token: 0x04000DFD RID: 3581
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000DFE RID: 3582
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000DFF RID: 3583
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

	// Token: 0x04000E00 RID: 3584
	private static readonly IntPtr NativeMethodInfoPtr_ShowBanner_Public_Void_0;

	// Token: 0x04000E01 RID: 3585
	private static readonly IntPtr NativeMethodInfoPtr_HideBanner_Public_Void_0;

	// Token: 0x04000E02 RID: 3586
	private static readonly IntPtr NativeMethodInfoPtr_get_registerdBanners_Public_Static_get_Dictionary_2_String_GoogleMobileAdBanner_0;

	// Token: 0x04000E03 RID: 3587
	private static readonly IntPtr NativeMethodInfoPtr_get_sceneBannerId_Public_get_String_0;

	// Token: 0x04000E04 RID: 3588
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
