using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UTNotifications
{
	// Token: 0x020000E4 RID: 228
	public class NotificationDetailsDialog : MonoBehaviour
	{
		// Token: 0x06001C33 RID: 7219 RVA: 0x0006E5D0 File Offset: 0x0006C7D0
		// Note: this type is marked as 'beforefieldinit'.
		static NotificationDetailsDialog()
		{
			Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "NotificationDetailsDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr);
			NotificationDetailsDialog.NativeFieldInfoPtr_DialogTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "DialogTitle");
			NotificationDetailsDialog.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "ID");
			NotificationDetailsDialog.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "Title");
			NotificationDetailsDialog.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "Text");
			NotificationDetailsDialog.NativeFieldInfoPtr_Profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "Profile");
			NotificationDetailsDialog.NativeFieldInfoPtr_UserData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "UserData");
			NotificationDetailsDialog.NativeFieldInfoPtr_Badge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "Badge");
			NotificationDetailsDialog.NativeFieldInfoPtr_received = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "received");
			NotificationDetailsDialog.NativeFieldInfoPtr_clicked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "clicked");
			NotificationDetailsDialog.NativeMethodInfoPtr_get_Current_Public_get_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665504);
			NotificationDetailsDialog.NativeMethodInfoPtr_OnReceived_Public_Void_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665505);
			NotificationDetailsDialog.NativeMethodInfoPtr_OnClicked_Public_Void_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665506);
			NotificationDetailsDialog.NativeMethodInfoPtr_Hide_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665507);
			NotificationDetailsDialog.NativeMethodInfoPtr_Hide_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665508);
			NotificationDetailsDialog.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665509);
			NotificationDetailsDialog.NativeMethodInfoPtr_CancelAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665510);
			NotificationDetailsDialog.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665511);
			NotificationDetailsDialog.NativeMethodInfoPtr_UpdateContents_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665512);
			NotificationDetailsDialog.NativeMethodInfoPtr_UserDataString_Private_String_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665513);
			NotificationDetailsDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, 100665514);
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x0006E790 File Offset: 0x0006C990
		public unsafe ReceivedNotification Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253514, XrefRangeEnd = 253516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_get_Current_Public_get_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReceivedNotification>(intPtr3) : null;
			}
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x0006E7D0 File Offset: 0x0006C9D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253521, RefRangeEnd = 253522, XrefRangeStart = 253516, XrefRangeEnd = 253521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReceived(ReceivedNotification received)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(received);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_OnReceived_Public_Void_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x0006E814 File Offset: 0x0006CA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253523, RefRangeEnd = 253524, XrefRangeStart = 253522, XrefRangeEnd = 253523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnClicked(ReceivedNotification clicked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clicked);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_OnClicked_Public_Void_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x0006E858 File Offset: 0x0006CA58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253524, XrefRangeEnd = 253537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_Hide_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x0006E88C File Offset: 0x0006CA8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 253554, RefRangeEnd = 253556, XrefRangeStart = 253537, XrefRangeEnd = 253554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hide(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_Hide_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C39 RID: 7225 RVA: 0x0006E8CC File Offset: 0x0006CACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253556, XrefRangeEnd = 253569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3A RID: 7226 RVA: 0x0006E900 File Offset: 0x0006CB00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 253574, RefRangeEnd = 253575, XrefRangeStart = 253569, XrefRangeEnd = 253574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_CancelAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3B RID: 7227 RVA: 0x0006E934 File Offset: 0x0006CB34
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x0006E968 File Offset: 0x0006CB68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 253583, RefRangeEnd = 253587, XrefRangeStart = 253575, XrefRangeEnd = 253583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateContents()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_UpdateContents_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3D RID: 7229 RVA: 0x0006E99C File Offset: 0x0006CB9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253587, XrefRangeEnd = 253590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string UserDataString(IDictionary<string, string> userData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(userData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr_UserDataString_Private_String_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x0006E9E4 File Offset: 0x0006CBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 253590, XrefRangeEnd = 253597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotificationDetailsDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x0001225D File Offset: 0x0001045D
		public NotificationDetailsDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x0006EA20 File Offset: 0x0006CC20
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00012266 File Offset: 0x00010466
		public unsafe Text DialogTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_DialogTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_DialogTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x0006EA50 File Offset: 0x0006CC50
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00012285 File Offset: 0x00010485
		public unsafe Text ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_ID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_ID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x0006EA80 File Offset: 0x0006CC80
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x000122A4 File Offset: 0x000104A4
		public unsafe Text Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x0006EAB0 File Offset: 0x0006CCB0
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x000122C3 File Offset: 0x000104C3
		public unsafe Text Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x0006EAE0 File Offset: 0x0006CCE0
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x000122E2 File Offset: 0x000104E2
		public unsafe Text Profile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Profile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Profile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0006EB10 File Offset: 0x0006CD10
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x00012301 File Offset: 0x00010501
		public unsafe Text UserData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_UserData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_UserData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0006EB40 File Offset: 0x0006CD40
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00012320 File Offset: 0x00010520
		public unsafe Text Badge
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Badge);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_Badge), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x0006EB70 File Offset: 0x0006CD70
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x0001233F File Offset: 0x0001053F
		public unsafe List<ReceivedNotification> received
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_received);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ReceivedNotification>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_received), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x0006EBA0 File Offset: 0x0006CDA0
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x0001235E File Offset: 0x0001055E
		public unsafe ReceivedNotification clicked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_clicked);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReceivedNotification>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.NativeFieldInfoPtr_clicked), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001300 RID: 4864
		private static readonly IntPtr NativeFieldInfoPtr_DialogTitle;

		// Token: 0x04001301 RID: 4865
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001302 RID: 4866
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04001303 RID: 4867
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04001304 RID: 4868
		private static readonly IntPtr NativeFieldInfoPtr_Profile;

		// Token: 0x04001305 RID: 4869
		private static readonly IntPtr NativeFieldInfoPtr_UserData;

		// Token: 0x04001306 RID: 4870
		private static readonly IntPtr NativeFieldInfoPtr_Badge;

		// Token: 0x04001307 RID: 4871
		private static readonly IntPtr NativeFieldInfoPtr_received;

		// Token: 0x04001308 RID: 4872
		private static readonly IntPtr NativeFieldInfoPtr_clicked;

		// Token: 0x04001309 RID: 4873
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_get_ReceivedNotification_0;

		// Token: 0x0400130A RID: 4874
		private static readonly IntPtr NativeMethodInfoPtr_OnReceived_Public_Void_ReceivedNotification_0;

		// Token: 0x0400130B RID: 4875
		private static readonly IntPtr NativeMethodInfoPtr_OnClicked_Public_Void_ReceivedNotification_0;

		// Token: 0x0400130C RID: 4876
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_0;

		// Token: 0x0400130D RID: 4877
		private static readonly IntPtr NativeMethodInfoPtr_Hide_Public_Void_Int32_0;

		// Token: 0x0400130E RID: 4878
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x0400130F RID: 4879
		private static readonly IntPtr NativeMethodInfoPtr_CancelAll_Public_Void_0;

		// Token: 0x04001310 RID: 4880
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001311 RID: 4881
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContents_Private_Void_0;

		// Token: 0x04001312 RID: 4882
		private static readonly IntPtr NativeMethodInfoPtr_UserDataString_Private_String_IDictionary_2_String_String_0;

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200020A RID: 522
		[ObfuscatedName("UTNotifications.NotificationDetailsDialog+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002953 RID: 10579 RVA: 0x00094F24 File Offset: 0x00093124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NotificationDetailsDialog>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr);
				NotificationDetailsDialog.__c__DisplayClass12_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr, "id");
				NotificationDetailsDialog.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr, 100666545);
				NotificationDetailsDialog.__c__DisplayClass12_0.NativeMethodInfoPtr__Hide_b__0_Internal_Boolean_ReceivedNotification_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr, 100666546);
			}

			// Token: 0x06002954 RID: 10580 RVA: 0x00094F8C File Offset: 0x0009318C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotificationDetailsDialog.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002955 RID: 10581 RVA: 0x00094FC8 File Offset: 0x000931C8
			[CallerCount(0)]
			public unsafe bool _Hide_b__0(ReceivedNotification it)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(it);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotificationDetailsDialog.__c__DisplayClass12_0.NativeMethodInfoPtr__Hide_b__0_Internal_Boolean_ReceivedNotification_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002956 RID: 10582 RVA: 0x0001970B File Offset: 0x0001790B
			public __c__DisplayClass12_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D05 RID: 3333
			// (get) Token: 0x06002957 RID: 10583 RVA: 0x00095018 File Offset: 0x00093218
			// (set) Token: 0x06002958 RID: 10584 RVA: 0x00019714 File Offset: 0x00017914
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.__c__DisplayClass12_0.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotificationDetailsDialog.__c__DisplayClass12_0.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x04001C51 RID: 7249
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04001C52 RID: 7250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C53 RID: 7251
			private static readonly IntPtr NativeMethodInfoPtr__Hide_b__0_Internal_Boolean_ReceivedNotification_0;
		}
	}
}
