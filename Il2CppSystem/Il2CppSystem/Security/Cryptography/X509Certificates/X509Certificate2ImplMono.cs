using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008E RID: 142
	public class X509Certificate2ImplMono : X509Certificate2Impl
	{
		// Token: 0x06000868 RID: 2152 RVA: 0x0002F578 File Offset: 0x0002D778
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2ImplMono()
		{
			Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2ImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr);
			X509Certificate2ImplMono.NativeFieldInfoPtr__archived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "_archived");
			X509Certificate2ImplMono.NativeFieldInfoPtr__extensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "_extensions");
			X509Certificate2ImplMono.NativeFieldInfoPtr__publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "_publicKey");
			X509Certificate2ImplMono.NativeFieldInfoPtr_issuer_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "issuer_name");
			X509Certificate2ImplMono.NativeFieldInfoPtr_subject_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "subject_name");
			X509Certificate2ImplMono.NativeFieldInfoPtr_signature_algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "signature_algorithm");
			X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "intermediateCerts");
			X509Certificate2ImplMono.NativeFieldInfoPtr__cert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "_cert");
			X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "empty_error");
			X509Certificate2ImplMono.NativeFieldInfoPtr_commonName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "commonName");
			X509Certificate2ImplMono.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "email");
			X509Certificate2ImplMono.NativeFieldInfoPtr_signedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, "signedData");
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664390);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664391);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664392);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664393);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664394);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664395);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664396);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664397);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664398);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664399);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664400);
			X509Certificate2ImplMono.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664401);
			X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664402);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664403);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_get_PublicKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664404);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664405);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_Version_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664406);
			X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664407);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664408);
			X509Certificate2ImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664409);
			X509Certificate2ImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664410);
			X509Certificate2ImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664411);
			X509Certificate2ImplMono.NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664412);
			X509Certificate2ImplMono.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr, 100664413);
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0002F878 File Offset: 0x0002DA78
		public unsafe override bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x0002F8C0 File Offset: 0x0002DAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42212, XrefRangeEnd = 42213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono(Il2CppMono.Security.X509.X509Certificate cert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0002F90C File Offset: 0x0002DB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42213, XrefRangeEnd = 42218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono(X509Certificate2ImplMono other)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0002F958 File Offset: 0x0002DB58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42218, XrefRangeEnd = 42227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42227, XrefRangeEnd = 42234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetIssuerName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0002F9F4 File Offset: 0x0002DBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42234, XrefRangeEnd = 42241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSubjectName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0002FA44 File Offset: 0x0002DC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42241, XrefRangeEnd = 42243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002FA90 File Offset: 0x0002DC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42243, XrefRangeEnd = 42247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetCertHash(bool lazy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x0002FAE8 File Offset: 0x0002DCE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42247, XrefRangeEnd = 42249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime GetValidFrom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002FB30 File Offset: 0x0002DD30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42249, XrefRangeEnd = 42251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime GetValidUntil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0002FB78 File Offset: 0x0002DD78
		[CallerCount(0)]
		public unsafe override bool Equals(X509CertificateImpl other, out bool result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x0002FBE0 File Offset: 0x0002DDE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42251, XrefRangeEnd = 42253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x0002FC2C File Offset: 0x0002DE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42253, XrefRangeEnd = 42254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2ImplMono()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2ImplMono>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0002FC68 File Offset: 0x0002DE68
		public unsafe override AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42254, XrefRangeEnd = 42272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002FCB4 File Offset: 0x0002DEB4
		public unsafe override PublicKey PublicKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42272, XrefRangeEnd = 42276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_PublicKey_Public_Virtual_get_PublicKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr3) : null;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x0002FD00 File Offset: 0x0002DF00
		public unsafe override Oid SignatureAlgorithm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42276, XrefRangeEnd = 42280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_get_Oid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0002FD4C File Offset: 0x0002DF4C
		public unsafe override int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_Version_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0002FD94 File Offset: 0x0002DF94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42355, RefRangeEnd = 42356, XrefRangeStart = 42280, XrefRangeEnd = 42355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppMono.Security.X509.X509Certificate ImportPkcs12(Il2CppStructArray<byte> rawData, string password)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Security.X509.X509Certificate>(intPtr3) : null;
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x0002FDF8 File Offset: 0x0002DFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42356, XrefRangeEnd = 42362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x0002FE68 File Offset: 0x0002E068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42362, XrefRangeEnd = 42366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42366, XrefRangeEnd = 42368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x0002FEE8 File Offset: 0x0002E0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42368, XrefRangeEnd = 42454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool verbose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verbose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0002FF38 File Offset: 0x0002E138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42454, XrefRangeEnd = 42462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AppendBuffer(StringBuilder sb, Il2CppStructArray<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2ImplMono.NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x0002FF80 File Offset: 0x0002E180
		public unsafe override X509CertificateImplCollection IntermediateCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2ImplMono.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00005665 File Offset: 0x00003865
		public X509Certificate2ImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x0002FFCC File Offset: 0x0002E1CC
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0000566E File Offset: 0x0000386E
		public unsafe bool _archived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__archived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__archived)) = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x0002FFF4 File Offset: 0x0002E1F4
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00005689 File Offset: 0x00003889
		public unsafe Il2CppSystem.Security.Cryptography.X509Certificates.X509ExtensionCollection _extensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__extensions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Security.Cryptography.X509Certificates.X509ExtensionCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__extensions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000886 RID: 2182 RVA: 0x00030024 File Offset: 0x0002E224
		// (set) Token: 0x06000887 RID: 2183 RVA: 0x000056A8 File Offset: 0x000038A8
		public unsafe PublicKey _publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000888 RID: 2184 RVA: 0x00030054 File Offset: 0x0002E254
		// (set) Token: 0x06000889 RID: 2185 RVA: 0x000056C7 File Offset: 0x000038C7
		public unsafe X500DistinguishedName issuer_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_issuer_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_issuer_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600088A RID: 2186 RVA: 0x00030084 File Offset: 0x0002E284
		// (set) Token: 0x0600088B RID: 2187 RVA: 0x000056E6 File Offset: 0x000038E6
		public unsafe X500DistinguishedName subject_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_subject_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X500DistinguishedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_subject_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600088C RID: 2188 RVA: 0x000300B4 File Offset: 0x0002E2B4
		// (set) Token: 0x0600088D RID: 2189 RVA: 0x00005705 File Offset: 0x00003905
		public unsafe Oid signature_algorithm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_signature_algorithm);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_signature_algorithm), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600088E RID: 2190 RVA: 0x000300E4 File Offset: 0x0002E2E4
		// (set) Token: 0x0600088F RID: 2191 RVA: 0x00005724 File Offset: 0x00003924
		public unsafe X509CertificateImplCollection intermediateCerts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr_intermediateCerts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000890 RID: 2192 RVA: 0x00030114 File Offset: 0x0002E314
		// (set) Token: 0x06000891 RID: 2193 RVA: 0x00005743 File Offset: 0x00003943
		public unsafe Il2CppMono.Security.X509.X509Certificate _cert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__cert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppMono.Security.X509.X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2ImplMono.NativeFieldInfoPtr__cert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x00030144 File Offset: 0x0002E344
		// (set) Token: 0x06000893 RID: 2195 RVA: 0x00005762 File Offset: 0x00003962
		public unsafe static string empty_error
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_empty_error, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00030164 File Offset: 0x0002E364
		// (set) Token: 0x06000895 RID: 2197 RVA: 0x00005774 File Offset: 0x00003974
		public unsafe static Il2CppStructArray<byte> commonName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_commonName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_commonName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0003018C File Offset: 0x0002E38C
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe static Il2CppStructArray<byte> email
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_email, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_email, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000301B4 File Offset: 0x0002E3B4
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00005798 File Offset: 0x00003998
		public unsafe static Il2CppStructArray<byte> signedData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2ImplMono.NativeFieldInfoPtr_signedData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2ImplMono.NativeFieldInfoPtr_signedData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr__archived;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeFieldInfoPtr__extensions;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeFieldInfoPtr__publicKey;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeFieldInfoPtr_issuer_name;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeFieldInfoPtr_subject_name;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_signature_algorithm;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_intermediateCerts;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeFieldInfoPtr__cert;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr_empty_error;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeFieldInfoPtr_commonName;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr_email;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr_signedData;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509Certificate_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_X509Certificate2ImplMono_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_Virtual_get_AsymmetricAlgorithm_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_Virtual_get_PublicKey_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Virtual_get_Oid_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_Int32_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Private_X509Certificate_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Virtual_get_X509CertificateImplCollection_0;
	}
}
