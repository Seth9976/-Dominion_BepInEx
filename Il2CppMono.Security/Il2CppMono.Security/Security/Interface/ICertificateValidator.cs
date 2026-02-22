using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200001C RID: 28
	public class ICertificateValidator : Il2CppObjectBase
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00008F9C File Offset: 0x0000719C
		// Note: this type is marked as 'beforefieldinit'.
		static ICertificateValidator()
		{
			Il2CppClassPointerStore<ICertificateValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "ICertificateValidator");
			ICertificateValidator.NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_MonoTlsSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificateValidator>.NativeClassPtr, 100663498);
			ICertificateValidator.NativeMethodInfoPtr_SelectClientCertificate_Public_Abstract_Virtual_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICertificateValidator>.NativeClassPtr, 100663499);
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00008FEC File Offset: 0x000071EC
		public unsafe virtual MonoTlsSettings Settings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificateValidator.NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_MonoTlsSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MonoTlsSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009038 File Offset: 0x00007238
		[CallerCount(0)]
		public unsafe virtual bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, Il2CppStringArray acceptableIssuers, out X509Certificate clientCertificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localCertificates);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCertificate);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(acceptableIssuers);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICertificateValidator.NativeMethodInfoPtr_SelectClientCertificate_Public_Abstract_Virtual_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clientCertificate = ((intPtr4 == 0) ? null : new X509Certificate(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public ICertificateValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012A RID: 298
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Abstract_Virtual_New_get_MonoTlsSettings_0;

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_SelectClientCertificate_Public_Abstract_Virtual_New_Boolean_String_X509CertificateCollection_X509Certificate_Il2CppStringArray_byref_X509Certificate_0;
	}
}
