using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000292 RID: 658
	public sealed class Timer : MarshalByRefObject
	{
		// Token: 0x06002CD7 RID: 11479 RVA: 0x000E38DC File Offset: 0x000E1ADC
		// Note: this type is marked as 'beforefieldinit'.
		static Timer()
		{
			Il2CppClassPointerStore<Timer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "Timer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer>.NativeClassPtr);
			Timer.NativeFieldInfoPtr_scheduler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "scheduler");
			Timer.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "callback");
			Timer.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "state");
			Timer.NativeFieldInfoPtr_due_time_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "due_time_ms");
			Timer.NativeFieldInfoPtr_period_ms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "period_ms");
			Timer.NativeFieldInfoPtr_next_run = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "next_run");
			Timer.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer>.NativeClassPtr, "disposed");
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670362);
			Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670363);
			Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670364);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670365);
			Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670366);
			Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670367);
			Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670368);
			Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670369);
			Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer>.NativeClassPtr, 100670370);
		}

		// Token: 0x06002CD8 RID: 11480 RVA: 0x000E3A4C File Offset: 0x000E1C4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334028, RefRangeEnd = 334030, XrefRangeStart = 334020, XrefRangeEnd = 334028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, int dueTime, int period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x000E3AC8 File Offset: 0x000E1CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 334040, RefRangeEnd = 334042, XrefRangeStart = 334030, XrefRangeEnd = 334040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Timer(TimerCallback callback, Object state, TimeSpan dueTime, TimeSpan period)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x000E3B44 File Offset: 0x000E1D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 334042, XrefRangeEnd = 334059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(TimerCallback callback, Object state, long dueTime, long period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dueTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000E3BB4 File Offset: 0x000E1DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334060, RefRangeEnd = 334061, XrefRangeStart = 334059, XrefRangeEnd = 334060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(int dueTime, int period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000E3C0C File Offset: 0x000E1E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 334064, RefRangeEnd = 334065, XrefRangeStart = 334061, XrefRangeEnd = 334064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(TimeSpan dueTime, TimeSpan period)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x000E3C64 File Offset: 0x000E1E64
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 334070, RefRangeEnd = 334076, XrefRangeStart = 334065, XrefRangeEnd = 334070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CDE RID: 11486 RVA: 0x000E3C98 File Offset: 0x000E1E98
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 334081, RefRangeEnd = 334086, XrefRangeStart = 334076, XrefRangeEnd = 334081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Change(long dueTime, long period, bool first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dueTime;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref period;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CDF RID: 11487 RVA: 0x000E3D00 File Offset: 0x000E1F00
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void KeepRootedWhileScheduled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CE0 RID: 11488 RVA: 0x000E3D34 File Offset: 0x000E1F34
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40881, RefRangeEnd = 40884, XrefRangeStart = 40881, XrefRangeEnd = 40884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long GetTimeMonotonic()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002CE1 RID: 11489 RVA: 0x0000FC56 File Offset: 0x0000DE56
		public Timer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002CE2 RID: 11490 RVA: 0x000E3D64 File Offset: 0x000E1F64
		// (set) Token: 0x06002CE3 RID: 11491 RVA: 0x0000FC5F File Offset: 0x0000DE5F
		public unsafe static Timer.Scheduler scheduler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Timer.NativeFieldInfoPtr_scheduler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Timer.NativeFieldInfoPtr_scheduler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002CE4 RID: 11492 RVA: 0x000E3D8C File Offset: 0x000E1F8C
		// (set) Token: 0x06002CE5 RID: 11493 RVA: 0x0000FC71 File Offset: 0x0000DE71
		public unsafe TimerCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002CE6 RID: 11494 RVA: 0x000E3DBC File Offset: 0x000E1FBC
		// (set) Token: 0x06002CE7 RID: 11495 RVA: 0x0000FC90 File Offset: 0x0000DE90
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000E3DEC File Offset: 0x000E1FEC
		// (set) Token: 0x06002CE9 RID: 11497 RVA: 0x0000FCAF File Offset: 0x0000DEAF
		public unsafe long due_time_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_due_time_ms)) = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002CEA RID: 11498 RVA: 0x000E3E14 File Offset: 0x000E2014
		// (set) Token: 0x06002CEB RID: 11499 RVA: 0x0000FCCA File Offset: 0x0000DECA
		public unsafe long period_ms
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_period_ms)) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002CEC RID: 11500 RVA: 0x000E3E3C File Offset: 0x000E203C
		// (set) Token: 0x06002CED RID: 11501 RVA: 0x0000FCE5 File Offset: 0x0000DEE5
		public unsafe long next_run
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_next_run)) = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002CEE RID: 11502 RVA: 0x000E3E64 File Offset: 0x000E2064
		// (set) Token: 0x06002CEF RID: 11503 RVA: 0x0000FD00 File Offset: 0x0000DF00
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x040026D8 RID: 9944
		private static readonly IntPtr NativeFieldInfoPtr_scheduler;

		// Token: 0x040026D9 RID: 9945
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x040026DA RID: 9946
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040026DB RID: 9947
		private static readonly IntPtr NativeFieldInfoPtr_due_time_ms;

		// Token: 0x040026DC RID: 9948
		private static readonly IntPtr NativeFieldInfoPtr_period_ms;

		// Token: 0x040026DD RID: 9949
		private static readonly IntPtr NativeFieldInfoPtr_next_run;

		// Token: 0x040026DE RID: 9950
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x040026DF RID: 9951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_Int32_Int32_0;

		// Token: 0x040026E0 RID: 9952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TimerCallback_Object_TimeSpan_TimeSpan_0;

		// Token: 0x040026E1 RID: 9953
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_TimerCallback_Object_Int64_Int64_0;

		// Token: 0x040026E2 RID: 9954
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_Int32_Int32_0;

		// Token: 0x040026E3 RID: 9955
		private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x040026E4 RID: 9956
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040026E5 RID: 9957
		private static readonly IntPtr NativeMethodInfoPtr_Change_Private_Boolean_Int64_Int64_Boolean_0;

		// Token: 0x040026E6 RID: 9958
		private static readonly IntPtr NativeMethodInfoPtr_KeepRootedWhileScheduled_Internal_Void_0;

		// Token: 0x040026E7 RID: 9959
		private static readonly IntPtr NativeMethodInfoPtr_GetTimeMonotonic_Private_Static_Int64_0;

		// Token: 0x020005F6 RID: 1526
		public sealed class TimerComparer : Object
		{
			// Token: 0x060052AA RID: 21162 RVA: 0x0017057C File Offset: 0x0016E77C
			// Note: this type is marked as 'beforefieldinit'.
			static TimerComparer()
			{
				Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "TimerComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr);
				Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100670372);
				Timer.TimerComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr, 100670373);
			}

			// Token: 0x060052AB RID: 21163 RVA: 0x001705D0 File Offset: 0x0016E7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333803, XrefRangeEnd = 333805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060052AC RID: 21164 RVA: 0x00170630 File Offset: 0x0016E830
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimerComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer.TimerComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.TimerComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052AD RID: 21165 RVA: 0x0001F9B7 File Offset: 0x0001DBB7
			public TimerComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040042F8 RID: 17144
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x040042F9 RID: 17145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020005F7 RID: 1527
		public sealed class Scheduler : Object
		{
			// Token: 0x060052AE RID: 21166 RVA: 0x0017066C File Offset: 0x0016E86C
			// Note: this type is marked as 'beforefieldinit'.
			static Scheduler()
			{
				Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Timer>.NativeClassPtr, "Scheduler");
				Timer.Scheduler.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "instance");
				Timer.Scheduler.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "list");
				Timer.Scheduler.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, "changed");
				Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670375);
				Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670376);
				Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670377);
				Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670378);
				Timer.Scheduler.NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670379);
				Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670380);
				Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670381);
				Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670382);
				Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670383);
				Timer.Scheduler.NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr, 100670384);
			}

			// Token: 0x17001520 RID: 5408
			// (get) Token: 0x060052AF RID: 21167 RVA: 0x00170794 File Offset: 0x0016E994
			public unsafe static Timer.Scheduler Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333805, XrefRangeEnd = 333809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr3) : null;
				}
			}

			// Token: 0x060052B0 RID: 21168 RVA: 0x001707C8 File Offset: 0x0016E9C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333809, XrefRangeEnd = 333835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Scheduler()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Timer.Scheduler>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B1 RID: 21169 RVA: 0x00170804 File Offset: 0x0016EA04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333839, RefRangeEnd = 333840, XrefRangeStart = 333835, XrefRangeEnd = 333839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Remove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Remove_Public_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052B2 RID: 21170 RVA: 0x00170848 File Offset: 0x0016EA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333840, XrefRangeEnd = 333846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Change(Timer timer, long new_next_run)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref new_next_run;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B3 RID: 21171 RVA: 0x00170898 File Offset: 0x0016EA98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333848, RefRangeEnd = 333849, XrefRangeStart = 333846, XrefRangeEnd = 333848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int FindByDueTime(long nr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref nr;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052B4 RID: 21172 RVA: 0x001708E4 File Offset: 0x0016EAE4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 333854, RefRangeEnd = 333856, XrefRangeStart = 333849, XrefRangeEnd = 333854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_Add_Private_Void_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052B5 RID: 21173 RVA: 0x00170928 File Offset: 0x0016EB28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 333856, RefRangeEnd = 333857, XrefRangeStart = 333856, XrefRangeEnd = 333856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int InternalRemove(Timer timer)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(timer);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060052B6 RID: 21174 RVA: 0x00170978 File Offset: 0x0016EB78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333857, XrefRangeEnd = 333891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void TimerCB(Object o)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060052B7 RID: 21175 RVA: 0x001709B0 File Offset: 0x0016EBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333891, XrefRangeEnd = 334012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SchedulerThread()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_SchedulerThread_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B8 RID: 21176 RVA: 0x001709E4 File Offset: 0x0016EBE4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 334019, RefRangeEnd = 334020, XrefRangeStart = 334012, XrefRangeEnd = 334019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ShrinkIfNeeded(List<Timer> list, int initial)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initial;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Timer.Scheduler.NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060052B9 RID: 21177 RVA: 0x0001F9C0 File Offset: 0x0001DBC0
			public Scheduler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700151D RID: 5405
			// (get) Token: 0x060052BA RID: 21178 RVA: 0x00170A34 File Offset: 0x0016EC34
			// (set) Token: 0x060052BB RID: 21179 RVA: 0x0001F9C9 File Offset: 0x0001DBC9
			public unsafe static Timer.Scheduler instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Timer.Scheduler.NativeFieldInfoPtr_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Timer.Scheduler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Timer.Scheduler.NativeFieldInfoPtr_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700151E RID: 5406
			// (get) Token: 0x060052BC RID: 21180 RVA: 0x00170A5C File Offset: 0x0016EC5C
			// (set) Token: 0x060052BD RID: 21181 RVA: 0x0001F9DB File Offset: 0x0001DBDB
			public unsafe SortedList list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SortedList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700151F RID: 5407
			// (get) Token: 0x060052BE RID: 21182 RVA: 0x00170A8C File Offset: 0x0016EC8C
			// (set) Token: 0x060052BF RID: 21183 RVA: 0x0001F9FA File Offset: 0x0001DBFA
			public unsafe ManualResetEvent changed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Timer.Scheduler.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040042FA RID: 17146
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x040042FB RID: 17147
			private static readonly IntPtr NativeFieldInfoPtr_list;

			// Token: 0x040042FC RID: 17148
			private static readonly IntPtr NativeFieldInfoPtr_changed;

			// Token: 0x040042FD RID: 17149
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Scheduler_0;

			// Token: 0x040042FE RID: 17150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

			// Token: 0x040042FF RID: 17151
			private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_Timer_0;

			// Token: 0x04004300 RID: 17152
			private static readonly IntPtr NativeMethodInfoPtr_Change_Public_Void_Timer_Int64_0;

			// Token: 0x04004301 RID: 17153
			private static readonly IntPtr NativeMethodInfoPtr_FindByDueTime_Private_Int32_Int64_0;

			// Token: 0x04004302 RID: 17154
			private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_Timer_0;

			// Token: 0x04004303 RID: 17155
			private static readonly IntPtr NativeMethodInfoPtr_InternalRemove_Private_Int32_Timer_0;

			// Token: 0x04004304 RID: 17156
			private static readonly IntPtr NativeMethodInfoPtr_TimerCB_Private_Static_Void_Object_0;

			// Token: 0x04004305 RID: 17157
			private static readonly IntPtr NativeMethodInfoPtr_SchedulerThread_Private_Void_0;

			// Token: 0x04004306 RID: 17158
			private static readonly IntPtr NativeMethodInfoPtr_ShrinkIfNeeded_Private_Void_List_1_Timer_Int32_0;
		}
	}
}
