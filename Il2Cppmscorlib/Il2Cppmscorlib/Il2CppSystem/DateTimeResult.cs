using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000B2 RID: 178
	public sealed class DateTimeResult : ValueType
	{
		// Token: 0x06000C78 RID: 3192 RVA: 0x0005AED0 File Offset: 0x000590D0
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeResult()
		{
			Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr);
			DateTimeResult.NativeFieldInfoPtr_Year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Year");
			DateTimeResult.NativeFieldInfoPtr_Month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Month");
			DateTimeResult.NativeFieldInfoPtr_Day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Day");
			DateTimeResult.NativeFieldInfoPtr_Hour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Hour");
			DateTimeResult.NativeFieldInfoPtr_Minute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Minute");
			DateTimeResult.NativeFieldInfoPtr_Second = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "Second");
			DateTimeResult.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "fraction");
			DateTimeResult.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "era");
			DateTimeResult.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "flags");
			DateTimeResult.NativeFieldInfoPtr_timeZoneOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "timeZoneOffset");
			DateTimeResult.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "calendar");
			DateTimeResult.NativeFieldInfoPtr_parsedDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "parsedDate");
			DateTimeResult.NativeFieldInfoPtr_failure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failure");
			DateTimeResult.NativeFieldInfoPtr_failureMessageID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageID");
			DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureMessageFormatArgument");
			DateTimeResult.NativeFieldInfoPtr_failureArgumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, "failureArgumentName");
			DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665406);
			DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665407);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665408);
			DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr, 100665409);
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x0005B090 File Offset: 0x00059290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 285689, RefRangeEnd = 285696, XrefRangeStart = 285689, XrefRangeEnd = 285689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x0005B0C8 File Offset: 0x000592C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67362, RefRangeEnd = 67363, XrefRangeStart = 67362, XrefRangeEnd = 67363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDate(int year, int month, int day)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref year;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref month;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref day;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0005B128 File Offset: 0x00059328
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 285696, RefRangeEnd = 285727, XrefRangeStart = 285696, XrefRangeEnd = 285696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0005B190 File Offset: 0x00059390
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 285727, RefRangeEnd = 285729, XrefRangeStart = 285727, XrefRangeEnd = 285727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFailure(ParseFailureKind failure, string failureMessageID, Object failureMessageFormatArgument, string failureArgumentName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref failure;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureMessageID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(failureMessageFormatArgument);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(failureArgumentName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeResult.NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000531C File Offset: 0x0000351C
		public DateTimeResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00005325 File Offset: 0x00003525
		public DateTimeResult()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DateTimeResult>.NativeClassPtr))
		{
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000C7F RID: 3199 RVA: 0x0005B20C File Offset: 0x0005940C
		// (set) Token: 0x06000C80 RID: 3200 RVA: 0x00005337 File Offset: 0x00003537
		public unsafe int Year
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Year)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0005B234 File Offset: 0x00059434
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x00005352 File Offset: 0x00003552
		public unsafe int Month
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Month)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0005B25C File Offset: 0x0005945C
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x0000536D File Offset: 0x0000356D
		public unsafe int Day
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Day)) = value;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000C85 RID: 3205 RVA: 0x0005B284 File Offset: 0x00059484
		// (set) Token: 0x06000C86 RID: 3206 RVA: 0x00005388 File Offset: 0x00003588
		public unsafe int Hour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Hour)) = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x0005B2AC File Offset: 0x000594AC
		// (set) Token: 0x06000C88 RID: 3208 RVA: 0x000053A3 File Offset: 0x000035A3
		public unsafe int Minute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Minute)) = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000C89 RID: 3209 RVA: 0x0005B2D4 File Offset: 0x000594D4
		// (set) Token: 0x06000C8A RID: 3210 RVA: 0x000053BE File Offset: 0x000035BE
		public unsafe int Second
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_Second)) = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000C8B RID: 3211 RVA: 0x0005B2FC File Offset: 0x000594FC
		// (set) Token: 0x06000C8C RID: 3212 RVA: 0x000053D9 File Offset: 0x000035D9
		public unsafe double fraction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_fraction)) = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000C8D RID: 3213 RVA: 0x0005B324 File Offset: 0x00059524
		// (set) Token: 0x06000C8E RID: 3214 RVA: 0x000053F4 File Offset: 0x000035F4
		public unsafe int era
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_era)) = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0005B34C File Offset: 0x0005954C
		// (set) Token: 0x06000C90 RID: 3216 RVA: 0x0000540F File Offset: 0x0000360F
		public unsafe ParseFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000C91 RID: 3217 RVA: 0x0005B374 File Offset: 0x00059574
		// (set) Token: 0x06000C92 RID: 3218 RVA: 0x0000542A File Offset: 0x0000362A
		public unsafe TimeSpan timeZoneOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_timeZoneOffset)) = value;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000C93 RID: 3219 RVA: 0x0005B39C File Offset: 0x0005959C
		// (set) Token: 0x06000C94 RID: 3220 RVA: 0x00005445 File Offset: 0x00003645
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x0005B3CC File Offset: 0x000595CC
		// (set) Token: 0x06000C96 RID: 3222 RVA: 0x00005464 File Offset: 0x00003664
		public unsafe DateTime parsedDate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_parsedDate)) = value;
			}
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06000C97 RID: 3223 RVA: 0x0005B3F4 File Offset: 0x000595F4
		// (set) Token: 0x06000C98 RID: 3224 RVA: 0x0000547F File Offset: 0x0000367F
		public unsafe ParseFailureKind failure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failure)) = value;
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0005B41C File Offset: 0x0005961C
		// (set) Token: 0x06000C9A RID: 3226 RVA: 0x0000549A File Offset: 0x0000369A
		public unsafe string failureMessageID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000C9B RID: 3227 RVA: 0x0005B444 File Offset: 0x00059644
		// (set) Token: 0x06000C9C RID: 3228 RVA: 0x000054B9 File Offset: 0x000036B9
		public unsafe Object failureMessageFormatArgument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureMessageFormatArgument), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0005B474 File Offset: 0x00059674
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000054D8 File Offset: 0x000036D8
		public unsafe string failureArgumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DateTimeResult.NativeFieldInfoPtr_failureArgumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A8C RID: 2700
		private static readonly IntPtr NativeFieldInfoPtr_Year;

		// Token: 0x04000A8D RID: 2701
		private static readonly IntPtr NativeFieldInfoPtr_Month;

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_Day;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_Hour;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_Minute;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_Second;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_timeZoneOffset;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_parsedDate;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_failure;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageID;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_failureMessageFormatArgument;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_failureArgumentName;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeMethodInfoPtr_SetDate_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_0;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeMethodInfoPtr_SetFailure_Internal_Void_ParseFailureKind_String_Object_String_0;
	}
}
