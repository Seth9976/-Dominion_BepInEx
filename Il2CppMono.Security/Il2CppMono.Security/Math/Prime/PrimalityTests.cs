using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000034 RID: 52
	public sealed class PrimalityTests : Object
	{
		// Token: 0x060002B4 RID: 692 RVA: 0x0000DB28 File Offset: 0x0000BD28
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTests()
		{
			Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime", "PrimalityTests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr);
			PrimalityTests.NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663691);
			PrimalityTests.NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTests>.NativeClassPtr, 100663692);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000DB80 File Offset: 0x0000BD80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11526, RefRangeEnd = 11527, XrefRangeStart = 11515, XrefRangeEnd = 11526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002B6 RID: 694 RVA: 0x0000DBD0 File Offset: 0x0000BDD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11527, XrefRangeEnd = 11579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002B7 RID: 695 RVA: 0x0000329F File Offset: 0x0000149F
		public PrimalityTests(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_GetSPPRounds_Private_Static_Int32_BigInteger_ConfidenceFactor_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_RabinMillerTest_Public_Static_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
