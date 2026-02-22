using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000EC RID: 236
	public class UTNotificationsSample : MonoBehaviour
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x0006F7D8 File Offset: 0x0006D9D8
		// Note: this type is marked as 'beforefieldinit'.
		static UTNotificationsSample()
		{
			Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "UTNotificationsSample");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr);
			UTNotificationsSample.NativeFieldInfoPtr_DemoServerURLInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "DemoServerURLInputField");
			UTNotificationsSample.NativeFieldInfoPtr_NotifyAllText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "NotifyAllText");
			UTNotificationsSample.NativeFieldInfoPtr_InitializeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "InitializeText");
			UTNotificationsSample.NativeFieldInfoPtr_NotificationsEnabledToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "NotificationsEnabledToggle");
			UTNotificationsSample.NativeFieldInfoPtr_CreateNotificationDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "CreateNotificationDialog");
			UTNotificationsSample.NativeFieldInfoPtr_NotificationDetailsDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "NotificationDetailsDialog");
			UTNotificationsSample.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "instance");
			UTNotificationsSample.NativeFieldInfoPtr_notifyAllTextOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "notifyAllTextOriginal");
			UTNotificationsSample.NativeFieldInfoPtr_initializeTextOriginal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "initializeTextOriginal");
			UTNotificationsSample.NativeMethodInfoPtr_get_Instance_Public_Static_get_UTNotificationsSample_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665540);
			UTNotificationsSample.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665541);
			UTNotificationsSample.NativeMethodInfoPtr_NotifyAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665542);
			UTNotificationsSample.NativeMethodInfoPtr_NotifyAll_Public_IEnumerator_String_String_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665543);
			UTNotificationsSample.NativeMethodInfoPtr_CreateLocalNotification_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665544);
			UTNotificationsSample.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665545);
			UTNotificationsSample.NativeMethodInfoPtr_ScheduleRepeatingLocalNotification_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665546);
			UTNotificationsSample.NativeMethodInfoPtr_Hide_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665547);
			UTNotificationsSample.NativeMethodInfoPtr_Cancel_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665548);
			UTNotificationsSample.NativeMethodInfoPtr_CancelAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665549);
			UTNotificationsSample.NativeMethodInfoPtr_IncrementBadge_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665550);
			UTNotificationsSample.NativeMethodInfoPtr_OnNotificationsEnabledToggleValueChanged_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665551);
			UTNotificationsSample.NativeMethodInfoPtr_UserData_Protected_Dictionary_2_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665552);
			UTNotificationsSample.NativeMethodInfoPtr_Buttons_Protected_List_1_Button_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665553);
			UTNotificationsSample.NativeMethodInfoPtr_SendRegistrationId_Protected_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665554);
			UTNotificationsSample.NativeMethodInfoPtr_SendRegistrationId_Protected_IEnumerator_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665555);
			UTNotificationsSample.NativeMethodInfoPtr_OnNotificationClicked_Protected_Void_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665556);
			UTNotificationsSample.NativeMethodInfoPtr_OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665557);
			UTNotificationsSample.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665558);
			UTNotificationsSample.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665559);
			UTNotificationsSample.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665560);
			UTNotificationsSample.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665561);
			UTNotificationsSample.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665562);
			UTNotificationsSample.NativeMethodInfoPtr__NotifyAll_b__9_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665564);
			UTNotificationsSample.NativeMethodInfoPtr__CreateLocalNotification_b__11_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665565);
			UTNotificationsSample.NativeMethodInfoPtr__ScheduleLocalNotification_b__12_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665566);
			UTNotificationsSample.NativeMethodInfoPtr__ScheduleRepeatingLocalNotification_b__13_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, 100665567);
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06001C92 RID: 7314 RVA: 0x0006FAD8 File Offset: 0x0006DCD8
		public unsafe static UTNotificationsSample Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253869, XrefRangeEnd = 253873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_get_Instance_Public_Static_get_UTNotificationsSample_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UTNotificationsSample>(intPtr3) : null;
			}
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0006FB0C File Offset: 0x0006DD0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253873, XrefRangeEnd = 253888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0006FB40 File Offset: 0x0006DD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253888, XrefRangeEnd = 253896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_NotifyAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0006FB74 File Offset: 0x0006DD74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253896, XrefRangeEnd = 253900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator NotifyAll(string title, string text, int id, string notificationProfile, int badgeNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_NotifyAll_Public_IEnumerator_String_String_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0006FC08 File Offset: 0x0006DE08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253900, XrefRangeEnd = 253908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLocalNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_CreateLocalNotification_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0006FC3C File Offset: 0x0006DE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253908, XrefRangeEnd = 253916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleLocalNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0006FC70 File Offset: 0x0006DE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253916, XrefRangeEnd = 253924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScheduleRepeatingLocalNotification()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_ScheduleRepeatingLocalNotification_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0006FCA4 File Offset: 0x0006DEA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253930, RefRangeEnd = 253931, XrefRangeStart = 253924, XrefRangeEnd = 253930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Hide_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253937, RefRangeEnd = 253938, XrefRangeStart = 253931, XrefRangeEnd = 253937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Cancel_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0006FD24 File Offset: 0x0006DF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253938, XrefRangeEnd = 253945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_CancelAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0006FD58 File Offset: 0x0006DF58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253945, XrefRangeEnd = 253951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementBadge()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_IncrementBadge_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0006FD8C File Offset: 0x0006DF8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253951, XrefRangeEnd = 253958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotificationsEnabledToggleValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_OnNotificationsEnabledToggleValueChanged_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0006FDCC File Offset: 0x0006DFCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 253977, RefRangeEnd = 253980, XrefRangeStart = 253958, XrefRangeEnd = 253977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Dictionary<string, string> UserData(bool hasImage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasImage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_UserData_Protected_Dictionary_2_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
			}
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0006FE18 File Offset: 0x0006E018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 254030, RefRangeEnd = 254033, XrefRangeStart = 253980, XrefRangeEnd = 254030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Button> Buttons(bool hasButtons)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasButtons;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Buttons_Protected_List_1_Button_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Button>>(intPtr3) : null;
			}
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0006FE64 File Offset: 0x0006E064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254033, XrefRangeEnd = 254040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendRegistrationId(string providerName, string registrationId)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_SendRegistrationId_Protected_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254040, XrefRangeEnd = 254044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator SendRegistrationId(string userId, string providerName, string registrationId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(userId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(registrationId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_SendRegistrationId_Protected_IEnumerator_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0006FF2C File Offset: 0x0006E12C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254044, XrefRangeEnd = 254046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotificationClicked(ReceivedNotification notification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(notification);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_OnNotificationClicked_Protected_Void_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA3 RID: 7331 RVA: 0x0006FF70 File Offset: 0x0006E170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254046, XrefRangeEnd = 254062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNotificationsReceived(IList<ReceivedNotification> receivedNotifications)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(receivedNotifications);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001CA4 RID: 7332 RVA: 0x0006FFB4 File Offset: 0x0006E1B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254062, XrefRangeEnd = 254073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0006FFE8 File Offset: 0x0006E1E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254073, XrefRangeEnd = 254145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA6 RID: 7334 RVA: 0x0007001C File Offset: 0x0006E21C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254145, XrefRangeEnd = 254152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA7 RID: 7335 RVA: 0x00070050 File Offset: 0x0006E250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254152, XrefRangeEnd = 254188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA8 RID: 7336 RVA: 0x00070084 File Offset: 0x0006E284
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UTNotificationsSample()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA9 RID: 7337 RVA: 0x000700C0 File Offset: 0x0006E2C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254188, XrefRangeEnd = 254194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _NotifyAll_b__9_0(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr__NotifyAll_b__9_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAA RID: 7338 RVA: 0x00070160 File Offset: 0x0006E360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254194, XrefRangeEnd = 254201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateLocalNotification_b__11_0(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr__CreateLocalNotification_b__11_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAB RID: 7339 RVA: 0x00070200 File Offset: 0x0006E400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254201, XrefRangeEnd = 254207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScheduleLocalNotification_b__12_0(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr__ScheduleLocalNotification_b__12_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAC RID: 7340 RVA: 0x000702A0 File Offset: 0x0006E4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254207, XrefRangeEnd = 254219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _ScheduleRepeatingLocalNotification_b__13_0(string title, string text, int id, string notificationProfile, int badge, bool hasImage, bool hasButtons)
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badge;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasImage;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasButtons;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.NativeMethodInfoPtr__ScheduleRepeatingLocalNotification_b__13_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CAD RID: 7341 RVA: 0x0001252C File Offset: 0x0001072C
		public UTNotificationsSample(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001CAE RID: 7342 RVA: 0x00070340 File Offset: 0x0006E540
		// (set) Token: 0x06001CAF RID: 7343 RVA: 0x00012535 File Offset: 0x00010735
		public unsafe ValidatedInputField DemoServerURLInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_DemoServerURLInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValidatedInputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_DemoServerURLInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001CB0 RID: 7344 RVA: 0x00070370 File Offset: 0x0006E570
		// (set) Token: 0x06001CB1 RID: 7345 RVA: 0x00012554 File Offset: 0x00010754
		public unsafe Text NotifyAllText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotifyAllText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotifyAllText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001CB2 RID: 7346 RVA: 0x000703A0 File Offset: 0x0006E5A0
		// (set) Token: 0x06001CB3 RID: 7347 RVA: 0x00012573 File Offset: 0x00010773
		public unsafe Text InitializeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_InitializeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_InitializeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001CB4 RID: 7348 RVA: 0x000703D0 File Offset: 0x0006E5D0
		// (set) Token: 0x06001CB5 RID: 7349 RVA: 0x00012592 File Offset: 0x00010792
		public unsafe Toggle NotificationsEnabledToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotificationsEnabledToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotificationsEnabledToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001CB6 RID: 7350 RVA: 0x00070400 File Offset: 0x0006E600
		// (set) Token: 0x06001CB7 RID: 7351 RVA: 0x000125B1 File Offset: 0x000107B1
		public unsafe CreateNotificationDialog CreateNotificationDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_CreateNotificationDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreateNotificationDialog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_CreateNotificationDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00070430 File Offset: 0x0006E630
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x000125D0 File Offset: 0x000107D0
		public unsafe NotificationDetailsDialog NotificationDetailsDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotificationDetailsDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NotificationDetailsDialog>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_NotificationDetailsDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x06001CBA RID: 7354 RVA: 0x00070460 File Offset: 0x0006E660
		// (set) Token: 0x06001CBB RID: 7355 RVA: 0x000125EF File Offset: 0x000107EF
		public unsafe static UTNotificationsSample instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UTNotificationsSample.NativeFieldInfoPtr_instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTNotificationsSample>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UTNotificationsSample.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06001CBC RID: 7356 RVA: 0x00070488 File Offset: 0x0006E688
		// (set) Token: 0x06001CBD RID: 7357 RVA: 0x00012601 File Offset: 0x00010801
		public unsafe string notifyAllTextOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_notifyAllTextOriginal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_notifyAllTextOriginal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000704B0 File Offset: 0x0006E6B0
		// (set) Token: 0x06001CBF RID: 7359 RVA: 0x00012620 File Offset: 0x00010820
		public unsafe string initializeTextOriginal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_initializeTextOriginal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample.NativeFieldInfoPtr_initializeTextOriginal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeFieldInfoPtr_DemoServerURLInputField;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeFieldInfoPtr_NotifyAllText;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_InitializeText;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_NotificationsEnabledToggle;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_CreateNotificationDialog;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_NotificationDetailsDialog;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_instance;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_notifyAllTextOriginal;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeFieldInfoPtr_initializeTextOriginal;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_UTNotificationsSample_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAll_Public_Void_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAll_Public_IEnumerator_String_String_Int32_String_Int32_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_CreateLocalNotification_Public_Void_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleLocalNotification_Public_Void_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr_ScheduleRepeatingLocalNotification_Public_Void_0;

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_Int32_0;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_Int32_0;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_CancelAll_Public_Void_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_IncrementBadge_Public_Void_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_OnNotificationsEnabledToggleValueChanged_Public_Void_Boolean_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr_UserData_Protected_Dictionary_2_String_String_Boolean_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_Buttons_Protected_List_1_Button_Boolean_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr_SendRegistrationId_Protected_Void_String_String_0;

		// Token: 0x04001351 RID: 4945
		private static readonly IntPtr NativeMethodInfoPtr_SendRegistrationId_Protected_IEnumerator_String_String_String_0;

		// Token: 0x04001352 RID: 4946
		private static readonly IntPtr NativeMethodInfoPtr_OnNotificationClicked_Protected_Void_ReceivedNotification_0;

		// Token: 0x04001353 RID: 4947
		private static readonly IntPtr NativeMethodInfoPtr_OnNotificationsReceived_Protected_Void_IList_1_ReceivedNotification_0;

		// Token: 0x04001354 RID: 4948
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001355 RID: 4949
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001356 RID: 4950
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04001357 RID: 4951
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001358 RID: 4952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001359 RID: 4953
		private static readonly IntPtr NativeMethodInfoPtr__NotifyAll_b__9_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0;

		// Token: 0x0400135A RID: 4954
		private static readonly IntPtr NativeMethodInfoPtr__CreateLocalNotification_b__11_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0;

		// Token: 0x0400135B RID: 4955
		private static readonly IntPtr NativeMethodInfoPtr__ScheduleLocalNotification_b__12_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0;

		// Token: 0x0400135C RID: 4956
		private static readonly IntPtr NativeMethodInfoPtr__ScheduleRepeatingLocalNotification_b__13_0_Private_Void_String_String_Int32_String_Int32_Boolean_Boolean_0;

		// Token: 0x0200020B RID: 523
		[ObfuscatedName("UTNotifications.UTNotificationsSample+<NotifyAll>d__10")]
		public sealed class _NotifyAll_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x06002959 RID: 10585 RVA: 0x00095040 File Offset: 0x00093240
			// Note: this type is marked as 'beforefieldinit'.
			static _NotifyAll_d__10()
			{
				Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "<NotifyAll>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr);
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "<>1__state");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "<>2__current");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "title");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "text");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "<>4__this");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "id");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_badgeNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "badgeNumber");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_notificationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "notificationProfile");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "<www>5__2");
				UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__dots_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, "<dots>5__3");
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666547);
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666548);
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666549);
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666550);
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666551);
				UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr, 100666552);
			}

			// Token: 0x0600295A RID: 10586 RVA: 0x000951AC File Offset: 0x000933AC
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NotifyAll_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTNotificationsSample._NotifyAll_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600295B RID: 10587 RVA: 0x000951F4 File Offset: 0x000933F4
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600295C RID: 10588 RVA: 0x00095228 File Offset: 0x00093428
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253756, XrefRangeEnd = 253815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x0600295D RID: 10589 RVA: 0x00095264 File Offset: 0x00093464
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600295E RID: 10590 RVA: 0x000952A4 File Offset: 0x000934A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253815, XrefRangeEnd = 253820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x0600295F RID: 10591 RVA: 0x000952D8 File Offset: 0x000934D8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._NotifyAll_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002960 RID: 10592 RVA: 0x0001972F File Offset: 0x0001792F
			public _NotifyAll_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D06 RID: 3334
			// (get) Token: 0x06002961 RID: 10593 RVA: 0x00095318 File Offset: 0x00093518
			// (set) Token: 0x06002962 RID: 10594 RVA: 0x00019738 File Offset: 0x00017938
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D07 RID: 3335
			// (get) Token: 0x06002963 RID: 10595 RVA: 0x00095340 File Offset: 0x00093540
			// (set) Token: 0x06002964 RID: 10596 RVA: 0x00019753 File Offset: 0x00017953
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D08 RID: 3336
			// (get) Token: 0x06002965 RID: 10597 RVA: 0x00095370 File Offset: 0x00093570
			// (set) Token: 0x06002966 RID: 10598 RVA: 0x00019772 File Offset: 0x00017972
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D09 RID: 3337
			// (get) Token: 0x06002967 RID: 10599 RVA: 0x00095398 File Offset: 0x00093598
			// (set) Token: 0x06002968 RID: 10600 RVA: 0x00019791 File Offset: 0x00017991
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06002969 RID: 10601 RVA: 0x000953C0 File Offset: 0x000935C0
			// (set) Token: 0x0600296A RID: 10602 RVA: 0x000197B0 File Offset: 0x000179B0
			public unsafe UTNotificationsSample __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTNotificationsSample>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x0600296B RID: 10603 RVA: 0x000953F0 File Offset: 0x000935F0
			// (set) Token: 0x0600296C RID: 10604 RVA: 0x000197CF File Offset: 0x000179CF
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x0600296D RID: 10605 RVA: 0x00095418 File Offset: 0x00093618
			// (set) Token: 0x0600296E RID: 10606 RVA: 0x000197EA File Offset: 0x000179EA
			public unsafe int badgeNumber
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_badgeNumber);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_badgeNumber)) = value;
				}
			}

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x0600296F RID: 10607 RVA: 0x00095440 File Offset: 0x00093640
			// (set) Token: 0x06002970 RID: 10608 RVA: 0x00019805 File Offset: 0x00017A05
			public unsafe string notificationProfile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_notificationProfile);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr_notificationProfile), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x06002971 RID: 10609 RVA: 0x00095468 File Offset: 0x00093668
			// (set) Token: 0x06002972 RID: 10610 RVA: 0x00019824 File Offset: 0x00017A24
			public unsafe WWW _www_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__www_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06002973 RID: 10611 RVA: 0x00095498 File Offset: 0x00093698
			// (set) Token: 0x06002974 RID: 10612 RVA: 0x00019843 File Offset: 0x00017A43
			public unsafe int _dots_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__dots_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._NotifyAll_d__10.NativeFieldInfoPtr__dots_5__3)) = value;
				}
			}

			// Token: 0x04001C54 RID: 7252
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C55 RID: 7253
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C56 RID: 7254
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x04001C57 RID: 7255
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04001C58 RID: 7256
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C59 RID: 7257
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001C5A RID: 7258
			private static readonly IntPtr NativeFieldInfoPtr_badgeNumber;

			// Token: 0x04001C5B RID: 7259
			private static readonly IntPtr NativeFieldInfoPtr_notificationProfile;

			// Token: 0x04001C5C RID: 7260
			private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

			// Token: 0x04001C5D RID: 7261
			private static readonly IntPtr NativeFieldInfoPtr__dots_5__3;

			// Token: 0x04001C5E RID: 7262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C5F RID: 7263
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C60 RID: 7264
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C61 RID: 7265
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C62 RID: 7266
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C63 RID: 7267
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200020C RID: 524
		[ObfuscatedName("UTNotifications.UTNotificationsSample+<SendRegistrationId>d__22")]
		public sealed class _SendRegistrationId_d__22 : global::Il2CppSystem.Object
		{
			// Token: 0x06002975 RID: 10613 RVA: 0x000954C0 File Offset: 0x000936C0
			// Note: this type is marked as 'beforefieldinit'.
			static _SendRegistrationId_d__22()
			{
				Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "<SendRegistrationId>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr);
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "<>1__state");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "<>2__current");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_userId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "userId");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_providerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "providerName");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_registrationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "registrationId");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "<>4__this");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__www_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "<www>5__2");
				UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__dots_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, "<dots>5__3");
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666553);
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666554);
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666555);
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666556);
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666557);
				UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr, 100666558);
			}

			// Token: 0x06002976 RID: 10614 RVA: 0x00095604 File Offset: 0x00093804
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _SendRegistrationId_d__22(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTNotificationsSample._SendRegistrationId_d__22>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002977 RID: 10615 RVA: 0x0009564C File Offset: 0x0009384C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002978 RID: 10616 RVA: 0x00095680 File Offset: 0x00093880
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253820, XrefRangeEnd = 253864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D1A RID: 3354
			// (get) Token: 0x06002979 RID: 10617 RVA: 0x000956BC File Offset: 0x000938BC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600297A RID: 10618 RVA: 0x000956FC File Offset: 0x000938FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253864, XrefRangeEnd = 253869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D1B RID: 3355
			// (get) Token: 0x0600297B RID: 10619 RVA: 0x00095730 File Offset: 0x00093930
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample._SendRegistrationId_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600297C RID: 10620 RVA: 0x0001985E File Offset: 0x00017A5E
			public _SendRegistrationId_d__22(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x0600297D RID: 10621 RVA: 0x00095770 File Offset: 0x00093970
			// (set) Token: 0x0600297E RID: 10622 RVA: 0x00019867 File Offset: 0x00017A67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x0600297F RID: 10623 RVA: 0x00095798 File Offset: 0x00093998
			// (set) Token: 0x06002980 RID: 10624 RVA: 0x00019882 File Offset: 0x00017A82
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x06002981 RID: 10625 RVA: 0x000957C8 File Offset: 0x000939C8
			// (set) Token: 0x06002982 RID: 10626 RVA: 0x000198A1 File Offset: 0x00017AA1
			public unsafe string userId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_userId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_userId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x06002983 RID: 10627 RVA: 0x000957F0 File Offset: 0x000939F0
			// (set) Token: 0x06002984 RID: 10628 RVA: 0x000198C0 File Offset: 0x00017AC0
			public unsafe string providerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_providerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_providerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x06002985 RID: 10629 RVA: 0x00095818 File Offset: 0x00093A18
			// (set) Token: 0x06002986 RID: 10630 RVA: 0x000198DF File Offset: 0x00017ADF
			public unsafe string registrationId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_registrationId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr_registrationId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x06002987 RID: 10631 RVA: 0x00095840 File Offset: 0x00093A40
			// (set) Token: 0x06002988 RID: 10632 RVA: 0x000198FE File Offset: 0x00017AFE
			public unsafe UTNotificationsSample __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTNotificationsSample>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D18 RID: 3352
			// (get) Token: 0x06002989 RID: 10633 RVA: 0x00095870 File Offset: 0x00093A70
			// (set) Token: 0x0600298A RID: 10634 RVA: 0x0001991D File Offset: 0x00017B1D
			public unsafe WWW _www_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__www_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WWW>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__www_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D19 RID: 3353
			// (get) Token: 0x0600298B RID: 10635 RVA: 0x000958A0 File Offset: 0x00093AA0
			// (set) Token: 0x0600298C RID: 10636 RVA: 0x0001993C File Offset: 0x00017B3C
			public unsafe int _dots_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__dots_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UTNotificationsSample._SendRegistrationId_d__22.NativeFieldInfoPtr__dots_5__3)) = value;
				}
			}

			// Token: 0x04001C64 RID: 7268
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C65 RID: 7269
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C66 RID: 7270
			private static readonly IntPtr NativeFieldInfoPtr_userId;

			// Token: 0x04001C67 RID: 7271
			private static readonly IntPtr NativeFieldInfoPtr_providerName;

			// Token: 0x04001C68 RID: 7272
			private static readonly IntPtr NativeFieldInfoPtr_registrationId;

			// Token: 0x04001C69 RID: 7273
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C6A RID: 7274
			private static readonly IntPtr NativeFieldInfoPtr__www_5__2;

			// Token: 0x04001C6B RID: 7275
			private static readonly IntPtr NativeFieldInfoPtr__dots_5__3;

			// Token: 0x04001C6C RID: 7276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C6D RID: 7277
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C6E RID: 7278
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C6F RID: 7279
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C70 RID: 7280
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C71 RID: 7281
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200020D RID: 525
		[ObfuscatedName("UTNotifications.UTNotificationsSample+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600298D RID: 10637 RVA: 0x000958C8 File Offset: 0x00093AC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UTNotificationsSample>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr);
				UTNotificationsSample.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr, "<>9");
				UTNotificationsSample.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr, "<>9__26_0");
				UTNotificationsSample.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr, 100666560);
				UTNotificationsSample.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr, 100666561);
			}

			// Token: 0x0600298E RID: 10638 RVA: 0x00095944 File Offset: 0x00093B44
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UTNotificationsSample.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600298F RID: 10639 RVA: 0x00095980 File Offset: 0x00093B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__26_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UTNotificationsSample.__c.NativeMethodInfoPtr__Start_b__26_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002990 RID: 10640 RVA: 0x00019957 File Offset: 0x00017B57
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D1C RID: 3356
			// (get) Token: 0x06002991 RID: 10641 RVA: 0x000959B4 File Offset: 0x00093BB4
			// (set) Token: 0x06002992 RID: 10642 RVA: 0x00019960 File Offset: 0x00017B60
			public unsafe static UTNotificationsSample.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UTNotificationsSample.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UTNotificationsSample.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UTNotificationsSample.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1D RID: 3357
			// (get) Token: 0x06002993 RID: 10643 RVA: 0x000959DC File Offset: 0x00093BDC
			// (set) Token: 0x06002994 RID: 10644 RVA: 0x00019972 File Offset: 0x00017B72
			public unsafe static UnityAction __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UTNotificationsSample.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UTNotificationsSample.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C72 RID: 7282
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C73 RID: 7283
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04001C74 RID: 7284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C75 RID: 7285
			private static readonly IntPtr NativeMethodInfoPtr__Start_b__26_0_Internal_Void_0;
		}
	}
}
