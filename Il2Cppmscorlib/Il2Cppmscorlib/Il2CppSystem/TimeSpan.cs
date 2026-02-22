using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000F2 RID: 242
	[Serializable]
	[StructLayout(2)]
	public struct TimeSpan
	{
		// Token: 0x060010B0 RID: 4272 RVA: 0x0006F768 File Offset: 0x0006D968
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpan()
		{
			Il2CppClassPointerStore<TimeSpan>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TimeSpan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr);
			TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerMillisecond");
			TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisecondsPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerSecond");
			TimeSpan.NativeFieldInfoPtr_SecondsPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "SecondsPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerMinute");
			TimeSpan.NativeFieldInfoPtr_MinutesPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinutesPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerHour");
			TimeSpan.NativeFieldInfoPtr_HoursPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "HoursPerTick");
			TimeSpan.NativeFieldInfoPtr_TicksPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerDay");
			TimeSpan.NativeFieldInfoPtr_DaysPerTick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "DaysPerTick");
			TimeSpan.NativeFieldInfoPtr_MillisPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerSecond");
			TimeSpan.NativeFieldInfoPtr_MillisPerMinute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerMinute");
			TimeSpan.NativeFieldInfoPtr_MillisPerHour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerHour");
			TimeSpan.NativeFieldInfoPtr_MillisPerDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MillisPerDay");
			TimeSpan.NativeFieldInfoPtr_MaxSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxSeconds");
			TimeSpan.NativeFieldInfoPtr_MinSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinSeconds");
			TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxMilliSeconds");
			TimeSpan.NativeFieldInfoPtr_MinMilliSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinMilliSeconds");
			TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "TicksPerTenthSecond");
			TimeSpan.NativeFieldInfoPtr_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "Zero");
			TimeSpan.NativeFieldInfoPtr_MaxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MaxValue");
			TimeSpan.NativeFieldInfoPtr_MinValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "MinValue");
			TimeSpan.NativeFieldInfoPtr__ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_ticks");
			TimeSpan.NativeFieldInfoPtr__legacyConfigChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_legacyConfigChecked");
			TimeSpan.NativeFieldInfoPtr__legacyMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, "_legacyMode");
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666165);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666166);
			TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666167);
			TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666168);
			TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666169);
			TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666170);
			TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666171);
			TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666172);
			TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666173);
			TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666174);
			TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666175);
			TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666176);
			TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666177);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666178);
			TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666179);
			TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666180);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666181);
			TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666182);
			TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666183);
			TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666184);
			TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666185);
			TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666186);
			TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666187);
			TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666188);
			TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666189);
			TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666190);
			TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666191);
			TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666192);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666193);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666194);
			TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666195);
			TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666196);
			TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666197);
			TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666198);
			TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666199);
			TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666200);
			TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666201);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666202);
			TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666203);
			TimeSpan.NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666204);
			TimeSpan.NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, 100666205);
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0006FCC0 File Offset: 0x0006DEC0
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19565, RefRangeEnd = 19577, XrefRangeStart = 19565, XrefRangeEnd = 19577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(long ticks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ticks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0006FCF4 File Offset: 0x0006DEF4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 298357, RefRangeEnd = 298385, XrefRangeStart = 298354, XrefRangeEnd = 298357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int hours, int minutes, int seconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hours;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0006FD44 File Offset: 0x0006DF44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298385, RefRangeEnd = 298387, XrefRangeStart = 298385, XrefRangeEnd = 298385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hours;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minutes;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref milliseconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x060010B4 RID: 4276 RVA: 0x0006FDB0 File Offset: 0x0006DFB0
		public unsafe long Ticks
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0006FDE0 File Offset: 0x0006DFE0
		public unsafe int Hours
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 298387, RefRangeEnd = 298391, XrefRangeStart = 298387, XrefRangeEnd = 298387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Hours_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060010B6 RID: 4278 RVA: 0x0006FE10 File Offset: 0x0006E010
		public unsafe int Minutes
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 298391, RefRangeEnd = 298395, XrefRangeStart = 298391, XrefRangeEnd = 298391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0006FE40 File Offset: 0x0006E040
		public unsafe double TotalDays
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 298395, RefRangeEnd = 298396, XrefRangeStart = 298395, XrefRangeEnd = 298395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060010B8 RID: 4280 RVA: 0x0006FE70 File Offset: 0x0006E070
		public unsafe double TotalHours
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0006FEA0 File Offset: 0x0006E0A0
		public unsafe double TotalMilliseconds
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 298396, RefRangeEnd = 298406, XrefRangeStart = 298396, XrefRangeEnd = 298396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x0006FED0 File Offset: 0x0006E0D0
		public unsafe double TotalMinutes
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 298406, RefRangeEnd = 298408, XrefRangeStart = 298406, XrefRangeEnd = 298406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x0006FF00 File Offset: 0x0006E100
		public unsafe double TotalSeconds
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 298408, RefRangeEnd = 298414, XrefRangeStart = 298408, XrefRangeEnd = 298408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0006FF30 File Offset: 0x0006E130
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 298414, RefRangeEnd = 298422, XrefRangeStart = 298414, XrefRangeEnd = 298414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Add(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0006FF70 File Offset: 0x0006E170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298422, RefRangeEnd = 298424, XrefRangeStart = 298422, XrefRangeEnd = 298422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0006FFBC File Offset: 0x0006E1BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298427, RefRangeEnd = 298428, XrefRangeStart = 298424, XrefRangeEnd = 298427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x00070000 File Offset: 0x0006E200
		[CallerCount(0)]
		public unsafe int CompareTo(TimeSpan value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00070040 File Offset: 0x0006E240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 298432, RefRangeEnd = 298435, XrefRangeStart = 298428, XrefRangeEnd = 298432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromDays(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x00070080 File Offset: 0x0006E280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298435, XrefRangeEnd = 298438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000700C4 File Offset: 0x0006E2C4
		[CallerCount(0)]
		public unsafe bool Equals(TimeSpan obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00070104 File Offset: 0x0006E304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286804, RefRangeEnd = 286805, XrefRangeStart = 286804, XrefRangeEnd = 286805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00070134 File Offset: 0x0006E334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298438, XrefRangeEnd = 298442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromHours(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00070174 File Offset: 0x0006E374
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298447, RefRangeEnd = 298452, XrefRangeStart = 298442, XrefRangeEnd = 298447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan Interval(double value, int scale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x000701C0 File Offset: 0x0006E3C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 298456, RefRangeEnd = 298459, XrefRangeStart = 298452, XrefRangeEnd = 298456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMilliseconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00070200 File Offset: 0x0006E400
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298463, RefRangeEnd = 298467, XrefRangeStart = 298459, XrefRangeEnd = 298463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromMinutes(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x00070240 File Offset: 0x0006E440
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 298471, RefRangeEnd = 298474, XrefRangeStart = 298467, XrefRangeEnd = 298471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Negate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Negate_Public_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00070270 File Offset: 0x0006E470
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298478, RefRangeEnd = 298479, XrefRangeStart = 298474, XrefRangeEnd = 298478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromSeconds(double value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x000702B0 File Offset: 0x0006E4B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298479, RefRangeEnd = 298481, XrefRangeStart = 298479, XrefRangeEnd = 298479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan Subtract(TimeSpan ts)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x000702F0 File Offset: 0x0006E4F0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan FromTicks(long value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010CC RID: 4300 RVA: 0x00070330 File Offset: 0x0006E530
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 298481, RefRangeEnd = 298484, XrefRangeStart = 298481, XrefRangeEnd = 298481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long TimeToTicks(int hour, int minute, int second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hour;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minute;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref second;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x0007038C File Offset: 0x0006E58C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298484, XrefRangeEnd = 298488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000703B8 File Offset: 0x0006E5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298488, XrefRangeEnd = 298492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_String_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000703F4 File Offset: 0x0006E5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298492, XrefRangeEnd = 298523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x00070444 File Offset: 0x0006E644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298523, XrefRangeEnd = 298524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator -(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x00070490 File Offset: 0x0006E690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298524, XrefRangeEnd = 298525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TimeSpan operator +(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000704DC File Offset: 0x0006E6DC
		[CallerCount(1128)]
		[CachedScanResults(RefRangeStart = 16551, RefRangeEnd = 17679, XrefRangeStart = 16551, XrefRangeEnd = 17679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00070528 File Offset: 0x0006E728
		[CallerCount(209)]
		[CachedScanResults(RefRangeStart = 210425, RefRangeEnd = 210634, XrefRangeStart = 210425, XrefRangeEnd = 210634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00070574 File Offset: 0x0006E774
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298525, RefRangeEnd = 298527, XrefRangeStart = 298525, XrefRangeEnd = 298525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x000705C0 File Offset: 0x0006E7C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298527, RefRangeEnd = 298528, XrefRangeStart = 298527, XrefRangeEnd = 298527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x0007060C File Offset: 0x0006E80C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298528, RefRangeEnd = 298529, XrefRangeStart = 298528, XrefRangeEnd = 298528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x00070658 File Offset: 0x0006E858
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298529, RefRangeEnd = 298530, XrefRangeStart = 298529, XrefRangeEnd = 298529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(TimeSpan t1, TimeSpan t2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x000706A4 File Offset: 0x0006E8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298530, XrefRangeEnd = 298532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetLegacyFormatMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x060010D9 RID: 4313 RVA: 0x000706D4 File Offset: 0x0006E8D4
		public unsafe static bool LegacyMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298532, XrefRangeEnd = 298549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpan.NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0000617D File Offset: 0x0000437D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpan>.NativeClassPtr, ref this));
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060010DB RID: 4315 RVA: 0x00070704 File Offset: 0x0006E904
		// (set) Token: 0x060010DC RID: 4316 RVA: 0x0000618F File Offset: 0x0000438F
		public unsafe static long TicksPerMillisecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerMillisecond, (void*)(&value));
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060010DD RID: 4317 RVA: 0x00070720 File Offset: 0x0006E920
		// (set) Token: 0x060010DE RID: 4318 RVA: 0x0000619D File Offset: 0x0000439D
		public unsafe static double MillisecondsPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisecondsPerTick, (void*)(&value));
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060010DF RID: 4319 RVA: 0x0007073C File Offset: 0x0006E93C
		// (set) Token: 0x060010E0 RID: 4320 RVA: 0x000061AB File Offset: 0x000043AB
		public unsafe static long TicksPerSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060010E1 RID: 4321 RVA: 0x00070758 File Offset: 0x0006E958
		// (set) Token: 0x060010E2 RID: 4322 RVA: 0x000061B9 File Offset: 0x000043B9
		public unsafe static double SecondsPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_SecondsPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_SecondsPerTick, (void*)(&value));
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x060010E3 RID: 4323 RVA: 0x00070774 File Offset: 0x0006E974
		// (set) Token: 0x060010E4 RID: 4324 RVA: 0x000061C7 File Offset: 0x000043C7
		public unsafe static long TicksPerMinute
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x060010E5 RID: 4325 RVA: 0x00070790 File Offset: 0x0006E990
		// (set) Token: 0x060010E6 RID: 4326 RVA: 0x000061D5 File Offset: 0x000043D5
		public unsafe static double MinutesPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinutesPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinutesPerTick, (void*)(&value));
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x060010E7 RID: 4327 RVA: 0x000707AC File Offset: 0x0006E9AC
		// (set) Token: 0x060010E8 RID: 4328 RVA: 0x000061E3 File Offset: 0x000043E3
		public unsafe static long TicksPerHour
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerHour, (void*)(&value));
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x060010E9 RID: 4329 RVA: 0x000707C8 File Offset: 0x0006E9C8
		// (set) Token: 0x060010EA RID: 4330 RVA: 0x000061F1 File Offset: 0x000043F1
		public unsafe static double HoursPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_HoursPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_HoursPerTick, (void*)(&value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x060010EB RID: 4331 RVA: 0x000707E4 File Offset: 0x0006E9E4
		// (set) Token: 0x060010EC RID: 4332 RVA: 0x000061FF File Offset: 0x000043FF
		public unsafe static long TicksPerDay
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerDay, (void*)(&value));
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00070800 File Offset: 0x0006EA00
		// (set) Token: 0x060010EE RID: 4334 RVA: 0x0000620D File Offset: 0x0000440D
		public unsafe static double DaysPerTick
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_DaysPerTick, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_DaysPerTick, (void*)(&value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x060010EF RID: 4335 RVA: 0x0007081C File Offset: 0x0006EA1C
		// (set) Token: 0x060010F0 RID: 4336 RVA: 0x0000621B File Offset: 0x0000441B
		public unsafe static int MillisPerSecond
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerSecond, (void*)(&value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x060010F1 RID: 4337 RVA: 0x00070838 File Offset: 0x0006EA38
		// (set) Token: 0x060010F2 RID: 4338 RVA: 0x00006229 File Offset: 0x00004429
		public unsafe static int MillisPerMinute
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerMinute, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerMinute, (void*)(&value));
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x00070854 File Offset: 0x0006EA54
		// (set) Token: 0x060010F4 RID: 4340 RVA: 0x00006237 File Offset: 0x00004437
		public unsafe static int MillisPerHour
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerHour, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerHour, (void*)(&value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x060010F5 RID: 4341 RVA: 0x00070870 File Offset: 0x0006EA70
		// (set) Token: 0x060010F6 RID: 4342 RVA: 0x00006245 File Offset: 0x00004445
		public unsafe static int MillisPerDay
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MillisPerDay, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MillisPerDay, (void*)(&value));
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0007088C File Offset: 0x0006EA8C
		// (set) Token: 0x060010F8 RID: 4344 RVA: 0x00006253 File Offset: 0x00004453
		public unsafe static long MaxSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxSeconds, (void*)(&value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x000708A8 File Offset: 0x0006EAA8
		// (set) Token: 0x060010FA RID: 4346 RVA: 0x00006261 File Offset: 0x00004461
		public unsafe static long MinSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinSeconds, (void*)(&value));
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x000708C4 File Offset: 0x0006EAC4
		// (set) Token: 0x060010FC RID: 4348 RVA: 0x0000626F File Offset: 0x0000446F
		public unsafe static long MaxMilliSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxMilliSeconds, (void*)(&value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x000708E0 File Offset: 0x0006EAE0
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0000627D File Offset: 0x0000447D
		public unsafe static long MinMilliSeconds
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinMilliSeconds, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinMilliSeconds, (void*)(&value));
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x000708FC File Offset: 0x0006EAFC
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0000628B File Offset: 0x0000448B
		public unsafe static long TicksPerTenthSecond
		{
			get
			{
				long num;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_TicksPerTenthSecond, (void*)(&value));
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x00070918 File Offset: 0x0006EB18
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x00006299 File Offset: 0x00004499
		public unsafe static TimeSpan Zero
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_Zero, (void*)(&value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x00070934 File Offset: 0x0006EB34
		// (set) Token: 0x06001104 RID: 4356 RVA: 0x000062A7 File Offset: 0x000044A7
		public unsafe static TimeSpan MaxValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MaxValue, (void*)(&value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x00070950 File Offset: 0x0006EB50
		// (set) Token: 0x06001106 RID: 4358 RVA: 0x000062B5 File Offset: 0x000044B5
		public unsafe static TimeSpan MinValue
		{
			get
			{
				TimeSpan timeSpan;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&timeSpan));
				return timeSpan;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr_MinValue, (void*)(&value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0007096C File Offset: 0x0006EB6C
		// (set) Token: 0x06001108 RID: 4360 RVA: 0x000062C3 File Offset: 0x000044C3
		public unsafe static bool _legacyConfigChecked
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr__legacyConfigChecked, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr__legacyConfigChecked, (void*)(&value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00070988 File Offset: 0x0006EB88
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x000062D1 File Offset: 0x000044D1
		public unsafe static bool _legacyMode
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(TimeSpan.NativeFieldInfoPtr__legacyMode, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpan.NativeFieldInfoPtr__legacyMode, (void*)(&value));
			}
		}

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMillisecond;

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr_MillisecondsPerTick;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerSecond;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr_SecondsPerTick;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerMinute;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeFieldInfoPtr_MinutesPerTick;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerHour;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeFieldInfoPtr_HoursPerTick;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerDay;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeFieldInfoPtr_DaysPerTick;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerSecond;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerMinute;

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerHour;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_MillisPerDay;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_MaxSeconds;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_MinSeconds;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_MaxMilliSeconds;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_MinMilliSeconds;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeFieldInfoPtr_TicksPerTenthSecond;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeFieldInfoPtr_Zero;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeFieldInfoPtr_MaxValue;

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeFieldInfoPtr_MinValue;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr__ticks;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeFieldInfoPtr__legacyConfigChecked;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeFieldInfoPtr__legacyMode;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

		// Token: 0x04000E93 RID: 3731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000E94 RID: 3732
		private static readonly IntPtr NativeMethodInfoPtr_get_Ticks_Public_get_Int64_0;

		// Token: 0x04000E95 RID: 3733
		private static readonly IntPtr NativeMethodInfoPtr_get_Hours_Public_get_Int32_0;

		// Token: 0x04000E96 RID: 3734
		private static readonly IntPtr NativeMethodInfoPtr_get_Minutes_Public_get_Int32_0;

		// Token: 0x04000E97 RID: 3735
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalDays_Public_get_Double_0;

		// Token: 0x04000E98 RID: 3736
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalHours_Public_get_Double_0;

		// Token: 0x04000E99 RID: 3737
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMilliseconds_Public_get_Double_0;

		// Token: 0x04000E9A RID: 3738
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalMinutes_Public_get_Double_0;

		// Token: 0x04000E9B RID: 3739
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalSeconds_Public_get_Double_0;

		// Token: 0x04000E9C RID: 3740
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000E9D RID: 3741
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_TimeSpan_TimeSpan_0;

		// Token: 0x04000E9E RID: 3742
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000E9F RID: 3743
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TimeSpan_0;

		// Token: 0x04000EA0 RID: 3744
		private static readonly IntPtr NativeMethodInfoPtr_FromDays_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EA1 RID: 3745
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000EA2 RID: 3746
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TimeSpan_0;

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeMethodInfoPtr_FromHours_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr_Interval_Private_Static_TimeSpan_Double_Int32_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_FromMilliseconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_FromMinutes_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_Negate_Public_TimeSpan_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_FromSeconds_Public_Static_TimeSpan_Double_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_TimeSpan_TimeSpan_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_FromTicks_Public_Static_TimeSpan_Int64_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_TimeToTicks_Internal_Static_Int64_Int32_Int32_Int32_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_String_0;

		// Token: 0x04000EAF RID: 3759
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000EB0 RID: 3760
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB1 RID: 3761
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_TimeSpan_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB2 RID: 3762
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB3 RID: 3763
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB4 RID: 3764
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB5 RID: 3765
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB6 RID: 3766
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB7 RID: 3767
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_TimeSpan_TimeSpan_0;

		// Token: 0x04000EB8 RID: 3768
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyFormatMode_Private_Static_Boolean_0;

		// Token: 0x04000EB9 RID: 3769
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyMode_Private_Static_get_Boolean_0;

		// Token: 0x04000EBA RID: 3770
		[FieldOffset(0)]
		public long _ticks;
	}
}
