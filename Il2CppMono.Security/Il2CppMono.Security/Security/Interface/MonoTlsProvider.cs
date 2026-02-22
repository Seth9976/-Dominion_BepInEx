using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x02000025 RID: 37
	public class MonoTlsProvider : Object
	{
		// Token: 0x060001C2 RID: 450 RVA: 0x0000A0DC File Offset: 0x000082DC
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTlsProvider()
		{
			Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "MonoTlsProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr);
			MonoTlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663533);
			MonoTlsProvider.NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663534);
			MonoTlsProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663535);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663536);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663537);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663538);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663539);
			MonoTlsProvider.NativeMethodInfoPtr_CreateSslStream_Public_Abstract_Virtual_New_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663540);
			MonoTlsProvider.NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Abstract_Virtual_New_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663541);
			MonoTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663542);
			MonoTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr, 100663543);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTlsProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTlsProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTlsProvider.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000A224 File Offset: 0x00008424
		public unsafe virtual Guid ID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x0000A26C File Offset: 0x0000846C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000A2B0 File Offset: 0x000084B0
		public unsafe virtual bool SupportsSslStream
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x0000A2F8 File Offset: 0x000084F8
		public unsafe virtual bool SupportsConnectionInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000A340 File Offset: 0x00008540
		public unsafe virtual bool SupportsMonoExtensions
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0000A388 File Offset: 0x00008588
		public unsafe virtual SslProtocols SupportedProtocols
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000A3D0 File Offset: 0x000085D0
		[CallerCount(0)]
		public unsafe virtual IMonoSslStream CreateSslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_CreateSslStream_Public_Abstract_Virtual_New_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr3) : null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000A44C File Offset: 0x0000864C
		[CallerCount(0)]
		public unsafe virtual IMonoSslStream CreateSslStreamInternal(SslStream sslStream, Stream innerStream, bool leaveInnerStreamOpen, MonoTlsSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sslStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Abstract_Virtual_New_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMonoSslStream>(intPtr3) : null;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000A4DC File Offset: 0x000086DC
		[CallerCount(0)]
		public unsafe virtual bool ValidateCertificate(ICertificateValidator2 validator, string targetHost, bool serverMode, X509CertificateCollection certificates, bool wantsChain, ref X509Chain chain, ref MonoSslPolicyErrors errors, ref int status11)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serverMode;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(certificates);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wantsChain;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(chain);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &errors;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &status11;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			chain = ((intPtr4 == 0) ? null : new X509Chain(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0000A5C0 File Offset: 0x000087C0
		public unsafe virtual bool SupportsCleanShutdown
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoTlsProvider.NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002C1D File Offset: 0x00000E1D
		public MonoTlsProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_get_ID_Public_Abstract_Virtual_New_get_Guid_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsSslStream_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsConnectionInfo_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsMonoExtensions_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportedProtocols_Public_Abstract_Virtual_New_get_SslProtocols_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStream_Public_Abstract_Virtual_New_IMonoSslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_CreateSslStreamInternal_Internal_Abstract_Virtual_New_IMonoSslStream_SslStream_Stream_Boolean_MonoTlsSettings_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_ValidateCertificate_Internal_Abstract_Virtual_New_Boolean_ICertificateValidator2_String_Boolean_X509CertificateCollection_Boolean_byref_X509Chain_byref_MonoSslPolicyErrors_byref_Int32_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportsCleanShutdown_Internal_Abstract_Virtual_New_get_Boolean_0;
	}
}
