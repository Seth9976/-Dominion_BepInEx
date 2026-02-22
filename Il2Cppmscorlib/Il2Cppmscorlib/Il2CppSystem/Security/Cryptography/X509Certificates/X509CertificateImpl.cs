using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000322 RID: 802
	public class X509CertificateImpl : Object
	{
		// Token: 0x060033FD RID: 13309 RVA: 0x000FED30 File Offset: 0x000FCF30
		// Note: this type is marked as 'beforefieldinit'.
		static X509CertificateImpl()
		{
			Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509CertificateImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr);
			X509CertificateImpl.NativeFieldInfoPtr_cachedCertificateHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, "cachedCertificateHash");
			X509CertificateImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671355);
			X509CertificateImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671356);
			X509CertificateImpl.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671357);
			X509CertificateImpl.NativeMethodInfoPtr_GetIssuerName_Public_Abstract_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671358);
			X509CertificateImpl.NativeMethodInfoPtr_GetSubjectName_Public_Abstract_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671359);
			X509CertificateImpl.NativeMethodInfoPtr_GetRawCertData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671360);
			X509CertificateImpl.NativeMethodInfoPtr_GetValidFrom_Public_Abstract_Virtual_New_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671361);
			X509CertificateImpl.NativeMethodInfoPtr_GetValidUntil_Public_Abstract_Virtual_New_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671362);
			X509CertificateImpl.NativeMethodInfoPtr_GetCertHash_Public_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671363);
			X509CertificateImpl.NativeMethodInfoPtr_GetCertHash_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671364);
			X509CertificateImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671365);
			X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_X509CertificateImpl_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671366);
			X509CertificateImpl.NativeMethodInfoPtr_GetSerialNumber_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671367);
			X509CertificateImpl.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671368);
			X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671369);
			X509CertificateImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671370);
			X509CertificateImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671371);
			X509CertificateImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671372);
			X509CertificateImpl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr, 100671373);
		}

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x000FEEF0 File Offset: 0x000FD0F0
		public unsafe virtual bool IsValid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x000FEF38 File Offset: 0x000FD138
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 342183, RefRangeEnd = 342191, XrefRangeStart = 342183, XrefRangeEnd = 342183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowIfContextInvalid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x000FEF6C File Offset: 0x000FD16C
		[CallerCount(0)]
		public unsafe virtual X509CertificateImpl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x000FEFB8 File Offset: 0x000FD1B8
		[CallerCount(0)]
		public unsafe virtual string GetIssuerName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetIssuerName_Public_Abstract_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x000FF008 File Offset: 0x000FD208
		[CallerCount(0)]
		public unsafe virtual string GetSubjectName(bool legacyV1Mode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref legacyV1Mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetSubjectName_Public_Abstract_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003403 RID: 13315 RVA: 0x000FF058 File Offset: 0x000FD258
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetRawCertData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003404 RID: 13316 RVA: 0x000FF0A4 File Offset: 0x000FD2A4
		[CallerCount(0)]
		public unsafe virtual DateTime GetValidFrom()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetValidFrom_Public_Abstract_Virtual_New_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003405 RID: 13317 RVA: 0x000FF0EC File Offset: 0x000FD2EC
		[CallerCount(0)]
		public unsafe virtual DateTime GetValidUntil()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetValidUntil_Public_Abstract_Virtual_New_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003406 RID: 13318 RVA: 0x000FF134 File Offset: 0x000FD334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342191, RefRangeEnd = 342192, XrefRangeStart = 342191, XrefRangeEnd = 342191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetCertHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_GetCertHash_Public_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000FF174 File Offset: 0x000FD374
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetCertHash(bool lazy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetCertHash_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000FF1CC File Offset: 0x000FD3CC
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000FF214 File Offset: 0x000FD414
		[CallerCount(0)]
		public unsafe virtual bool Equals(X509CertificateImpl other, out bool result)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_X509CertificateImpl_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000FF27C File Offset: 0x000FD47C
		[CallerCount(0)]
		public unsafe virtual Il2CppStructArray<byte> GetSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_GetSerialNumber_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600340B RID: 13323 RVA: 0x000FF2C8 File Offset: 0x000FD4C8
		[CallerCount(0)]
		public unsafe virtual string ToString(bool full)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref full;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600340C RID: 13324 RVA: 0x000FF318 File Offset: 0x000FD518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342192, XrefRangeEnd = 342195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600340D RID: 13325 RVA: 0x000FF370 File Offset: 0x000FD570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342199, RefRangeEnd = 342200, XrefRangeStart = 342195, XrefRangeEnd = 342199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600340E RID: 13326 RVA: 0x000FF3A4 File Offset: 0x000FD5A4
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600340F RID: 13327 RVA: 0x000FF3F0 File Offset: 0x000FD5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342200, XrefRangeEnd = 342203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509CertificateImpl.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003410 RID: 13328 RVA: 0x000FF42C File Offset: 0x000FD62C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509CertificateImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509CertificateImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509CertificateImpl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x00012988 File Offset: 0x00010B88
		public X509CertificateImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x000FF468 File Offset: 0x000FD668
		// (set) Token: 0x06003413 RID: 13331 RVA: 0x00012991 File Offset: 0x00010B91
		public unsafe Il2CppStructArray<byte> cachedCertificateHash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImpl.NativeFieldInfoPtr_cachedCertificateHash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509CertificateImpl.NativeFieldInfoPtr_cachedCertificateHash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C2D RID: 11309
		private static readonly IntPtr NativeFieldInfoPtr_cachedCertificateHash;

		// Token: 0x04002C2E RID: 11310
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04002C2F RID: 11311
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Protected_Void_0;

		// Token: 0x04002C30 RID: 11312
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_X509CertificateImpl_0;

		// Token: 0x04002C31 RID: 11313
		private static readonly IntPtr NativeMethodInfoPtr_GetIssuerName_Public_Abstract_Virtual_New_String_Boolean_0;

		// Token: 0x04002C32 RID: 11314
		private static readonly IntPtr NativeMethodInfoPtr_GetSubjectName_Public_Abstract_Virtual_New_String_Boolean_0;

		// Token: 0x04002C33 RID: 11315
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C34 RID: 11316
		private static readonly IntPtr NativeMethodInfoPtr_GetValidFrom_Public_Abstract_Virtual_New_DateTime_0;

		// Token: 0x04002C35 RID: 11317
		private static readonly IntPtr NativeMethodInfoPtr_GetValidUntil_Public_Abstract_Virtual_New_DateTime_0;

		// Token: 0x04002C36 RID: 11318
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Public_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C37 RID: 11319
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Protected_Abstract_Virtual_New_Il2CppStructArray_1_Byte_Boolean_0;

		// Token: 0x04002C38 RID: 11320
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002C39 RID: 11321
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Abstract_Virtual_New_Boolean_X509CertificateImpl_byref_Boolean_0;

		// Token: 0x04002C3A RID: 11322
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Abstract_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C3B RID: 11323
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Abstract_Virtual_New_String_Boolean_0;

		// Token: 0x04002C3C RID: 11324
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002C3D RID: 11325
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002C3E RID: 11326
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002C3F RID: 11327
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04002C40 RID: 11328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
