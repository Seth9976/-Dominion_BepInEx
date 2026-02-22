using System;
using System.Runtime.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000422 RID: 1058
	public sealed class TaskAwaiter<TResult> : ValueType, INotifyCompletion
	{
		// Token: 0x060041FD RID: 16893 RVA: 0x0013064C File Offset: 0x0012E84C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskAwaiter()
		{
			Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TaskAwaiter`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr);
			TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, "m_task");
			TaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100672898);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100672899);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100672900);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100672901);
			TaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr, 100672902);
		}

		// Token: 0x060041FE RID: 16894 RVA: 0x00130730 File Offset: 0x0012E930
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskAwaiter(Task<TResult> task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170010E9 RID: 4329
		// (get) Token: 0x060041FF RID: 16895 RVA: 0x00130780 File Offset: 0x0012E980
		public unsafe bool IsCompleted
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 356963, RefRangeEnd = 357021, XrefRangeStart = 356961, XrefRangeEnd = 356963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004200 RID: 16896 RVA: 0x001307C4 File Offset: 0x0012E9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004201 RID: 16897 RVA: 0x0013080C File Offset: 0x0012EA0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeOnCompleted(Action continuation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004202 RID: 16898 RVA: 0x00130854 File Offset: 0x0012EA54
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 357030, RefRangeEnd = 357066, XrefRangeStart = 357021, XrefRangeEnd = 357030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskAwaiter<TResult>.NativeMethodInfoPtr_GetResult_Public_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
		}

		// Token: 0x06004203 RID: 16899 RVA: 0x00019258 File Offset: 0x00017458
		public TaskAwaiter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004204 RID: 16900 RVA: 0x00019261 File Offset: 0x00017461
		public TaskAwaiter()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskAwaiter<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x170010E8 RID: 4328
		// (get) Token: 0x06004205 RID: 16901 RVA: 0x00130894 File Offset: 0x0012EA94
		// (set) Token: 0x06004206 RID: 16902 RVA: 0x00019273 File Offset: 0x00017473
		public unsafe Task<TResult> m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskAwaiter<TResult>.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06004207 RID: 16903 RVA: 0x00019292 File Offset: 0x00017492
		public void OnCompleted(Action continuation)
		{
			this.OnCompleted(continuation);
		}

		// Token: 0x040035C3 RID: 13763
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x040035C4 RID: 13764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_1_TResult_0;

		// Token: 0x040035C5 RID: 13765
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_get_Boolean_0;

		// Token: 0x040035C6 RID: 13766
		private static readonly IntPtr NativeMethodInfoPtr_OnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x040035C7 RID: 13767
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeOnCompleted_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x040035C8 RID: 13768
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_TResult_0;
	}
}
