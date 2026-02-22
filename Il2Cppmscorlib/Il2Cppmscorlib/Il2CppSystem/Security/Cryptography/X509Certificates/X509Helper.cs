using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000324 RID: 804
	public static class X509Helper : Object
	{
		// Token: 0x06003425 RID: 13349 RVA: 0x000FF984 File Offset: 0x000FDB84
		// Note: this type is marked as 'beforefieldinit'.
		static X509Helper()
		{
			Il2CppClassPointerStore<X509Helper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Helper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Helper>.NativeClassPtr);
			X509Helper.NativeFieldInfoPtr_nativeHelper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, "nativeHelper");
			X509Helper.NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671387);
			X509Helper.NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671388);
			X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671389);
			X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671390);
			X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671391);
			X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671392);
			X509Helper.NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671393);
			X509Helper.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671394);
			X509Helper.NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671395);
			X509Helper.NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671396);
			X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671397);
			X509Helper.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Helper>.NativeClassPtr, 100671398);
		}

		// Token: 0x06003426 RID: 13350 RVA: 0x000FFAB8 File Offset: 0x000FDCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342273, RefRangeEnd = 342274, XrefRangeStart = 342270, XrefRangeEnd = 342273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallNativeHelper(INativeCertificateHelper helper)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(helper);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x000FFAF0 File Offset: 0x000FDCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342274, XrefRangeEnd = 342275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x000FFB34 File Offset: 0x000FDD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342283, RefRangeEnd = 342284, XrefRangeStart = 342275, XrefRangeEnd = 342283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl InitFromCertificate(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x000FFB78 File Offset: 0x000FDD78
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 42874, RefRangeEnd = 42880, XrefRangeStart = 42874, XrefRangeEnd = 42880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x000FFBBC File Offset: 0x000FDDBC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 342284, RefRangeEnd = 342292, XrefRangeStart = 342284, XrefRangeEnd = 342284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIfContextInvalid(X509CertificateImpl impl)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600342B RID: 13355 RVA: 0x000FFBF4 File Offset: 0x000FDDF4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 342299, RefRangeEnd = 342304, XrefRangeStart = 342292, XrefRangeEnd = 342299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetInvalidContextException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600342C RID: 13356 RVA: 0x000FFC28 File Offset: 0x000FDE28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 342332, RefRangeEnd = 342334, XrefRangeStart = 342304, XrefRangeEnd = 342332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Certificate ImportPkcs12(Il2CppStructArray<byte> rawData, string password)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate>(intPtr3) : null;
		}

		// Token: 0x0600342D RID: 13357 RVA: 0x000FFC80 File Offset: 0x000FDE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342334, XrefRangeEnd = 342349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600342E RID: 13358 RVA: 0x000FFCD8 File Offset: 0x000FDED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342349, XrefRangeEnd = 342365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> ConvertData(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x000FFD1C File Offset: 0x000FDF1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342375, RefRangeEnd = 342376, XrefRangeStart = 342365, XrefRangeEnd = 342375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl ImportCore(Il2CppStructArray<byte> rawData)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x000FFD60 File Offset: 0x000FDF60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342385, RefRangeEnd = 342386, XrefRangeStart = 342376, XrefRangeEnd = 342385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509CertificateImpl Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keyStorageFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x000FFDC4 File Offset: 0x000FDFC4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 342388, RefRangeEnd = 342392, XrefRangeStart = 342386, XrefRangeEnd = 342388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToHexString(Il2CppStructArray<byte> data)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Helper.NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000129D8 File Offset: 0x00010BD8
		public X509Helper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x000FFE00 File Offset: 0x000FE000
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x000129E1 File Offset: 0x00010BE1
		public unsafe static INativeCertificateHelper nativeHelper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Helper.NativeFieldInfoPtr_nativeHelper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeCertificateHelper>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Helper.NativeFieldInfoPtr_nativeHelper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002C4F RID: 11343
		private static readonly IntPtr NativeFieldInfoPtr_nativeHelper;

		// Token: 0x04002C50 RID: 11344
		private static readonly IntPtr NativeMethodInfoPtr_InstallNativeHelper_Internal_Static_Void_INativeCertificateHelper_0;

		// Token: 0x04002C51 RID: 11345
		private static readonly IntPtr NativeMethodInfoPtr_Import_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C52 RID: 11346
		private static readonly IntPtr NativeMethodInfoPtr_InitFromCertificate_Public_Static_X509CertificateImpl_X509CertificateImpl_0;

		// Token: 0x04002C53 RID: 11347
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Static_Boolean_X509CertificateImpl_0;

		// Token: 0x04002C54 RID: 11348
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIfContextInvalid_Internal_Static_Void_X509CertificateImpl_0;

		// Token: 0x04002C55 RID: 11349
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidContextException_Internal_Static_Exception_0;

		// Token: 0x04002C56 RID: 11350
		private static readonly IntPtr NativeMethodInfoPtr_ImportPkcs12_Internal_Static_X509Certificate_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002C57 RID: 11351
		private static readonly IntPtr NativeMethodInfoPtr_PEM_Private_Static_Il2CppStructArray_1_Byte_String_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C58 RID: 11352
		private static readonly IntPtr NativeMethodInfoPtr_ConvertData_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C59 RID: 11353
		private static readonly IntPtr NativeMethodInfoPtr_ImportCore_Private_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Static_X509CertificateImpl_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeMethodInfoPtr_ToHexString_Public_Static_String_Il2CppStructArray_1_Byte_0;
	}
}
