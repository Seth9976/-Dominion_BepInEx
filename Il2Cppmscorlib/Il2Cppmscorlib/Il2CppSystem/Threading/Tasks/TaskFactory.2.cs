using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B3 RID: 691
	public class TaskFactory : Object
	{
		// Token: 0x06002E89 RID: 11913 RVA: 0x000EB46C File Offset: 0x000E966C
		// Note: this type is marked as 'beforefieldinit'.
		static TaskFactory()
		{
			Il2CppClassPointerStore<TaskFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskFactory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr);
			TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCancellationToken");
			TaskFactory.NativeFieldInfoPtr_m_defaultScheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultScheduler");
			TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultCreationOptions");
			TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "m_defaultContinuationOptions");
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670677);
			TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670678);
			TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670679);
			TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670680);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670681);
			TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670682);
			TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670683);
			TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670684);
			TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, 100670685);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000EB5A0 File Offset: 0x000E97A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337014, XrefRangeEnd = 337015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000EB5DC File Offset: 0x000E97DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337015, XrefRangeEnd = 337016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskFactory(CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskContinuationOptions continuationOptions, TaskScheduler scheduler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x000EB65C File Offset: 0x000E985C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337016, RefRangeEnd = 337017, XrefRangeStart = 337016, XrefRangeEnd = 337016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckCreationOptions(TaskCreationOptions creationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x000EB690 File Offset: 0x000E9890
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337025, RefRangeEnd = 337026, XrefRangeStart = 337017, XrefRangeEnd = 337025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<TResult> StartNew<TResult>(Func<Object, TResult> function, Object state, CancellationToken cancellationToken, TaskCreationOptions creationOptions, TaskScheduler scheduler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(function);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TResult>>(intPtr3) : null;
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x000EB72C File Offset: 0x000E992C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337026, RefRangeEnd = 337027, XrefRangeStart = 337026, XrefRangeEnd = 337026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000EB7EC File Offset: 0x000E99EC
		[CallerCount(0)]
		public unsafe Task FromAsync<TArg1>(Func<TArg1, AsyncCallback, Object, IAsyncResult> beginMethod, Action<IAsyncResult> endMethod, TArg1 arg1, Object state, TaskCreationOptions creationOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(beginMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(endMethod);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
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
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref creationOptions;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TaskFactory.MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Task>(intPtr4) : null;
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x000EB8B8 File Offset: 0x000E9AB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337027, RefRangeEnd = 337029, XrefRangeStart = 337027, XrefRangeEnd = 337027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckFromAsyncOptions(TaskCreationOptions creationOptions, bool hasBeginMethod)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref creationOptions;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasBeginMethod;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x000EB8F8 File Offset: 0x000E9AF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 337051, RefRangeEnd = 337053, XrefRangeStart = 337029, XrefRangeEnd = 337051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Task<Task> CommonCWAnyLogic(IList<Task> tasks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Task>>(intPtr3) : null;
			}
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x000EB93C File Offset: 0x000E9B3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337053, RefRangeEnd = 337054, XrefRangeStart = 337053, XrefRangeEnd = 337053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckMultiTaskContinuationOptions(TaskContinuationOptions continuationOptions)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref continuationOptions;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x000103F0 File Offset: 0x0000E5F0
		public TaskFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002E94 RID: 11924 RVA: 0x000EB970 File Offset: 0x000E9B70
		// (set) Token: 0x06002E95 RID: 11925 RVA: 0x000103F9 File Offset: 0x0000E5F9
		public CancellationToken m_defaultCancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002E96 RID: 11926 RVA: 0x000EB9A0 File Offset: 0x000E9BA0
		// (set) Token: 0x06002E97 RID: 11927 RVA: 0x00010427 File Offset: 0x0000E627
		public unsafe TaskScheduler m_defaultScheduler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TaskScheduler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultScheduler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002E98 RID: 11928 RVA: 0x000EB9D0 File Offset: 0x000E9BD0
		// (set) Token: 0x06002E99 RID: 11929 RVA: 0x00010446 File Offset: 0x0000E646
		public unsafe TaskCreationOptions m_defaultCreationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultCreationOptions)) = value;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002E9A RID: 11930 RVA: 0x000EB9F8 File Offset: 0x000E9BF8
		// (set) Token: 0x06002E9B RID: 11931 RVA: 0x00010461 File Offset: 0x0000E661
		public unsafe TaskContinuationOptions m_defaultContinuationOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.NativeFieldInfoPtr_m_defaultContinuationOptions)) = value;
			}
		}

		// Token: 0x04002853 RID: 10323
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCancellationToken;

		// Token: 0x04002854 RID: 10324
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultScheduler;

		// Token: 0x04002855 RID: 10325
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultCreationOptions;

		// Token: 0x04002856 RID: 10326
		private static readonly IntPtr NativeFieldInfoPtr_m_defaultContinuationOptions;

		// Token: 0x04002857 RID: 10327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002858 RID: 10328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_TaskCreationOptions_TaskContinuationOptions_TaskScheduler_0;

		// Token: 0x04002859 RID: 10329
		private static readonly IntPtr NativeMethodInfoPtr_CheckCreationOptions_Internal_Static_Void_TaskCreationOptions_0;

		// Token: 0x0400285A RID: 10330
		private static readonly IntPtr NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0;

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr_CheckFromAsyncOptions_Internal_Static_Void_TaskCreationOptions_Boolean_0;

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeMethodInfoPtr_CommonCWAnyLogic_Internal_Static_Task_1_Task_IList_1_Task_0;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeMethodInfoPtr_CheckMultiTaskContinuationOptions_Internal_Static_Void_TaskContinuationOptions_0;

		// Token: 0x02000614 RID: 1556
		public sealed class CompleteOnInvokePromise : Task<Task>
		{
			// Token: 0x0600535F RID: 21343 RVA: 0x00172AD0 File Offset: 0x00170CD0
			// Note: this type is marked as 'beforefieldinit'.
			static CompleteOnInvokePromise()
			{
				Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskFactory>.NativeClassPtr, "CompleteOnInvokePromise");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr);
				TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, "_tasks");
				TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, "m_firstTaskAlreadyCompleted");
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100670686);
				TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr, 100670687);
			}

			// Token: 0x06005360 RID: 21344 RVA: 0x00172B4C File Offset: 0x00170D4C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 336987, RefRangeEnd = 336988, XrefRangeStart = 336970, XrefRangeEnd = 336987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CompleteOnInvokePromise(IList<Task> tasks)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskFactory.CompleteOnInvokePromise>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(tasks);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005361 RID: 21345 RVA: 0x00172B98 File Offset: 0x00170D98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 337013, RefRangeEnd = 337014, XrefRangeStart = 336988, XrefRangeEnd = 337013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskFactory.CompleteOnInvokePromise.NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005362 RID: 21346 RVA: 0x0001FED6 File Offset: 0x0001E0D6
			public CompleteOnInvokePromise(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001549 RID: 5449
			// (get) Token: 0x06005363 RID: 21347 RVA: 0x00172BDC File Offset: 0x00170DDC
			// (set) Token: 0x06005364 RID: 21348 RVA: 0x0001FEDF File Offset: 0x0001E0DF
			public unsafe IList<Task> _tasks
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<Task>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr__tasks), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700154A RID: 5450
			// (get) Token: 0x06005365 RID: 21349 RVA: 0x00172C0C File Offset: 0x00170E0C
			// (set) Token: 0x06005366 RID: 21350 RVA: 0x0001FEFE File Offset: 0x0001E0FE
			public unsafe int m_firstTaskAlreadyCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskFactory.CompleteOnInvokePromise.NativeFieldInfoPtr_m_firstTaskAlreadyCompleted)) = value;
				}
			}

			// Token: 0x04004360 RID: 17248
			private static readonly IntPtr NativeFieldInfoPtr__tasks;

			// Token: 0x04004361 RID: 17249
			private static readonly IntPtr NativeFieldInfoPtr_m_firstTaskAlreadyCompleted;

			// Token: 0x04004362 RID: 17250
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_Task_0;

			// Token: 0x04004363 RID: 17251
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x02000615 RID: 1557
		private sealed class MethodInfoStoreGeneric_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0<TResult>
		{
			// Token: 0x04004364 RID: 17252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_StartNew_Public_Task_1_TResult_Func_2_Object_TResult_Object_CancellationToken_TaskCreationOptions_TaskScheduler_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}

		// Token: 0x02000616 RID: 1558
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0<TArg1>
		{
			// Token: 0x04004365 RID: 17253
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}

		// Token: 0x02000617 RID: 1559
		private sealed class MethodInfoStoreGeneric_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0<TArg1>
		{
			// Token: 0x04004366 RID: 17254
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskFactory.NativeMethodInfoPtr_FromAsync_Public_Task_Func_4_TArg1_AsyncCallback_Object_IAsyncResult_Action_1_IAsyncResult_TArg1_Object_TaskCreationOptions_0, Il2CppClassPointerStore<TaskFactory>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg1>.NativeClassPtr)) }))));
		}
	}
}
