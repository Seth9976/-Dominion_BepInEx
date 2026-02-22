using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000002 RID: 2
public sealed class Locale : Object
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	// Note: this type is marked as 'beforefieldinit'.
	static Locale()
	{
		Il2CppClassPointerStore<global::Locale>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "", "Locale");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<global::Locale>.NativeClassPtr);
		global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<global::Locale>.NativeClassPtr, 100663297);
	}

	// Token: 0x06000002 RID: 2 RVA: 0x00003944 File Offset: 0x00001B44
	[CallerCount(734)]
	[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 3778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static string GetText(string msg)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(global::Locale.NativeMethodInfoPtr_GetText_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x06000003 RID: 3 RVA: 0x00002089 File Offset: 0x00000289
	public Locale(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x04000001 RID: 1
	private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_Static_String_String_0;
}
