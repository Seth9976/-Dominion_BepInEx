using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Net
{
	// Token: 0x020000CF RID: 207
	public static class ExceptionHelper : Object
	{
		// Token: 0x06000BFF RID: 3071 RVA: 0x0003D78C File Offset: 0x0003B98C
		// Note: this type is marked as 'beforefieldinit'.
		static ExceptionHelper()
		{
			Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "ExceptionHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr);
			ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100664986);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100664987);
			ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100664988);
			ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionHelper>.NativeClassPtr, 100664989);
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x0003D80C File Offset: 0x0003BA0C
		public unsafe static NotImplementedException MethodNotImplementedException
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 46283, RefRangeEnd = 46290, XrefRangeStart = 46276, XrefRangeEnd = 46283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000C01 RID: 3073 RVA: 0x0003D840 File Offset: 0x0003BA40
		public unsafe static NotImplementedException PropertyNotImplementedException
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 46297, RefRangeEnd = 46311, XrefRangeStart = 46290, XrefRangeEnd = 46297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotImplementedException>(intPtr3) : null;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003D874 File Offset: 0x0003BA74
		public unsafe static NotSupportedException PropertyNotSupportedException
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 46318, RefRangeEnd = 46319, XrefRangeStart = 46311, XrefRangeEnd = 46318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NotSupportedException>(intPtr3) : null;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0003D8A8 File Offset: 0x0003BAA8
		public unsafe static WebException RequestAbortedException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 46319, XrefRangeEnd = 46326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExceptionHelper.NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WebException>(intPtr3) : null;
			}
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00006BB3 File Offset: 0x00004DB3
		public ExceptionHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_get_MethodNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotImplementedException_Internal_Static_get_NotImplementedException_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyNotSupportedException_Internal_Static_get_NotSupportedException_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestAbortedException_Internal_Static_get_WebException_0;
	}
}
