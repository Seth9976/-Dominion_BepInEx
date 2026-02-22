using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000321 RID: 801
	[Serializable]
	public class X509Certificate : Object
	{
		// Token: 0x060033DB RID: 13275 RVA: 0x000FE348 File Offset: 0x000FC548
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate()
		{
			Il2CppClassPointerStore<X509Certificate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr);
			X509Certificate.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "impl");
			X509Certificate.NativeFieldInfoPtr_hideDates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "hideDates");
			X509Certificate.NativeFieldInfoPtr_issuer_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "issuer_name");
			X509Certificate.NativeFieldInfoPtr_subject_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, "subject_name");
			X509Certificate.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671331);
			X509Certificate.NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671332);
			X509Certificate.NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671333);
			X509Certificate.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671334);
			X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671335);
			X509Certificate.NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671336);
			X509Certificate.NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671337);
			X509Certificate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671338);
			X509Certificate.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671339);
			X509Certificate.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671340);
			X509Certificate.NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671341);
			X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671342);
			X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671343);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671344);
			X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671345);
			X509Certificate.NativeMethodInfoPtr_get_Issuer_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671346);
			X509Certificate.NativeMethodInfoPtr_get_Subject_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671347);
			X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671348);
			X509Certificate.NativeMethodInfoPtr_Import_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671349);
			X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671350);
			X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671351);
			X509Certificate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671352);
			X509Certificate.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671353);
			X509Certificate.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr, 100671354);
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000FE5A8 File Offset: 0x000FC7A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342114, RefRangeEnd = 342115, XrefRangeStart = 342112, XrefRangeEnd = 342114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(X509CertificateImpl impl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000FE5F4 File Offset: 0x000FC7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342115, RefRangeEnd = 342116, XrefRangeStart = 342115, XrefRangeEnd = 342115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportHandle(X509CertificateImpl impl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x000FE638 File Offset: 0x000FC838
		public unsafe X509CertificateImpl Impl
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 342117, RefRangeEnd = 342119, XrefRangeStart = 342116, XrefRangeEnd = 342117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr3) : null;
			}
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x060033DF RID: 13279 RVA: 0x000FE678 File Offset: 0x000FC878
		public unsafe bool IsValid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 342120, RefRangeEnd = 342122, XrefRangeStart = 342119, XrefRangeEnd = 342120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000FE6B4 File Offset: 0x000FC8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342122, XrefRangeEnd = 342125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(X509Certificate other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x000FE70C File Offset: 0x000FC90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342125, XrefRangeEnd = 342126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetCertHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x000FE758 File Offset: 0x000FC958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342126, XrefRangeEnd = 342127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetCertHashString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033E3 RID: 13283 RVA: 0x000FE79C File Offset: 0x000FC99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342127, XrefRangeEnd = 342128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060033E4 RID: 13284 RVA: 0x000FE7E4 File Offset: 0x000FC9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342128, XrefRangeEnd = 342130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetRawCertData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060033E5 RID: 13285 RVA: 0x000FE830 File Offset: 0x000FCA30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342130, XrefRangeEnd = 342132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetSerialNumber()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x060033E6 RID: 13286 RVA: 0x000FE87C File Offset: 0x000FCA7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342132, XrefRangeEnd = 342136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSerialNumberString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033E7 RID: 13287 RVA: 0x000FE8C0 File Offset: 0x000FCAC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342136, XrefRangeEnd = 342142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060033E8 RID: 13288 RVA: 0x000FE904 File Offset: 0x000FCB04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342145, RefRangeEnd = 342146, XrefRangeStart = 342142, XrefRangeEnd = 342145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToString(bool fVerbose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fVerbose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033E9 RID: 13289 RVA: 0x000FE954 File Offset: 0x000FCB54
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EA RID: 13290 RVA: 0x000FE990 File Offset: 0x000FCB90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342160, RefRangeEnd = 342161, XrefRangeStart = 342146, XrefRangeEnd = 342160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x000FE9F4 File Offset: 0x000FCBF4
		public unsafe string Issuer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 342162, RefRangeEnd = 342163, XrefRangeStart = 342161, XrefRangeEnd = 342162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Issuer_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x060033EC RID: 13292 RVA: 0x000FEA2C File Offset: 0x000FCC2C
		public unsafe string Subject
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 342164, RefRangeEnd = 342165, XrefRangeStart = 342163, XrefRangeEnd = 342164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_get_Subject_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x000FEA64 File Offset: 0x000FCC64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342165, XrefRangeEnd = 342167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x000FEABC File Offset: 0x000FCCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342167, XrefRangeEnd = 342168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Import(Il2CppStructArray<byte> rawData, string password, X509KeyStorageFlags keyStorageFlags)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Import_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033EF RID: 13295 RVA: 0x000FEB2C File Offset: 0x000FCD2C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x000FEB70 File Offset: 0x000FCD70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 342168, XrefRangeEnd = 342178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x000FEBCC File Offset: 0x000FCDCC
		[CallerCount(0)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x000FEC00 File Offset: 0x000FCE00
		[CallerCount(0)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x000FEC4C File Offset: 0x000FCE4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 342182, RefRangeEnd = 342183, XrefRangeStart = 342178, XrefRangeEnd = 342182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate.NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00012907 File Offset: 0x00010B07
		public X509Certificate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x000FEC88 File Offset: 0x000FCE88
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x00012910 File Offset: 0x00010B10
		public unsafe X509CertificateImpl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509CertificateImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x000FECB8 File Offset: 0x000FCEB8
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x0001292F File Offset: 0x00010B2F
		public unsafe bool hideDates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_hideDates);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_hideDates)) = value;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x000FECE0 File Offset: 0x000FCEE0
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x0001294A File Offset: 0x00010B4A
		public unsafe string issuer_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_issuer_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x000FED08 File Offset: 0x000FCF08
		// (set) Token: 0x060033FC RID: 13308 RVA: 0x00012969 File Offset: 0x00010B69
		public unsafe string subject_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate.NativeFieldInfoPtr_subject_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002C11 RID: 11281
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x04002C12 RID: 11282
		private static readonly IntPtr NativeFieldInfoPtr_hideDates;

		// Token: 0x04002C13 RID: 11283
		private static readonly IntPtr NativeFieldInfoPtr_issuer_name;

		// Token: 0x04002C14 RID: 11284
		private static readonly IntPtr NativeFieldInfoPtr_subject_name;

		// Token: 0x04002C15 RID: 11285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509CertificateImpl_0;

		// Token: 0x04002C16 RID: 11286
		private static readonly IntPtr NativeMethodInfoPtr_ImportHandle_Internal_Void_X509CertificateImpl_0;

		// Token: 0x04002C17 RID: 11287
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509CertificateImpl_0;

		// Token: 0x04002C18 RID: 11288
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Internal_get_Boolean_0;

		// Token: 0x04002C19 RID: 11289
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_X509Certificate_0;

		// Token: 0x04002C1A RID: 11290
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHash_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C1B RID: 11291
		private static readonly IntPtr NativeMethodInfoPtr_GetCertHashString_Public_Virtual_New_String_0;

		// Token: 0x04002C1C RID: 11292
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002C1D RID: 11293
		private static readonly IntPtr NativeMethodInfoPtr_GetRawCertData_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C1E RID: 11294
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumber_Public_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002C1F RID: 11295
		private static readonly IntPtr NativeMethodInfoPtr_GetSerialNumberString_Public_Virtual_New_String_0;

		// Token: 0x04002C20 RID: 11296
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002C21 RID: 11297
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_New_String_Boolean_0;

		// Token: 0x04002C22 RID: 11298
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002C23 RID: 11299
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002C24 RID: 11300
		private static readonly IntPtr NativeMethodInfoPtr_get_Issuer_Public_get_String_0;

		// Token: 0x04002C25 RID: 11301
		private static readonly IntPtr NativeMethodInfoPtr_get_Subject_Public_get_String_0;

		// Token: 0x04002C26 RID: 11302
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002C27 RID: 11303
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04002C28 RID: 11304
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04002C29 RID: 11305
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04002C2A RID: 11306
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002C2B RID: 11307
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002C2C RID: 11308
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_New_Void_0;
	}
}
