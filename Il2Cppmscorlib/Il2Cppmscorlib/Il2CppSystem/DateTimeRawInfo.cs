using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000AF RID: 175
	[StructLayout(2)]
	public struct DateTimeRawInfo
	{
		// Token: 0x06000C73 RID: 3187 RVA: 0x0005ACF4 File Offset: 0x00058EF4
		// Note: this type is marked as 'beforefieldinit'.
		static DateTimeRawInfo()
		{
			Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DateTimeRawInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr);
			DateTimeRawInfo.NativeFieldInfoPtr_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "num");
			DateTimeRawInfo.NativeFieldInfoPtr_numCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "numCount");
			DateTimeRawInfo.NativeFieldInfoPtr_month = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "month");
			DateTimeRawInfo.NativeFieldInfoPtr_year = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "year");
			DateTimeRawInfo.NativeFieldInfoPtr_dayOfWeek = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "dayOfWeek");
			DateTimeRawInfo.NativeFieldInfoPtr_era = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "era");
			DateTimeRawInfo.NativeFieldInfoPtr_timeMark = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeMark");
			DateTimeRawInfo.NativeFieldInfoPtr_fraction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "fraction");
			DateTimeRawInfo.NativeFieldInfoPtr_hasSameDateAndTimeSeparators = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "hasSameDateAndTimeSeparators");
			DateTimeRawInfo.NativeFieldInfoPtr_timeZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, "timeZone");
			DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665403);
			DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665404);
			DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, 100665405);
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0005AE28 File Offset: 0x00059028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 285644, RefRangeEnd = 285645, XrefRangeStart = 285644, XrefRangeEnd = 285644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(int* numberBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = numberBuffer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x0005AE5C File Offset: 0x0005905C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 285645, RefRangeEnd = 285652, XrefRangeStart = 285645, XrefRangeEnd = 285645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNumber(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x0005AE90 File Offset: 0x00059090
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 285652, RefRangeEnd = 285689, XrefRangeStart = 285652, XrefRangeEnd = 285652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetNumber(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DateTimeRawInfo.NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x0000530A File Offset: 0x0000350A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DateTimeRawInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000A5F RID: 2655
		private static readonly IntPtr NativeFieldInfoPtr_num;

		// Token: 0x04000A60 RID: 2656
		private static readonly IntPtr NativeFieldInfoPtr_numCount;

		// Token: 0x04000A61 RID: 2657
		private static readonly IntPtr NativeFieldInfoPtr_month;

		// Token: 0x04000A62 RID: 2658
		private static readonly IntPtr NativeFieldInfoPtr_year;

		// Token: 0x04000A63 RID: 2659
		private static readonly IntPtr NativeFieldInfoPtr_dayOfWeek;

		// Token: 0x04000A64 RID: 2660
		private static readonly IntPtr NativeFieldInfoPtr_era;

		// Token: 0x04000A65 RID: 2661
		private static readonly IntPtr NativeFieldInfoPtr_timeMark;

		// Token: 0x04000A66 RID: 2662
		private static readonly IntPtr NativeFieldInfoPtr_fraction;

		// Token: 0x04000A67 RID: 2663
		private static readonly IntPtr NativeFieldInfoPtr_hasSameDateAndTimeSeparators;

		// Token: 0x04000A68 RID: 2664
		private static readonly IntPtr NativeFieldInfoPtr_timeZone;

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_ptr_Int32_0;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeMethodInfoPtr_AddNumber_Internal_Void_Int32_0;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeMethodInfoPtr_GetNumber_Internal_Int32_Int32_0;

		// Token: 0x04000A6C RID: 2668
		[FieldOffset(0)]
		public IntPtr num;

		// Token: 0x04000A6D RID: 2669
		[FieldOffset(8)]
		public int numCount;

		// Token: 0x04000A6E RID: 2670
		[FieldOffset(12)]
		public int month;

		// Token: 0x04000A6F RID: 2671
		[FieldOffset(16)]
		public int year;

		// Token: 0x04000A70 RID: 2672
		[FieldOffset(20)]
		public int dayOfWeek;

		// Token: 0x04000A71 RID: 2673
		[FieldOffset(24)]
		public int era;

		// Token: 0x04000A72 RID: 2674
		[FieldOffset(28)]
		public DateTimeParse.TM timeMark;

		// Token: 0x04000A73 RID: 2675
		[FieldOffset(32)]
		public double fraction;

		// Token: 0x04000A74 RID: 2676
		[FieldOffset(40)]
		[MarshalAs(4)]
		public bool hasSameDateAndTimeSeparators;

		// Token: 0x04000A75 RID: 2677
		[FieldOffset(41)]
		[MarshalAs(4)]
		public bool timeZone;
	}
}
