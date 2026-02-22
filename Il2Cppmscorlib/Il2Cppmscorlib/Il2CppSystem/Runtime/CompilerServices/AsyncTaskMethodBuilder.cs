using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000415 RID: 1045
	public sealed class AsyncTaskMethodBuilder : ValueType
	{
		// Token: 0x06004190 RID: 16784 RVA: 0x0012ED0C File Offset: 0x0012CF0C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncTaskMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncTaskMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr);
			AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, "s_cachedCompleted");
			AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, "m_builder");
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672834);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672835);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672836);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672837);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672838);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672839);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672840);
			AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr, 100672841);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x0012EE04 File Offset: 0x0012D004
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 147741, RefRangeEnd = 147759, XrefRangeStart = 147741, XrefRangeEnd = 147759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncTaskMethodBuilder Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncTaskMethodBuilder(intPtr);
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x0012EE30 File Offset: 0x0012D030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356161, XrefRangeEnd = 356172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x0012EE90 File Offset: 0x0012D090
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 356181, RefRangeEnd = 356198, XrefRangeStart = 356172, XrefRangeEnd = 356181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x0012EED8 File Offset: 0x0012D0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356198, XrefRangeEnd = 356210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x0012EF64 File Offset: 0x0012D164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356216, RefRangeEnd = 356217, XrefRangeStart = 356210, XrefRangeEnd = 356216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06004196 RID: 16790 RVA: 0x0012EFF0 File Offset: 0x0012D1F0
		public unsafe Task Task
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 356220, RefRangeEnd = 356238, XrefRangeStart = 356217, XrefRangeEnd = 356220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_get_Task_Public_get_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x0012F034 File Offset: 0x0012D234
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 356245, RefRangeEnd = 356262, XrefRangeStart = 356238, XrefRangeEnd = 356245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x0012F06C File Offset: 0x0012D26C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356262, XrefRangeEnd = 356265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncTaskMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00018F32 File Offset: 0x00017132
		public AsyncTaskMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00018F3B File Offset: 0x0001713B
		public AsyncTaskMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x0600419B RID: 16795 RVA: 0x0012F0B4 File Offset: 0x0012D2B4
		// (set) Token: 0x0600419C RID: 16796 RVA: 0x00018F4D File Offset: 0x0001714D
		public unsafe static Task<VoidTaskResult> s_cachedCompleted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<VoidTaskResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AsyncTaskMethodBuilder.NativeFieldInfoPtr_s_cachedCompleted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x0600419D RID: 16797 RVA: 0x0012F0DC File Offset: 0x0012D2DC
		// (set) Token: 0x0600419E RID: 16798 RVA: 0x00018F5F File Offset: 0x0001715F
		public AsyncTaskMethodBuilder<VoidTaskResult> m_builder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder);
				return new AsyncTaskMethodBuilder<VoidTaskResult>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<VoidTaskResult>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncTaskMethodBuilder.NativeFieldInfoPtr_m_builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<VoidTaskResult>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003583 RID: 13699
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedCompleted;

		// Token: 0x04003584 RID: 13700
		private static readonly IntPtr NativeFieldInfoPtr_m_builder;

		// Token: 0x04003585 RID: 13701
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncTaskMethodBuilder_0;

		// Token: 0x04003586 RID: 13702
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x04003587 RID: 13703
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x04003588 RID: 13704
		private static readonly IntPtr NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x04003589 RID: 13705
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x0400358A RID: 13706
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_0;

		// Token: 0x0400358B RID: 13707
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

		// Token: 0x0400358C RID: 13708
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x02000633 RID: 1587
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x040043FC RID: 17404
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000634 RID: 1588
		private sealed class MethodInfoStoreGeneric_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x040043FD RID: 17405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000635 RID: 1589
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x040043FE RID: 17406
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncTaskMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncTaskMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
