using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000039 RID: 57
	public sealed class PrimalityTests : Object
	{
		// Token: 0x060003FF RID: 1023 RVA: 0x00031B58 File Offset: 0x0002FD58
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTests()
		{
			Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime", "PrimalityTests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr);
			PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663858);
			PrimalityTests.NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663859);
			PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663860);
			PrimalityTests.NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663861);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00031BD8 File Offset: 0x0002FDD8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264523, RefRangeEnd = 264525, XrefRangeStart = 264512, XrefRangeEnd = 264523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetSPPRounds(BigInteger bi, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00031C28 File Offset: 0x0002FE28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264529, RefRangeEnd = 264530, XrefRangeStart = 264525, XrefRangeEnd = 264529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Test(BigInteger n, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00031C78 File Offset: 0x0002FE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264572, RefRangeEnd = 264573, XrefRangeStart = 264530, XrefRangeEnd = 264572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RabinMillerTest(BigInteger n, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264597, RefRangeEnd = 264598, XrefRangeStart = 264573, XrefRangeEnd = 264597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SmallPrimeSppTest(BigInteger bi, ConfidenceFactor confidence)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTests.NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00003A83 File Offset: 0x00001C83
		public PrimalityTests(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_Test_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_SmallPrimeSppTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
