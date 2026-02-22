using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000B9 RID: 185
public class AN_CloudMessagingProxy : Object
{
	// Token: 0x06000D6D RID: 3437 RVA: 0x00046330 File Offset: 0x00044530
	// Note: this type is marked as 'beforefieldinit'.
	static AN_CloudMessagingProxy()
	{
		Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_CloudMessagingProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr);
		AN_CloudMessagingProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, "CLASS_NAME");
		AN_CloudMessagingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664932);
		AN_CloudMessagingProxy.NativeMethodInfoPtr_InitPushNotifications_Public_Static_Void_String_String_String_Boolean_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664933);
		AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMRgisterDevice_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664934);
		AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMLoadLastMessage_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664935);
		AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMRemoveLastMessageInfo_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664936);
		AN_CloudMessagingProxy.NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664937);
		AN_CloudMessagingProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr, 100664938);
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x00046400 File Offset: 0x00044600
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177293, XrefRangeEnd = 177294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CallActivityFunction(string methodName, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x00046458 File Offset: 0x00044658
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 177309, RefRangeEnd = 177311, XrefRangeStart = 177294, XrefRangeEnd = 177309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void InitPushNotifications(string smallIcon, string largeIcon, string sound, bool vibration, bool showWhenAppForeground, bool replaceOldNotificationWithNew, string color)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(smallIcon);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(largeIcon);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sound);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref vibration;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showWhenAppForeground;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replaceOldNotificationWithNew;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(color);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_InitPushNotifications_Public_Static_Void_String_String_String_Boolean_Boolean_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x000464F0 File Offset: 0x000446F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177317, RefRangeEnd = 177318, XrefRangeStart = 177311, XrefRangeEnd = 177317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GCMRgisterDevice(string senderId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(senderId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMRgisterDevice_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x00046528 File Offset: 0x00044728
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177323, RefRangeEnd = 177324, XrefRangeStart = 177318, XrefRangeEnd = 177323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GCMLoadLastMessage()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMLoadLastMessage_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x00046550 File Offset: 0x00044750
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177329, RefRangeEnd = 177330, XrefRangeStart = 177324, XrefRangeEnd = 177329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GCMRemoveLastMessageInfo()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_GCMRemoveLastMessageInfo_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x00046578 File Offset: 0x00044778
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177335, RefRangeEnd = 177336, XrefRangeStart = 177330, XrefRangeEnd = 177335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAllNotifications()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x000465A0 File Offset: 0x000447A0
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_CloudMessagingProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_CloudMessagingProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_CloudMessagingProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0000750F File Offset: 0x0000570F
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_CloudMessagingProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x0000751D File Offset: 0x0000571D
	public AN_CloudMessagingProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700042F RID: 1071
	// (get) Token: 0x06000D77 RID: 3447 RVA: 0x000465DC File Offset: 0x000447DC
	// (set) Token: 0x06000D78 RID: 3448 RVA: 0x00007526 File Offset: 0x00005726
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_CloudMessagingProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_CloudMessagingProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A71 RID: 2673
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A72 RID: 2674
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A73 RID: 2675
	private static readonly IntPtr NativeMethodInfoPtr_InitPushNotifications_Public_Static_Void_String_String_String_Boolean_Boolean_Boolean_String_0;

	// Token: 0x04000A74 RID: 2676
	private static readonly IntPtr NativeMethodInfoPtr_GCMRgisterDevice_Public_Static_Void_String_0;

	// Token: 0x04000A75 RID: 2677
	private static readonly IntPtr NativeMethodInfoPtr_GCMLoadLastMessage_Public_Static_Void_0;

	// Token: 0x04000A76 RID: 2678
	private static readonly IntPtr NativeMethodInfoPtr_GCMRemoveLastMessageInfo_Public_Static_Void_0;

	// Token: 0x04000A77 RID: 2679
	private static readonly IntPtr NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0;

	// Token: 0x04000A78 RID: 2680
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
