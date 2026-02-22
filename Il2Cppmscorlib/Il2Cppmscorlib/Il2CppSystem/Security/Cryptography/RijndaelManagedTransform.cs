using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002FA RID: 762
	public sealed class RijndaelManagedTransform : Object
	{
		// Token: 0x0600319B RID: 12699 RVA: 0x000F64B0 File Offset: 0x000F46B0
		// Note: this type is marked as 'beforefieldinit'.
		static RijndaelManagedTransform()
		{
			Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RijndaelManagedTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr);
			RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_cipherMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_paddingValue");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_transformMode");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBits");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_blockSizeBytes");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_inputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_outputBlockSize");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptKeyExpansion");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nr");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nb");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_Nk");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_encryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_decryptindex");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_IV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_IV");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_lastBlockBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_depadBuffer");
			RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "m_shiftRegister");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Sbox");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_Rcon");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_T = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_T");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_TF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_TF");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iT");
			RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, "s_iTF");
			RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671074);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671075);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671076);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671077);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671078);
			RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671079);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671080);
			RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671081);
			RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671082);
			RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671083);
			RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671084);
			RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671085);
			RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671086);
			RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671087);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671088);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671089);
			RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671090);
			RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671091);
			RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr, 100671092);
		}

		// Token: 0x0600319C RID: 12700 RVA: 0x000F683C File Offset: 0x000F4A3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340075, RefRangeEnd = 340078, XrefRangeStart = 340040, XrefRangeEnd = 340075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RijndaelManagedTransform(Il2CppStructArray<byte> rgbKey, CipherMode mode, Il2CppStructArray<byte> rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RijndaelManagedTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref blockSize;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref feedbackSize;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref PaddingValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformMode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000F68E0 File Offset: 0x000F4AE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340078, XrefRangeEnd = 340084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000F6914 File Offset: 0x000F4B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340084, XrefRangeEnd = 340090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x0600319F RID: 12703 RVA: 0x000F6954 File Offset: 0x000F4B54
		public unsafe int InputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000F6990 File Offset: 0x000F4B90
		public unsafe int OutputBlockSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x060031A1 RID: 12705 RVA: 0x000F69CC File Offset: 0x000F4BCC
		public unsafe bool CanTransformMultipleBlocks
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031A2 RID: 12706 RVA: 0x000F6A08 File Offset: 0x000F4C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340090, XrefRangeEnd = 340094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060031A3 RID: 12707 RVA: 0x000F6A94 File Offset: 0x000F4C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340094, XrefRangeEnd = 340101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000F6B00 File Offset: 0x000F4D00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340103, RefRangeEnd = 340104, XrefRangeStart = 340101, XrefRangeEnd = 340103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000F6B34 File Offset: 0x000F4D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 340104, XrefRangeEnd = 340148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EncryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000F6BF4 File Offset: 0x000F4DF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 340185, RefRangeEnd = 340188, XrefRangeStart = 340148, XrefRangeEnd = 340185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DecryptData(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, ref Il2CppStructArray<byte> outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputBuffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inputCount;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(outputBuffer);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref outputOffset;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingMode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fLast;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			outputBuffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000F6CB4 File Offset: 0x000F4EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340188, RefRangeEnd = 340190, XrefRangeStart = 340188, XrefRangeEnd = 340188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = encryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = encryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = T;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = TF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000F6D38 File Offset: 0x000F4F38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340190, RefRangeEnd = 340191, XrefRangeStart = 340190, XrefRangeEnd = 340190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = decryptindex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = decryptKeyExpansion;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iT;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = iTF;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = work;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060031A9 RID: 12713 RVA: 0x000F6DBC File Offset: 0x000F4FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 340209, RefRangeEnd = 340210, XrefRangeStart = 340191, XrefRangeEnd = 340209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateKeyExpansion(Il2CppStructArray<byte> rgbKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060031AA RID: 12714 RVA: 0x000F6E00 File Offset: 0x000F5000
		[CallerCount(0)]
		public unsafe static int rot1(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031AB RID: 12715 RVA: 0x000F6E40 File Offset: 0x000F5040
		[CallerCount(0)]
		public unsafe static int rot2(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000F6E80 File Offset: 0x000F5080
		[CallerCount(0)]
		public unsafe static int rot3(int val)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000F6EC0 File Offset: 0x000F50C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 340214, RefRangeEnd = 340216, XrefRangeStart = 340210, XrefRangeEnd = 340214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int SubWord(int a)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031AE RID: 12718 RVA: 0x000F6F00 File Offset: 0x000F5100
		[CallerCount(0)]
		public unsafe static int MulX(int x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RijndaelManagedTransform.NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000118BD File Offset: 0x0000FABD
		public RijndaelManagedTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x060031B0 RID: 12720 RVA: 0x000F6F40 File Offset: 0x000F5140
		// (set) Token: 0x060031B1 RID: 12721 RVA: 0x000118C6 File Offset: 0x0000FAC6
		public unsafe CipherMode m_cipherMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_cipherMode)) = value;
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x060031B2 RID: 12722 RVA: 0x000F6F68 File Offset: 0x000F5168
		// (set) Token: 0x060031B3 RID: 12723 RVA: 0x000118E1 File Offset: 0x0000FAE1
		public unsafe PaddingMode m_paddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_paddingValue)) = value;
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x060031B4 RID: 12724 RVA: 0x000F6F90 File Offset: 0x000F5190
		// (set) Token: 0x060031B5 RID: 12725 RVA: 0x000118FC File Offset: 0x0000FAFC
		public unsafe RijndaelManagedTransformMode m_transformMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_transformMode)) = value;
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060031B6 RID: 12726 RVA: 0x000F6FB8 File Offset: 0x000F51B8
		// (set) Token: 0x060031B7 RID: 12727 RVA: 0x00011917 File Offset: 0x0000FB17
		public unsafe int m_blockSizeBits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBits)) = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000F6FE0 File Offset: 0x000F51E0
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x00011932 File Offset: 0x0000FB32
		public unsafe int m_blockSizeBytes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_blockSizeBytes)) = value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060031BA RID: 12730 RVA: 0x000F7008 File Offset: 0x000F5208
		// (set) Token: 0x060031BB RID: 12731 RVA: 0x0001194D File Offset: 0x0000FB4D
		public unsafe int m_inputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_inputBlockSize)) = value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x060031BC RID: 12732 RVA: 0x000F7030 File Offset: 0x000F5230
		// (set) Token: 0x060031BD RID: 12733 RVA: 0x00011968 File Offset: 0x0000FB68
		public unsafe int m_outputBlockSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_outputBlockSize)) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x060031BE RID: 12734 RVA: 0x000F7058 File Offset: 0x000F5258
		// (set) Token: 0x060031BF RID: 12735 RVA: 0x00011983 File Offset: 0x0000FB83
		public unsafe Il2CppStructArray<int> m_encryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060031C0 RID: 12736 RVA: 0x000F7088 File Offset: 0x000F5288
		// (set) Token: 0x060031C1 RID: 12737 RVA: 0x000119A2 File Offset: 0x0000FBA2
		public unsafe Il2CppStructArray<int> m_decryptKeyExpansion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptKeyExpansion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x060031C2 RID: 12738 RVA: 0x000F70B8 File Offset: 0x000F52B8
		// (set) Token: 0x060031C3 RID: 12739 RVA: 0x000119C1 File Offset: 0x0000FBC1
		public unsafe int m_Nr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nr)) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x060031C4 RID: 12740 RVA: 0x000F70E0 File Offset: 0x000F52E0
		// (set) Token: 0x060031C5 RID: 12741 RVA: 0x000119DC File Offset: 0x0000FBDC
		public unsafe int m_Nb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nb)) = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x060031C6 RID: 12742 RVA: 0x000F7108 File Offset: 0x000F5308
		// (set) Token: 0x060031C7 RID: 12743 RVA: 0x000119F7 File Offset: 0x0000FBF7
		public unsafe int m_Nk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_Nk)) = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x060031C8 RID: 12744 RVA: 0x000F7130 File Offset: 0x000F5330
		// (set) Token: 0x060031C9 RID: 12745 RVA: 0x00011A12 File Offset: 0x0000FC12
		public unsafe Il2CppStructArray<int> m_encryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_encryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060031CA RID: 12746 RVA: 0x000F7160 File Offset: 0x000F5360
		// (set) Token: 0x060031CB RID: 12747 RVA: 0x00011A31 File Offset: 0x0000FC31
		public unsafe Il2CppStructArray<int> m_decryptindex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_decryptindex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x060031CC RID: 12748 RVA: 0x000F7190 File Offset: 0x000F5390
		// (set) Token: 0x060031CD RID: 12749 RVA: 0x00011A50 File Offset: 0x0000FC50
		public unsafe Il2CppStructArray<int> m_IV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_IV), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x060031CE RID: 12750 RVA: 0x000F71C0 File Offset: 0x000F53C0
		// (set) Token: 0x060031CF RID: 12751 RVA: 0x00011A6F File Offset: 0x0000FC6F
		public unsafe Il2CppStructArray<int> m_lastBlockBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_lastBlockBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x060031D0 RID: 12752 RVA: 0x000F71F0 File Offset: 0x000F53F0
		// (set) Token: 0x060031D1 RID: 12753 RVA: 0x00011A8E File Offset: 0x0000FC8E
		public unsafe Il2CppStructArray<byte> m_depadBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_depadBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x060031D2 RID: 12754 RVA: 0x000F7220 File Offset: 0x000F5420
		// (set) Token: 0x060031D3 RID: 12755 RVA: 0x00011AAD File Offset: 0x0000FCAD
		public unsafe Il2CppStructArray<byte> m_shiftRegister
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RijndaelManagedTransform.NativeFieldInfoPtr_m_shiftRegister), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060031D4 RID: 12756 RVA: 0x000F7250 File Offset: 0x000F5450
		// (set) Token: 0x060031D5 RID: 12757 RVA: 0x00011ACC File Offset: 0x0000FCCC
		public unsafe static Il2CppStructArray<byte> s_Sbox
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Sbox, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x060031D6 RID: 12758 RVA: 0x000F7278 File Offset: 0x000F5478
		// (set) Token: 0x060031D7 RID: 12759 RVA: 0x00011ADE File Offset: 0x0000FCDE
		public unsafe static Il2CppStructArray<int> s_Rcon
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_Rcon, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x060031D8 RID: 12760 RVA: 0x000F72A0 File Offset: 0x000F54A0
		// (set) Token: 0x060031D9 RID: 12761 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		public unsafe static Il2CppStructArray<int> s_T
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_T, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x060031DA RID: 12762 RVA: 0x000F72C8 File Offset: 0x000F54C8
		// (set) Token: 0x060031DB RID: 12763 RVA: 0x00011B02 File Offset: 0x0000FD02
		public unsafe static Il2CppStructArray<int> s_TF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_TF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x060031DC RID: 12764 RVA: 0x000F72F0 File Offset: 0x000F54F0
		// (set) Token: 0x060031DD RID: 12765 RVA: 0x00011B14 File Offset: 0x0000FD14
		public unsafe static Il2CppStructArray<int> s_iT
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iT, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060031DE RID: 12766 RVA: 0x000F7318 File Offset: 0x000F5518
		// (set) Token: 0x060031DF RID: 12767 RVA: 0x00011B26 File Offset: 0x0000FD26
		public unsafe static Il2CppStructArray<int> s_iTF
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RijndaelManagedTransform.NativeFieldInfoPtr_s_iTF, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002A86 RID: 10886
		private static readonly IntPtr NativeFieldInfoPtr_m_cipherMode;

		// Token: 0x04002A87 RID: 10887
		private static readonly IntPtr NativeFieldInfoPtr_m_paddingValue;

		// Token: 0x04002A88 RID: 10888
		private static readonly IntPtr NativeFieldInfoPtr_m_transformMode;

		// Token: 0x04002A89 RID: 10889
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBits;

		// Token: 0x04002A8A RID: 10890
		private static readonly IntPtr NativeFieldInfoPtr_m_blockSizeBytes;

		// Token: 0x04002A8B RID: 10891
		private static readonly IntPtr NativeFieldInfoPtr_m_inputBlockSize;

		// Token: 0x04002A8C RID: 10892
		private static readonly IntPtr NativeFieldInfoPtr_m_outputBlockSize;

		// Token: 0x04002A8D RID: 10893
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptKeyExpansion;

		// Token: 0x04002A8E RID: 10894
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptKeyExpansion;

		// Token: 0x04002A8F RID: 10895
		private static readonly IntPtr NativeFieldInfoPtr_m_Nr;

		// Token: 0x04002A90 RID: 10896
		private static readonly IntPtr NativeFieldInfoPtr_m_Nb;

		// Token: 0x04002A91 RID: 10897
		private static readonly IntPtr NativeFieldInfoPtr_m_Nk;

		// Token: 0x04002A92 RID: 10898
		private static readonly IntPtr NativeFieldInfoPtr_m_encryptindex;

		// Token: 0x04002A93 RID: 10899
		private static readonly IntPtr NativeFieldInfoPtr_m_decryptindex;

		// Token: 0x04002A94 RID: 10900
		private static readonly IntPtr NativeFieldInfoPtr_m_IV;

		// Token: 0x04002A95 RID: 10901
		private static readonly IntPtr NativeFieldInfoPtr_m_lastBlockBuffer;

		// Token: 0x04002A96 RID: 10902
		private static readonly IntPtr NativeFieldInfoPtr_m_depadBuffer;

		// Token: 0x04002A97 RID: 10903
		private static readonly IntPtr NativeFieldInfoPtr_m_shiftRegister;

		// Token: 0x04002A98 RID: 10904
		private static readonly IntPtr NativeFieldInfoPtr_s_Sbox;

		// Token: 0x04002A99 RID: 10905
		private static readonly IntPtr NativeFieldInfoPtr_s_Rcon;

		// Token: 0x04002A9A RID: 10906
		private static readonly IntPtr NativeFieldInfoPtr_s_T;

		// Token: 0x04002A9B RID: 10907
		private static readonly IntPtr NativeFieldInfoPtr_s_TF;

		// Token: 0x04002A9C RID: 10908
		private static readonly IntPtr NativeFieldInfoPtr_s_iT;

		// Token: 0x04002A9D RID: 10909
		private static readonly IntPtr NativeFieldInfoPtr_s_iTF;

		// Token: 0x04002A9E RID: 10910
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Il2CppStructArray_1_Byte_CipherMode_Il2CppStructArray_1_Byte_Int32_Int32_PaddingMode_RijndaelManagedTransformMode_0;

		// Token: 0x04002A9F RID: 10911
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002AA0 RID: 10912
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x04002AA1 RID: 10913
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002AA2 RID: 10914
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04002AA3 RID: 10915
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002AA4 RID: 10916
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_Final_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04002AA5 RID: 10917
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_Final_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04002AA6 RID: 10918
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04002AA7 RID: 10919
		private static readonly IntPtr NativeMethodInfoPtr_EncryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002AA8 RID: 10920
		private static readonly IntPtr NativeMethodInfoPtr_DecryptData_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_byref_Il2CppStructArray_1_Byte_Int32_PaddingMode_Boolean_0;

		// Token: 0x04002AA9 RID: 10921
		private static readonly IntPtr NativeMethodInfoPtr_Enc_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002AAA RID: 10922
		private static readonly IntPtr NativeMethodInfoPtr_Dec_Private_Void_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_ptr_Int32_0;

		// Token: 0x04002AAB RID: 10923
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKeyExpansion_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002AAC RID: 10924
		private static readonly IntPtr NativeMethodInfoPtr_rot1_Private_Static_Int32_Int32_0;

		// Token: 0x04002AAD RID: 10925
		private static readonly IntPtr NativeMethodInfoPtr_rot2_Private_Static_Int32_Int32_0;

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeMethodInfoPtr_rot3_Private_Static_Int32_Int32_0;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeMethodInfoPtr_SubWord_Private_Static_Int32_Int32_0;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeMethodInfoPtr_MulX_Private_Static_Int32_Int32_0;
	}
}
