using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000421 RID: 1057
	public sealed class TaskAwaiter : ValueType, INotifyCompletion
	{
		// Token: 0x060041EE RID: 16878 RVA: 0x001302BC File Offset: 0x0012E4BC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskAwaiter()
		{
			Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TaskAwaiter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr);
			TaskAwaiter.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, "m_task");
			TaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672889);
			TaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672890);
			TaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672891);
			TaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672892);
			TaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672893);
			TaskAwaiter.NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672894);
			TaskAwaiter.NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672895);
			TaskAwaiter.NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672896);
			TaskAwaiter.NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr, 100672897);
		}

		// Token: 0x060041EF RID: 16879 RVA: 0x001303B4 File Offset: 0x0012E5B4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010E7 RID: 4327
		// (get) Token: 0x060041F0 RID: 16880 RVA: 0x00130404 File Offset: 0x0012E604
		public unsafe bool IsCompleted
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 356860, RefRangeEnd = 356864, XrefRangeStart = 356856, XrefRangeEnd = 356860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060041F1 RID: 16881 RVA: 0x00130448 File Offset: 0x0012E648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356864, XrefRangeEnd = 356865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F2 RID: 16882 RVA: 0x00130490 File Offset: 0x0012E690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356865, XrefRangeEnd = 356866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F3 RID: 16883 RVA: 0x001304D8 File Offset: 0x0012E6D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 356876, RefRangeEnd = 356881, XrefRangeStart = 356866, XrefRangeEnd = 356876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_GetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F4 RID: 16884 RVA: 0x00130510 File Offset: 0x0012E710
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 356891, RefRangeEnd = 356901, XrefRangeStart = 356881, XrefRangeEnd = 356891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateEnd(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00130548 File Offset: 0x0012E748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356901, XrefRangeEnd = 356910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleNonSuccessAndDebuggerNotification(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x00130580 File Offset: 0x0012E780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356949, RefRangeEnd = 356952, XrefRangeStart = 356910, XrefRangeEnd = 356949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowForNonSuccess(Task task)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x001305B8 File Offset: 0x0012E7B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 356953, RefRangeEnd = 356961, XrefRangeStart = 356952, XrefRangeEnd = 356953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnCompletedInternal(Task task, Action continuation, bool continueOnCapturedContext, bool flowExecutionContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(continuation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continueOnCapturedContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flowExecutionContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter.NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x00019210 File Offset: 0x00017410
		public TaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00019219 File Offset: 0x00017419
		public TaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter>.NativeClassPtr))
		{
		}

		// Token: 0x170010E6 RID: 4326
		// (get) Token: 0x060041FA RID: 16890 RVA: 0x0013061C File Offset: 0x0012E81C
		// (set) Token: 0x060041FB RID: 16891 RVA: 0x0001922B File Offset: 0x0001742B
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060041FC RID: 16892 RVA: 0x0001924A File Offset: 0x0001744A
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x040035B9 RID: 13753
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x040035BA RID: 13754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x040035BB RID: 13755
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x040035BC RID: 13756
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x040035BD RID: 13757
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x040035BE RID: 13758
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_Void_0;

		// Token: 0x040035BF RID: 13759
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEnd_Internal_Static_Void_Task_0;

		// Token: 0x040035C0 RID: 13760
		private static readonly IntPtr NativeMethodInfoPtr_HandleNonSuccessAndDebuggerNotification_Private_Static_Void_Task_0;

		// Token: 0x040035C1 RID: 13761
		private static readonly IntPtr NativeMethodInfoPtr_ThrowForNonSuccess_Private_Static_Void_Task_0;

		// Token: 0x040035C2 RID: 13762
		private static readonly IntPtr NativeMethodInfoPtr_OnCompletedInternal_Internal_Static_Void_Task_Action_Boolean_Boolean_0;
	}
}
