using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000003 RID: 3
public sealed class Locale : Object
{
	// Token: 0x06000009 RID: 9 RVA: 0x00022B80 File Offset: 0x00020D80
	// Note: this type is marked as 'beforefieldinit'.
	static Locale()
	{
		Il2CppClassPointerStore<Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "", "Locale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Locale>.NativeClassPtr);
		Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663301);
		Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Locale>.NativeClassPtr, 100663302);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00022BD8 File Offset: 0x00020DD8
	[CallerCount(734)]
	[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00022C14 File Offset: 0x00020E14
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 258340, RefRangeEnd = 258341, XrefRangeStart = 258339, XrefRangeEnd = 258340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string fmt, [Optional] Il2CppReferenceArray<Object> args)
	{
		if (args == null)
		{
			args = new Il2CppReferenceArray<Object>(0L);
		}
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fmt);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002059 File Offset: 0x00000259
	public static string GetText(string fmt, params Object[] args)
	{
		return Locale.GetText(fmt, new Il2CppReferenceArray<Object>(args));
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002067 File Offset: 0x00000267
	public Locale(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_0;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;
}
