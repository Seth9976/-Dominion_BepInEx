using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200013D RID: 317
public class SA_Ad_EditorUIController : MonoBehaviour
{
	// Token: 0x06001744 RID: 5956 RVA: 0x00067308 File Offset: 0x00065508
	// Note: this type is marked as 'beforefieldinit'.
	static SA_Ad_EditorUIController()
	{
		Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_Ad_EditorUIController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr);
		SA_Ad_EditorUIController.NativeFieldInfoPtr_VideoPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "VideoPanel");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_InterstitialPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "InterstitialPanel");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_AppIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "AppIcons");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_AppNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "AppNames");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseVideo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "OnCloseVideo");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_OnVideoLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "OnVideoLeftApplication");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseInterstitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "OnCloseInterstitial");
		SA_Ad_EditorUIController.NativeFieldInfoPtr_OnInterstitialLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "OnInterstitialLeftApplication");
		SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnCloseVideo_Public_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666119);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnCloseVideo_Public_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666120);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666121);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666122);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnCloseInterstitial_Public_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666123);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnCloseInterstitial_Public_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666124);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666125);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666126);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666127);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666128);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_InterstitialClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666129);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_VideoClick_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666130);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666131);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_ShowVideoAd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666132);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_CloseInterstitial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666133);
		SA_Ad_EditorUIController.NativeMethodInfoPtr_CloseVideo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666134);
		SA_Ad_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, 100666135);
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x0006752C File Offset: 0x0006572C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194120, XrefRangeEnd = 194124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCloseVideo(Action<bool> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnCloseVideo_Public_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00067570 File Offset: 0x00065770
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194124, XrefRangeEnd = 194128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCloseVideo(Action<bool> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnCloseVideo_Public_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x000675B4 File Offset: 0x000657B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194128, XrefRangeEnd = 194132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnVideoLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x000675F8 File Offset: 0x000657F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194132, XrefRangeEnd = 194136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnVideoLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001749 RID: 5961 RVA: 0x0006763C File Offset: 0x0006583C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194136, XrefRangeEnd = 194140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnCloseInterstitial(Action<bool> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnCloseInterstitial_Public_add_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00067680 File Offset: 0x00065880
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194140, XrefRangeEnd = 194144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnCloseInterstitial(Action<bool> value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnCloseInterstitial_Public_rem_Void_Action_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600174B RID: 5963 RVA: 0x000676C4 File Offset: 0x000658C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194144, XrefRangeEnd = 194148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void add_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600174C RID: 5964 RVA: 0x00067708 File Offset: 0x00065908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194148, XrefRangeEnd = 194152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void remove_OnInterstitialLeftApplication(Action value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x0006774C File Offset: 0x0006594C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194152, XrefRangeEnd = 194163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00067780 File Offset: 0x00065980
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x000677B4 File Offset: 0x000659B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InterstitialClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_InterstitialClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x000677E8 File Offset: 0x000659E8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194163, XrefRangeEnd = 194165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void VideoClick()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_VideoClick_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x0006781C File Offset: 0x00065A1C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194165, XrefRangeEnd = 194169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInterstitialAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001752 RID: 5970 RVA: 0x00067850 File Offset: 0x00065A50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194169, XrefRangeEnd = 194173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVideoAd()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_ShowVideoAd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001753 RID: 5971 RVA: 0x00067884 File Offset: 0x00065A84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194173, XrefRangeEnd = 194180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseInterstitial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_CloseInterstitial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x000678B8 File Offset: 0x00065AB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194180, XrefRangeEnd = 194187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CloseVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr_CloseVideo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x000678EC File Offset: 0x00065AEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194187, XrefRangeEnd = 194239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_Ad_EditorUIController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x0000B430 File Offset: 0x00009630
	public SA_Ad_EditorUIController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700068C RID: 1676
	// (get) Token: 0x06001757 RID: 5975 RVA: 0x00067928 File Offset: 0x00065B28
	// (set) Token: 0x06001758 RID: 5976 RVA: 0x0000B439 File Offset: 0x00009639
	public unsafe GameObject VideoPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_VideoPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_VideoPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068D RID: 1677
	// (get) Token: 0x06001759 RID: 5977 RVA: 0x00067958 File Offset: 0x00065B58
	// (set) Token: 0x0600175A RID: 5978 RVA: 0x0000B458 File Offset: 0x00009658
	public unsafe GameObject InterstitialPanel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_InterstitialPanel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_InterstitialPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068E RID: 1678
	// (get) Token: 0x0600175B RID: 5979 RVA: 0x00067988 File Offset: 0x00065B88
	// (set) Token: 0x0600175C RID: 5980 RVA: 0x0000B477 File Offset: 0x00009677
	public unsafe Il2CppReferenceArray<Image> AppIcons
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_AppIcons);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_AppIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700068F RID: 1679
	// (get) Token: 0x0600175D RID: 5981 RVA: 0x000679B8 File Offset: 0x00065BB8
	// (set) Token: 0x0600175E RID: 5982 RVA: 0x0000B496 File Offset: 0x00009696
	public unsafe Il2CppReferenceArray<Text> AppNames
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_AppNames);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_AppNames), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000690 RID: 1680
	// (get) Token: 0x0600175F RID: 5983 RVA: 0x000679E8 File Offset: 0x00065BE8
	// (set) Token: 0x06001760 RID: 5984 RVA: 0x0000B4B5 File Offset: 0x000096B5
	public unsafe Action<bool> OnCloseVideo
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseVideo);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseVideo), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000691 RID: 1681
	// (get) Token: 0x06001761 RID: 5985 RVA: 0x00067A18 File Offset: 0x00065C18
	// (set) Token: 0x06001762 RID: 5986 RVA: 0x0000B4D4 File Offset: 0x000096D4
	public unsafe Action OnVideoLeftApplication
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnVideoLeftApplication);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnVideoLeftApplication), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000692 RID: 1682
	// (get) Token: 0x06001763 RID: 5987 RVA: 0x00067A48 File Offset: 0x00065C48
	// (set) Token: 0x06001764 RID: 5988 RVA: 0x0000B4F3 File Offset: 0x000096F3
	public unsafe Action<bool> OnCloseInterstitial
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseInterstitial);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnCloseInterstitial), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000693 RID: 1683
	// (get) Token: 0x06001765 RID: 5989 RVA: 0x00067A78 File Offset: 0x00065C78
	// (set) Token: 0x06001766 RID: 5990 RVA: 0x0000B512 File Offset: 0x00009712
	public unsafe Action OnInterstitialLeftApplication
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnInterstitialLeftApplication);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Ad_EditorUIController.NativeFieldInfoPtr_OnInterstitialLeftApplication), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400119E RID: 4510
	private static readonly IntPtr NativeFieldInfoPtr_VideoPanel;

	// Token: 0x0400119F RID: 4511
	private static readonly IntPtr NativeFieldInfoPtr_InterstitialPanel;

	// Token: 0x040011A0 RID: 4512
	private static readonly IntPtr NativeFieldInfoPtr_AppIcons;

	// Token: 0x040011A1 RID: 4513
	private static readonly IntPtr NativeFieldInfoPtr_AppNames;

	// Token: 0x040011A2 RID: 4514
	private static readonly IntPtr NativeFieldInfoPtr_OnCloseVideo;

	// Token: 0x040011A3 RID: 4515
	private static readonly IntPtr NativeFieldInfoPtr_OnVideoLeftApplication;

	// Token: 0x040011A4 RID: 4516
	private static readonly IntPtr NativeFieldInfoPtr_OnCloseInterstitial;

	// Token: 0x040011A5 RID: 4517
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialLeftApplication;

	// Token: 0x040011A6 RID: 4518
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCloseVideo_Public_add_Void_Action_1_Boolean_0;

	// Token: 0x040011A7 RID: 4519
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCloseVideo_Public_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011A8 RID: 4520
	private static readonly IntPtr NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_add_Void_Action_0;

	// Token: 0x040011A9 RID: 4521
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_rem_Void_Action_0;

	// Token: 0x040011AA RID: 4522
	private static readonly IntPtr NativeMethodInfoPtr_add_OnCloseInterstitial_Public_add_Void_Action_1_Boolean_0;

	// Token: 0x040011AB RID: 4523
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnCloseInterstitial_Public_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011AC RID: 4524
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_add_Void_Action_0;

	// Token: 0x040011AD RID: 4525
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_rem_Void_Action_0;

	// Token: 0x040011AE RID: 4526
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040011AF RID: 4527
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x040011B0 RID: 4528
	private static readonly IntPtr NativeMethodInfoPtr_InterstitialClick_Public_Void_0;

	// Token: 0x040011B1 RID: 4529
	private static readonly IntPtr NativeMethodInfoPtr_VideoClick_Public_Void_0;

	// Token: 0x040011B2 RID: 4530
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitialAd_Public_Void_0;

	// Token: 0x040011B3 RID: 4531
	private static readonly IntPtr NativeMethodInfoPtr_ShowVideoAd_Public_Void_0;

	// Token: 0x040011B4 RID: 4532
	private static readonly IntPtr NativeMethodInfoPtr_CloseInterstitial_Public_Void_0;

	// Token: 0x040011B5 RID: 4533
	private static readonly IntPtr NativeMethodInfoPtr_CloseVideo_Public_Void_0;

	// Token: 0x040011B6 RID: 4534
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020003A5 RID: 933
	[ObfuscatedName("SA_Ad_EditorUIController+<>c")]
	[Serializable]
	public sealed class __c : global::Il2CppSystem.Object
	{
		// Token: 0x06003716 RID: 14102 RVA: 0x000E165C File Offset: 0x000DF85C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Ad_EditorUIController>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr);
			SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, "<>9");
			SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, "<>9__24_0");
			SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, "<>9__24_1");
			SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, "<>9__24_2");
			SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, "<>9__24_3");
			SA_Ad_EditorUIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, 100670298);
			SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, 100670299);
			SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, 100670300);
			SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, 100670301);
			SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr, 100670302);
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000E1750 File Offset: 0x000DF950
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Ad_EditorUIController.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x000E178C File Offset: 0x000DF98C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_0(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x000E17CC File Offset: 0x000DF9CC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x000E1800 File Offset: 0x000DFA00
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_2(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x000E1840 File Offset: 0x000DFA40
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__24_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Ad_EditorUIController.__c.NativeMethodInfoPtr___ctor_b__24_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x00015581 File Offset: 0x00013781
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x000E1874 File Offset: 0x000DFA74
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x0001558A File Offset: 0x0001378A
		public unsafe static SA_Ad_EditorUIController.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Ad_EditorUIController.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D34 RID: 3380
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x000E189C File Offset: 0x000DFA9C
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x0001559C File Offset: 0x0001379C
		public unsafe static Action<bool> __9__24_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D35 RID: 3381
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x000E18C4 File Offset: 0x000DFAC4
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x000155AE File Offset: 0x000137AE
		public unsafe static Action __9__24_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x000E18EC File Offset: 0x000DFAEC
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x000155C0 File Offset: 0x000137C0
		public unsafe static Action<bool> __9__24_2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D37 RID: 3383
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x000E1914 File Offset: 0x000DFB14
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x000155D2 File Offset: 0x000137D2
		public unsafe static Action __9__24_3
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_3, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_Ad_EditorUIController.__c.NativeFieldInfoPtr___9__24_3, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003230 RID: 12848
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003231 RID: 12849
		private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

		// Token: 0x04003232 RID: 12850
		private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

		// Token: 0x04003233 RID: 12851
		private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

		// Token: 0x04003234 RID: 12852
		private static readonly IntPtr NativeFieldInfoPtr___9__24_3;

		// Token: 0x04003235 RID: 12853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003236 RID: 12854
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_0_Internal_Void_Boolean_0;

		// Token: 0x04003237 RID: 12855
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_1_Internal_Void_0;

		// Token: 0x04003238 RID: 12856
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_2_Internal_Void_Boolean_0;

		// Token: 0x04003239 RID: 12857
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__24_3_Internal_Void_0;
	}
}
