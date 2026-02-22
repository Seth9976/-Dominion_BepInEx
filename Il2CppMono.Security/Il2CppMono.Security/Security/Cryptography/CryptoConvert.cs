using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000029 RID: 41
	public sealed class CryptoConvert : Object
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00002E6E File Offset: 0x0000106E
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConvert()
		{
			Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "CryptoConvert");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr);
			CryptoConvert.NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConvert>.NativeClassPtr, 100663574);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B51C File Offset: 0x0000971C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 10276, RefRangeEnd = 10278, XrefRangeStart = 10263, XrefRangeEnd = 10276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHex(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConvert.NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002EA7 File Offset: 0x000010A7
		public CryptoConvert(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_ToHex_Public_Static_String_Il2CppStructArray_1_Byte_0;
	}
}
