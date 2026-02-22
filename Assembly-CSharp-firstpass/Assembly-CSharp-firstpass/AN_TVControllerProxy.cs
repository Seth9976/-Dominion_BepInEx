using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000CA RID: 202
public class AN_TVControllerProxy : Object
{
	// Token: 0x06000E8B RID: 3723 RVA: 0x0004AF44 File Offset: 0x00049144
	// Note: this type is marked as 'beforefieldinit'.
	static AN_TVControllerProxy()
	{
		Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_TVControllerProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr);
		AN_TVControllerProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr, "CLASS_NAME");
		AN_TVControllerProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr, 100665135);
		AN_TVControllerProxy.NativeMethodInfoPtr_AN_CheckForATVDevice_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr, 100665136);
		AN_TVControllerProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr, 100665137);
	}

	// Token: 0x06000E8C RID: 3724 RVA: 0x0004AFC4 File Offset: 0x000491C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178887, XrefRangeEnd = 178888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_TVControllerProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E8D RID: 3725 RVA: 0x0004B01C File Offset: 0x0004921C
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 178893, RefRangeEnd = 178894, XrefRangeStart = 178888, XrefRangeEnd = 178893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AN_CheckForATVDevice()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_TVControllerProxy.NativeMethodInfoPtr_AN_CheckForATVDevice_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E8E RID: 3726 RVA: 0x0004B044 File Offset: 0x00049244
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_TVControllerProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_TVControllerProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_TVControllerProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E8F RID: 3727 RVA: 0x000077B7 File Offset: 0x000059B7
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_TVControllerProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E90 RID: 3728 RVA: 0x000077C5 File Offset: 0x000059C5
	public AN_TVControllerProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700043F RID: 1087
	// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0004B080 File Offset: 0x00049280
	// (set) Token: 0x06000E92 RID: 3730 RVA: 0x000077CE File Offset: 0x000059CE
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_TVControllerProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_TVControllerProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B4C RID: 2892
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B4D RID: 2893
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B4E RID: 2894
	private static readonly IntPtr NativeMethodInfoPtr_AN_CheckForATVDevice_Public_Static_Void_0;

	// Token: 0x04000B4F RID: 2895
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
