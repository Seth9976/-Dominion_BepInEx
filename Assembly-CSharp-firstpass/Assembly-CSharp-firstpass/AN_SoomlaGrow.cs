using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using SA.Common.Pattern;

// Token: 0x02000005 RID: 5
public class AN_SoomlaGrow : Singleton<AN_SoomlaGrow>
{
	// Token: 0x06000006 RID: 6 RVA: 0x00016C10 File Offset: 0x00014E10
	// Note: this type is marked as 'beforefieldinit'.
	static AN_SoomlaGrow()
	{
		Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_SoomlaGrow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr);
		AN_SoomlaGrow.NativeFieldInfoPtr__IsInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, "_IsInitialized");
		AN_SoomlaGrow.NativeFieldInfoPtr_ActionInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, "ActionInitialized");
		AN_SoomlaGrow.NativeFieldInfoPtr_ActionConnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, "ActionConnected");
		AN_SoomlaGrow.NativeFieldInfoPtr_ActionDisconnected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, "ActionDisconnected");
		AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionInitialized_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663299);
		AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionInitialized_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663300);
		AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionConnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663301);
		AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionConnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663302);
		AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionDisconnected_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663303);
		AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionDisconnected_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663304);
		AN_SoomlaGrow.NativeMethodInfoPtr_CreateListner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663305);
		AN_SoomlaGrow.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663306);
		AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseStarted_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663307);
		AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseFinished_Public_Static_Void_String_Int64_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663308);
		AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseCanceled_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663309);
		AN_SoomlaGrow.NativeMethodInfoPtr_SetPurhsesSupportedState_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663310);
		AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseError_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663311);
		AN_SoomlaGrow.NativeMethodInfoPtr_FriendsRequest_Private_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663312);
		AN_SoomlaGrow.NativeMethodInfoPtr_SocialLogin_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663313);
		AN_SoomlaGrow.NativeMethodInfoPtr_SocialLoginFinished_Public_Static_Void_AN_SoomlaSocialProvider_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663314);
		AN_SoomlaGrow.NativeMethodInfoPtr_SocialLogOut_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663315);
		AN_SoomlaGrow.NativeMethodInfoPtr_SocialShare_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663316);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnFriendsRequestStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663317);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_HandleOnFriendsDataRequestCompleteAction_Private_Static_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663318);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnAuthCompleteAction_Private_Static_Void_FB_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663319);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnLoginStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663320);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnLogOut_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663321);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_PostStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663322);
		AN_SoomlaGrow.NativeMethodInfoPtr_FB_PostCompleted_Private_Static_Void_FB_PostResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663323);
		AN_SoomlaGrow.NativeMethodInfoPtr_HandleOnAuthCompleteAction_Private_Static_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663324);
		AN_SoomlaGrow.NativeMethodInfoPtr_HandleOnUserDataRequestCompleteAction_Private_Static_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663325);
		AN_SoomlaGrow.NativeMethodInfoPtr_OnTwitterLoginStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663326);
		AN_SoomlaGrow.NativeMethodInfoPtr_OnTwitterLogOut_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663327);
		AN_SoomlaGrow.NativeMethodInfoPtr_TW_PostStarted_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663328);
		AN_SoomlaGrow.NativeMethodInfoPtr_TW_PostCompleted_Private_Static_Void_TWResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663329);
		AN_SoomlaGrow.NativeMethodInfoPtr_CheckState_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663330);
		AN_SoomlaGrow.NativeMethodInfoPtr_OnInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663331);
		AN_SoomlaGrow.NativeMethodInfoPtr_OnConnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663332);
		AN_SoomlaGrow.NativeMethodInfoPtr_OnDisconnected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663333);
		AN_SoomlaGrow.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, 100663334);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00016F60 File Offset: 0x00015160
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159074, XrefRangeEnd = 159085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionInitialized(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionInitialized_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00016F98 File Offset: 0x00015198
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159085, XrefRangeEnd = 159096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionInitialized(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionInitialized_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00016FD0 File Offset: 0x000151D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159096, XrefRangeEnd = 159107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionConnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionConnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00017008 File Offset: 0x00015208
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159107, XrefRangeEnd = 159118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionConnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionConnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00017040 File Offset: 0x00015240
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159118, XrefRangeEnd = 159129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionDisconnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_add_ActionDisconnected_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00017078 File Offset: 0x00015278
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159129, XrefRangeEnd = 159140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionDisconnected(Action value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_remove_ActionDisconnected_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000170B0 File Offset: 0x000152B0
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CreateListner()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_CreateListner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000170E4 File Offset: 0x000152E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 159280, RefRangeEnd = 159281, XrefRangeStart = 159140, XrefRangeEnd = 159280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void Init()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x0001710C File Offset: 0x0001530C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 159291, RefRangeEnd = 159297, XrefRangeStart = 159281, XrefRangeEnd = 159291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PurchaseStarted(string prodcutId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prodcutId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseStarted_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00017144 File Offset: 0x00015344
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 159312, RefRangeEnd = 159316, XrefRangeStart = 159297, XrefRangeEnd = 159312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PurchaseFinished(string prodcutId, long priceInMicros, string currency)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prodcutId);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priceInMicros;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currency);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseFinished_Public_Static_Void_String_Int64_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x0001719C File Offset: 0x0001539C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159326, RefRangeEnd = 159328, XrefRangeStart = 159316, XrefRangeEnd = 159326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PurchaseCanceled(string prodcutId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(prodcutId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseCanceled_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000171D4 File Offset: 0x000153D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159328, XrefRangeEnd = 159341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetPurhsesSupportedState(bool isSupported)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isSupported;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_SetPurhsesSupportedState_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00017208 File Offset: 0x00015408
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159350, RefRangeEnd = 159352, XrefRangeStart = 159341, XrefRangeEnd = 159350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PurchaseError()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_PurchaseError_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00017230 File Offset: 0x00015430
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 159368, RefRangeEnd = 159371, XrefRangeStart = 159352, XrefRangeEnd = 159368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FriendsRequest(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref provider;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FriendsRequest_Private_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00017270 File Offset: 0x00015470
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 159387, RefRangeEnd = 159392, XrefRangeStart = 159371, XrefRangeEnd = 159387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SocialLogin(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref provider;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_SocialLogin_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x000172B0 File Offset: 0x000154B0
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 159406, RefRangeEnd = 159408, XrefRangeStart = 159392, XrefRangeEnd = 159406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SocialLoginFinished(AN_SoomlaSocialProvider provider, string ProfileId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref provider;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ProfileId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_SocialLoginFinished_Public_Static_Void_AN_SoomlaSocialProvider_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000172F4 File Offset: 0x000154F4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 159424, RefRangeEnd = 159428, XrefRangeStart = 159408, XrefRangeEnd = 159424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SocialLogOut(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref provider;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_SocialLogOut_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00017334 File Offset: 0x00015534
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 159444, RefRangeEnd = 159450, XrefRangeStart = 159428, XrefRangeEnd = 159444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SocialShare(AN_SoomlaEventType eventType, AN_SoomlaSocialProvider provider)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref eventType;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref provider;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_SocialShare_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00017374 File Offset: 0x00015574
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159450, XrefRangeEnd = 159454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_OnFriendsRequestStarted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnFriendsRequestStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0001739C File Offset: 0x0001559C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159454, XrefRangeEnd = 159461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_HandleOnFriendsDataRequestCompleteAction(FB_Result res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_HandleOnFriendsDataRequestCompleteAction_Private_Static_Void_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001B RID: 27 RVA: 0x000173D4 File Offset: 0x000155D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159461, XrefRangeEnd = 159476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_OnAuthCompleteAction(FB_Result res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnAuthCompleteAction_Private_Static_Void_FB_Result_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600001C RID: 28 RVA: 0x0001740C File Offset: 0x0001560C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159476, XrefRangeEnd = 159480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_OnLoginStarted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnLoginStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00017434 File Offset: 0x00015634
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159480, XrefRangeEnd = 159485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_OnLogOut()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_OnLogOut_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001E RID: 30 RVA: 0x0001745C File Offset: 0x0001565C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159485, XrefRangeEnd = 159489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_PostStarted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_PostStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00017484 File Offset: 0x00015684
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159489, XrefRangeEnd = 159512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void FB_PostCompleted(FB_PostResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_FB_PostCompleted_Private_Static_Void_FB_PostResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000174BC File Offset: 0x000156BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159512, XrefRangeEnd = 159524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleOnAuthCompleteAction(TWResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_HandleOnAuthCompleteAction_Private_Static_Void_TWResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000174F4 File Offset: 0x000156F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159524, XrefRangeEnd = 159538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HandleOnUserDataRequestCompleteAction(TWResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_HandleOnUserDataRequestCompleteAction_Private_Static_Void_TWResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0001752C File Offset: 0x0001572C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159538, XrefRangeEnd = 159542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnTwitterLoginStarted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_OnTwitterLoginStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00017554 File Offset: 0x00015754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159542, XrefRangeEnd = 159547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void OnTwitterLogOut()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_OnTwitterLogOut_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000024 RID: 36 RVA: 0x0001757C File Offset: 0x0001577C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159547, XrefRangeEnd = 159578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TW_PostStarted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_TW_PostStarted_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000025 RID: 37 RVA: 0x000175A4 File Offset: 0x000157A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159578, XrefRangeEnd = 159585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void TW_PostCompleted(TWResult res)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_TW_PostCompleted_Private_Static_Void_TWResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000026 RID: 38 RVA: 0x000175DC File Offset: 0x000157DC
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 159596, RefRangeEnd = 159607, XrefRangeStart = 159585, XrefRangeEnd = 159596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool CheckState()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_CheckState_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0001760C File Offset: 0x0001580C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159607, XrefRangeEnd = 159619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnInitialized()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_OnInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00017640 File Offset: 0x00015840
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159619, XrefRangeEnd = 159625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnConnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_OnConnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00017674 File Offset: 0x00015874
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159625, XrefRangeEnd = 159631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisconnected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr_OnDisconnected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000176A8 File Offset: 0x000158A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159631, XrefRangeEnd = 159637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_SoomlaGrow()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002B RID: 43 RVA: 0x0000206B File Offset: 0x0000026B
	public AN_SoomlaGrow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x0600002C RID: 44 RVA: 0x000176E4 File Offset: 0x000158E4
	// (set) Token: 0x0600002D RID: 45 RVA: 0x00002074 File Offset: 0x00000274
	public unsafe static bool _IsInitialized
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(AN_SoomlaGrow.NativeFieldInfoPtr__IsInitialized, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SoomlaGrow.NativeFieldInfoPtr__IsInitialized, (void*)(&value));
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x0600002E RID: 46 RVA: 0x00017700 File Offset: 0x00015900
	// (set) Token: 0x0600002F RID: 47 RVA: 0x00002082 File Offset: 0x00000282
	public unsafe static Action ActionInitialized
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionInitialized, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionInitialized, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000030 RID: 48 RVA: 0x00017728 File Offset: 0x00015928
	// (set) Token: 0x06000031 RID: 49 RVA: 0x00002094 File Offset: 0x00000294
	public unsafe static Action ActionConnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionConnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionConnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000032 RID: 50 RVA: 0x00017750 File Offset: 0x00015950
	// (set) Token: 0x06000033 RID: 51 RVA: 0x000020A6 File Offset: 0x000002A6
	public unsafe static Action ActionDisconnected
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionDisconnected, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_SoomlaGrow.NativeFieldInfoPtr_ActionDisconnected, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr__IsInitialized;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeFieldInfoPtr_ActionInitialized;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_ActionConnected;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_ActionDisconnected;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionInitialized_Public_Static_add_Void_Action_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionInitialized_Public_Static_rem_Void_Action_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionConnected_Public_Static_add_Void_Action_0;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionConnected_Public_Static_rem_Void_Action_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionDisconnected_Public_Static_add_Void_Action_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionDisconnected_Public_Static_rem_Void_Action_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_CreateListner_Public_Void_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseStarted_Public_Static_Void_String_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseFinished_Public_Static_Void_String_Int64_String_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseCanceled_Public_Static_Void_String_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr_SetPurhsesSupportedState_Public_Static_Void_Boolean_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_PurchaseError_Public_Static_Void_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_FriendsRequest_Private_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr_SocialLogin_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_SocialLoginFinished_Public_Static_Void_AN_SoomlaSocialProvider_String_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_SocialLogOut_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_SocialShare_Public_Static_Void_AN_SoomlaEventType_AN_SoomlaSocialProvider_0;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_FB_OnFriendsRequestStarted_Private_Static_Void_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_FB_HandleOnFriendsDataRequestCompleteAction_Private_Static_Void_FB_Result_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_FB_OnAuthCompleteAction_Private_Static_Void_FB_Result_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_FB_OnLoginStarted_Private_Static_Void_0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_FB_OnLogOut_Private_Static_Void_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_FB_PostStarted_Private_Static_Void_0;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_FB_PostCompleted_Private_Static_Void_FB_PostResult_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnAuthCompleteAction_Private_Static_Void_TWResult_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnUserDataRequestCompleteAction_Private_Static_Void_TWResult_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_OnTwitterLoginStarted_Private_Static_Void_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_OnTwitterLogOut_Private_Static_Void_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_TW_PostStarted_Private_Static_Void_0;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr_TW_PostCompleted_Private_Static_Void_TWResult_0;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeMethodInfoPtr_CheckState_Private_Static_Boolean_0;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_OnInitialized_Private_Void_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr_OnConnected_Private_Void_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr_OnDisconnected_Private_Void_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000362 RID: 866
	[ObfuscatedName("AN_SoomlaGrow+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x060033E4 RID: 13284 RVA: 0x000D7400 File Offset: 0x000D5600
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AN_SoomlaGrow>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr);
			AN_SoomlaGrow.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr, "<>9");
			AN_SoomlaGrow.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr, 100669912);
			AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr, 100669913);
			AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr, 100669914);
			AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr, 100669915);
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000D7490 File Offset: 0x000D5690
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_SoomlaGrow.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000D74CC File Offset: 0x000D56CC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__40_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000D7500 File Offset: 0x000D5700
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__40_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000D7534 File Offset: 0x000D5734
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__40_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_SoomlaGrow.__c.NativeMethodInfoPtr___cctor_b__40_2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000144AB File Offset: 0x000126AB
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060033EA RID: 13290 RVA: 0x000D7568 File Offset: 0x000D5768
		// (set) Token: 0x060033EB RID: 13291 RVA: 0x000144B4 File Offset: 0x000126B4
		public unsafe static AN_SoomlaGrow.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AN_SoomlaGrow.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AN_SoomlaGrow.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AN_SoomlaGrow.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003035 RID: 12341
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04003036 RID: 12342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003037 RID: 12343
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__40_0_Internal_Void_0;

		// Token: 0x04003038 RID: 12344
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__40_1_Internal_Void_0;

		// Token: 0x04003039 RID: 12345
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__40_2_Internal_Void_0;
	}
}
