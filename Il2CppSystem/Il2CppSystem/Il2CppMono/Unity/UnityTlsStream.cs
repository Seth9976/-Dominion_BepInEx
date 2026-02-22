using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Net.Security;
using Il2CppMono.Security.Interface;
using Il2CppSystem.IO;
using Il2CppSystem.Net.Security;
using Il2CppSystem.Security.Authentication;
using Il2CppSystem.Security.Cryptography.X509Certificates;

namespace Il2CppMono.Unity
{
	// Token: 0x0200000A RID: 10
	public class UnityTlsStream : MobileAuthenticatedStream
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00012270 File Offset: 0x00010470
		// Note: this type is marked as 'beforefieldinit'.
		static UnityTlsStream()
		{
			Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "Mono.Unity", "UnityTlsStream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr);
			UnityTlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr, 100663419);
			UnityTlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr, 100663420);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000122C8 File Offset: 0x000104C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32279, XrefRangeEnd = 32283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityTlsStream(Stream innerStream, bool leaveInnerStreamOpen, SslStream owner, MonoTlsSettings settings, MonoTlsProvider provider)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityTlsStream>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(innerStream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref leaveInnerStreamOpen;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityTlsStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0001235C File Offset: 0x0001055C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 32283, XrefRangeEnd = 32287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MobileTlsContext CreateContext(bool serverMode, string targetHost, SslProtocols enabledProtocols, X509Certificate serverCertificate, X509CertificateCollection clientCertificates, bool askForClientCert)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref serverMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetHost);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabledProtocols;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serverCertificate);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clientCertificates);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref askForClientCert;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnityTlsStream.NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MobileTlsContext>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022F3 File Offset: 0x000004F3
		public UnityTlsStream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_Boolean_SslStream_MonoTlsSettings_MonoTlsProvider_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_CreateContext_Protected_Virtual_MobileTlsContext_Boolean_String_SslProtocols_X509Certificate_X509CertificateCollection_Boolean_0;
	}
}
