using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000085 RID: 133
	public static class GoogleBillingStrings : Object
	{
		// Token: 0x06000551 RID: 1361 RVA: 0x00004AC9 File Offset: 0x00002CC9
		// Note: this type is marked as 'beforefieldinit'.
		static GoogleBillingStrings()
		{
			Il2CppClassPointerStore<GoogleBillingStrings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GoogleBillingStrings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GoogleBillingStrings>.NativeClassPtr);
			GoogleBillingStrings.NativeMethodInfoPtr_getWarningMessageMoreThanOneSkuFound_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GoogleBillingStrings>.NativeClassPtr, 100663952);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x000176BC File Offset: 0x000158BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157173, XrefRangeEnd = 157178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string getWarningMessageMoreThanOneSkuFound(string sku)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sku);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GoogleBillingStrings.NativeMethodInfoPtr_getWarningMessageMoreThanOneSkuFound_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00004B02 File Offset: 0x00002D02
		public GoogleBillingStrings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_getWarningMessageMoreThanOneSkuFound_Internal_Static_String_String_0;
	}
}
