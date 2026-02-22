using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000418 RID: 1048
	public sealed class AsyncMethodBuilderCore : ValueType
	{
		// Token: 0x060041BC RID: 16828 RVA: 0x0012F88C File Offset: 0x0012DA8C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncMethodBuilderCore()
		{
			Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncMethodBuilderCore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr);
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_stateMachine");
			AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "m_defaultContextAction");
			AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672857);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672858);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672859);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672860);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672861);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672862);
			AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, 100672863);
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x0012F970 File Offset: 0x0012DB70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 356701, RefRangeEnd = 356703, XrefRangeStart = 356701, XrefRangeEnd = 356701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x0012F9B8 File Offset: 0x0012DBB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356731, RefRangeEnd = 356734, XrefRangeStart = 356703, XrefRangeEnd = 356731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action GetCompletionAction(Task taskForTracing, ref AsyncMethodBuilderCore.MoveNextRunner runnerToInitialize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(taskForTracing);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(runnerToInitialize);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			runnerToInitialize = ((intPtr4 == 0) ? null : new AsyncMethodBuilderCore.MoveNextRunner(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Action>(intPtr5) : null;
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x0012FA38 File Offset: 0x0012DC38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 356752, RefRangeEnd = 356754, XrefRangeStart = 356734, XrefRangeEnd = 356752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action OutputAsyncCausalityEvents(Task innerTask, Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060041C0 RID: 16832 RVA: 0x0012FAA0 File Offset: 0x0012DCA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356764, RefRangeEnd = 356767, XrefRangeStart = 356754, XrefRangeEnd = 356764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostBoxInitialization(IAsyncStateMachine stateMachine, AsyncMethodBuilderCore.MoveNextRunner runner, Task builtTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runner);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builtTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C1 RID: 16833 RVA: 0x0012FB0C File Offset: 0x0012DD0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 356803, RefRangeEnd = 356809, XrefRangeStart = 356767, XrefRangeEnd = 356803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAsync(Exception exception, SynchronizationContext targetContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C2 RID: 16834 RVA: 0x0012FB54 File Offset: 0x0012DD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356809, XrefRangeEnd = 356818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action CreateContinuationWrapper(Action continuation, Action invokeAction, Task innerTask = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x060041C3 RID: 16835 RVA: 0x0012FBBC File Offset: 0x0012DDBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356820, RefRangeEnd = 356821, XrefRangeStart = 356818, XrefRangeEnd = 356820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task TryGetContinuationTask(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x060041C4 RID: 16836 RVA: 0x00019046 File Offset: 0x00017246
		public AsyncMethodBuilderCore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060041C5 RID: 16837 RVA: 0x0001904F File Offset: 0x0001724F
		public AsyncMethodBuilderCore()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr))
		{
		}

		// Token: 0x170010DF RID: 4319
		// (get) Token: 0x060041C6 RID: 16838 RVA: 0x0012FC00 File Offset: 0x0012DE00
		// (set) Token: 0x060041C7 RID: 16839 RVA: 0x00019061 File Offset: 0x00017261
		public unsafe IAsyncStateMachine m_stateMachine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010E0 RID: 4320
		// (get) Token: 0x060041C8 RID: 16840 RVA: 0x0012FC30 File Offset: 0x0012DE30
		// (set) Token: 0x060041C9 RID: 16841 RVA: 0x00019080 File Offset: 0x00017280
		public unsafe Action m_defaultContextAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.NativeFieldInfoPtr_m_defaultContextAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400359F RID: 13727
		private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

		// Token: 0x040035A0 RID: 13728
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContextAction;

		// Token: 0x040035A1 RID: 13729
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x040035A2 RID: 13730
		private static readonly IntPtr NativeMethodInfoPtr_GetCompletionAction_Internal_Action_Task_byref_MoveNextRunner_0;

		// Token: 0x040035A3 RID: 13731
		private static readonly IntPtr NativeMethodInfoPtr_OutputAsyncCausalityEvents_Private_Action_Task_Action_0;

		// Token: 0x040035A4 RID: 13732
		private static readonly IntPtr NativeMethodInfoPtr_PostBoxInitialization_Internal_Void_IAsyncStateMachine_MoveNextRunner_Task_0;

		// Token: 0x040035A5 RID: 13733
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAsync_Internal_Static_Void_Exception_SynchronizationContext_0;

		// Token: 0x040035A6 RID: 13734
		private static readonly IntPtr NativeMethodInfoPtr_CreateContinuationWrapper_Internal_Static_Action_Action_Action_Task_0;

		// Token: 0x040035A7 RID: 13735
		private static readonly IntPtr NativeMethodInfoPtr_TryGetContinuationTask_Internal_Static_Task_Action_0;

		// Token: 0x0200063A RID: 1594
		public sealed class MoveNextRunner : Object
		{
			// Token: 0x0600547C RID: 21628 RVA: 0x00175D78 File Offset: 0x00173F78
			// Note: this type is marked as 'beforefieldinit'.
			static MoveNextRunner()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "MoveNextRunner");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr);
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_context");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "m_stateMachine");
				AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, "s_invokeMoveNext");
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100672864);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100672865);
				AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr, 100672866);
			}

			// Token: 0x0600547D RID: 21629 RVA: 0x00175E1C File Offset: 0x0017401C
			[CallerCount(44)]
			[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoveNextRunner(ExecutionContext context, IAsyncStateMachine stateMachine)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.MoveNextRunner>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600547E RID: 21630 RVA: 0x00175E7C File Offset: 0x0017407C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356647, XrefRangeEnd = 356665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Run()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_Run_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600547F RID: 21631 RVA: 0x00175EB0 File Offset: 0x001740B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356665, XrefRangeEnd = 356675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeMoveNext(Object stateMachine)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.MoveNextRunner.NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005480 RID: 21632 RVA: 0x00020979 File Offset: 0x0001EB79
			public MoveNextRunner(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A4 RID: 5540
			// (get) Token: 0x06005481 RID: 21633 RVA: 0x00175EE8 File Offset: 0x001740E8
			// (set) Token: 0x06005482 RID: 21634 RVA: 0x00020982 File Offset: 0x0001EB82
			public unsafe ExecutionContext m_context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A5 RID: 5541
			// (get) Token: 0x06005483 RID: 21635 RVA: 0x00175F18 File Offset: 0x00174118
			// (set) Token: 0x06005484 RID: 21636 RVA: 0x000209A1 File Offset: 0x0001EBA1
			public unsafe IAsyncStateMachine m_stateMachine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncStateMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_m_stateMachine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A6 RID: 5542
			// (get) Token: 0x06005485 RID: 21637 RVA: 0x00175F48 File Offset: 0x00174148
			// (set) Token: 0x06005486 RID: 21638 RVA: 0x000209C0 File Offset: 0x0001EBC0
			public unsafe static ContextCallback s_invokeMoveNext
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.MoveNextRunner.NativeFieldInfoPtr_s_invokeMoveNext, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004403 RID: 17411
			private static readonly IntPtr NativeFieldInfoPtr_m_context;

			// Token: 0x04004404 RID: 17412
			private static readonly IntPtr NativeFieldInfoPtr_m_stateMachine;

			// Token: 0x04004405 RID: 17413
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeMoveNext;

			// Token: 0x04004406 RID: 17414
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ExecutionContext_IAsyncStateMachine_0;

			// Token: 0x04004407 RID: 17415
			private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Void_0;

			// Token: 0x04004408 RID: 17416
			private static readonly IntPtr NativeMethodInfoPtr_InvokeMoveNext_Private_Static_Void_Object_0;
		}

		// Token: 0x0200063B RID: 1595
		public class ContinuationWrapper : Object
		{
			// Token: 0x06005487 RID: 21639 RVA: 0x00175F70 File Offset: 0x00174170
			// Note: this type is marked as 'beforefieldinit'.
			static ContinuationWrapper()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "ContinuationWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_continuation");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_invokeAction");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, "m_innerTask");
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100672867);
				AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr, 100672868);
			}

			// Token: 0x06005488 RID: 21640 RVA: 0x00176000 File Offset: 0x00174200
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 356677, RefRangeEnd = 356679, XrefRangeStart = 356675, XrefRangeEnd = 356677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContinuationWrapper(Action continuation, Action invokeAction, Task innerTask)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.ContinuationWrapper>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(invokeAction);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005489 RID: 21641 RVA: 0x00176070 File Offset: 0x00174270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356679, XrefRangeEnd = 356681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.ContinuationWrapper.NativeMethodInfoPtr_Invoke_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600548A RID: 21642 RVA: 0x000209D2 File Offset: 0x0001EBD2
			public ContinuationWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015A7 RID: 5543
			// (get) Token: 0x0600548B RID: 21643 RVA: 0x001760A4 File Offset: 0x001742A4
			// (set) Token: 0x0600548C RID: 21644 RVA: 0x000209DB File Offset: 0x0001EBDB
			public unsafe Action m_continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A8 RID: 5544
			// (get) Token: 0x0600548D RID: 21645 RVA: 0x001760D4 File Offset: 0x001742D4
			// (set) Token: 0x0600548E RID: 21646 RVA: 0x000209FA File Offset: 0x0001EBFA
			public unsafe Action m_invokeAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_invokeAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015A9 RID: 5545
			// (get) Token: 0x0600548F RID: 21647 RVA: 0x00176104 File Offset: 0x00174304
			// (set) Token: 0x06005490 RID: 21648 RVA: 0x00020A19 File Offset: 0x0001EC19
			public unsafe Task m_innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.ContinuationWrapper.NativeFieldInfoPtr_m_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004409 RID: 17417
			private static readonly IntPtr NativeFieldInfoPtr_m_continuation;

			// Token: 0x0400440A RID: 17418
			private static readonly IntPtr NativeFieldInfoPtr_m_invokeAction;

			// Token: 0x0400440B RID: 17419
			private static readonly IntPtr NativeFieldInfoPtr_m_innerTask;

			// Token: 0x0400440C RID: 17420
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Action_Action_Task_0;

			// Token: 0x0400440D RID: 17421
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Internal_Void_0;
		}

		// Token: 0x0200063C RID: 1596
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06005491 RID: 21649 RVA: 0x00176134 File Offset: 0x00174334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr);
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, "innerTask");
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, "continuation");
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, 100672869);
				AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr, 100672870);
			}

			// Token: 0x06005492 RID: 21650 RVA: 0x001761B0 File Offset: 0x001743B0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005493 RID: 21651 RVA: 0x001761EC File Offset: 0x001743EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356681, XrefRangeEnd = 356691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OutputAsyncCausalityEvents_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005494 RID: 21652 RVA: 0x00020A38 File Offset: 0x0001EC38
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015AA RID: 5546
			// (get) Token: 0x06005495 RID: 21653 RVA: 0x00176220 File Offset: 0x00174420
			// (set) Token: 0x06005496 RID: 21654 RVA: 0x00020A41 File Offset: 0x0001EC41
			public unsafe Task innerTask
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_innerTask), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AB RID: 5547
			// (get) Token: 0x06005497 RID: 21655 RVA: 0x00176250 File Offset: 0x00174450
			// (set) Token: 0x06005498 RID: 21656 RVA: 0x00020A60 File Offset: 0x0001EC60
			public unsafe Action continuation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncMethodBuilderCore.__c__DisplayClass4_0.NativeFieldInfoPtr_continuation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400440E RID: 17422
			private static readonly IntPtr NativeFieldInfoPtr_innerTask;

			// Token: 0x0400440F RID: 17423
			private static readonly IntPtr NativeFieldInfoPtr_continuation;

			// Token: 0x04004410 RID: 17424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004411 RID: 17425
			private static readonly IntPtr NativeMethodInfoPtr__OutputAsyncCausalityEvents_b__0_Internal_Void_0;
		}

		// Token: 0x0200063D RID: 1597
		[ObfuscatedName("System.Runtime.CompilerServices.AsyncMethodBuilderCore+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005499 RID: 21657 RVA: 0x00176280 File Offset: 0x00174480
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr);
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__6_0");
				AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, "<>9__6_1");
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100672872);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100672873);
				AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr, 100672874);
			}

			// Token: 0x0600549A RID: 21658 RVA: 0x00176324 File Offset: 0x00174524
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncMethodBuilderCore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600549B RID: 21659 RVA: 0x00176360 File Offset: 0x00174560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356691, XrefRangeEnd = 356696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__6_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600549C RID: 21660 RVA: 0x001763A4 File Offset: 0x001745A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356696, XrefRangeEnd = 356701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ThrowAsync_b__6_1(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncMethodBuilderCore.__c.NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600549D RID: 21661 RVA: 0x00020A7F File Offset: 0x0001EC7F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170015AC RID: 5548
			// (get) Token: 0x0600549E RID: 21662 RVA: 0x001763E8 File Offset: 0x001745E8
			// (set) Token: 0x0600549F RID: 21663 RVA: 0x00020A88 File Offset: 0x0001EC88
			public unsafe static AsyncMethodBuilderCore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncMethodBuilderCore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AD RID: 5549
			// (get) Token: 0x060054A0 RID: 21664 RVA: 0x00176410 File Offset: 0x00174610
			// (set) Token: 0x060054A1 RID: 21665 RVA: 0x00020A9A File Offset: 0x0001EC9A
			public unsafe static SendOrPostCallback __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170015AE RID: 5550
			// (get) Token: 0x060054A2 RID: 21666 RVA: 0x00176438 File Offset: 0x00174638
			// (set) Token: 0x060054A3 RID: 21667 RVA: 0x00020AAC File Offset: 0x0001ECAC
			public unsafe static WaitCallback __9__6_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncMethodBuilderCore.__c.NativeFieldInfoPtr___9__6_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004412 RID: 17426
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004413 RID: 17427
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x04004414 RID: 17428
			private static readonly IntPtr NativeFieldInfoPtr___9__6_1;

			// Token: 0x04004415 RID: 17429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004416 RID: 17430
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__6_0_Internal_Void_Object_0;

			// Token: 0x04004417 RID: 17431
			private static readonly IntPtr NativeMethodInfoPtr__ThrowAsync_b__6_1_Internal_Void_Object_0;
		}
	}
}
