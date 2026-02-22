using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000D8 RID: 216
	public static class WebExceptionMapping : Object
	{
		// Token: 0x06000C5C RID: 3164 RVA: 0x0003EFD0 File Offset: 0x0003D1D0
		// Note: this type is marked as 'beforefieldinit'.
		static WebExceptionMapping()
		{
			Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "WebExceptionMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr);
			WebExceptionMapping.NativeFieldInfoPtr_s_Mapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, "s_Mapping");
			WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WebExceptionMapping>.NativeClassPtr, 100665036);
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x0003F028 File Offset: 0x0003D228
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 46540, RefRangeEnd = 46542, XrefRangeStart = 46522, XrefRangeEnd = 46540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetWebStatusString(WebExceptionStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WebExceptionMapping.NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00006D98 File Offset: 0x00004F98
		public WebExceptionMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003F060 File Offset: 0x0003D260
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x00006DA1 File Offset: 0x00004FA1
		public unsafe static Il2CppStringArray s_Mapping
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WebExceptionMapping.NativeFieldInfoPtr_s_Mapping, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009D2 RID: 2514
		private static readonly IntPtr NativeFieldInfoPtr_s_Mapping;

		// Token: 0x040009D3 RID: 2515
		private static readonly IntPtr NativeMethodInfoPtr_GetWebStatusString_Internal_Static_String_WebExceptionStatus_0;
	}
}
