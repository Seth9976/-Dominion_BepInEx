using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x020000C2 RID: 194
public class AN_GooglePlayUtilsProxy : Object
{
	// Token: 0x06000E31 RID: 3633 RVA: 0x0004983C File Offset: 0x00047A3C
	// Note: this type is marked as 'beforefieldinit'.
	static AN_GooglePlayUtilsProxy()
	{
		Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "", "AN_GooglePlayUtilsProxy");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr);
		AN_GooglePlayUtilsProxy.NativeFieldInfoPtr_CLASS_NAME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr, "CLASS_NAME");
		AN_GooglePlayUtilsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr, 100665083);
		AN_GooglePlayUtilsProxy.NativeMethodInfoPtr_GetAdvertisingId_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr, 100665084);
		AN_GooglePlayUtilsProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr, 100665085);
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x000498BC File Offset: 0x00047ABC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 178390, XrefRangeEnd = 178391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GooglePlayUtilsProxy.NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x00049914 File Offset: 0x00047B14
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 178396, RefRangeEnd = 178398, XrefRangeStart = 178391, XrefRangeEnd = 178396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetAdvertisingId()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GooglePlayUtilsProxy.NativeMethodInfoPtr_GetAdvertisingId_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x0004993C File Offset: 0x00047B3C
	[CallerCount(817)]
	[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AN_GooglePlayUtilsProxy()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AN_GooglePlayUtilsProxy>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AN_GooglePlayUtilsProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00007680 File Offset: 0x00005880
	public static void CallActivityFunction(string methodName, params Object[] args)
	{
		AN_GooglePlayUtilsProxy.CallActivityFunction(methodName, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0000768E File Offset: 0x0000588E
	public AN_GooglePlayUtilsProxy(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000438 RID: 1080
	// (get) Token: 0x06000E37 RID: 3639 RVA: 0x00049978 File Offset: 0x00047B78
	// (set) Token: 0x06000E38 RID: 3640 RVA: 0x00007697 File Offset: 0x00005897
	public unsafe static string CLASS_NAME
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AN_GooglePlayUtilsProxy.NativeFieldInfoPtr_CLASS_NAME, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AN_GooglePlayUtilsProxy.NativeFieldInfoPtr_CLASS_NAME, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x04000B11 RID: 2833
	private static readonly IntPtr NativeFieldInfoPtr_CLASS_NAME;

	// Token: 0x04000B12 RID: 2834
	private static readonly IntPtr NativeMethodInfoPtr_CallActivityFunction_Private_Static_Void_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000B13 RID: 2835
	private static readonly IntPtr NativeMethodInfoPtr_GetAdvertisingId_Public_Static_Void_0;

	// Token: 0x04000B14 RID: 2836
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
