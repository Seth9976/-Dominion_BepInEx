using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Security.X509;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x02000088 RID: 136
	public sealed class PublicKey : Object
	{
		// Token: 0x06000815 RID: 2069 RVA: 0x0002E21C File Offset: 0x0002C41C
		// Note: this type is marked as 'beforefieldinit'.
		static PublicKey()
		{
			Il2CppClassPointerStore<PublicKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "PublicKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublicKey>.NativeClassPtr);
			PublicKey.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_key");
			PublicKey.NativeFieldInfoPtr__keyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_keyValue");
			PublicKey.NativeFieldInfoPtr__params = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_params");
			PublicKey.NativeFieldInfoPtr__oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "_oid");
			PublicKey.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, "Empty");
			PublicKey.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664344);
			PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664345);
			PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664346);
			PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664347);
			PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664348);
			PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664349);
			PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664350);
			PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublicKey>.NativeClassPtr, 100664351);
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x0002E350 File Offset: 0x0002C550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41847, RefRangeEnd = 41848, XrefRangeStart = 41806, XrefRangeEnd = 41847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PublicKey(Il2CppMono.Security.X509.X509Certificate certificate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PublicKey>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x0002E39C File Offset: 0x0002C59C
		public unsafe AsnEncodedData EncodedKeyValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x0002E3DC File Offset: 0x0002C5DC
		public unsafe AsnEncodedData EncodedParameters
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr3) : null;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x0002E41C File Offset: 0x0002C61C
		public unsafe AsymmetricAlgorithm Key
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 41856, RefRangeEnd = 41858, XrefRangeStart = 41848, XrefRangeEnd = 41856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr3) : null;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x0002E45C File Offset: 0x0002C65C
		public unsafe Oid Oid
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_get_Oid_Public_get_Oid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr3) : null;
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0002E49C File Offset: 0x0002C69C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 41862, RefRangeEnd = 41867, XrefRangeStart = 41858, XrefRangeEnd = 41862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> GetUnsignedBigInteger(Il2CppStructArray<byte> integer)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(integer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0002E4E0 File Offset: 0x0002C6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 41867, XrefRangeEnd = 41898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> rawPublicKey, Il2CppStructArray<byte> rawParameters)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rawParameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0002E538 File Offset: 0x0002C738
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 41915, RefRangeEnd = 41916, XrefRangeStart = 41898, XrefRangeEnd = 41915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> rawPublicKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawPublicKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublicKey.NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00005470 File Offset: 0x00003670
		public PublicKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x0002E57C File Offset: 0x0002C77C
		// (set) Token: 0x06000820 RID: 2080 RVA: 0x00005479 File Offset: 0x00003679
		public unsafe AsymmetricAlgorithm _key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__key);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsymmetricAlgorithm>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0002E5AC File Offset: 0x0002C7AC
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00005498 File Offset: 0x00003698
		public unsafe AsnEncodedData _keyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__keyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x0002E5DC File Offset: 0x0002C7DC
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x000054B7 File Offset: 0x000036B7
		public unsafe AsnEncodedData _params
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsnEncodedData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__params), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0002E60C File Offset: 0x0002C80C
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x000054D6 File Offset: 0x000036D6
		public unsafe Oid _oid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oid>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PublicKey.NativeFieldInfoPtr__oid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0002E63C File Offset: 0x0002C83C
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x000054F5 File Offset: 0x000036F5
		public unsafe static Il2CppStructArray<byte> Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PublicKey.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PublicKey.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr__keyValue;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeFieldInfoPtr__params;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeFieldInfoPtr__oid;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509Certificate_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedKeyValue_Public_get_AsnEncodedData_0;

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeMethodInfoPtr_get_EncodedParameters_Public_get_AsnEncodedData_0;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_AsymmetricAlgorithm_0;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeMethodInfoPtr_get_Oid_Public_get_Oid_0;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeMethodInfoPtr_GetUnsignedBigInteger_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Internal_Static_DSA_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Internal_Static_RSA_Il2CppStructArray_1_Byte_0;
	}
}
