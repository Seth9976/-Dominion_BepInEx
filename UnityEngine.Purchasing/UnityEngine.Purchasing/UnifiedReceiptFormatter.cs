using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001E RID: 30
	public static class UnifiedReceiptFormatter : Object
	{
		// Token: 0x06000121 RID: 289 RVA: 0x000027E8 File Offset: 0x000009E8
		// Note: this type is marked as 'beforefieldinit'.
		static UnifiedReceiptFormatter()
		{
			Il2CppClassPointerStore<UnifiedReceiptFormatter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "UnifiedReceiptFormatter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnifiedReceiptFormatter>.NativeClassPtr);
			UnifiedReceiptFormatter.NativeMethodInfoPtr_FormatUnifiedReceipt_Internal_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnifiedReceiptFormatter>.NativeClassPtr, 100663445);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006F4C File Offset: 0x0000514C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 131310, RefRangeEnd = 131317, XrefRangeStart = 131304, XrefRangeEnd = 131310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatUnifiedReceipt(string platformReceipt, string transactionId, string storeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(platformReceipt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnifiedReceiptFormatter.NativeMethodInfoPtr_FormatUnifiedReceipt_Internal_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002821 File Offset: 0x00000A21
		public UnifiedReceiptFormatter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_FormatUnifiedReceipt_Internal_Static_String_String_String_String_0;
	}
}
