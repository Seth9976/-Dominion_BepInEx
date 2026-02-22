using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x0200013E RID: 318
public class SA_EditorAd : Singleton<SA_EditorAd>
{
	// Token: 0x06001767 RID: 5991 RVA: 0x00067AA8 File Offset: 0x00065CA8
	// Note: this type is marked as 'beforefieldinit'.
	static SA_EditorAd()
	{
		Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_EditorAd");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr);
		SA_EditorAd.NativeFieldInfoPtr_MIN_LOAD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "MIN_LOAD_TIME");
		SA_EditorAd.NativeFieldInfoPtr_MAX_LOAD_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "MAX_LOAD_TIME");
		SA_EditorAd.NativeFieldInfoPtr__IsInterstitialLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_IsInterstitialLoading");
		SA_EditorAd.NativeFieldInfoPtr__IsVideoLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_IsVideoLoading");
		SA_EditorAd.NativeFieldInfoPtr__IsInterstitialReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_IsInterstitialReady");
		SA_EditorAd.NativeFieldInfoPtr__IsVideoReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_IsVideoReady");
		SA_EditorAd.NativeFieldInfoPtr__FillRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_FillRate");
		SA_EditorAd.NativeFieldInfoPtr_OnInterstitialFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnInterstitialFinished");
		SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnInterstitialLoadComplete");
		SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnInterstitialLeftApplication");
		SA_EditorAd.NativeFieldInfoPtr_OnVideoFinished = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnVideoFinished");
		SA_EditorAd.NativeFieldInfoPtr_OnVideoLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnVideoLoadComplete");
		SA_EditorAd.NativeFieldInfoPtr_OnVideoLeftApplication = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "OnVideoLeftApplication");
		SA_EditorAd.NativeFieldInfoPtr__EditorUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "_EditorUI");
		SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialFinished_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666136);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialFinished_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666137);
		SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialLoadComplete_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666138);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666139);
		SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666140);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666141);
		SA_EditorAd.NativeMethodInfoPtr_add_OnVideoFinished_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666142);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoFinished_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666143);
		SA_EditorAd.NativeMethodInfoPtr_add_OnVideoLoadComplete_Public_Static_add_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666144);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666145);
		SA_EditorAd.NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666146);
		SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666147);
		SA_EditorAd.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666148);
		SA_EditorAd.NativeMethodInfoPtr_SetFillRate_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666149);
		SA_EditorAd.NativeMethodInfoPtr_LoadInterstitial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666150);
		SA_EditorAd.NativeMethodInfoPtr_ShowInterstitial_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666151);
		SA_EditorAd.NativeMethodInfoPtr_LoadVideo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666152);
		SA_EditorAd.NativeMethodInfoPtr_ShowVideo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666153);
		SA_EditorAd.NativeMethodInfoPtr_get_IsVideoReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666154);
		SA_EditorAd.NativeMethodInfoPtr_get_IsVideoLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666155);
		SA_EditorAd.NativeMethodInfoPtr_get_IsInterstitialReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666156);
		SA_EditorAd.NativeMethodInfoPtr_get_IsInterstitialLoading_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666157);
		SA_EditorAd.NativeMethodInfoPtr_get_HasFill_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666158);
		SA_EditorAd.NativeMethodInfoPtr_get_FillRate_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666159);
		SA_EditorAd.NativeMethodInfoPtr_get_EditorUI_Private_get_SA_Ad_EditorUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666160);
		SA_EditorAd.NativeMethodInfoPtr_OnVideoRequestComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666161);
		SA_EditorAd.NativeMethodInfoPtr_OnInterstitialRequestComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666162);
		SA_EditorAd.NativeMethodInfoPtr_OnInterstitialFinished_UIEvent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666163);
		SA_EditorAd.NativeMethodInfoPtr_OnVideoFinished_UIEvent_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666164);
		SA_EditorAd.NativeMethodInfoPtr_OnInterstitialLeftApplication_UIEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666165);
		SA_EditorAd.NativeMethodInfoPtr_OnVideoLeftApplication_UIEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666166);
		SA_EditorAd.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, 100666167);
	}

	// Token: 0x06001768 RID: 5992 RVA: 0x00067E70 File Offset: 0x00066070
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194250, RefRangeEnd = 194251, XrefRangeStart = 194239, XrefRangeEnd = 194250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInterstitialFinished(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialFinished_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x00067EA8 File Offset: 0x000660A8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194262, RefRangeEnd = 194263, XrefRangeStart = 194251, XrefRangeEnd = 194262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInterstitialFinished(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialFinished_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00067EE0 File Offset: 0x000660E0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194274, RefRangeEnd = 194277, XrefRangeStart = 194263, XrefRangeEnd = 194274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInterstitialLoadComplete(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialLoadComplete_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00067F18 File Offset: 0x00066118
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194288, RefRangeEnd = 194289, XrefRangeStart = 194277, XrefRangeEnd = 194288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInterstitialLoadComplete(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176C RID: 5996 RVA: 0x00067F50 File Offset: 0x00066150
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194300, RefRangeEnd = 194301, XrefRangeStart = 194289, XrefRangeEnd = 194300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnInterstitialLeftApplication(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x00067F88 File Offset: 0x00066188
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194312, RefRangeEnd = 194313, XrefRangeStart = 194301, XrefRangeEnd = 194312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnInterstitialLeftApplication(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00067FC0 File Offset: 0x000661C0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194324, RefRangeEnd = 194325, XrefRangeStart = 194313, XrefRangeEnd = 194324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnVideoFinished(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnVideoFinished_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00067FF8 File Offset: 0x000661F8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194336, RefRangeEnd = 194337, XrefRangeStart = 194325, XrefRangeEnd = 194336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnVideoFinished(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoFinished_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001770 RID: 6000 RVA: 0x00068030 File Offset: 0x00066230
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194348, RefRangeEnd = 194350, XrefRangeStart = 194337, XrefRangeEnd = 194348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnVideoLoadComplete(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnVideoLoadComplete_Public_Static_add_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x00068068 File Offset: 0x00066268
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194361, RefRangeEnd = 194362, XrefRangeStart = 194350, XrefRangeEnd = 194361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnVideoLoadComplete(Action<bool> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x000680A0 File Offset: 0x000662A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194373, RefRangeEnd = 194374, XrefRangeStart = 194362, XrefRangeEnd = 194373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_OnVideoLeftApplication(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001773 RID: 6003 RVA: 0x000680D8 File Offset: 0x000662D8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 194385, RefRangeEnd = 194386, XrefRangeStart = 194374, XrefRangeEnd = 194385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_OnVideoLeftApplication(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x00068110 File Offset: 0x00066310
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194386, XrefRangeEnd = 194391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x00068144 File Offset: 0x00066344
	[CallerCount(0)]
	public unsafe void SetFillRate(int fillRate)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fillRate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_SetFillRate_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00068184 File Offset: 0x00066384
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 194395, RefRangeEnd = 194398, XrefRangeStart = 194391, XrefRangeEnd = 194395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadInterstitial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_LoadInterstitial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x000681B8 File Offset: 0x000663B8
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowInterstitial()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_ShowInterstitial_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x000681EC File Offset: 0x000663EC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 194402, RefRangeEnd = 194404, XrefRangeStart = 194398, XrefRangeEnd = 194402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_LoadVideo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00068220 File Offset: 0x00066420
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ShowVideo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_ShowVideo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170006A2 RID: 1698
	// (get) Token: 0x0600177A RID: 6010 RVA: 0x00068254 File Offset: 0x00066454
	public unsafe bool IsVideoReady
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_IsVideoReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A3 RID: 1699
	// (get) Token: 0x0600177B RID: 6011 RVA: 0x00068290 File Offset: 0x00066490
	public unsafe bool IsVideoLoading
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_IsVideoLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A4 RID: 1700
	// (get) Token: 0x0600177C RID: 6012 RVA: 0x000682CC File Offset: 0x000664CC
	public unsafe bool IsInterstitialReady
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_IsInterstitialReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A5 RID: 1701
	// (get) Token: 0x0600177D RID: 6013 RVA: 0x00068308 File Offset: 0x00066508
	public unsafe bool IsInterstitialLoading
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_IsInterstitialLoading_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A6 RID: 1702
	// (get) Token: 0x0600177E RID: 6014 RVA: 0x00068344 File Offset: 0x00066544
	public unsafe bool HasFill
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194404, XrefRangeEnd = 194405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_HasFill_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A7 RID: 1703
	// (get) Token: 0x0600177F RID: 6015 RVA: 0x00068380 File Offset: 0x00066580
	public unsafe int FillRate
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_FillRate_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170006A8 RID: 1704
	// (get) Token: 0x06001780 RID: 6016 RVA: 0x000683BC File Offset: 0x000665BC
	public unsafe SA_Ad_EditorUIController EditorUI
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_get_EditorUI_Private_get_SA_Ad_EditorUIController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_Ad_EditorUIController>(intPtr3) : null;
		}
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x000683FC File Offset: 0x000665FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194405, XrefRangeEnd = 194414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVideoRequestComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnVideoRequestComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x00068430 File Offset: 0x00066630
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194414, XrefRangeEnd = 194423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialRequestComplete()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnInterstitialRequestComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00068464 File Offset: 0x00066664
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194423, XrefRangeEnd = 194431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialFinished_UIEvent(bool IsRewarded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsRewarded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnInterstitialFinished_UIEvent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x000684A4 File Offset: 0x000666A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194431, XrefRangeEnd = 194439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVideoFinished_UIEvent(bool IsRewarded)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref IsRewarded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnVideoFinished_UIEvent_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x000684E4 File Offset: 0x000666E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194439, XrefRangeEnd = 194445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInterstitialLeftApplication_UIEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnInterstitialLeftApplication_UIEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001786 RID: 6022 RVA: 0x00068518 File Offset: 0x00066718
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194445, XrefRangeEnd = 194451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnVideoLeftApplication_UIEvent()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr_OnVideoLeftApplication_UIEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001787 RID: 6023 RVA: 0x0006854C File Offset: 0x0006674C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194451, XrefRangeEnd = 194457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_EditorAd()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x0000B531 File Offset: 0x00009731
	public SA_EditorAd(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000694 RID: 1684
	// (get) Token: 0x06001789 RID: 6025 RVA: 0x00068588 File Offset: 0x00066788
	// (set) Token: 0x0600178A RID: 6026 RVA: 0x0000B53A File Offset: 0x0000973A
	public unsafe static float MIN_LOAD_TIME
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_MIN_LOAD_TIME, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_MIN_LOAD_TIME, (void*)(&value));
		}
	}

	// Token: 0x17000695 RID: 1685
	// (get) Token: 0x0600178B RID: 6027 RVA: 0x000685A4 File Offset: 0x000667A4
	// (set) Token: 0x0600178C RID: 6028 RVA: 0x0000B548 File Offset: 0x00009748
	public unsafe static float MAX_LOAD_TIME
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_MAX_LOAD_TIME, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_MAX_LOAD_TIME, (void*)(&value));
		}
	}

	// Token: 0x17000696 RID: 1686
	// (get) Token: 0x0600178D RID: 6029 RVA: 0x000685C0 File Offset: 0x000667C0
	// (set) Token: 0x0600178E RID: 6030 RVA: 0x0000B556 File Offset: 0x00009756
	public unsafe bool _IsInterstitialLoading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsInterstitialLoading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsInterstitialLoading)) = value;
		}
	}

	// Token: 0x17000697 RID: 1687
	// (get) Token: 0x0600178F RID: 6031 RVA: 0x000685E8 File Offset: 0x000667E8
	// (set) Token: 0x06001790 RID: 6032 RVA: 0x0000B571 File Offset: 0x00009771
	public unsafe bool _IsVideoLoading
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsVideoLoading);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsVideoLoading)) = value;
		}
	}

	// Token: 0x17000698 RID: 1688
	// (get) Token: 0x06001791 RID: 6033 RVA: 0x00068610 File Offset: 0x00066810
	// (set) Token: 0x06001792 RID: 6034 RVA: 0x0000B58C File Offset: 0x0000978C
	public unsafe bool _IsInterstitialReady
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsInterstitialReady);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsInterstitialReady)) = value;
		}
	}

	// Token: 0x17000699 RID: 1689
	// (get) Token: 0x06001793 RID: 6035 RVA: 0x00068638 File Offset: 0x00066838
	// (set) Token: 0x06001794 RID: 6036 RVA: 0x0000B5A7 File Offset: 0x000097A7
	public unsafe bool _IsVideoReady
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsVideoReady);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__IsVideoReady)) = value;
		}
	}

	// Token: 0x1700069A RID: 1690
	// (get) Token: 0x06001795 RID: 6037 RVA: 0x00068660 File Offset: 0x00066860
	// (set) Token: 0x06001796 RID: 6038 RVA: 0x0000B5C2 File Offset: 0x000097C2
	public unsafe int _FillRate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__FillRate);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__FillRate)) = value;
		}
	}

	// Token: 0x1700069B RID: 1691
	// (get) Token: 0x06001797 RID: 6039 RVA: 0x00068688 File Offset: 0x00066888
	// (set) Token: 0x06001798 RID: 6040 RVA: 0x0000B5DD File Offset: 0x000097DD
	public unsafe static Action<bool> OnInterstitialFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069C RID: 1692
	// (get) Token: 0x06001799 RID: 6041 RVA: 0x000686B0 File Offset: 0x000668B0
	// (set) Token: 0x0600179A RID: 6042 RVA: 0x0000B5EF File Offset: 0x000097EF
	public unsafe static Action<bool> OnInterstitialLoadComplete
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLoadComplete, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLoadComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069D RID: 1693
	// (get) Token: 0x0600179B RID: 6043 RVA: 0x000686D8 File Offset: 0x000668D8
	// (set) Token: 0x0600179C RID: 6044 RVA: 0x0000B601 File Offset: 0x00009801
	public unsafe static Action OnInterstitialLeftApplication
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLeftApplication, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnInterstitialLeftApplication, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069E RID: 1694
	// (get) Token: 0x0600179D RID: 6045 RVA: 0x00068700 File Offset: 0x00066900
	// (set) Token: 0x0600179E RID: 6046 RVA: 0x0000B613 File Offset: 0x00009813
	public unsafe static Action<bool> OnVideoFinished
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoFinished, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoFinished, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700069F RID: 1695
	// (get) Token: 0x0600179F RID: 6047 RVA: 0x00068728 File Offset: 0x00066928
	// (set) Token: 0x060017A0 RID: 6048 RVA: 0x0000B625 File Offset: 0x00009825
	public unsafe static Action<bool> OnVideoLoadComplete
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoLoadComplete, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoLoadComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A0 RID: 1696
	// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00068750 File Offset: 0x00066950
	// (set) Token: 0x060017A2 RID: 6050 RVA: 0x0000B637 File Offset: 0x00009837
	public unsafe static Action OnVideoLeftApplication
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoLeftApplication, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.NativeFieldInfoPtr_OnVideoLeftApplication, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170006A1 RID: 1697
	// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00068778 File Offset: 0x00066978
	// (set) Token: 0x060017A4 RID: 6052 RVA: 0x0000B649 File Offset: 0x00009849
	public unsafe SA_Ad_EditorUIController _EditorUI
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__EditorUI);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Ad_EditorUIController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_EditorAd.NativeFieldInfoPtr__EditorUI), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040011B7 RID: 4535
	private static readonly IntPtr NativeFieldInfoPtr_MIN_LOAD_TIME;

	// Token: 0x040011B8 RID: 4536
	private static readonly IntPtr NativeFieldInfoPtr_MAX_LOAD_TIME;

	// Token: 0x040011B9 RID: 4537
	private static readonly IntPtr NativeFieldInfoPtr__IsInterstitialLoading;

	// Token: 0x040011BA RID: 4538
	private static readonly IntPtr NativeFieldInfoPtr__IsVideoLoading;

	// Token: 0x040011BB RID: 4539
	private static readonly IntPtr NativeFieldInfoPtr__IsInterstitialReady;

	// Token: 0x040011BC RID: 4540
	private static readonly IntPtr NativeFieldInfoPtr__IsVideoReady;

	// Token: 0x040011BD RID: 4541
	private static readonly IntPtr NativeFieldInfoPtr__FillRate;

	// Token: 0x040011BE RID: 4542
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialFinished;

	// Token: 0x040011BF RID: 4543
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialLoadComplete;

	// Token: 0x040011C0 RID: 4544
	private static readonly IntPtr NativeFieldInfoPtr_OnInterstitialLeftApplication;

	// Token: 0x040011C1 RID: 4545
	private static readonly IntPtr NativeFieldInfoPtr_OnVideoFinished;

	// Token: 0x040011C2 RID: 4546
	private static readonly IntPtr NativeFieldInfoPtr_OnVideoLoadComplete;

	// Token: 0x040011C3 RID: 4547
	private static readonly IntPtr NativeFieldInfoPtr_OnVideoLeftApplication;

	// Token: 0x040011C4 RID: 4548
	private static readonly IntPtr NativeFieldInfoPtr__EditorUI;

	// Token: 0x040011C5 RID: 4549
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialFinished_Public_Static_add_Void_Action_1_Boolean_0;

	// Token: 0x040011C6 RID: 4550
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialFinished_Public_Static_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011C7 RID: 4551
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLoadComplete_Public_Static_add_Void_Action_1_Boolean_0;

	// Token: 0x040011C8 RID: 4552
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011C9 RID: 4553
	private static readonly IntPtr NativeMethodInfoPtr_add_OnInterstitialLeftApplication_Public_Static_add_Void_Action_0;

	// Token: 0x040011CA RID: 4554
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnInterstitialLeftApplication_Public_Static_rem_Void_Action_0;

	// Token: 0x040011CB RID: 4555
	private static readonly IntPtr NativeMethodInfoPtr_add_OnVideoFinished_Public_Static_add_Void_Action_1_Boolean_0;

	// Token: 0x040011CC RID: 4556
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnVideoFinished_Public_Static_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011CD RID: 4557
	private static readonly IntPtr NativeMethodInfoPtr_add_OnVideoLoadComplete_Public_Static_add_Void_Action_1_Boolean_0;

	// Token: 0x040011CE RID: 4558
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnVideoLoadComplete_Public_Static_rem_Void_Action_1_Boolean_0;

	// Token: 0x040011CF RID: 4559
	private static readonly IntPtr NativeMethodInfoPtr_add_OnVideoLeftApplication_Public_Static_add_Void_Action_0;

	// Token: 0x040011D0 RID: 4560
	private static readonly IntPtr NativeMethodInfoPtr_remove_OnVideoLeftApplication_Public_Static_rem_Void_Action_0;

	// Token: 0x040011D1 RID: 4561
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040011D2 RID: 4562
	private static readonly IntPtr NativeMethodInfoPtr_SetFillRate_Public_Void_Int32_0;

	// Token: 0x040011D3 RID: 4563
	private static readonly IntPtr NativeMethodInfoPtr_LoadInterstitial_Public_Void_0;

	// Token: 0x040011D4 RID: 4564
	private static readonly IntPtr NativeMethodInfoPtr_ShowInterstitial_Public_Void_0;

	// Token: 0x040011D5 RID: 4565
	private static readonly IntPtr NativeMethodInfoPtr_LoadVideo_Public_Void_0;

	// Token: 0x040011D6 RID: 4566
	private static readonly IntPtr NativeMethodInfoPtr_ShowVideo_Public_Void_0;

	// Token: 0x040011D7 RID: 4567
	private static readonly IntPtr NativeMethodInfoPtr_get_IsVideoReady_Public_get_Boolean_0;

	// Token: 0x040011D8 RID: 4568
	private static readonly IntPtr NativeMethodInfoPtr_get_IsVideoLoading_Public_get_Boolean_0;

	// Token: 0x040011D9 RID: 4569
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInterstitialReady_Public_get_Boolean_0;

	// Token: 0x040011DA RID: 4570
	private static readonly IntPtr NativeMethodInfoPtr_get_IsInterstitialLoading_Public_get_Boolean_0;

	// Token: 0x040011DB RID: 4571
	private static readonly IntPtr NativeMethodInfoPtr_get_HasFill_Public_get_Boolean_0;

	// Token: 0x040011DC RID: 4572
	private static readonly IntPtr NativeMethodInfoPtr_get_FillRate_Public_get_Int32_0;

	// Token: 0x040011DD RID: 4573
	private static readonly IntPtr NativeMethodInfoPtr_get_EditorUI_Private_get_SA_Ad_EditorUIController_0;

	// Token: 0x040011DE RID: 4574
	private static readonly IntPtr NativeMethodInfoPtr_OnVideoRequestComplete_Private_Void_0;

	// Token: 0x040011DF RID: 4575
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialRequestComplete_Private_Void_0;

	// Token: 0x040011E0 RID: 4576
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialFinished_UIEvent_Private_Void_Boolean_0;

	// Token: 0x040011E1 RID: 4577
	private static readonly IntPtr NativeMethodInfoPtr_OnVideoFinished_UIEvent_Private_Void_Boolean_0;

	// Token: 0x040011E2 RID: 4578
	private static readonly IntPtr NativeMethodInfoPtr_OnInterstitialLeftApplication_UIEvent_Private_Void_0;

	// Token: 0x040011E3 RID: 4579
	private static readonly IntPtr NativeMethodInfoPtr_OnVideoLeftApplication_UIEvent_Private_Void_0;

	// Token: 0x040011E4 RID: 4580
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020003A6 RID: 934
	[ObfuscatedName("SA_EditorAd+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003727 RID: 14119 RVA: 0x000E193C File Offset: 0x000DFB3C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_EditorAd>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr);
			SA_EditorAd.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, "<>9");
			SA_EditorAd.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670304);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_0_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670305);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_1_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670306);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670307);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_3_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670308);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_4_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670309);
			SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr, 100670310);
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x000E1A08 File Offset: 0x000DFC08
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_EditorAd.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x000E1A44 File Offset: 0x000DFC44
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_0(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_0_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x000E1A84 File Offset: 0x000DFC84
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_1(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_1_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x000E1AC4 File Offset: 0x000DFCC4
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x000E1AF8 File Offset: 0x000DFCF8
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_3(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_3_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x000E1B38 File Offset: 0x000DFD38
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_4(bool <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <p0>;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_4_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x000E1B78 File Offset: 0x000DFD78
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__53_5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorAd.__c.NativeMethodInfoPtr___cctor_b__53_5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x000155E4 File Offset: 0x000137E4
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06003730 RID: 14128 RVA: 0x000E1BAC File Offset: 0x000DFDAC
		// (set) Token: 0x06003731 RID: 14129 RVA: 0x000155ED File Offset: 0x000137ED
		public unsafe static SA_EditorAd.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SA_EditorAd.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_EditorAd.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SA_EditorAd.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400323A RID: 12858
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400323B RID: 12859
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400323C RID: 12860
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_0_Internal_Void_Boolean_0;

		// Token: 0x0400323D RID: 12861
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_1_Internal_Void_Boolean_0;

		// Token: 0x0400323E RID: 12862
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_2_Internal_Void_0;

		// Token: 0x0400323F RID: 12863
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_3_Internal_Void_Boolean_0;

		// Token: 0x04003240 RID: 12864
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_4_Internal_Void_Boolean_0;

		// Token: 0x04003241 RID: 12865
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__53_5_Internal_Void_0;
	}
}
