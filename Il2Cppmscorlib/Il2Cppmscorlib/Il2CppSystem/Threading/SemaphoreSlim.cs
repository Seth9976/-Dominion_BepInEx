using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000260 RID: 608
	public class SemaphoreSlim : Object
	{
		// Token: 0x06002A39 RID: 10809 RVA: 0x000DA55C File Offset: 0x000D875C
		// Note: this type is marked as 'beforefieldinit'.
		static SemaphoreSlim()
		{
			Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SemaphoreSlim");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr);
			SemaphoreSlim.NativeFieldInfoPtr_m_currentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_currentCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_maxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_maxCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitCount");
			SemaphoreSlim.NativeFieldInfoPtr_m_lockObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_lockObj");
			SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_waitHandle");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncHead");
			SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "m_asyncTail");
			SemaphoreSlim.NativeFieldInfoPtr_s_trueTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_trueTask");
			SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "s_cancellationTokenCanceledEventHandler");
			SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670015);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670016);
			SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670017);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670018);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670019);
			SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670020);
			SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670021);
			SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670022);
			SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670023);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670024);
			SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670025);
			SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670026);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670027);
			SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670028);
			SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670029);
			SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670030);
			SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, 100670031);
		}

		// Token: 0x06002A3A RID: 10810 RVA: 0x000DA794 File Offset: 0x000D8994
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 330880, RefRangeEnd = 330887, XrefRangeStart = 330874, XrefRangeEnd = 330880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim(int initialCount, int maxCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref initialCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3B RID: 10811 RVA: 0x000DA7EC File Offset: 0x000D89EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330888, RefRangeEnd = 330890, XrefRangeStart = 330887, XrefRangeEnd = 330888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Wait()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A3C RID: 10812 RVA: 0x000DA820 File Offset: 0x000D8A20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330932, RefRangeEnd = 330933, XrefRangeStart = 330890, XrefRangeEnd = 330932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Wait(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x000DA880 File Offset: 0x000D8A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330933, XrefRangeEnd = 330938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitUntilCountOrTimeout(int millisecondsTimeout, uint startTime, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x000DA8F0 File Offset: 0x000D8AF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 330939, RefRangeEnd = 330944, XrefRangeStart = 330938, XrefRangeEnd = 330939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WaitAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x000DA930 File Offset: 0x000D8B30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 330981, RefRangeEnd = 330983, XrefRangeStart = 330944, XrefRangeEnd = 330981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitAsync(int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06002A40 RID: 10816 RVA: 0x000DA994 File Offset: 0x000D8B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330983, XrefRangeEnd = 330987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim.TaskNode CreateAndAddAsyncWaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr3) : null;
		}

		// Token: 0x06002A41 RID: 10817 RVA: 0x000DA9D4 File Offset: 0x000D8BD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 330988, RefRangeEnd = 330989, XrefRangeStart = 330987, XrefRangeEnd = 330988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool RemoveAsyncWaiter(SemaphoreSlim.TaskNode task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A42 RID: 10818 RVA: 0x000DAA24 File Offset: 0x000D8C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330989, XrefRangeEnd = 331001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> WaitUntilCountOrTimeoutAsync(SemaphoreSlim.TaskNode asyncWaiter, int millisecondsTimeout, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06002A43 RID: 10819 RVA: 0x000DAA9C File Offset: 0x000D8C9C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331002, RefRangeEnd = 331005, XrefRangeStart = 331001, XrefRangeEnd = 331002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002A44 RID: 10820 RVA: 0x000DAAD8 File Offset: 0x000D8CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331023, RefRangeEnd = 331024, XrefRangeStart = 331005, XrefRangeEnd = 331023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Release(int releaseCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref releaseCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Release_Public_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002A45 RID: 10821 RVA: 0x000DAB24 File Offset: 0x000D8D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331024, XrefRangeEnd = 331025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QueueWaiterTask(SemaphoreSlim.TaskNode waiterTask)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waiterTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A46 RID: 10822 RVA: 0x000DAB5C File Offset: 0x000D8D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331025, XrefRangeEnd = 331029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A47 RID: 10823 RVA: 0x000DAB90 File Offset: 0x000D8D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331029, XrefRangeEnd = 331032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SemaphoreSlim.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A48 RID: 10824 RVA: 0x000DABDC File Offset: 0x000D8DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331032, XrefRangeEnd = 331038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CancellationTokenCanceledEventHandler(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A49 RID: 10825 RVA: 0x000DAC14 File Offset: 0x000D8E14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 331038, RefRangeEnd = 331041, XrefRangeStart = 331038, XrefRangeEnd = 331038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_CheckDispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A4A RID: 10826 RVA: 0x000DAC48 File Offset: 0x000D8E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331041, XrefRangeEnd = 331042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002A4B RID: 10827 RVA: 0x0000EB9B File Offset: 0x0000CD9B
		public SemaphoreSlim(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000DAC84 File Offset: 0x000D8E84
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		public unsafe int m_currentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_currentCount)) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x000DACAC File Offset: 0x000D8EAC
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x0000EBBF File Offset: 0x0000CDBF
		public unsafe int m_maxCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_maxCount)) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x000DACD4 File Offset: 0x000D8ED4
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x0000EBDA File Offset: 0x0000CDDA
		public unsafe int m_waitCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitCount)) = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x000DACFC File Offset: 0x000D8EFC
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x0000EBF5 File Offset: 0x0000CDF5
		public unsafe Object m_lockObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_lockObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x000DAD2C File Offset: 0x000D8F2C
		// (set) Token: 0x06002A55 RID: 10837 RVA: 0x0000EC14 File Offset: 0x0000CE14
		public unsafe ManualResetEvent m_waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x000DAD5C File Offset: 0x000D8F5C
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x0000EC33 File Offset: 0x0000CE33
		public unsafe SemaphoreSlim.TaskNode m_asyncHead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncHead), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x000DAD8C File Offset: 0x000D8F8C
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x0000EC52 File Offset: 0x0000CE52
		public unsafe SemaphoreSlim.TaskNode m_asyncTail
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.NativeFieldInfoPtr_m_asyncTail), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x000DADBC File Offset: 0x000D8FBC
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0000EC71 File Offset: 0x0000CE71
		public unsafe static Task<bool> s_trueTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_trueTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x000DADE4 File Offset: 0x000D8FE4
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x0000EC83 File Offset: 0x0000CE83
		public unsafe static Action<Object> s_cancellationTokenCanceledEventHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SemaphoreSlim.NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400250C RID: 9484
		private static readonly IntPtr NativeFieldInfoPtr_m_currentCount;

		// Token: 0x0400250D RID: 9485
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCount;

		// Token: 0x0400250E RID: 9486
		private static readonly IntPtr NativeFieldInfoPtr_m_waitCount;

		// Token: 0x0400250F RID: 9487
		private static readonly IntPtr NativeFieldInfoPtr_m_lockObj;

		// Token: 0x04002510 RID: 9488
		private static readonly IntPtr NativeFieldInfoPtr_m_waitHandle;

		// Token: 0x04002511 RID: 9489
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncHead;

		// Token: 0x04002512 RID: 9490
		private static readonly IntPtr NativeFieldInfoPtr_m_asyncTail;

		// Token: 0x04002513 RID: 9491
		private static readonly IntPtr NativeFieldInfoPtr_s_trueTask;

		// Token: 0x04002514 RID: 9492
		private static readonly IntPtr NativeFieldInfoPtr_s_cancellationTokenCanceledEventHandler;

		// Token: 0x04002515 RID: 9493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04002516 RID: 9494
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Void_0;

		// Token: 0x04002517 RID: 9495
		private static readonly IntPtr NativeMethodInfoPtr_Wait_Public_Boolean_Int32_CancellationToken_0;

		// Token: 0x04002518 RID: 9496
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeout_Private_Boolean_Int32_UInt32_CancellationToken_0;

		// Token: 0x04002519 RID: 9497
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_0;

		// Token: 0x0400251A RID: 9498
		private static readonly IntPtr NativeMethodInfoPtr_WaitAsync_Public_Task_1_Boolean_Int32_CancellationToken_0;

		// Token: 0x0400251B RID: 9499
		private static readonly IntPtr NativeMethodInfoPtr_CreateAndAddAsyncWaiter_Private_TaskNode_0;

		// Token: 0x0400251C RID: 9500
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAsyncWaiter_Private_Boolean_TaskNode_0;

		// Token: 0x0400251D RID: 9501
		private static readonly IntPtr NativeMethodInfoPtr_WaitUntilCountOrTimeoutAsync_Private_Task_1_Boolean_TaskNode_Int32_CancellationToken_0;

		// Token: 0x0400251E RID: 9502
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_0;

		// Token: 0x0400251F RID: 9503
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Int32_Int32_0;

		// Token: 0x04002520 RID: 9504
		private static readonly IntPtr NativeMethodInfoPtr_QueueWaiterTask_Private_Static_Void_TaskNode_0;

		// Token: 0x04002521 RID: 9505
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002522 RID: 9506
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002523 RID: 9507
		private static readonly IntPtr NativeMethodInfoPtr_CancellationTokenCanceledEventHandler_Private_Static_Void_Object_0;

		// Token: 0x04002524 RID: 9508
		private static readonly IntPtr NativeMethodInfoPtr_CheckDispose_Private_Void_0;

		// Token: 0x04002525 RID: 9509
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x020005E7 RID: 1511
		public sealed class TaskNode : Task<bool>
		{
			// Token: 0x06005233 RID: 21043 RVA: 0x0016EE50 File Offset: 0x0016D050
			// Note: this type is marked as 'beforefieldinit'.
			static TaskNode()
			{
				Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "TaskNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr);
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Prev");
				SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, "Next");
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670033);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670034);
				SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr, 100670035);
			}

			// Token: 0x06005234 RID: 21044 RVA: 0x0016EEE0 File Offset: 0x0016D0E0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 330802, RefRangeEnd = 330804, XrefRangeStart = 330796, XrefRangeEnd = 330802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskNode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim.TaskNode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005235 RID: 21045 RVA: 0x0016EF1C File Offset: 0x0016D11C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330804, XrefRangeEnd = 330807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005236 RID: 21046 RVA: 0x0016EF50 File Offset: 0x0016D150
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public new unsafe void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim.TaskNode.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005237 RID: 21047 RVA: 0x0001F54B File Offset: 0x0001D74B
			public TaskNode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014FD RID: 5373
			// (get) Token: 0x06005238 RID: 21048 RVA: 0x0016EF94 File Offset: 0x0016D194
			// (set) Token: 0x06005239 RID: 21049 RVA: 0x0001F554 File Offset: 0x0001D754
			public unsafe SemaphoreSlim.TaskNode Prev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Prev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014FE RID: 5374
			// (get) Token: 0x0600523A RID: 21050 RVA: 0x0016EFC4 File Offset: 0x0016D1C4
			// (set) Token: 0x0600523B RID: 21051 RVA: 0x0001F573 File Offset: 0x0001D773
			public unsafe SemaphoreSlim.TaskNode Next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim.TaskNode.NativeFieldInfoPtr_Next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042AD RID: 17069
			private static readonly IntPtr NativeFieldInfoPtr_Prev;

			// Token: 0x040042AE RID: 17070
			private static readonly IntPtr NativeFieldInfoPtr_Next;

			// Token: 0x040042AF RID: 17071
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040042B0 RID: 17072
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042B1 RID: 17073
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;
		}

		// Token: 0x020005E8 RID: 1512
		[ObfuscatedName("System.Threading.SemaphoreSlim+<WaitUntilCountOrTimeoutAsync>d__31")]
		public sealed class _WaitUntilCountOrTimeoutAsync_d__31 : ValueType
		{
			// Token: 0x0600523C RID: 21052 RVA: 0x0016EFF4 File Offset: 0x0016D1F4
			// Note: this type is marked as 'beforefieldinit'.
			static _WaitUntilCountOrTimeoutAsync_d__31()
			{
				Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SemaphoreSlim>.NativeClassPtr, "<WaitUntilCountOrTimeoutAsync>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>1__state");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>t__builder");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "cancellationToken");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "asyncWaiter");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "millisecondsTimeout");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<cts>5__1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>4__this");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>7__wrap1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>u__1");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, "<>u__2");
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, 100670036);
				SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr, 100670037);
			}

			// Token: 0x0600523D RID: 21053 RVA: 0x0016F110 File Offset: 0x0016D310
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330807, XrefRangeEnd = 330871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600523E RID: 21054 RVA: 0x0016F148 File Offset: 0x0016D348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 330871, XrefRangeEnd = 330874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600523F RID: 21055 RVA: 0x0001F592 File Offset: 0x0001D792
			public _WaitUntilCountOrTimeoutAsync_d__31(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005240 RID: 21056 RVA: 0x0001F59B File Offset: 0x0001D79B
			public _WaitUntilCountOrTimeoutAsync_d__31()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31>.NativeClassPtr))
			{
			}

			// Token: 0x170014FF RID: 5375
			// (get) Token: 0x06005241 RID: 21057 RVA: 0x0016F190 File Offset: 0x0016D390
			// (set) Token: 0x06005242 RID: 21058 RVA: 0x0001F5AD File Offset: 0x0001D7AD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17001500 RID: 5376
			// (get) Token: 0x06005243 RID: 21059 RVA: 0x0016F1B8 File Offset: 0x0016D3B8
			// (set) Token: 0x06005244 RID: 21060 RVA: 0x0001F5C8 File Offset: 0x0001D7C8
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001501 RID: 5377
			// (get) Token: 0x06005245 RID: 21061 RVA: 0x0016F1E8 File Offset: 0x0016D3E8
			// (set) Token: 0x06005246 RID: 21062 RVA: 0x0001F5F6 File Offset: 0x0001D7F6
			public CancellationToken cancellationToken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken);
					return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001502 RID: 5378
			// (get) Token: 0x06005247 RID: 21063 RVA: 0x0016F218 File Offset: 0x0016D418
			// (set) Token: 0x06005248 RID: 21064 RVA: 0x0001F624 File Offset: 0x0001D824
			public unsafe SemaphoreSlim.TaskNode asyncWaiter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim.TaskNode>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_asyncWaiter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001503 RID: 5379
			// (get) Token: 0x06005249 RID: 21065 RVA: 0x0016F248 File Offset: 0x0016D448
			// (set) Token: 0x0600524A RID: 21066 RVA: 0x0001F643 File Offset: 0x0001D843
			public unsafe int millisecondsTimeout
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr_millisecondsTimeout)) = value;
				}
			}

			// Token: 0x17001504 RID: 5380
			// (get) Token: 0x0600524B RID: 21067 RVA: 0x0016F270 File Offset: 0x0016D470
			// (set) Token: 0x0600524C RID: 21068 RVA: 0x0001F65E File Offset: 0x0001D85E
			public unsafe CancellationTokenSource _cts_5__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CancellationTokenSource>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr__cts_5__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001505 RID: 5381
			// (get) Token: 0x0600524D RID: 21069 RVA: 0x0016F2A0 File Offset: 0x0016D4A0
			// (set) Token: 0x0600524E RID: 21070 RVA: 0x0001F67D File Offset: 0x0001D87D
			public unsafe SemaphoreSlim __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001506 RID: 5382
			// (get) Token: 0x0600524F RID: 21071 RVA: 0x0016F2D0 File Offset: 0x0016D4D0
			// (set) Token: 0x06005250 RID: 21072 RVA: 0x0001F69C File Offset: 0x0001D89C
			public unsafe Object __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___7__wrap1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001507 RID: 5383
			// (get) Token: 0x06005251 RID: 21073 RVA: 0x0016F300 File Offset: 0x0016D500
			// (set) Token: 0x06005252 RID: 21074 RVA: 0x0001F6BB File Offset: 0x0001D8BB
			public ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1);
					return new ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17001508 RID: 5384
			// (get) Token: 0x06005253 RID: 21075 RVA: 0x0016F330 File Offset: 0x0016D530
			// (set) Token: 0x06005254 RID: 21076 RVA: 0x0001F6E9 File Offset: 0x0001D8E9
			public ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2);
					return new ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemaphoreSlim._WaitUntilCountOrTimeoutAsync_d__31.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040042B2 RID: 17074
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040042B3 RID: 17075
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040042B4 RID: 17076
			private static readonly IntPtr NativeFieldInfoPtr_cancellationToken;

			// Token: 0x040042B5 RID: 17077
			private static readonly IntPtr NativeFieldInfoPtr_asyncWaiter;

			// Token: 0x040042B6 RID: 17078
			private static readonly IntPtr NativeFieldInfoPtr_millisecondsTimeout;

			// Token: 0x040042B7 RID: 17079
			private static readonly IntPtr NativeFieldInfoPtr__cts_5__1;

			// Token: 0x040042B8 RID: 17080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040042B9 RID: 17081
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x040042BA RID: 17082
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040042BB RID: 17083
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040042BC RID: 17084
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040042BD RID: 17085
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
