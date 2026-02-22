using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C5 RID: 197
public class AN_NotificationProxy : Object
{
	// Token: 0x06000E49 RID: 3657 RVA: 0x00049C60 File Offset: 0x00047E60
	// Note: this type is marked as 'beforefieldinit'.
	static AN_NotificationProxy()
	{
		Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_NotificationProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr);
		AN_NotificationProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, "CLASS_NAME");
		AN_NotificationProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665092);
		AN_NotificationProxy.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665093);
		AN_NotificationProxy.NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665094);
		AN_NotificationProxy.NativeMethodInfoPtr_requestCurrentAppLaunchNotificationId_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665095);
		AN_NotificationProxy.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Static_Void_AndroidNotificationBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665096);
		AN_NotificationProxy.NativeMethodInfoPtr_CanselLocalNotification_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665097);
		AN_NotificationProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr, 100665098);
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x00049D30 File Offset: 0x00047F30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178412, XrefRangeEnd = 178413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x00049D88 File Offset: 0x00047F88
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 178421, RefRangeEnd = 178425, XrefRangeStart = 178413, XrefRangeEnd = 178421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ShowToastNotification(string text, int duration)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x00049DCC File Offset: 0x00047FCC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178430, RefRangeEnd = 178431, XrefRangeStart = 178425, XrefRangeEnd = 178430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void HideAllNotifications()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x00049DF4 File Offset: 0x00047FF4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178436, RefRangeEnd = 178437, XrefRangeStart = 178431, XrefRangeEnd = 178436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void requestCurrentAppLaunchNotificationId()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_requestCurrentAppLaunchNotificationId_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x00049E1C File Offset: 0x0004801C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178500, RefRangeEnd = 178501, XrefRangeStart = 178437, XrefRangeEnd = 178500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ScheduleLocalNotification(AndroidNotificationBuilder builder)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_ScheduleLocalNotification_Public_Static_Void_AndroidNotificationBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00049E54 File Offset: 0x00048054
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178508, RefRangeEnd = 178509, XrefRangeStart = 178501, XrefRangeEnd = 178508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CanselLocalNotification(int id)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr_CanselLocalNotification_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00049E88 File Offset: 0x00048088
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_NotificationProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_NotificationProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_NotificationProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x000076FB File Offset: 0x000058FB
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_NotificationProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x00007709 File Offset: 0x00005909
	public AN_NotificationProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043B RID: 1083
	// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00049EC4 File Offset: 0x000480C4
	// (set) Token: 0x06000E54 RID: 3668 RVA: 0x00007712 File Offset: 0x00005912
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_NotificationProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_NotificationProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B1D RID: 2845
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B1E RID: 2846
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B1F RID: 2847
	private static readonly IntPtr NativeMethodInfoPtr_ShowToastNotification_Public_Static_Void_String_Int32_0;

	// Token: 0x04000B20 RID: 2848
	private static readonly IntPtr NativeMethodInfoPtr_HideAllNotifications_Public_Static_Void_0;

	// Token: 0x04000B21 RID: 2849
	private static readonly IntPtr NativeMethodInfoPtr_requestCurrentAppLaunchNotificationId_Public_Static_Void_0;

	// Token: 0x04000B22 RID: 2850
	private static readonly IntPtr NativeMethodInfoPtr_ScheduleLocalNotification_Public_Static_Void_AndroidNotificationBuilder_0;

	// Token: 0x04000B23 RID: 2851
	private static readonly IntPtr NativeMethodInfoPtr_CanselLocalNotification_Public_Static_Void_Int32_0;

	// Token: 0x04000B24 RID: 2852
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
