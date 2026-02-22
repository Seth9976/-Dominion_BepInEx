using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UTNotifications
{
	// Token: 0x020000FA RID: 250
	public sealed class TimeUtils : Object
	{
		// Token: 0x06001E0F RID: 7695 RVA: 0x000763BC File Offset: 0x000745BC
		// Note: this type is marked as 'beforefieldinit'.
		static TimeUtils()
		{
			Il2CppClassPointerStore<TimeUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UTNotifications", "TimeUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr);
			TimeUtils.NativeMethodInfoPtr_ToSecondsFromNow_Public_Static_Int32_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665782);
			TimeUtils.NativeMethodInfoPtr_MinutesToSeconds_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665783);
			TimeUtils.NativeMethodInfoPtr_HoursToSeconds_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665784);
			TimeUtils.NativeMethodInfoPtr_DaysToSeconds_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665785);
			TimeUtils.NativeMethodInfoPtr_WeeksToSeconds_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665786);
			TimeUtils.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr, 100665787);
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00076464 File Offset: 0x00074664
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255533, RefRangeEnd = 255535, XrefRangeStart = 255527, XrefRangeEnd = 255533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ToSecondsFromNow(DateTime dateTime)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dateTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr_ToSecondsFromNow_Public_Static_Int32_DateTime_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x000764A4 File Offset: 0x000746A4
		[CallerCount(0)]
		public unsafe static int MinutesToSeconds(int minutes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minutes;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr_MinutesToSeconds_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x000764E4 File Offset: 0x000746E4
		[CallerCount(0)]
		public unsafe static int HoursToSeconds(int hours)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hours;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr_HoursToSeconds_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00076524 File Offset: 0x00074724
		[CallerCount(0)]
		public unsafe static int DaysToSeconds(int days)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref days;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr_DaysToSeconds_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00076564 File Offset: 0x00074764
		[CallerCount(0)]
		public unsafe static int WeeksToSeconds(int weeks)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref weeks;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr_WeeksToSeconds_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x000765A4 File Offset: 0x000747A4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeUtils()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeUtils>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TimeUtils.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x00012C2F File Offset: 0x00010E2F
		public TimeUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeMethodInfoPtr_ToSecondsFromNow_Public_Static_Int32_DateTime_0;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeMethodInfoPtr_MinutesToSeconds_Public_Static_Int32_Int32_0;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_HoursToSeconds_Public_Static_Int32_Int32_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_DaysToSeconds_Public_Static_Int32_Int32_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_WeeksToSeconds_Public_Static_Int32_Int32_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
