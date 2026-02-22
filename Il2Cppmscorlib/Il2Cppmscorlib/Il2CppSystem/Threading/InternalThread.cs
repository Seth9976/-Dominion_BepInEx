using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ConstrainedExecution;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000291 RID: 657
	public sealed class InternalThread : CriticalFinalizerObject
	{
		// Token: 0x06002C84 RID: 11396 RVA: 0x000E2E88 File Offset: 0x000E1088
		// Note: this type is marked as 'beforefieldinit'.
		static InternalThread()
		{
			Il2CppClassPointerStore<InternalThread>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "InternalThread");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalThread>.NativeClassPtr);
			InternalThread.NativeFieldInfoPtr_lock_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "lock_thread_id");
			InternalThread.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "handle");
			InternalThread.NativeFieldInfoPtr_native_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "native_handle");
			InternalThread.NativeFieldInfoPtr_unused3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused3");
			InternalThread.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name");
			InternalThread.NativeFieldInfoPtr_name_len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "name_len");
			InternalThread.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "state");
			InternalThread.NativeFieldInfoPtr_abort_exc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_exc");
			InternalThread.NativeFieldInfoPtr_abort_state_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_state_handle");
			InternalThread.NativeFieldInfoPtr_thread_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_id");
			InternalThread.NativeFieldInfoPtr_debugger_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "debugger_thread");
			InternalThread.NativeFieldInfoPtr_static_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "static_data");
			InternalThread.NativeFieldInfoPtr_runtime_thread_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "runtime_thread_info");
			InternalThread.NativeFieldInfoPtr_current_appcontext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "current_appcontext");
			InternalThread.NativeFieldInfoPtr_root_domain_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "root_domain_thread");
			InternalThread.NativeFieldInfoPtr__serialized_principal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal");
			InternalThread.NativeFieldInfoPtr__serialized_principal_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "_serialized_principal_version");
			InternalThread.NativeFieldInfoPtr_appdomain_refs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "appdomain_refs");
			InternalThread.NativeFieldInfoPtr_interruption_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "interruption_requested");
			InternalThread.NativeFieldInfoPtr_synch_cs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "synch_cs");
			InternalThread.NativeFieldInfoPtr_threadpool_thread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "threadpool_thread");
			InternalThread.NativeFieldInfoPtr_thread_interrupt_requested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_interrupt_requested");
			InternalThread.NativeFieldInfoPtr_stack_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "stack_size");
			InternalThread.NativeFieldInfoPtr_apartment_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "apartment_state");
			InternalThread.NativeFieldInfoPtr_critical_region_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "critical_region_level");
			InternalThread.NativeFieldInfoPtr_managed_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "managed_id");
			InternalThread.NativeFieldInfoPtr_small_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "small_id");
			InternalThread.NativeFieldInfoPtr_manage_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "manage_callback");
			InternalThread.NativeFieldInfoPtr_unused4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused4");
			InternalThread.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "flags");
			InternalThread.NativeFieldInfoPtr_thread_pinning_ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "thread_pinning_ref");
			InternalThread.NativeFieldInfoPtr_abort_protected_block_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "abort_protected_block_count");
			InternalThread.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "priority");
			InternalThread.NativeFieldInfoPtr_owned_mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "owned_mutex");
			InternalThread.NativeFieldInfoPtr_suspended_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "suspended_event");
			InternalThread.NativeFieldInfoPtr_self_suspended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "self_suspended");
			InternalThread.NativeFieldInfoPtr_unused1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused1");
			InternalThread.NativeFieldInfoPtr_unused2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "unused2");
			InternalThread.NativeFieldInfoPtr_last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, "last");
			InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670359);
			InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670360);
			InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalThread>.NativeClassPtr, 100670361);
		}

		// Token: 0x06002C85 RID: 11397 RVA: 0x000E3200 File Offset: 0x000E1400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333797, XrefRangeEnd = 333798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Thread_free_internal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Thread_free_internal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C86 RID: 11398 RVA: 0x000E3234 File Offset: 0x000E1434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333798, XrefRangeEnd = 333802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C87 RID: 11399 RVA: 0x000E3268 File Offset: 0x000E1468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333802, XrefRangeEnd = 333803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InternalThread()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InternalThread>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalThread.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C88 RID: 11400 RVA: 0x0000F820 File Offset: 0x0000DA20
		public InternalThread(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x000E32A4 File Offset: 0x000E14A4
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x0000F829 File Offset: 0x0000DA29
		public unsafe int lock_thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_lock_thread_id)) = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06002C8B RID: 11403 RVA: 0x000E32CC File Offset: 0x000E14CC
		// (set) Token: 0x06002C8C RID: 11404 RVA: 0x0000F844 File Offset: 0x0000DA44
		public unsafe IntPtr handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_handle)) = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06002C8D RID: 11405 RVA: 0x000E32F4 File Offset: 0x000E14F4
		// (set) Token: 0x06002C8E RID: 11406 RVA: 0x0000F85F File Offset: 0x0000DA5F
		public unsafe IntPtr native_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_native_handle)) = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06002C8F RID: 11407 RVA: 0x000E331C File Offset: 0x000E151C
		// (set) Token: 0x06002C90 RID: 11408 RVA: 0x0000F87A File Offset: 0x0000DA7A
		public unsafe IntPtr unused3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused3)) = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06002C91 RID: 11409 RVA: 0x000E3344 File Offset: 0x000E1544
		// (set) Token: 0x06002C92 RID: 11410 RVA: 0x0000F895 File Offset: 0x0000DA95
		public unsafe IntPtr name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name)) = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002C93 RID: 11411 RVA: 0x000E336C File Offset: 0x000E156C
		// (set) Token: 0x06002C94 RID: 11412 RVA: 0x0000F8B0 File Offset: 0x0000DAB0
		public unsafe int name_len
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_len);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_name_len)) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002C95 RID: 11413 RVA: 0x000E3394 File Offset: 0x000E1594
		// (set) Token: 0x06002C96 RID: 11414 RVA: 0x0000F8CB File Offset: 0x0000DACB
		public unsafe ThreadState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002C97 RID: 11415 RVA: 0x000E33BC File Offset: 0x000E15BC
		// (set) Token: 0x06002C98 RID: 11416 RVA: 0x0000F8E6 File Offset: 0x0000DAE6
		public unsafe Object abort_exc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_exc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002C99 RID: 11417 RVA: 0x000E33EC File Offset: 0x000E15EC
		// (set) Token: 0x06002C9A RID: 11418 RVA: 0x0000F905 File Offset: 0x0000DB05
		public unsafe int abort_state_handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_state_handle)) = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002C9B RID: 11419 RVA: 0x000E3414 File Offset: 0x000E1614
		// (set) Token: 0x06002C9C RID: 11420 RVA: 0x0000F920 File Offset: 0x0000DB20
		public unsafe long thread_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_id)) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002C9D RID: 11421 RVA: 0x000E343C File Offset: 0x000E163C
		// (set) Token: 0x06002C9E RID: 11422 RVA: 0x0000F93B File Offset: 0x0000DB3B
		public unsafe IntPtr debugger_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_debugger_thread)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002C9F RID: 11423 RVA: 0x000E3464 File Offset: 0x000E1664
		// (set) Token: 0x06002CA0 RID: 11424 RVA: 0x0000F956 File Offset: 0x0000DB56
		public unsafe UIntPtr static_data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_static_data)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002CA1 RID: 11425 RVA: 0x000E348C File Offset: 0x000E168C
		// (set) Token: 0x06002CA2 RID: 11426 RVA: 0x0000F971 File Offset: 0x0000DB71
		public unsafe IntPtr runtime_thread_info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_runtime_thread_info)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002CA3 RID: 11427 RVA: 0x000E34B4 File Offset: 0x000E16B4
		// (set) Token: 0x06002CA4 RID: 11428 RVA: 0x0000F98C File Offset: 0x0000DB8C
		public unsafe Object current_appcontext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_current_appcontext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002CA5 RID: 11429 RVA: 0x000E34E4 File Offset: 0x000E16E4
		// (set) Token: 0x06002CA6 RID: 11430 RVA: 0x0000F9AB File Offset: 0x0000DBAB
		public unsafe Object root_domain_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_root_domain_thread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002CA7 RID: 11431 RVA: 0x000E3514 File Offset: 0x000E1714
		// (set) Token: 0x06002CA8 RID: 11432 RVA: 0x0000F9CA File Offset: 0x0000DBCA
		public unsafe Il2CppStructArray<byte> _serialized_principal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002CA9 RID: 11433 RVA: 0x000E3544 File Offset: 0x000E1744
		// (set) Token: 0x06002CAA RID: 11434 RVA: 0x0000F9E9 File Offset: 0x0000DBE9
		public unsafe int _serialized_principal_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr__serialized_principal_version)) = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06002CAB RID: 11435 RVA: 0x000E356C File Offset: 0x000E176C
		// (set) Token: 0x06002CAC RID: 11436 RVA: 0x0000FA04 File Offset: 0x0000DC04
		public unsafe IntPtr appdomain_refs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_appdomain_refs)) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06002CAD RID: 11437 RVA: 0x000E3594 File Offset: 0x000E1794
		// (set) Token: 0x06002CAE RID: 11438 RVA: 0x0000FA1F File Offset: 0x0000DC1F
		public unsafe int interruption_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_interruption_requested)) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06002CAF RID: 11439 RVA: 0x000E35BC File Offset: 0x000E17BC
		// (set) Token: 0x06002CB0 RID: 11440 RVA: 0x0000FA3A File Offset: 0x0000DC3A
		public unsafe IntPtr synch_cs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_synch_cs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_synch_cs)) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000E35E4 File Offset: 0x000E17E4
		// (set) Token: 0x06002CB2 RID: 11442 RVA: 0x0000FA55 File Offset: 0x0000DC55
		public unsafe bool threadpool_thread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_threadpool_thread)) = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000E360C File Offset: 0x000E180C
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x0000FA70 File Offset: 0x0000DC70
		public unsafe bool thread_interrupt_requested
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_interrupt_requested)) = value;
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000E3634 File Offset: 0x000E1834
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x0000FA8B File Offset: 0x0000DC8B
		public unsafe int stack_size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_stack_size)) = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000E365C File Offset: 0x000E185C
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x0000FAA6 File Offset: 0x0000DCA6
		public unsafe byte apartment_state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_apartment_state)) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x000E3684 File Offset: 0x000E1884
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x0000FAC1 File Offset: 0x0000DCC1
		public unsafe int critical_region_level
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_critical_region_level)) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x000E36AC File Offset: 0x000E18AC
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x0000FADC File Offset: 0x0000DCDC
		public unsafe int managed_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_managed_id)) = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x000E36D4 File Offset: 0x000E18D4
		// (set) Token: 0x06002CBE RID: 11454 RVA: 0x0000FAF7 File Offset: 0x0000DCF7
		public unsafe int small_id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_small_id)) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06002CBF RID: 11455 RVA: 0x000E36FC File Offset: 0x000E18FC
		// (set) Token: 0x06002CC0 RID: 11456 RVA: 0x0000FB12 File Offset: 0x0000DD12
		public unsafe IntPtr manage_callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_manage_callback)) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06002CC1 RID: 11457 RVA: 0x000E3724 File Offset: 0x000E1924
		// (set) Token: 0x06002CC2 RID: 11458 RVA: 0x0000FB2D File Offset: 0x0000DD2D
		public unsafe IntPtr unused4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused4);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused4)) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x000E374C File Offset: 0x000E194C
		// (set) Token: 0x06002CC4 RID: 11460 RVA: 0x0000FB48 File Offset: 0x0000DD48
		public unsafe IntPtr flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x000E3774 File Offset: 0x000E1974
		// (set) Token: 0x06002CC6 RID: 11462 RVA: 0x0000FB63 File Offset: 0x0000DD63
		public unsafe IntPtr thread_pinning_ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_thread_pinning_ref)) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x000E379C File Offset: 0x000E199C
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x0000FB7E File Offset: 0x0000DD7E
		public unsafe IntPtr abort_protected_block_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_abort_protected_block_count)) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x000E37C4 File Offset: 0x000E19C4
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x0000FB99 File Offset: 0x0000DD99
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x000E37EC File Offset: 0x000E19EC
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		public unsafe IntPtr owned_mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_owned_mutex)) = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06002CCD RID: 11469 RVA: 0x000E3814 File Offset: 0x000E1A14
		// (set) Token: 0x06002CCE RID: 11470 RVA: 0x0000FBCF File Offset: 0x0000DDCF
		public unsafe IntPtr suspended_event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_suspended_event)) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002CCF RID: 11471 RVA: 0x000E383C File Offset: 0x000E1A3C
		// (set) Token: 0x06002CD0 RID: 11472 RVA: 0x0000FBEA File Offset: 0x0000DDEA
		public unsafe int self_suspended
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_self_suspended)) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002CD1 RID: 11473 RVA: 0x000E3864 File Offset: 0x000E1A64
		// (set) Token: 0x06002CD2 RID: 11474 RVA: 0x0000FC05 File Offset: 0x0000DE05
		public unsafe IntPtr unused1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused1)) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002CD3 RID: 11475 RVA: 0x000E388C File Offset: 0x000E1A8C
		// (set) Token: 0x06002CD4 RID: 11476 RVA: 0x0000FC20 File Offset: 0x0000DE20
		public unsafe IntPtr unused2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_unused2)) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x000E38B4 File Offset: 0x000E1AB4
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x0000FC3B File Offset: 0x0000DE3B
		public unsafe IntPtr last
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InternalThread.NativeFieldInfoPtr_last)) = value;
			}
		}

		// Token: 0x040026AE RID: 9902
		private static readonly IntPtr NativeFieldInfoPtr_lock_thread_id;

		// Token: 0x040026AF RID: 9903
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040026B0 RID: 9904
		private static readonly IntPtr NativeFieldInfoPtr_native_handle;

		// Token: 0x040026B1 RID: 9905
		private static readonly IntPtr NativeFieldInfoPtr_unused3;

		// Token: 0x040026B2 RID: 9906
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040026B3 RID: 9907
		private static readonly IntPtr NativeFieldInfoPtr_name_len;

		// Token: 0x040026B4 RID: 9908
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040026B5 RID: 9909
		private static readonly IntPtr NativeFieldInfoPtr_abort_exc;

		// Token: 0x040026B6 RID: 9910
		private static readonly IntPtr NativeFieldInfoPtr_abort_state_handle;

		// Token: 0x040026B7 RID: 9911
		private static readonly IntPtr NativeFieldInfoPtr_thread_id;

		// Token: 0x040026B8 RID: 9912
		private static readonly IntPtr NativeFieldInfoPtr_debugger_thread;

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeFieldInfoPtr_static_data;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeFieldInfoPtr_runtime_thread_info;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeFieldInfoPtr_current_appcontext;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeFieldInfoPtr_root_domain_thread;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeFieldInfoPtr__serialized_principal_version;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeFieldInfoPtr_appdomain_refs;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeFieldInfoPtr_interruption_requested;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeFieldInfoPtr_synch_cs;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeFieldInfoPtr_threadpool_thread;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeFieldInfoPtr_thread_interrupt_requested;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeFieldInfoPtr_stack_size;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeFieldInfoPtr_apartment_state;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeFieldInfoPtr_critical_region_level;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeFieldInfoPtr_managed_id;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeFieldInfoPtr_small_id;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeFieldInfoPtr_manage_callback;

		// Token: 0x040026CA RID: 9930
		private static readonly IntPtr NativeFieldInfoPtr_unused4;

		// Token: 0x040026CB RID: 9931
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040026CC RID: 9932
		private static readonly IntPtr NativeFieldInfoPtr_thread_pinning_ref;

		// Token: 0x040026CD RID: 9933
		private static readonly IntPtr NativeFieldInfoPtr_abort_protected_block_count;

		// Token: 0x040026CE RID: 9934
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x040026CF RID: 9935
		private static readonly IntPtr NativeFieldInfoPtr_owned_mutex;

		// Token: 0x040026D0 RID: 9936
		private static readonly IntPtr NativeFieldInfoPtr_suspended_event;

		// Token: 0x040026D1 RID: 9937
		private static readonly IntPtr NativeFieldInfoPtr_self_suspended;

		// Token: 0x040026D2 RID: 9938
		private static readonly IntPtr NativeFieldInfoPtr_unused1;

		// Token: 0x040026D3 RID: 9939
		private static readonly IntPtr NativeFieldInfoPtr_unused2;

		// Token: 0x040026D4 RID: 9940
		private static readonly IntPtr NativeFieldInfoPtr_last;

		// Token: 0x040026D5 RID: 9941
		private static readonly IntPtr NativeMethodInfoPtr_Thread_free_internal_Private_Void_0;

		// Token: 0x040026D6 RID: 9942
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040026D7 RID: 9943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
