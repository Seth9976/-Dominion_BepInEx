using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public static class SR : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this type is marked as 'beforefieldinit'.
	static SR()
	{
		Il2CppClassPointerStore<global::SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "", "SR");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::SR>.NativeClassPtr);
		global::SR.NativeMethodInfoPtr_GetString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::SR>.NativeClassPtr, 100663297);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00002E84 File Offset: 0x00001084
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

	// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
	public SR(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetString_Internal_Static_String_String_0;
}
