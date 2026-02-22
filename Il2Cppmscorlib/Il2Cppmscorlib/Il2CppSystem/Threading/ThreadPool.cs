using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000285 RID: 645
	public static class ThreadPool : Object
	{
		// Token: 0x06002BF8 RID: 11256 RVA: 0x000E0AEC File Offset: 0x000DECEC
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPool()
		{
			Il2CppClassPointerStore<ThreadPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ThreadPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670284);
			ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670285);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670286);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670287);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670288);
			ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670289);
			ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670290);
			ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670291);
			ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670292);
			ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670293);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670294);
			ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670295);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670296);
			ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670297);
			ThreadPool.NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670298);
			ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPool>.NativeClassPtr, 100670299);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000E0C5C File Offset: 0x000DEE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333310, XrefRangeEnd = 333324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, uint millisecondsTimeOutInterval, bool executeOnlyOnce, ref StackCrawlMark stackMark, bool compressStack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeOutInterval;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000E0D00 File Offset: 0x000DEF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333337, RefRangeEnd = 333338, XrefRangeStart = 333324, XrefRangeEnd = 333337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegisteredWaitHandle RegisterWaitForSingleObject(WaitHandle waitObject, WaitOrTimerCallback callBack, Object state, TimeSpan timeout, bool executeOnlyOnce)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref executeOnlyOnce;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegisteredWaitHandle>(intPtr3) : null;
		}

		// Token: 0x06002BFB RID: 11259 RVA: 0x000E0D84 File Offset: 0x000DEF84
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 333339, RefRangeEnd = 333348, XrefRangeStart = 333338, XrefRangeEnd = 333339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000E0DD8 File Offset: 0x000DEFD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333349, RefRangeEnd = 333350, XrefRangeStart = 333348, XrefRangeEnd = 333349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItem(WaitCallback callBack)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000E0E1C File Offset: 0x000DF01C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 333351, RefRangeEnd = 333355, XrefRangeStart = 333350, XrefRangeEnd = 333351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UnsafeQueueUserWorkItem(WaitCallback callBack, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000E0E70 File Offset: 0x000DF070
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333366, RefRangeEnd = 333369, XrefRangeStart = 333355, XrefRangeEnd = 333366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool QueueUserWorkItemHelper(WaitCallback callBack, Object state, ref StackCrawlMark stackMark, bool compressStack)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callBack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref compressStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000E0EE0 File Offset: 0x000DF0E0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 333376, RefRangeEnd = 333383, XrefRangeStart = 333369, XrefRangeEnd = 333376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeQueueCustomWorkItem(IThreadPoolWorkItem workItem, bool forceGlobal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceGlobal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000E0F24 File Offset: 0x000DF124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333395, RefRangeEnd = 333397, XrefRangeStart = 333383, XrefRangeEnd = 333395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryPopCustomWorkItem(IThreadPoolWorkItem workItem)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(workItem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C01 RID: 11265 RVA: 0x000E0F68 File Offset: 0x000DF168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333397, XrefRangeEnd = 333398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RequestWorkerThread()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000E0F98 File Offset: 0x000DF198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 333409, RefRangeEnd = 333411, XrefRangeStart = 333398, XrefRangeEnd = 333409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureVMInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C03 RID: 11267 RVA: 0x000E0FC0 File Offset: 0x000DF1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333411, XrefRangeEnd = 333412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NotifyWorkItemComplete()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000E0FF0 File Offset: 0x000DF1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ReportThreadStatus(bool isWorking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWorking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000E1024 File Offset: 0x000DF224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333412, XrefRangeEnd = 333422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgress()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C06 RID: 11270 RVA: 0x000E104C File Offset: 0x000DF24C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333422, XrefRangeEnd = 333423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyWorkItemProgressNative()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000E1074 File Offset: 0x000DF274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 262712, RefRangeEnd = 262714, XrefRangeStart = 262712, XrefRangeEnd = 262714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsThreadPoolHosted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000E10A4 File Offset: 0x000DF2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333423, XrefRangeEnd = 333424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeVMTp(ref bool enableWorkerTracking)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &enableWorkerTracking;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPool.NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x0000F555 File Offset: 0x0000D755
		public ThreadPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400263B RID: 9787
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Private_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_UInt32_Boolean_byref_StackCrawlMark_Boolean_0;

		// Token: 0x0400263C RID: 9788
		private static readonly IntPtr NativeMethodInfoPtr_RegisterWaitForSingleObject_Public_Static_RegisteredWaitHandle_WaitHandle_WaitOrTimerCallback_Object_TimeSpan_Boolean_0;

		// Token: 0x0400263D RID: 9789
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x0400263E RID: 9790
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItem_Public_Static_Boolean_WaitCallback_0;

		// Token: 0x0400263F RID: 9791
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueUserWorkItem_Public_Static_Boolean_WaitCallback_Object_0;

		// Token: 0x04002640 RID: 9792
		private static readonly IntPtr NativeMethodInfoPtr_QueueUserWorkItemHelper_Private_Static_Boolean_WaitCallback_Object_byref_StackCrawlMark_Boolean_0;

		// Token: 0x04002641 RID: 9793
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeQueueCustomWorkItem_Internal_Static_Void_IThreadPoolWorkItem_Boolean_0;

		// Token: 0x04002642 RID: 9794
		private static readonly IntPtr NativeMethodInfoPtr_TryPopCustomWorkItem_Internal_Static_Boolean_IThreadPoolWorkItem_0;

		// Token: 0x04002643 RID: 9795
		private static readonly IntPtr NativeMethodInfoPtr_RequestWorkerThread_Internal_Static_Boolean_0;

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeMethodInfoPtr_EnsureVMInitialized_Private_Static_Void_0;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemComplete_Internal_Static_Boolean_0;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeMethodInfoPtr_ReportThreadStatus_Internal_Static_Void_Boolean_0;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Static_Void_0;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgressNative_Internal_Static_Void_0;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeMethodInfoPtr_IsThreadPoolHosted_Internal_Static_Boolean_0;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVMTp_Private_Static_Void_byref_Boolean_0;
	}
}
