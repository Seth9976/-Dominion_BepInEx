using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Text;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x0200008B RID: 139
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x0002EB8C File Offset: 0x0002CD8C
		// Note: this type is marked as 'beforefieldinit'.
		static X509Certificate2()
		{
			Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Certificate2");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr);
			X509Certificate2.NativeFieldInfoPtr_friendlyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "friendlyName");
			X509Certificate2.NativeFieldInfoPtr_signedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, "signedData");
			X509Certificate2.NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664363);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664364);
			X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664365);
			X509Certificate2.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664366);
			X509Certificate2.NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664367);
			X509Certificate2.NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664368);
			X509Certificate2.NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664369);
			X509Certificate2.NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664370);
			X509Certificate2.NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664371);
			X509Certificate2.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664372);
			X509Certificate2.NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664373);
			X509Certificate2.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664374);
			X509Certificate2.NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664375);
			X509Certificate2.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664376);
			X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664377);
			X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664378);
			X509Certificate2.NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr, 100664379);
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x0002ED38 File Offset: 0x0002CF38
		public new unsafe X509Certificate2Impl Impl
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 42059, RefRangeEnd = 42073, XrefRangeStart = 42053, XrefRangeEnd = 42059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Certificate2Impl>(intPtr3) : null;
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0002ED78 File Offset: 0x0002CF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42073, XrefRangeEnd = 42076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0002EDB4 File Offset: 0x0002CFB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 42079, RefRangeEnd = 42080, XrefRangeStart = 42076, XrefRangeEnd = 42079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(Il2CppStructArray<byte> rawData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0002EE00 File Offset: 0x0002D000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42080, XrefRangeEnd = 42083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Certificate2(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Certificate2>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0002EE64 File Offset: 0x0002D064
		public unsafe DateTime NotAfter
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42083, XrefRangeEnd = 42085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0002EEA0 File Offset: 0x0002D0A0
		public unsafe DateTime NotBefore
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42085, XrefRangeEnd = 42087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0002EEDC File Offset: 0x0002D0DC
		public unsafe AsymmetricAlgorithm PrivateKey
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 42089, RefRangeEnd = 42091, XrefRangeStart = 42087, XrefRangeEnd = 42089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002EF1C File Offset: 0x0002D11C
		public unsafe PublicKey PublicKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42091, XrefRangeEnd = 42093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PublicKey>(intPtr3) : null;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0002EF5C File Offset: 0x0002D15C
		public unsafe string SerialNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0002EF94 File Offset: 0x0002D194
		public unsafe Oid SignatureAlgorithm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42093, XrefRangeEnd = 42095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0002EFD4 File Offset: 0x0002D1D4
		public unsafe string Thumbprint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0002F00C File Offset: 0x0002D20C
		public unsafe int Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42095, XrefRangeEnd = 42097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0002F048 File Offset: 0x0002D248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42097, XrefRangeEnd = 42102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0002F0B8 File Offset: 0x0002D2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42102, XrefRangeEnd = 42105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42105, XrefRangeEnd = 42109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0002F138 File Offset: 0x0002D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42109, XrefRangeEnd = 42204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString(bool verbose)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref verbose;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Certificate2.NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0002F188 File Offset: 0x0002D388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 42204, XrefRangeEnd = 42212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Certificate2.NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x000055CE File Offset: 0x000037CE
		public X509Certificate2(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000856 RID: 2134 RVA: 0x0002F1D0 File Offset: 0x0002D3D0
		// (set) Token: 0x06000857 RID: 2135 RVA: 0x000055D7 File Offset: 0x000037D7
		public unsafe string friendlyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_friendlyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Certificate2.NativeFieldInfoPtr_friendlyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000858 RID: 2136 RVA: 0x0002F1F8 File Offset: 0x0002D3F8
		// (set) Token: 0x06000859 RID: 2137 RVA: 0x000055F6 File Offset: 0x000037F6
		public unsafe static Il2CppStructArray<byte> signedData
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(X509Certificate2.NativeFieldInfoPtr_signedData, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(X509Certificate2.NativeFieldInfoPtr_signedData, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_friendlyName;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_signedData;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509Certificate2Impl_0;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_get_NotAfter_Public_get_DateTime_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_NotBefore_Public_get_DateTime_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_AsymmetricAlgorithm_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicKey_Public_get_PublicKey_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_get_SerialNumber_Public_get_String_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_SignatureAlgorithm_Public_get_Oid_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_get_Thumbprint_Public_get_String_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_Import_Public_Virtual_Void_Il2CppStructArray_1_Byte_String_X509KeyStorageFlags_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_Boolean_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_AppendBuffer_Private_Static_Void_StringBuilder_Il2CppStructArray_1_Byte_0;
	}
}
