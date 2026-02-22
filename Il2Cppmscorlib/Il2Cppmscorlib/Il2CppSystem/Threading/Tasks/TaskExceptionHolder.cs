using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Runtime.ExceptionServices;

namespace Il2CppSystem.Threading.Tasks
{
	// Token: 0x020002B2 RID: 690
	public class TaskExceptionHolder : Object
	{
		// Token: 0x06002E6B RID: 11883 RVA: 0x000EADF0 File Offset: 0x000E8FF0
		// Note: this type is marked as 'beforefieldinit'.
		static TaskExceptionHolder()
		{
			Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading.Tasks", "TaskExceptionHolder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr);
			TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_failFastOnUnobservedException");
			TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_domainUnloadStarted");
			TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "s_adUnloadEventHandler");
			TaskExceptionHolder.NativeFieldInfoPtr_m_task = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_task");
			TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_faultExceptions");
			TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_cancellationException");
			TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, "m_isHandled");
			TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670662);
			TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670663);
			TaskExceptionHolder.NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670664);
			TaskExceptionHolder.NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670665);
			TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670666);
			TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670667);
			TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670668);
			TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670669);
			TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670670);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670671);
			TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670672);
			TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670673);
			TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670674);
			TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr, 100670675);
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x000EAFC4 File Offset: 0x000E91C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336709, XrefRangeEnd = 336735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TaskExceptionHolder(Task task)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TaskExceptionHolder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(task);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr__ctor_Internal_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x000EB010 File Offset: 0x000E9210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336735, XrefRangeEnd = 336739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldFailFastOnUnobservedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x000EB040 File Offset: 0x000E9240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336739, XrefRangeEnd = 336760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureADUnloadCallbackRegistered()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x000EB068 File Offset: 0x000E9268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336760, XrefRangeEnd = 336765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppDomainUnloadCallback(Object sender, EventArgs e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x000EB0B0 File Offset: 0x000E92B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336765, XrefRangeEnd = 336832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TaskExceptionHolder.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x000EB0EC File Offset: 0x000E92EC
		public unsafe bool ContainsFaultList
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336832, XrefRangeEnd = 336833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x000EB128 File Offset: 0x000E9328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336833, XrefRangeEnd = 336846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object exceptionObject, bool representsCancellation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref representsCancellation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x000EB178 File Offset: 0x000E9378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336846, XrefRangeEnd = 336858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCancellationException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000EB1BC File Offset: 0x000E93BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 336923, RefRangeEnd = 336925, XrefRangeStart = 336858, XrefRangeEnd = 336923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFaultException(Object exceptionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exceptionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000EB200 File Offset: 0x000E9400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336931, RefRangeEnd = 336932, XrefRangeStart = 336925, XrefRangeEnd = 336931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsUnhandled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000EB234 File Offset: 0x000E9434
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 336938, RefRangeEnd = 336941, XrefRangeStart = 336932, XrefRangeEnd = 336938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkAsHandled(bool calledFromFinalizer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000EB274 File Offset: 0x000E9474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 336956, RefRangeEnd = 336957, XrefRangeStart = 336941, XrefRangeEnd = 336956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AggregateException CreateExceptionObject(bool calledFromFinalizer, Exception includeThisException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref calledFromFinalizer;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(includeThisException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AggregateException>(intPtr3) : null;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000EB2D4 File Offset: 0x000E94D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 336957, XrefRangeEnd = 336970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyCollection<ExceptionDispatchInfo> GetExceptionDispatchInfos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ExceptionDispatchInfo>>(intPtr3) : null;
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000EB314 File Offset: 0x000E9514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExceptionDispatchInfo GetCancellationExceptionDispatchInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TaskExceptionHolder.NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr3) : null;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00010341 File Offset: 0x0000E541
		public TaskExceptionHolder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06002E7B RID: 11899 RVA: 0x000EB354 File Offset: 0x000E9554
		// (set) Token: 0x06002E7C RID: 11900 RVA: 0x0001034A File Offset: 0x0000E54A
		public unsafe static bool s_failFastOnUnobservedException
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_failFastOnUnobservedException, (void*)(&value));
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06002E7D RID: 11901 RVA: 0x000EB370 File Offset: 0x000E9570
		// (set) Token: 0x06002E7E RID: 11902 RVA: 0x00010358 File Offset: 0x0000E558
		public unsafe static bool s_domainUnloadStarted
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_domainUnloadStarted, (void*)(&value));
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x000EB38C File Offset: 0x000E958C
		// (set) Token: 0x06002E80 RID: 11904 RVA: 0x00010366 File Offset: 0x0000E566
		public unsafe static EventHandler s_adUnloadEventHandler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TaskExceptionHolder.NativeFieldInfoPtr_s_adUnloadEventHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002E81 RID: 11905 RVA: 0x000EB3B4 File Offset: 0x000E95B4
		// (set) Token: 0x06002E82 RID: 11906 RVA: 0x00010378 File Offset: 0x0000E578
		public unsafe Task m_task
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_task), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002E83 RID: 11907 RVA: 0x000EB3E4 File Offset: 0x000E95E4
		// (set) Token: 0x06002E84 RID: 11908 RVA: 0x00010397 File Offset: 0x0000E597
		public unsafe List<ExceptionDispatchInfo> m_faultExceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ExceptionDispatchInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_faultExceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002E85 RID: 11909 RVA: 0x000EB414 File Offset: 0x000E9614
		// (set) Token: 0x06002E86 RID: 11910 RVA: 0x000103B6 File Offset: 0x0000E5B6
		public unsafe ExceptionDispatchInfo m_cancellationException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_cancellationException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x000EB444 File Offset: 0x000E9644
		// (set) Token: 0x06002E88 RID: 11912 RVA: 0x000103D5 File Offset: 0x0000E5D5
		public unsafe bool m_isHandled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TaskExceptionHolder.NativeFieldInfoPtr_m_isHandled)) = value;
			}
		}

		// Token: 0x0400283E RID: 10302
		private static readonly IntPtr NativeFieldInfoPtr_s_failFastOnUnobservedException;

		// Token: 0x0400283F RID: 10303
		private static readonly IntPtr NativeFieldInfoPtr_s_domainUnloadStarted;

		// Token: 0x04002840 RID: 10304
		private static readonly IntPtr NativeFieldInfoPtr_s_adUnloadEventHandler;

		// Token: 0x04002841 RID: 10305
		private static readonly IntPtr NativeFieldInfoPtr_m_task;

		// Token: 0x04002842 RID: 10306
		private static readonly IntPtr NativeFieldInfoPtr_m_faultExceptions;

		// Token: 0x04002843 RID: 10307
		private static readonly IntPtr NativeFieldInfoPtr_m_cancellationException;

		// Token: 0x04002844 RID: 10308
		private static readonly IntPtr NativeFieldInfoPtr_m_isHandled;

		// Token: 0x04002845 RID: 10309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Task_0;

		// Token: 0x04002846 RID: 10310
		private static readonly IntPtr NativeMethodInfoPtr_ShouldFailFastOnUnobservedException_Private_Static_Boolean_0;

		// Token: 0x04002847 RID: 10311
		private static readonly IntPtr NativeMethodInfoPtr_EnsureADUnloadCallbackRegistered_Private_Static_Void_0;

		// Token: 0x04002848 RID: 10312
		private static readonly IntPtr NativeMethodInfoPtr_AppDomainUnloadCallback_Private_Static_Void_Object_EventArgs_0;

		// Token: 0x04002849 RID: 10313
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400284A RID: 10314
		private static readonly IntPtr NativeMethodInfoPtr_get_ContainsFaultList_Internal_get_Boolean_0;

		// Token: 0x0400284B RID: 10315
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Object_Boolean_0;

		// Token: 0x0400284C RID: 10316
		private static readonly IntPtr NativeMethodInfoPtr_SetCancellationException_Private_Void_Object_0;

		// Token: 0x0400284D RID: 10317
		private static readonly IntPtr NativeMethodInfoPtr_AddFaultException_Private_Void_Object_0;

		// Token: 0x0400284E RID: 10318
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsUnhandled_Private_Void_0;

		// Token: 0x0400284F RID: 10319
		private static readonly IntPtr NativeMethodInfoPtr_MarkAsHandled_Internal_Void_Boolean_0;

		// Token: 0x04002850 RID: 10320
		private static readonly IntPtr NativeMethodInfoPtr_CreateExceptionObject_Internal_AggregateException_Boolean_Exception_0;

		// Token: 0x04002851 RID: 10321
		private static readonly IntPtr NativeMethodInfoPtr_GetExceptionDispatchInfos_Internal_ReadOnlyCollection_1_ExceptionDispatchInfo_0;

		// Token: 0x04002852 RID: 10322
		private static readonly IntPtr NativeMethodInfoPtr_GetCancellationExceptionDispatchInfo_Internal_ExceptionDispatchInfo_0;
	}
}
