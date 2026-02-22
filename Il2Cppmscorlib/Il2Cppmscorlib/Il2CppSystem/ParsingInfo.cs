using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem
{
	// Token: 0x020000B3 RID: 179
	public sealed class ParsingInfo : ValueType
	{
		// Token: 0x06000C9F RID: 3231 RVA: 0x0005B49C File Offset: 0x0005969C
		// Note: this type is marked as 'beforefieldinit'.
		static ParsingInfo()
		{
			Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ParsingInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr);
			ParsingInfo.NativeFieldInfoPtr_calendar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "calendar");
			ParsingInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "dayOfWeek");
			ParsingInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "timeMark");
			ParsingInfo.NativeFieldInfoPtr_fUseHour12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseHour12");
			ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fUseTwoDigitYear");
			ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowInnerWhite");
			ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fAllowTrailingWhite");
			ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "fCustomNumberParser");
			ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, "parseNumberDelegate");
			ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr, 100665410);
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0005B594 File Offset: 0x00059794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285729, RefRangeEnd = 285730, XrefRangeStart = 285729, XrefRangeEnd = 285729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParsingInfo.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000054F7 File Offset: 0x000036F7
		public ParsingInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x00005500 File Offset: 0x00003700
		public ParsingInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParsingInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x0005B5CC File Offset: 0x000597CC
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x00005512 File Offset: 0x00003712
		public unsafe Calendar calendar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Calendar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_calendar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0005B5FC File Offset: 0x000597FC
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00005531 File Offset: 0x00003731
		public unsafe int dayOfWeek
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_dayOfWeek)) = value;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0005B624 File Offset: 0x00059824
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0000554C File Offset: 0x0000374C
		public unsafe DateTimeParse.TM timeMark
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_timeMark)) = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0005B64C File Offset: 0x0005984C
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00005567 File Offset: 0x00003767
		public unsafe bool fUseHour12
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseHour12)) = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0005B674 File Offset: 0x00059874
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00005582 File Offset: 0x00003782
		public unsafe bool fUseTwoDigitYear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fUseTwoDigitYear)) = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0005B69C File Offset: 0x0005989C
		// (set) Token: 0x06000CAE RID: 3246 RVA: 0x0000559D File Offset: 0x0000379D
		public unsafe bool fAllowInnerWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowInnerWhite)) = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0005B6C4 File Offset: 0x000598C4
		// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x000055B8 File Offset: 0x000037B8
		public unsafe bool fAllowTrailingWhite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fAllowTrailingWhite)) = value;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0005B6EC File Offset: 0x000598EC
		// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x000055D3 File Offset: 0x000037D3
		public unsafe bool fCustomNumberParser
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_fCustomNumberParser)) = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x0005B714 File Offset: 0x00059914
		// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x000055EE File Offset: 0x000037EE
		public unsafe DateTimeParse.MatchNumberDelegate parseNumberDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DateTimeParse.MatchNumberDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParsingInfo.NativeFieldInfoPtr_parseNumberDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_calendar;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr_fUseHour12;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr_fUseTwoDigitYear;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr_fAllowInnerWhite;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr_fAllowTrailingWhite;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeFieldInfoPtr_fCustomNumberParser;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeFieldInfoPtr_parseNumberDelegate;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}
