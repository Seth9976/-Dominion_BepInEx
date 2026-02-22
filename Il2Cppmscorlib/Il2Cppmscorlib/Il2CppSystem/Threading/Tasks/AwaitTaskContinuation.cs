using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B1 RID: 689
	public class AwaitTaskContinuation : TaskContinuation
	{
		// Token: 0x06002E55 RID: 11861 RVA: 0x000EA7A0 File Offset: 0x000E89A0
		// Note: this type is marked as 'beforefieldinit'.
		static AwaitTaskContinuation()
		{
			Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "AwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr);
			AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_capturedContext");
			AwaitTaskContinuation.NativeFieldInfoPtr_m_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "m_action");
			AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "s_invokeActionCallback");
			AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670645);
			AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670646);
			AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670647);
			AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670648);
			AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670649);
			AwaitTaskContinuation.NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670650);
			AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670651);
			AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670652);
			AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670653);
			AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670654);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670655);
			AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670656);
			AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670657);
			AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, 100670658);
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x000EA924 File Offset: 0x000E8B24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 336591, RefRangeEnd = 336596, XrefRangeStart = 336586, XrefRangeEnd = 336591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x000EA98C File Offset: 0x000E8B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336596, XrefRangeEnd = 336601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AwaitTaskContinuation(Action action, bool flowExecutionContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000EA9E8 File Offset: 0x000E8BE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336606, RefRangeEnd = 336607, XrefRangeStart = 336601, XrefRangeEnd = 336606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task CreateTask(Action<Object> action, Object state, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000EAA5C File Offset: 0x000E8C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336615, RefRangeEnd = 336616, XrefRangeStart = 336607, XrefRangeEnd = 336615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task task, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002E5A RID: 11866 RVA: 0x000EAAB8 File Offset: 0x000E8CB8
		public unsafe static bool IsValidLocationForInlining
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 336626, RefRangeEnd = 336628, XrefRangeStart = 336616, XrefRangeEnd = 336626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x000EAAE8 File Offset: 0x000E8CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336637, RefRangeEnd = 336638, XrefRangeStart = 336628, XrefRangeEnd = 336637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExecuteWorkItemHelper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x000EAB1C File Offset: 0x000E8D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336638, XrefRangeEnd = 336641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_ExecuteWorkItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000EAB50 File Offset: 0x000E8D50
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Threading_IThreadPoolWorkItem_MarkAborted(ThreadAbortException tae)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tae);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x000EAB94 File Offset: 0x000E8D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336641, XrefRangeEnd = 336646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeAction(Object state)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000EABCC File Offset: 0x000E8DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336646, XrefRangeEnd = 336655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextCallback GetInvokeActionCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr3) : null;
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x000EAC00 File Offset: 0x000E8E00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336665, RefRangeEnd = 336667, XrefRangeStart = 336655, XrefRangeEnd = 336665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunCallback(ContextCallback callback, Object state, ref Task currentTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x000EAC7C File Offset: 0x000E8E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336679, RefRangeEnd = 336681, XrefRangeStart = 336667, XrefRangeEnd = 336679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RunOrScheduleAction(Action action, bool allowInlining, ref Task currentTask)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInlining;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(currentTask);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			currentTask = ((intPtr4 == 0) ? null : new Task(intPtr4));
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x000EACE8 File Offset: 0x000E8EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336687, RefRangeEnd = 336688, XrefRangeStart = 336681, XrefRangeEnd = 336687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnsafeScheduleAction(Action action, Task task)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(task);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x000EAD30 File Offset: 0x000E8F30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 336706, RefRangeEnd = 336709, XrefRangeStart = 336688, XrefRangeEnd = 336706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsyncIfNecessary(Exception exc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x000102E8 File Offset: 0x0000E4E8
		public AwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000EAD68 File Offset: 0x000E8F68
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x000102F1 File Offset: 0x0000E4F1
		public unsafe ExecutionContext m_capturedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_capturedContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000EAD98 File Offset: 0x000E8F98
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x00010310 File Offset: 0x0000E510
		public unsafe Action m_action
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AwaitTaskContinuation.NativeFieldInfoPtr_m_action), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000EADC8 File Offset: 0x000E8FC8
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x0001032F File Offset: 0x0000E52F
		public unsafe static ContextCallback s_invokeActionCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.NativeFieldInfoPtr_s_invokeActionCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeFieldInfoPtr_m_capturedContext;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeFieldInfoPtr_m_action;

		// Token: 0x0400282F RID: 10287
		private static readonly IntPtr NativeFieldInfoPtr_s_invokeActionCallback;

		// Token: 0x04002830 RID: 10288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x04002831 RID: 10289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Boolean_0;

		// Token: 0x04002832 RID: 10290
		private static readonly IntPtr NativeMethodInfoPtr_CreateTask_Protected_Task_Action_1_Object_Object_TaskScheduler_0;

		// Token: 0x04002833 RID: 10291
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;

		// Token: 0x04002834 RID: 10292
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValidLocationForInlining_Internal_Static_get_Boolean_0;

		// Token: 0x04002835 RID: 10293
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteWorkItemHelper_Private_Void_0;

		// Token: 0x04002836 RID: 10294
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_ExecuteWorkItem_Private_Virtual_Final_New_Void_0;

		// Token: 0x04002837 RID: 10295
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IThreadPoolWorkItem_MarkAborted_Private_Virtual_Final_New_Void_ThreadAbortException_0;

		// Token: 0x04002838 RID: 10296
		private static readonly IntPtr NativeMethodInfoPtr_InvokeAction_Private_Static_Void_Object_0;

		// Token: 0x04002839 RID: 10297
		private static readonly IntPtr NativeMethodInfoPtr_GetInvokeActionCallback_Protected_Static_ContextCallback_0;

		// Token: 0x0400283A RID: 10298
		private static readonly IntPtr NativeMethodInfoPtr_RunCallback_Protected_Void_ContextCallback_Object_byref_Task_0;

		// Token: 0x0400283B RID: 10299
		private static readonly IntPtr NativeMethodInfoPtr_RunOrScheduleAction_Internal_Static_Void_Action_Boolean_byref_Task_0;

		// Token: 0x0400283C RID: 10300
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeScheduleAction_Internal_Static_Void_Action_Task_0;

		// Token: 0x0400283D RID: 10301
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsyncIfNecessary_Protected_Static_Void_Exception_0;

		// Token: 0x02000613 RID: 1555
		[ObfuscatedName("System.Threading.Tasks.AwaitTaskContinuation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005357 RID: 21335 RVA: 0x00172984 File Offset: 0x00170B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr);
				AwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, "<>9__17_0");
				AwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, 100670660);
				AwaitTaskContinuation.__c.NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr, 100670661);
			}

			// Token: 0x06005358 RID: 21336 RVA: 0x00172A00 File Offset: 0x00170C00
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005359 RID: 21337 RVA: 0x00172A3C File Offset: 0x00170C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336581, XrefRangeEnd = 336586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsyncIfNecessary_b__17_0(Object s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AwaitTaskContinuation.__c.NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600535A RID: 21338 RVA: 0x0001FEA9 File Offset: 0x0001E0A9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001547 RID: 5447
			// (get) Token: 0x0600535B RID: 21339 RVA: 0x00172A80 File Offset: 0x00170C80
			// (set) Token: 0x0600535C RID: 21340 RVA: 0x0001FEB2 File Offset: 0x0001E0B2
			public unsafe static AwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001548 RID: 5448
			// (get) Token: 0x0600535D RID: 21341 RVA: 0x00172AA8 File Offset: 0x00170CA8
			// (set) Token: 0x0600535E RID: 21342 RVA: 0x0001FEC4 File Offset: 0x0001E0C4
			public unsafe static WaitCallback __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AwaitTaskContinuation.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400435C RID: 17244
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400435D RID: 17245
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400435E RID: 17246
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400435F RID: 17247
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsyncIfNecessary_b__17_0_Internal_Void_Object_0;
		}
	}
}
