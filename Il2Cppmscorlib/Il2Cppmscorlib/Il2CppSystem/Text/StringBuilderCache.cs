using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text
{
	// Token: 0x02000171 RID: 369
	public static class StringBuilderCache : Object
	{
		// Token: 0x06001976 RID: 6518 RVA: 0x00094CE4 File Offset: 0x00092EE4
		// Note: this type is marked as 'beforefieldinit'.
		static StringBuilderCache()
		{
			Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Text", "StringBuilderCache");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr);
			StringBuilderCache.NativeFieldInfoPtr_CachedInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, "CachedInstance");
			StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667556);
			StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667557);
			StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringBuilderCache>.NativeClassPtr, 100667558);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00094D64 File Offset: 0x00092F64
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 313767, RefRangeEnd = 313786, XrefRangeStart = 313760, XrefRangeEnd = 313767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StringBuilder Acquire(int capacity = 16)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capacity;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00094DA4 File Offset: 0x00092FA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 313789, RefRangeEnd = 313790, XrefRangeStart = 313786, XrefRangeEnd = 313789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Release(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00094DDC File Offset: 0x00092FDC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 313793, RefRangeEnd = 313809, XrefRangeStart = 313790, XrefRangeEnd = 313793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringAndRelease(StringBuilder sb)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringBuilderCache.NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00008D1A File Offset: 0x00006F1A
		public StringBuilderCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00094E18 File Offset: 0x00093018
		// (set) Token: 0x0600197C RID: 6524 RVA: 0x00008D23 File Offset: 0x00006F23
		public unsafe static StringBuilder CachedInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringBuilderCache.NativeFieldInfoPtr_CachedInstance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringBuilderCache.NativeFieldInfoPtr_CachedInstance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400173C RID: 5948
		private static readonly IntPtr NativeFieldInfoPtr_CachedInstance;

		// Token: 0x0400173D RID: 5949
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Public_Static_StringBuilder_Int32_0;

		// Token: 0x0400173E RID: 5950
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Static_Void_StringBuilder_0;

		// Token: 0x0400173F RID: 5951
		private static readonly IntPtr NativeMethodInfoPtr_GetStringAndRelease_Public_Static_String_StringBuilder_0;
	}
}
