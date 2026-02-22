using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Globalization;

// Token: 0x02000002 RID: 2
public static class SR : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x000107D8 File Offset: 0x0000E9D8
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<global::SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::SR>.NativeClassPtr);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663297);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663298);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663299);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663300);
		global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663301);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x0001086C File Offset: 0x0000EA6C
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 31603, RefRangeEnd = 31610, XrefRangeStart = 31598, XrefRangeEnd = 31603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string name, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000003 RID: 3 RVA: 0x000108C8 File Offset: 0x0000EAC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(CultureInfo culture, string name, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00010938 File Offset: 0x0000EB38
	[CallerCount(734)]
	[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetString(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00010974 File Offset: 0x0000EB74
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 31615, RefRangeEnd = 31616, XrefRangeStart = 31610, XrefRangeEnd = 31615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, Object p1)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x000109C4 File Offset: 0x0000EBC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 31616, XrefRangeEnd = 31621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string Format(string resourceFormat, Object p1, Object p2)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
	public static string GetString(string name, params Object[] args)
	{
		return global::SR.GetString(name, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0000205E File Offset: 0x0000025E
	public static string GetString(CultureInfo culture, string name, params Object[] args)
	{
		return global::SR.GetString(culture, name, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x06000009 RID: 9 RVA: 0x0000206D File Offset: 0x0000026D
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000002 RID: 2
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_CultureInfo_String_Il2CppReferenceArray_1_Object_0;

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_0;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;
}
