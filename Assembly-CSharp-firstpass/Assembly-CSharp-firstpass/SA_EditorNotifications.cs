using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x02000141 RID: 321
public class SA_EditorNotifications : Object
{
	// Token: 0x060017CC RID: 6092 RVA: 0x00068FB0 File Offset: 0x000671B0
	// Note: this type is marked as 'beforefieldinit'.
	static SA_EditorNotifications()
	{
		Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "SA_EditorNotifications");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr);
		SA_EditorNotifications.NativeFieldInfoPtr__EditorUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr, "_EditorUI");
		SA_EditorNotifications.NativeMethodInfoPtr_ShowNotification_Public_Static_Void_String_String_SA_EditorNotificationType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr, 100666185);
		SA_EditorNotifications.NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_Notifications_EditorUIController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr, 100666186);
		SA_EditorNotifications.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr, 100666187);
	}

	// Token: 0x060017CD RID: 6093 RVA: 0x00069030 File Offset: 0x00067230
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 194611, RefRangeEnd = 194626, XrefRangeStart = 194600, XrefRangeEnd = 194611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowNotification(string title, string message, SA_EditorNotificationType type)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorNotifications.NativeMethodInfoPtr_ShowNotification_Public_Static_Void_String_String_SA_EditorNotificationType_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x170006B5 RID: 1717
	// (get) Token: 0x060017CE RID: 6094 RVA: 0x00069088 File Offset: 0x00067288
	public unsafe static SA_Notifications_EditorUIController EditorUI
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194626, XrefRangeEnd = 194630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorNotifications.NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_Notifications_EditorUIController_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SA_Notifications_EditorUIController>(intPtr3) : null;
		}
	}

	// Token: 0x060017CF RID: 6095 RVA: 0x000690BC File Offset: 0x000672BC
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SA_EditorNotifications()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_EditorNotifications>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_EditorNotifications.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060017D0 RID: 6096 RVA: 0x0000B7A3 File Offset: 0x000099A3
	public SA_EditorNotifications(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170006B4 RID: 1716
	// (get) Token: 0x060017D1 RID: 6097 RVA: 0x000690F8 File Offset: 0x000672F8
	// (set) Token: 0x060017D2 RID: 6098 RVA: 0x0000B7AC File Offset: 0x000099AC
	public unsafe static SA_Notifications_EditorUIController _EditorUI
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(SA_EditorNotifications.NativeFieldInfoPtr__EditorUI, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SA_Notifications_EditorUIController>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(SA_EditorNotifications.NativeFieldInfoPtr__EditorUI, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040011FE RID: 4606
	private static readonly IntPtr NativeFieldInfoPtr__EditorUI;

	// Token: 0x040011FF RID: 4607
	private static readonly IntPtr NativeMethodInfoPtr_ShowNotification_Public_Static_Void_String_String_SA_EditorNotificationType_0;

	// Token: 0x04001200 RID: 4608
	private static readonly IntPtr NativeMethodInfoPtr_get_EditorUI_Private_Static_get_SA_Notifications_EditorUIController_0;

	// Token: 0x04001201 RID: 4609
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
