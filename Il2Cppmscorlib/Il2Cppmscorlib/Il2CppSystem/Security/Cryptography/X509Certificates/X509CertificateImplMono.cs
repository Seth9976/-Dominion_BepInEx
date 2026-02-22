using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000323 RID: 803
	public sealed class X509CertificateImplMono : X509CertificateImpl
	{
		// Token: 0x06003414 RID: 13332 RVA: 0x000FF498 File Offset: 0x000FD698
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImplMono()
		{
			Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateImplMono");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr);
			X509CertificateImplMono.NativeFieldInfoPtr_x509 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, "x509");
			X509CertificateImplMono.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671374);
			X509CertificateImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671375);
			X509CertificateImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671376);
			X509CertificateImplMono.NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671377);
			X509CertificateImplMono.NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671378);
			X509CertificateImplMono.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671379);
			X509CertificateImplMono.NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671380);
			X509CertificateImplMono.NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671381);
			X509CertificateImplMono.NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671382);
			X509CertificateImplMono.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671383);
			X509CertificateImplMono.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671384);
			X509CertificateImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671385);
			X509CertificateImplMono.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr, 100671386);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000FF5E0 File Offset: 0x000FD7E0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 33270, RefRangeEnd = 33281, XrefRangeStart = 33270, XrefRangeEnd = 33281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImplMono(X509Certificate x509)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImplMono>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x509);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06003416 RID: 13334 RVA: 0x000FF62C File Offset: 0x000FD82C
		public unsafe override bool IsValid
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 309744, RefRangeEnd = 309751, XrefRangeStart = 309744, XrefRangeEnd = 309751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x000FF668 File Offset: 0x000FD868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342203, XrefRangeEnd = 342207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06003418 RID: 13336 RVA: 0x000FF6A8 File Offset: 0x000FD8A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342207, XrefRangeEnd = 342213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetIssuerName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003419 RID: 13337 RVA: 0x000FF6EC File Offset: 0x000FD8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342213, XrefRangeEnd = 342219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSubjectName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600341A RID: 13338 RVA: 0x000FF730 File Offset: 0x000FD930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342219, XrefRangeEnd = 342223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x000FF770 File Offset: 0x000FD970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342223, XrefRangeEnd = 342229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetCertHash(bool lazy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600341C RID: 13340 RVA: 0x000FF7BC File Offset: 0x000FD9BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342229, XrefRangeEnd = 342233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime GetValidFrom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x000FF7F8 File Offset: 0x000FD9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342233, XrefRangeEnd = 342237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DateTime GetValidUntil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x000FF834 File Offset: 0x000FDA34
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600341F RID: 13343 RVA: 0x000FF890 File Offset: 0x000FDA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342237, XrefRangeEnd = 342241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppStructArray<byte> GetSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x000FF8D0 File Offset: 0x000FDAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342241, XrefRangeEnd = 342270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool full)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref full;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x000FF914 File Offset: 0x000FDB14
		[CallerCount(0)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImplMono.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003422 RID: 13346 RVA: 0x000129B0 File Offset: 0x00010BB0
		public X509CertificateImplMono(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x000FF954 File Offset: 0x000FDB54
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x000129B9 File Offset: 0x00010BB9
		public unsafe X509Certificate x509
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplMono.NativeFieldInfoPtr_x509);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImplMono.NativeFieldInfoPtr_x509), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C41 RID: 11329
		private static readonly IntPtr NativeFieldInfoPtr_x509;

		// Token: 0x04002C42 RID: 11330
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_X509Certificate_0;

		// Token: 0x04002C43 RID: 11331
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Virtual_get_Boolean_0;

		// Token: 0x04002C44 RID: 11332
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_X509CertificateImpl_0;

		// Token: 0x04002C45 RID: 11333
		private static readonly IntPtr NativeMethodInfoPtr_GetIssuerName_Public_Virtual_String_Boolean_0;

		// Token: 0x04002C46 RID: 11334
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_Virtual_String_Boolean_0;

		// Token: 0x04002C47 RID: 11335
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C48 RID: 11336
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Protected_Virtual_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04002C49 RID: 11337
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFrom_Public_Virtual_DateTime_0;

		// Token: 0x04002C4A RID: 11338
		private static readonly IntPtr NativeMethodInfoPtr_GetValidUntil_Public_Virtual_DateTime_0;

		// Token: 0x04002C4B RID: 11339
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_X509CertificateImpl_byref_Boolean_0;

		// Token: 0x04002C4C RID: 11340
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C4D RID: 11341
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04002C4E RID: 11342
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
