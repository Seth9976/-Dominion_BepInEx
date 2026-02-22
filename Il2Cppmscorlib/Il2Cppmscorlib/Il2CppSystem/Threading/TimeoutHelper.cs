using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000264 RID: 612
	public static class TimeoutHelper : Object
	{
		// Token: 0x06002A78 RID: 10872 RVA: 0x000DB34C File Offset: 0x000D954C
		// Note: this type is marked as 'beforefieldinit'.
		static TimeoutHelper()
		{
			Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "TimeoutHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr);
			TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100670053);
			TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeoutHelper>.NativeClassPtr, 100670054);
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000DB3A4 File Offset: 0x000D95A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331194, RefRangeEnd = 331197, XrefRangeStart = 331193, XrefRangeEnd = 331194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000DB3D4 File Offset: 0x000D95D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 331198, RefRangeEnd = 331205, XrefRangeStart = 331197, XrefRangeEnd = 331198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int UpdateTimeOut(uint startTime, int originalWaitMillisecondsTimeout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalWaitMillisecondsTimeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeoutHelper.NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		public TimeoutHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400253B RID: 9531
		private static readonly IntPtr NativeMethodInfoPtr_GetTime_Public_Static_UInt32_0;

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTimeOut_Public_Static_Int32_UInt32_Int32_0;
	}
}
