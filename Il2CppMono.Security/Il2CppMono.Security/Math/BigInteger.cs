using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Math
{
	// Token: 0x02000031 RID: 49
	public class BigInteger : Object
	{
		// Token: 0x0600027B RID: 635 RVA: 0x0000CA04 File Offset: 0x0000AC04
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
			Il2CppClassPointerStore<BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math", "BigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger>.NativeClassPtr);
			BigInteger.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "length");
			BigInteger.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "data");
			BigInteger.NativeFieldInfoPtr_smallPrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "smallPrimes");
			BigInteger.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "rng");
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663628);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663629);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663630);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663631);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663632);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663633);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663634);
			BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663635);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663636);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663637);
			BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663638);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663639);
			BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663640);
			BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663641);
			BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663642);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663643);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663644);
			BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663645);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663646);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663647);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663648);
			BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663649);
			BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663650);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663651);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663652);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663653);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663654);
			BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663655);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663656);
			BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663657);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663658);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663659);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663660);
			BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663661);
			BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663662);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663663);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663664);
			BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663665);
			BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663666);
			BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663667);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000CDA4 File Offset: 0x0000AFA4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 11143, RefRangeEnd = 11148, XrefRangeStart = 11139, XrefRangeEnd = 11143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger.Sign sign, uint len)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sign;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11153, RefRangeEnd = 11155, XrefRangeStart = 11148, XrefRangeEnd = 11153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger bi)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0000CE48 File Offset: 0x0000B048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11155, XrefRangeEnd = 11160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(BigInteger bi, uint len)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000CEA4 File Offset: 0x0000B0A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 11169, RefRangeEnd = 11177, XrefRangeStart = 11160, XrefRangeEnd = 11169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(Il2CppStructArray<byte> inData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000CEF0 File Offset: 0x0000B0F0
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11181, RefRangeEnd = 11198, XrefRangeStart = 11177, XrefRangeEnd = 11181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger(uint ui)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ui;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0000CF38 File Offset: 0x0000B138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11198, XrefRangeEnd = 11202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000CF78 File Offset: 0x0000B178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11206, RefRangeEnd = 11208, XrefRangeStart = 11202, XrefRangeEnd = 11206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator BigInteger(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000CFB8 File Offset: 0x0000B1B8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 11219, RefRangeEnd = 11226, XrefRangeStart = 11208, XrefRangeEnd = 11219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x0000D010 File Offset: 0x0000B210
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 10985, RefRangeEnd = 10988, XrefRangeStart = 10985, XrefRangeEnd = 10988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint operator %(BigInteger bi, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0000D060 File Offset: 0x0000B260
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11227, RefRangeEnd = 11231, XrefRangeStart = 11226, XrefRangeEnd = 11227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0000D0B8 File Offset: 0x0000B2B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11232, RefRangeEnd = 11233, XrefRangeStart = 11231, XrefRangeEnd = 11232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0000D110 File Offset: 0x0000B310
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 11251, RefRangeEnd = 11258, XrefRangeStart = 11233, XrefRangeEnd = 11251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000D168 File Offset: 0x0000B368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11258, XrefRangeEnd = 11259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000D1BC File Offset: 0x0000B3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11259, XrefRangeEnd = 11260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator >>(BigInteger bi1, int shiftVal)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shiftVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600028A RID: 650 RVA: 0x0000D210 File Offset: 0x0000B410
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11260, XrefRangeEnd = 11271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000D244 File Offset: 0x0000B444
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11283, RefRangeEnd = 11284, XrefRangeStart = 11271, XrefRangeEnd = 11283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GenerateRandom(int bits, RandomNumberGenerator rng)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rng);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000D298 File Offset: 0x0000B498
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11300, RefRangeEnd = 11302, XrefRangeStart = 11284, XrefRangeEnd = 11300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GenerateRandom(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 11302, RefRangeEnd = 11318, XrefRangeStart = 11302, XrefRangeEnd = 11302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BitCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000D314 File Offset: 0x0000B514
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11318, RefRangeEnd = 11322, XrefRangeStart = 11318, XrefRangeEnd = 11318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestBit(int bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000D360 File Offset: 0x0000B560
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11322, RefRangeEnd = 11323, XrefRangeStart = 11322, XrefRangeEnd = 11322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBit(uint bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000D3A0 File Offset: 0x0000B5A0
		[CallerCount(0)]
		public unsafe void SetBit(uint bitNum, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000D3EC File Offset: 0x0000B5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11328, RefRangeEnd = 11329, XrefRangeStart = 11323, XrefRangeEnd = 11328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LowestSetBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000D428 File Offset: 0x0000B628
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11338, RefRangeEnd = 11342, XrefRangeStart = 11329, XrefRangeEnd = 11338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000D468 File Offset: 0x0000B668
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 11342, RefRangeEnd = 11366, XrefRangeStart = 11342, XrefRangeEnd = 11342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BigInteger bi1, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11366, RefRangeEnd = 11370, XrefRangeStart = 11366, XrefRangeEnd = 11366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BigInteger bi1, uint ui)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ui;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000D508 File Offset: 0x0000B708
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 11378, RefRangeEnd = 11391, XrefRangeStart = 11370, XrefRangeEnd = 11378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000D55C File Offset: 0x0000B75C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 11399, RefRangeEnd = 11412, XrefRangeStart = 11391, XrefRangeEnd = 11399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11413, RefRangeEnd = 11417, XrefRangeStart = 11412, XrefRangeEnd = 11413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000D604 File Offset: 0x0000B804
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11418, RefRangeEnd = 11419, XrefRangeStart = 11417, XrefRangeEnd = 11418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000D658 File Offset: 0x0000B858
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11420, RefRangeEnd = 11429, XrefRangeStart = 11419, XrefRangeEnd = 11420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D6AC File Offset: 0x0000B8AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 11430, RefRangeEnd = 11435, XrefRangeStart = 11429, XrefRangeEnd = 11430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator <=(BigInteger bi1, BigInteger bi2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000D700 File Offset: 0x0000B900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11435, XrefRangeEnd = 11438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(uint radix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000D744 File Offset: 0x0000B944
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11458, RefRangeEnd = 11460, XrefRangeStart = 11438, XrefRangeEnd = 11458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(uint radix, string characterSet)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref radix;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(characterSet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000D79C File Offset: 0x0000B99C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11460, RefRangeEnd = 11477, XrefRangeStart = 11460, XrefRangeEnd = 11460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000D7D0 File Offset: 0x0000B9D0
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000D818 File Offset: 0x0000BA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11477, XrefRangeEnd = 11480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000D85C File Offset: 0x0000BA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11480, XrefRangeEnd = 11505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object o)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11505, XrefRangeEnd = 11506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger ModInverse(BigInteger modulus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(modulus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000D904 File Offset: 0x0000BB04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11506, XrefRangeEnd = 11511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger GeneratePseudoPrime(int bits)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bits;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000D944 File Offset: 0x0000BB44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11512, RefRangeEnd = 11513, XrefRangeStart = 11511, XrefRangeEnd = 11512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incr2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003208 File Offset: 0x00001408
		public BigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000D978 File Offset: 0x0000BB78
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003211 File Offset: 0x00001411
		public unsafe uint length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0000322C File Offset: 0x0000142C
		public unsafe Il2CppStructArray<uint> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000D9D0 File Offset: 0x0000BBD0
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000324B File Offset: 0x0000144B
		public unsafe static Il2CppStructArray<uint> smallPrimes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_smallPrimes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_smallPrimes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000325D File Offset: 0x0000145D
		public unsafe static RandomNumberGenerator rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BigInteger.NativeFieldInfoPtr_rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BigInteger.NativeFieldInfoPtr_rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_smallPrimes;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_BitCount_Public_Int32_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_LowestSetBit_Public_Int32_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Void_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_Incr2_Public_Void_0;

		// Token: 0x0200003F RID: 63
		public enum Sign
		{
			// Token: 0x0400038B RID: 907
			Negative = -1,
			// Token: 0x0400038C RID: 908
			Zero,
			// Token: 0x0400038D RID: 909
			Positive
		}

		// Token: 0x02000040 RID: 64
		public sealed class ModulusRing : Object
		{
			// Token: 0x06000370 RID: 880 RVA: 0x0000FE30 File Offset: 0x0000E030
			// Note: this type is marked as 'beforefieldinit'.
			static ModulusRing()
			{
				Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "ModulusRing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr);
				BigInteger.ModulusRing.NativeFieldInfoPtr_mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "mod");
				BigInteger.ModulusRing.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "constant");
				BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663669);
				BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663670);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663671);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663672);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663673);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663674);
			}

			// Token: 0x06000371 RID: 881 RVA: 0x0000FEFC File Offset: 0x0000E0FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10839, RefRangeEnd = 10841, XrefRangeStart = 10831, XrefRangeEnd = 10839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ModulusRing(BigInteger modulus)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(modulus);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000372 RID: 882 RVA: 0x0000FF48 File Offset: 0x0000E148
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10866, RefRangeEnd = 10868, XrefRangeStart = 10841, XrefRangeEnd = 10866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void BarrettReduction(BigInteger x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000373 RID: 883 RVA: 0x0000FF8C File Offset: 0x0000E18C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 10891, RefRangeEnd = 10895, XrefRangeStart = 10868, XrefRangeEnd = 10891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Multiply(BigInteger a, BigInteger b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000374 RID: 884 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10914, RefRangeEnd = 10916, XrefRangeStart = 10895, XrefRangeEnd = 10914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Difference(BigInteger a, BigInteger b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000375 RID: 885 RVA: 0x00010054 File Offset: 0x0000E254
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10929, RefRangeEnd = 10931, XrefRangeStart = 10916, XrefRangeEnd = 10929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Pow(BigInteger a, BigInteger k)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(k);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000376 RID: 886 RVA: 0x000100B8 File Offset: 0x0000E2B8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10948, RefRangeEnd = 10949, XrefRangeStart = 10931, XrefRangeEnd = 10948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BigInteger Pow(uint b, BigInteger exp)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref b;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000377 RID: 887 RVA: 0x00003762 File Offset: 0x00001962
			public ModulusRing(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000378 RID: 888 RVA: 0x00010118 File Offset: 0x0000E318
			// (set) Token: 0x06000379 RID: 889 RVA: 0x0000376B File Offset: 0x0000196B
			public unsafe BigInteger mod
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_mod);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_mod), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600037A RID: 890 RVA: 0x00010148 File Offset: 0x0000E348
			// (set) Token: 0x0600037B RID: 891 RVA: 0x0000378A File Offset: 0x0000198A
			public unsafe BigInteger constant
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_constant);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BigInteger.ModulusRing.NativeFieldInfoPtr_constant), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400038E RID: 910
			private static readonly IntPtr NativeFieldInfoPtr_mod;

			// Token: 0x0400038F RID: 911
			private static readonly IntPtr NativeFieldInfoPtr_constant;

			// Token: 0x04000390 RID: 912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

			// Token: 0x04000391 RID: 913
			private static readonly IntPtr NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0;

			// Token: 0x04000392 RID: 914
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04000393 RID: 915
			private static readonly IntPtr NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04000394 RID: 916
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04000395 RID: 917
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0;
		}

		// Token: 0x02000041 RID: 65
		public sealed class Kernel : Object
		{
			// Token: 0x0600037C RID: 892 RVA: 0x00010178 File Offset: 0x0000E378
			// Note: this type is marked as 'beforefieldinit'.
			static Kernel()
			{
				Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "Kernel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr);
				BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663675);
				BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663676);
				BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663677);
				BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663678);
				BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663679);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663680);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663681);
				BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663682);
				BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663683);
				BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663684);
				BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663685);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663686);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663687);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663688);
			}

			// Token: 0x0600037D RID: 893 RVA: 0x000102BC File Offset: 0x0000E4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10949, XrefRangeEnd = 10956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger Subtract(BigInteger big, BigInteger small)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(small);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600037E RID: 894 RVA: 0x00010314 File Offset: 0x0000E514
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 10957, RefRangeEnd = 10961, XrefRangeStart = 10956, XrefRangeEnd = 10957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void MinusEq(BigInteger big, BigInteger small)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(big);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(small);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600037F RID: 895 RVA: 0x0001035C File Offset: 0x0000E55C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10962, RefRangeEnd = 10963, XrefRangeStart = 10961, XrefRangeEnd = 10962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void PlusEq(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000380 RID: 896 RVA: 0x000103A4 File Offset: 0x0000E5A4
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 10963, RefRangeEnd = 10985, XrefRangeStart = 10963, XrefRangeEnd = 10963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger.Sign Compare(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000381 RID: 897 RVA: 0x000103F8 File Offset: 0x0000E5F8
			[CallerCount(0)]
			public unsafe static uint SingleByteDivideInPlace(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000382 RID: 898 RVA: 0x00010448 File Offset: 0x0000E648
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 10985, RefRangeEnd = 10988, XrefRangeStart = 10985, XrefRangeEnd = 10985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint DwordMod(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000383 RID: 899 RVA: 0x00010498 File Offset: 0x0000E698
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10988, XrefRangeEnd = 11010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<BigInteger> DwordDivMod(BigInteger n, uint d)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BigInteger>>(intPtr3) : null;
			}

			// Token: 0x06000384 RID: 900 RVA: 0x000104EC File Offset: 0x0000E6EC
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 11032, RefRangeEnd = 11038, XrefRangeStart = 11010, XrefRangeEnd = 11032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<BigInteger> multiByteDivide(BigInteger bi1, BigInteger bi2)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi1);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bi2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BigInteger>>(intPtr3) : null;
			}

			// Token: 0x06000385 RID: 901 RVA: 0x00010544 File Offset: 0x0000E744
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11049, RefRangeEnd = 11052, XrefRangeStart = 11038, XrefRangeEnd = 11049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger LeftShift(BigInteger bi, int n)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000386 RID: 902 RVA: 0x00010598 File Offset: 0x0000E798
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11060, RefRangeEnd = 11063, XrefRangeStart = 11052, XrefRangeEnd = 11060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger RightShift(BigInteger bi, int n)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06000387 RID: 903 RVA: 0x000105EC File Offset: 0x0000E7EC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11066, RefRangeEnd = 11068, XrefRangeStart = 11063, XrefRangeEnd = 11066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Multiply(Il2CppStructArray<uint> x, uint xOffset, uint xLen, Il2CppStructArray<uint> y, uint yOffset, uint yLen, Il2CppStructArray<uint> d, uint dOffset)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dOffset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000388 RID: 904 RVA: 0x00010690 File Offset: 0x0000E890
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11071, RefRangeEnd = 11072, XrefRangeStart = 11068, XrefRangeEnd = 11071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void MultiplyMod2p32pmod(Il2CppStructArray<uint> x, int xOffset, int xLen, Il2CppStructArray<uint> y, int yOffest, int yLen, Il2CppStructArray<uint> d, int dOffset, int mod)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xLen;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffest;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yLen;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(d);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dOffset;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000389 RID: 905 RVA: 0x00010740 File Offset: 0x0000E940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11072, XrefRangeEnd = 11075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static uint modInverse(BigInteger bi, uint modulus)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref modulus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600038A RID: 906 RVA: 0x00010790 File Offset: 0x0000E990
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 11134, RefRangeEnd = 11139, XrefRangeStart = 11075, XrefRangeEnd = 11134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger modInverse(BigInteger bi, BigInteger modulus)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(modulus);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x0600038B RID: 907 RVA: 0x000037A9 File Offset: 0x000019A9
			public Kernel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000396 RID: 918
			private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04000397 RID: 919
			private static readonly IntPtr NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x04000398 RID: 920
			private static readonly IntPtr NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x04000399 RID: 921
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0;

			// Token: 0x0400039A RID: 922
			private static readonly IntPtr NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x0400039B RID: 923
			private static readonly IntPtr NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x0400039C RID: 924
			private static readonly IntPtr NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0;

			// Token: 0x0400039D RID: 925
			private static readonly IntPtr NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x0400039E RID: 926
			private static readonly IntPtr NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x0400039F RID: 927
			private static readonly IntPtr NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x040003A0 RID: 928
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

			// Token: 0x040003A1 RID: 929
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0;

			// Token: 0x040003A2 RID: 930
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x040003A3 RID: 931
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0;
		}
	}
}
