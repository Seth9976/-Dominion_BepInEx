using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000312 RID: 786
	public static class Utils : Object
	{
		// Token: 0x06003310 RID: 13072 RVA: 0x000FB908 File Offset: 0x000F9B08
		// Note: this type is marked as 'beforefieldinit'.
		static Utils()
		{
			Il2CppClassPointerStore<Utils>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "Utils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utils>.NativeClassPtr);
			Utils.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utils>.NativeClassPtr, "_rng");
			Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671247);
			Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671248);
			Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671249);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671250);
			Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671251);
			Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671252);
			Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671253);
			Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671254);
			Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671255);
			Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671256);
			Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671257);
			Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671258);
			Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671259);
			Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671260);
			Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utils>.NativeClassPtr, 100671261);
		}

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06003311 RID: 13073 RVA: 0x000FBA78 File Offset: 0x000F9C78
		public unsafe static RNGCryptoServiceProvider StaticRandomNumberGenerator
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 341250, RefRangeEnd = 341258, XrefRangeStart = 341239, XrefRangeEnd = 341250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr3) : null;
			}
		}

		// Token: 0x06003312 RID: 13074 RVA: 0x000FBAAC File Offset: 0x000F9CAC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 341272, RefRangeEnd = 341286, XrefRangeStart = 341258, XrefRangeEnd = 341272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GenerateRandom(int keySize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keySize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003313 RID: 13075 RVA: 0x000FBAEC File Offset: 0x000F9CEC
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasAlgorithm(int dwCalg, int dwKeySize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwCalg;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dwKeySize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003314 RID: 13076 RVA: 0x000FBB38 File Offset: 0x000F9D38
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 341288, RefRangeEnd = 341304, XrefRangeStart = 341286, XrefRangeEnd = 341288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003315 RID: 13077 RVA: 0x000FBB74 File Offset: 0x000F9D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341324, RefRangeEnd = 341325, XrefRangeStart = 341304, XrefRangeEnd = 341324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string DiscardWhiteSpaces(string inputBuffer, int inputOffset, int inputCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003316 RID: 13078 RVA: 0x000FBBCC File Offset: 0x000F9DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341326, RefRangeEnd = 341327, XrefRangeStart = 341325, XrefRangeEnd = 341326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int ConvertByteArrayToInt(Il2CppStructArray<byte> input)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003317 RID: 13079 RVA: 0x000FBC10 File Offset: 0x000F9E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341335, RefRangeEnd = 341336, XrefRangeStart = 341327, XrefRangeEnd = 341335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertIntToByteArray(int dwInput)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dwInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003318 RID: 13080 RVA: 0x000FBC50 File Offset: 0x000F9E50
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 341340, RefRangeEnd = 341344, XrefRangeStart = 341336, XrefRangeEnd = 341340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FixupKeyParity(Il2CppStructArray<byte> key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003319 RID: 13081 RVA: 0x000FBC94 File Offset: 0x000F9E94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341344, RefRangeEnd = 341345, XrefRangeStart = 341344, XrefRangeEnd = 341344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDFromLittleEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331A RID: 13082 RVA: 0x000FBCE0 File Offset: 0x000F9EE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341345, RefRangeEnd = 341346, XrefRangeStart = 341345, XrefRangeEnd = 341345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDToLittleEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331B RID: 13083 RVA: 0x000FBD38 File Offset: 0x000F9F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341346, RefRangeEnd = 341348, XrefRangeStart = 341346, XrefRangeEnd = 341346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDFromBigEndian(uint* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331C RID: 13084 RVA: 0x000FBD84 File Offset: 0x000F9F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341348, RefRangeEnd = 341350, XrefRangeStart = 341348, XrefRangeEnd = 341348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DWORDToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<uint> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331D RID: 13085 RVA: 0x000FBDDC File Offset: 0x000F9FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341350, RefRangeEnd = 341352, XrefRangeStart = 341350, XrefRangeEnd = 341350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuadWordFromBigEndian(ulong* x, int digits, byte* block)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = block;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331E RID: 13086 RVA: 0x000FBE28 File Offset: 0x000FA028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 341352, RefRangeEnd = 341354, XrefRangeStart = 341352, XrefRangeEnd = 341352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuadWordToBigEndian(Il2CppStructArray<byte> block, Il2CppStructArray<ulong> x, int digits)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(x);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref digits;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600331F RID: 13087 RVA: 0x000FBE80 File Offset: 0x000FA080
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _ProduceLegacyHmacValues()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utils.NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003320 RID: 13088 RVA: 0x00012336 File Offset: 0x00010536
		public Utils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06003321 RID: 13089 RVA: 0x000FBEB0 File Offset: 0x000FA0B0
		// (set) Token: 0x06003322 RID: 13090 RVA: 0x0001233F File Offset: 0x0001053F
		public unsafe static RNGCryptoServiceProvider _rng
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utils.NativeFieldInfoPtr__rng, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RNGCryptoServiceProvider>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utils.NativeFieldInfoPtr__rng, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_get_StaticRandomNumberGenerator_Internal_Static_get_RNGCryptoServiceProvider_0;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_GenerateRandom_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_HasAlgorithm_Internal_Static_Boolean_Int32_Int32_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_DiscardWhiteSpaces_Internal_Static_String_String_Int32_Int32_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_ConvertByteArrayToInt_Internal_Static_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_ConvertIntToByteArray_Internal_Static_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr_FixupKeyParity_Internal_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromLittleEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToLittleEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeMethodInfoPtr_DWORDFromBigEndian_Internal_Static_Void_ptr_UInt32_Int32_ptr_Byte_0;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeMethodInfoPtr_DWORDToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt32_Int32_0;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordFromBigEndian_Internal_Static_Void_ptr_UInt64_Int32_ptr_Byte_0;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordToBigEndian_Internal_Static_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_UInt64_Int32_0;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr__ProduceLegacyHmacValues_Internal_Static_Boolean_0;
	}
}
