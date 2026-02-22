using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B4 RID: 692
	public class TaskScheduler : Object
	{
		// Token: 0x06002E9C RID: 11932 RVA: 0x000EBA20 File Offset: 0x000E9C20
		// Note: this type is marked as 'beforefieldinit'.
		static TaskScheduler()
		{
			Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskScheduler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr);
			TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_activeTaskSchedulers");
			TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_defaultTaskScheduler");
			TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "s_taskSchedulerIdCounter");
			TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "m_taskSchedulerId");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskException");
			TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "_unobservedTaskExceptionLockObject");
			TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670688);
			TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670689);
			TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670690);
			TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670691);
			TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670692);
			TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670693);
			TaskScheduler.NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670694);
			TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670695);
			TaskScheduler.NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670696);
			TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670697);
			TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670698);
			TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670699);
			TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670700);
			TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, 100670701);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x000EBBE0 File Offset: 0x000E9DE0
		[CallerCount(0)]
		public unsafe virtual void QueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x000EBC30 File Offset: 0x000E9E30
		[CallerCount(0)]
		public unsafe virtual bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x000EBC98 File Offset: 0x000E9E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337056, RefRangeEnd = 337059, XrefRangeStart = 337054, XrefRangeEnd = 337056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryRunInline(Task task, bool taskWasPreviouslyQueued)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x000EBCF4 File Offset: 0x000E9EF4
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryDequeue(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x000EBD4C File Offset: 0x000E9F4C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NotifyWorkItemProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002EA2 RID: 11938 RVA: 0x000EBD88 File Offset: 0x000E9F88
		public unsafe virtual bool RequiresAtomicStartTransition
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskScheduler.NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x000EBDD0 File Offset: 0x000E9FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337059, XrefRangeEnd = 337060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalQueueTask(Task task)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x000EBE14 File Offset: 0x000EA014
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337082, RefRangeEnd = 337083, XrefRangeStart = 337060, XrefRangeEnd = 337082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskScheduler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x000EBE50 File Offset: 0x000EA050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337083, XrefRangeEnd = 337101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToActiveTaskSchedulers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002EA6 RID: 11942 RVA: 0x000EBE84 File Offset: 0x000EA084
		public unsafe static TaskScheduler Default
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337101, XrefRangeEnd = 337105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002EA7 RID: 11943 RVA: 0x000EBEB8 File Offset: 0x000EA0B8
		public unsafe static TaskScheduler Current
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337116, RefRangeEnd = 337117, XrefRangeStart = 337105, XrefRangeEnd = 337116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002EA8 RID: 11944 RVA: 0x000EBEEC File Offset: 0x000EA0EC
		public unsafe static TaskScheduler InternalCurrent
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 337130, RefRangeEnd = 337134, XrefRangeStart = 337117, XrefRangeEnd = 337130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr3) : null;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002EA9 RID: 11945 RVA: 0x000EBF20 File Offset: 0x000EA120
		public unsafe int Id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337143, RefRangeEnd = 337144, XrefRangeStart = 337134, XrefRangeEnd = 337143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_get_Id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x000EBF5C File Offset: 0x000EA15C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337157, RefRangeEnd = 337158, XrefRangeStart = 337144, XrefRangeEnd = 337157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PublishUnobservedTaskException(Object sender, UnobservedTaskExceptionEventArgs ueea)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ueea);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskScheduler.NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x0001047C File Offset: 0x0000E67C
		public TaskScheduler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002EAC RID: 11948 RVA: 0x000EBFA4 File Offset: 0x000EA1A4
		// (set) Token: 0x06002EAD RID: 11949 RVA: 0x00010485 File Offset: 0x0000E685
		public unsafe static ConditionalWeakTable<TaskScheduler, Object> s_activeTaskSchedulers
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConditionalWeakTable<TaskScheduler, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_activeTaskSchedulers, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002EAE RID: 11950 RVA: 0x000EBFCC File Offset: 0x000EA1CC
		// (set) Token: 0x06002EAF RID: 11951 RVA: 0x00010497 File Offset: 0x0000E697
		public unsafe static TaskScheduler s_defaultTaskScheduler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_defaultTaskScheduler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x000EBFF4 File Offset: 0x000EA1F4
		// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x000104A9 File Offset: 0x0000E6A9
		public unsafe static int s_taskSchedulerIdCounter
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr_s_taskSchedulerIdCounter, (void*)(&value));
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x000EC010 File Offset: 0x000EA210
		// (set) Token: 0x06002EB3 RID: 11955 RVA: 0x000104B7 File Offset: 0x0000E6B7
		public unsafe int m_taskSchedulerId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskScheduler.NativeFieldInfoPtr_m_taskSchedulerId)) = value;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x000EC038 File Offset: 0x000EA238
		// (set) Token: 0x06002EB5 RID: 11957 RVA: 0x000104D2 File Offset: 0x0000E6D2
		public unsafe static EventHandler<UnobservedTaskExceptionEventArgs> _unobservedTaskException
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler<UnobservedTaskExceptionEventArgs>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskException, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002EB6 RID: 11958 RVA: 0x000EC060 File Offset: 0x000EA260
		// (set) Token: 0x06002EB7 RID: 11959 RVA: 0x000104E4 File Offset: 0x0000E6E4
		public unsafe static Object _unobservedTaskExceptionLockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskScheduler.NativeFieldInfoPtr__unobservedTaskExceptionLockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeFieldInfoPtr_s_activeTaskSchedulers;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultTaskScheduler;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeFieldInfoPtr_s_taskSchedulerIdCounter;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeFieldInfoPtr_m_taskSchedulerId;

		// Token: 0x04002864 RID: 10340
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskException;

		// Token: 0x04002865 RID: 10341
		private static readonly IntPtr NativeFieldInfoPtr__unobservedTaskExceptionLockObject;

		// Token: 0x04002866 RID: 10342
		private static readonly IntPtr NativeMethodInfoPtr_QueueTask_FamOrAssem_Abstract_Virtual_New_Void_Task_0;

		// Token: 0x04002867 RID: 10343
		private static readonly IntPtr NativeMethodInfoPtr_TryExecuteTaskInline_Protected_Abstract_Virtual_New_Boolean_Task_Boolean_0;

		// Token: 0x04002868 RID: 10344
		private static readonly IntPtr NativeMethodInfoPtr_TryRunInline_Internal_Boolean_Task_Boolean_0;

		// Token: 0x04002869 RID: 10345
		private static readonly IntPtr NativeMethodInfoPtr_TryDequeue_FamOrAssem_Virtual_New_Boolean_Task_0;

		// Token: 0x0400286A RID: 10346
		private static readonly IntPtr NativeMethodInfoPtr_NotifyWorkItemProgress_Internal_Virtual_New_Void_0;

		// Token: 0x0400286B RID: 10347
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAtomicStartTransition_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x0400286C RID: 10348
		private static readonly IntPtr NativeMethodInfoPtr_InternalQueueTask_Internal_Void_Task_0;

		// Token: 0x0400286D RID: 10349
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x0400286E RID: 10350
		private static readonly IntPtr NativeMethodInfoPtr_AddToActiveTaskSchedulers_Private_Void_0;

		// Token: 0x0400286F RID: 10351
		private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TaskScheduler_0;

		// Token: 0x04002870 RID: 10352
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_TaskScheduler_0;

		// Token: 0x04002871 RID: 10353
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalCurrent_Internal_Static_get_TaskScheduler_0;

		// Token: 0x04002872 RID: 10354
		private static readonly IntPtr NativeMethodInfoPtr_get_Id_Public_get_Int32_0;

		// Token: 0x04002873 RID: 10355
		private static readonly IntPtr NativeMethodInfoPtr_PublishUnobservedTaskException_Internal_Static_Void_Object_UnobservedTaskExceptionEventArgs_0;

		// Token: 0x02000618 RID: 1560
		public sealed class SystemThreadingTasks_TaskSchedulerDebugView : Object
		{
			// Token: 0x0600536A RID: 21354 RVA: 0x0001FF19 File Offset: 0x0001E119
			// Note: this type is marked as 'beforefieldinit'.
			static SystemThreadingTasks_TaskSchedulerDebugView()
			{
				Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskScheduler>.NativeClassPtr, "SystemThreadingTasks_TaskSchedulerDebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskScheduler.SystemThreadingTasks_TaskSchedulerDebugView>.NativeClassPtr);
			}

			// Token: 0x0600536B RID: 21355 RVA: 0x0001FF39 File Offset: 0x0001E139
			public SystemThreadingTasks_TaskSchedulerDebugView(IntPtr pointer)
				: base(pointer)
			{
			}
		}
	}
}
