using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x02000036 RID: 54
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000DE24 File Offset: 0x0000C024
		// Note: this type is marked as 'beforefieldinit'.
		static SequentialSearchPrimeGeneratorBase()
		{
			Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime.Generator", "SequentialSearchPrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663698);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663699);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663700);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663701);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663702);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11584, XrefRangeEnd = 11588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BigInteger GenerateSearchBase(int bits, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000DF24 File Offset: 0x0000C124
		[CallerCount(0)]
		public unsafe override BigInteger GenerateNewPrime(int bits)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000DF7C File Offset: 0x0000C17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11588, XrefRangeEnd = 11600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BigInteger GenerateNewPrime(int bits, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsPrimeAcceptable(BigInteger bi, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E054 File Offset: 0x0000C254
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialSearchPrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000032B1 File Offset: 0x000014B1
		public SequentialSearchPrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
