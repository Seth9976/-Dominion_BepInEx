using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008D RID: 141
	public class X509Certificate2Impl : X509CertificateImpl
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x0002F248 File Offset: 0x0002D448
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2Impl()
		{
			Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2Impl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr);
			X509Certificate2Impl.NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664382);
			X509Certificate2Impl.NativeMethodInfoPtr_get_PublicKey_Public_Abstract_Virtual_New_get_PublicKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664383);
			X509Certificate2Impl.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664384);
			X509Certificate2Impl.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664385);
			X509Certificate2Impl.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664386);
			X509Certificate2Impl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664387);
			X509Certificate2Impl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664388);
			X509Certificate2Impl.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr, 100664389);
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0002F318 File Offset: 0x0002D518
		public unsafe virtual AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0002F364 File Offset: 0x0002D564
		public unsafe virtual PublicKey PublicKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_PublicKey_Public_Abstract_Virtual_New_get_PublicKey_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr3) : null;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0002F3B0 File Offset: 0x0002D5B0
		public unsafe virtual Oid SignatureAlgorithm
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_Oid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x0002F3FC File Offset: 0x0002D5FC
		public unsafe virtual int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002F444 File Offset: 0x0002D644
		public unsafe virtual X509CertificateImplCollection IntermediateCertificates
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509CertificateImplCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0002F490 File Offset: 0x0002D690
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0002F500 File Offset: 0x0002D700
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2Impl.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002F53C File Offset: 0x0002D73C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2Impl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2Impl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2Impl.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0000565C File Offset: 0x0000385C
		public X509Certificate2Impl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_Abstract_Virtual_New_get_AsymmetricAlgorithm_0;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_Abstract_Virtual_New_get_PublicKey_0;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_Abstract_Virtual_New_get_Oid_0;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeMethodInfoPtr_get_IntermediateCertificates_Internal_Abstract_Virtual_New_get_X509CertificateImplCollection_0;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
