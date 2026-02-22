using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000244 RID: 580
	public static class TimeSpanFormat : Object
	{
		// Token: 0x06002790 RID: 10128 RVA: 0x000D0BB4 File Offset: 0x000CEDB4
		// Note: this type is marked as 'beforefieldinit'.
		static TimeSpanFormat()
		{
			Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "TimeSpanFormat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr);
			TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "PositiveInvariantFormatLiterals");
			TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "NegativeInvariantFormatLiterals");
			TimeSpanFormat.NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669699);
			TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669700);
			TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669701);
			TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, 100669702);
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000D0C5C File Offset: 0x000CEE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327874, XrefRangeEnd = 327875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string IntToString(int n, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000D0CA4 File Offset: 0x000CEEA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 327890, RefRangeEnd = 327894, XrefRangeStart = 327875, XrefRangeEnd = 327890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(TimeSpan value, string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000D0D00 File Offset: 0x000CEF00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 327947, RefRangeEnd = 327948, XrefRangeStart = 327894, XrefRangeEnd = 327947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatStandard(TimeSpan value, bool isInvariant, string format, TimeSpanFormat.Pattern pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInvariant;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pattern;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002794 RID: 10132 RVA: 0x000D0D68 File Offset: 0x000CEF68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 328032, RefRangeEnd = 328034, XrefRangeStart = 327948, XrefRangeEnd = 328032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatCustomized(TimeSpan value, string format, DateTimeFormatInfo dtfi)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtfi);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x0000D9AD File Offset: 0x0000BBAD
		public TimeSpanFormat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000D0DC4 File Offset: 0x000CEFC4
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x0000D9B6 File Offset: 0x0000BBB6
		public unsafe static TimeSpanFormat.FormatLiterals PositiveInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_PositiveInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002798 RID: 10136 RVA: 0x000D0E00 File Offset: 0x000CF000
		// (set) Token: 0x06002799 RID: 10137 RVA: 0x0000D9CD File Offset: 0x0000BBCD
		public unsafe static TimeSpanFormat.FormatLiterals NegativeInvariantFormatLiterals
		{
			get
			{
				IntPtr intPtr = stackalloc byte[(UIntPtr)IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, (UIntPtr)0)];
				IL2CPP.il2cpp_field_static_get_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, intPtr);
				return new TimeSpanFormat.FormatLiterals(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, intPtr));
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TimeSpanFormat.NativeFieldInfoPtr_NegativeInvariantFormatLiterals, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value)));
			}
		}

		// Token: 0x04002323 RID: 8995
		private static readonly IntPtr NativeFieldInfoPtr_PositiveInvariantFormatLiterals;

		// Token: 0x04002324 RID: 8996
		private static readonly IntPtr NativeFieldInfoPtr_NegativeInvariantFormatLiterals;

		// Token: 0x04002325 RID: 8997
		private static readonly IntPtr NativeMethodInfoPtr_IntToString_Private_Static_String_Int32_Int32_0;

		// Token: 0x04002326 RID: 8998
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_TimeSpan_String_IFormatProvider_0;

		// Token: 0x04002327 RID: 8999
		private static readonly IntPtr NativeMethodInfoPtr_FormatStandard_Private_Static_String_TimeSpan_Boolean_String_Pattern_0;

		// Token: 0x04002328 RID: 9000
		private static readonly IntPtr NativeMethodInfoPtr_FormatCustomized_Internal_Static_String_TimeSpan_String_DateTimeFormatInfo_0;

		// Token: 0x020005E1 RID: 1505
		public enum Pattern
		{
			// Token: 0x04004288 RID: 17032
			None,
			// Token: 0x04004289 RID: 17033
			Minimum,
			// Token: 0x0400428A RID: 17034
			Full
		}

		// Token: 0x020005E2 RID: 1506
		public sealed class FormatLiterals : ValueType
		{
			// Token: 0x06005213 RID: 21011 RVA: 0x0016E7D0 File Offset: 0x0016C9D0
			// Note: this type is marked as 'beforefieldinit'.
			static FormatLiterals()
			{
				Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TimeSpanFormat>.NativeClassPtr, "FormatLiterals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr);
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "AppCompatLiteral");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "dd");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "hh");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "mm");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ss");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "ff");
				TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, "literals");
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669704);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669705);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669706);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669707);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669708);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669709);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669710);
				TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr, 100669711);
			}

			// Token: 0x170014F7 RID: 5367
			// (get) Token: 0x06005214 RID: 21012 RVA: 0x0016E928 File Offset: 0x0016CB28
			public unsafe string Start
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49760, RefRangeEnd = 49761, XrefRangeStart = 49760, XrefRangeEnd = 49761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_Start_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014F8 RID: 5368
			// (get) Token: 0x06005215 RID: 21013 RVA: 0x0016E964 File Offset: 0x0016CB64
			public unsafe string DayHourSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49761, RefRangeEnd = 49762, XrefRangeStart = 49761, XrefRangeEnd = 49762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014F9 RID: 5369
			// (get) Token: 0x06005216 RID: 21014 RVA: 0x0016E9A0 File Offset: 0x0016CBA0
			public unsafe string HourMinuteSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49762, RefRangeEnd = 49763, XrefRangeStart = 49762, XrefRangeEnd = 49763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014FA RID: 5370
			// (get) Token: 0x06005217 RID: 21015 RVA: 0x0016E9DC File Offset: 0x0016CBDC
			public unsafe string MinuteSecondSep
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 49763, RefRangeEnd = 49764, XrefRangeStart = 49763, XrefRangeEnd = 49764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014FB RID: 5371
			// (get) Token: 0x06005218 RID: 21016 RVA: 0x0016EA18 File Offset: 0x0016CC18
			public unsafe string SecondFractionSep
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 49764, RefRangeEnd = 49766, XrefRangeStart = 49764, XrefRangeEnd = 49766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170014FC RID: 5372
			// (get) Token: 0x06005219 RID: 21017 RVA: 0x0016EA54 File Offset: 0x0016CC54
			public unsafe string End
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 327819, RefRangeEnd = 327820, XrefRangeStart = 327819, XrefRangeEnd = 327819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_get_End_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600521A RID: 21018 RVA: 0x0016EA90 File Offset: 0x0016CC90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 327820, XrefRangeEnd = 327847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static TimeSpanFormat.FormatLiterals InitInvariant(bool isNegative)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isNegative;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return new TimeSpanFormat.FormatLiterals(intPtr);
				}
			}

			// Token: 0x0600521B RID: 21019 RVA: 0x0016EAC8 File Offset: 0x0016CCC8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 327873, RefRangeEnd = 327874, XrefRangeStart = 327847, XrefRangeEnd = 327873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init(string format, bool useInvariantFieldLengths)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useInvariantFieldLengths;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeSpanFormat.FormatLiterals.NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600521C RID: 21020 RVA: 0x0001F447 File Offset: 0x0001D647
			public FormatLiterals(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600521D RID: 21021 RVA: 0x0001F450 File Offset: 0x0001D650
			public FormatLiterals()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeSpanFormat.FormatLiterals>.NativeClassPtr))
			{
			}

			// Token: 0x170014F0 RID: 5360
			// (get) Token: 0x0600521E RID: 21022 RVA: 0x0016EB20 File Offset: 0x0016CD20
			// (set) Token: 0x0600521F RID: 21023 RVA: 0x0001F462 File Offset: 0x0001D662
			public unsafe string AppCompatLiteral
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_AppCompatLiteral), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170014F1 RID: 5361
			// (get) Token: 0x06005220 RID: 21024 RVA: 0x0016EB48 File Offset: 0x0016CD48
			// (set) Token: 0x06005221 RID: 21025 RVA: 0x0001F481 File Offset: 0x0001D681
			public unsafe int dd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_dd)) = value;
				}
			}

			// Token: 0x170014F2 RID: 5362
			// (get) Token: 0x06005222 RID: 21026 RVA: 0x0016EB70 File Offset: 0x0016CD70
			// (set) Token: 0x06005223 RID: 21027 RVA: 0x0001F49C File Offset: 0x0001D69C
			public unsafe int hh
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_hh)) = value;
				}
			}

			// Token: 0x170014F3 RID: 5363
			// (get) Token: 0x06005224 RID: 21028 RVA: 0x0016EB98 File Offset: 0x0016CD98
			// (set) Token: 0x06005225 RID: 21029 RVA: 0x0001F4B7 File Offset: 0x0001D6B7
			public unsafe int mm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_mm)) = value;
				}
			}

			// Token: 0x170014F4 RID: 5364
			// (get) Token: 0x06005226 RID: 21030 RVA: 0x0016EBC0 File Offset: 0x0016CDC0
			// (set) Token: 0x06005227 RID: 21031 RVA: 0x0001F4D2 File Offset: 0x0001D6D2
			public unsafe int ss
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ss)) = value;
				}
			}

			// Token: 0x170014F5 RID: 5365
			// (get) Token: 0x06005228 RID: 21032 RVA: 0x0016EBE8 File Offset: 0x0016CDE8
			// (set) Token: 0x06005229 RID: 21033 RVA: 0x0001F4ED File Offset: 0x0001D6ED
			public unsafe int ff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_ff)) = value;
				}
			}

			// Token: 0x170014F6 RID: 5366
			// (get) Token: 0x0600522A RID: 21034 RVA: 0x0016EC10 File Offset: 0x0016CE10
			// (set) Token: 0x0600522B RID: 21035 RVA: 0x0001F508 File Offset: 0x0001D708
			public unsafe Il2CppStringArray literals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TimeSpanFormat.FormatLiterals.NativeFieldInfoPtr_literals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400428B RID: 17035
			private static readonly IntPtr NativeFieldInfoPtr_AppCompatLiteral;

			// Token: 0x0400428C RID: 17036
			private static readonly IntPtr NativeFieldInfoPtr_dd;

			// Token: 0x0400428D RID: 17037
			private static readonly IntPtr NativeFieldInfoPtr_hh;

			// Token: 0x0400428E RID: 17038
			private static readonly IntPtr NativeFieldInfoPtr_mm;

			// Token: 0x0400428F RID: 17039
			private static readonly IntPtr NativeFieldInfoPtr_ss;

			// Token: 0x04004290 RID: 17040
			private static readonly IntPtr NativeFieldInfoPtr_ff;

			// Token: 0x04004291 RID: 17041
			private static readonly IntPtr NativeFieldInfoPtr_literals;

			// Token: 0x04004292 RID: 17042
			private static readonly IntPtr NativeMethodInfoPtr_get_Start_Internal_get_String_0;

			// Token: 0x04004293 RID: 17043
			private static readonly IntPtr NativeMethodInfoPtr_get_DayHourSep_Internal_get_String_0;

			// Token: 0x04004294 RID: 17044
			private static readonly IntPtr NativeMethodInfoPtr_get_HourMinuteSep_Internal_get_String_0;

			// Token: 0x04004295 RID: 17045
			private static readonly IntPtr NativeMethodInfoPtr_get_MinuteSecondSep_Internal_get_String_0;

			// Token: 0x04004296 RID: 17046
			private static readonly IntPtr NativeMethodInfoPtr_get_SecondFractionSep_Internal_get_String_0;

			// Token: 0x04004297 RID: 17047
			private static readonly IntPtr NativeMethodInfoPtr_get_End_Internal_get_String_0;

			// Token: 0x04004298 RID: 17048
			private static readonly IntPtr NativeMethodInfoPtr_InitInvariant_Internal_Static_FormatLiterals_Boolean_0;

			// Token: 0x04004299 RID: 17049
			private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_String_Boolean_0;
		}
	}
}
