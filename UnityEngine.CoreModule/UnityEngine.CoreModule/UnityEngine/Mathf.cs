using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	[StructLayout(2)]
	public struct Mathf
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x00039E34 File Offset: 0x00038034
		// Note: this type is marked as 'beforefieldinit'.
		static Mathf()
		{
			Il2CppClassPointerStore<Mathf>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Mathf");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Mathf>.NativeClassPtr);
			Mathf.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Mathf>.NativeClassPtr, "Epsilon");
			Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664106);
			Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664107);
			Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664108);
			Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664109);
			Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664110);
			Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664111);
			Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664112);
			Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664113);
			Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664114);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664115);
			Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664116);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664117);
			Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664118);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664119);
			Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664120);
			Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664121);
			Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664122);
			Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664123);
			Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664124);
			Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664125);
			Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664126);
			Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664127);
			Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664128);
			Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664129);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664130);
			Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664131);
			Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664132);
			Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664133);
			Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664134);
			Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664135);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664136);
			Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664137);
			Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664138);
			Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664139);
			Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664140);
			Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664141);
			Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664142);
			Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Mathf>.NativeClassPtr, 100664143);
			Mathf.ClosestPowerOfTwoDelegateField = IL2CPP.ResolveICall<Mathf.ClosestPowerOfTwoDelegate>("UnityEngine.Mathf::ClosestPowerOfTwo");
			Mathf.IsPowerOfTwoDelegateField = IL2CPP.ResolveICall<Mathf.IsPowerOfTwoDelegate>("UnityEngine.Mathf::IsPowerOfTwo");
			Mathf.LinearToGammaSpaceDelegateField = IL2CPP.ResolveICall<Mathf.LinearToGammaSpaceDelegate>("UnityEngine.Mathf::LinearToGammaSpace");
			Mathf.FloatToHalfDelegateField = IL2CPP.ResolveICall<Mathf.FloatToHalfDelegate>("UnityEngine.Mathf::FloatToHalf");
			Mathf.HalfToFloatDelegateField = IL2CPP.ResolveICall<Mathf.HalfToFloatDelegate>("UnityEngine.Mathf::HalfToFloat");
			Mathf.PerlinNoiseDelegateField = IL2CPP.ResolveICall<Mathf.PerlinNoiseDelegate>("UnityEngine.Mathf::PerlinNoise");
			Mathf.CorrelatedColorTemperatureToRGB_InjectedDelegateField = IL2CPP.ResolveICall<Mathf.CorrelatedColorTemperatureToRGB_InjectedDelegate>("UnityEngine.Mathf::CorrelatedColorTemperatureToRGB_Injected");
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x0003A1DC File Offset: 0x000383DC
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 66255, RefRangeEnd = 66279, XrefRangeStart = 66253, XrefRangeEnd = 66255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int NextPowerOfTwo(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0003A21C File Offset: 0x0003841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66279, XrefRangeEnd = 66281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GammaToLinearSpace(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x0003A25C File Offset: 0x0003845C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66281, XrefRangeEnd = 66285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sin(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003A29C File Offset: 0x0003849C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66285, XrefRangeEnd = 66289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Cos(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x0003A2DC File Offset: 0x000384DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66289, XrefRangeEnd = 66293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Tan(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x0003A31C File Offset: 0x0003851C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66293, XrefRangeEnd = 66297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Asin(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x0003A35C File Offset: 0x0003855C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66297, XrefRangeEnd = 66301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Acos(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0003A39C File Offset: 0x0003859C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66301, XrefRangeEnd = 66305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Atan(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003A3DC File Offset: 0x000385DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66305, XrefRangeEnd = 66308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sqrt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x0003A41C File Offset: 0x0003861C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66308, XrefRangeEnd = 66311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Abs(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x0003A45C File Offset: 0x0003865C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66314, RefRangeEnd = 66316, XrefRangeStart = 66311, XrefRangeEnd = 66314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Abs(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x0003A49C File Offset: 0x0003869C
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 66316, RefRangeEnd = 66405, XrefRangeStart = 66316, XrefRangeEnd = 66316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Min(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x0003A4E8 File Offset: 0x000386E8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 66405, RefRangeEnd = 66430, XrefRangeStart = 66405, XrefRangeEnd = 66405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Min(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0003A534 File Offset: 0x00038734
		[CallerCount(136)]
		[CachedScanResults(RefRangeStart = 66430, RefRangeEnd = 66566, XrefRangeStart = 66430, XrefRangeEnd = 66430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Max(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0003A580 File Offset: 0x00038780
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 66566, RefRangeEnd = 66598, XrefRangeStart = 66566, XrefRangeEnd = 66566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Max(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0003A5CC File Offset: 0x000387CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66598, XrefRangeEnd = 66602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Pow(float f, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x0003A618 File Offset: 0x00038818
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66606, RefRangeEnd = 66608, XrefRangeStart = 66602, XrefRangeEnd = 66606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Log(float f, float p)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref p;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x0003A664 File Offset: 0x00038864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66608, XrefRangeEnd = 66612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Ceil(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x0003A6A4 File Offset: 0x000388A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66612, XrefRangeEnd = 66616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Floor(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x0003A6E4 File Offset: 0x000388E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66616, XrefRangeEnd = 66620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Round(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Round_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x0003A724 File Offset: 0x00038924
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66624, RefRangeEnd = 66630, XrefRangeStart = 66620, XrefRangeEnd = 66624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CeilToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x0003A764 File Offset: 0x00038964
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 66634, RefRangeEnd = 66650, XrefRangeStart = 66630, XrefRangeEnd = 66634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FloorToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x0003A7A4 File Offset: 0x000389A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 66654, RefRangeEnd = 66662, XrefRangeStart = 66650, XrefRangeEnd = 66654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RoundToInt(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x0003A7E4 File Offset: 0x000389E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66662, RefRangeEnd = 66665, XrefRangeStart = 66662, XrefRangeEnd = 66662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Sign(float f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x0003A824 File Offset: 0x00038A24
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 66665, RefRangeEnd = 66721, XrefRangeStart = 66665, XrefRangeEnd = 66665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Clamp(float value, float min, float max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x0003A880 File Offset: 0x00038A80
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 66721, RefRangeEnd = 66767, XrefRangeStart = 66721, XrefRangeEnd = 66721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Clamp(int value, int min, int max)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003A8DC File Offset: 0x00038ADC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 66767, RefRangeEnd = 66795, XrefRangeStart = 66767, XrefRangeEnd = 66767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Clamp01(float value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x0003A91C File Offset: 0x00038B1C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 66795, RefRangeEnd = 66819, XrefRangeStart = 66795, XrefRangeEnd = 66795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Lerp(float a, float b, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003A978 File Offset: 0x00038B78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66820, RefRangeEnd = 66821, XrefRangeStart = 66819, XrefRangeEnd = 66820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothStep(float from, float to, float t)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003A9D4 File Offset: 0x00038BD4
		[CallerCount(42)]
		[CachedScanResults(RefRangeStart = 66823, RefRangeEnd = 66865, XrefRangeStart = 66821, XrefRangeEnd = 66823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x0003AA20 File Offset: 0x00038C20
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 66867, RefRangeEnd = 66887, XrefRangeStart = 66865, XrefRangeEnd = 66867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x0003AA88 File Offset: 0x00038C88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 66889, RefRangeEnd = 66893, XrefRangeStart = 66887, XrefRangeEnd = 66889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x0003AB0C File Offset: 0x00038D0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 66897, RefRangeEnd = 66903, XrefRangeStart = 66893, XrefRangeEnd = 66897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x0003AB74 File Offset: 0x00038D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66903, XrefRangeEnd = 66906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &currentVelocity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref smoothTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxSpeed;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x0003ABF8 File Offset: 0x00038DF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 66907, RefRangeEnd = 66909, XrefRangeStart = 66906, XrefRangeEnd = 66907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float Repeat(float t, float length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0003AC44 File Offset: 0x00038E44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 66911, RefRangeEnd = 66912, XrefRangeStart = 66909, XrefRangeEnd = 66911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float PingPong(float t, float length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref t;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0003AC90 File Offset: 0x00038E90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 66912, RefRangeEnd = 66915, XrefRangeStart = 66912, XrefRangeEnd = 66912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float InverseLerp(float a, float b, float value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0003ACEC File Offset: 0x00038EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66915, XrefRangeEnd = 66917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float DeltaAngle(float current, float target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref current;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref target;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Mathf.NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000095B2 File Offset: 0x000077B2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Mathf>.NativeClassPtr, ref this));
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x0003AD38 File Offset: 0x00038F38
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x000095C4 File Offset: 0x000077C4
		public unsafe static float Epsilon
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Mathf.NativeFieldInfoPtr_Epsilon, (void*)(&value));
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000095D2 File Offset: 0x000077D2
		public static int ClosestPowerOfTwo(int value)
		{
			return Mathf.ClosestPowerOfTwoDelegateField(value);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000095DF File Offset: 0x000077DF
		public static bool IsPowerOfTwo(int value)
		{
			return Mathf.IsPowerOfTwoDelegateField(value);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x000095EC File Offset: 0x000077EC
		public static float LinearToGammaSpace(float value)
		{
			return Mathf.LinearToGammaSpaceDelegateField(value);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0003AD54 File Offset: 0x00038F54
		public static Color CorrelatedColorTemperatureToRGB(float kelvin)
		{
			Color color;
			Mathf.CorrelatedColorTemperatureToRGB_Injected(kelvin, out color);
			return color;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000095F9 File Offset: 0x000077F9
		public static ushort FloatToHalf(float val)
		{
			return Mathf.FloatToHalfDelegateField(val);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00009606 File Offset: 0x00007806
		public static float HalfToFloat(ushort val)
		{
			return Mathf.HalfToFloatDelegateField(val);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00009613 File Offset: 0x00007813
		public static float PerlinNoise(float x, float y)
		{
			return Mathf.PerlinNoiseDelegateField(x, y);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0003AD6C File Offset: 0x00038F6C
		public static float Atan2(float y, float x)
		{
			return (float)Math.Atan2((double)y, (double)x);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0003AD88 File Offset: 0x00038F88
		public static float Min(Il2CppStructArray<float> values)
		{
			int num = values.Length;
			bool flag = num == 0;
			float num2;
			if (flag)
			{
				num2 = 0f;
			}
			else
			{
				float num3 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] < num3;
					if (flag2)
					{
						num3 = values[i];
					}
				}
				num2 = num3;
			}
			return num2;
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00009621 File Offset: 0x00007821
		public static float Min(params float[] values)
		{
			return Mathf.Min(new Il2CppStructArray<float>(values));
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0000962E File Offset: 0x0000782E
		public static int Min(Il2CppStructArray<int> values)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000963B File Offset: 0x0000783B
		public static int Min(params int[] values)
		{
			return Mathf.Min(new Il2CppStructArray<int>(values));
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0003ADF0 File Offset: 0x00038FF0
		public static float Max(Il2CppStructArray<float> values)
		{
			int num = values.Length;
			bool flag = num == 0;
			float num2;
			if (flag)
			{
				num2 = 0f;
			}
			else
			{
				float num3 = values[0];
				for (int i = 1; i < num; i++)
				{
					bool flag2 = values[i] > num3;
					if (flag2)
					{
						num3 = values[i];
					}
				}
				num2 = num3;
			}
			return num2;
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00009648 File Offset: 0x00007848
		public static float Max(params float[] values)
		{
			return Mathf.Max(new Il2CppStructArray<float>(values));
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00009655 File Offset: 0x00007855
		public static int Max(Il2CppStructArray<int> values)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x00009662 File Offset: 0x00007862
		public static int Max(params int[] values)
		{
			return Mathf.Max(new Il2CppStructArray<int>(values));
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0003AE58 File Offset: 0x00039058
		public static float Exp(float power)
		{
			return (float)Math.Exp((double)power);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003AE74 File Offset: 0x00039074
		public static float Log(float f)
		{
			return (float)Math.Log((double)f);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0003AE90 File Offset: 0x00039090
		public static float Log10(float f)
		{
			return (float)Math.Log10((double)f);
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0003AEAC File Offset: 0x000390AC
		public static float LerpUnclamped(float a, float b, float t)
		{
			return a + (b - a) * t;
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0003AEC8 File Offset: 0x000390C8
		public static float LerpAngle(float a, float b, float t)
		{
			float num = Mathf.Repeat(b - a, 360f);
			bool flag = num > 180f;
			if (flag)
			{
				num -= 360f;
			}
			return a + num * Mathf.Clamp01(t);
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x0003AF08 File Offset: 0x00039108
		public static float MoveTowards(float current, float target, float maxDelta)
		{
			bool flag = Mathf.Abs(target - current) <= maxDelta;
			float num;
			if (flag)
			{
				num = target;
			}
			else
			{
				num = current + Mathf.Sign(target - current) * maxDelta;
			}
			return num;
		}

		// Token: 0x06000DEB RID: 3563 RVA: 0x0003AF3C File Offset: 0x0003913C
		public static float MoveTowardsAngle(float current, float target, float maxDelta)
		{
			float num = Mathf.DeltaAngle(current, target);
			bool flag = -maxDelta < num && num < maxDelta;
			float num2;
			if (flag)
			{
				num2 = target;
			}
			else
			{
				target = current + num;
				num2 = Mathf.MoveTowards(current, target, maxDelta);
			}
			return num2;
		}

		// Token: 0x06000DEC RID: 3564 RVA: 0x0003AF78 File Offset: 0x00039178
		public static float Gamma(float value, float absmax, float gamma)
		{
			bool flag = value < 0f;
			float num = Mathf.Abs(value);
			bool flag2 = num > absmax;
			float num2;
			if (flag2)
			{
				num2 = (flag ? (-num) : num);
			}
			else
			{
				float num3 = Mathf.Pow(num / absmax, gamma) * absmax;
				num2 = (flag ? (-num3) : num3);
			}
			return num2;
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0003AFC4 File Offset: 0x000391C4
		public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06000DEE RID: 3566 RVA: 0x0003AFE8 File Offset: 0x000391E8
		public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed)
		{
			float deltaTime = Time.deltaTime;
			return Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);
		}

		// Token: 0x06000DEF RID: 3567 RVA: 0x0003B00C File Offset: 0x0003920C
		public static bool LineIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				result.x = p1.x + num8 * num;
				result.y = p1.y + num8 * num2;
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x06000DF0 RID: 3568 RVA: 0x0003B0C8 File Offset: 0x000392C8
		public static bool LineSegmentIntersection(Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, ref Vector2 result)
		{
			float num = p2.x - p1.x;
			float num2 = p2.y - p1.y;
			float num3 = p4.x - p3.x;
			float num4 = p4.y - p3.y;
			float num5 = num * num4 - num2 * num3;
			bool flag = num5 == 0f;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				float num6 = p3.x - p1.x;
				float num7 = p3.y - p1.y;
				float num8 = (num6 * num4 - num7 * num3) / num5;
				bool flag3 = num8 < 0f || num8 > 1f;
				if (flag3)
				{
					flag2 = false;
				}
				else
				{
					float num9 = (num6 * num2 - num7 * num) / num5;
					bool flag4 = num9 < 0f || num9 > 1f;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						result.x = p1.x + num8 * num;
						result.y = p1.y + num8 * num2;
						flag2 = true;
					}
				}
			}
			return flag2;
		}

		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000966F File Offset: 0x0000786F
		public static long RandomToLong(Random r)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0000967C File Offset: 0x0000787C
		public static void CorrelatedColorTemperatureToRGB_Injected(float kelvin, out Color ret)
		{
			Mathf.CorrelatedColorTemperatureToRGB_InjectedDelegateField(kelvin, out ret);
		}

		// Token: 0x04000ADF RID: 2783
		private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

		// Token: 0x04000AE0 RID: 2784
		private static readonly IntPtr NativeMethodInfoPtr_NextPowerOfTwo_Public_Static_Int32_Int32_0;

		// Token: 0x04000AE1 RID: 2785
		private static readonly IntPtr NativeMethodInfoPtr_GammaToLinearSpace_Public_Static_Single_Single_0;

		// Token: 0x04000AE2 RID: 2786
		private static readonly IntPtr NativeMethodInfoPtr_Sin_Public_Static_Single_Single_0;

		// Token: 0x04000AE3 RID: 2787
		private static readonly IntPtr NativeMethodInfoPtr_Cos_Public_Static_Single_Single_0;

		// Token: 0x04000AE4 RID: 2788
		private static readonly IntPtr NativeMethodInfoPtr_Tan_Public_Static_Single_Single_0;

		// Token: 0x04000AE5 RID: 2789
		private static readonly IntPtr NativeMethodInfoPtr_Asin_Public_Static_Single_Single_0;

		// Token: 0x04000AE6 RID: 2790
		private static readonly IntPtr NativeMethodInfoPtr_Acos_Public_Static_Single_Single_0;

		// Token: 0x04000AE7 RID: 2791
		private static readonly IntPtr NativeMethodInfoPtr_Atan_Public_Static_Single_Single_0;

		// Token: 0x04000AE8 RID: 2792
		private static readonly IntPtr NativeMethodInfoPtr_Sqrt_Public_Static_Single_Single_0;

		// Token: 0x04000AE9 RID: 2793
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Single_Single_0;

		// Token: 0x04000AEA RID: 2794
		private static readonly IntPtr NativeMethodInfoPtr_Abs_Public_Static_Int32_Int32_0;

		// Token: 0x04000AEB RID: 2795
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Single_Single_Single_0;

		// Token: 0x04000AEC RID: 2796
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000AED RID: 2797
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Single_Single_Single_0;

		// Token: 0x04000AEE RID: 2798
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Int32_Int32_Int32_0;

		// Token: 0x04000AEF RID: 2799
		private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_Static_Single_Single_Single_0;

		// Token: 0x04000AF0 RID: 2800
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Single_Single_Single_0;

		// Token: 0x04000AF1 RID: 2801
		private static readonly IntPtr NativeMethodInfoPtr_Ceil_Public_Static_Single_Single_0;

		// Token: 0x04000AF2 RID: 2802
		private static readonly IntPtr NativeMethodInfoPtr_Floor_Public_Static_Single_Single_0;

		// Token: 0x04000AF3 RID: 2803
		private static readonly IntPtr NativeMethodInfoPtr_Round_Public_Static_Single_Single_0;

		// Token: 0x04000AF4 RID: 2804
		private static readonly IntPtr NativeMethodInfoPtr_CeilToInt_Public_Static_Int32_Single_0;

		// Token: 0x04000AF5 RID: 2805
		private static readonly IntPtr NativeMethodInfoPtr_FloorToInt_Public_Static_Int32_Single_0;

		// Token: 0x04000AF6 RID: 2806
		private static readonly IntPtr NativeMethodInfoPtr_RoundToInt_Public_Static_Int32_Single_0;

		// Token: 0x04000AF7 RID: 2807
		private static readonly IntPtr NativeMethodInfoPtr_Sign_Public_Static_Single_Single_0;

		// Token: 0x04000AF8 RID: 2808
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000AF9 RID: 2809
		private static readonly IntPtr NativeMethodInfoPtr_Clamp_Public_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000AFA RID: 2810
		private static readonly IntPtr NativeMethodInfoPtr_Clamp01_Public_Static_Single_Single_0;

		// Token: 0x04000AFB RID: 2811
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000AFC RID: 2812
		private static readonly IntPtr NativeMethodInfoPtr_SmoothStep_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000AFD RID: 2813
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x04000AFE RID: 2814
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_0;

		// Token: 0x04000AFF RID: 2815
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDamp_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x04000B00 RID: 2816
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_0;

		// Token: 0x04000B01 RID: 2817
		private static readonly IntPtr NativeMethodInfoPtr_SmoothDampAngle_Public_Static_Single_Single_Single_byref_Single_Single_Single_Single_0;

		// Token: 0x04000B02 RID: 2818
		private static readonly IntPtr NativeMethodInfoPtr_Repeat_Public_Static_Single_Single_Single_0;

		// Token: 0x04000B03 RID: 2819
		private static readonly IntPtr NativeMethodInfoPtr_PingPong_Public_Static_Single_Single_Single_0;

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_InverseLerp_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_DeltaAngle_Public_Static_Single_Single_Single_0;

		// Token: 0x04000B06 RID: 2822
		public const float PI = 3.1415927f;

		// Token: 0x04000B07 RID: 2823
		public const float Infinity = float.PositiveInfinity;

		// Token: 0x04000B08 RID: 2824
		public const float NegativeInfinity = float.NegativeInfinity;

		// Token: 0x04000B09 RID: 2825
		public const float Deg2Rad = 0.017453292f;

		// Token: 0x04000B0A RID: 2826
		public const float Rad2Deg = 57.29578f;

		// Token: 0x04000B0B RID: 2827
		private static readonly Mathf.ClosestPowerOfTwoDelegate ClosestPowerOfTwoDelegateField;

		// Token: 0x04000B0C RID: 2828
		private static readonly Mathf.IsPowerOfTwoDelegate IsPowerOfTwoDelegateField;

		// Token: 0x04000B0D RID: 2829
		private static readonly Mathf.LinearToGammaSpaceDelegate LinearToGammaSpaceDelegateField;

		// Token: 0x04000B0E RID: 2830
		private static readonly Mathf.FloatToHalfDelegate FloatToHalfDelegateField;

		// Token: 0x04000B0F RID: 2831
		private static readonly Mathf.HalfToFloatDelegate HalfToFloatDelegateField;

		// Token: 0x04000B10 RID: 2832
		private static readonly Mathf.PerlinNoiseDelegate PerlinNoiseDelegateField;

		// Token: 0x04000B11 RID: 2833
		private static readonly Mathf.CorrelatedColorTemperatureToRGB_InjectedDelegate CorrelatedColorTemperatureToRGB_InjectedDelegateField;

		// Token: 0x02000752 RID: 1874
		// (Invoke) Token: 0x06002C67 RID: 11367
		private delegate int ClosestPowerOfTwoDelegate(int value);

		// Token: 0x02000753 RID: 1875
		// (Invoke) Token: 0x06002C69 RID: 11369
		private delegate bool IsPowerOfTwoDelegate(int value);

		// Token: 0x02000754 RID: 1876
		// (Invoke) Token: 0x06002C6B RID: 11371
		private delegate float LinearToGammaSpaceDelegate(float value);

		// Token: 0x02000755 RID: 1877
		// (Invoke) Token: 0x06002C6D RID: 11373
		private delegate ushort FloatToHalfDelegate(float val);

		// Token: 0x02000756 RID: 1878
		// (Invoke) Token: 0x06002C6F RID: 11375
		private delegate float HalfToFloatDelegate(ushort val);

		// Token: 0x02000757 RID: 1879
		// (Invoke) Token: 0x06002C71 RID: 11377
		private delegate float PerlinNoiseDelegate(float x, float y);

		// Token: 0x02000758 RID: 1880
		// (Invoke) Token: 0x06002C73 RID: 11379
		private delegate void CorrelatedColorTemperatureToRGB_InjectedDelegate(float kelvin, [Out] IntPtr ret);
	}
}
