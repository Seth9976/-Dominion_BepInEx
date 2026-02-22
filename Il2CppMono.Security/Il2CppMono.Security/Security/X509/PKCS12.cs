using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.Cryptography;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000008 RID: 8
	public class PKCS12 : Object
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00004828 File Offset: 0x00002A28
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS12()
		{
			Il2CppClassPointerStore<PKCS12>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "PKCS12");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12>.NativeClassPtr);
			PKCS12.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_password");
			PKCS12.NativeFieldInfoPtr__keyBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBags");
			PKCS12.NativeFieldInfoPtr__secretBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBags");
			PKCS12.NativeFieldInfoPtr__certs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certs");
			PKCS12.NativeFieldInfoPtr__keyBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_keyBagsChanged");
			PKCS12.NativeFieldInfoPtr__secretBagsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_secretBagsChanged");
			PKCS12.NativeFieldInfoPtr__certsChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_certsChanged");
			PKCS12.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_iterations");
			PKCS12.NativeFieldInfoPtr__safeBags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_safeBags");
			PKCS12.NativeFieldInfoPtr__rng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "_rng");
			PKCS12.NativeFieldInfoPtr_password_max_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "password_max_length");
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663346);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663347);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663348);
			PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663349);
			PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663350);
			PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663351);
			PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663352);
			PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663353);
			PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663354);
			PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663355);
			PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663356);
			PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663357);
			PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663358);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663359);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663360);
			PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663361);
			PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663362);
			PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663363);
			PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663364);
			PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663365);
			PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663366);
			PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663367);
			PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663368);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663369);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663370);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663371);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663372);
			PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663373);
			PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663374);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004B78 File Offset: 0x00002D78
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 6299, RefRangeEnd = 6303, XrefRangeStart = 6284, XrefRangeEnd = 6299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004BB4 File Offset: 0x00002DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6303, XrefRangeEnd = 6308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004C00 File Offset: 0x00002E00
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 6311, RefRangeEnd = 6314, XrefRangeStart = 6308, XrefRangeEnd = 6311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12(Il2CppStructArray<byte> data, string password)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004C60 File Offset: 0x00002E60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 6392, RefRangeEnd = 6395, XrefRangeStart = 6314, XrefRangeEnd = 6392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decode(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004CA4 File Offset: 0x00002EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6395, XrefRangeEnd = 6399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00004CE0 File Offset: 0x00002EE0
		public unsafe string Password
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 6404, RefRangeEnd = 6406, XrefRangeStart = 6399, XrefRangeEnd = 6404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004D24 File Offset: 0x00002F24
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00004D60 File Offset: 0x00002F60
		public unsafe int IterationCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004DA0 File Offset: 0x00002FA0
		public unsafe ArrayList Keys
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 6487, RefRangeEnd = 6489, XrefRangeStart = 6406, XrefRangeEnd = 6487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004DE0 File Offset: 0x00002FE0
		public unsafe X509CertificateCollection Certificates
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 6522, RefRangeEnd = 6530, XrefRangeStart = 6489, XrefRangeEnd = 6522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004E20 File Offset: 0x00003020
		public unsafe RandomNumberGenerator RNG
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6530, XrefRangeEnd = 6531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004E60 File Offset: 0x00003060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 6531, XrefRangeEnd = 6532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Compare(Il2CppStructArray<byte> expected, Il2CppStructArray<byte> actual)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expected);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actual);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004EC0 File Offset: 0x000030C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 6615, RefRangeEnd = 6617, XrefRangeStart = 6532, XrefRangeEnd = 6615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SymmetricAlgorithm>(intPtr3) : null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004F30 File Offset: 0x00003130
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 6623, RefRangeEnd = 6626, XrefRangeStart = 6617, XrefRangeEnd = 6623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> encryptedData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encryptedData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004FB4 File Offset: 0x000031B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 6632, RefRangeEnd = 6633, XrefRangeStart = 6626, XrefRangeEnd = 6632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Decrypt(PKCS7.EncryptedData ed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005004 File Offset: 0x00003204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 6641, RefRangeEnd = 6642, XrefRangeStart = 6633, XrefRangeEnd = 6641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> Encrypt(string algorithmOid, Il2CppStructArray<byte> salt, int iterationCount, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterationCount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005088 File Offset: 0x00003288
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 6657, RefRangeEnd = 6658, XrefRangeStart = 6642, XrefRangeEnd = 6657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSAParameters GetExistingParameters(out bool found)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &found;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000050CC File Offset: 0x000032CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 6675, RefRangeEnd = 6677, XrefRangeStart = 6658, XrefRangeEnd = 6675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrivateKey(Il2CppMono.Security.Cryptography.PKCS8.PrivateKeyInfo pki)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pki);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005110 File Offset: 0x00003310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 6819, RefRangeEnd = 6821, XrefRangeStart = 6677, XrefRangeEnd = 6819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadSafeBag(ASN1 safeBag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005154 File Offset: 0x00003354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 6965, RefRangeEnd = 6966, XrefRangeStart = 6821, XrefRangeEnd = 6965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000051B8 File Offset: 0x000033B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 6982, RefRangeEnd = 6985, XrefRangeStart = 6966, XrefRangeEnd = 6982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> MAC(Il2CppStructArray<byte> password, Il2CppStructArray<byte> salt, int iterations, Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(password);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(salt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iterations;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000523C File Offset: 0x0000343C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7380, RefRangeEnd = 7382, XrefRangeStart = 6985, XrefRangeEnd = 7380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBytes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000527C File Offset: 0x0000347C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7473, RefRangeEnd = 7475, XrefRangeStart = 7382, XrefRangeEnd = 7473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(safeBags);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(algorithmOid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000052E0 File Offset: 0x000034E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7475, XrefRangeEnd = 7476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005324 File Offset: 0x00003524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7501, RefRangeEnd = 7503, XrefRangeStart = 7476, XrefRangeEnd = 7501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attributes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005378 File Offset: 0x00003578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7503, XrefRangeEnd = 7506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000053BC File Offset: 0x000035BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 7551, RefRangeEnd = 7553, XrefRangeStart = 7506, XrefRangeEnd = 7551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00005410 File Offset: 0x00003610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7553, XrefRangeEnd = 7569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe static int MaximumPasswordLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 7569, XrefRangeEnd = 7573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000217B File Offset: 0x0000037B
		public PKCS12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00005480 File Offset: 0x00003680
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002184 File Offset: 0x00000384
		public unsafe Il2CppStructArray<byte> _password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000054B0 File Offset: 0x000036B0
		// (set) Token: 0x0600005C RID: 92 RVA: 0x000021A3 File Offset: 0x000003A3
		public unsafe ArrayList _keyBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000054E0 File Offset: 0x000036E0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000021C2 File Offset: 0x000003C2
		public unsafe ArrayList _secretBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00005510 File Offset: 0x00003710
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000021E1 File Offset: 0x000003E1
		public unsafe X509CertificateCollection _certs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00005540 File Offset: 0x00003740
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002200 File Offset: 0x00000400
		public unsafe bool _keyBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__keyBagsChanged)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00005568 File Offset: 0x00003768
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000221B File Offset: 0x0000041B
		public unsafe bool _secretBagsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__secretBagsChanged)) = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00005590 File Offset: 0x00003790
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002236 File Offset: 0x00000436
		public unsafe bool _certsChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__certsChanged)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000055B8 File Offset: 0x000037B8
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002251 File Offset: 0x00000451
		public unsafe int _iterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__iterations)) = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000055E0 File Offset: 0x000037E0
		// (set) Token: 0x0600006A RID: 106 RVA: 0x0000226C File Offset: 0x0000046C
		public unsafe ArrayList _safeBags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__safeBags), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x0600006C RID: 108 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe RandomNumberGenerator _rng
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RandomNumberGenerator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.NativeFieldInfoPtr__rng), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00005640 File Offset: 0x00003840
		// (set) Token: 0x0600006E RID: 110 RVA: 0x000022AA File Offset: 0x000004AA
		public unsafe static int password_max_length
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PKCS12.NativeFieldInfoPtr_password_max_length, (void*)(&value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr__keyBags;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__secretBags;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__certs;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__keyBagsChanged;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__secretBagsChanged;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeFieldInfoPtr__certsChanged;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__iterations;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__safeBags;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_password_max_length;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0;

		// Token: 0x0200003A RID: 58
		public class DeriveBytes : Object
		{
			// Token: 0x0600031F RID: 799 RVA: 0x0000ECF8 File Offset: 0x0000CEF8
			// Note: this type is marked as 'beforefieldinit'.
			static DeriveBytes()
			{
				Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, "DeriveBytes");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr);
				PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "keyDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "ivDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "macDiversifier");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_hashName");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_iterations");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_password");
				PKCS12.DeriveBytes.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, "_salt");
				PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663376);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663377);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663378);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663379);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663380);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663381);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663382);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663383);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663384);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663385);
			}

			// Token: 0x06000320 RID: 800 RVA: 0x0000EE78 File Offset: 0x0000D078
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5400, XrefRangeEnd = 5401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeriveBytes()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000112 RID: 274
			// (set) Token: 0x06000321 RID: 801 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
			public unsafe string HashName
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000113 RID: 275
			// (set) Token: 0x06000322 RID: 802 RVA: 0x0000EEF8 File Offset: 0x0000D0F8
			public unsafe int IterationCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000114 RID: 276
			// (set) Token: 0x06000323 RID: 803 RVA: 0x0000EF38 File Offset: 0x0000D138
			public unsafe Il2CppStructArray<byte> Password
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 6223, RefRangeEnd = 6225, XrefRangeStart = 6219, XrefRangeEnd = 6223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000115 RID: 277
			// (set) Token: 0x06000324 RID: 804 RVA: 0x0000EF7C File Offset: 0x0000D17C
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 6226, RefRangeEnd = 6228, XrefRangeStart = 6225, XrefRangeEnd = 6226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06000325 RID: 805 RVA: 0x0000EFC0 File Offset: 0x0000D1C0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 6228, RefRangeEnd = 6230, XrefRangeStart = 6228, XrefRangeEnd = 6228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Adjust(Il2CppStructArray<byte> a, int aOff, Il2CppStructArray<byte> b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref aOff;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000326 RID: 806 RVA: 0x0000F024 File Offset: 0x0000D224
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 6262, RefRangeEnd = 6265, XrefRangeStart = 6230, XrefRangeEnd = 6262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> Derive(Il2CppStructArray<byte> diversifier, int n)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(diversifier);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06000327 RID: 807 RVA: 0x0000F084 File Offset: 0x0000D284
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6270, RefRangeEnd = 6271, XrefRangeStart = 6265, XrefRangeEnd = 6270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveKey(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000328 RID: 808 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 6276, RefRangeEnd = 6277, XrefRangeStart = 6271, XrefRangeEnd = 6276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveIV(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06000329 RID: 809 RVA: 0x0000F11C File Offset: 0x0000D31C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 6282, RefRangeEnd = 6284, XrefRangeStart = 6277, XrefRangeEnd = 6282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppStructArray<byte> DeriveMAC(int size)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref size;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600032A RID: 810 RVA: 0x00003513 File Offset: 0x00001713
			public DeriveBytes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700010B RID: 267
			// (get) Token: 0x0600032B RID: 811 RVA: 0x0000F168 File Offset: 0x0000D368
			// (set) Token: 0x0600032C RID: 812 RVA: 0x0000351C File Offset: 0x0000171C
			public unsafe static Il2CppStructArray<byte> keyDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_keyDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010C RID: 268
			// (get) Token: 0x0600032D RID: 813 RVA: 0x0000F190 File Offset: 0x0000D390
			// (set) Token: 0x0600032E RID: 814 RVA: 0x0000352E File Offset: 0x0000172E
			public unsafe static Il2CppStructArray<byte> ivDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_ivDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010D RID: 269
			// (get) Token: 0x0600032F RID: 815 RVA: 0x0000F1B8 File Offset: 0x0000D3B8
			// (set) Token: 0x06000330 RID: 816 RVA: 0x00003540 File Offset: 0x00001740
			public unsafe static Il2CppStructArray<byte> macDiversifier
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PKCS12.DeriveBytes.NativeFieldInfoPtr_macDiversifier, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700010E RID: 270
			// (get) Token: 0x06000331 RID: 817 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
			// (set) Token: 0x06000332 RID: 818 RVA: 0x00003552 File Offset: 0x00001752
			public unsafe string _hashName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__hashName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700010F RID: 271
			// (get) Token: 0x06000333 RID: 819 RVA: 0x0000F208 File Offset: 0x0000D408
			// (set) Token: 0x06000334 RID: 820 RVA: 0x00003571 File Offset: 0x00001771
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x17000110 RID: 272
			// (get) Token: 0x06000335 RID: 821 RVA: 0x0000F230 File Offset: 0x0000D430
			// (set) Token: 0x06000336 RID: 822 RVA: 0x0000358C File Offset: 0x0000178C
			public unsafe Il2CppStructArray<byte> _password
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__password), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000111 RID: 273
			// (get) Token: 0x06000337 RID: 823 RVA: 0x0000F260 File Offset: 0x0000D460
			// (set) Token: 0x06000338 RID: 824 RVA: 0x000035AB File Offset: 0x000017AB
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS12.DeriveBytes.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000356 RID: 854
			private static readonly IntPtr NativeFieldInfoPtr_keyDiversifier;

			// Token: 0x04000357 RID: 855
			private static readonly IntPtr NativeFieldInfoPtr_ivDiversifier;

			// Token: 0x04000358 RID: 856
			private static readonly IntPtr NativeFieldInfoPtr_macDiversifier;

			// Token: 0x04000359 RID: 857
			private static readonly IntPtr NativeFieldInfoPtr__hashName;

			// Token: 0x0400035A RID: 858
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x0400035B RID: 859
			private static readonly IntPtr NativeFieldInfoPtr__password;

			// Token: 0x0400035C RID: 860
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x0400035D RID: 861
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400035E RID: 862
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x0400035F RID: 863
			private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

			// Token: 0x04000360 RID: 864
			private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000361 RID: 865
			private static readonly IntPtr NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000362 RID: 866
			private static readonly IntPtr NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000363 RID: 867
			private static readonly IntPtr NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000364 RID: 868
			private static readonly IntPtr NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000365 RID: 869
			private static readonly IntPtr NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000366 RID: 870
			private static readonly IntPtr NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0;
		}
	}
}
