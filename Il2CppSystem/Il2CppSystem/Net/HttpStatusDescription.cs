using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000BA RID: 186
	public static class HttpStatusDescription : Object
	{
		// Token: 0x06000B57 RID: 2903 RVA: 0x0003B744 File Offset: 0x00039944
		// Note: this type is marked as 'beforefieldinit'.
		static HttpStatusDescription()
		{
			Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "HttpStatusDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100664921);
			HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HttpStatusDescription>.NativeClassPtr, 100664922);
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x0003B79C File Offset: 0x0003999C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 45757, XrefRangeEnd = 45768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(HttpStatusCode code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x0003B7D4 File Offset: 0x000399D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 45816, RefRangeEnd = 45819, XrefRangeStart = 45768, XrefRangeEnd = 45816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Get(int code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HttpStatusDescription.NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x000066EA File Offset: 0x000048EA
		public HttpStatusDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_HttpStatusCode_0;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_Get_Internal_Static_String_Int32_0;
	}
}
