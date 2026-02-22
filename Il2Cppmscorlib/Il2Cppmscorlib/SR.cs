using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000004 RID: 4
public static class SR : Object
{
	// Token: 0x0600000E RID: 14 RVA: 0x00022C70 File Offset: 0x00020E70
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SR>.NativeClassPtr);
		SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663303);
		SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663304);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00022CC8 File Offset: 0x00020EC8
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 258346, RefRangeEnd = 258347, XrefRangeStart = 258341, XrefRangeEnd = 258346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00022D18 File Offset: 0x00020F18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258347, XrefRangeEnd = 258352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002070 File Offset: 0x00000270
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;
}
