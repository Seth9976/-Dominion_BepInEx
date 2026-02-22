using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000B7 RID: 183
public class AN_AppInvitesProxy : Object
{
	// Token: 0x06000D51 RID: 3409 RVA: 0x00045C4C File Offset: 0x00043E4C
	// Note: this type is marked as 'beforefieldinit'.
	static AN_AppInvitesProxy()
	{
		Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_AppInvitesProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr);
		AN_AppInvitesProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, "CLASS_NAME");
		AN_AppInvitesProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664914);
		AN_AppInvitesProxy.NativeMethodInfoPtr_CreateBuilder_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664915);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetMessage_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664916);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetDeepLink_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664917);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetCallToActionText_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664918);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Static_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664919);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664920);
		AN_AppInvitesProxy.NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Static_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664921);
		AN_AppInvitesProxy.NativeMethodInfoPtr_StartInvitationDialog_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664922);
		AN_AppInvitesProxy.NativeMethodInfoPtr_GetInvitation_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664923);
		AN_AppInvitesProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr, 100664924);
	}

	// Token: 0x06000D52 RID: 3410 RVA: 0x00045D6C File Offset: 0x00043F6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 177155, XrefRangeEnd = 177156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D53 RID: 3411 RVA: 0x00045DC4 File Offset: 0x00043FC4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177166, RefRangeEnd = 177167, XrefRangeStart = 177156, XrefRangeEnd = 177166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void CreateBuilder(int id, string title)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_CreateBuilder_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D54 RID: 3412 RVA: 0x00045E08 File Offset: 0x00044008
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177177, RefRangeEnd = 177178, XrefRangeStart = 177167, XrefRangeEnd = 177177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMessage(int id, string msg)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetMessage_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D55 RID: 3413 RVA: 0x00045E4C File Offset: 0x0004404C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177188, RefRangeEnd = 177189, XrefRangeStart = 177178, XrefRangeEnd = 177188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetDeepLink(int id, string url)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(url);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetDeepLink_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x00045E90 File Offset: 0x00044090
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177199, RefRangeEnd = 177200, XrefRangeStart = 177189, XrefRangeEnd = 177199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCallToActionText(int id, string actionText)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(actionText);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetCallToActionText_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x00045ED4 File Offset: 0x000440D4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177210, RefRangeEnd = 177211, XrefRangeStart = 177200, XrefRangeEnd = 177210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGoogleAnalyticsTrackingId(int id, string trackingId)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(trackingId);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Static_Void_Int32_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x00045F18 File Offset: 0x00044118
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177223, RefRangeEnd = 177224, XrefRangeStart = 177211, XrefRangeEnd = 177223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAndroidMinimumVersionCode(int id, int versionCode)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionCode;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Static_Void_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x00045F58 File Offset: 0x00044158
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177235, RefRangeEnd = 177236, XrefRangeStart = 177224, XrefRangeEnd = 177235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetAdditionalReferralParameters(int id, string keys, string values)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref id;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(keys);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(values);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Static_Void_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x00045FB0 File Offset: 0x000441B0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177245, RefRangeEnd = 177246, XrefRangeStart = 177236, XrefRangeEnd = 177245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartInvitationDialog(int builderId)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref builderId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_StartInvitationDialog_Public_Static_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x00045FE4 File Offset: 0x000441E4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 177255, RefRangeEnd = 177256, XrefRangeStart = 177246, XrefRangeEnd = 177255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetInvitation(bool autoLaunchDeepLink)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref autoLaunchDeepLink;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr_GetInvitation_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x00046018 File Offset: 0x00044218
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_AppInvitesProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_AppInvitesProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_AppInvitesProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x000074BD File Offset: 0x000056BD
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_AppInvitesProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x000074CB File Offset: 0x000056CB
	public AN_AppInvitesProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700042D RID: 1069
	// (get) Token: 0x06000D5F RID: 3423 RVA: 0x00046054 File Offset: 0x00044254
	// (set) Token: 0x06000D60 RID: 3424 RVA: 0x000074D4 File Offset: 0x000056D4
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_AppInvitesProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_AppInvitesProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000A5D RID: 2653
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000A5E RID: 2654
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000A5F RID: 2655
	private static readonly IntPtr NativeMethodInfoPtr_CreateBuilder_Public_Static_Void_Int32_String_0;

	// Token: 0x04000A60 RID: 2656
	private static readonly IntPtr NativeMethodInfoPtr_SetMessage_Public_Static_Void_Int32_String_0;

	// Token: 0x04000A61 RID: 2657
	private static readonly IntPtr NativeMethodInfoPtr_SetDeepLink_Public_Static_Void_Int32_String_0;

	// Token: 0x04000A62 RID: 2658
	private static readonly IntPtr NativeMethodInfoPtr_SetCallToActionText_Public_Static_Void_Int32_String_0;

	// Token: 0x04000A63 RID: 2659
	private static readonly IntPtr NativeMethodInfoPtr_SetGoogleAnalyticsTrackingId_Public_Static_Void_Int32_String_0;

	// Token: 0x04000A64 RID: 2660
	private static readonly IntPtr NativeMethodInfoPtr_SetAndroidMinimumVersionCode_Public_Static_Void_Int32_Int32_0;

	// Token: 0x04000A65 RID: 2661
	private static readonly IntPtr NativeMethodInfoPtr_SetAdditionalReferralParameters_Public_Static_Void_Int32_String_String_0;

	// Token: 0x04000A66 RID: 2662
	private static readonly IntPtr NativeMethodInfoPtr_StartInvitationDialog_Public_Static_Void_Int32_0;

	// Token: 0x04000A67 RID: 2663
	private static readonly IntPtr NativeMethodInfoPtr_GetInvitation_Public_Static_Void_Boolean_0;

	// Token: 0x04000A68 RID: 2664
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
