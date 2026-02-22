using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x0200003A RID: 58
	public class PrimeGeneratorBase : Object
	{
		// Token: 0x06000405 RID: 1029 RVA: 0x00031D18 File Offset: 0x0002FF18
		// Note: this type is marked as 'beforefieldinit'.
		static PrimeGeneratorBase()
		{
			Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime.Generator", "PrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663862);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663863);
			PrimeGeneratorBase.NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663864);
			PrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663865);
			PrimeGeneratorBase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimeGeneratorBase>.NativeClassPtr, 100663866);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x00031DAC File Offset: 0x0002FFAC
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

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00031DF4 File Offset: 0x0002FFF4
		public unsafe virtual PrimalityTest PrimalityTest
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264598, XrefRangeEnd = 264603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00031E40 File Offset: 0x00030040
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

		// Token: 0x06000409 RID: 1033 RVA: 0x00031E88 File Offset: 0x00030088
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

		// Token: 0x0600040A RID: 1034 RVA: 0x00031EE0 File Offset: 0x000300E0
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

		// Token: 0x0600040B RID: 1035 RVA: 0x00003A8C File Offset: 0x00001C8C
		public PrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_get_Confidence_Public_Virtual_New_get_ConfidenceFactor_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimalityTest_Public_Virtual_New_get_PrimalityTest_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_get_TrialDivisionBounds_Public_Virtual_New_get_Int32_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Abstract_Virtual_New_BigInteger_Int32_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
