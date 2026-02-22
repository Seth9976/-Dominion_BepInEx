using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B7 RID: 695
	public static class TaskToApm : Object
	{
		// Token: 0x06002EC4 RID: 11972 RVA: 0x000EC2F0 File Offset: 0x000EA4F0
		// Note: this type is marked as 'beforefieldinit'.
		static TaskToApm()
		{
			Il2CppClassPointerStore<TaskToApm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskToApm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr);
			TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670707);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670708);
			TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670709);
			TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, 100670710);
		}

		// Token: 0x06002EC5 RID: 11973 RVA: 0x000EC370 File Offset: 0x000EA570
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 337214, RefRangeEnd = 337221, XrefRangeStart = 337188, XrefRangeEnd = 337214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IAsyncResult Begin(Task task, AsyncCallback callback, Object state)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000EC3D8 File Offset: 0x000EA5D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 337227, RefRangeEnd = 337230, XrefRangeStart = 337221, XrefRangeEnd = 337227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void End(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000EC410 File Offset: 0x000EA610
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337236, RefRangeEnd = 337237, XrefRangeStart = 337230, XrefRangeEnd = 337236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TResult End<TResult>(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TResult>(intPtr, false, true);
			}
		}

		// Token: 0x06002EC8 RID: 11976 RVA: 0x000EC450 File Offset: 0x000EA650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337237, XrefRangeEnd = 337249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeCallbackWhenTaskCompletes(Task antecedent, AsyncCallback callback, IAsyncResult asyncResult)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(antecedent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00010542 File Offset: 0x0000E742
		public TaskToApm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400287A RID: 10362
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_Static_IAsyncResult_Task_AsyncCallback_Object_0;

		// Token: 0x0400287B RID: 10363
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_Void_IAsyncResult_0;

		// Token: 0x0400287C RID: 10364
		private static readonly IntPtr NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0;

		// Token: 0x0400287D RID: 10365
		private static readonly IntPtr NativeMethodInfoPtr_InvokeCallbackWhenTaskCompletes_Private_Static_Void_Task_AsyncCallback_IAsyncResult_0;

		// Token: 0x02000619 RID: 1561
		public sealed class TaskWrapperAsyncResult : Object
		{
			// Token: 0x0600536C RID: 21356 RVA: 0x00172D30 File Offset: 0x00170F30
			// Note: this type is marked as 'beforefieldinit'.
			static TaskWrapperAsyncResult()
			{
				Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "TaskWrapperAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr);
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "Task");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "m_state");
				TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, "m_completedSynchronously");
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670711);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670712);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670713);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670714);
				TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr, 100670715);
			}

			// Token: 0x0600536D RID: 21357 RVA: 0x00172DFC File Offset: 0x00170FFC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 52975, RefRangeEnd = 52980, XrefRangeStart = 52975, XrefRangeEnd = 52980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TaskWrapperAsyncResult(Task task, Object state, bool completedSynchronously)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.TaskWrapperAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref completedSynchronously;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700154E RID: 5454
			// (get) Token: 0x0600536E RID: 21358 RVA: 0x00172E68 File Offset: 0x00171068
			public unsafe Object System.IAsyncResult.AsyncState
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x1700154F RID: 5455
			// (get) Token: 0x0600536F RID: 21359 RVA: 0x00172EA8 File Offset: 0x001710A8
			public unsafe bool System.IAsyncResult.CompletedSynchronously
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001550 RID: 5456
			// (get) Token: 0x06005370 RID: 21360 RVA: 0x00172EE4 File Offset: 0x001710E4
			public unsafe bool System.IAsyncResult.IsCompleted
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337182, XrefRangeEnd = 337184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17001551 RID: 5457
			// (get) Token: 0x06005371 RID: 21361 RVA: 0x00172F20 File Offset: 0x00171120
			public unsafe WaitHandle System.IAsyncResult.AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337184, XrefRangeEnd = 337188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.TaskWrapperAsyncResult.NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x06005372 RID: 21362 RVA: 0x0001FF42 File Offset: 0x0001E142
			public TaskWrapperAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700154B RID: 5451
			// (get) Token: 0x06005373 RID: 21363 RVA: 0x00172F60 File Offset: 0x00171160
			// (set) Token: 0x06005374 RID: 21364 RVA: 0x0001FF4B File Offset: 0x0001E14B
			public unsafe Task Task
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_Task), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700154C RID: 5452
			// (get) Token: 0x06005375 RID: 21365 RVA: 0x00172F90 File Offset: 0x00171190
			// (set) Token: 0x06005376 RID: 21366 RVA: 0x0001FF6A File Offset: 0x0001E16A
			public unsafe Object m_state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_state), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700154D RID: 5453
			// (get) Token: 0x06005377 RID: 21367 RVA: 0x00172FC0 File Offset: 0x001711C0
			// (set) Token: 0x06005378 RID: 21368 RVA: 0x0001FF89 File Offset: 0x0001E189
			public unsafe bool m_completedSynchronously
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.TaskWrapperAsyncResult.NativeFieldInfoPtr_m_completedSynchronously)) = value;
				}
			}

			// Token: 0x04004367 RID: 17255
			private static readonly IntPtr NativeFieldInfoPtr_Task;

			// Token: 0x04004368 RID: 17256
			private static readonly IntPtr NativeFieldInfoPtr_m_state;

			// Token: 0x04004369 RID: 17257
			private static readonly IntPtr NativeFieldInfoPtr_m_completedSynchronously;

			// Token: 0x0400436A RID: 17258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_Object_Boolean_0;

			// Token: 0x0400436B RID: 17259
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncState_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400436C RID: 17260
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_CompletedSynchronously_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400436D RID: 17261
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_IsCompleted_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x0400436E RID: 17262
			private static readonly IntPtr NativeMethodInfoPtr_System_IAsyncResult_get_AsyncWaitHandle_Private_Virtual_Final_New_get_WaitHandle_0;
		}

		// Token: 0x0200061A RID: 1562
		[ObfuscatedName("System.Threading.Tasks.TaskToApm+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x06005379 RID: 21369 RVA: 0x00172FE8 File Offset: 0x001711E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TaskToApm>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr);
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, "asyncResult");
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100670716);
				TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr, 100670717);
			}

			// Token: 0x0600537A RID: 21370 RVA: 0x00173064 File Offset: 0x00171264
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskToApm.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600537B RID: 21371 RVA: 0x001730A0 File Offset: 0x001712A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 332371, RefRangeEnd = 332372, XrefRangeStart = 332371, XrefRangeEnd = 332372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InvokeCallbackWhenTaskCompletes_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskToApm.__c__DisplayClass3_0.NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600537C RID: 21372 RVA: 0x0001FFA4 File Offset: 0x0001E1A4
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001552 RID: 5458
			// (get) Token: 0x0600537D RID: 21373 RVA: 0x001730D4 File Offset: 0x001712D4
			// (set) Token: 0x0600537E RID: 21374 RVA: 0x0001FFAD File Offset: 0x0001E1AD
			public unsafe AsyncCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001553 RID: 5459
			// (get) Token: 0x0600537F RID: 21375 RVA: 0x00173104 File Offset: 0x00171304
			// (set) Token: 0x06005380 RID: 21376 RVA: 0x0001FFCC File Offset: 0x0001E1CC
			public unsafe IAsyncResult asyncResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskToApm.__c__DisplayClass3_0.NativeFieldInfoPtr_asyncResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400436F RID: 17263
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04004370 RID: 17264
			private static readonly IntPtr NativeFieldInfoPtr_asyncResult;

			// Token: 0x04004371 RID: 17265
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004372 RID: 17266
			private static readonly IntPtr NativeMethodInfoPtr__InvokeCallbackWhenTaskCompletes_b__0_Internal_Void_0;
		}

		// Token: 0x0200061B RID: 1563
		private sealed class MethodInfoStoreGeneric_End_Public_Static_TResult_IAsyncResult_0<TResult>
		{
			// Token: 0x04004373 RID: 17267
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TaskToApm.NativeMethodInfoPtr_End_Public_Static_TResult_IAsyncResult_0, Il2CppClassPointerStore<TaskToApm>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) }))));
		}
	}
}
