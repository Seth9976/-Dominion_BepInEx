using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace SA.Foundation.Time
{
	// Token: 0x0200001D RID: 29
	public static class SA_Unix_Time : Object
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x000070EC File Offset: 0x000052EC
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Unix_Time()
		{
			Il2CppClassPointerStore<SA_Unix_Time>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Time", "SA_Unix_Time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Unix_Time>.NativeClassPtr);
			SA_Unix_Time.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Unix_Time>.NativeClassPtr, 100663443);
			SA_Unix_Time.NativeMethodInfoPtr_ToUnixTime_Public_Static_Int64_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Unix_Time>.NativeClassPtr, 100663444);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00007144 File Offset: 0x00005344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99501, XrefRangeEnd = 99503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DateTime ToDateTime(long timestamp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timestamp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Unix_Time.NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00007184 File Offset: 0x00005384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99503, XrefRangeEnd = 99510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ToUnixTime(DateTime date)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref date;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Unix_Time.NativeMethodInfoPtr_ToUnixTime_Public_Static_Int64_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000022DE File Offset: 0x000004DE
		public SA_Unix_Time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_ToDateTime_Public_Static_DateTime_Int64_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_ToUnixTime_Public_Static_Int64_DateTime_0;
	}
}
