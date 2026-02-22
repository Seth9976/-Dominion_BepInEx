using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B0 RID: 688
	public sealed class TaskSchedulerAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x06002E4F RID: 11855 RVA: 0x000EA638 File Offset: 0x000E8838
		// Note: this type is marked as 'beforefieldinit'.
		static TaskSchedulerAwaitTaskContinuation()
		{
			Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskSchedulerAwaitTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr);
			TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "m_scheduler");
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100670640);
			TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, 100670641);
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x000EA6A4 File Offset: 0x000E88A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskSchedulerAwaitTaskContinuation(TaskScheduler scheduler, Action action, bool flowExecutionContext, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(action);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x000EA720 File Offset: 0x000E8920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336545, XrefRangeEnd = 336581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task ignored, bool canInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ignored);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000102C0 File Offset: 0x0000E4C0
		public TaskSchedulerAwaitTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x000EA770 File Offset: 0x000E8970
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x000102C9 File Offset: 0x0000E4C9
		public unsafe TaskScheduler m_scheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskSchedulerAwaitTaskContinuation.NativeFieldInfoPtr_m_scheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeFieldInfoPtr_m_scheduler;

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TaskScheduler_Action_Boolean_byref_StackCrawlMark_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Final_Void_Task_Boolean_0;

		// Token: 0x02000612 RID: 1554
		[ObfuscatedName("System.Threading.Tasks.TaskSchedulerAwaitTaskContinuation+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600534F RID: 21327 RVA: 0x00172838 File Offset: 0x00170A38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr);
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9");
				TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, "<>9__2_0");
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100670643);
				TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr, 100670644);
			}

			// Token: 0x06005350 RID: 21328 RVA: 0x001728B4 File Offset: 0x00170AB4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskSchedulerAwaitTaskContinuation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005351 RID: 21329 RVA: 0x001728F0 File Offset: 0x00170AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336540, XrefRangeEnd = 336545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Run_b__2_0(Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskSchedulerAwaitTaskContinuation.__c.NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005352 RID: 21330 RVA: 0x0001FE7C File Offset: 0x0001E07C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001545 RID: 5445
			// (get) Token: 0x06005353 RID: 21331 RVA: 0x00172934 File Offset: 0x00170B34
			// (set) Token: 0x06005354 RID: 21332 RVA: 0x0001FE85 File Offset: 0x0001E085
			public unsafe static TaskSchedulerAwaitTaskContinuation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskSchedulerAwaitTaskContinuation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001546 RID: 5446
			// (get) Token: 0x06005355 RID: 21333 RVA: 0x0017295C File Offset: 0x00170B5C
			// (set) Token: 0x06005356 RID: 21334 RVA: 0x0001FE97 File Offset: 0x0001E097
			public unsafe static Action<Object> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskSchedulerAwaitTaskContinuation.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004358 RID: 17240
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04004359 RID: 17241
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400435A RID: 17242
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400435B RID: 17243
			private static readonly IntPtr NativeMethodInfoPtr__Run_b__2_0_Internal_Void_Object_0;
		}
	}
}
