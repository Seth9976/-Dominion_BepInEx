using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AE RID: 686
	public class StandardTaskContinuation : TaskContinuation
	{
		// Token: 0x06002E39 RID: 11833 RVA: 0x000EA1E0 File Offset: 0x000E83E0
		// Note: this type is marked as 'beforefieldinit'.
		static StandardTaskContinuation()
		{
			Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "StandardTaskContinuation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr);
			StandardTaskContinuation.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_task");
			StandardTaskContinuation.NativeFieldInfoPtr_m_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_options");
			StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, "m_taskScheduler");
			StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100670630);
			StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr, 100670631);
		}

		// Token: 0x06002E3A RID: 11834 RVA: 0x000EA274 File Offset: 0x000E8474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336472, RefRangeEnd = 336473, XrefRangeStart = 336456, XrefRangeEnd = 336472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StandardTaskContinuation(Task task, TaskContinuationOptions options, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StandardTaskContinuation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StandardTaskContinuation.NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3B RID: 11835 RVA: 0x000EA2E0 File Offset: 0x000E84E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336473, XrefRangeEnd = 336478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Run(Task completedTask, bool bCanInlineContinuationTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bCanInlineContinuationTask;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StandardTaskContinuation.NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E3C RID: 11836 RVA: 0x00010212 File Offset: 0x0000E412
		public StandardTaskContinuation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000EA33C File Offset: 0x000E853C
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x0001021B File Offset: 0x0000E41B
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000EA36C File Offset: 0x000E856C
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x0001023A File Offset: 0x0000E43A
		public unsafe TaskContinuationOptions m_options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_options)) = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x000EA394 File Offset: 0x000E8594
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x00010255 File Offset: 0x0000E455
		public unsafe TaskScheduler m_taskScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StandardTaskContinuation.NativeFieldInfoPtr_m_taskScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400281E RID: 10270
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x0400281F RID: 10271
		private static readonly IntPtr NativeFieldInfoPtr_m_options;

		// Token: 0x04002820 RID: 10272
		private static readonly IntPtr NativeFieldInfoPtr_m_taskScheduler;

		// Token: 0x04002821 RID: 10273
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04002822 RID: 10274
		private static readonly IntPtr NativeMethodInfoPtr_Run_Internal_Virtual_Void_Task_Boolean_0;
	}
}
