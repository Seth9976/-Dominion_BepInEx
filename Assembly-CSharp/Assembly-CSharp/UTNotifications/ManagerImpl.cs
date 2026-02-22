using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace UTNotifications
{
	// Token: 0x020000EE RID: 238
	public class ManagerImpl : Manager
	{
		// Token: 0x06001CC7 RID: 7367 RVA: 0x000705FC File Offset: 0x0006E7FC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagerImpl()
		{
			Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "ManagerImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr);
			ManagerImpl.NativeMethodInfoPtr_Initialize_Public_Virtual_Boolean_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665569);
			ManagerImpl.NativeMethodInfoPtr_PostLocalNotification_Public_Virtual_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665570);
			ManagerImpl.NativeMethodInfoPtr_ScheduleNotification_Public_Virtual_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665571);
			ManagerImpl.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Virtual_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665572);
			ManagerImpl.NativeMethodInfoPtr_NotificationsEnabled_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665573);
			ManagerImpl.NativeMethodInfoPtr_NotificationsAllowed_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665574);
			ManagerImpl.NativeMethodInfoPtr_SetNotificationsEnabled_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665575);
			ManagerImpl.NativeMethodInfoPtr_PushNotificationsEnabled_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665576);
			ManagerImpl.NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Virtual_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665577);
			ManagerImpl.NativeMethodInfoPtr_CancelNotification_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665578);
			ManagerImpl.NativeMethodInfoPtr_HideNotification_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665579);
			ManagerImpl.NativeMethodInfoPtr_HideAllNotifications_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665580);
			ManagerImpl.NativeMethodInfoPtr_CancelAllNotifications_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665581);
			ManagerImpl.NativeMethodInfoPtr_GetBadge_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665582);
			ManagerImpl.NativeMethodInfoPtr_SetBadge_Public_Virtual_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665583);
			ManagerImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr, 100665584);
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x0007076C File Offset: 0x0006E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254219, XrefRangeEnd = 254228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Initialize(bool willHandleReceivedNotifications, int startId, bool incrementalId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_Initialize_Public_Virtual_Boolean_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CC9 RID: 7369 RVA: 0x000707DC File Offset: 0x0006E9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254228, XrefRangeEnd = 254242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostLocalNotification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_PostLocalNotification_Public_Virtual_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCA RID: 7370 RVA: 0x00070890 File Offset: 0x0006EA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ScheduleNotification(int triggerInSeconds, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_ScheduleNotification_Public_Virtual_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCB RID: 7371 RVA: 0x00070954 File Offset: 0x0006EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ScheduleNotificationRepeating(int firstTriggerInSeconds, int intervalSeconds, string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber, ICollection<Button> buttons)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Virtual_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CCC RID: 7372 RVA: 0x00070A28 File Offset: 0x0006EC28
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool NotificationsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_NotificationsEnabled_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCD RID: 7373 RVA: 0x00070A70 File Offset: 0x0006EC70
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool NotificationsAllowed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_NotificationsAllowed_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CCE RID: 7374 RVA: 0x00070AB8 File Offset: 0x0006ECB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254242, XrefRangeEnd = 254250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetNotificationsEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_SetNotificationsEnabled_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CCF RID: 7375 RVA: 0x00070B04 File Offset: 0x0006ED04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254250, XrefRangeEnd = 254258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool PushNotificationsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_PushNotificationsEnabled_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD0 RID: 7376 RVA: 0x00070B4C File Offset: 0x0006ED4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool SetPushNotificationsEnabled(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Virtual_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CD1 RID: 7377 RVA: 0x00070BA0 File Offset: 0x0006EDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CancelNotification(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_CancelNotification_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CD2 RID: 7378 RVA: 0x00070BEC File Offset: 0x0006EDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideNotification(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_HideNotification_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CD3 RID: 7379 RVA: 0x00070C38 File Offset: 0x0006EE38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void HideAllNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_HideAllNotifications_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00070C74 File Offset: 0x0006EE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CancelAllNotifications()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_CancelAllNotifications_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x00070CB0 File Offset: 0x0006EEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254258, XrefRangeEnd = 254272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetBadge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_GetBadge_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x00070CF8 File Offset: 0x0006EEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetBadge(int bandgeNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bandgeNumber;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManagerImpl.NativeMethodInfoPtr_SetBadge_Public_Virtual_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00070D44 File Offset: 0x0006EF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254272, XrefRangeEnd = 254276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagerImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagerImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagerImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x00012686 File Offset: 0x00010886
		public ManagerImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001360 RID: 4960
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Boolean_Boolean_Int32_Boolean_0;

		// Token: 0x04001361 RID: 4961
		private static readonly IntPtr NativeMethodInfoPtr_PostLocalNotification_Public_Virtual_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001362 RID: 4962
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotification_Public_Virtual_Void_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleNotificationRepeating_Public_Virtual_Void_Int32_Int32_String_String_Int32_IDictionary_2_String_String_String_Int32_ICollection_1_Button_0;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_NotificationsEnabled_Public_Virtual_Boolean_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_NotificationsAllowed_Public_Virtual_Boolean_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_SetNotificationsEnabled_Public_Virtual_Void_Boolean_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_PushNotificationsEnabled_Public_Virtual_Boolean_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_SetPushNotificationsEnabled_Public_Virtual_Boolean_Boolean_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_CancelNotification_Public_Virtual_Void_Int32_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_HideNotification_Public_Virtual_Void_Int32_0;

		// Token: 0x0400136B RID: 4971
		private static readonly IntPtr NativeMethodInfoPtr_HideAllNotifications_Public_Virtual_Void_0;

		// Token: 0x0400136C RID: 4972
		private static readonly IntPtr NativeMethodInfoPtr_CancelAllNotifications_Public_Virtual_Void_0;

		// Token: 0x0400136D RID: 4973
		private static readonly IntPtr NativeMethodInfoPtr_GetBadge_Public_Virtual_Int32_0;

		// Token: 0x0400136E RID: 4974
		private static readonly IntPtr NativeMethodInfoPtr_SetBadge_Public_Virtual_Void_Int32_0;

		// Token: 0x0400136F RID: 4975
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
