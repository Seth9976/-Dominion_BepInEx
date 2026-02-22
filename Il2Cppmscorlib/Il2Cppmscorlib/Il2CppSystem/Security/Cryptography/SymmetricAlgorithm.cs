using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200030F RID: 783
	public class SymmetricAlgorithm : Object
	{
		// Token: 0x060032CE RID: 13006 RVA: 0x000FA7D4 File Offset: 0x000F89D4
		// Note: this type is marked as 'beforefieldinit'.
		static SymmetricAlgorithm()
		{
			Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "SymmetricAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr);
			SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "BlockSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "FeedbackSizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_IVValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "IVValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeyValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalBlockSizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "LegalKeySizesValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "KeySizeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "ModeValue");
			SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, "PaddingValue");
			SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671208);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671209);
			SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671210);
			SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671211);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671212);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671213);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671214);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671215);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671216);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671217);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671218);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671219);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671220);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671221);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671222);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671223);
			SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671224);
			SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671225);
			SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671226);
			SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671227);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671228);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671229);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671230);
			SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671231);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671232);
			SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr, 100671233);
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x000FAAC0 File Offset: 0x000F8CC0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 341075, RefRangeEnd = 341086, XrefRangeStart = 341074, XrefRangeEnd = 341075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SymmetricAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D0 RID: 13008 RVA: 0x000FAAFC File Offset: 0x000F8CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341086, XrefRangeEnd = 341090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x000FAB30 File Offset: 0x000F8D30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 341093, RefRangeEnd = 341098, XrefRangeStart = 341090, XrefRangeEnd = 341093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x000FAB64 File Offset: 0x000F8D64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 341100, RefRangeEnd = 341103, XrefRangeStart = 341098, XrefRangeEnd = 341100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x060032D3 RID: 13011 RVA: 0x000FABB0 File Offset: 0x000F8DB0
		// (set) Token: 0x060032D4 RID: 13012 RVA: 0x000FABF8 File Offset: 0x000F8DF8
		public unsafe virtual int BlockSize
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341103, XrefRangeEnd = 341106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x060032D5 RID: 13013 RVA: 0x000FAC44 File Offset: 0x000F8E44
		public unsafe virtual int FeedbackSize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x000FAC8C File Offset: 0x000F8E8C
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x000FACD8 File Offset: 0x000F8ED8
		public unsafe virtual Il2CppStructArray<byte> IV
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341109, RefRangeEnd = 341110, XrefRangeStart = 341106, XrefRangeEnd = 341109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341114, RefRangeEnd = 341115, XrefRangeStart = 341110, XrefRangeEnd = 341114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x000FAD28 File Offset: 0x000F8F28
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x000FAD74 File Offset: 0x000F8F74
		public unsafe virtual Il2CppStructArray<byte> Key
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341118, RefRangeEnd = 341119, XrefRangeStart = 341115, XrefRangeEnd = 341118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341124, RefRangeEnd = 341125, XrefRangeStart = 341119, XrefRangeEnd = 341124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x000FADC4 File Offset: 0x000F8FC4
		public unsafe virtual Il2CppReferenceArray<KeySizes> LegalKeySizes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 341125, XrefRangeEnd = 341128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr3) : null;
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x060032DB RID: 13019 RVA: 0x000FAE10 File Offset: 0x000F9010
		// (set) Token: 0x060032DC RID: 13020 RVA: 0x000FAE58 File Offset: 0x000F9058
		public unsafe virtual int KeySize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 341129, RefRangeEnd = 341131, XrefRangeStart = 341128, XrefRangeEnd = 341129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x060032DD RID: 13021 RVA: 0x000FAEA4 File Offset: 0x000F90A4
		// (set) Token: 0x060032DE RID: 13022 RVA: 0x000FAEEC File Offset: 0x000F90EC
		public unsafe virtual CipherMode Mode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341131, RefRangeEnd = 341132, XrefRangeStart = 341131, XrefRangeEnd = 341131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x060032DF RID: 13023 RVA: 0x000FAF38 File Offset: 0x000F9138
		// (set) Token: 0x060032E0 RID: 13024 RVA: 0x000FAF80 File Offset: 0x000F9180
		public unsafe virtual PaddingMode Padding
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 341132, RefRangeEnd = 341133, XrefRangeStart = 341132, XrefRangeEnd = 341132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x000FAFCC File Offset: 0x000F91CC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 341135, RefRangeEnd = 341141, XrefRangeStart = 341133, XrefRangeEnd = 341135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidKeySize(int bitLength)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bitLength;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060032E2 RID: 13026 RVA: 0x000FB018 File Offset: 0x000F9218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 341144, RefRangeEnd = 341145, XrefRangeStart = 341141, XrefRangeEnd = 341144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SymmetricAlgorithm Create(string algName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SymmetricAlgorithm.NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x060032E3 RID: 13027 RVA: 0x000FB05C File Offset: 0x000F925C
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060032E4 RID: 13028 RVA: 0x000FB0A8 File Offset: 0x000F92A8
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateEncryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x000FB118 File Offset: 0x000F9318
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060032E6 RID: 13030 RVA: 0x000FB164 File Offset: 0x000F9364
		[CallerCount(0)]
		public unsafe virtual ICryptoTransform CreateDecryptor(Il2CppStructArray<byte> rgbKey, Il2CppStructArray<byte> rgbIV)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rgbIV);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICryptoTransform>(intPtr3) : null;
		}

		// Token: 0x060032E7 RID: 13031 RVA: 0x000FB1D4 File Offset: 0x000F93D4
		[CallerCount(0)]
		public unsafe virtual void GenerateKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E8 RID: 13032 RVA: 0x000FB210 File Offset: 0x000F9410
		[CallerCount(0)]
		public unsafe virtual void GenerateIV()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SymmetricAlgorithm.NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032E9 RID: 13033 RVA: 0x000121F4 File Offset: 0x000103F4
		public SymmetricAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x060032EA RID: 13034 RVA: 0x000FB24C File Offset: 0x000F944C
		// (set) Token: 0x060032EB RID: 13035 RVA: 0x000121FD File Offset: 0x000103FD
		public unsafe int BlockSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_BlockSizeValue)) = value;
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x060032EC RID: 13036 RVA: 0x000FB274 File Offset: 0x000F9474
		// (set) Token: 0x060032ED RID: 13037 RVA: 0x00012218 File Offset: 0x00010418
		public unsafe int FeedbackSizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_FeedbackSizeValue)) = value;
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x060032EE RID: 13038 RVA: 0x000FB29C File Offset: 0x000F949C
		// (set) Token: 0x060032EF RID: 13039 RVA: 0x00012233 File Offset: 0x00010433
		public unsafe Il2CppStructArray<byte> IVValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_IVValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x060032F0 RID: 13040 RVA: 0x000FB2CC File Offset: 0x000F94CC
		// (set) Token: 0x060032F1 RID: 13041 RVA: 0x00012252 File Offset: 0x00010452
		public unsafe Il2CppStructArray<byte> KeyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x060032F2 RID: 13042 RVA: 0x000FB2FC File Offset: 0x000F94FC
		// (set) Token: 0x060032F3 RID: 13043 RVA: 0x00012271 File Offset: 0x00010471
		public unsafe Il2CppReferenceArray<KeySizes> LegalBlockSizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalBlockSizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x060032F4 RID: 13044 RVA: 0x000FB32C File Offset: 0x000F952C
		// (set) Token: 0x060032F5 RID: 13045 RVA: 0x00012290 File Offset: 0x00010490
		public unsafe Il2CppReferenceArray<KeySizes> LegalKeySizesValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_LegalKeySizesValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x060032F6 RID: 13046 RVA: 0x000FB35C File Offset: 0x000F955C
		// (set) Token: 0x060032F7 RID: 13047 RVA: 0x000122AF File Offset: 0x000104AF
		public unsafe int KeySizeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_KeySizeValue)) = value;
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x060032F8 RID: 13048 RVA: 0x000FB384 File Offset: 0x000F9584
		// (set) Token: 0x060032F9 RID: 13049 RVA: 0x000122CA File Offset: 0x000104CA
		public unsafe CipherMode ModeValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_ModeValue)) = value;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x060032FA RID: 13050 RVA: 0x000FB3AC File Offset: 0x000F95AC
		// (set) Token: 0x060032FB RID: 13051 RVA: 0x000122E5 File Offset: 0x000104E5
		public unsafe PaddingMode PaddingValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SymmetricAlgorithm.NativeFieldInfoPtr_PaddingValue)) = value;
			}
		}

		// Token: 0x04002B4B RID: 11083
		private static readonly IntPtr NativeFieldInfoPtr_BlockSizeValue;

		// Token: 0x04002B4C RID: 11084
		private static readonly IntPtr NativeFieldInfoPtr_FeedbackSizeValue;

		// Token: 0x04002B4D RID: 11085
		private static readonly IntPtr NativeFieldInfoPtr_IVValue;

		// Token: 0x04002B4E RID: 11086
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04002B4F RID: 11087
		private static readonly IntPtr NativeFieldInfoPtr_LegalBlockSizesValue;

		// Token: 0x04002B50 RID: 11088
		private static readonly IntPtr NativeFieldInfoPtr_LegalKeySizesValue;

		// Token: 0x04002B51 RID: 11089
		private static readonly IntPtr NativeFieldInfoPtr_KeySizeValue;

		// Token: 0x04002B52 RID: 11090
		private static readonly IntPtr NativeFieldInfoPtr_ModeValue;

		// Token: 0x04002B53 RID: 11091
		private static readonly IntPtr NativeFieldInfoPtr_PaddingValue;

		// Token: 0x04002B54 RID: 11092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002B55 RID: 11093
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002B56 RID: 11094
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04002B57 RID: 11095
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002B58 RID: 11096
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002B59 RID: 11097
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockSize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002B5A RID: 11098
		private static readonly IntPtr NativeMethodInfoPtr_get_FeedbackSize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002B5B RID: 11099
		private static readonly IntPtr NativeMethodInfoPtr_get_IV_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B5C RID: 11100
		private static readonly IntPtr NativeMethodInfoPtr_set_IV_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B5D RID: 11101
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B5E RID: 11102
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B5F RID: 11103
		private static readonly IntPtr NativeMethodInfoPtr_get_LegalKeySizes_Public_Virtual_New_get_Il2CppReferenceArray_1_KeySizes_0;

		// Token: 0x04002B60 RID: 11104
		private static readonly IntPtr NativeMethodInfoPtr_get_KeySize_Public_Virtual_New_get_Int32_0;

		// Token: 0x04002B61 RID: 11105
		private static readonly IntPtr NativeMethodInfoPtr_set_KeySize_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04002B62 RID: 11106
		private static readonly IntPtr NativeMethodInfoPtr_get_Mode_Public_Virtual_New_get_CipherMode_0;

		// Token: 0x04002B63 RID: 11107
		private static readonly IntPtr NativeMethodInfoPtr_set_Mode_Public_Virtual_New_set_Void_CipherMode_0;

		// Token: 0x04002B64 RID: 11108
		private static readonly IntPtr NativeMethodInfoPtr_get_Padding_Public_Virtual_New_get_PaddingMode_0;

		// Token: 0x04002B65 RID: 11109
		private static readonly IntPtr NativeMethodInfoPtr_set_Padding_Public_Virtual_New_set_Void_PaddingMode_0;

		// Token: 0x04002B66 RID: 11110
		private static readonly IntPtr NativeMethodInfoPtr_ValidKeySize_Public_Boolean_Int32_0;

		// Token: 0x04002B67 RID: 11111
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_SymmetricAlgorithm_String_0;

		// Token: 0x04002B68 RID: 11112
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002B69 RID: 11113
		private static readonly IntPtr NativeMethodInfoPtr_CreateEncryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B6A RID: 11114
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Virtual_New_ICryptoTransform_0;

		// Token: 0x04002B6B RID: 11115
		private static readonly IntPtr NativeMethodInfoPtr_CreateDecryptor_Public_Abstract_Virtual_New_ICryptoTransform_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeMethodInfoPtr_GenerateKey_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIV_Public_Abstract_Virtual_New_Void_0;
	}
}
