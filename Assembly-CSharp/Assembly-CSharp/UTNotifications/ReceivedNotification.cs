using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UTNotifications
{
	// Token: 0x020000F1 RID: 241
	public class ReceivedNotification : Object
	{
		// Token: 0x06001D15 RID: 7445 RVA: 0x0007207C File Offset: 0x0007027C
		// Note: this type is marked as 'beforefieldinit'.
		static ReceivedNotification()
		{
			Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "ReceivedNotification");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr);
			ReceivedNotification.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "title");
			ReceivedNotification.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "text");
			ReceivedNotification.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "id");
			ReceivedNotification.NativeFieldInfoPtr_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "userData");
			ReceivedNotification.NativeFieldInfoPtr_notificationProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "notificationProfile");
			ReceivedNotification.NativeFieldInfoPtr_badgeNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, "badgeNumber");
			ReceivedNotification.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr, 100665628);
		}

		// Token: 0x06001D16 RID: 7446 RVA: 0x00072138 File Offset: 0x00070338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254507, XrefRangeEnd = 254508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReceivedNotification(string title, string text, int id, IDictionary<string, string> userData, string notificationProfile, int badgeNumber)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReceivedNotification>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userData);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notificationProfile);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref badgeNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReceivedNotification.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D17 RID: 7447 RVA: 0x00012758 File Offset: 0x00010958
		public ReceivedNotification(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x000721D8 File Offset: 0x000703D8
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00012761 File Offset: 0x00010961
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00072200 File Offset: 0x00070400
		// (set) Token: 0x06001D1B RID: 7451 RVA: 0x00012780 File Offset: 0x00010980
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001D1C RID: 7452 RVA: 0x00072228 File Offset: 0x00070428
		// (set) Token: 0x06001D1D RID: 7453 RVA: 0x0001279F File Offset: 0x0001099F
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00072250 File Offset: 0x00070450
		// (set) Token: 0x06001D1F RID: 7455 RVA: 0x000127BA File Offset: 0x000109BA
		public unsafe IDictionary<string, string> userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_userData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_userData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001D20 RID: 7456 RVA: 0x00072280 File Offset: 0x00070480
		// (set) Token: 0x06001D21 RID: 7457 RVA: 0x000127D9 File Offset: 0x000109D9
		public unsafe string notificationProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_notificationProfile);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_notificationProfile), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x000722A8 File Offset: 0x000704A8
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x000127F8 File Offset: 0x000109F8
		public unsafe int badgeNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_badgeNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReceivedNotification.NativeFieldInfoPtr_badgeNumber)) = value;
			}
		}

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr_userData;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr_notificationProfile;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeFieldInfoPtr_badgeNumber;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_IDictionary_2_String_String_String_Int32_0;
	}
}
