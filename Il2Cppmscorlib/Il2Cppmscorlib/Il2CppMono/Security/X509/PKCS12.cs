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
	// Token: 0x02000023 RID: 35
	public class PKCS12 : Object
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00029E18 File Offset: 0x00028018
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS12()
		{
			Il2CppClassPointerStore<PKCS12>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "PKCS12");
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
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663555);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663556);
			PKCS12.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663557);
			PKCS12.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663558);
			PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663559);
			PKCS12.NativeMethodInfoPtr_set_Password_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663560);
			PKCS12.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663561);
			PKCS12.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663562);
			PKCS12.NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663563);
			PKCS12.NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663564);
			PKCS12.NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663565);
			PKCS12.NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663566);
			PKCS12.NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663567);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663568);
			PKCS12.NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663569);
			PKCS12.NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663570);
			PKCS12.NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663571);
			PKCS12.NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663572);
			PKCS12.NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663573);
			PKCS12.NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663574);
			PKCS12.NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663575);
			PKCS12.NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663576);
			PKCS12.NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663577);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663578);
			PKCS12.NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663579);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663580);
			PKCS12.NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663581);
			PKCS12.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663582);
			PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12>.NativeClassPtr, 100663583);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0002A168 File Offset: 0x00028368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 260629, RefRangeEnd = 260633, XrefRangeStart = 260615, XrefRangeEnd = 260629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PKCS12()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0002A1A4 File Offset: 0x000283A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260638, RefRangeEnd = 260639, XrefRangeStart = 260633, XrefRangeEnd = 260638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001EB RID: 491 RVA: 0x0002A1F0 File Offset: 0x000283F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260642, RefRangeEnd = 260643, XrefRangeStart = 260639, XrefRangeEnd = 260642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001EC RID: 492 RVA: 0x0002A250 File Offset: 0x00028450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260723, RefRangeEnd = 260726, XrefRangeStart = 260643, XrefRangeEnd = 260723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001ED RID: 493 RVA: 0x0002A294 File Offset: 0x00028494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260726, XrefRangeEnd = 260728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PKCS12.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700008A RID: 138
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0002A2D0 File Offset: 0x000284D0
		public unsafe string Password
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260733, RefRangeEnd = 260735, XrefRangeStart = 260728, XrefRangeEnd = 260733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0002A314 File Offset: 0x00028514
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0002A350 File Offset: 0x00028550
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

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0002A390 File Offset: 0x00028590
		public unsafe ArrayList Keys
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260816, RefRangeEnd = 260818, XrefRangeStart = 260735, XrefRangeEnd = 260816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0002A3D0 File Offset: 0x000285D0
		public unsafe X509CertificateCollection Certificates
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260851, RefRangeEnd = 260856, XrefRangeStart = 260818, XrefRangeEnd = 260851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x0002A410 File Offset: 0x00028610
		public unsafe RandomNumberGenerator RNG
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F4 RID: 500 RVA: 0x0002A450 File Offset: 0x00028650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F5 RID: 501 RVA: 0x0002A4B0 File Offset: 0x000286B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260964, RefRangeEnd = 260966, XrefRangeStart = 260856, XrefRangeEnd = 260964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F6 RID: 502 RVA: 0x0002A520 File Offset: 0x00028720
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260972, RefRangeEnd = 260975, XrefRangeStart = 260966, XrefRangeEnd = 260972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F7 RID: 503 RVA: 0x0002A5A4 File Offset: 0x000287A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260981, RefRangeEnd = 260982, XrefRangeStart = 260975, XrefRangeEnd = 260981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F8 RID: 504 RVA: 0x0002A5F4 File Offset: 0x000287F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260990, RefRangeEnd = 260991, XrefRangeStart = 260982, XrefRangeEnd = 260990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001F9 RID: 505 RVA: 0x0002A678 File Offset: 0x00028878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261003, RefRangeEnd = 261004, XrefRangeStart = 260991, XrefRangeEnd = 261003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001FA RID: 506 RVA: 0x0002A6BC File Offset: 0x000288BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261021, RefRangeEnd = 261023, XrefRangeStart = 261004, XrefRangeEnd = 261021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
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

		// Token: 0x060001FB RID: 507 RVA: 0x0002A700 File Offset: 0x00028900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261160, RefRangeEnd = 261162, XrefRangeStart = 261023, XrefRangeEnd = 261160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001FC RID: 508 RVA: 0x0002A744 File Offset: 0x00028944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261276, RefRangeEnd = 261277, XrefRangeStart = 261162, XrefRangeEnd = 261276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001FD RID: 509 RVA: 0x0002A7A8 File Offset: 0x000289A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 261293, RefRangeEnd = 261296, XrefRangeStart = 261277, XrefRangeEnd = 261293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001FE RID: 510 RVA: 0x0002A82C File Offset: 0x00028A2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261633, RefRangeEnd = 261635, XrefRangeStart = 261296, XrefRangeEnd = 261633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060001FF RID: 511 RVA: 0x0002A86C File Offset: 0x00028A6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261688, RefRangeEnd = 261690, XrefRangeStart = 261635, XrefRangeEnd = 261688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000200 RID: 512 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261690, XrefRangeEnd = 261691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000201 RID: 513 RVA: 0x0002A914 File Offset: 0x00028B14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261716, RefRangeEnd = 261718, XrefRangeStart = 261691, XrefRangeEnd = 261716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000202 RID: 514 RVA: 0x0002A968 File Offset: 0x00028B68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261718, XrefRangeEnd = 261719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000203 RID: 515 RVA: 0x0002A9AC File Offset: 0x00028BAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 261765, RefRangeEnd = 261767, XrefRangeStart = 261719, XrefRangeEnd = 261765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000204 RID: 516 RVA: 0x0002AA00 File Offset: 0x00028C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261767, XrefRangeEnd = 261783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0002AA40 File Offset: 0x00028C40
		public unsafe static int MaximumPasswordLength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261783, XrefRangeEnd = 261787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002C54 File Offset: 0x00000E54
		public PKCS12(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000207 RID: 519 RVA: 0x0002AA70 File Offset: 0x00028C70
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002C5D File Offset: 0x00000E5D
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

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000209 RID: 521 RVA: 0x0002AAA0 File Offset: 0x00028CA0
		// (set) Token: 0x0600020A RID: 522 RVA: 0x00002C7C File Offset: 0x00000E7C
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600020B RID: 523 RVA: 0x0002AAD0 File Offset: 0x00028CD0
		// (set) Token: 0x0600020C RID: 524 RVA: 0x00002C9B File Offset: 0x00000E9B
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

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0002AB00 File Offset: 0x00028D00
		// (set) Token: 0x0600020E RID: 526 RVA: 0x00002CBA File Offset: 0x00000EBA
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

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0002AB30 File Offset: 0x00028D30
		// (set) Token: 0x06000210 RID: 528 RVA: 0x00002CD9 File Offset: 0x00000ED9
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

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0002AB58 File Offset: 0x00028D58
		// (set) Token: 0x06000212 RID: 530 RVA: 0x00002CF4 File Offset: 0x00000EF4
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

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000213 RID: 531 RVA: 0x0002AB80 File Offset: 0x00028D80
		// (set) Token: 0x06000214 RID: 532 RVA: 0x00002D0F File Offset: 0x00000F0F
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

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D2A File Offset: 0x00000F2A
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

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0002ABD0 File Offset: 0x00028DD0
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00002D45 File Offset: 0x00000F45
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

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0002AC00 File Offset: 0x00028E00
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00002D64 File Offset: 0x00000F64
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

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0002AC30 File Offset: 0x00028E30
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002D83 File Offset: 0x00000F83
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

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr__password;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr__keyBags;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr__secretBags;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr__certs;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr__keyBagsChanged;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr__secretBagsChanged;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr__certsChanged;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr__iterations;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr__safeBags;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr__rng;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_password_max_length;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_String_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_get_ArrayList_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_get_Certificates_Public_get_X509CertificateCollection_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_get_RNG_Internal_get_RandomNumberGenerator_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Private_Boolean_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_GetSymmetricAlgorithm_Private_SymmetricAlgorithm_String_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Public_Il2CppStructArray_1_Byte_EncryptedData_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Public_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_GetExistingParameters_Private_DSAParameters_byref_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_AddPrivateKey_Private_Void_PrivateKeyInfo_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_ReadSafeBag_Private_Void_ASN1_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_CertificateSafeBag_Private_ASN1_X509Certificate_IDictionary_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_MAC_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeMethodInfoPtr_EncryptedContentInfo_Private_ContentInfo_ASN1_String_0;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_0;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeMethodInfoPtr_AddCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_0;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCertificate_Public_Void_X509Certificate_IDictionary_0;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeMethodInfoPtr_get_MaximumPasswordLength_Public_Static_get_Int32_0;

		// Token: 0x02000541 RID: 1345
		public class DeriveBytes : Object
		{
			// Token: 0x06004DC4 RID: 19908 RVA: 0x0015EC94 File Offset: 0x0015CE94
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
				PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663585);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663586);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663587);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663588);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663589);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663590);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663591);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663592);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663593);
				PKCS12.DeriveBytes.NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr, 100663594);
			}

			// Token: 0x06004DC5 RID: 19909 RVA: 0x0015EE14 File Offset: 0x0015D014
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DeriveBytes()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS12.DeriveBytes>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS12.DeriveBytes.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170013D7 RID: 5079
			// (set) Token: 0x06004DC6 RID: 19910 RVA: 0x0015EE50 File Offset: 0x0015D050
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

			// Token: 0x170013D8 RID: 5080
			// (set) Token: 0x06004DC7 RID: 19911 RVA: 0x0015EE94 File Offset: 0x0015D094
			public unsafe int IterationCount
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 6218, RefRangeEnd = 6219, XrefRangeStart = 6218, XrefRangeEnd = 6219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x170013D9 RID: 5081
			// (set) Token: 0x06004DC8 RID: 19912 RVA: 0x0015EED4 File Offset: 0x0015D0D4
			public unsafe Il2CppStructArray<byte> Password
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260556, RefRangeEnd = 260558, XrefRangeStart = 260552, XrefRangeEnd = 260556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x170013DA RID: 5082
			// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x0015EF18 File Offset: 0x0015D118
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 260559, RefRangeEnd = 260561, XrefRangeStart = 260558, XrefRangeEnd = 260559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCA RID: 19914 RVA: 0x0015EF5C File Offset: 0x0015D15C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 6228, RefRangeEnd = 6230, XrefRangeStart = 6228, XrefRangeEnd = 6230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCB RID: 19915 RVA: 0x0015EFC0 File Offset: 0x0015D1C0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260593, RefRangeEnd = 260596, XrefRangeStart = 260561, XrefRangeEnd = 260593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCC RID: 19916 RVA: 0x0015F020 File Offset: 0x0015D220
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260601, RefRangeEnd = 260602, XrefRangeStart = 260596, XrefRangeEnd = 260601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCD RID: 19917 RVA: 0x0015F06C File Offset: 0x0015D26C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260607, RefRangeEnd = 260608, XrefRangeStart = 260602, XrefRangeEnd = 260607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCE RID: 19918 RVA: 0x0015F0B8 File Offset: 0x0015D2B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 260613, RefRangeEnd = 260615, XrefRangeStart = 260608, XrefRangeEnd = 260613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06004DCF RID: 19919 RVA: 0x0001D726 File Offset: 0x0001B926
			public DeriveBytes(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013D0 RID: 5072
			// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x0015F104 File Offset: 0x0015D304
			// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x0001D72F File Offset: 0x0001B92F
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

			// Token: 0x170013D1 RID: 5073
			// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x0015F12C File Offset: 0x0015D32C
			// (set) Token: 0x06004DD3 RID: 19923 RVA: 0x0001D741 File Offset: 0x0001B941
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

			// Token: 0x170013D2 RID: 5074
			// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x0015F154 File Offset: 0x0015D354
			// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x0001D753 File Offset: 0x0001B953
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

			// Token: 0x170013D3 RID: 5075
			// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x0015F17C File Offset: 0x0015D37C
			// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x0001D765 File Offset: 0x0001B965
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

			// Token: 0x170013D4 RID: 5076
			// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x0015F1A4 File Offset: 0x0015D3A4
			// (set) Token: 0x06004DD9 RID: 19929 RVA: 0x0001D784 File Offset: 0x0001B984
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

			// Token: 0x170013D5 RID: 5077
			// (get) Token: 0x06004DDA RID: 19930 RVA: 0x0015F1CC File Offset: 0x0015D3CC
			// (set) Token: 0x06004DDB RID: 19931 RVA: 0x0001D79F File Offset: 0x0001B99F
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

			// Token: 0x170013D6 RID: 5078
			// (get) Token: 0x06004DDC RID: 19932 RVA: 0x0015F1FC File Offset: 0x0015D3FC
			// (set) Token: 0x06004DDD RID: 19933 RVA: 0x0001D7BE File Offset: 0x0001B9BE
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

			// Token: 0x04003ED4 RID: 16084
			private static readonly IntPtr NativeFieldInfoPtr_keyDiversifier;

			// Token: 0x04003ED5 RID: 16085
			private static readonly IntPtr NativeFieldInfoPtr_ivDiversifier;

			// Token: 0x04003ED6 RID: 16086
			private static readonly IntPtr NativeFieldInfoPtr_macDiversifier;

			// Token: 0x04003ED7 RID: 16087
			private static readonly IntPtr NativeFieldInfoPtr__hashName;

			// Token: 0x04003ED8 RID: 16088
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x04003ED9 RID: 16089
			private static readonly IntPtr NativeFieldInfoPtr__password;

			// Token: 0x04003EDA RID: 16090
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x04003EDB RID: 16091
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EDC RID: 16092
			private static readonly IntPtr NativeMethodInfoPtr_set_HashName_Public_set_Void_String_0;

			// Token: 0x04003EDD RID: 16093
			private static readonly IntPtr NativeMethodInfoPtr_set_IterationCount_Public_set_Void_Int32_0;

			// Token: 0x04003EDE RID: 16094
			private static readonly IntPtr NativeMethodInfoPtr_set_Password_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EDF RID: 16095
			private static readonly IntPtr NativeMethodInfoPtr_set_Salt_Public_set_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EE0 RID: 16096
			private static readonly IntPtr NativeMethodInfoPtr_Adjust_Private_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EE1 RID: 16097
			private static readonly IntPtr NativeMethodInfoPtr_Derive_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04003EE2 RID: 16098
			private static readonly IntPtr NativeMethodInfoPtr_DeriveKey_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04003EE3 RID: 16099
			private static readonly IntPtr NativeMethodInfoPtr_DeriveIV_Public_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04003EE4 RID: 16100
			private static readonly IntPtr NativeMethodInfoPtr_DeriveMAC_Public_Il2CppStructArray_1_Byte_Int32_0;
		}
	}
}
