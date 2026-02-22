using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Common.Pattern;

// Token: 0x02000022 RID: 34
public class GoogleCloudMessageService : Singleton<GoogleCloudMessageService>
{
	// Token: 0x060003D4 RID: 980 RVA: 0x000236D4 File Offset: 0x000218D4
	// Note: this type is marked as 'beforefieldinit'.
	static GoogleCloudMessageService()
	{
		Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "GoogleCloudMessageService");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr);
		GoogleCloudMessageService.NativeFieldInfoPtr_ActionCouldMessageLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "ActionCouldMessageLoaded");
		GoogleCloudMessageService.NativeFieldInfoPtr_ActionCMDRegistrationResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "ActionCMDRegistrationResult");
		GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushLaunched = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "ActionGCMPushLaunched");
		GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "ActionGCMPushReceived");
		GoogleCloudMessageService.NativeFieldInfoPtr_ActionParsePushReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "ActionParsePushReceived");
		GoogleCloudMessageService.NativeFieldInfoPtr__lastMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "_lastMessage");
		GoogleCloudMessageService.NativeFieldInfoPtr__registrationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "_registrationId");
		GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionCouldMessageLoaded_Public_Static_add_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663716);
		GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionCouldMessageLoaded_Public_Static_rem_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663717);
		GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionCMDRegistrationResult_Public_Static_add_Void_Action_1_GP_GCM_RegistrationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663718);
		GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionCMDRegistrationResult_Public_Static_rem_Void_Action_1_GP_GCM_RegistrationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663719);
		GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionGCMPushLaunched_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663720);
		GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionGCMPushLaunched_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663721);
		GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionGCMPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663722);
		GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionGCMPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663723);
		GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionParsePushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663724);
		GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionParsePushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663725);
		GoogleCloudMessageService.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663726);
		GoogleCloudMessageService.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663727);
		GoogleCloudMessageService.NativeMethodInfoPtr_InitOneSignalNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663728);
		GoogleCloudMessageService.NativeMethodInfoPtr_InitPushNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663729);
		GoogleCloudMessageService.NativeMethodInfoPtr_InitPushNotifications_Public_Void_String_String_String_Boolean_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663730);
		GoogleCloudMessageService.NativeMethodInfoPtr_InitParsePushNotifications_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663731);
		GoogleCloudMessageService.NativeMethodInfoPtr_RgisterDevice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663732);
		GoogleCloudMessageService.NativeMethodInfoPtr_LoadLastMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663733);
		GoogleCloudMessageService.NativeMethodInfoPtr_RemoveLastMessageInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663734);
		GoogleCloudMessageService.NativeMethodInfoPtr_HideAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663735);
		GoogleCloudMessageService.NativeMethodInfoPtr_HandleOnPushReceived_Private_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663736);
		GoogleCloudMessageService.NativeMethodInfoPtr_GCMNotificationCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663737);
		GoogleCloudMessageService.NativeMethodInfoPtr_GCMNotificationLaunchedCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663738);
		GoogleCloudMessageService.NativeMethodInfoPtr_get_registrationId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663739);
		GoogleCloudMessageService.NativeMethodInfoPtr_get_lastMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663740);
		GoogleCloudMessageService.NativeMethodInfoPtr_OnLastMessageLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663741);
		GoogleCloudMessageService.NativeMethodInfoPtr_OnRegistrationReviced_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663742);
		GoogleCloudMessageService.NativeMethodInfoPtr_OnRegistrationFailed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663743);
		GoogleCloudMessageService.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, 100663744);
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x000239D4 File Offset: 0x00021BD4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162771, RefRangeEnd = 162772, XrefRangeStart = 162760, XrefRangeEnd = 162771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionCouldMessageLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionCouldMessageLoaded_Public_Static_add_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00023A0C File Offset: 0x00021C0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162772, XrefRangeEnd = 162783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionCouldMessageLoaded(Action<string> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionCouldMessageLoaded_Public_Static_rem_Void_Action_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00023A44 File Offset: 0x00021C44
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162794, RefRangeEnd = 162795, XrefRangeStart = 162783, XrefRangeEnd = 162794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionCMDRegistrationResult(Action<GP_GCM_RegistrationResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionCMDRegistrationResult_Public_Static_add_Void_Action_1_GP_GCM_RegistrationResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00023A7C File Offset: 0x00021C7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162795, XrefRangeEnd = 162806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionCMDRegistrationResult(Action<GP_GCM_RegistrationResult> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionCMDRegistrationResult_Public_Static_rem_Void_Action_1_GP_GCM_RegistrationResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00023AB4 File Offset: 0x00021CB4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162817, RefRangeEnd = 162818, XrefRangeStart = 162806, XrefRangeEnd = 162817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGCMPushLaunched(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionGCMPushLaunched_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00023AEC File Offset: 0x00021CEC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162818, XrefRangeEnd = 162829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGCMPushLaunched(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionGCMPushLaunched_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00023B24 File Offset: 0x00021D24
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162840, RefRangeEnd = 162841, XrefRangeStart = 162829, XrefRangeEnd = 162840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionGCMPushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionGCMPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00023B5C File Offset: 0x00021D5C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162841, XrefRangeEnd = 162852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionGCMPushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionGCMPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00023B94 File Offset: 0x00021D94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162852, XrefRangeEnd = 162863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void add_ActionParsePushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_add_ActionParsePushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00023BCC File Offset: 0x00021DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162863, XrefRangeEnd = 162874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void remove_ActionParsePushReceived(Action<string, Dictionary<string, Object>> value)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_remove_ActionParsePushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00023C04 File Offset: 0x00021E04
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162874, XrefRangeEnd = 162879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00023C38 File Offset: 0x00021E38
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 162896, RefRangeEnd = 162897, XrefRangeStart = 162879, XrefRangeEnd = 162896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Init()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00023C6C File Offset: 0x00021E6C
	[CallerCount(3728)]
	[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitOneSignalNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_InitOneSignalNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00023CA0 File Offset: 0x00021EA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162897, XrefRangeEnd = 162967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPushNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_InitPushNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00023CD4 File Offset: 0x00021ED4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162967, XrefRangeEnd = 162968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitPushNotifications(string smallIcon, string largeIcon, string sound, bool enableVibrationPush, bool showWhenAppForeground, bool replaceOldNotificationWithNew, string color)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(smallIcon);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(largeIcon);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sound);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableVibrationPush;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showWhenAppForeground;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replaceOldNotificationWithNew;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_InitPushNotifications_Public_Void_String_String_String_Boolean_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00023D78 File Offset: 0x00021F78
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162968, XrefRangeEnd = 162981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitParsePushNotifications()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_InitParsePushNotifications_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00023DAC File Offset: 0x00021FAC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 163037, RefRangeEnd = 163038, XrefRangeStart = 162981, XrefRangeEnd = 163037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RgisterDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_RgisterDevice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E6 RID: 998 RVA: 0x00023DE0 File Offset: 0x00021FE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 163039, RefRangeEnd = 163040, XrefRangeStart = 163038, XrefRangeEnd = 163039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void LoadLastMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_LoadLastMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x00023E14 File Offset: 0x00022014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163040, XrefRangeEnd = 163041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void RemoveLastMessageInfo()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_RemoveLastMessageInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00023E48 File Offset: 0x00022048
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163041, XrefRangeEnd = 163042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HideAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_HideAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00023E7C File Offset: 0x0002207C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163042, XrefRangeEnd = 163050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleOnPushReceived(string stringPayload, Dictionary<string, Object> payload)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(stringPayload);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payload);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_HandleOnPushReceived_Private_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003EA RID: 1002 RVA: 0x00023ED0 File Offset: 0x000220D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163050, XrefRangeEnd = 163086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GCMNotificationCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_GCMNotificationCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003EB RID: 1003 RVA: 0x00023F14 File Offset: 0x00022114
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163086, XrefRangeEnd = 163122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void GCMNotificationLaunchedCallback(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_GCMNotificationLaunchedCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x060003EC RID: 1004 RVA: 0x00023F58 File Offset: 0x00022158
	public unsafe string registrationId
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_get_registrationId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x1700015E RID: 350
	// (get) Token: 0x060003ED RID: 1005 RVA: 0x00023F90 File Offset: 0x00022190
	public unsafe string lastMessage
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_get_lastMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060003EE RID: 1006 RVA: 0x00023FC8 File Offset: 0x000221C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163122, XrefRangeEnd = 163130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLastMessageLoaded(string data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_OnLastMessageLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003EF RID: 1007 RVA: 0x0002400C File Offset: 0x0002220C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163130, XrefRangeEnd = 163144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRegistrationReviced(string regId)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(regId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_OnRegistrationReviced_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060003F0 RID: 1008 RVA: 0x00024050 File Offset: 0x00022250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163144, XrefRangeEnd = 163158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRegistrationFailed()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr_OnRegistrationFailed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003F1 RID: 1009 RVA: 0x00024084 File Offset: 0x00022284
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163158, XrefRangeEnd = 163167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GoogleCloudMessageService()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060003F2 RID: 1010 RVA: 0x00003BB4 File Offset: 0x00001DB4
	public GoogleCloudMessageService(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000156 RID: 342
	// (get) Token: 0x060003F3 RID: 1011 RVA: 0x000240C0 File Offset: 0x000222C0
	// (set) Token: 0x060003F4 RID: 1012 RVA: 0x00003BBD File Offset: 0x00001DBD
	public unsafe static Action<string> ActionCouldMessageLoaded
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionCouldMessageLoaded, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionCouldMessageLoaded, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000240E8 File Offset: 0x000222E8
	// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00003BCF File Offset: 0x00001DCF
	public unsafe static Action<GP_GCM_RegistrationResult> ActionCMDRegistrationResult
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionCMDRegistrationResult, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GP_GCM_RegistrationResult>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionCMDRegistrationResult, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00024110 File Offset: 0x00022310
	// (set) Token: 0x060003F8 RID: 1016 RVA: 0x00003BE1 File Offset: 0x00001DE1
	public unsafe static Action<string, Dictionary<string, Object>> ActionGCMPushLaunched
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushLaunched, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Dictionary<string, Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushLaunched, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00024138 File Offset: 0x00022338
	// (set) Token: 0x060003FA RID: 1018 RVA: 0x00003BF3 File Offset: 0x00001DF3
	public unsafe static Action<string, Dictionary<string, Object>> ActionGCMPushReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Dictionary<string, Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionGCMPushReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x060003FB RID: 1019 RVA: 0x00024160 File Offset: 0x00022360
	// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003C05 File Offset: 0x00001E05
	public unsafe static Action<string, Dictionary<string, Object>> ActionParsePushReceived
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionParsePushReceived, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string, Dictionary<string, Object>>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.NativeFieldInfoPtr_ActionParsePushReceived, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x060003FD RID: 1021 RVA: 0x00024188 File Offset: 0x00022388
	// (set) Token: 0x060003FE RID: 1022 RVA: 0x00003C17 File Offset: 0x00001E17
	public unsafe string _lastMessage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCloudMessageService.NativeFieldInfoPtr__lastMessage);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCloudMessageService.NativeFieldInfoPtr__lastMessage), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x060003FF RID: 1023 RVA: 0x000241B0 File Offset: 0x000223B0
	// (set) Token: 0x06000400 RID: 1024 RVA: 0x00003C36 File Offset: 0x00001E36
	public unsafe string _registrationId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCloudMessageService.NativeFieldInfoPtr__registrationId);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GoogleCloudMessageService.NativeFieldInfoPtr__registrationId), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040002DA RID: 730
	private static readonly IntPtr NativeFieldInfoPtr_ActionCouldMessageLoaded;

	// Token: 0x040002DB RID: 731
	private static readonly IntPtr NativeFieldInfoPtr_ActionCMDRegistrationResult;

	// Token: 0x040002DC RID: 732
	private static readonly IntPtr NativeFieldInfoPtr_ActionGCMPushLaunched;

	// Token: 0x040002DD RID: 733
	private static readonly IntPtr NativeFieldInfoPtr_ActionGCMPushReceived;

	// Token: 0x040002DE RID: 734
	private static readonly IntPtr NativeFieldInfoPtr_ActionParsePushReceived;

	// Token: 0x040002DF RID: 735
	private static readonly IntPtr NativeFieldInfoPtr__lastMessage;

	// Token: 0x040002E0 RID: 736
	private static readonly IntPtr NativeFieldInfoPtr__registrationId;

	// Token: 0x040002E1 RID: 737
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionCouldMessageLoaded_Public_Static_add_Void_Action_1_String_0;

	// Token: 0x040002E2 RID: 738
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionCouldMessageLoaded_Public_Static_rem_Void_Action_1_String_0;

	// Token: 0x040002E3 RID: 739
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionCMDRegistrationResult_Public_Static_add_Void_Action_1_GP_GCM_RegistrationResult_0;

	// Token: 0x040002E4 RID: 740
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionCMDRegistrationResult_Public_Static_rem_Void_Action_1_GP_GCM_RegistrationResult_0;

	// Token: 0x040002E5 RID: 741
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGCMPushLaunched_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002E6 RID: 742
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGCMPushLaunched_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002E7 RID: 743
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionGCMPushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002E8 RID: 744
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionGCMPushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002E9 RID: 745
	private static readonly IntPtr NativeMethodInfoPtr_add_ActionParsePushReceived_Public_Static_add_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002EA RID: 746
	private static readonly IntPtr NativeMethodInfoPtr_remove_ActionParsePushReceived_Public_Static_rem_Void_Action_2_String_Dictionary_2_String_Object_0;

	// Token: 0x040002EB RID: 747
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040002EC RID: 748
	private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

	// Token: 0x040002ED RID: 749
	private static readonly IntPtr NativeMethodInfoPtr_InitOneSignalNotifications_Public_Void_0;

	// Token: 0x040002EE RID: 750
	private static readonly IntPtr NativeMethodInfoPtr_InitPushNotifications_Public_Void_0;

	// Token: 0x040002EF RID: 751
	private static readonly IntPtr NativeMethodInfoPtr_InitPushNotifications_Public_Void_String_String_String_Boolean_Boolean_Boolean_String_0;

	// Token: 0x040002F0 RID: 752
	private static readonly IntPtr NativeMethodInfoPtr_InitParsePushNotifications_Public_Void_0;

	// Token: 0x040002F1 RID: 753
	private static readonly IntPtr NativeMethodInfoPtr_RgisterDevice_Public_Void_0;

	// Token: 0x040002F2 RID: 754
	private static readonly IntPtr NativeMethodInfoPtr_LoadLastMessage_Public_Void_0;

	// Token: 0x040002F3 RID: 755
	private static readonly IntPtr NativeMethodInfoPtr_RemoveLastMessageInfo_Public_Void_0;

	// Token: 0x040002F4 RID: 756
	private static readonly IntPtr NativeMethodInfoPtr_HideAll_Public_Void_0;

	// Token: 0x040002F5 RID: 757
	private static readonly IntPtr NativeMethodInfoPtr_HandleOnPushReceived_Private_Void_String_Dictionary_2_String_Object_0;

	// Token: 0x040002F6 RID: 758
	private static readonly IntPtr NativeMethodInfoPtr_GCMNotificationCallback_Private_Void_String_0;

	// Token: 0x040002F7 RID: 759
	private static readonly IntPtr NativeMethodInfoPtr_GCMNotificationLaunchedCallback_Private_Void_String_0;

	// Token: 0x040002F8 RID: 760
	private static readonly IntPtr NativeMethodInfoPtr_get_registrationId_Public_get_String_0;

	// Token: 0x040002F9 RID: 761
	private static readonly IntPtr NativeMethodInfoPtr_get_lastMessage_Public_get_String_0;

	// Token: 0x040002FA RID: 762
	private static readonly IntPtr NativeMethodInfoPtr_OnLastMessageLoaded_Private_Void_String_0;

	// Token: 0x040002FB RID: 763
	private static readonly IntPtr NativeMethodInfoPtr_OnRegistrationReviced_Private_Void_String_0;

	// Token: 0x040002FC RID: 764
	private static readonly IntPtr NativeMethodInfoPtr_OnRegistrationFailed_Private_Void_0;

	// Token: 0x040002FD RID: 765
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000369 RID: 873
	[ObfuscatedName("GoogleCloudMessageService+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06003471 RID: 13425 RVA: 0x000D8DA8 File Offset: 0x000D6FA8
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GoogleCloudMessageService>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr);
			GoogleCloudMessageService.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, "<>9");
			GoogleCloudMessageService.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669966);
			GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669967);
			GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_1_Internal_Void_GP_GCM_RegistrationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669968);
			GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_2_Internal_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669969);
			GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_3_Internal_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669970);
			GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_4_Internal_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr, 100669971);
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x000D8E60 File Offset: 0x000D7060
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GoogleCloudMessageService.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x000D8E9C File Offset: 0x000D709C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__38_0(string <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x000D8EE0 File Offset: 0x000D70E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__38_1(GP_GCM_RegistrationResult <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_1_Internal_Void_GP_GCM_RegistrationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003475 RID: 13429 RVA: 0x000D8F24 File Offset: 0x000D7124
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__38_2(string <p0>, Dictionary<string, Object> <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_2_Internal_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003476 RID: 13430 RVA: 0x000D8F78 File Offset: 0x000D7178
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__38_3(string <p0>, Dictionary<string, Object> <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_3_Internal_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x000D8FCC File Offset: 0x000D71CC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __cctor_b__38_4(string <p0>, Dictionary<string, Object> <p1>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(<p0>);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(<p1>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleCloudMessageService.__c.NativeMethodInfoPtr___cctor_b__38_4_Internal_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x000147BA File Offset: 0x000129BA
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C93 RID: 3219
		// (get) Token: 0x06003479 RID: 13433 RVA: 0x000D9020 File Offset: 0x000D7220
		// (set) Token: 0x0600347A RID: 13434 RVA: 0x000147C3 File Offset: 0x000129C3
		public unsafe static GoogleCloudMessageService.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GoogleCloudMessageService.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GoogleCloudMessageService.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GoogleCloudMessageService.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400308C RID: 12428
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x0400308D RID: 12429
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400308E RID: 12430
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__38_0_Internal_Void_String_0;

		// Token: 0x0400308F RID: 12431
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__38_1_Internal_Void_GP_GCM_RegistrationResult_0;

		// Token: 0x04003090 RID: 12432
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__38_2_Internal_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x04003091 RID: 12433
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__38_3_Internal_Void_String_Dictionary_2_String_Object_0;

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeMethodInfoPtr___cctor_b__38_4_Internal_Void_String_Dictionary_2_String_Object_0;
	}
}
