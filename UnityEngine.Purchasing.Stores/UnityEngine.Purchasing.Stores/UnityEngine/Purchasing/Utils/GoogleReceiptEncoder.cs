using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Utils
{
	// Token: 0x02000098 RID: 152
	public static class GoogleReceiptEncoder : Object
	{
		// Token: 0x060005C3 RID: 1475 RVA: 0x00018F04 File Offset: 0x00017104
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleReceiptEncoder()
		{
			Il2CppClassPointerStore<GoogleReceiptEncoder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Utils", "GoogleReceiptEncoder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleReceiptEncoder>.NativeClassPtr);
			GoogleReceiptEncoder.NativeMethodInfoPtr_EncodeReceipt_Internal_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleReceiptEncoder>.NativeClassPtr, 100664000);
			GoogleReceiptEncoder.NativeMethodInfoPtr_FormatPayload_Private_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleReceiptEncoder>.NativeClassPtr, 100664001);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00018F5C File Offset: 0x0001715C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157460, XrefRangeEnd = 157481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EncodeReceipt(string transactionId, string purchaseOriginalJson, string purchaseSignature, string skuDetailsJson)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseOriginalJson);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(purchaseSignature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(skuDetailsJson);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleReceiptEncoder.NativeMethodInfoPtr_EncodeReceipt_Internal_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00018FD0 File Offset: 0x000171D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157481, XrefRangeEnd = 157502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatPayload(string json, string signature, string skuDetails)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(skuDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleReceiptEncoder.NativeMethodInfoPtr_FormatPayload_Private_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00004E85 File Offset: 0x00003085
		public GoogleReceiptEncoder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_EncodeReceipt_Internal_Static_String_String_String_String_String_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_FormatPayload_Private_Static_String_String_String_String_0;
	}
}
