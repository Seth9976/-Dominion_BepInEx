using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002AA RID: 682
	public class TaskCompletionSource<TResult> : Object
	{
		// Token: 0x06002E1D RID: 11805 RVA: 0x000E9A20 File Offset: 0x000E7C20
		// Note: this type is marked as 'beforefieldinit'.
		static TaskCompletionSource()
		{
			Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskCompletionSource`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr);
			TaskCompletionSource<TResult>.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, "m_task");
			TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670616);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670617);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670618);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670619);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670620);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670621);
			TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr, 100670622);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000E9B2C File Offset: 0x000E7D2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 336363, RefRangeEnd = 336375, XrefRangeStart = 336360, XrefRangeEnd = 336363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskCompletionSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskCompletionSource<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x000E9B68 File Offset: 0x000E7D68
		public unsafe Task<TResult> Task
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x000E9BA8 File Offset: 0x000E7DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336375, XrefRangeEnd = 336378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SpinUntilCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x000E9BDC File Offset: 0x000E7DDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336379, RefRangeEnd = 336380, XrefRangeStart = 336378, XrefRangeEnd = 336379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x000E9C2C File Offset: 0x000E7E2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336381, RefRangeEnd = 336382, XrefRangeStart = 336380, XrefRangeEnd = 336381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetResult(TResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TResult).IsValueType)
				{
					TResult tresult = result;
					intPtr = ((tresult is string) ? IL2CPP.ManagedStringToIl2Cpp(tresult as string) : IL2CPP.Il2CppObjectBaseToPtr(tresult as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x000E9CB0 File Offset: 0x000E7EB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 336384, RefRangeEnd = 336392, XrefRangeStart = 336382, XrefRangeEnd = 336384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x000E9CEC File Offset: 0x000E7EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336392, XrefRangeEnd = 336393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskCompletionSource<TResult>.NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E25 RID: 11813 RVA: 0x00010191 File Offset: 0x0000E391
		public TaskCompletionSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000E9D40 File Offset: 0x000E7F40
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x0001019A File Offset: 0x0000E39A
		public unsafe Task<TResult> m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCompletionSource<TResult>.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskCompletionSource<TResult>.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400280D RID: 10253
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x0400280E RID: 10254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400280F RID: 10255
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0;

		// Token: 0x04002810 RID: 10256
		private static readonly IntPtr NativeMethodInfoPtr_SpinUntilCompleted_Private_Void_0;

		// Token: 0x04002811 RID: 10257
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Public_Boolean_Exception_0;

		// Token: 0x04002812 RID: 10258
		private static readonly IntPtr NativeMethodInfoPtr_TrySetResult_Public_Boolean_TResult_0;

		// Token: 0x04002813 RID: 10259
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_0;

		// Token: 0x04002814 RID: 10260
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Public_Boolean_CancellationToken_0;
	}
}
