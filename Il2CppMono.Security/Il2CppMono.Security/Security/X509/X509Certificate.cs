using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.X509
{
	// Token: 0x0200000A RID: 10
	public class X509Certificate : Object
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00005B4C File Offset: 0x00003D4C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
			Il2CppClassPointerStore<X509Certificate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X509Certificate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr);
			X509Certificate.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "decoder");
			X509Certificate.NativeFieldInfoPtr_m_encodedcert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_encodedcert");
			X509Certificate.NativeFieldInfoPtr_m_from = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_from");
			X509Certificate.NativeFieldInfoPtr_m_until = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_until");
			X509Certificate.NativeFieldInfoPtr_issuer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "issuer");
			X509Certificate.NativeFieldInfoPtr_m_issuername = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_issuername");
			X509Certificate.NativeFieldInfoPtr_m_keyalgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_keyalgo");
			X509Certificate.NativeFieldInfoPtr_m_keyalgoparams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_keyalgoparams");
			X509Certificate.NativeFieldInfoPtr_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "subject");
			X509Certificate.NativeFieldInfoPtr_m_subject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_subject");
			X509Certificate.NativeFieldInfoPtr_m_publickey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_publickey");
			X509Certificate.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "signature");
			X509Certificate.NativeFieldInfoPtr_m_signaturealgo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_signaturealgo");
			X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "m_signaturealgoparams");
			X509Certificate.NativeFieldInfoPtr__rsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "_rsa");
			X509Certificate.NativeFieldInfoPtr__dsa = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "_dsa");
			X509Certificate.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "version");
			X509Certificate.NativeFieldInfoPtr_serialnumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "serialnumber");
			X509Certificate.NativeFieldInfoPtr_issuerUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "issuerUniqueID");
			X509Certificate.NativeFieldInfoPtr_subjectUniqueID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "subjectUniqueID");
			X509Certificate.NativeFieldInfoPtr_extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "extensions");
			X509Certificate.NativeFieldInfoPtr_encoding_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "encoding_error");
			X509Certificate.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663391);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663392);
			X509Certificate.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663393);
			X509Certificate.NativeMethodInfoPtr_get_DSA_Public_get_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663394);
			X509Certificate.NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663395);
			X509Certificate.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663396);
			X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663397);
			X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663398);
			X509Certificate.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663399);
			X509Certificate.NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663400);
			X509Certificate.NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663401);
			X509Certificate.NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663402);
			X509Certificate.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663403);
			X509Certificate.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663404);
			X509Certificate.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663405);
			X509Certificate.NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663406);
			X509Certificate.NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663407);
			X509Certificate.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663408);
			X509Certificate.NativeMethodInfoPtr_GetIssuerName_Public_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663409);
			X509Certificate.NativeMethodInfoPtr_GetSubjectName_Public_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663410);
			X509Certificate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663411);
			X509Certificate.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663412);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005EEC File Offset: 0x000040EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 7928, RefRangeEnd = 7929, XrefRangeStart = 7859, XrefRangeEnd = 7928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00005F30 File Offset: 0x00004130
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 7950, RefRangeEnd = 7956, XrefRangeStart = 7929, XrefRangeEnd = 7950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(Il2CppStructArray<byte> data)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005F7C File Offset: 0x0000417C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 7957, RefRangeEnd = 7962, XrefRangeStart = 7956, XrefRangeEnd = 7957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetUnsignedBigInteger(Il2CppStructArray<byte> integer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(integer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00005FCC File Offset: 0x000041CC
		// (set) Token: 0x06000097 RID: 151 RVA: 0x0000600C File Offset: 0x0000420C
		public unsafe DSA DSA
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 7990, RefRangeEnd = 8000, XrefRangeStart = 7962, XrefRangeEnd = 7990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_DSA_Public_get_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8000, RefRangeEnd = 8001, XrefRangeStart = 8000, XrefRangeEnd = 8000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00006050 File Offset: 0x00004250
		public unsafe virtual string IssuerName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00006094 File Offset: 0x00004294
		public unsafe virtual string KeyAlgorithm
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600009A RID: 154 RVA: 0x000060D8 File Offset: 0x000042D8
		public unsafe virtual Il2CppStructArray<byte> KeyAlgorithmParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8014, XrefRangeEnd = 8017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00006124 File Offset: 0x00004324
		public unsafe virtual Il2CppStructArray<byte> PublicKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8017, XrefRangeEnd = 8020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00006170 File Offset: 0x00004370
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000061BC File Offset: 0x000043BC
		public unsafe virtual RSA RSA
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8020, XrefRangeEnd = 8036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000620C File Offset: 0x0000440C
		public unsafe virtual Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8036, XrefRangeEnd = 8039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00006258 File Offset: 0x00004458
		public unsafe virtual Il2CppStructArray<byte> SerialNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8039, XrefRangeEnd = 8042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000062A4 File Offset: 0x000044A4
		public unsafe virtual string SignatureAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000062E8 File Offset: 0x000044E8
		public unsafe virtual string SubjectName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000632C File Offset: 0x0000452C
		public unsafe virtual DateTime ValidFrom
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00006374 File Offset: 0x00004574
		public unsafe virtual DateTime ValidUntil
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x000063BC File Offset: 0x000045BC
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000063F8 File Offset: 0x000045F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ASN1 GetIssuerName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetIssuerName_Public_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006438 File Offset: 0x00004638
		[CallerCount(0)]
		public unsafe ASN1 GetSubjectName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_GetSubjectName_Public_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006478 File Offset: 0x00004678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8045, XrefRangeEnd = 8049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000064DC File Offset: 0x000046DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 8049, XrefRangeEnd = 8064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> PEM(string type, Il2CppStructArray<byte> data)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000023CF File Offset: 0x000005CF
		public X509Certificate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00006534 File Offset: 0x00004734
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe ASN1 decoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_decoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00006564 File Offset: 0x00004764
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000023F7 File Offset: 0x000005F7
		public unsafe Il2CppStructArray<byte> m_encodedcert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_encodedcert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_encodedcert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00006594 File Offset: 0x00004794
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002416 File Offset: 0x00000616
		public unsafe DateTime m_from
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_from);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_from)) = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000065BC File Offset: 0x000047BC
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002431 File Offset: 0x00000631
		public unsafe DateTime m_until
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_until);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_until)) = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000065E4 File Offset: 0x000047E4
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000244C File Offset: 0x0000064C
		public unsafe ASN1 issuer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00006614 File Offset: 0x00004814
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000246B File Offset: 0x0000066B
		public unsafe string m_issuername
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_issuername);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_issuername), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000663C File Offset: 0x0000483C
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000248A File Offset: 0x0000068A
		public unsafe string m_keyalgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00006664 File Offset: 0x00004864
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000024A9 File Offset: 0x000006A9
		public unsafe Il2CppStructArray<byte> m_keyalgoparams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgoparams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_keyalgoparams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00006694 File Offset: 0x00004894
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000024C8 File Offset: 0x000006C8
		public unsafe ASN1 subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BC RID: 188 RVA: 0x000066C4 File Offset: 0x000048C4
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000024E7 File Offset: 0x000006E7
		public unsafe string m_subject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_subject);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_subject), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000066EC File Offset: 0x000048EC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00002506 File Offset: 0x00000706
		public unsafe Il2CppStructArray<byte> m_publickey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_publickey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_publickey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000671C File Offset: 0x0000491C
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002525 File Offset: 0x00000725
		public unsafe Il2CppStructArray<byte> signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000674C File Offset: 0x0000494C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002544 File Offset: 0x00000744
		public unsafe string m_signaturealgo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgo);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgo), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00006774 File Offset: 0x00004974
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002563 File Offset: 0x00000763
		public unsafe Il2CppStructArray<byte> m_signaturealgoparams
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_m_signaturealgoparams), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000067A4 File Offset: 0x000049A4
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002582 File Offset: 0x00000782
		public unsafe RSA _rsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__rsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__rsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000067D4 File Offset: 0x000049D4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000025A1 File Offset: 0x000007A1
		public unsafe DSA _dsa
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__dsa);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr__dsa), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00006804 File Offset: 0x00004A04
		// (set) Token: 0x060000CB RID: 203 RVA: 0x000025C0 File Offset: 0x000007C0
		public unsafe int version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000682C File Offset: 0x00004A2C
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000025DB File Offset: 0x000007DB
		public unsafe Il2CppStructArray<byte> serialnumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_serialnumber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_serialnumber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000685C File Offset: 0x00004A5C
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000025FA File Offset: 0x000007FA
		public unsafe Il2CppStructArray<byte> issuerUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuerUniqueID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuerUniqueID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000688C File Offset: 0x00004A8C
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x00002619 File Offset: 0x00000819
		public unsafe Il2CppStructArray<byte> subjectUniqueID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subjectUniqueID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subjectUniqueID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000068BC File Offset: 0x00004ABC
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00002638 File Offset: 0x00000838
		public unsafe X509ExtensionCollection extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ExtensionCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000068EC File Offset: 0x00004AEC
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x00002657 File Offset: 0x00000857
		public unsafe static string encoding_error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate.NativeFieldInfoPtr_encoding_error, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate.NativeFieldInfoPtr_encoding_error, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeFieldInfoPtr_m_encodedcert;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeFieldInfoPtr_m_from;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeFieldInfoPtr_m_until;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_issuer;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_issuername;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgo;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgoparams;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_subject;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_m_publickey;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgo;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgoparams;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr__rsa;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr__dsa;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_serialnumber;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_issuerUniqueID;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_subjectUniqueID;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_extensions;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_encoding_error;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_DSA_Public_get_DSA_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_set_DSA_Public_set_Void_DSA_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithm_Public_Virtual_New_get_String_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_set_RSA_Public_Virtual_New_set_Void_RSA_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_New_get_String_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_GetIssuerName_Public_ASN1_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_ASN1_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;
	}
}
