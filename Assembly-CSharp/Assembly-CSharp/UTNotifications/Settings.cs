using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace UTNotifications
{
	// Token: 0x020000F2 RID: 242
	public class Settings : ScriptableObject
	{
		// Token: 0x06001D24 RID: 7460 RVA: 0x000722D0 File Offset: 0x000704D0
		// Note: this type is marked as 'beforefieldinit'.
		static Settings()
		{
			Il2CppClassPointerStore<Settings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "Settings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings>.NativeClassPtr);
			Settings.NativeFieldInfoPtr_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "Version");
			Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DEFAULT_PROFILE_NAME");
			Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME_INTERNAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "DEFAULT_PROFILE_NAME_INTERNAL");
			Settings.NativeFieldInfoPtr_m_notificationProfiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_notificationProfiles");
			Settings.NativeFieldInfoPtr_m_pushPayloadTitleFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadTitleFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadTextFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadTextFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadIdFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadIdFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadUserDataParentFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadUserDataParentFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadNotificationProfileFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadNotificationProfileFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadBadgeFieldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadBadgeFieldName");
			Settings.NativeFieldInfoPtr_m_pushPayloadButtonsParentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushPayloadButtonsParentName");
			Settings.NativeFieldInfoPtr_m_googlePlayServicesLibVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_googlePlayServicesLibVersion");
			Settings.NativeFieldInfoPtr_m_androidSupportLibVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_androidSupportLibVersion");
			Settings.NativeFieldInfoPtr_m_androidShowNotificationsMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_androidShowNotificationsMode");
			Settings.NativeFieldInfoPtr_m_android4CompatibilityMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_android4CompatibilityMode");
			Settings.NativeFieldInfoPtr_m_androidRestoreScheduledNotificationsAfterReboot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_androidRestoreScheduledNotificationsAfterReboot");
			Settings.NativeFieldInfoPtr_m_androidNotificationsGrouping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_androidNotificationsGrouping");
			Settings.NativeFieldInfoPtr_m_androidShowLatestNotificationOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_androidShowLatestNotificationOnly");
			Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledIOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushNotificationsEnabledIOS");
			Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledFirebase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushNotificationsEnabledFirebase");
			Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledAmazon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushNotificationsEnabledAmazon");
			Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledWindows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_pushNotificationsEnabledWindows");
			Settings.NativeFieldInfoPtr_m_allowUpdatingGooglePlayIfRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_allowUpdatingGooglePlayIfRequired");
			Settings.NativeFieldInfoPtr_m_firebaseSenderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_firebaseSenderID");
			Settings.NativeFieldInfoPtr_m_assetVersionSaved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_assetVersionSaved");
			Settings.NativeFieldInfoPtr_m_windowsDontShowWhenRunning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_windowsDontShowWhenRunning");
			Settings.NativeFieldInfoPtr_m_assetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_assetName");
			Settings.NativeFieldInfoPtr_m_settingsMenuItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_settingsMenuItem");
			Settings.NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings>.NativeClassPtr, "m_instance");
			Settings.NativeMethodInfoPtr_get_Instance_Public_Static_get_Settings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665629);
			Settings.NativeMethodInfoPtr_get_NotificationProfiles_Public_get_List_1_NotificationProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665630);
			Settings.NativeMethodInfoPtr_get_PushPayloadTitleFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665631);
			Settings.NativeMethodInfoPtr_set_PushPayloadTitleFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665632);
			Settings.NativeMethodInfoPtr_get_PushPayloadTextFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665633);
			Settings.NativeMethodInfoPtr_set_PushPayloadTextFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665634);
			Settings.NativeMethodInfoPtr_get_PushPayloadIdFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665635);
			Settings.NativeMethodInfoPtr_set_PushPayloadIdFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665636);
			Settings.NativeMethodInfoPtr_get_PushPayloadUserDataParentFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665637);
			Settings.NativeMethodInfoPtr_set_PushPayloadUserDataParentFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665638);
			Settings.NativeMethodInfoPtr_get_PushPayloadNotificationProfileFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665639);
			Settings.NativeMethodInfoPtr_set_PushPayloadNotificationProfileFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665640);
			Settings.NativeMethodInfoPtr_get_PushPayloadBadgeFieldName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665641);
			Settings.NativeMethodInfoPtr_set_PushPayloadBadgeFieldName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665642);
			Settings.NativeMethodInfoPtr_get_PushPayloadButtonsParentName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665643);
			Settings.NativeMethodInfoPtr_set_PushPayloadButtonsParentName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665644);
			Settings.NativeMethodInfoPtr_get_GooglePlayServicesLibVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665645);
			Settings.NativeMethodInfoPtr_set_GooglePlayServicesLibVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665646);
			Settings.NativeMethodInfoPtr_get_AndroidSupportLibVersion_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665647);
			Settings.NativeMethodInfoPtr_set_AndroidSupportLibVersion_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665648);
			Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledIOS_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665649);
			Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledIOS_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665650);
			Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledFirebase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665651);
			Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledFirebase_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665652);
			Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledAmazon_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665653);
			Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledAmazon_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665654);
			Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledWindows_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665655);
			Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledWindows_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665656);
			Settings.NativeMethodInfoPtr_get_AndroidShowNotificationsMode_Public_get_ShowNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665657);
			Settings.NativeMethodInfoPtr_set_AndroidShowNotificationsMode_Public_set_Void_ShowNotifications_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665658);
			Settings.NativeMethodInfoPtr_get_AndroidRestoreScheduledNotificationsAfterReboot_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665659);
			Settings.NativeMethodInfoPtr_get_AndroidNotificationsGrouping_Public_get_NotificationsGroupingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665660);
			Settings.NativeMethodInfoPtr_set_AndroidNotificationsGrouping_Public_set_Void_NotificationsGroupingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665661);
			Settings.NativeMethodInfoPtr_get_AllowUpdatingGooglePlayIfRequired_Public_get_GooglePlayUpdatingIfRequiredMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665662);
			Settings.NativeMethodInfoPtr_set_AllowUpdatingGooglePlayIfRequired_Public_set_Void_GooglePlayUpdatingIfRequiredMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665663);
			Settings.NativeMethodInfoPtr_get_AndroidShowLatestNotificationOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665664);
			Settings.NativeMethodInfoPtr_get_FirebaseSenderID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665665);
			Settings.NativeMethodInfoPtr_get_WindowsDontShowWhenRunning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665666);
			Settings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings>.NativeClassPtr, 100665667);
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x00072850 File Offset: 0x00070A50
		public unsafe static Settings Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254508, XrefRangeEnd = 254529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_Instance_Public_Static_get_Settings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Settings>(intPtr3) : null;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x00072884 File Offset: 0x00070A84
		public unsafe List<Settings.NotificationProfile> NotificationProfiles
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254529, XrefRangeEnd = 254538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_NotificationProfiles_Public_get_List_1_NotificationProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Settings.NotificationProfile>>(intPtr3) : null;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000728C4 File Offset: 0x00070AC4
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x000728FC File Offset: 0x00070AFC
		public unsafe string PushPayloadTitleFieldName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadTitleFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254538, XrefRangeEnd = 254539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadTitleFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x00072940 File Offset: 0x00070B40
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x00072978 File Offset: 0x00070B78
		public unsafe string PushPayloadTextFieldName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadTextFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254539, XrefRangeEnd = 254540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadTextFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x000729BC File Offset: 0x00070BBC
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x000729F4 File Offset: 0x00070BF4
		public unsafe string PushPayloadIdFieldName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadIdFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254540, XrefRangeEnd = 254541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadIdFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x00072A38 File Offset: 0x00070C38
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x00072A70 File Offset: 0x00070C70
		public unsafe string PushPayloadUserDataParentFieldName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadUserDataParentFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254541, XrefRangeEnd = 254542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadUserDataParentFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x00072AB4 File Offset: 0x00070CB4
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x00072AEC File Offset: 0x00070CEC
		public unsafe string PushPayloadNotificationProfileFieldName
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadNotificationProfileFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254542, XrefRangeEnd = 254543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadNotificationProfileFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00072B30 File Offset: 0x00070D30
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x00072B68 File Offset: 0x00070D68
		public unsafe string PushPayloadBadgeFieldName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadBadgeFieldName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254543, XrefRangeEnd = 254544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadBadgeFieldName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x00072BAC File Offset: 0x00070DAC
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x00072BE4 File Offset: 0x00070DE4
		public unsafe string PushPayloadButtonsParentName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushPayloadButtonsParentName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254544, XrefRangeEnd = 254545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushPayloadButtonsParentName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x00072C28 File Offset: 0x00070E28
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x00072C60 File Offset: 0x00070E60
		public unsafe string GooglePlayServicesLibVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_GooglePlayServicesLibVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254545, XrefRangeEnd = 254546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_GooglePlayServicesLibVersion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x00072CA4 File Offset: 0x00070EA4
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x00072CDC File Offset: 0x00070EDC
		public unsafe string AndroidSupportLibVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AndroidSupportLibVersion_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254546, XrefRangeEnd = 254547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_AndroidSupportLibVersion_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x00072D20 File Offset: 0x00070F20
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x00072D5C File Offset: 0x00070F5C
		public unsafe bool PushNotificationsEnabledIOS
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledIOS_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledIOS_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x00072D9C File Offset: 0x00070F9C
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x00072DD8 File Offset: 0x00070FD8
		public unsafe bool PushNotificationsEnabledFirebase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledFirebase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledFirebase_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x00072E18 File Offset: 0x00071018
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x00072E54 File Offset: 0x00071054
		public unsafe bool PushNotificationsEnabledAmazon
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledAmazon_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledAmazon_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x00072E94 File Offset: 0x00071094
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x00072ED0 File Offset: 0x000710D0
		public unsafe bool PushNotificationsEnabledWindows
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_PushNotificationsEnabledWindows_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_PushNotificationsEnabledWindows_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x00072F10 File Offset: 0x00071110
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x00072F4C File Offset: 0x0007114C
		public unsafe Settings.ShowNotifications AndroidShowNotificationsMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AndroidShowNotificationsMode_Public_get_ShowNotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_AndroidShowNotificationsMode_Public_set_Void_ShowNotifications_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x00072F8C File Offset: 0x0007118C
		public unsafe bool AndroidRestoreScheduledNotificationsAfterReboot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AndroidRestoreScheduledNotificationsAfterReboot_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06001D44 RID: 7492 RVA: 0x00072FC8 File Offset: 0x000711C8
		// (set) Token: 0x06001D45 RID: 7493 RVA: 0x00073004 File Offset: 0x00071204
		public unsafe Settings.NotificationsGroupingMode AndroidNotificationsGrouping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AndroidNotificationsGrouping_Public_get_NotificationsGroupingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_AndroidNotificationsGrouping_Public_set_Void_NotificationsGroupingMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06001D46 RID: 7494 RVA: 0x00073044 File Offset: 0x00071244
		// (set) Token: 0x06001D47 RID: 7495 RVA: 0x00073080 File Offset: 0x00071280
		public unsafe Settings.GooglePlayUpdatingIfRequiredMode AllowUpdatingGooglePlayIfRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AllowUpdatingGooglePlayIfRequired_Public_get_GooglePlayUpdatingIfRequiredMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_set_AllowUpdatingGooglePlayIfRequired_Public_set_Void_GooglePlayUpdatingIfRequiredMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06001D48 RID: 7496 RVA: 0x000730C0 File Offset: 0x000712C0
		public unsafe bool AndroidShowLatestNotificationOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_AndroidShowLatestNotificationOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x000730FC File Offset: 0x000712FC
		public unsafe string FirebaseSenderID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_FirebaseSenderID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06001D4A RID: 7498 RVA: 0x00073134 File Offset: 0x00071334
		public unsafe bool WindowsDontShowWhenRunning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr_get_WindowsDontShowWhenRunning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00073170 File Offset: 0x00071370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254547, XrefRangeEnd = 254574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Settings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x00012813 File Offset: 0x00010A13
		public Settings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x000731AC File Offset: 0x000713AC
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0001281C File Offset: 0x00010A1C
		public unsafe static string Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000731CC File Offset: 0x000713CC
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0001282E File Offset: 0x00010A2E
		public unsafe static string DEFAULT_PROFILE_NAME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x000731EC File Offset: 0x000713EC
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x00012840 File Offset: 0x00010A40
		public unsafe static string DEFAULT_PROFILE_NAME_INTERNAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME_INTERNAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_DEFAULT_PROFILE_NAME_INTERNAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0007320C File Offset: 0x0007140C
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x00012852 File Offset: 0x00010A52
		public unsafe List<Settings.NotificationProfile> m_notificationProfiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_notificationProfiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Settings.NotificationProfile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_notificationProfiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0007323C File Offset: 0x0007143C
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x00012871 File Offset: 0x00010A71
		public unsafe string m_pushPayloadTitleFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadTitleFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadTitleFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x00073264 File Offset: 0x00071464
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x00012890 File Offset: 0x00010A90
		public unsafe string m_pushPayloadTextFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadTextFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadTextFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0007328C File Offset: 0x0007148C
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x000128AF File Offset: 0x00010AAF
		public unsafe string m_pushPayloadIdFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadIdFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadIdFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x000732B4 File Offset: 0x000714B4
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x000128CE File Offset: 0x00010ACE
		public unsafe string m_pushPayloadUserDataParentFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadUserDataParentFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadUserDataParentFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x000732DC File Offset: 0x000714DC
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x000128ED File Offset: 0x00010AED
		public unsafe string m_pushPayloadNotificationProfileFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadNotificationProfileFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadNotificationProfileFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x00073304 File Offset: 0x00071504
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0001290C File Offset: 0x00010B0C
		public unsafe string m_pushPayloadBadgeFieldName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadBadgeFieldName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadBadgeFieldName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0007332C File Offset: 0x0007152C
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0001292B File Offset: 0x00010B2B
		public unsafe string m_pushPayloadButtonsParentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadButtonsParentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushPayloadButtonsParentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x00073354 File Offset: 0x00071554
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0001294A File Offset: 0x00010B4A
		public unsafe string m_googlePlayServicesLibVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_googlePlayServicesLibVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_googlePlayServicesLibVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0007337C File Offset: 0x0007157C
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x00012969 File Offset: 0x00010B69
		public unsafe string m_androidSupportLibVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidSupportLibVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidSupportLibVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x000733A4 File Offset: 0x000715A4
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x00012988 File Offset: 0x00010B88
		public unsafe Settings.ShowNotifications m_androidShowNotificationsMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidShowNotificationsMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidShowNotificationsMode)) = value;
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x000733CC File Offset: 0x000715CC
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x000129A3 File Offset: 0x00010BA3
		public unsafe bool m_android4CompatibilityMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_android4CompatibilityMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_android4CompatibilityMode)) = value;
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x000733F4 File Offset: 0x000715F4
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x000129BE File Offset: 0x00010BBE
		public unsafe bool m_androidRestoreScheduledNotificationsAfterReboot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidRestoreScheduledNotificationsAfterReboot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidRestoreScheduledNotificationsAfterReboot)) = value;
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0007341C File Offset: 0x0007161C
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x000129D9 File Offset: 0x00010BD9
		public unsafe Settings.NotificationsGroupingMode m_androidNotificationsGrouping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidNotificationsGrouping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidNotificationsGrouping)) = value;
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x00073444 File Offset: 0x00071644
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x000129F4 File Offset: 0x00010BF4
		public unsafe bool m_androidShowLatestNotificationOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidShowLatestNotificationOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_androidShowLatestNotificationOnly)) = value;
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0007346C File Offset: 0x0007166C
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x00012A0F File Offset: 0x00010C0F
		public unsafe bool m_pushNotificationsEnabledIOS
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledIOS);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledIOS)) = value;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00073494 File Offset: 0x00071694
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x00012A2A File Offset: 0x00010C2A
		public unsafe bool m_pushNotificationsEnabledFirebase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledFirebase);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledFirebase)) = value;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x000734BC File Offset: 0x000716BC
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x00012A45 File Offset: 0x00010C45
		public unsafe bool m_pushNotificationsEnabledAmazon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledAmazon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledAmazon)) = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x000734E4 File Offset: 0x000716E4
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x00012A60 File Offset: 0x00010C60
		public unsafe bool m_pushNotificationsEnabledWindows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledWindows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_pushNotificationsEnabledWindows)) = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0007350C File Offset: 0x0007170C
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x00012A7B File Offset: 0x00010C7B
		public unsafe Settings.GooglePlayUpdatingIfRequiredMode m_allowUpdatingGooglePlayIfRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_allowUpdatingGooglePlayIfRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_allowUpdatingGooglePlayIfRequired)) = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x00073534 File Offset: 0x00071734
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x00012A96 File Offset: 0x00010C96
		public unsafe string m_firebaseSenderID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_firebaseSenderID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_firebaseSenderID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0007355C File Offset: 0x0007175C
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x00012AB5 File Offset: 0x00010CB5
		public unsafe string m_assetVersionSaved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_assetVersionSaved);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_assetVersionSaved), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x00073584 File Offset: 0x00071784
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x00012AD4 File Offset: 0x00010CD4
		public unsafe bool m_windowsDontShowWhenRunning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_windowsDontShowWhenRunning);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NativeFieldInfoPtr_m_windowsDontShowWhenRunning)) = value;
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x000735AC File Offset: 0x000717AC
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x00012AEF File Offset: 0x00010CEF
		public unsafe static string m_assetName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_m_assetName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_m_assetName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x000735CC File Offset: 0x000717CC
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x00012B01 File Offset: 0x00010D01
		public unsafe static string m_settingsMenuItem
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_m_settingsMenuItem, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_m_settingsMenuItem, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x000735EC File Offset: 0x000717EC
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x00012B13 File Offset: 0x00010D13
		public unsafe static Settings m_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Settings.NativeFieldInfoPtr_m_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Settings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Settings.NativeFieldInfoPtr_m_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeFieldInfoPtr_Version;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PROFILE_NAME;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_PROFILE_NAME_INTERNAL;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeFieldInfoPtr_m_notificationProfiles;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadTitleFieldName;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadTextFieldName;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadIdFieldName;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadUserDataParentFieldName;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadNotificationProfileFieldName;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadBadgeFieldName;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeFieldInfoPtr_m_pushPayloadButtonsParentName;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeFieldInfoPtr_m_googlePlayServicesLibVersion;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeFieldInfoPtr_m_androidSupportLibVersion;

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeFieldInfoPtr_m_androidShowNotificationsMode;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeFieldInfoPtr_m_android4CompatibilityMode;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeFieldInfoPtr_m_androidRestoreScheduledNotificationsAfterReboot;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeFieldInfoPtr_m_androidNotificationsGrouping;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeFieldInfoPtr_m_androidShowLatestNotificationOnly;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeFieldInfoPtr_m_pushNotificationsEnabledIOS;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeFieldInfoPtr_m_pushNotificationsEnabledFirebase;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeFieldInfoPtr_m_pushNotificationsEnabledAmazon;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeFieldInfoPtr_m_pushNotificationsEnabledWindows;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeFieldInfoPtr_m_allowUpdatingGooglePlayIfRequired;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeFieldInfoPtr_m_firebaseSenderID;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeFieldInfoPtr_m_assetVersionSaved;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeFieldInfoPtr_m_windowsDontShowWhenRunning;

		// Token: 0x040013C2 RID: 5058
		private static readonly IntPtr NativeFieldInfoPtr_m_assetName;

		// Token: 0x040013C3 RID: 5059
		private static readonly IntPtr NativeFieldInfoPtr_m_settingsMenuItem;

		// Token: 0x040013C4 RID: 5060
		private static readonly IntPtr NativeFieldInfoPtr_m_instance;

		// Token: 0x040013C5 RID: 5061
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Settings_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly IntPtr NativeMethodInfoPtr_get_NotificationProfiles_Public_get_List_1_NotificationProfile_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadTitleFieldName_Public_get_String_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadTitleFieldName_Public_set_Void_String_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadTextFieldName_Public_get_String_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadTextFieldName_Public_set_Void_String_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadIdFieldName_Public_get_String_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadIdFieldName_Public_set_Void_String_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadUserDataParentFieldName_Public_get_String_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadUserDataParentFieldName_Public_set_Void_String_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadNotificationProfileFieldName_Public_get_String_0;

		// Token: 0x040013D0 RID: 5072
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadNotificationProfileFieldName_Public_set_Void_String_0;

		// Token: 0x040013D1 RID: 5073
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadBadgeFieldName_Public_get_String_0;

		// Token: 0x040013D2 RID: 5074
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadBadgeFieldName_Public_set_Void_String_0;

		// Token: 0x040013D3 RID: 5075
		private static readonly IntPtr NativeMethodInfoPtr_get_PushPayloadButtonsParentName_Public_get_String_0;

		// Token: 0x040013D4 RID: 5076
		private static readonly IntPtr NativeMethodInfoPtr_set_PushPayloadButtonsParentName_Public_set_Void_String_0;

		// Token: 0x040013D5 RID: 5077
		private static readonly IntPtr NativeMethodInfoPtr_get_GooglePlayServicesLibVersion_Public_get_String_0;

		// Token: 0x040013D6 RID: 5078
		private static readonly IntPtr NativeMethodInfoPtr_set_GooglePlayServicesLibVersion_Public_set_Void_String_0;

		// Token: 0x040013D7 RID: 5079
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidSupportLibVersion_Public_get_String_0;

		// Token: 0x040013D8 RID: 5080
		private static readonly IntPtr NativeMethodInfoPtr_set_AndroidSupportLibVersion_Public_set_Void_String_0;

		// Token: 0x040013D9 RID: 5081
		private static readonly IntPtr NativeMethodInfoPtr_get_PushNotificationsEnabledIOS_Public_get_Boolean_0;

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeMethodInfoPtr_set_PushNotificationsEnabledIOS_Public_set_Void_Boolean_0;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeMethodInfoPtr_get_PushNotificationsEnabledFirebase_Public_get_Boolean_0;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeMethodInfoPtr_set_PushNotificationsEnabledFirebase_Public_set_Void_Boolean_0;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr_get_PushNotificationsEnabledAmazon_Public_get_Boolean_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_set_PushNotificationsEnabledAmazon_Public_set_Void_Boolean_0;

		// Token: 0x040013DF RID: 5087
		private static readonly IntPtr NativeMethodInfoPtr_get_PushNotificationsEnabledWindows_Public_get_Boolean_0;

		// Token: 0x040013E0 RID: 5088
		private static readonly IntPtr NativeMethodInfoPtr_set_PushNotificationsEnabledWindows_Public_set_Void_Boolean_0;

		// Token: 0x040013E1 RID: 5089
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidShowNotificationsMode_Public_get_ShowNotifications_0;

		// Token: 0x040013E2 RID: 5090
		private static readonly IntPtr NativeMethodInfoPtr_set_AndroidShowNotificationsMode_Public_set_Void_ShowNotifications_0;

		// Token: 0x040013E3 RID: 5091
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidRestoreScheduledNotificationsAfterReboot_Public_get_Boolean_0;

		// Token: 0x040013E4 RID: 5092
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidNotificationsGrouping_Public_get_NotificationsGroupingMode_0;

		// Token: 0x040013E5 RID: 5093
		private static readonly IntPtr NativeMethodInfoPtr_set_AndroidNotificationsGrouping_Public_set_Void_NotificationsGroupingMode_0;

		// Token: 0x040013E6 RID: 5094
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowUpdatingGooglePlayIfRequired_Public_get_GooglePlayUpdatingIfRequiredMode_0;

		// Token: 0x040013E7 RID: 5095
		private static readonly IntPtr NativeMethodInfoPtr_set_AllowUpdatingGooglePlayIfRequired_Public_set_Void_GooglePlayUpdatingIfRequiredMode_0;

		// Token: 0x040013E8 RID: 5096
		private static readonly IntPtr NativeMethodInfoPtr_get_AndroidShowLatestNotificationOnly_Public_get_Boolean_0;

		// Token: 0x040013E9 RID: 5097
		private static readonly IntPtr NativeMethodInfoPtr_get_FirebaseSenderID_Public_get_String_0;

		// Token: 0x040013EA RID: 5098
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowsDontShowWhenRunning_Public_get_Boolean_0;

		// Token: 0x040013EB RID: 5099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000212 RID: 530
		[Serializable]
		public sealed class NotificationProfile : ValueType
		{
			// Token: 0x060029B9 RID: 10681 RVA: 0x00096138 File Offset: 0x00094338
			// Note: this type is marked as 'beforefieldinit'.
			static NotificationProfile()
			{
				Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings>.NativeClassPtr, "NotificationProfile");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr);
				Settings.NotificationProfile.NativeFieldInfoPtr_profileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "profileName");
				Settings.NotificationProfile.NativeFieldInfoPtr_iosSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "iosSound");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidChannelName");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidChannelDescription");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidIcon");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidLargeIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidLargeIcon");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon5Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidIcon5Plus");
				Settings.NotificationProfile.NativeFieldInfoPtr_colorSpecified = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "colorSpecified");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidColor");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidSound");
				Settings.NotificationProfile.NativeFieldInfoPtr_androidHighPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr, "androidHighPriority");
			}

			// Token: 0x060029BA RID: 10682 RVA: 0x00019A44 File Offset: 0x00017C44
			public NotificationProfile(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029BB RID: 10683 RVA: 0x00019A4D File Offset: 0x00017C4D
			public NotificationProfile()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings.NotificationProfile>.NativeClassPtr))
			{
			}

			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x060029BC RID: 10684 RVA: 0x00096240 File Offset: 0x00094440
			// (set) Token: 0x060029BD RID: 10685 RVA: 0x00019A5F File Offset: 0x00017C5F
			public unsafe string profileName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_profileName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_profileName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x060029BE RID: 10686 RVA: 0x00096268 File Offset: 0x00094468
			// (set) Token: 0x060029BF RID: 10687 RVA: 0x00019A7E File Offset: 0x00017C7E
			public unsafe string iosSound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_iosSound);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_iosSound), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x060029C0 RID: 10688 RVA: 0x00096290 File Offset: 0x00094490
			// (set) Token: 0x060029C1 RID: 10689 RVA: 0x00019A9D File Offset: 0x00017C9D
			public unsafe string androidChannelName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000962B8 File Offset: 0x000944B8
			// (set) Token: 0x060029C3 RID: 10691 RVA: 0x00019ABC File Offset: 0x00017CBC
			public unsafe string androidChannelDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidChannelDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000962E0 File Offset: 0x000944E0
			// (set) Token: 0x060029C5 RID: 10693 RVA: 0x00019ADB File Offset: 0x00017CDB
			public unsafe string androidIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x060029C6 RID: 10694 RVA: 0x00096308 File Offset: 0x00094508
			// (set) Token: 0x060029C7 RID: 10695 RVA: 0x00019AFA File Offset: 0x00017CFA
			public unsafe string androidLargeIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidLargeIcon);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidLargeIcon), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x060029C8 RID: 10696 RVA: 0x00096330 File Offset: 0x00094530
			// (set) Token: 0x060029C9 RID: 10697 RVA: 0x00019B19 File Offset: 0x00017D19
			public unsafe string androidIcon5Plus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon5Plus);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidIcon5Plus), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x060029CA RID: 10698 RVA: 0x00096358 File Offset: 0x00094558
			// (set) Token: 0x060029CB RID: 10699 RVA: 0x00019B38 File Offset: 0x00017D38
			public unsafe bool colorSpecified
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_colorSpecified);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_colorSpecified)) = value;
				}
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x060029CC RID: 10700 RVA: 0x00096380 File Offset: 0x00094580
			// (set) Token: 0x060029CD RID: 10701 RVA: 0x00019B53 File Offset: 0x00017D53
			public unsafe Color androidColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidColor)) = value;
				}
			}

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x060029CE RID: 10702 RVA: 0x000963A8 File Offset: 0x000945A8
			// (set) Token: 0x060029CF RID: 10703 RVA: 0x00019B6E File Offset: 0x00017D6E
			public unsafe string androidSound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidSound);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidSound), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000963D0 File Offset: 0x000945D0
			// (set) Token: 0x060029D1 RID: 10705 RVA: 0x00019B8D File Offset: 0x00017D8D
			public unsafe bool androidHighPriority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidHighPriority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.NotificationProfile.NativeFieldInfoPtr_androidHighPriority)) = value;
				}
			}

			// Token: 0x04001C86 RID: 7302
			private static readonly IntPtr NativeFieldInfoPtr_profileName;

			// Token: 0x04001C87 RID: 7303
			private static readonly IntPtr NativeFieldInfoPtr_iosSound;

			// Token: 0x04001C88 RID: 7304
			private static readonly IntPtr NativeFieldInfoPtr_androidChannelName;

			// Token: 0x04001C89 RID: 7305
			private static readonly IntPtr NativeFieldInfoPtr_androidChannelDescription;

			// Token: 0x04001C8A RID: 7306
			private static readonly IntPtr NativeFieldInfoPtr_androidIcon;

			// Token: 0x04001C8B RID: 7307
			private static readonly IntPtr NativeFieldInfoPtr_androidLargeIcon;

			// Token: 0x04001C8C RID: 7308
			private static readonly IntPtr NativeFieldInfoPtr_androidIcon5Plus;

			// Token: 0x04001C8D RID: 7309
			private static readonly IntPtr NativeFieldInfoPtr_colorSpecified;

			// Token: 0x04001C8E RID: 7310
			private static readonly IntPtr NativeFieldInfoPtr_androidColor;

			// Token: 0x04001C8F RID: 7311
			private static readonly IntPtr NativeFieldInfoPtr_androidSound;

			// Token: 0x04001C90 RID: 7312
			private static readonly IntPtr NativeFieldInfoPtr_androidHighPriority;
		}

		// Token: 0x02000213 RID: 531
		public enum ShowNotifications
		{
			// Token: 0x04001C92 RID: 7314
			WHEN_CLOSED_OR_IN_BACKGROUND,
			// Token: 0x04001C93 RID: 7315
			WHEN_CLOSED,
			// Token: 0x04001C94 RID: 7316
			ALWAYS
		}

		// Token: 0x02000214 RID: 532
		public enum NotificationsGroupingMode
		{
			// Token: 0x04001C96 RID: 7318
			NONE,
			// Token: 0x04001C97 RID: 7319
			BY_NOTIFICATION_PROFILES,
			// Token: 0x04001C98 RID: 7320
			FROM_USER_DATA,
			// Token: 0x04001C99 RID: 7321
			ALL_IN_A_SINGLE_GROUP
		}

		// Token: 0x02000215 RID: 533
		public enum GooglePlayUpdatingIfRequiredMode
		{
			// Token: 0x04001C9B RID: 7323
			DISABLED,
			// Token: 0x04001C9C RID: 7324
			ONCE,
			// Token: 0x04001C9D RID: 7325
			EVERY_INITIALIZE
		}

		// Token: 0x02000216 RID: 534
		public class UpdateMessage : global::Il2CppSystem.Object
		{
			// Token: 0x060029D2 RID: 10706 RVA: 0x000963F8 File Offset: 0x000945F8
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateMessage()
			{
				Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Settings>.NativeClassPtr, "UpdateMessage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr);
				Settings.UpdateMessage.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr, "version");
				Settings.UpdateMessage.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr, "text");
				Settings.UpdateMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr, 100666578);
			}

			// Token: 0x060029D3 RID: 10707 RVA: 0x00096460 File Offset: 0x00094660
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateMessage(string version, string text)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Settings.UpdateMessage>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Settings.UpdateMessage.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029D4 RID: 10708 RVA: 0x00019BA8 File Offset: 0x00017DA8
			public UpdateMessage(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000964C0 File Offset: 0x000946C0
			// (set) Token: 0x060029D6 RID: 10710 RVA: 0x00019BB1 File Offset: 0x00017DB1
			public unsafe string version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.UpdateMessage.NativeFieldInfoPtr_version);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.UpdateMessage.NativeFieldInfoPtr_version), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000964E8 File Offset: 0x000946E8
			// (set) Token: 0x060029D8 RID: 10712 RVA: 0x00019BD0 File Offset: 0x00017DD0
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.UpdateMessage.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Settings.UpdateMessage.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001C9E RID: 7326
			private static readonly IntPtr NativeFieldInfoPtr_version;

			// Token: 0x04001C9F RID: 7327
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04001CA0 RID: 7328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
		}
	}
}
