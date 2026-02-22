using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000064 RID: 100
	public static class QueryHelper : Object
	{
		// Token: 0x06000397 RID: 919 RVA: 0x00003CC6 File Offset: 0x00001EC6
		// Note: this type is marked as 'beforefieldinit'.
		static QueryHelper()
		{
			Il2CppClassPointerStore<QueryHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "QueryHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr);
			QueryHelper.NativeMethodInfoPtr_ToQueryString_Internal_Static_String_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QueryHelper>.NativeClassPtr, 100663747);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00011D08 File Offset: 0x0000FF08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154959, RefRangeEnd = 154960, XrefRangeStart = 154921, XrefRangeEnd = 154959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToQueryString(this Dictionary<string, Object> parameters)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QueryHelper.NativeMethodInfoPtr_ToQueryString_Internal_Static_String_Dictionary_2_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00003CFF File Offset: 0x00001EFF
		public QueryHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_ToQueryString_Internal_Static_String_Dictionary_2_String_Object_0;
	}
}
