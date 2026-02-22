using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000013 RID: 19
public class AndroidADBanner : global::Il2CppSystem.Object
{
	// Token: 0x06000140 RID: 320 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
	// Note: this type is marked as 'beforefieldinit'.
	static AndroidADBanner()
	{
		Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AndroidADBanner");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr);
		AndroidADBanner.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_id");
		AndroidADBanner.NativeFieldInfoPtr__size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_size");
		AndroidADBanner.NativeFieldInfoPtr__anchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_anchor");
		AndroidADBanner.NativeFieldInfoPtr__IsLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_IsLoaded");
		AndroidADBanner.NativeFieldInfoPtr__IsOnScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_IsOnScreen");
		AndroidADBanner.NativeFieldInfoPtr_firstLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "firstLoad");
		AndroidADBanner.NativeFieldInfoPtr_destroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "destroyOnLoad");
		AndroidADBanner.NativeFieldInfoPtr__ShowOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_ShowOnLoad");
		AndroidADBanner.NativeFieldInfoPtr__width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_width");
		AndroidADBanner.NativeFieldInfoPtr__height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_height");
		AndroidADBanner.NativeFieldInfoPtr__OnLoadedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_OnLoadedAction");
		AndroidADBanner.NativeFieldInfoPtr__OnFailedLoadingAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_OnFailedLoadingAction");
		AndroidADBanner.NativeFieldInfoPtr__OnOpenedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_OnOpenedAction");
		AndroidADBanner.NativeFieldInfoPtr__OnClosedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_OnClosedAction");
		AndroidADBanner.NativeFieldInfoPtr__OnLeftApplicationAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "_OnLeftApplicationAction");
		AndroidADBanner.NativeMethodInfoPtr__ctor_Public_Void_TextAnchor_GADBannerSize_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663515);
		AndroidADBanner.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GADBannerSize_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663516);
		AndroidADBanner.NativeMethodInfoPtr_Hide_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663517);
		AndroidADBanner.NativeMethodInfoPtr_Show_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663518);
		AndroidADBanner.NativeMethodInfoPtr_Refresh_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663519);
		AndroidADBanner.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663520);
		AndroidADBanner.NativeMethodInfoPtr_Resume_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663521);
		AndroidADBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663522);
		AndroidADBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663523);
		AndroidADBanner.NativeMethodInfoPtr_DestroyAfterLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663524);
		AndroidADBanner.NativeMethodInfoPtr_SetDimentions_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663525);
		AndroidADBanner.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663526);
		AndroidADBanner.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663527);
		AndroidADBanner.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663528);
		AndroidADBanner.NativeMethodInfoPtr_get_size_Public_Virtual_Final_New_get_GADBannerSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663529);
		AndroidADBanner.NativeMethodInfoPtr_get_IsLoaded_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663530);
		AndroidADBanner.NativeMethodInfoPtr_get_IsOnScreen_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663531);
		AndroidADBanner.NativeMethodInfoPtr_get_ShowOnLoad_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663532);
		AndroidADBanner.NativeMethodInfoPtr_set_ShowOnLoad_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663533);
		AndroidADBanner.NativeMethodInfoPtr_get_anchor_Public_Virtual_Final_New_get_TextAnchor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663534);
		AndroidADBanner.NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663535);
		AndroidADBanner.NativeMethodInfoPtr_get_OnLoadedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663536);
		AndroidADBanner.NativeMethodInfoPtr_set_OnLoadedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663537);
		AndroidADBanner.NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663538);
		AndroidADBanner.NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663539);
		AndroidADBanner.NativeMethodInfoPtr_get_OnOpenedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663540);
		AndroidADBanner.NativeMethodInfoPtr_set_OnOpenedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663541);
		AndroidADBanner.NativeMethodInfoPtr_get_OnClosedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663542);
		AndroidADBanner.NativeMethodInfoPtr_set_OnClosedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663543);
		AndroidADBanner.NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663544);
		AndroidADBanner.NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663545);
		AndroidADBanner.NativeMethodInfoPtr_OnBannerAdLoaded_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663546);
		AndroidADBanner.NativeMethodInfoPtr_OnBannerAdFailedToLoad_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663547);
		AndroidADBanner.NativeMethodInfoPtr_OnBannerAdOpened_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663548);
		AndroidADBanner.NativeMethodInfoPtr_OnBannerAdClosed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663549);
		AndroidADBanner.NativeMethodInfoPtr_OnBannerAdLeftApplication_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, 100663550);
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0001C3DC File Offset: 0x0001A5DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 160757, RefRangeEnd = 160759, XrefRangeStart = 160681, XrefRangeEnd = 160757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidADBanner(TextAnchor anchor, GADBannerSize size, int id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchor;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr__ctor_Public_Void_TextAnchor_GADBannerSize_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0001C440 File Offset: 0x0001A640
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 160824, RefRangeEnd = 160825, XrefRangeStart = 160759, XrefRangeEnd = 160824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AndroidADBanner(int x, int y, GADBannerSize size, int id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GADBannerSize_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000143 RID: 323 RVA: 0x0001C4B4 File Offset: 0x0001A6B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160825, XrefRangeEnd = 160832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Hide()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_Hide_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000144 RID: 324 RVA: 0x0001C4E8 File Offset: 0x0001A6E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160832, XrefRangeEnd = 160839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Show()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_Show_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000145 RID: 325 RVA: 0x0001C51C File Offset: 0x0001A71C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160839, XrefRangeEnd = 160846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Refresh()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_Refresh_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000146 RID: 326 RVA: 0x0001C550 File Offset: 0x0001A750
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160846, XrefRangeEnd = 160853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000147 RID: 327 RVA: 0x0001C584 File Offset: 0x0001A784
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160853, XrefRangeEnd = 160860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Resume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_Resume_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160860, XrefRangeEnd = 160871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetBannerPosition(int x, int y)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000149 RID: 329 RVA: 0x0001C604 File Offset: 0x0001A804
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160871, XrefRangeEnd = 160881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void SetBannerPosition(TextAnchor anchor)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref anchor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600014A RID: 330 RVA: 0x0001C644 File Offset: 0x0001A844
	[CallerCount(0)]
	public unsafe void DestroyAfterLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_DestroyAfterLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x0001C678 File Offset: 0x0001A878
	[CallerCount(0)]
	public unsafe void SetDimentions(int w, int h)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref w;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_SetDimentions_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600014C RID: 332 RVA: 0x0001C6C4 File Offset: 0x0001A8C4
	public unsafe virtual int id
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600014D RID: 333 RVA: 0x0001C700 File Offset: 0x0001A900
	public unsafe virtual int width
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x0600014E RID: 334 RVA: 0x0001C73C File Offset: 0x0001A93C
	public unsafe virtual int height
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600014F RID: 335 RVA: 0x0001C778 File Offset: 0x0001A978
	public unsafe virtual GADBannerSize size
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_size_Public_Virtual_Final_New_get_GADBannerSize_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000150 RID: 336 RVA: 0x0001C7B4 File Offset: 0x0001A9B4
	public unsafe virtual bool IsLoaded
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_IsLoaded_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0001C7F0 File Offset: 0x0001A9F0
	public unsafe virtual bool IsOnScreen
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_IsOnScreen_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000152 RID: 338 RVA: 0x0001C82C File Offset: 0x0001AA2C
	// (set) Token: 0x06000153 RID: 339 RVA: 0x0001C868 File Offset: 0x0001AA68
	public unsafe virtual bool ShowOnLoad
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_ShowOnLoad_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_ShowOnLoad_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x06000154 RID: 340 RVA: 0x0001C8A8 File Offset: 0x0001AAA8
	public unsafe virtual TextAnchor anchor
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_anchor_Public_Virtual_Final_New_get_TextAnchor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x06000155 RID: 341 RVA: 0x0001C8E4 File Offset: 0x0001AAE4
	public unsafe GoogleGravity gravity
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 160881, RefRangeEnd = 160883, XrefRangeStart = 160881, XrefRangeEnd = 160881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x06000156 RID: 342 RVA: 0x0001C920 File Offset: 0x0001AB20
	// (set) Token: 0x06000157 RID: 343 RVA: 0x0001C960 File Offset: 0x0001AB60
	public unsafe virtual Action<GoogleMobileAdBanner> OnLoadedAction
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_OnLoadedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_OnLoadedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000158 RID: 344 RVA: 0x0001C9A4 File Offset: 0x0001ABA4
	// (set) Token: 0x06000159 RID: 345 RVA: 0x0001C9E4 File Offset: 0x0001ABE4
	public unsafe virtual Action<GoogleMobileAdBanner> OnFailedLoadingAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x0600015A RID: 346 RVA: 0x0001CA28 File Offset: 0x0001AC28
	// (set) Token: 0x0600015B RID: 347 RVA: 0x0001CA68 File Offset: 0x0001AC68
	public unsafe virtual Action<GoogleMobileAdBanner> OnOpenedAction
	{
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_OnOpenedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_OnOpenedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x0600015C RID: 348 RVA: 0x0001CAAC File Offset: 0x0001ACAC
	// (set) Token: 0x0600015D RID: 349 RVA: 0x0001CAEC File Offset: 0x0001ACEC
	public unsafe virtual Action<GoogleMobileAdBanner> OnClosedAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_OnClosedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_OnClosedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600015E RID: 350 RVA: 0x0001CB30 File Offset: 0x0001AD30
	// (set) Token: 0x0600015F RID: 351 RVA: 0x0001CB70 File Offset: 0x0001AD70
	public unsafe virtual Action<GoogleMobileAdBanner> OnLeftApplicationAction
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr3) : null;
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160883, XrefRangeEnd = 160900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdLoaded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_OnBannerAdLoaded_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000161 RID: 353 RVA: 0x0001CBE8 File Offset: 0x0001ADE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160900, XrefRangeEnd = 160904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdFailedToLoad()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_OnBannerAdFailedToLoad_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x0001CC1C File Offset: 0x0001AE1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160904, XrefRangeEnd = 160908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdOpened()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_OnBannerAdOpened_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0001CC50 File Offset: 0x0001AE50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160908, XrefRangeEnd = 160912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdClosed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_OnBannerAdClosed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000164 RID: 356 RVA: 0x0001CC84 File Offset: 0x0001AE84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160912, XrefRangeEnd = 160916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnBannerAdLeftApplication()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.NativeMethodInfoPtr_OnBannerAdLeftApplication_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000165 RID: 357 RVA: 0x000024C1 File Offset: 0x000006C1
	public AndroidADBanner(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x06000166 RID: 358 RVA: 0x0001CCB8 File Offset: 0x0001AEB8
	// (set) Token: 0x06000167 RID: 359 RVA: 0x000024CA File Offset: 0x000006CA
	public unsafe int _id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__id);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__id)) = value;
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x06000168 RID: 360 RVA: 0x0001CCE0 File Offset: 0x0001AEE0
	// (set) Token: 0x06000169 RID: 361 RVA: 0x000024E5 File Offset: 0x000006E5
	public unsafe GADBannerSize _size
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__size);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__size)) = value;
		}
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x0600016A RID: 362 RVA: 0x0001CD08 File Offset: 0x0001AF08
	// (set) Token: 0x0600016B RID: 363 RVA: 0x00002500 File Offset: 0x00000700
	public unsafe TextAnchor _anchor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__anchor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__anchor)) = value;
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600016C RID: 364 RVA: 0x0001CD30 File Offset: 0x0001AF30
	// (set) Token: 0x0600016D RID: 365 RVA: 0x0000251B File Offset: 0x0000071B
	public unsafe bool _IsLoaded
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__IsLoaded);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__IsLoaded)) = value;
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600016E RID: 366 RVA: 0x0001CD58 File Offset: 0x0001AF58
	// (set) Token: 0x0600016F RID: 367 RVA: 0x00002536 File Offset: 0x00000736
	public unsafe bool _IsOnScreen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__IsOnScreen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__IsOnScreen)) = value;
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000170 RID: 368 RVA: 0x0001CD80 File Offset: 0x0001AF80
	// (set) Token: 0x06000171 RID: 369 RVA: 0x00002551 File Offset: 0x00000751
	public unsafe bool firstLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr_firstLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr_firstLoad)) = value;
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06000172 RID: 370 RVA: 0x0001CDA8 File Offset: 0x0001AFA8
	// (set) Token: 0x06000173 RID: 371 RVA: 0x0000256C File Offset: 0x0000076C
	public unsafe bool destroyOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr_destroyOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr_destroyOnLoad)) = value;
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x06000174 RID: 372 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
	// (set) Token: 0x06000175 RID: 373 RVA: 0x00002587 File Offset: 0x00000787
	public unsafe bool _ShowOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__ShowOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__ShowOnLoad)) = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06000176 RID: 374 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
	// (set) Token: 0x06000177 RID: 375 RVA: 0x000025A2 File Offset: 0x000007A2
	public unsafe int _width
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__width);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__width)) = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000178 RID: 376 RVA: 0x0001CE20 File Offset: 0x0001B020
	// (set) Token: 0x06000179 RID: 377 RVA: 0x000025BD File Offset: 0x000007BD
	public unsafe int _height
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__height);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__height)) = value;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x0600017A RID: 378 RVA: 0x0001CE48 File Offset: 0x0001B048
	// (set) Token: 0x0600017B RID: 379 RVA: 0x000025D8 File Offset: 0x000007D8
	public unsafe Action<GoogleMobileAdBanner> _OnLoadedAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnLoadedAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnLoadedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x0600017C RID: 380 RVA: 0x0001CE78 File Offset: 0x0001B078
	// (set) Token: 0x0600017D RID: 381 RVA: 0x000025F7 File Offset: 0x000007F7
	public unsafe Action<GoogleMobileAdBanner> _OnFailedLoadingAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnFailedLoadingAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnFailedLoadingAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x0600017E RID: 382 RVA: 0x0001CEA8 File Offset: 0x0001B0A8
	// (set) Token: 0x0600017F RID: 383 RVA: 0x00002616 File Offset: 0x00000816
	public unsafe Action<GoogleMobileAdBanner> _OnOpenedAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnOpenedAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnOpenedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000180 RID: 384 RVA: 0x0001CED8 File Offset: 0x0001B0D8
	// (set) Token: 0x06000181 RID: 385 RVA: 0x00002635 File Offset: 0x00000835
	public unsafe Action<GoogleMobileAdBanner> _OnClosedAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnClosedAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnClosedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x06000182 RID: 386 RVA: 0x0001CF08 File Offset: 0x0001B108
	// (set) Token: 0x06000183 RID: 387 RVA: 0x00002654 File Offset: 0x00000854
	public unsafe Action<GoogleMobileAdBanner> _OnLeftApplicationAction
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnLeftApplicationAction);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidADBanner.NativeFieldInfoPtr__OnLeftApplicationAction), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeFieldInfoPtr__id;

	// Token: 0x04000133 RID: 307
	private static readonly IntPtr NativeFieldInfoPtr__size;

	// Token: 0x04000134 RID: 308
	private static readonly IntPtr NativeFieldInfoPtr__anchor;

	// Token: 0x04000135 RID: 309
	private static readonly IntPtr NativeFieldInfoPtr__IsLoaded;

	// Token: 0x04000136 RID: 310
	private static readonly IntPtr NativeFieldInfoPtr__IsOnScreen;

	// Token: 0x04000137 RID: 311
	private static readonly IntPtr NativeFieldInfoPtr_firstLoad;

	// Token: 0x04000138 RID: 312
	private static readonly IntPtr NativeFieldInfoPtr_destroyOnLoad;

	// Token: 0x04000139 RID: 313
	private static readonly IntPtr NativeFieldInfoPtr__ShowOnLoad;

	// Token: 0x0400013A RID: 314
	private static readonly IntPtr NativeFieldInfoPtr__width;

	// Token: 0x0400013B RID: 315
	private static readonly IntPtr NativeFieldInfoPtr__height;

	// Token: 0x0400013C RID: 316
	private static readonly IntPtr NativeFieldInfoPtr__OnLoadedAction;

	// Token: 0x0400013D RID: 317
	private static readonly IntPtr NativeFieldInfoPtr__OnFailedLoadingAction;

	// Token: 0x0400013E RID: 318
	private static readonly IntPtr NativeFieldInfoPtr__OnOpenedAction;

	// Token: 0x0400013F RID: 319
	private static readonly IntPtr NativeFieldInfoPtr__OnClosedAction;

	// Token: 0x04000140 RID: 320
	private static readonly IntPtr NativeFieldInfoPtr__OnLeftApplicationAction;

	// Token: 0x04000141 RID: 321
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextAnchor_GADBannerSize_Int32_0;

	// Token: 0x04000142 RID: 322
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_GADBannerSize_Int32_0;

	// Token: 0x04000143 RID: 323
	private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000144 RID: 324
	private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000145 RID: 325
	private static readonly IntPtr NativeMethodInfoPtr_Refresh_Public_Virtual_Final_New_Void_0;

	// Token: 0x04000146 RID: 326
	private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	// Token: 0x04000147 RID: 327
	private static readonly IntPtr NativeMethodInfoPtr_Resume_Public_Void_0;

	// Token: 0x04000148 RID: 328
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_Int32_Int32_0;

	// Token: 0x04000149 RID: 329
	private static readonly IntPtr NativeMethodInfoPtr_SetBannerPosition_Public_Virtual_Final_New_Void_TextAnchor_0;

	// Token: 0x0400014A RID: 330
	private static readonly IntPtr NativeMethodInfoPtr_DestroyAfterLoad_Public_Void_0;

	// Token: 0x0400014B RID: 331
	private static readonly IntPtr NativeMethodInfoPtr_SetDimentions_Public_Void_Int32_Int32_0;

	// Token: 0x0400014C RID: 332
	private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400014D RID: 333
	private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400014E RID: 334
	private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_Virtual_Final_New_get_Int32_0;

	// Token: 0x0400014F RID: 335
	private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_Virtual_Final_New_get_GADBannerSize_0;

	// Token: 0x04000150 RID: 336
	private static readonly IntPtr NativeMethodInfoPtr_get_IsLoaded_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000151 RID: 337
	private static readonly IntPtr NativeMethodInfoPtr_get_IsOnScreen_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000152 RID: 338
	private static readonly IntPtr NativeMethodInfoPtr_get_ShowOnLoad_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000153 RID: 339
	private static readonly IntPtr NativeMethodInfoPtr_set_ShowOnLoad_Public_Virtual_Final_New_set_Void_Boolean_0;

	// Token: 0x04000154 RID: 340
	private static readonly IntPtr NativeMethodInfoPtr_get_anchor_Public_Virtual_Final_New_get_TextAnchor_0;

	// Token: 0x04000155 RID: 341
	private static readonly IntPtr NativeMethodInfoPtr_get_gravity_Public_get_GoogleGravity_0;

	// Token: 0x04000156 RID: 342
	private static readonly IntPtr NativeMethodInfoPtr_get_OnLoadedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x04000157 RID: 343
	private static readonly IntPtr NativeMethodInfoPtr_set_OnLoadedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x04000158 RID: 344
	private static readonly IntPtr NativeMethodInfoPtr_get_OnFailedLoadingAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x04000159 RID: 345
	private static readonly IntPtr NativeMethodInfoPtr_set_OnFailedLoadingAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015A RID: 346
	private static readonly IntPtr NativeMethodInfoPtr_get_OnOpenedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015B RID: 347
	private static readonly IntPtr NativeMethodInfoPtr_set_OnOpenedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015C RID: 348
	private static readonly IntPtr NativeMethodInfoPtr_get_OnClosedAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015D RID: 349
	private static readonly IntPtr NativeMethodInfoPtr_set_OnClosedAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015E RID: 350
	private static readonly IntPtr NativeMethodInfoPtr_get_OnLeftApplicationAction_Public_Virtual_Final_New_get_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x0400015F RID: 351
	private static readonly IntPtr NativeMethodInfoPtr_set_OnLeftApplicationAction_Public_Virtual_Final_New_set_Void_Action_1_GoogleMobileAdBanner_0;

	// Token: 0x04000160 RID: 352
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdLoaded_Public_Void_0;

	// Token: 0x04000161 RID: 353
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdFailedToLoad_Public_Void_0;

	// Token: 0x04000162 RID: 354
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdOpened_Public_Void_0;

	// Token: 0x04000163 RID: 355
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdClosed_Public_Void_0;

	// Token: 0x04000164 RID: 356
	private static readonly IntPtr NativeMethodInfoPtr_OnBannerAdLeftApplication_Public_Void_0;

	// Token: 0x02000364 RID: 868
	[ObfuscatedName("AndroidADBanner+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003418 RID: 13336 RVA: 0x000D7D40 File Offset: 0x000D5F40
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AndroidADBanner>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr);
			AndroidADBanner.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__15_0");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__15_1");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__15_2");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__15_3");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__15_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__15_4");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__16_0");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__16_1");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__16_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__16_2");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__16_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__16_3");
			AndroidADBanner.__c.NativeFieldInfoPtr___9__16_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, "<>9__16_4");
			AndroidADBanner.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669932);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669933);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669934);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_2_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669935);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_3_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669936);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_4_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669937);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669938);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669939);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_2_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669940);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_3_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669941);
			AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_4_Internal_Void_GoogleMobileAdBanner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr, 100669942);
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000D7F24 File Offset: 0x000D6124
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidADBanner.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000D7F60 File Offset: 0x000D6160
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_0(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000D7FA4 File Offset: 0x000D61A4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_1(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000D7FE8 File Offset: 0x000D61E8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_2(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_2_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000D802C File Offset: 0x000D622C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_3(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_3_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000D8070 File Offset: 0x000D6270
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_4(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__15_4_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000D80B4 File Offset: 0x000D62B4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_0(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000D80F8 File Offset: 0x000D62F8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_1(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000D813C File Offset: 0x000D633C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_2(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_2_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000D8180 File Offset: 0x000D6380
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_3(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_3_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003423 RID: 13347 RVA: 0x000D81C4 File Offset: 0x000D63C4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_4(GoogleMobileAdBanner <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidADBanner.__c.NativeMethodInfoPtr___ctor_b__16_4_Internal_Void_GoogleMobileAdBanner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003424 RID: 13348 RVA: 0x000145CB File Offset: 0x000127CB
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x000D8208 File Offset: 0x000D6408
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x000145D4 File Offset: 0x000127D4
		public unsafe static AndroidADBanner.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidADBanner.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x000D8230 File Offset: 0x000D6430
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x000145E6 File Offset: 0x000127E6
		public unsafe static Action<GoogleMobileAdBanner> __9__15_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x000D8258 File Offset: 0x000D6458
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x000145F8 File Offset: 0x000127F8
		public unsafe static Action<GoogleMobileAdBanner> __9__15_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x000D8280 File Offset: 0x000D6480
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x0001460A File Offset: 0x0001280A
		public unsafe static Action<GoogleMobileAdBanner> __9__15_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x000D82A8 File Offset: 0x000D64A8
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x0001461C File Offset: 0x0001281C
		public unsafe static Action<GoogleMobileAdBanner> __9__15_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x000D82D0 File Offset: 0x000D64D0
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x0001462E File Offset: 0x0001282E
		public unsafe static Action<GoogleMobileAdBanner> __9__15_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__15_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x000D82F8 File Offset: 0x000D64F8
		// (set) Token: 0x06003432 RID: 13362 RVA: 0x00014640 File Offset: 0x00012840
		public unsafe static Action<GoogleMobileAdBanner> __9__16_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x000D8320 File Offset: 0x000D6520
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x00014652 File Offset: 0x00012852
		public unsafe static Action<GoogleMobileAdBanner> __9__16_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x000D8348 File Offset: 0x000D6548
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x00014664 File Offset: 0x00012864
		public unsafe static Action<GoogleMobileAdBanner> __9__16_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x000D8370 File Offset: 0x000D6570
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x00014676 File Offset: 0x00012876
		public unsafe static Action<GoogleMobileAdBanner> __9__16_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x000D8398 File Offset: 0x000D6598
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00014688 File Offset: 0x00012888
		public unsafe static Action<GoogleMobileAdBanner> __9__16_4
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_4, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GoogleMobileAdBanner>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidADBanner.__c.NativeFieldInfoPtr___9__16_4, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003056 RID: 12374
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003057 RID: 12375
		private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

		// Token: 0x04003058 RID: 12376
		private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

		// Token: 0x04003059 RID: 12377
		private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

		// Token: 0x0400305A RID: 12378
		private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

		// Token: 0x0400305B RID: 12379
		private static readonly IntPtr NativeFieldInfoPtr___9__15_4;

		// Token: 0x0400305C RID: 12380
		private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

		// Token: 0x0400305D RID: 12381
		private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeFieldInfoPtr___9__16_2;

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeFieldInfoPtr___9__16_3;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeFieldInfoPtr___9__16_4;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_1_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_2_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_3_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_4_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_0_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_1_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_2_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_3_Internal_Void_GoogleMobileAdBanner_0;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_4_Internal_Void_GoogleMobileAdBanner_0;
	}
}
