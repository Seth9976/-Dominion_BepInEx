using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace UTNotifications
{
	// Token: 0x020000F0 RID: 240
	public class Manager : MonoBehaviour
	{
		// Token: 0x06001CDE RID: 7390 RVA: 0x00070EB0 File Offset: 0x0006F0B0
		// Note: this type is marked as 'beforefieldinit'.
		static Manager()
		{
			Il2CppClassPointerStore<Manager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "Manager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Manager>.NativeClassPtr);
			Manager.NativeFieldInfoPtr_OnInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnInitialized");
			Manager.NativeFieldInfoPtr_OnSendRegistrationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnSendRegistrationId");
			Manager.NativeFieldInfoPtr_OnNotificationClicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnNotificationClicked");
			Manager.NativeFieldInfoPtr_OnNotificationsReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnNotificationsReceived");
			Manager.NativeFieldInfoPtr_m_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "m_instance");
			Manager.NativeFieldInfoPtr_m_destroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "m_destroyed");
			Manager.NativeFieldInfoPtr_m_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Manager>.NativeClassPtr, "m_initialized");
			Manager.NativeMethodInfoPtr_get_Instance_Public_Static_get_Manager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665588);
			Manager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665589);
			Manager.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665590);
			Manager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665591);
			Manager.NativeMethodInfoPtr_PostLocalNotification_Public_Abstract_Virtual_New_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665592);
			Manager.NativeMethodInfoPtr_ScheduleNotification_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665593);
			Manager.NativeMethodInfoPtr_ScheduleNotification_Public_Void_DateTime_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665594);
			Manager.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Abstract_Virtual_New_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665595);
			Manager.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Void_DateTime_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665596);
			Manager.NativeMethodInfoPtr_NotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665597);
			Manager.NativeMethodInfoPtr_NotificationsAllowed_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665598);
			Manager.NativeMethodInfoPtr_SetNotificationsEnabled_Public_Abstract_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665599);
			Manager.NativeMethodInfoPtr_PushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665600);
			Manager.NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665601);
			Manager.NativeMethodInfoPtr_CancelNotification_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665602);
			Manager.NativeMethodInfoPtr_HideNotification_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665603);
			Manager.NativeMethodInfoPtr_CancelAllNotifications_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665604);
			Manager.NativeMethodInfoPtr_HideAllNotifications_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665605);
			Manager.NativeMethodInfoPtr_GetBadge_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665606);
			Manager.NativeMethodInfoPtr_SetBadge_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665607);
			Manager.NativeMethodInfoPtr_add_OnInitialized_Public_add_Void_OnInitializedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665608);
			Manager.NativeMethodInfoPtr_remove_OnInitialized_Public_rem_Void_OnInitializedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665609);
			Manager.NativeMethodInfoPtr_add_OnSendRegistrationId_Public_add_Void_OnSendRegistrationIdHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665610);
			Manager.NativeMethodInfoPtr_remove_OnSendRegistrationId_Public_rem_Void_OnSendRegistrationIdHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665611);
			Manager.NativeMethodInfoPtr_add_OnNotificationClicked_Public_add_Void_OnNotificationClickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665612);
			Manager.NativeMethodInfoPtr_remove_OnNotificationClicked_Public_rem_Void_OnNotificationClickedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665613);
			Manager.NativeMethodInfoPtr_add_OnNotificationsReceived_Public_add_Void_OnNotificationsReceivedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665614);
			Manager.NativeMethodInfoPtr_remove_OnNotificationsReceived_Public_rem_Void_OnNotificationsReceivedHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665615);
			Manager.NativeMethodInfoPtr_OnSendRegistrationIdHasSubscribers_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665616);
			Manager.NativeMethodInfoPtr__OnSendRegistrationId_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665617);
			Manager.NativeMethodInfoPtr_OnNotificationClickedHasSubscribers_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665618);
			Manager.NativeMethodInfoPtr__OnNotificationClicked_Protected_Void_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665619);
			Manager.NativeMethodInfoPtr_OnNotificationsReceivedHasSubscribers_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665620);
			Manager.NativeMethodInfoPtr__OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665621);
			Manager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665622);
			Manager.NativeMethodInfoPtr_NotSupported_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665623);
			Manager.NativeMethodInfoPtr_CheckInitialized_Protected_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665624);
			Manager.NativeMethodInfoPtr_InstanceRequired_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665625);
			Manager.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager>.NativeClassPtr, 100665626);
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x00071278 File Offset: 0x0006F478
		public unsafe static Manager Instance
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 254380, RefRangeEnd = 254403, XrefRangeStart = 254349, XrefRangeEnd = 254380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_get_Instance_Public_Static_get_Manager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Manager>(intPtr3) : null;
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06001CE0 RID: 7392 RVA: 0x000712AC File Offset: 0x0006F4AC
		// (set) Token: 0x06001CE1 RID: 7393 RVA: 0x000712E8 File Offset: 0x0006F4E8
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254403, XrefRangeEnd = 254404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x00071328 File Offset: 0x0006F528
		[CallerCount(0)]
		public unsafe virtual bool Initialize(bool willHandleReceivedNotifications, int startId = 0, bool incrementalId = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref willHandleReceivedNotifications;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref incrementalId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x00071398 File Offset: 0x0006F598
		[CallerCount(0)]
		public unsafe virtual void PostLocalNotification(string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_PostLocalNotification_Public_Abstract_Virtual_New_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x0007144C File Offset: 0x0006F64C
		[CallerCount(0)]
		public unsafe virtual void ScheduleNotification(int triggerInSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triggerInSeconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_ScheduleNotification_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00071510 File Offset: 0x0006F710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254404, XrefRangeEnd = 254405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleNotification(DateTime triggerDateTime, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref triggerDateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_ScheduleNotification_Public_Void_DateTime_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x000715C8 File Offset: 0x0006F7C8
		[CallerCount(0)]
		public unsafe virtual void ScheduleNotificationRepeating(int firstTriggerInSeconds, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstTriggerInSeconds;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalSeconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Abstract_Virtual_New_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE7 RID: 7399 RVA: 0x0007169C File Offset: 0x0006F89C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254406, RefRangeEnd = 254407, XrefRangeStart = 254405, XrefRangeEnd = 254406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleNotificationRepeating(DateTime firstTriggerDateTime, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData = null, string notificationProfile = null, int badgeNumber = -1, ICollection<Button> buttons = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref firstTriggerDateTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref intervalSeconds;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buttons);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Void_DateTime_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x00071764 File Offset: 0x0006F964
		[CallerCount(0)]
		public unsafe virtual bool NotificationsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_NotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000717AC File Offset: 0x0006F9AC
		[CallerCount(0)]
		public unsafe virtual bool NotificationsAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_NotificationsAllowed_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000717F4 File Offset: 0x0006F9F4
		[CallerCount(0)]
		public unsafe virtual void SetNotificationsEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_SetNotificationsEnabled_Public_Abstract_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x00071840 File Offset: 0x0006FA40
		[CallerCount(0)]
		public unsafe virtual bool PushNotificationsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_PushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x00071888 File Offset: 0x0006FA88
		[CallerCount(0)]
		public unsafe virtual bool SetPushNotificationsEnabled(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000718DC File Offset: 0x0006FADC
		[CallerCount(0)]
		public unsafe virtual void CancelNotification(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_CancelNotification_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x00071928 File Offset: 0x0006FB28
		[CallerCount(0)]
		public unsafe virtual void HideNotification(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_HideNotification_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x00071974 File Offset: 0x0006FB74
		[CallerCount(0)]
		public unsafe virtual void CancelAllNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_CancelAllNotifications_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000719B0 File Offset: 0x0006FBB0
		[CallerCount(0)]
		public unsafe virtual void HideAllNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_HideAllNotifications_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000719EC File Offset: 0x0006FBEC
		[CallerCount(0)]
		public unsafe virtual int GetBadge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_GetBadge_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00071A34 File Offset: 0x0006FC34
		[CallerCount(0)]
		public unsafe virtual void SetBadge(int bandgeNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bandgeNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_SetBadge_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00071A80 File Offset: 0x0006FC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254411, RefRangeEnd = 254412, XrefRangeStart = 254407, XrefRangeEnd = 254411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnInitialized(Manager.OnInitializedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_add_OnInitialized_Public_add_Void_OnInitializedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00071AC4 File Offset: 0x0006FCC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 254416, RefRangeEnd = 254418, XrefRangeStart = 254412, XrefRangeEnd = 254416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnInitialized(Manager.OnInitializedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_remove_OnInitialized_Public_rem_Void_OnInitializedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00071B08 File Offset: 0x0006FD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254422, RefRangeEnd = 254423, XrefRangeStart = 254418, XrefRangeEnd = 254422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnSendRegistrationId(Manager.OnSendRegistrationIdHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_add_OnSendRegistrationId_Public_add_Void_OnSendRegistrationIdHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00071B4C File Offset: 0x0006FD4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254427, RefRangeEnd = 254428, XrefRangeStart = 254423, XrefRangeEnd = 254427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnSendRegistrationId(Manager.OnSendRegistrationIdHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_remove_OnSendRegistrationId_Public_rem_Void_OnSendRegistrationIdHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00071B90 File Offset: 0x0006FD90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254432, RefRangeEnd = 254433, XrefRangeStart = 254428, XrefRangeEnd = 254432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNotificationClicked(Manager.OnNotificationClickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_add_OnNotificationClicked_Public_add_Void_OnNotificationClickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00071BD4 File Offset: 0x0006FDD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254437, RefRangeEnd = 254438, XrefRangeStart = 254433, XrefRangeEnd = 254437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNotificationClicked(Manager.OnNotificationClickedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_remove_OnNotificationClicked_Public_rem_Void_OnNotificationClickedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00071C18 File Offset: 0x0006FE18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254442, RefRangeEnd = 254443, XrefRangeStart = 254438, XrefRangeEnd = 254442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnNotificationsReceived(Manager.OnNotificationsReceivedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_add_OnNotificationsReceived_Public_add_Void_OnNotificationsReceivedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00071C5C File Offset: 0x0006FE5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254447, RefRangeEnd = 254448, XrefRangeStart = 254443, XrefRangeEnd = 254447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnNotificationsReceived(Manager.OnNotificationsReceivedHandler value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_remove_OnNotificationsReceived_Public_rem_Void_OnNotificationsReceivedHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 35304, RefRangeEnd = 35309, XrefRangeStart = 35304, XrefRangeEnd = 35309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnSendRegistrationIdHasSubscribers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_OnSendRegistrationIdHasSubscribers_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00071CDC File Offset: 0x0006FEDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254448, XrefRangeEnd = 254450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnSendRegistrationId(string providerName, string registrationId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(registrationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr__OnSendRegistrationId_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00071D30 File Offset: 0x0006FF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254450, RefRangeEnd = 254451, XrefRangeStart = 254450, XrefRangeEnd = 254450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnNotificationClickedHasSubscribers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_OnNotificationClickedHasSubscribers_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00071D6C File Offset: 0x0006FF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254451, XrefRangeEnd = 254453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNotificationClicked(ReceivedNotification notification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notification);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr__OnNotificationClicked_Protected_Void_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00071DB0 File Offset: 0x0006FFB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 254453, RefRangeEnd = 254454, XrefRangeStart = 254453, XrefRangeEnd = 254453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OnNotificationsReceivedHasSubscribers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_OnNotificationsReceivedHasSubscribers_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00071DEC File Offset: 0x0006FFEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254454, XrefRangeEnd = 254456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNotificationsReceived(IList<ReceivedNotification> receivedNotifications)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receivedNotifications);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr__OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00071E30 File Offset: 0x00070030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254456, XrefRangeEnd = 254461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Manager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00071E6C File Offset: 0x0007006C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254461, XrefRangeEnd = 254475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotSupported(string feature = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(feature);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_NotSupported_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00071EB0 File Offset: 0x000700B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254475, XrefRangeEnd = 254481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_CheckInitialized_Protected_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00071EEC File Offset: 0x000700EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254481, XrefRangeEnd = 254507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstanceRequired()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr_InstanceRequired_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00071F14 File Offset: 0x00070114
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Manager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00012698 File Offset: 0x00010898
		public Manager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x00071F50 File Offset: 0x00070150
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x000126A1 File Offset: 0x000108A1
		public unsafe Manager.OnInitializedHandler OnInitialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnInitialized);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager.OnInitializedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnInitialized), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x00071F80 File Offset: 0x00070180
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x000126C0 File Offset: 0x000108C0
		public unsafe Manager.OnSendRegistrationIdHandler OnSendRegistrationId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnSendRegistrationId);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager.OnSendRegistrationIdHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnSendRegistrationId), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x00071FB0 File Offset: 0x000701B0
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x000126DF File Offset: 0x000108DF
		public unsafe Manager.OnNotificationClickedHandler OnNotificationClicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnNotificationClicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager.OnNotificationClickedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnNotificationClicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00071FE0 File Offset: 0x000701E0
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x000126FE File Offset: 0x000108FE
		public unsafe Manager.OnNotificationsReceivedHandler OnNotificationsReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnNotificationsReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager.OnNotificationsReceivedHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_OnNotificationsReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00072010 File Offset: 0x00070210
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0001271D File Offset: 0x0001091D
		public unsafe static Manager m_instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Manager.NativeFieldInfoPtr_m_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Manager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Manager.NativeFieldInfoPtr_m_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x00072038 File Offset: 0x00070238
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0001272F File Offset: 0x0001092F
		public unsafe static bool m_destroyed
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Manager.NativeFieldInfoPtr_m_destroyed, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Manager.NativeFieldInfoPtr_m_destroyed, (void*)(&value));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00072054 File Offset: 0x00070254
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0001273D File Offset: 0x0001093D
		public unsafe bool m_initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_m_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Manager.NativeFieldInfoPtr_m_initialized)) = value;
			}
		}

		// Token: 0x04001373 RID: 4979
		private static readonly IntPtr NativeFieldInfoPtr_OnInitialized;

		// Token: 0x04001374 RID: 4980
		private static readonly IntPtr NativeFieldInfoPtr_OnSendRegistrationId;

		// Token: 0x04001375 RID: 4981
		private static readonly IntPtr NativeFieldInfoPtr_OnNotificationClicked;

		// Token: 0x04001376 RID: 4982
		private static readonly IntPtr NativeFieldInfoPtr_OnNotificationsReceived;

		// Token: 0x04001377 RID: 4983
		private static readonly IntPtr NativeFieldInfoPtr_m_instance;

		// Token: 0x04001378 RID: 4984
		private static readonly IntPtr NativeFieldInfoPtr_m_destroyed;

		// Token: 0x04001379 RID: 4985
		private static readonly IntPtr NativeFieldInfoPtr_m_initialized;

		// Token: 0x0400137A RID: 4986
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Manager_0;

		// Token: 0x0400137B RID: 4987
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Boolean_Boolean_Int32_Boolean_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_PostLocalNotification_Public_Abstract_Virtual_New_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotification_Public_Abstract_Virtual_New_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotification_Public_Void_DateTime_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Abstract_Virtual_New_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Void_DateTime_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_NotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr_NotificationsAllowed_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationsEnabled_Public_Abstract_Virtual_New_Void_Boolean_0;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeMethodInfoPtr_PushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Abstract_Virtual_New_Boolean_Boolean_0;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeMethodInfoPtr_CancelNotification_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeMethodInfoPtr_HideNotification_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllNotifications_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr_HideAllNotifications_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_GetBadge_Public_Abstract_Virtual_New_Int32_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_SetBadge_Public_Abstract_Virtual_New_Void_Int32_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_add_OnInitialized_Public_add_Void_OnInitializedHandler_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnInitialized_Public_rem_Void_OnInitializedHandler_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_add_OnSendRegistrationId_Public_add_Void_OnSendRegistrationIdHandler_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnSendRegistrationId_Public_rem_Void_OnSendRegistrationIdHandler_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNotificationClicked_Public_add_Void_OnNotificationClickedHandler_0;

		// Token: 0x04001393 RID: 5011
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNotificationClicked_Public_rem_Void_OnNotificationClickedHandler_0;

		// Token: 0x04001394 RID: 5012
		private static readonly IntPtr NativeMethodInfoPtr_add_OnNotificationsReceived_Public_add_Void_OnNotificationsReceivedHandler_0;

		// Token: 0x04001395 RID: 5013
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnNotificationsReceived_Public_rem_Void_OnNotificationsReceivedHandler_0;

		// Token: 0x04001396 RID: 5014
		private static readonly IntPtr NativeMethodInfoPtr_OnSendRegistrationIdHasSubscribers_Protected_Boolean_0;

		// Token: 0x04001397 RID: 5015
		private static readonly IntPtr NativeMethodInfoPtr__OnSendRegistrationId_Protected_Void_String_String_0;

		// Token: 0x04001398 RID: 5016
		private static readonly IntPtr NativeMethodInfoPtr_OnNotificationClickedHasSubscribers_Protected_Boolean_0;

		// Token: 0x04001399 RID: 5017
		private static readonly IntPtr NativeMethodInfoPtr__OnNotificationClicked_Protected_Void_ReceivedNotification_0;

		// Token: 0x0400139A RID: 5018
		private static readonly IntPtr NativeMethodInfoPtr_OnNotificationsReceivedHasSubscribers_Protected_Boolean_0;

		// Token: 0x0400139B RID: 5019
		private static readonly IntPtr NativeMethodInfoPtr__OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0;

		// Token: 0x0400139C RID: 5020
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_New_Void_0;

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeMethodInfoPtr_NotSupported_Protected_Void_String_0;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeMethodInfoPtr_CheckInitialized_Protected_Boolean_0;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeMethodInfoPtr_InstanceRequired_Private_Static_Void_0;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0200020E RID: 526
		public sealed class OnInitializedHandler : MulticastDelegate
		{
			// Token: 0x06002995 RID: 10645 RVA: 0x00095A04 File Offset: 0x00093C04
			// Note: this type is marked as 'beforefieldinit'.
			static OnInitializedHandler()
			{
				Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnInitializedHandler");
				Manager.OnInitializedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr, 100666562);
				Manager.OnInitializedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr, 100666563);
				Manager.OnInitializedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr, 100666564);
				Manager.OnInitializedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr, 100666565);
			}

			// Token: 0x06002996 RID: 10646 RVA: 0x00095A78 File Offset: 0x00093C78
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnInitializedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager.OnInitializedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnInitializedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002997 RID: 10647 RVA: 0x00095AD4 File Offset: 0x00093CD4
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnInitializedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002998 RID: 10648 RVA: 0x00095B08 File Offset: 0x00093D08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnInitializedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06002999 RID: 10649 RVA: 0x00095B6C File Offset: 0x00093D6C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnInitializedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600299A RID: 10650 RVA: 0x00019984 File Offset: 0x00017B84
			public OnInitializedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600299B RID: 10651 RVA: 0x0001998D File Offset: 0x00017B8D
			public static implicit operator Manager.OnInitializedHandler(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<Manager.OnInitializedHandler>(A_0);
			}

			// Token: 0x0600299C RID: 10652 RVA: 0x00019995 File Offset: 0x00017B95
			public static Manager.OnInitializedHandler operator +(Manager.OnInitializedHandler A_0, Manager.OnInitializedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Manager.OnInitializedHandler>();
			}

			// Token: 0x0600299D RID: 10653 RVA: 0x000199A3 File Offset: 0x00017BA3
			public static Manager.OnInitializedHandler operator -(Manager.OnInitializedHandler A_0, Manager.OnInitializedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Manager.OnInitializedHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001C76 RID: 7286
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C77 RID: 7287
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

			// Token: 0x04001C78 RID: 7288
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

			// Token: 0x04001C79 RID: 7289
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x0200020F RID: 527
		public sealed class OnSendRegistrationIdHandler : MulticastDelegate
		{
			// Token: 0x0600299E RID: 10654 RVA: 0x00095BB0 File Offset: 0x00093DB0
			// Note: this type is marked as 'beforefieldinit'.
			static OnSendRegistrationIdHandler()
			{
				Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnSendRegistrationIdHandler");
				Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr, 100666566);
				Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr, 100666567);
				Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr, 100666568);
				Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr, 100666569);
			}

			// Token: 0x0600299F RID: 10655 RVA: 0x00095C24 File Offset: 0x00093E24
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnSendRegistrationIdHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager.OnSendRegistrationIdHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A0 RID: 10656 RVA: 0x00095C80 File Offset: 0x00093E80
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(string providerName, string registrationId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(registrationId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A1 RID: 10657 RVA: 0x00095CD4 File Offset: 0x00093ED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string providerName, string registrationId, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(providerName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(registrationId);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060029A2 RID: 10658 RVA: 0x00095D5C File Offset: 0x00093F5C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnSendRegistrationIdHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029A3 RID: 10659 RVA: 0x000199B4 File Offset: 0x00017BB4
			public OnSendRegistrationIdHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029A4 RID: 10660 RVA: 0x000199BD File Offset: 0x00017BBD
			public static implicit operator Manager.OnSendRegistrationIdHandler(Action<string, string> A_0)
			{
				return DelegateSupport.ConvertDelegate<Manager.OnSendRegistrationIdHandler>(A_0);
			}

			// Token: 0x060029A5 RID: 10661 RVA: 0x000199C5 File Offset: 0x00017BC5
			public static Manager.OnSendRegistrationIdHandler operator +(Manager.OnSendRegistrationIdHandler A_0, Manager.OnSendRegistrationIdHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Manager.OnSendRegistrationIdHandler>();
			}

			// Token: 0x060029A6 RID: 10662 RVA: 0x000199D3 File Offset: 0x00017BD3
			public static Manager.OnSendRegistrationIdHandler operator -(Manager.OnSendRegistrationIdHandler A_0, Manager.OnSendRegistrationIdHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Manager.OnSendRegistrationIdHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001C7A RID: 7290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C7B RID: 7291
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_0;

			// Token: 0x04001C7C RID: 7292
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_String_AsyncCallback_Object_0;

			// Token: 0x04001C7D RID: 7293
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000210 RID: 528
		public sealed class OnNotificationClickedHandler : MulticastDelegate
		{
			// Token: 0x060029A7 RID: 10663 RVA: 0x00095DA0 File Offset: 0x00093FA0
			// Note: this type is marked as 'beforefieldinit'.
			static OnNotificationClickedHandler()
			{
				Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnNotificationClickedHandler");
				Manager.OnNotificationClickedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr, 100666570);
				Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr, 100666571);
				Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReceivedNotification_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr, 100666572);
				Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr, 100666573);
			}

			// Token: 0x060029A8 RID: 10664 RVA: 0x00095E14 File Offset: 0x00094014
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnNotificationClickedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager.OnNotificationClickedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationClickedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029A9 RID: 10665 RVA: 0x00095E70 File Offset: 0x00094070
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(ReceivedNotification notification)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(notification);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029AA RID: 10666 RVA: 0x00095EB4 File Offset: 0x000940B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(ReceivedNotification notification, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(notification);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReceivedNotification_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060029AB RID: 10667 RVA: 0x00095F28 File Offset: 0x00094128
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationClickedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029AC RID: 10668 RVA: 0x000199E4 File Offset: 0x00017BE4
			public OnNotificationClickedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029AD RID: 10669 RVA: 0x000199ED File Offset: 0x00017BED
			public static implicit operator Manager.OnNotificationClickedHandler(Action<ReceivedNotification> A_0)
			{
				return DelegateSupport.ConvertDelegate<Manager.OnNotificationClickedHandler>(A_0);
			}

			// Token: 0x060029AE RID: 10670 RVA: 0x000199F5 File Offset: 0x00017BF5
			public static Manager.OnNotificationClickedHandler operator +(Manager.OnNotificationClickedHandler A_0, Manager.OnNotificationClickedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Manager.OnNotificationClickedHandler>();
			}

			// Token: 0x060029AF RID: 10671 RVA: 0x00019A03 File Offset: 0x00017C03
			public static Manager.OnNotificationClickedHandler operator -(Manager.OnNotificationClickedHandler A_0, Manager.OnNotificationClickedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Manager.OnNotificationClickedHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001C7E RID: 7294
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C7F RID: 7295
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ReceivedNotification_0;

			// Token: 0x04001C80 RID: 7296
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ReceivedNotification_AsyncCallback_Object_0;

			// Token: 0x04001C81 RID: 7297
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000211 RID: 529
		public sealed class OnNotificationsReceivedHandler : MulticastDelegate
		{
			// Token: 0x060029B0 RID: 10672 RVA: 0x00095F6C File Offset: 0x0009416C
			// Note: this type is marked as 'beforefieldinit'.
			static OnNotificationsReceivedHandler()
			{
				Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Manager>.NativeClassPtr, "OnNotificationsReceivedHandler");
				Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr, 100666574);
				Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr, 100666575);
				Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_ReceivedNotification_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr, 100666576);
				Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr, 100666577);
			}

			// Token: 0x060029B1 RID: 10673 RVA: 0x00095FE0 File Offset: 0x000941E0
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnNotificationsReceivedHandler(global::Il2CppSystem.Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Manager.OnNotificationsReceivedHandler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060029B2 RID: 10674 RVA: 0x0009603C File Offset: 0x0009423C
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 59640, RefRangeEnd = 59663, XrefRangeStart = 59640, XrefRangeEnd = 59663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IList<ReceivedNotification> receivedNotifications)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(receivedNotifications);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029B3 RID: 10675 RVA: 0x00096080 File Offset: 0x00094280
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163501, RefRangeEnd = 163503, XrefRangeStart = 163501, XrefRangeEnd = 163503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(IList<ReceivedNotification> receivedNotifications, AsyncCallback callback, global::Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(receivedNotifications);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_ReceivedNotification_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x060029B4 RID: 10676 RVA: 0x000960F4 File Offset: 0x000942F4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Manager.OnNotificationsReceivedHandler.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060029B5 RID: 10677 RVA: 0x00019A14 File Offset: 0x00017C14
			public OnNotificationsReceivedHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060029B6 RID: 10678 RVA: 0x00019A1D File Offset: 0x00017C1D
			public static implicit operator Manager.OnNotificationsReceivedHandler(Action<IList<ReceivedNotification>> A_0)
			{
				return DelegateSupport.ConvertDelegate<Manager.OnNotificationsReceivedHandler>(A_0);
			}

			// Token: 0x060029B7 RID: 10679 RVA: 0x00019A25 File Offset: 0x00017C25
			public static Manager.OnNotificationsReceivedHandler operator +(Manager.OnNotificationsReceivedHandler A_0, Manager.OnNotificationsReceivedHandler A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Manager.OnNotificationsReceivedHandler>();
			}

			// Token: 0x060029B8 RID: 10680 RVA: 0x00019A33 File Offset: 0x00017C33
			public static Manager.OnNotificationsReceivedHandler operator -(Manager.OnNotificationsReceivedHandler A_0, Manager.OnNotificationsReceivedHandler A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<Manager.OnNotificationsReceivedHandler>();
				}
				return delegate2;
			}

			// Token: 0x04001C82 RID: 7298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001C83 RID: 7299
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IList_1_ReceivedNotification_0;

			// Token: 0x04001C84 RID: 7300
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_IList_1_ReceivedNotification_AsyncCallback_Object_0;

			// Token: 0x04001C85 RID: 7301
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
