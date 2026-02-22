using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029C RID: 668
	public class TaskFactory<TResult> : Object
	{
		// Token: 0x06002D27 RID: 11559 RVA: 0x000E52EC File Offset: 0x000E34EC
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr);
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670425);
			TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670426);
			TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670427);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670428);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670429);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670430);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670431);
			TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, 100670432);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x000E5448 File Offset: 0x000E3648
		[CallerCount(0)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x000E5484 File Offset: 0x000E3684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334263, XrefRangeEnd = 334266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x000E5504 File Offset: 0x000E3704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334266, XrefRangeEnd = 334274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew(Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x000E558C File Offset: 0x000E378C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334274, XrefRangeEnd = 334316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromAsyncCoreLogic(IAsyncResult iar, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Task<TResult> promise, bool requiresSynchronization)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(promise);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x000E5608 File Offset: 0x000E3808
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 334316, RefRangeEnd = 334319, XrefRangeStart = 334316, XrefRangeEnd = 334316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> FromAsync(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endMethod, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x000E567C File Offset: 0x000E387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334319, XrefRangeEnd = 334359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl(Func<AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x000E5704 File Offset: 0x000E3904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334359, XrefRangeEnd = 334391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncImpl<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Func<IAsyncResult, TResult> endFunction, Action<IAsyncResult> endAction, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endFunction);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endAction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg1).IsValueType)
			{
				TArg1 targ = arg1;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref arg1;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TArg1>.MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr4) : null;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000E57D8 File Offset: 0x000E39D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334401, RefRangeEnd = 334402, XrefRangeStart = 334391, XrefRangeEnd = 334401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> FromAsyncTrim<TInstance, TArgs>(TInstance thisRef, TArgs args, Func<TInstance, TArgs, AsyncCallback, Object, IAsyncResult> beginMethod, Func<TInstance, IAsyncResult, TResult> endMethod) where TInstance : class
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TInstance).IsValueType)
				{
					TInstance tinstance = thisRef;
					intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref thisRef;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(TArgs).IsValueType)
			{
				TArgs targs = args;
				intPtr2 = ((targs is string) ? IL2CPP.ManagedStringToIl2Cpp(targs as string) : IL2CPP.Il2CppObjectBaseToPtr(targs as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref args;
			}
			ptr3 = intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TInstance>.MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr5) : null;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0000FD93 File Offset: 0x0000DF93
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002D31 RID: 11569 RVA: 0x000E58C0 File Offset: 0x000E3AC0
		// (set) Token: 0x06002D32 RID: 11570 RVA: 0x0000FD9C File Offset: 0x0000DF9C
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002D33 RID: 11571 RVA: 0x000E58F0 File Offset: 0x000E3AF0
		// (set) Token: 0x06002D34 RID: 11572 RVA: 0x0000FDCA File Offset: 0x0000DFCA
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06002D35 RID: 11573 RVA: 0x000E5920 File Offset: 0x000E3B20
		// (set) Token: 0x06002D36 RID: 11574 RVA: 0x0000FDE9 File Offset: 0x0000DFE9
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000E5948 File Offset: 0x000E3B48
		// (set) Token: 0x06002D38 RID: 11576 RVA: 0x0000FE04 File Offset: 0x0000E004
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_1_TResult_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncCoreLogic_Private_Static_Void_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Task_1_TResult_Boolean_0;

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Object_0;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_3_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_Object_TaskCreationOptions_0;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0;

		// Token: 0x020005FD RID: 1533
		public sealed class FromAsyncTrimPromise<TInstance> : Task<TResult> where TInstance : class
		{
			// Token: 0x060052CA RID: 21194 RVA: 0x00170D64 File Offset: 0x0016EF64
			// Note: this type is marked as 'beforefieldinit'.
			static FromAsyncTrimPromise()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "FromAsyncTrimPromise`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "s_completeFromAsyncResult");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_thisRef");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, "m_endMethod");
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670433);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670434);
				TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr, 100670435);
			}

			// Token: 0x060052CB RID: 21195 RVA: 0x00170E54 File Offset: 0x0016F054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334245, XrefRangeEnd = 334249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FromAsyncTrimPromise(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref thisRef;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060052CC RID: 21196 RVA: 0x00170EE8 File Offset: 0x0016F0E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334249, XrefRangeEnd = 334260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CompleteFromAsyncResult(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052CD RID: 21197 RVA: 0x00170F20 File Offset: 0x0016F120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334260, XrefRangeEnd = 334262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Complete(TInstance thisRef, Func<TInstance, IAsyncResult, TResult> endMethod, IAsyncResult asyncResult, bool requiresSynchronization)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TInstance).IsValueType)
					{
						TInstance tinstance = thisRef;
						intPtr = ((tinstance is string) ? IL2CPP.ManagedStringToIl2Cpp(tinstance as string) : IL2CPP.Il2CppObjectBaseToPtr(tinstance as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref thisRef;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref requiresSynchronization;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060052CE RID: 21198 RVA: 0x0001FA34 File Offset: 0x0001DC34
			public FromAsyncTrimPromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001522 RID: 5410
			// (get) Token: 0x060052CF RID: 21199 RVA: 0x00170FCC File Offset: 0x0016F1CC
			// (set) Token: 0x060052D0 RID: 21200 RVA: 0x0001FA3D File Offset: 0x0001DC3D
			public unsafe static AsyncCallback s_completeFromAsyncResult
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_s_completeFromAsyncResult, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001523 RID: 5411
			// (get) Token: 0x060052D1 RID: 21201 RVA: 0x00170FF4 File Offset: 0x0016F1F4
			// (set) Token: 0x060052D2 RID: 21202 RVA: 0x0017101C File Offset: 0x0016F21C
			public unsafe TInstance m_thisRef
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					return IL2CPP.PointerToValueGeneric<TInstance>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_thisRef);
					Type typeFromHandle = typeof(TInstance);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17001524 RID: 5412
			// (get) Token: 0x060052D3 RID: 21203 RVA: 0x001710C4 File Offset: 0x0016F2C4
			// (set) Token: 0x060052D4 RID: 21204 RVA: 0x0001FA4F File Offset: 0x0001DC4F
			public unsafe Func<TInstance, IAsyncResult, TResult> m_endMethod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TInstance, IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.FromAsyncTrimPromise<TInstance>.NativeFieldInfoPtr_m_endMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400430E RID: 17166
			private static readonly IntPtr NativeFieldInfoPtr_s_completeFromAsyncResult;

			// Token: 0x0400430F RID: 17167
			private static readonly IntPtr NativeFieldInfoPtr_m_thisRef;

			// Token: 0x04004310 RID: 17168
			private static readonly IntPtr NativeFieldInfoPtr_m_endMethod;

			// Token: 0x04004311 RID: 17169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_0;

			// Token: 0x04004312 RID: 17170
			private static readonly IntPtr NativeMethodInfoPtr_CompleteFromAsyncResult_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x04004313 RID: 17171
			private static readonly IntPtr NativeMethodInfoPtr_Complete_Internal_Void_TInstance_Func_3_TInstance_IAsyncResult_TResult_IAsyncResult_Boolean_0;
		}

		// Token: 0x020005FE RID: 1534
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Object
		{
			// Token: 0x060052D5 RID: 21205 RVA: 0x001710F4 File Offset: 0x0016F2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100670437);
				TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr, 100670438);
			}

			// Token: 0x060052D6 RID: 21206 RVA: 0x001711C0 File Offset: 0x0016F3C0
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052D7 RID: 21207 RVA: 0x001711FC File Offset: 0x0016F3FC
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_0.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052D8 RID: 21208 RVA: 0x0001FA6E File Offset: 0x0001DC6E
			public __c__DisplayClass35_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001525 RID: 5413
			// (get) Token: 0x060052D9 RID: 21209 RVA: 0x00171240 File Offset: 0x0016F440
			// (set) Token: 0x060052DA RID: 21210 RVA: 0x0001FA77 File Offset: 0x0001DC77
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001526 RID: 5414
			// (get) Token: 0x060052DB RID: 21211 RVA: 0x00171270 File Offset: 0x0016F470
			// (set) Token: 0x060052DC RID: 21212 RVA: 0x0001FA96 File Offset: 0x0001DC96
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001527 RID: 5415
			// (get) Token: 0x060052DD RID: 21213 RVA: 0x001712A0 File Offset: 0x0016F4A0
			// (set) Token: 0x060052DE RID: 21214 RVA: 0x0001FAB5 File Offset: 0x0001DCB5
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_0.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004314 RID: 17172
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x04004315 RID: 17173
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x04004316 RID: 17174
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x04004317 RID: 17175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004318 RID: 17176
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x020005FF RID: 1535
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass35_1")]
		public sealed class __c__DisplayClass35_1 : Object
		{
			// Token: 0x060052DF RID: 21215 RVA: 0x001712D0 File Offset: 0x0016F4D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_1()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass35_1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, "invoked");
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, "CS$<>8__locals1");
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, 100670439);
				TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr, 100670440);
			}

			// Token: 0x060052E0 RID: 21216 RVA: 0x00171388 File Offset: 0x0016F588
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass35_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E1 RID: 21217 RVA: 0x001713C4 File Offset: 0x0016F5C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334262, XrefRangeEnd = 334263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromAsyncImpl_b__1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass35_1.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052E2 RID: 21218 RVA: 0x0001FAD4 File Offset: 0x0001DCD4
			public __c__DisplayClass35_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001528 RID: 5416
			// (get) Token: 0x060052E3 RID: 21219 RVA: 0x00171408 File Offset: 0x0016F608
			// (set) Token: 0x060052E4 RID: 21220 RVA: 0x0001FADD File Offset: 0x0001DCDD
			public unsafe AtomicBoolean invoked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtomicBoolean>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001529 RID: 5417
			// (get) Token: 0x060052E5 RID: 21221 RVA: 0x00171438 File Offset: 0x0016F638
			// (set) Token: 0x060052E6 RID: 21222 RVA: 0x0001FAFC File Offset: 0x0001DCFC
			public unsafe TaskFactory<TResult>.__c__DisplayClass35_0 field_Public___c__DisplayClass35_0_TResult_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>.__c__DisplayClass35_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass35_1.NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004319 RID: 17177
			private static readonly IntPtr NativeFieldInfoPtr_invoked;

			// Token: 0x0400431A RID: 17178
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass35_0_TResult_0;

			// Token: 0x0400431B RID: 17179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400431C RID: 17180
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000600 RID: 1536
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_0`1")]
		public sealed class __c__DisplayClass38_0<TArg1> : Object
		{
			// Token: 0x060052E7 RID: 21223 RVA: 0x00171468 File Offset: 0x0016F668
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_0()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endFunction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "endAction");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, "promise");
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100670441);
				TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr, 100670442);
			}

			// Token: 0x060052E8 RID: 21224 RVA: 0x00171544 File Offset: 0x0016F744
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052E9 RID: 21225 RVA: 0x00171580 File Offset: 0x0016F780
			[CallerCount(0)]
			public unsafe void _FromAsyncImpl_b__0(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052EA RID: 21226 RVA: 0x0001FB1B File Offset: 0x0001DD1B
			public __c__DisplayClass38_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700152A RID: 5418
			// (get) Token: 0x060052EB RID: 21227 RVA: 0x001715C4 File Offset: 0x0016F7C4
			// (set) Token: 0x060052EC RID: 21228 RVA: 0x0001FB24 File Offset: 0x0001DD24
			public unsafe Func<IAsyncResult, TResult> endFunction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncResult, TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700152B RID: 5419
			// (get) Token: 0x060052ED RID: 21229 RVA: 0x001715F4 File Offset: 0x0016F7F4
			// (set) Token: 0x060052EE RID: 21230 RVA: 0x0001FB43 File Offset: 0x0001DD43
			public unsafe Action<IAsyncResult> endAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_endAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700152C RID: 5420
			// (get) Token: 0x060052EF RID: 21231 RVA: 0x00171624 File Offset: 0x0016F824
			// (set) Token: 0x060052F0 RID: 21232 RVA: 0x0001FB62 File Offset: 0x0001DD62
			public unsafe Task<TResult> promise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>.NativeFieldInfoPtr_promise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400431D RID: 17181
			private static readonly IntPtr NativeFieldInfoPtr_endFunction;

			// Token: 0x0400431E RID: 17182
			private static readonly IntPtr NativeFieldInfoPtr_endAction;

			// Token: 0x0400431F RID: 17183
			private static readonly IntPtr NativeFieldInfoPtr_promise;

			// Token: 0x04004320 RID: 17184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004321 RID: 17185
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__0_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000601 RID: 1537
		[ObfuscatedName("System.Threading.Tasks.TaskFactory`1+<>c__DisplayClass38_1`1")]
		public sealed class __c__DisplayClass38_1<TArg1> : Object
		{
			// Token: 0x060052F1 RID: 21233 RVA: 0x00171654 File Offset: 0x0016F854
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass38_1()
			{
				Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory<TResult>>.NativeClassPtr, "<>c__DisplayClass38_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr);
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, "invoked");
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, "CS$<>8__locals1");
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, 100670443);
				TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr, 100670444);
			}

			// Token: 0x060052F2 RID: 21234 RVA: 0x0017171C File Offset: 0x0016F91C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass38_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052F3 RID: 21235 RVA: 0x00171758 File Offset: 0x0016F958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FromAsyncImpl_b__1(IAsyncResult iar)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(iar);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052F4 RID: 21236 RVA: 0x0001FB81 File Offset: 0x0001DD81
			public __c__DisplayClass38_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700152D RID: 5421
			// (get) Token: 0x060052F5 RID: 21237 RVA: 0x0017179C File Offset: 0x0016F99C
			// (set) Token: 0x060052F6 RID: 21238 RVA: 0x0001FB8A File Offset: 0x0001DD8A
			public unsafe AtomicBoolean invoked
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AtomicBoolean>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_invoked), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700152E RID: 5422
			// (get) Token: 0x060052F7 RID: 21239 RVA: 0x001717CC File Offset: 0x0016F9CC
			// (set) Token: 0x060052F8 RID: 21240 RVA: 0x0001FBA9 File Offset: 0x0001DDA9
			public unsafe TaskFactory<TResult>.__c__DisplayClass38_0<TArg1> field_Public___c__DisplayClass38_0_1_TResult_TArg1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>.__c__DisplayClass38_0<TArg1>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory<TResult>.__c__DisplayClass38_1<TArg1>.NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004322 RID: 17186
			private static readonly IntPtr NativeFieldInfoPtr_invoked;

			// Token: 0x04004323 RID: 17187
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass38_0_1_TResult_TArg1_0;

			// Token: 0x04004324 RID: 17188
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004325 RID: 17189
			private static readonly IntPtr NativeMethodInfoPtr__FromAsyncImpl_b__1_Internal_Void_IAsyncResult_0;
		}

		// Token: 0x02000602 RID: 1538
		private sealed class MethodInfoStoreGeneric_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0
		{
			// Token: 0x04004326 RID: 17190
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TArg1>.NativeMethodInfoPtr_FromAsyncImpl_Internal_Static_Task_1_TResult_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Func_2_IAsyncResult_TResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory<TArg1>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x02000603 RID: 1539
		private sealed class MethodInfoStoreGeneric_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0<TArgs>
		{
			// Token: 0x04004327 RID: 17191
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory<TInstance>.NativeMethodInfoPtr_FromAsyncTrim_Internal_Static_Task_1_TResult_TInstance_TArgs_Func_5_TInstance_TArgs_AsyncCallback_Object_IAsyncResult_Func_3_TInstance_IAsyncResult_TResult_0, Il2CppClassPointerStore<TaskFactory<TInstance>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TInstance>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArgs>.NativeClassPtr))
			}))));
		}
	}
}
