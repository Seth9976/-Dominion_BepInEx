using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Math
{
	// Token: 0x02000036 RID: 54
	public class BigInteger : Object
	{
		// Token: 0x060003BF RID: 959 RVA: 0x000307BC File Offset: 0x0002E9BC
		// Note: this type is marked as 'beforefieldinit'.
		static BigInteger()
		{
			Il2CppClassPointerStore<BigInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math", "BigInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger>.NativeClassPtr);
			BigInteger.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "length");
			BigInteger.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "data");
			BigInteger.NativeFieldInfoPtr_smallPrimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "smallPrimes");
			BigInteger.NativeFieldInfoPtr_rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "rng");
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663787);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663788);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663789);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663790);
			BigInteger.NativeMethodInfoPtr__ctor_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663791);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663792);
			BigInteger.NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663793);
			BigInteger.NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663794);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663795);
			BigInteger.NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663796);
			BigInteger.NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663797);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663798);
			BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663799);
			BigInteger.NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663800);
			BigInteger.NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663801);
			BigInteger.NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663802);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663803);
			BigInteger.NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663804);
			BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663805);
			BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663806);
			BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663807);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663808);
			BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663809);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663810);
			BigInteger.NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663811);
			BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663812);
			BigInteger.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663813);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663814);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663815);
			BigInteger.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663816);
			BigInteger.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663817);
			BigInteger.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663818);
			BigInteger.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663819);
			BigInteger.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663820);
			BigInteger.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663821);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663822);
			BigInteger.NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663823);
			BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663824);
			BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663825);
			BigInteger.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663826);
			BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663827);
			BigInteger.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663828);
			BigInteger.NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663829);
			BigInteger.NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663830);
			BigInteger.NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663831);
			BigInteger.NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663832);
			BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, 100663833);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00030BE8 File Offset: 0x0002EDE8
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 264069, RefRangeEnd = 264081, XrefRangeStart = 264065, XrefRangeEnd = 264069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00030C40 File Offset: 0x0002EE40
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264086, RefRangeEnd = 264089, XrefRangeStart = 264081, XrefRangeEnd = 264086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C2 RID: 962 RVA: 0x00030C8C File Offset: 0x0002EE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264089, XrefRangeEnd = 264094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C3 RID: 963 RVA: 0x00030CE8 File Offset: 0x0002EEE8
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 264103, RefRangeEnd = 264121, XrefRangeStart = 264094, XrefRangeEnd = 264103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C4 RID: 964 RVA: 0x00030D34 File Offset: 0x0002EF34
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 264125, RefRangeEnd = 264131, XrefRangeStart = 264121, XrefRangeEnd = 264125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C5 RID: 965 RVA: 0x00030D7C File Offset: 0x0002EF7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264135, RefRangeEnd = 264137, XrefRangeStart = 264131, XrefRangeEnd = 264135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C6 RID: 966 RVA: 0x00030DBC File Offset: 0x0002EFBC
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 264141, RefRangeEnd = 264163, XrefRangeStart = 264137, XrefRangeEnd = 264141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C7 RID: 967 RVA: 0x00030DFC File Offset: 0x0002EFFC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 264174, RefRangeEnd = 264188, XrefRangeStart = 264163, XrefRangeEnd = 264174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C8 RID: 968 RVA: 0x00030E54 File Offset: 0x0002F054
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264189, RefRangeEnd = 264194, XrefRangeStart = 264188, XrefRangeEnd = 264189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00030EA4 File Offset: 0x0002F0A4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 264195, RefRangeEnd = 264203, XrefRangeStart = 264194, XrefRangeEnd = 264195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003CA RID: 970 RVA: 0x00030EFC File Offset: 0x0002F0FC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264204, RefRangeEnd = 264209, XrefRangeStart = 264203, XrefRangeEnd = 264204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003CB RID: 971 RVA: 0x00030F54 File Offset: 0x0002F154
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 264225, RefRangeEnd = 264233, XrefRangeStart = 264209, XrefRangeEnd = 264225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003CC RID: 972 RVA: 0x00030FAC File Offset: 0x0002F1AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264238, RefRangeEnd = 264239, XrefRangeStart = 264233, XrefRangeEnd = 264238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BigInteger operator *(BigInteger bi, int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00031000 File Offset: 0x0002F200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264240, RefRangeEnd = 264242, XrefRangeStart = 264239, XrefRangeEnd = 264240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003CE RID: 974 RVA: 0x00031054 File Offset: 0x0002F254
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264243, RefRangeEnd = 264246, XrefRangeStart = 264242, XrefRangeEnd = 264243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000310A8 File Offset: 0x0002F2A8
		public unsafe static RandomNumberGenerator Rng
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 264257, RefRangeEnd = 264259, XrefRangeStart = 264246, XrefRangeEnd = 264257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D0 RID: 976 RVA: 0x000310DC File Offset: 0x0002F2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264273, RefRangeEnd = 264274, XrefRangeStart = 264259, XrefRangeEnd = 264273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D1 RID: 977 RVA: 0x00031130 File Offset: 0x0002F330
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 264279, RefRangeEnd = 264285, XrefRangeStart = 264274, XrefRangeEnd = 264279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D2 RID: 978 RVA: 0x00031170 File Offset: 0x0002F370
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264294, RefRangeEnd = 264295, XrefRangeStart = 264285, XrefRangeEnd = 264294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize(RandomNumberGenerator rng)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rng);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000311B4 File Offset: 0x0002F3B4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 264300, RefRangeEnd = 264303, XrefRangeStart = 264295, XrefRangeEnd = 264300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Randomize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Randomize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000311E8 File Offset: 0x0002F3E8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 11302, RefRangeEnd = 11318, XrefRangeStart = 11302, XrefRangeEnd = 11318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int BitCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_BitCount_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00031224 File Offset: 0x0002F424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264303, RefRangeEnd = 264304, XrefRangeStart = 264303, XrefRangeEnd = 264303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TestBit(uint bitNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00031270 File Offset: 0x0002F470
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264304, RefRangeEnd = 264308, XrefRangeStart = 264304, XrefRangeEnd = 264304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D7 RID: 983 RVA: 0x000312BC File Offset: 0x0002F4BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11322, RefRangeEnd = 11323, XrefRangeStart = 11322, XrefRangeEnd = 11323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003D8 RID: 984 RVA: 0x000312FC File Offset: 0x0002F4FC
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

		// Token: 0x060003D9 RID: 985 RVA: 0x00031348 File Offset: 0x0002F548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264313, RefRangeEnd = 264315, XrefRangeStart = 264308, XrefRangeEnd = 264313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LowestSetBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_LowestSetBit_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00031384 File Offset: 0x0002F584
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 264324, RefRangeEnd = 264335, XrefRangeStart = 264315, XrefRangeEnd = 264324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003DB RID: 987 RVA: 0x000313C4 File Offset: 0x0002F5C4
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 11342, RefRangeEnd = 11366, XrefRangeStart = 11342, XrefRangeEnd = 11366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003DC RID: 988 RVA: 0x00031414 File Offset: 0x0002F614
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11366, RefRangeEnd = 11370, XrefRangeStart = 11366, XrefRangeEnd = 11370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003DD RID: 989 RVA: 0x00031464 File Offset: 0x0002F664
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 264343, RefRangeEnd = 264358, XrefRangeStart = 264335, XrefRangeEnd = 264343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003DE RID: 990 RVA: 0x000314B8 File Offset: 0x0002F6B8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 264366, RefRangeEnd = 264394, XrefRangeStart = 264358, XrefRangeEnd = 264366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003DF RID: 991 RVA: 0x0003150C File Offset: 0x0002F70C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 11413, RefRangeEnd = 11417, XrefRangeStart = 11413, XrefRangeEnd = 11417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E0 RID: 992 RVA: 0x00031560 File Offset: 0x0002F760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11418, RefRangeEnd = 11419, XrefRangeStart = 11418, XrefRangeEnd = 11419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E1 RID: 993 RVA: 0x000315B4 File Offset: 0x0002F7B4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 11420, RefRangeEnd = 11429, XrefRangeStart = 11420, XrefRangeEnd = 11429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E2 RID: 994 RVA: 0x00031608 File Offset: 0x0002F808
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 11430, RefRangeEnd = 11435, XrefRangeStart = 11430, XrefRangeEnd = 11435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E3 RID: 995 RVA: 0x0003165C File Offset: 0x0002F85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264394, XrefRangeEnd = 264397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E4 RID: 996 RVA: 0x000316A0 File Offset: 0x0002F8A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264418, RefRangeEnd = 264420, XrefRangeStart = 264397, XrefRangeEnd = 264418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003E5 RID: 997 RVA: 0x000316F8 File Offset: 0x0002F8F8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 11460, RefRangeEnd = 11477, XrefRangeStart = 11460, XrefRangeEnd = 11477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Normalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Normalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x0003172C File Offset: 0x0002F92C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 264420, RefRangeEnd = 264435, XrefRangeStart = 264420, XrefRangeEnd = 264420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00031760 File Offset: 0x0002F960
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x000317A8 File Offset: 0x0002F9A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264435, XrefRangeEnd = 264446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BigInteger.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000317EC File Offset: 0x0002F9EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264446, XrefRangeEnd = 264463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003EA RID: 1002 RVA: 0x00031844 File Offset: 0x0002FA44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264464, RefRangeEnd = 264468, XrefRangeStart = 264463, XrefRangeEnd = 264464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003EB RID: 1003 RVA: 0x00031894 File Offset: 0x0002FA94
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 264474, RefRangeEnd = 264479, XrefRangeStart = 264468, XrefRangeEnd = 264474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exp);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(n);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000318F8 File Offset: 0x0002FAF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264503, RefRangeEnd = 264505, XrefRangeStart = 264479, XrefRangeEnd = 264503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsProbablePrime()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00031934 File Offset: 0x0002FB34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 264510, RefRangeEnd = 264512, XrefRangeStart = 264505, XrefRangeEnd = 264510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060003EE RID: 1006 RVA: 0x00031974 File Offset: 0x0002FB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 11512, RefRangeEnd = 11513, XrefRangeStart = 11512, XrefRangeEnd = 11513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Incr2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.NativeMethodInfoPtr_Incr2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000039EC File Offset: 0x00001BEC
		public BigInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x000319A8 File Offset: 0x0002FBA8
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x000039F5 File Offset: 0x00001BF5
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

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000319D0 File Offset: 0x0002FBD0
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00003A10 File Offset: 0x00001C10
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

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00031A00 File Offset: 0x0002FC00
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00003A2F File Offset: 0x00001C2F
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

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00031A28 File Offset: 0x0002FC28
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x00003A41 File Offset: 0x00001C41
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

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_smallPrimes;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_rng;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Sign_UInt32_0;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_UInt32_0;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_0;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_UInt32_0;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_BigInteger_Int32_0;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_UInt32_BigInteger_UInt32_0;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeMethodInfoPtr_op_Modulus_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeMethodInfoPtr_op_Division_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeMethodInfoPtr_op_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeMethodInfoPtr_op_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeMethodInfoPtr_get_Rng_Private_Static_get_RandomNumberGenerator_0;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_RandomNumberGenerator_0;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Public_Static_BigInteger_Int32_0;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_RandomNumberGenerator_0;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeMethodInfoPtr_Randomize_Public_Void_0;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr_BitCount_Public_Int32_0;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_UInt32_0;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_TestBit_Public_Boolean_Int32_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_SetBit_Public_Void_UInt32_Boolean_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_LowestSetBit_Public_Int32_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_UInt32_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_BigInteger_BigInteger_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_String_UInt32_String_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Void_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeMethodInfoPtr_ModInverse_Public_BigInteger_BigInteger_0;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeMethodInfoPtr_ModPow_Public_BigInteger_BigInteger_BigInteger_0;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr_IsProbablePrime_Public_Boolean_0;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePseudoPrime_Public_Static_BigInteger_Int32_0;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_Incr2_Public_Void_0;

		// Token: 0x02000547 RID: 1351
		public enum Sign
		{
			// Token: 0x04003F08 RID: 16136
			Negative = -1,
			// Token: 0x04003F09 RID: 16137
			Zero,
			// Token: 0x04003F0A RID: 16138
			Positive
		}

		// Token: 0x02000548 RID: 1352
		public sealed class ModulusRing : Object
		{
			// Token: 0x06004E19 RID: 19993 RVA: 0x0015FD74 File Offset: 0x0015DF74
			// Note: this type is marked as 'beforefieldinit'.
			static ModulusRing()
			{
				Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "ModulusRing");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr);
				BigInteger.ModulusRing.NativeFieldInfoPtr_mod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "mod");
				BigInteger.ModulusRing.NativeFieldInfoPtr_constant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, "constant");
				BigInteger.ModulusRing.NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663835);
				BigInteger.ModulusRing.NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663836);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663837);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663838);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663839);
				BigInteger.ModulusRing.NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.ModulusRing>.NativeClassPtr, 100663840);
			}

			// Token: 0x06004E1A RID: 19994 RVA: 0x0015FE40 File Offset: 0x0015E040
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 263817, RefRangeEnd = 263820, XrefRangeStart = 263809, XrefRangeEnd = 263817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E1B RID: 19995 RVA: 0x0015FE8C File Offset: 0x0015E08C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263849, RefRangeEnd = 263851, XrefRangeStart = 263820, XrefRangeEnd = 263849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E1C RID: 19996 RVA: 0x0015FED0 File Offset: 0x0015E0D0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 263874, RefRangeEnd = 263878, XrefRangeStart = 263851, XrefRangeEnd = 263874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E1D RID: 19997 RVA: 0x0015FF34 File Offset: 0x0015E134
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263897, RefRangeEnd = 263899, XrefRangeStart = 263878, XrefRangeEnd = 263897, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E1E RID: 19998 RVA: 0x0015FF98 File Offset: 0x0015E198
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 263912, RefRangeEnd = 263915, XrefRangeStart = 263899, XrefRangeEnd = 263912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E1F RID: 19999 RVA: 0x0015FFFC File Offset: 0x0015E1FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263932, RefRangeEnd = 263934, XrefRangeStart = 263915, XrefRangeEnd = 263932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E20 RID: 20000 RVA: 0x0001D9E3 File Offset: 0x0001BBE3
			public ModulusRing(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013EB RID: 5099
			// (get) Token: 0x06004E21 RID: 20001 RVA: 0x0016005C File Offset: 0x0015E25C
			// (set) Token: 0x06004E22 RID: 20002 RVA: 0x0001D9EC File Offset: 0x0001BBEC
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

			// Token: 0x170013EC RID: 5100
			// (get) Token: 0x06004E23 RID: 20003 RVA: 0x0016008C File Offset: 0x0015E28C
			// (set) Token: 0x06004E24 RID: 20004 RVA: 0x0001DA0B File Offset: 0x0001BC0B
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

			// Token: 0x04003F0B RID: 16139
			private static readonly IntPtr NativeFieldInfoPtr_mod;

			// Token: 0x04003F0C RID: 16140
			private static readonly IntPtr NativeFieldInfoPtr_constant;

			// Token: 0x04003F0D RID: 16141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BigInteger_0;

			// Token: 0x04003F0E RID: 16142
			private static readonly IntPtr NativeMethodInfoPtr_BarrettReduction_Public_Void_BigInteger_0;

			// Token: 0x04003F0F RID: 16143
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04003F10 RID: 16144
			private static readonly IntPtr NativeMethodInfoPtr_Difference_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04003F11 RID: 16145
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04003F12 RID: 16146
			private static readonly IntPtr NativeMethodInfoPtr_Pow_Public_BigInteger_UInt32_BigInteger_0;
		}

		// Token: 0x02000549 RID: 1353
		public sealed class Kernel : Object
		{
			// Token: 0x06004E25 RID: 20005 RVA: 0x001600BC File Offset: 0x0015E2BC
			// Note: this type is marked as 'beforefieldinit'.
			static Kernel()
			{
				Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BigInteger>.NativeClassPtr, "Kernel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr);
				BigInteger.Kernel.NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663841);
				BigInteger.Kernel.NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663842);
				BigInteger.Kernel.NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663843);
				BigInteger.Kernel.NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663844);
				BigInteger.Kernel.NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663845);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663846);
				BigInteger.Kernel.NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663847);
				BigInteger.Kernel.NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663848);
				BigInteger.Kernel.NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663849);
				BigInteger.Kernel.NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663850);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663851);
				BigInteger.Kernel.NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663852);
				BigInteger.Kernel.NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663853);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663854);
				BigInteger.Kernel.NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BigInteger.Kernel>.NativeClassPtr, 100663855);
			}

			// Token: 0x06004E26 RID: 20006 RVA: 0x00160214 File Offset: 0x0015E414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263934, XrefRangeEnd = 263939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E27 RID: 20007 RVA: 0x0016026C File Offset: 0x0015E46C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 10957, RefRangeEnd = 10961, XrefRangeStart = 10957, XrefRangeEnd = 10961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E28 RID: 20008 RVA: 0x001602B4 File Offset: 0x0015E4B4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263940, RefRangeEnd = 263941, XrefRangeStart = 263939, XrefRangeEnd = 263940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E29 RID: 20009 RVA: 0x001602FC File Offset: 0x0015E4FC
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 10963, RefRangeEnd = 10985, XrefRangeStart = 10963, XrefRangeEnd = 10985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2A RID: 20010 RVA: 0x00160350 File Offset: 0x0015E550
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263942, RefRangeEnd = 263943, XrefRangeStart = 263941, XrefRangeEnd = 263942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2B RID: 20011 RVA: 0x001603A0 File Offset: 0x0015E5A0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 10985, RefRangeEnd = 10988, XrefRangeStart = 10985, XrefRangeEnd = 10988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2C RID: 20012 RVA: 0x001603F0 File Offset: 0x0015E5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263943, XrefRangeEnd = 263957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2D RID: 20013 RVA: 0x00160444 File Offset: 0x0015E644
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 263980, RefRangeEnd = 263984, XrefRangeStart = 263957, XrefRangeEnd = 263980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2E RID: 20014 RVA: 0x0016049C File Offset: 0x0015E69C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263993, RefRangeEnd = 263994, XrefRangeStart = 263984, XrefRangeEnd = 263993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E2F RID: 20015 RVA: 0x001604F0 File Offset: 0x0015E6F0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264000, RefRangeEnd = 264001, XrefRangeStart = 263994, XrefRangeEnd = 264000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E30 RID: 20016 RVA: 0x00160544 File Offset: 0x0015E744
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264006, RefRangeEnd = 264007, XrefRangeStart = 264001, XrefRangeEnd = 264006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static BigInteger MultiplyByDword(BigInteger n, uint f)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BigInteger.Kernel.NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BigInteger>(intPtr3) : null;
			}

			// Token: 0x06004E31 RID: 20017 RVA: 0x00160598 File Offset: 0x0015E798
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 11066, RefRangeEnd = 11068, XrefRangeStart = 11066, XrefRangeEnd = 11068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E32 RID: 20018 RVA: 0x0016063C File Offset: 0x0015E83C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11071, RefRangeEnd = 11072, XrefRangeStart = 11071, XrefRangeEnd = 11072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E33 RID: 20019 RVA: 0x001606EC File Offset: 0x0015E8EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264007, XrefRangeEnd = 264011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E34 RID: 20020 RVA: 0x0016073C File Offset: 0x0015E93C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 264064, RefRangeEnd = 264065, XrefRangeStart = 264011, XrefRangeEnd = 264064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004E35 RID: 20021 RVA: 0x0001DA2A File Offset: 0x0001BC2A
			public Kernel(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003F13 RID: 16147
			private static readonly IntPtr NativeMethodInfoPtr_Subtract_Public_Static_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04003F14 RID: 16148
			private static readonly IntPtr NativeMethodInfoPtr_MinusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x04003F15 RID: 16149
			private static readonly IntPtr NativeMethodInfoPtr_PlusEq_Public_Static_Void_BigInteger_BigInteger_0;

			// Token: 0x04003F16 RID: 16150
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Sign_BigInteger_BigInteger_0;

			// Token: 0x04003F17 RID: 16151
			private static readonly IntPtr NativeMethodInfoPtr_SingleByteDivideInPlace_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x04003F18 RID: 16152
			private static readonly IntPtr NativeMethodInfoPtr_DwordMod_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x04003F19 RID: 16153
			private static readonly IntPtr NativeMethodInfoPtr_DwordDivMod_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_UInt32_0;

			// Token: 0x04003F1A RID: 16154
			private static readonly IntPtr NativeMethodInfoPtr_multiByteDivide_Public_Static_Il2CppReferenceArray_1_BigInteger_BigInteger_BigInteger_0;

			// Token: 0x04003F1B RID: 16155
			private static readonly IntPtr NativeMethodInfoPtr_LeftShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x04003F1C RID: 16156
			private static readonly IntPtr NativeMethodInfoPtr_RightShift_Public_Static_BigInteger_BigInteger_Int32_0;

			// Token: 0x04003F1D RID: 16157
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyByDword_Public_Static_BigInteger_BigInteger_UInt32_0;

			// Token: 0x04003F1E RID: 16158
			private static readonly IntPtr NativeMethodInfoPtr_Multiply_Public_Static_Void_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_UInt32_Il2CppStructArray_1_UInt32_UInt32_0;

			// Token: 0x04003F1F RID: 16159
			private static readonly IntPtr NativeMethodInfoPtr_MultiplyMod2p32pmod_Public_Static_Void_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_Il2CppStructArray_1_UInt32_Int32_Int32_0;

			// Token: 0x04003F20 RID: 16160
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_UInt32_BigInteger_UInt32_0;

			// Token: 0x04003F21 RID: 16161
			private static readonly IntPtr NativeMethodInfoPtr_modInverse_Public_Static_BigInteger_BigInteger_BigInteger_0;
		}
	}
}
