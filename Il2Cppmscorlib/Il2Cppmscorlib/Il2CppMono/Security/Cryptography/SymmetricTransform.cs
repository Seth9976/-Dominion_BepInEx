using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000034 RID: 52
	public class SymmetricTransform : Object
	{
		// Token: 0x06000364 RID: 868 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		// Note: this type is marked as 'beforefieldinit'.
		static SymmetricTransform()
		{
			Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "SymmetricTransform");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr);
			SymmetricTransform.NativeFieldInfoPtr_algo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "algo");
			SymmetricTransform.NativeFieldInfoPtr_encrypt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "encrypt");
			SymmetricTransform.NativeFieldInfoPtr_BlockSizeByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "BlockSizeByte");
			SymmetricTransform.NativeFieldInfoPtr_temp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "temp");
			SymmetricTransform.NativeFieldInfoPtr_temp2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "temp2");
			SymmetricTransform.NativeFieldInfoPtr_workBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "workBuff");
			SymmetricTransform.NativeFieldInfoPtr_workout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "workout");
			SymmetricTransform.NativeFieldInfoPtr_padmode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "padmode");
			SymmetricTransform.NativeFieldInfoPtr_FeedBackByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "FeedBackByte");
			SymmetricTransform.NativeFieldInfoPtr_m_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "m_disposed");
			SymmetricTransform.NativeFieldInfoPtr_lastBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "lastBlock");
			SymmetricTransform.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, "_rng");
			SymmetricTransform.NativeMethodInfoPtr__ctor_Public_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663748);
			SymmetricTransform.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663749);
			SymmetricTransform.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663750);
			SymmetricTransform.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663751);
			SymmetricTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663752);
			SymmetricTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663753);
			SymmetricTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663754);
			SymmetricTransform.NativeMethodInfoPtr_Transform_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663755);
			SymmetricTransform.NativeMethodInfoPtr_ECB_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663756);
			SymmetricTransform.NativeMethodInfoPtr_CBC_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663757);
			SymmetricTransform.NativeMethodInfoPtr_CFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663758);
			SymmetricTransform.NativeMethodInfoPtr_OFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663759);
			SymmetricTransform.NativeMethodInfoPtr_CTS_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663760);
			SymmetricTransform.NativeMethodInfoPtr_CheckInput_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663761);
			SymmetricTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663762);
			SymmetricTransform.NativeMethodInfoPtr_get_KeepLastBlock_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663763);
			SymmetricTransform.NativeMethodInfoPtr_InternalTransformBlock_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663764);
			SymmetricTransform.NativeMethodInfoPtr_Random_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663765);
			SymmetricTransform.NativeMethodInfoPtr_ThrowBadPaddingException_Private_Void_PaddingMode_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663766);
			SymmetricTransform.NativeMethodInfoPtr_FinalEncrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663767);
			SymmetricTransform.NativeMethodInfoPtr_FinalDecrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663768);
			SymmetricTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr, 100663769);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0002F4BC File Offset: 0x0002D6BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 263455, RefRangeEnd = 263459, XrefRangeStart = 263435, XrefRangeEnd = 263455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, Il2CppStructArray<byte> rgbIV)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymmetricTransform>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(symmAlgo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encryption;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr__ctor_Public_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x0002F528 File Offset: 0x0002D728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263459, XrefRangeEnd = 263462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0002F564 File Offset: 0x0002D764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263462, XrefRangeEnd = 263466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0002F598 File Offset: 0x0002D798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263466, XrefRangeEnd = 263468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		public unsafe virtual bool CanTransformMultipleBlocks
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0002F62C File Offset: 0x0002D82C
		public unsafe virtual int InputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0002F674 File Offset: 0x0002D874
		public unsafe virtual int OutputBlockSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0002F6BC File Offset: 0x0002D8BC
		[CallerCount(0)]
		public unsafe virtual void Transform(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_Transform_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0002F71C File Offset: 0x0002D91C
		[CallerCount(0)]
		public unsafe virtual void ECB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_ECB_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0002F77C File Offset: 0x0002D97C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263468, XrefRangeEnd = 263471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CBC(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_CBC_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0002F7DC File Offset: 0x0002D9DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263471, XrefRangeEnd = 263473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CFB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_CFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0002F83C File Offset: 0x0002DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263473, XrefRangeEnd = 263479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OFB(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_OFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0002F89C File Offset: 0x0002DA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263479, XrefRangeEnd = 263485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CTS(Il2CppStructArray<byte> input, Il2CppStructArray<byte> output)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(output);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_CTS_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0002F8FC File Offset: 0x0002DAFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263485, RefRangeEnd = 263487, XrefRangeStart = 263485, XrefRangeEnd = 263485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInput(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_CheckInput_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0002F95C File Offset: 0x0002DB5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263487, XrefRangeEnd = 263534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int TransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_TransformBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000374 RID: 884 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		public unsafe bool KeepLastBlock
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_get_KeepLastBlock_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0002FA30 File Offset: 0x0002DC30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263541, RefRangeEnd = 263543, XrefRangeStart = 263534, XrefRangeEnd = 263541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int InternalTransformBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount, Il2CppStructArray<byte> outputBuffer, int outputOffset)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_InternalTransformBlock_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0002FABC File Offset: 0x0002DCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263543, XrefRangeEnd = 263548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Random(Il2CppStructArray<byte> buffer, int start, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_Random_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263548, XrefRangeEnd = 263570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowBadPaddingException(PaddingMode padding, int length, int position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref padding;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricTransform.NativeMethodInfoPtr_ThrowBadPaddingException_Private_Void_PaddingMode_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0002FB78 File Offset: 0x0002DD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263570, XrefRangeEnd = 263577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> FinalEncrypt(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_FinalEncrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0002FBF0 File Offset: 0x0002DDF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263577, XrefRangeEnd = 263585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> FinalDecrypt(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_FinalDecrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0002FC68 File Offset: 0x0002DE68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263585, XrefRangeEnd = 263586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> TransformFinalBlock(Il2CppStructArray<byte> inputBuffer, int inputOffset, int inputCount)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricTransform.NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000036FB File Offset: 0x000018FB
		public SymmetricTransform(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002FCE0 File Offset: 0x0002DEE0
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00003704 File Offset: 0x00001904
		public unsafe SymmetricAlgorithm algo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_algo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_algo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0002FD10 File Offset: 0x0002DF10
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00003723 File Offset: 0x00001923
		public unsafe bool encrypt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_encrypt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_encrypt)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0002FD38 File Offset: 0x0002DF38
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000373E File Offset: 0x0000193E
		public unsafe int BlockSizeByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_BlockSizeByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_BlockSizeByte)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0002FD60 File Offset: 0x0002DF60
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00003759 File Offset: 0x00001959
		public unsafe Il2CppStructArray<byte> temp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_temp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_temp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0002FD90 File Offset: 0x0002DF90
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00003778 File Offset: 0x00001978
		public unsafe Il2CppStructArray<byte> temp2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_temp2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_temp2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00003797 File Offset: 0x00001997
		public unsafe Il2CppStructArray<byte> workBuff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_workBuff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_workBuff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0002FDF0 File Offset: 0x0002DFF0
		// (set) Token: 0x06000389 RID: 905 RVA: 0x000037B6 File Offset: 0x000019B6
		public unsafe Il2CppStructArray<byte> workout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_workout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_workout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0002FE20 File Offset: 0x0002E020
		// (set) Token: 0x0600038B RID: 907 RVA: 0x000037D5 File Offset: 0x000019D5
		public unsafe PaddingMode padmode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_padmode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_padmode)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0002FE48 File Offset: 0x0002E048
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000037F0 File Offset: 0x000019F0
		public unsafe int FeedBackByte
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_FeedBackByte);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_FeedBackByte)) = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0002FE70 File Offset: 0x0002E070
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000380B File Offset: 0x00001A0B
		public unsafe bool m_disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_m_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_m_disposed)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0002FE98 File Offset: 0x0002E098
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00003826 File Offset: 0x00001A26
		public unsafe bool lastBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_lastBlock);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr_lastBlock)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0002FEC0 File Offset: 0x0002E0C0
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00003841 File Offset: 0x00001A41
		public unsafe RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr__rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricTransform.NativeFieldInfoPtr__rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeFieldInfoPtr_algo;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeFieldInfoPtr_encrypt;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeFieldInfoPtr_BlockSizeByte;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeFieldInfoPtr_temp;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeFieldInfoPtr_temp2;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeFieldInfoPtr_workBuff;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeFieldInfoPtr_workout;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_padmode;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_FeedBackByte;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_disposed;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_lastBlock;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SymmetricAlgorithm_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_get_CanTransformMultipleBlocks_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputBlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_Transform_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_ECB_Protected_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_CBC_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_CFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_OFB_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_CTS_Protected_Virtual_New_Void_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_CheckInput_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_TransformBlock_Public_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_get_KeepLastBlock_Private_get_Boolean_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr_InternalTransformBlock_Private_Int32_Il2CppStructArray_1_Byte_Int32_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_Random_Private_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeMethodInfoPtr_ThrowBadPaddingException_Private_Void_PaddingMode_Int32_Int32_0;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr_FinalEncrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_FinalDecrypt_Protected_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_TransformFinalBlock_Public_Virtual_New_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Int32_0;
	}
}
