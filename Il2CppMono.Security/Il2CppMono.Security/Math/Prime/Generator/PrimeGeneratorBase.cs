using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x02000035 RID: 53
	public class PrimeGeneratorBase : Object
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x0000DC20 File Offset: 0x0000BE20
		// Note: this type is marked as 'beforefieldinit'.
		static PrimeGeneratorBase()
		{
			Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime.Generator", "PrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663693);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663694);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663695);
			PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663696);
			PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663697);
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000DCB4 File Offset: 0x0000BEB4
		public unsafe virtual ConfidenceFactor Confidence
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		public unsafe virtual PrimalityTest PrimalityTest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11579, XrefRangeEnd = 11584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PrimalityTest>(intPtr3) : null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000DD48 File Offset: 0x0000BF48
		public unsafe virtual int TrialDivisionBounds
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000DD90 File Offset: 0x0000BF90
		[CallerCount(0)]
		public unsafe virtual BigInteger GenerateNewPrime(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000DDE8 File Offset: 0x0000BFE8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x000032A8 File Offset: 0x000014A8
		public PrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
