using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Cryptography
{
	// Token: 0x0200003B RID: 59
	public static class SA_HMAC : Object
	{
		// Token: 0x06000316 RID: 790 RVA: 0x00002B36 File Offset: 0x00000D36
		// Note: this type is marked as 'beforefieldinit'.
		static SA_HMAC()
		{
			Il2CppClassPointerStore<SA_HMAC>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Cryptography", "SA_HMAC");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_HMAC>.NativeClassPtr);
			SA_HMAC.NativeMethodInfoPtr_Hash_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_HMAC>.NativeClassPtr, 100663826);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00010FC4 File Offset: 0x0000F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 107505, XrefRangeEnd = 107524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Hash(string key, string data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_HMAC.NativeMethodInfoPtr_Hash_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x00002B6F File Offset: 0x00000D6F
		public SA_HMAC(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Static_String_String_String_0;
	}
}
