using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x020000C8 RID: 200
	public static class Math : Object
	{
		// Token: 0x06000D99 RID: 3481 RVA: 0x0005FE2C File Offset: 0x0005E02C
		// Note: this type is marked as 'beforefieldinit'.
		static Math()
		{
			Il2CppClassPointerStore<Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Math>.NativeClassPtr);
			Math.NativeFieldInfoPtr_doubleRoundLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "doubleRoundLimit");
			Math.NativeFieldInfoPtr_maxRoundingDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "maxRoundingDigits");
			Math.NativeFieldInfoPtr_roundPower10Double = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "roundPower10Double");
			Math.NativeFieldInfoPtr_PI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "PI");
			Math.NativeFieldInfoPtr_E = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Math>.NativeClassPtr, "E");
			Math.NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665588);
			Math.NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665589);
			Math.NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665590);
			Math.NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665591);
			Math.NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665592);
			Math.NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665593);
			Math.NativeMethodInfoPtr_InternalTruncate_Private_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665594);
			Math.NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665595);
			Math.NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665596);
			Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665597);
			Math.NativeMethodInfoPtr_SplitFractionDouble_Private_Static_Double_ptr_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665598);
			Math.NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665599);
			Math.NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665600);
			Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665601);
			Math.NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665602);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665603);
			Math.NativeMethodInfoPtr_AbsHelper_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665604);
			Math.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665605);
			Math.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665606);
			Math.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665607);
			Math.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665608);
			Math.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665609);
			Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Math>.NativeClassPtr, 100665610);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x0006008C File Offset: 0x0005E28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288215, XrefRangeEnd = 288216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Acos(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x000600CC File Offset: 0x0005E2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288216, XrefRangeEnd = 288217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Asin(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x0006010C File Offset: 0x0005E30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288217, XrefRangeEnd = 288218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Atan(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x0006014C File Offset: 0x0005E34C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288218, XrefRangeEnd = 288219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Ceiling(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x0006018C File Offset: 0x0005E38C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288219, XrefRangeEnd = 288220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Cos(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000601CC File Offset: 0x0005E3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288220, XrefRangeEnd = 288221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Floor(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x0006020C File Offset: 0x0005E40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288221, XrefRangeEnd = 288225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double InternalTruncate(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_InternalTruncate_Private_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x0006024C File Offset: 0x0005E44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288225, XrefRangeEnd = 288226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Sin(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0006028C File Offset: 0x0005E48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288226, XrefRangeEnd = 288227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Tan(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000602CC File Offset: 0x0005E4CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288227, XrefRangeEnd = 288228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Round(double a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Round_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x0006030C File Offset: 0x0005E50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288228, XrefRangeEnd = 288229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double SplitFractionDouble(double* value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_SplitFractionDouble_Private_Static_Double_ptr_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00060348 File Offset: 0x0005E548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288237, RefRangeEnd = 288238, XrefRangeStart = 288229, XrefRangeEnd = 288237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Truncate(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00060388 File Offset: 0x0005E588
		[CallerCount(0)]
		public unsafe static double Sqrt(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000603C8 File Offset: 0x0005E5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288238, XrefRangeEnd = 288239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Log(double d)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00060408 File Offset: 0x0005E608
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288240, RefRangeEnd = 288246, XrefRangeStart = 288239, XrefRangeEnd = 288240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Pow(double x, double y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00060454 File Offset: 0x0005E654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 288246, XrefRangeEnd = 288249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00060494 File Offset: 0x0005E694
		[CallerCount(0)]
		public unsafe static int AbsHelper(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_AbsHelper_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x000604D4 File Offset: 0x0005E6D4
		[CallerCount(0)]
		public unsafe static float Abs(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00060514 File Offset: 0x0005E714
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 288249, RefRangeEnd = 288274, XrefRangeStart = 288249, XrefRangeEnd = 288249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Max(int val1, int val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00060560 File Offset: 0x0005E760
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 288275, RefRangeEnd = 288282, XrefRangeStart = 288274, XrefRangeEnd = 288275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Max(float val1, float val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000605AC File Offset: 0x0005E7AC
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 288282, RefRangeEnd = 288338, XrefRangeStart = 288282, XrefRangeEnd = 288282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Min(int val1, int val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000605F8 File Offset: 0x0005E7F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 288339, RefRangeEnd = 288345, XrefRangeStart = 288338, XrefRangeEnd = 288339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Min(float val1, float val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00060644 File Offset: 0x0005E844
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288360, RefRangeEnd = 288361, XrefRangeStart = 288345, XrefRangeEnd = 288360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double Log(double a, double newBase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newBase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Math.NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0000588E File Offset: 0x00003A8E
		public Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x00060690 File Offset: 0x0005E890
		// (set) Token: 0x06000DB3 RID: 3507 RVA: 0x00005897 File Offset: 0x00003A97
		public unsafe static double doubleRoundLimit
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_doubleRoundLimit, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_doubleRoundLimit, (void*)(&value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x000606AC File Offset: 0x0005E8AC
		// (set) Token: 0x06000DB5 RID: 3509 RVA: 0x000058A5 File Offset: 0x00003AA5
		public unsafe static int maxRoundingDigits
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_maxRoundingDigits, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_maxRoundingDigits, (void*)(&value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000DB6 RID: 3510 RVA: 0x000606C8 File Offset: 0x0005E8C8
		// (set) Token: 0x06000DB7 RID: 3511 RVA: 0x000058B3 File Offset: 0x00003AB3
		public unsafe static Il2CppStructArray<double> roundPower10Double
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_roundPower10Double, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_roundPower10Double, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x000606F0 File Offset: 0x0005E8F0
		// (set) Token: 0x06000DB9 RID: 3513 RVA: 0x000058C5 File Offset: 0x00003AC5
		public unsafe static double PI
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_PI, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_PI, (void*)(&value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000DBA RID: 3514 RVA: 0x0006070C File Offset: 0x0005E90C
		// (set) Token: 0x06000DBB RID: 3515 RVA: 0x000058D3 File Offset: 0x00003AD3
		public unsafe static double E
		{
			get
			{
				double num;
				IL2CPP.il2cpp_field_static_get_value(Math.NativeFieldInfoPtr_E, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Math.NativeFieldInfoPtr_E, (void*)(&value));
			}
		}

		// Token: 0x04000B9B RID: 2971
		private static readonly IntPtr NativeFieldInfoPtr_doubleRoundLimit;

		// Token: 0x04000B9C RID: 2972
		private static readonly IntPtr NativeFieldInfoPtr_maxRoundingDigits;

		// Token: 0x04000B9D RID: 2973
		private static readonly IntPtr NativeFieldInfoPtr_roundPower10Double;

		// Token: 0x04000B9E RID: 2974
		private static readonly IntPtr NativeFieldInfoPtr_PI;

		// Token: 0x04000B9F RID: 2975
		private static readonly IntPtr NativeFieldInfoPtr_E;

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Double_Double_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_Asin_Public_Static_Double_Double_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Double_Double_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_Ceiling_Public_Static_Double_Double_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Double_Double_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Double_Double_0;

		// Token: 0x04000BA6 RID: 2982
		private static readonly IntPtr NativeMethodInfoPtr_InternalTruncate_Private_Static_Double_Double_0;

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Double_Double_0;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Double_Double_0;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Double_Double_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_SplitFractionDouble_Private_Static_Double_ptr_Double_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_Truncate_Public_Static_Double_Double_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Double_Double_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Double_Double_Double_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr_AbsHelper_Private_Static_Int32_Int32_0;

		// Token: 0x04000BB1 RID: 2993
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04000BB2 RID: 2994
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000BB3 RID: 2995
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Double_Double_Double_0;
	}
}
