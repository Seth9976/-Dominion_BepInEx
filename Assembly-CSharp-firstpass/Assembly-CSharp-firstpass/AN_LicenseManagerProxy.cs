using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C4 RID: 196
public class AN_LicenseManagerProxy : Object
{
	// Token: 0x06000E41 RID: 3649 RVA: 0x00049AF4 File Offset: 0x00047CF4
	// Note: this type is marked as 'beforefieldinit'.
	static AN_LicenseManagerProxy()
	{
		Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_LicenseManagerProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr);
		AN_LicenseManagerProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr, "CLASS_NAME");
		AN_LicenseManagerProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr, 100665089);
		AN_LicenseManagerProxy.NativeMethodInfoPtr_StartLicenseRequest_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr, 100665090);
		AN_LicenseManagerProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr, 100665091);
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00049B74 File Offset: 0x00047D74
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178405, XrefRangeEnd = 178406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManagerProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00049BCC File Offset: 0x00047DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178406, XrefRangeEnd = 178412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StartLicenseRequest(string base64PublicKey)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(base64PublicKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManagerProxy.NativeMethodInfoPtr_StartLicenseRequest_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00049C04 File Offset: 0x00047E04
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_LicenseManagerProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_LicenseManagerProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_LicenseManagerProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E45 RID: 3653 RVA: 0x000076D2 File Offset: 0x000058D2
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_LicenseManagerProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x000076E0 File Offset: 0x000058E0
	public AN_LicenseManagerProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043A RID: 1082
	// (get) Token: 0x06000E47 RID: 3655 RVA: 0x00049C40 File Offset: 0x00047E40
	// (set) Token: 0x06000E48 RID: 3656 RVA: 0x000076E9 File Offset: 0x000058E9
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_LicenseManagerProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_LicenseManagerProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B19 RID: 2841
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B1A RID: 2842
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B1B RID: 2843
	private static readonly IntPtr NativeMethodInfoPtr_StartLicenseRequest_Public_Static_Void_String_0;

	// Token: 0x04000B1C RID: 2844
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
