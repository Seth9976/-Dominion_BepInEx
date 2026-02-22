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
	// Token: 0x02000025 RID: 37
	public class X509Certificate : Object
	{
		// Token: 0x06000240 RID: 576 RVA: 0x0002B13C File Offset: 0x0002933C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
			Il2CppClassPointerStore<X509Certificate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.X509", "X509Certificate");
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
			X509Certificate.NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663600);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663601);
			X509Certificate.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663602);
			X509Certificate.NativeMethodInfoPtr_get_DSA_Public_get_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663603);
			X509Certificate.NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663604);
			X509Certificate.NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663605);
			X509Certificate.NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663606);
			X509Certificate.NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663607);
			X509Certificate.NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663608);
			X509Certificate.NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663609);
			X509Certificate.NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663610);
			X509Certificate.NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663611);
			X509Certificate.NativeMethodInfoPtr_GetIssuerName_Public_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663612);
			X509Certificate.NativeMethodInfoPtr_GetSubjectName_Public_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663613);
			X509Certificate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663614);
			X509Certificate.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100663615);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0002B464 File Offset: 0x00029664
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 262145, RefRangeEnd = 262146, XrefRangeStart = 262074, XrefRangeEnd = 262145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000242 RID: 578 RVA: 0x0002B4A8 File Offset: 0x000296A8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 262167, RefRangeEnd = 262175, XrefRangeStart = 262146, XrefRangeEnd = 262167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000243 RID: 579 RVA: 0x0002B4F4 File Offset: 0x000296F4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 262176, RefRangeEnd = 262181, XrefRangeStart = 262175, XrefRangeEnd = 262176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0002B544 File Offset: 0x00029744
		public unsafe DSA DSA
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 262210, RefRangeEnd = 262213, XrefRangeStart = 262181, XrefRangeEnd = 262210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0002B584 File Offset: 0x00029784
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

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0002B5C8 File Offset: 0x000297C8
		public unsafe virtual Il2CppStructArray<byte> KeyAlgorithmParameters
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262213, XrefRangeEnd = 262216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0002B614 File Offset: 0x00029814
		public unsafe virtual RSA RSA
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262216, XrefRangeEnd = 262232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0002B660 File Offset: 0x00029860
		public unsafe virtual Il2CppStructArray<byte> RawData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262232, XrefRangeEnd = 262235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0002B6AC File Offset: 0x000298AC
		public unsafe virtual Il2CppStructArray<byte> SerialNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262235, XrefRangeEnd = 262238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0002B6F8 File Offset: 0x000298F8
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0002B73C File Offset: 0x0002993C
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600024C RID: 588 RVA: 0x0002B784 File Offset: 0x00029984
		public unsafe virtual DateTime ValidUntil
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600024D RID: 589 RVA: 0x0002B7CC File Offset: 0x000299CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x0600024E RID: 590 RVA: 0x0002B80C File Offset: 0x00029A0C
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

		// Token: 0x0600024F RID: 591 RVA: 0x0002B84C File Offset: 0x00029A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262238, XrefRangeEnd = 262242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000250 RID: 592 RVA: 0x0002B8B0 File Offset: 0x00029AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262242, XrefRangeEnd = 262257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x06000251 RID: 593 RVA: 0x00002EA8 File Offset: 0x000010A8
		public X509Certificate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0002B908 File Offset: 0x00029B08
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00002EB1 File Offset: 0x000010B1
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

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0002B938 File Offset: 0x00029B38
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002ED0 File Offset: 0x000010D0
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

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000256 RID: 598 RVA: 0x0002B968 File Offset: 0x00029B68
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002EEF File Offset: 0x000010EF
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

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000258 RID: 600 RVA: 0x0002B990 File Offset: 0x00029B90
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002F0A File Offset: 0x0000110A
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

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600025A RID: 602 RVA: 0x0002B9B8 File Offset: 0x00029BB8
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002F25 File Offset: 0x00001125
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0002B9E8 File Offset: 0x00029BE8
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002F44 File Offset: 0x00001144
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0002BA10 File Offset: 0x00029C10
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002F63 File Offset: 0x00001163
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

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000260 RID: 608 RVA: 0x0002BA38 File Offset: 0x00029C38
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002F82 File Offset: 0x00001182
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

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0002BA68 File Offset: 0x00029C68
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002FA1 File Offset: 0x000011A1
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

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000264 RID: 612 RVA: 0x0002BA98 File Offset: 0x00029C98
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002FC0 File Offset: 0x000011C0
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000266 RID: 614 RVA: 0x0002BAC0 File Offset: 0x00029CC0
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002FDF File Offset: 0x000011DF
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

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0002BAF0 File Offset: 0x00029CF0
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002FFE File Offset: 0x000011FE
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

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600026A RID: 618 RVA: 0x0002BB20 File Offset: 0x00029D20
		// (set) Token: 0x0600026B RID: 619 RVA: 0x0000301D File Offset: 0x0000121D
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

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600026C RID: 620 RVA: 0x0002BB48 File Offset: 0x00029D48
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000303C File Offset: 0x0000123C
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0002BB78 File Offset: 0x00029D78
		// (set) Token: 0x0600026F RID: 623 RVA: 0x0000305B File Offset: 0x0000125B
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000270 RID: 624 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		// (set) Token: 0x06000271 RID: 625 RVA: 0x0000307A File Offset: 0x0000127A
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000272 RID: 626 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		// (set) Token: 0x06000273 RID: 627 RVA: 0x00003099 File Offset: 0x00001299
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000274 RID: 628 RVA: 0x0002BC00 File Offset: 0x00029E00
		// (set) Token: 0x06000275 RID: 629 RVA: 0x000030B4 File Offset: 0x000012B4
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000276 RID: 630 RVA: 0x0002BC30 File Offset: 0x00029E30
		// (set) Token: 0x06000277 RID: 631 RVA: 0x000030D3 File Offset: 0x000012D3
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0002BC60 File Offset: 0x00029E60
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000030F2 File Offset: 0x000012F2
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600027A RID: 634 RVA: 0x0002BC90 File Offset: 0x00029E90
		// (set) Token: 0x0600027B RID: 635 RVA: 0x00003111 File Offset: 0x00001311
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

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600027C RID: 636 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x00003130 File Offset: 0x00001330
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

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_decoder;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_encodedcert;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_m_from;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr_m_until;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_issuer;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeFieldInfoPtr_m_issuername;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgo;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeFieldInfoPtr_m_keyalgoparams;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeFieldInfoPtr_subject;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeFieldInfoPtr_m_subject;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeFieldInfoPtr_m_publickey;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgo;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeFieldInfoPtr_m_signaturealgoparams;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeFieldInfoPtr__rsa;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeFieldInfoPtr__dsa;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeFieldInfoPtr_serialnumber;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_issuerUniqueID;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_subjectUniqueID;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeFieldInfoPtr_extensions;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeFieldInfoPtr_encoding_error;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_get_DSA_Public_get_DSA_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_get_IssuerName_Public_Virtual_New_get_String_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyAlgorithmParameters_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_RSA_Public_Virtual_New_get_RSA_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_RawData_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_SubjectName_Public_Virtual_New_get_String_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidFrom_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidUntil_Public_Virtual_New_get_DateTime_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_GetIssuerName_Public_ASN1_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_ASN1_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;
	}
}
