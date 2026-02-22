using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B8 RID: 696
	public sealed class ThreadPoolTaskScheduler : TaskScheduler
	{
		// Token: 0x06002ECA RID: 11978 RVA: 0x000EC4AC File Offset: 0x000EA6AC
		// Note: this type is marked as 'beforefieldinit'.
		static ThreadPoolTaskScheduler()
		{
			Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "ThreadPoolTaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr);
			ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, "s_longRunningThreadWork");
			ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670718);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670719);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670720);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670721);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670722);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670723);
			ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr, 100670724);
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x000EC57C File Offset: 0x000EA77C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337249, XrefRangeEnd = 337254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThreadPoolTaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThreadPoolTaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x000EC5B8 File Offset: 0x000EA7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337254, XrefRangeEnd = 337258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LongRunningThreadWork(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000EC5F0 File Offset: 0x000EA7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337258, XrefRangeEnd = 337288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002ECE RID: 11982 RVA: 0x000EC634 File Offset: 0x000EA834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337288, XrefRangeEnd = 337289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taskWasPreviouslyQueued;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002ECF RID: 11983 RVA: 0x000EC690 File Offset: 0x000EA890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337289, XrefRangeEnd = 337290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ED0 RID: 11984 RVA: 0x000EC6E0 File Offset: 0x000EA8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002ED1 RID: 11985 RVA: 0x000EC714 File Offset: 0x000EA914
		public unsafe override bool RequiresAtomicStartTransition
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThreadPoolTaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x0001054B File Offset: 0x0000E74B
		public ThreadPoolTaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002ED3 RID: 11987 RVA: 0x000EC750 File Offset: 0x000EA950
		// (set) Token: 0x06002ED4 RID: 11988 RVA: 0x00010554 File Offset: 0x0000E754
		public unsafe static ParameterizedThreadStart s_longRunningThreadWork
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParameterizedThreadStart>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ThreadPoolTaskScheduler.NativeFieldInfoPtr_s_longRunningThreadWork, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400287E RID: 10366
		private static readonly IntPtr NativeFieldInfoPtr_s_longRunningThreadWork;

		// Token: 0x0400287F RID: 10367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002880 RID: 10368
		private static readonly IntPtr NativeMethodInfoPtr_LongRunningThreadWork_Private_Static_Void_Object_0;

		// Token: 0x04002881 RID: 10369
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Virtual_Void_Task_0;

		// Token: 0x04002882 RID: 10370
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Virtual_Boolean_Task_Boolean_0;

		// Token: 0x04002883 RID: 10371
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_Boolean_Task_0;

		// Token: 0x04002884 RID: 10372
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_Void_0;

		// Token: 0x04002885 RID: 10373
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_get_Boolean_0;
	}
}
