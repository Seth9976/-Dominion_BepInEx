using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime.Generator
{
	// Token: 0x0200003B RID: 59
	public class SequentialSearchPrimeGeneratorBase : PrimeGeneratorBase
	{
		// Token: 0x0600040C RID: 1036 RVA: 0x00031F1C File Offset: 0x0003011C
		// Note: this type is marked as 'beforefieldinit'.
		static SequentialSearchPrimeGeneratorBase()
		{
			Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime.Generator", "SequentialSearchPrimeGeneratorBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663867);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663868);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663869);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663870);
			SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr, 100663871);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00031FB0 File Offset: 0x000301B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264603, XrefRangeEnd = 264608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600040E RID: 1038 RVA: 0x0003201C File Offset: 0x0003021C
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

		// Token: 0x0600040F RID: 1039 RVA: 0x00032074 File Offset: 0x00030274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264608, XrefRangeEnd = 264621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000410 RID: 1040 RVA: 0x000320E0 File Offset: 0x000302E0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000411 RID: 1041 RVA: 0x0003214C File Offset: 0x0003034C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SequentialSearchPrimeGeneratorBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequentialSearchPrimeGeneratorBase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SequentialSearchPrimeGeneratorBase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00003A95 File Offset: 0x00001C95
		public SequentialSearchPrimeGeneratorBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSearchBase_Protected_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_BigInteger_Int32_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNewPrime_Public_Virtual_New_BigInteger_Int32_Object_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimeAcceptable_Protected_Virtual_New_Boolean_BigInteger_Object_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
