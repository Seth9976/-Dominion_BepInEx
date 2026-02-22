using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000123 RID: 291
public sealed class NotificationsTab : FeatureTab
{
	// Token: 0x06001418 RID: 5144 RVA: 0x0005C8DC File Offset: 0x0005AADC
	// Note: this type is marked as 'beforefieldinit'.
	static NotificationsTab()
	{
		Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "NotificationsTab");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr);
		NotificationsTab.NativeFieldInfoPtr_bigPicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, "bigPicture");
		NotificationsTab.NativeFieldInfoPtr_LastNotificationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, "LastNotificationId");
		NotificationsTab.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665739);
		NotificationsTab.NativeMethodInfoPtr_OnShowToastButton_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665740);
		NotificationsTab.NativeMethodInfoPtr_OnScheduleLocal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665741);
		NotificationsTab.NativeMethodInfoPtr_OnCancelLastLocal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665742);
		NotificationsTab.NativeMethodInfoPtr_OnCancelAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665743);
		NotificationsTab.NativeMethodInfoPtr_OnRegisterDevice_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665744);
		NotificationsTab.NativeMethodInfoPtr_OnLoadLastGcmMessage_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665745);
		NotificationsTab.NativeMethodInfoPtr_HandleActionGCMPushReceived_Private_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665746);
		NotificationsTab.NativeMethodInfoPtr_HandleActionGCMPushLaunched_Private_Void_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665747);
		NotificationsTab.NativeMethodInfoPtr_HandleActionCMDRegistrationResult_Private_Void_GP_GCM_RegistrationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665748);
		NotificationsTab.NativeMethodInfoPtr_OnNotificationIdLoaded_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665749);
		NotificationsTab.NativeMethodInfoPtr_OnMessageLoaded_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665750);
		NotificationsTab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr, 100665751);
	}

	// Token: 0x06001419 RID: 5145 RVA: 0x0005CA38 File Offset: 0x0005AC38
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186661, XrefRangeEnd = 186706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x0005CA6C File Offset: 0x0005AC6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186706, XrefRangeEnd = 186709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnShowToastButton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnShowToastButton_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x0005CAA0 File Offset: 0x0005ACA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186709, XrefRangeEnd = 186726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnScheduleLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnScheduleLocal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141C RID: 5148 RVA: 0x0005CAD4 File Offset: 0x0005ACD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186726, XrefRangeEnd = 186734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCancelLastLocal()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnCancelLastLocal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141D RID: 5149 RVA: 0x0005CB08 File Offset: 0x0005AD08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186734, XrefRangeEnd = 186742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnCancelAll()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnCancelAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x0005CB3C File Offset: 0x0005AD3C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186742, XrefRangeEnd = 186750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnRegisterDevice()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnRegisterDevice_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x0005CB70 File Offset: 0x0005AD70
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186750, XrefRangeEnd = 186758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnLoadLastGcmMessage()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnLoadLastGcmMessage_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x0005CBA4 File Offset: 0x0005ADA4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186758, XrefRangeEnd = 186794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionGCMPushReceived(string message, Dictionary<string, global::Il2CppSystem.Object> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_HandleActionGCMPushReceived_Private_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x0005CBF8 File Offset: 0x0005ADF8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186794, XrefRangeEnd = 186830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionGCMPushLaunched(string message, Dictionary<string, global::Il2CppSystem.Object> data)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_HandleActionGCMPushLaunched_Private_Void_String_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x0005CC4C File Offset: 0x0005AE4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186830, XrefRangeEnd = 186849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void HandleActionCMDRegistrationResult(GP_GCM_RegistrationResult res)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_HandleActionCMDRegistrationResult_Private_Void_GP_GCM_RegistrationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x0005CC90 File Offset: 0x0005AE90
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186849, XrefRangeEnd = 186856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnNotificationIdLoaded(int notificationid)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref notificationid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnNotificationIdLoaded_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x0005CCD0 File Offset: 0x0005AED0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186856, XrefRangeEnd = 186869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnMessageLoaded(string msg)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr_OnMessageLoaded_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x0005CD14 File Offset: 0x0005AF14
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 114494, RefRangeEnd = 114502, XrefRangeStart = 114494, XrefRangeEnd = 114502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NotificationsTab()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationsTab>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationsTab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x00009CEA File Offset: 0x00007EEA
	public NotificationsTab(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170005C9 RID: 1481
	// (get) Token: 0x06001427 RID: 5159 RVA: 0x0005CD50 File Offset: 0x0005AF50
	// (set) Token: 0x06001428 RID: 5160 RVA: 0x00009CF3 File Offset: 0x00007EF3
	public unsafe Texture2D bigPicture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsTab.NativeFieldInfoPtr_bigPicture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsTab.NativeFieldInfoPtr_bigPicture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170005CA RID: 1482
	// (get) Token: 0x06001429 RID: 5161 RVA: 0x0005CD80 File Offset: 0x0005AF80
	// (set) Token: 0x0600142A RID: 5162 RVA: 0x00009D12 File Offset: 0x00007F12
	public unsafe int LastNotificationId
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsTab.NativeFieldInfoPtr_LastNotificationId);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationsTab.NativeFieldInfoPtr_LastNotificationId)) = value;
		}
	}

	// Token: 0x04000F57 RID: 3927
	private static readonly IntPtr NativeFieldInfoPtr_bigPicture;

	// Token: 0x04000F58 RID: 3928
	private static readonly IntPtr NativeFieldInfoPtr_LastNotificationId;

	// Token: 0x04000F59 RID: 3929
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000F5A RID: 3930
	private static readonly IntPtr NativeMethodInfoPtr_OnShowToastButton_Public_Void_0;

	// Token: 0x04000F5B RID: 3931
	private static readonly IntPtr NativeMethodInfoPtr_OnScheduleLocal_Public_Void_0;

	// Token: 0x04000F5C RID: 3932
	private static readonly IntPtr NativeMethodInfoPtr_OnCancelLastLocal_Public_Void_0;

	// Token: 0x04000F5D RID: 3933
	private static readonly IntPtr NativeMethodInfoPtr_OnCancelAll_Public_Void_0;

	// Token: 0x04000F5E RID: 3934
	private static readonly IntPtr NativeMethodInfoPtr_OnRegisterDevice_Public_Void_0;

	// Token: 0x04000F5F RID: 3935
	private static readonly IntPtr NativeMethodInfoPtr_OnLoadLastGcmMessage_Public_Void_0;

	// Token: 0x04000F60 RID: 3936
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionGCMPushReceived_Private_Void_String_Dictionary_2_String_Object_0;

	// Token: 0x04000F61 RID: 3937
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionGCMPushLaunched_Private_Void_String_Dictionary_2_String_Object_0;

	// Token: 0x04000F62 RID: 3938
	private static readonly IntPtr NativeMethodInfoPtr_HandleActionCMDRegistrationResult_Private_Void_GP_GCM_RegistrationResult_0;

	// Token: 0x04000F63 RID: 3939
	private static readonly IntPtr NativeMethodInfoPtr_OnNotificationIdLoaded_Private_Void_Int32_0;

	// Token: 0x04000F64 RID: 3940
	private static readonly IntPtr NativeMethodInfoPtr_OnMessageLoaded_Private_Void_String_0;

	// Token: 0x04000F65 RID: 3941
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
