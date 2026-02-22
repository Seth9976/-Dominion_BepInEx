using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000416 RID: 1046
	public sealed class AsyncTaskMethodBuilder<TResult> : ValueType
	{
		// Token: 0x0600419F RID: 16799 RVA: 0x0012F10C File Offset: 0x0012D30C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskMethodBuilder`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr);
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "s_defaultResultTask");
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "m_coreState");
			AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, "m_task");
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672843);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672844);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672845);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672846);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672847);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672848);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672849);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672850);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672851);
			AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_GetTaskForResult_Private_Task_1_TResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr, 100672852);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x0012F27C File Offset: 0x0012D47C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 356265, RefRangeEnd = 356291, XrefRangeStart = 356265, XrefRangeEnd = 356265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncTaskMethodBuilder<TResult> Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncTaskMethodBuilder<TResult>(intPtr);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x0012F2A8 File Offset: 0x0012D4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356300, RefRangeEnd = 356301, XrefRangeStart = 356291, XrefRangeEnd = 356300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start<TStateMachine>(ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TStateMachine>.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x0012F308 File Offset: 0x0012D508
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 356309, RefRangeEnd = 356333, XrefRangeStart = 356301, XrefRangeEnd = 356309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x0012F350 File Offset: 0x0012D550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356346, RefRangeEnd = 356347, XrefRangeStart = 356333, XrefRangeEnd = 356346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x0012F3DC File Offset: 0x0012D5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356363, RefRangeEnd = 356364, XrefRangeStart = 356347, XrefRangeEnd = 356363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(awaiter);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TAwaiter>.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x170010DB RID: 4315
		// (get) Token: 0x060041A5 RID: 16805 RVA: 0x0012F468 File Offset: 0x0012D668
		public unsafe Task<TResult> Task
		{
			[CallerCount(32)]
			[CachedScanResults(RefRangeStart = 356370, RefRangeEnd = 356402, XrefRangeStart = 356364, XrefRangeEnd = 356370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x0012F4AC File Offset: 0x0012D6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 356419, RefRangeEnd = 356421, XrefRangeStart = 356402, XrefRangeEnd = 356419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult(TResult result)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Public_Void_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060041A7 RID: 16807 RVA: 0x0012F52C File Offset: 0x0012D72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356421, XrefRangeEnd = 356423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult(Task<TResult> completedTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041A8 RID: 16808 RVA: 0x0012F574 File Offset: 0x0012D774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356423, XrefRangeEnd = 356435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060041A9 RID: 16809 RVA: 0x0012F5BC File Offset: 0x0012D7BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356633, RefRangeEnd = 356634, XrefRangeStart = 356435, XrefRangeEnd = 356633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> GetTaskForResult(TResult result)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder<TResult>.NativeMethodInfoPtr_GetTaskForResult_Private_Task_1_TResult_TResult_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
			}
		}

		// Token: 0x060041AA RID: 16810 RVA: 0x00018F8D File Offset: 0x0001718D
		public AsyncTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060041AB RID: 16811 RVA: 0x00018F96 File Offset: 0x00017196
		public AsyncTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncTaskMethodBuilder<TResult>>.NativeClassPtr))
		{
		}

		// Token: 0x170010D8 RID: 4312
		// (get) Token: 0x060041AC RID: 16812 RVA: 0x0012F648 File Offset: 0x0012D848
		// (set) Token: 0x060041AD RID: 16813 RVA: 0x00018FA8 File Offset: 0x000171A8
		public unsafe static Task<TResult> s_defaultResultTask
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_s_defaultResultTask, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D9 RID: 4313
		// (get) Token: 0x060041AE RID: 16814 RVA: 0x0012F670 File Offset: 0x0012D870
		// (set) Token: 0x060041AF RID: 16815 RVA: 0x00018FBA File Offset: 0x000171BA
		public AsyncMethodBuilderCore m_coreState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState);
				return new AsyncMethodBuilderCore(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_coreState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170010DA RID: 4314
		// (get) Token: 0x060041B0 RID: 16816 RVA: 0x0012F6A0 File Offset: 0x0012D8A0
		// (set) Token: 0x060041B1 RID: 16817 RVA: 0x00018FE8 File Offset: 0x000171E8
		public unsafe Task<TResult> m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder<TResult>.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400358D RID: 13709
		private static readonly IntPtr NativeFieldInfoPtr_s_defaultResultTask;

		// Token: 0x0400358E RID: 13710
		private static readonly IntPtr NativeFieldInfoPtr_m_coreState;

		// Token: 0x0400358F RID: 13711
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04003590 RID: 13712
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_1_TResult_0;

		// Token: 0x04003591 RID: 13713
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_TResult_0;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_TResult_0;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Internal_Void_Task_1_TResult_0;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04003599 RID: 13721
		private static readonly IntPtr NativeMethodInfoPtr_GetTaskForResult_Private_Task_1_TResult_TResult_0;

		// Token: 0x02000636 RID: 1590
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0
		{
			// Token: 0x040043FF RID: 17407
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TStateMachine>.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TStateMachine>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000637 RID: 1591
		private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004400 RID: 17408
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TAwaiter>.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TAwaiter>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000638 RID: 1592
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x04004401 RID: 17409
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder<TAwaiter>.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder<TAwaiter>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
