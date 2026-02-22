using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;

namespace UnityEngine
{
	// Token: 0x020000C6 RID: 198
	public sealed class UnitySynchronizationContext : SynchronizationContext
	{
		// Token: 0x06001169 RID: 4457 RVA: 0x00046D44 File Offset: 0x00044F44
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySynchronizationContext()
		{
			Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnitySynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr);
			UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_AsyncWorkQueue");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_CurrentFrameWork");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_MainThreadID");
			UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "m_TrackedCount");
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664515);
			UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664516);
			UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664517);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664518);
			UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664519);
			UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664520);
			UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664521);
			UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664522);
			UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664523);
			UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664524);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664525);
			UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, 100664526);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00046EB4 File Offset: 0x000450B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76490, XrefRangeEnd = 76501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(int mainThreadID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mainThreadID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00046EFC File Offset: 0x000450FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76501, XrefRangeEnd = 76508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySynchronizationContext(List<UnitySynchronizationContext.WorkRequest> queue, int mainThreadID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mainThreadID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00046F58 File Offset: 0x00045158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76508, XrefRangeEnd = 76526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Send(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00046FAC File Offset: 0x000451AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76526, XrefRangeEnd = 76527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00046FE0 File Offset: 0x000451E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76527, XrefRangeEnd = 76528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00047014 File Offset: 0x00045214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76528, XrefRangeEnd = 76535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Post(SendOrPostCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00047068 File Offset: 0x00045268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76535, XrefRangeEnd = 76545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000470A8 File Offset: 0x000452A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76563, RefRangeEnd = 76565, XrefRangeStart = 76545, XrefRangeEnd = 76563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exec()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_Exec_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000470DC File Offset: 0x000452DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76565, XrefRangeEnd = 76566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasPendingTasks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00047118 File Offset: 0x00045318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76566, XrefRangeEnd = 76584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeSynchronizationContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00047140 File Offset: 0x00045340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76584, XrefRangeEnd = 76588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteTasks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00047168 File Offset: 0x00045368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76588, XrefRangeEnd = 76603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExecutePendingTasks(long millisecondsTimeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0000A6BB File Offset: 0x000088BB
		public UnitySynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x000471A8 File Offset: 0x000453A8
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0000A6C4 File Offset: 0x000088C4
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_AsyncWorkQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_AsyncWorkQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x000471D8 File Offset: 0x000453D8
		// (set) Token: 0x0600117A RID: 4474 RVA: 0x0000A6E3 File Offset: 0x000088E3
		public unsafe List<UnitySynchronizationContext.WorkRequest> m_CurrentFrameWork
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnitySynchronizationContext.WorkRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_CurrentFrameWork), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600117B RID: 4475 RVA: 0x00047208 File Offset: 0x00045408
		// (set) Token: 0x0600117C RID: 4476 RVA: 0x0000A702 File Offset: 0x00008902
		public unsafe int m_MainThreadID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_MainThreadID)) = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x00047230 File Offset: 0x00045430
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0000A71D File Offset: 0x0000891D
		public unsafe int m_TrackedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.NativeFieldInfoPtr_m_TrackedCount)) = value;
			}
		}

		// Token: 0x04000D1D RID: 3357
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncWorkQueue;

		// Token: 0x04000D1E RID: 3358
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentFrameWork;

		// Token: 0x04000D1F RID: 3359
		private static readonly IntPtr NativeFieldInfoPtr_m_MainThreadID;

		// Token: 0x04000D20 RID: 3360
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedCount;

		// Token: 0x04000D21 RID: 3361
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Int32_0;

		// Token: 0x04000D22 RID: 3362
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_List_1_WorkRequest_Int32_0;

		// Token: 0x04000D23 RID: 3363
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x04000D24 RID: 3364
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_Void_0;

		// Token: 0x04000D25 RID: 3365
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_Void_0;

		// Token: 0x04000D26 RID: 3366
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Void_SendOrPostCallback_Object_0;

		// Token: 0x04000D27 RID: 3367
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_SynchronizationContext_0;

		// Token: 0x04000D28 RID: 3368
		private static readonly IntPtr NativeMethodInfoPtr_Exec_Private_Void_0;

		// Token: 0x04000D29 RID: 3369
		private static readonly IntPtr NativeMethodInfoPtr_HasPendingTasks_Private_Boolean_0;

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSynchronizationContext_Private_Static_Void_0;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteTasks_Private_Static_Void_0;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePendingTasks_Private_Static_Boolean_Int64_0;

		// Token: 0x04000D2D RID: 3373
		public const int kAwqInitialCapacity = 20;

		// Token: 0x020007B8 RID: 1976
		public sealed class WorkRequest : ValueType
		{
			// Token: 0x06002D12 RID: 11538 RVA: 0x0006CA08 File Offset: 0x0006AC08
			// Note: this type is marked as 'beforefieldinit'.
			static WorkRequest()
			{
				Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySynchronizationContext>.NativeClassPtr, "WorkRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr);
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateCallback");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_DelagateState");
				UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, "m_WaitHandle");
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100664527);
				UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr, 100664528);
			}

			// Token: 0x06002D13 RID: 11539 RVA: 0x0006CA98 File Offset: 0x0006AC98
			[CallerCount(0)]
			public unsafe WorkRequest(SendOrPostCallback callback, Object state, ManualResetEvent waitHandle = null)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(waitHandle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D14 RID: 11540 RVA: 0x0006CB0C File Offset: 0x0006AD0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 76489, RefRangeEnd = 76490, XrefRangeStart = 76481, XrefRangeEnd = 76489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySynchronizationContext.WorkRequest.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D15 RID: 11541 RVA: 0x00015452 File Offset: 0x00013652
			public WorkRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002D16 RID: 11542 RVA: 0x0001545B File Offset: 0x0001365B
			public WorkRequest()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySynchronizationContext.WorkRequest>.NativeClassPtr))
			{
			}

			// Token: 0x17000770 RID: 1904
			// (get) Token: 0x06002D17 RID: 11543 RVA: 0x0006CB44 File Offset: 0x0006AD44
			// (set) Token: 0x06002D18 RID: 11544 RVA: 0x0001546D File Offset: 0x0001366D
			public unsafe SendOrPostCallback m_DelagateCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendOrPostCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000771 RID: 1905
			// (get) Token: 0x06002D19 RID: 11545 RVA: 0x0006CB74 File Offset: 0x0006AD74
			// (set) Token: 0x06002D1A RID: 11546 RVA: 0x0001548C File Offset: 0x0001368C
			public unsafe Object m_DelagateState
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_DelagateState), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x06002D1B RID: 11547 RVA: 0x0006CBA4 File Offset: 0x0006ADA4
			// (set) Token: 0x06002D1C RID: 11548 RVA: 0x000154AB File Offset: 0x000136AB
			public unsafe ManualResetEvent m_WaitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySynchronizationContext.WorkRequest.NativeFieldInfoPtr_m_WaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001CAC RID: 7340
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateCallback;

			// Token: 0x04001CAD RID: 7341
			private static readonly IntPtr NativeFieldInfoPtr_m_DelagateState;

			// Token: 0x04001CAE RID: 7342
			private static readonly IntPtr NativeFieldInfoPtr_m_WaitHandle;

			// Token: 0x04001CAF RID: 7343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SendOrPostCallback_Object_ManualResetEvent_0;

			// Token: 0x04001CB0 RID: 7344
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;
		}
	}
}
