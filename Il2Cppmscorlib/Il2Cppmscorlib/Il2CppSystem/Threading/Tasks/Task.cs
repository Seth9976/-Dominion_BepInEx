using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x0200029A RID: 666
	public class Task<TResult> : Task
	{
		// Token: 0x06002D04 RID: 11524 RVA: 0x000E4380 File Offset: 0x000E2580
		// Note: this type is marked as 'beforefieldinit'.
		static Task()
		{
			Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "Task`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr);
			Task<TResult>.NativeFieldInfoPtr_m_result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "m_result");
			Task<TResult>.NativeFieldInfoPtr_s_Factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "s_Factory");
			Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "TaskWhenAnyCast");
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670396);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670397);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670398);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670399);
			Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670400);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670401);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670402);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670403);
			Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670404);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670405);
			Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670406);
			Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670407);
			Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670408);
			Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670409);
			Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670410);
			Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670411);
			Task<TResult>.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670412);
			Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670413);
			Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670414);
			Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670415);
			Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670416);
			Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670417);
			Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670418);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670419);
			Task<TResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, 100670420);
		}

		// Token: 0x06002D05 RID: 11525 RVA: 0x000E461C File Offset: 0x000E281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334093, XrefRangeEnd = 334102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D06 RID: 11526 RVA: 0x000E4658 File Offset: 0x000E2858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334102, XrefRangeEnd = 334106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Object state, TaskCreationOptions options)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x000E46B4 File Offset: 0x000E28B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334106, XrefRangeEnd = 334110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(TResult result)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000E4738 File Offset: 0x000E2938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334110, XrefRangeEnd = 334114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(bool canceled, TResult result, TaskCreationOptions creationOptions, CancellationToken ct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canceled;
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ct));
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000E47F0 File Offset: 0x000E29F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334114, XrefRangeEnd = 334119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000E4874 File Offset: 0x000E2A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334119, XrefRangeEnd = 334129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000E4928 File Offset: 0x000E2B28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334129, XrefRangeEnd = 334133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<TResult> valueSelector, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000E49CC File Offset: 0x000E2BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334133, XrefRangeEnd = 334138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Func<Object, TResult> valueSelector, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000E4A94 File Offset: 0x000E2C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334138, XrefRangeEnd = 334142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task(Delegate valueSelector, Object state, Task parent, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueSelector);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000E4B4C File Offset: 0x000E2D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334142, XrefRangeEnd = 334149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<TResult> function, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x000E4BF8 File Offset: 0x000E2DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334149, XrefRangeEnd = 334156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<TResult> StartNew(Task parent, Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, InternalTaskOptions internalOptions, TaskScheduler scheduler, ref StackCrawlMark stackMark)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref internalOptions;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000E4CB8 File Offset: 0x000E2EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334164, RefRangeEnd = 334165, XrefRangeStart = 334156, XrefRangeEnd = 334164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000E4D3C File Offset: 0x000E2F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334165, XrefRangeEnd = 334167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DangerousSetResult(TResult result)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002D12 RID: 11538 RVA: 0x000E4DB4 File Offset: 0x000E2FB4
		public unsafe TResult Result
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 334168, RefRangeEnd = 334174, XrefRangeStart = 334167, XrefRangeEnd = 334168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Result_Public_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000E4DF0 File Offset: 0x000E2FF0
		public unsafe TResult ResultOnSuccess
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002D14 RID: 11540 RVA: 0x000E4E2C File Offset: 0x000E302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334174, XrefRangeEnd = 334179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TResult GetResultCore(bool waitCompletionNotification)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref waitCompletionNotification;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000E4E74 File Offset: 0x000E3074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334179, XrefRangeEnd = 334183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D16 RID: 11542 RVA: 0x000E4EC4 File Offset: 0x000E30C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334184, RefRangeEnd = 334185, XrefRangeStart = 334183, XrefRangeEnd = 334184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D17 RID: 11543 RVA: 0x000E4F18 File Offset: 0x000E3118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334185, XrefRangeEnd = 334188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TrySetCanceled(CancellationToken tokenToRecord, Object cancellationException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tokenToRecord));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cancellationException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x000E4F7C File Offset: 0x000E317C
		public new unsafe static TaskFactory<TResult> Factory
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334188, XrefRangeEnd = 334196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr3) : null;
			}
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000E4FB0 File Offset: 0x000E31B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334196, XrefRangeEnd = 334201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InnerInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Task<TResult>.NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000E4FEC File Offset: 0x000E31EC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe TaskAwaiter<TResult> GetAwaiter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new TaskAwaiter<TResult>(intPtr);
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000E5024 File Offset: 0x000E3224
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 334202, RefRangeEnd = 334234, XrefRangeStart = 334201, XrefRangeEnd = 334202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe ConfiguredTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continueOnCapturedContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new ConfiguredTaskAwaitable<TResult>(intPtr);
			}
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000E5068 File Offset: 0x000E3268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334234, XrefRangeEnd = 334238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskContinuationOptions continuationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000E50C8 File Offset: 0x000E32C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334238, XrefRangeEnd = 334245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TNewResult> ContinueWith<TNewResult>(Func<Task<TResult>, TNewResult> continuationFunction, TaskScheduler scheduler, CancellationToken cancellationToken, TaskContinuationOptions continuationOptions, ref StackCrawlMark stackMark)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(continuationFunction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stackMark;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TNewResult>.MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TNewResult>>(intPtr3) : null;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x0000FD5D File Offset: 0x0000DF5D
		public Task(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002D1F RID: 11551 RVA: 0x000E5160 File Offset: 0x000E3360
		// (set) Token: 0x06002D20 RID: 11552 RVA: 0x000E5188 File Offset: 0x000E3388
		public unsafe TResult m_result
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Task<TResult>.NativeFieldInfoPtr_m_result);
				Type typeFromHandle = typeof(TResult);
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

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002D21 RID: 11553 RVA: 0x000E5230 File Offset: 0x000E3430
		// (set) Token: 0x06002D22 RID: 11554 RVA: 0x0000FD66 File Offset: 0x0000DF66
		public unsafe static TaskFactory<TResult> s_Factory
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task<TResult>.NativeFieldInfoPtr_s_Factory, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskFactory<TResult>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task<TResult>.NativeFieldInfoPtr_s_Factory, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002D23 RID: 11555 RVA: 0x000E5258 File Offset: 0x000E3458
		// (set) Token: 0x06002D24 RID: 11556 RVA: 0x0000FD78 File Offset: 0x0000DF78
		public unsafe static Func<Task<Task>, Task<TResult>> TaskWhenAnyCast
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Task<Task>, Task<TResult>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Task<TResult>.NativeFieldInfoPtr_TaskWhenAnyCast, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002706 RID: 9990
		private static readonly IntPtr NativeFieldInfoPtr_m_result;

		// Token: 0x04002707 RID: 9991
		private static readonly IntPtr NativeFieldInfoPtr_s_Factory;

		// Token: 0x04002708 RID: 9992
		private static readonly IntPtr NativeFieldInfoPtr_TaskWhenAnyCast;

		// Token: 0x04002709 RID: 9993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400270A RID: 9994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_TaskCreationOptions_0;

		// Token: 0x0400270B RID: 9995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TResult_0;

		// Token: 0x0400270C RID: 9996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_TResult_TaskCreationOptions_CancellationToken_0;

		// Token: 0x0400270D RID: 9997
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_0;

		// Token: 0x0400270E RID: 9998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x0400270F RID: 9999
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_1_TResult_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04002710 RID: 10000
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Func_2_Object_TResult_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x04002711 RID: 10001
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Delegate_Object_Task_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_0;

		// Token: 0x04002712 RID: 10002
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_1_TResult_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Internal_Static_Task_1_TResult_Task_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_InternalTaskOptions_TaskScheduler_byref_StackCrawlMark_0;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeMethodInfoPtr_TrySetResult_Internal_Boolean_TResult_0;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeMethodInfoPtr_DangerousSetResult_Internal_Void_TResult_0;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TResult_0;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeMethodInfoPtr_get_ResultOnSuccess_Internal_get_TResult_0;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeMethodInfoPtr_GetResultCore_Internal_TResult_Boolean_0;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeMethodInfoPtr_TrySetException_Internal_Boolean_Object_0;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_0;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeMethodInfoPtr_TrySetCanceled_Internal_Boolean_CancellationToken_Object_0;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeMethodInfoPtr_get_Factory_Public_Static_get_TaskFactory_1_TResult_0;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeMethodInfoPtr_InnerInvoke_Internal_Virtual_Void_0;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_GetAwaiter_Public_TaskAwaiter_1_TResult_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAwait_Public_ConfiguredTaskAwaitable_1_TResult_Boolean_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0;

		// Token: 0x020005FA RID: 1530
		[ObfuscatedName("System.Threading.Tasks.Task`1+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x060052C2 RID: 21186 RVA: 0x00170B64 File Offset: 0x0016ED64
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Task<TResult>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr);
				Task<TResult>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, "<>9");
				Task<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, 100670423);
				Task<TResult>.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr, 100670424);
			}

			// Token: 0x060052C3 RID: 21187 RVA: 0x00170C08 File Offset: 0x0016EE08
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Task<TResult>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052C4 RID: 21188 RVA: 0x00170C44 File Offset: 0x0016EE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334089, XrefRangeEnd = 334093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Task<TResult> __cctor_b__64_0(Task<Task> completed)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completed);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Task<TResult>.__c.NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
				}
			}

			// Token: 0x060052C5 RID: 21189 RVA: 0x0001FA19 File Offset: 0x0001DC19
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001521 RID: 5409
			// (get) Token: 0x060052C6 RID: 21190 RVA: 0x00170C94 File Offset: 0x0016EE94
			// (set) Token: 0x060052C7 RID: 21191 RVA: 0x0001FA22 File Offset: 0x0001DC22
			public unsafe static Task<TResult>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Task<TResult>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<TResult>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Task<TResult>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04004309 RID: 17161
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400430A RID: 17162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400430B RID: 17163
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__64_0_Internal_Task_1_TResult_Task_1_Task_0;
		}

		// Token: 0x020005FB RID: 1531
		private sealed class MethodInfoStoreGeneric_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0
		{
			// Token: 0x0400430C RID: 17164
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Public_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskContinuationOptions_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}

		// Token: 0x020005FC RID: 1532
		private sealed class MethodInfoStoreGeneric_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0
		{
			// Token: 0x0400430D RID: 17165
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Task<TNewResult>.NativeMethodInfoPtr_ContinueWith_Internal_Task_1_TNewResult_Func_2_Task_1_TResult_TNewResult_TaskScheduler_CancellationToken_TaskContinuationOptions_byref_StackCrawlMark_0, Il2CppClassPointerStore<Task<TNewResult>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TNewResult>.NativeClassPtr)) }))));
		}
	}
}
