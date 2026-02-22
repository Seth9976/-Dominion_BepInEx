using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000414 RID: 1044
	public sealed class AsyncVoidMethodBuilder : ValueType
	{
		// Token: 0x0600417F RID: 16767 RVA: 0x0012E914 File Offset: 0x0012CB14
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncVoidMethodBuilder()
		{
			Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "AsyncVoidMethodBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr);
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_synchronizationContext");
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_coreState");
			AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, "m_task");
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672826);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672827);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672828);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672829);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672830);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672831);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672832);
			AsyncVoidMethodBuilder.NativeMethodInfoPtr_get_Task_Private_get_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr, 100672833);
		}

		// Token: 0x06004180 RID: 16768 RVA: 0x0012EA20 File Offset: 0x0012CC20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 356085, RefRangeEnd = 356089, XrefRangeStart = 356084, XrefRangeEnd = 356085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncVoidMethodBuilder Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncVoidMethodBuilder(intPtr);
		}

		// Token: 0x06004181 RID: 16769 RVA: 0x0012EA4C File Offset: 0x0012CC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356089, XrefRangeEnd = 356100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				stateMachine = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr4, false, false));
			}
		}

		// Token: 0x06004182 RID: 16770 RVA: 0x0012EAAC File Offset: 0x0012CCAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356101, RefRangeEnd = 356104, XrefRangeStart = 356100, XrefRangeEnd = 356101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004183 RID: 16771 RVA: 0x0012EAF4 File Offset: 0x0012CCF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 356128, RefRangeEnd = 356129, XrefRangeStart = 356104, XrefRangeEnd = 356128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			awaiter = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TAwaiter>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			stateMachine = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<TStateMachine>(intPtr6, false, false));
		}

		// Token: 0x06004184 RID: 16772 RVA: 0x0012EB80 File Offset: 0x0012CD80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356137, RefRangeEnd = 356140, XrefRangeStart = 356129, XrefRangeEnd = 356137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetResult_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004185 RID: 16773 RVA: 0x0012EBB8 File Offset: 0x0012CDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 356140, XrefRangeEnd = 356149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetException(Exception exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_SetException_Public_Void_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004186 RID: 16774 RVA: 0x0012EC00 File Offset: 0x0012CE00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 356151, RefRangeEnd = 356154, XrefRangeStart = 356149, XrefRangeEnd = 356151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifySynchronizationContextOfCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06004187 RID: 16775 RVA: 0x0012EC38 File Offset: 0x0012CE38
		public unsafe Task Task
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 356158, RefRangeEnd = 356161, XrefRangeStart = 356154, XrefRangeEnd = 356158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncVoidMethodBuilder.NativeMethodInfoPtr_get_Task_Private_get_Task_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}
		}

		// Token: 0x06004188 RID: 16776 RVA: 0x00018EAB File Offset: 0x000170AB
		public AsyncVoidMethodBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06004189 RID: 16777 RVA: 0x00018EB4 File Offset: 0x000170B4
		public AsyncVoidMethodBuilder()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr))
		{
		}

		// Token: 0x170010D1 RID: 4305
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x0012EC7C File Offset: 0x0012CE7C
		// (set) Token: 0x0600418B RID: 16779 RVA: 0x00018EC6 File Offset: 0x000170C6
		public unsafe SynchronizationContext m_synchronizationContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_synchronizationContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170010D2 RID: 4306
		// (get) Token: 0x0600418C RID: 16780 RVA: 0x0012ECAC File Offset: 0x0012CEAC
		// (set) Token: 0x0600418D RID: 16781 RVA: 0x00018EE5 File Offset: 0x000170E5
		public AsyncMethodBuilderCore m_coreState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState);
				return new AsyncMethodBuilderCore(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_coreState), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncMethodBuilderCore>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x0600418E RID: 16782 RVA: 0x0012ECDC File Offset: 0x0012CEDC
		// (set) Token: 0x0600418F RID: 16783 RVA: 0x00018F13 File Offset: 0x00017113
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncVoidMethodBuilder.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003578 RID: 13688
		private static readonly IntPtr NativeFieldInfoPtr_m_synchronizationContext;

		// Token: 0x04003579 RID: 13689
		private static readonly IntPtr NativeFieldInfoPtr_m_coreState;

		// Token: 0x0400357A RID: 13690
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x0400357B RID: 13691
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_AsyncVoidMethodBuilder_0;

		// Token: 0x0400357C RID: 13692
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0;

		// Token: 0x0400357D RID: 13693
		private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Public_Void_IAsyncStateMachine_0;

		// Token: 0x0400357E RID: 13694
		private static readonly IntPtr NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0;

		// Token: 0x0400357F RID: 13695
		private static readonly IntPtr NativeMethodInfoPtr_SetResult_Public_Void_0;

		// Token: 0x04003580 RID: 13696
		private static readonly IntPtr NativeMethodInfoPtr_SetException_Public_Void_Exception_0;

		// Token: 0x04003581 RID: 13697
		private static readonly IntPtr NativeMethodInfoPtr_NotifySynchronizationContextOfCompletion_Private_Void_0;

		// Token: 0x04003582 RID: 13698
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Private_get_Task_0;

		// Token: 0x02000631 RID: 1585
		private sealed class MethodInfoStoreGeneric_Start_Public_Void_byref_TStateMachine_0<TStateMachine>
		{
			// Token: 0x040043FA RID: 17402
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncVoidMethodBuilder.NativeMethodInfoPtr_Start_Public_Void_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr)) }))));
		}

		// Token: 0x02000632 RID: 1586
		private sealed class MethodInfoStoreGeneric_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0<TAwaiter, TStateMachine>
		{
			// Token: 0x040043FB RID: 17403
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncVoidMethodBuilder.NativeMethodInfoPtr_AwaitUnsafeOnCompleted_Public_Void_byref_TAwaiter_byref_TStateMachine_0, Il2CppClassPointerStore<AsyncVoidMethodBuilder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAwaiter>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TStateMachine>.NativeClassPtr))
			}))));
		}
	}
}
