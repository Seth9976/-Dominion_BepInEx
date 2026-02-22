using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Cryptography;

namespace Il2CppMono.Security.Cryptography
{
	// Token: 0x02000031 RID: 49
	public sealed class PKCS8 : Object
	{
		// Token: 0x06000330 RID: 816 RVA: 0x00003514 File Offset: 0x00001714
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS8()
		{
			Il2CppClassPointerStore<PKCS8>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security.Cryptography", "PKCS8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8>.NativeClassPtr);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00003539 File Offset: 0x00001739
		public PKCS8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x02000543 RID: 1347
		public class PrivateKeyInfo : Object
		{
			// Token: 0x06004DE8 RID: 19944 RVA: 0x0015F48C File Offset: 0x0015D68C
			// Note: this type is marked as 'beforefieldinit'.
			static PrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "PrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr);
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_version");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_key");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_list");
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663714);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663715);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663716);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663717);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663718);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663719);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663720);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663721);
			}

			// Token: 0x06004DE9 RID: 19945 RVA: 0x0015F5A8 File Offset: 0x0015D7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 262956, XrefRangeEnd = 262961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DEA RID: 19946 RVA: 0x0015F5E4 File Offset: 0x0015D7E4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 262967, RefRangeEnd = 262971, XrefRangeStart = 262961, XrefRangeEnd = 262967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170013E2 RID: 5090
			// (get) Token: 0x06004DEB RID: 19947 RVA: 0x0015F630 File Offset: 0x0015D830
			public unsafe Il2CppStructArray<byte> PrivateKey
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 262974, RefRangeEnd = 262977, XrefRangeStart = 262971, XrefRangeEnd = 262974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004DEC RID: 19948 RVA: 0x0015F670 File Offset: 0x0015D870
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 262993, RefRangeEnd = 262994, XrefRangeStart = 262977, XrefRangeEnd = 262993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DED RID: 19949 RVA: 0x0015F6B4 File Offset: 0x0015D8B4
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 262998, RefRangeEnd = 263000, XrefRangeStart = 262994, XrefRangeEnd = 262998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> RemoveLeadingZero(Il2CppStructArray<byte> bigInt)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004DEE RID: 19950 RVA: 0x0015F6F8 File Offset: 0x0015D8F8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 263004, RefRangeEnd = 263011, XrefRangeStart = 263000, XrefRangeEnd = 263004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Normalize(Il2CppStructArray<byte> bigInt, int length)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(bigInt);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}

			// Token: 0x06004DEF RID: 19951 RVA: 0x0015F74C File Offset: 0x0015D94C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 263050, RefRangeEnd = 263053, XrefRangeStart = 263011, XrefRangeEnd = 263050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static RSA DecodeRSA(Il2CppStructArray<byte> keypair)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(keypair);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RSA>(intPtr3) : null;
				}
			}

			// Token: 0x06004DF0 RID: 19952 RVA: 0x0015F790 File Offset: 0x0015D990
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 263060, RefRangeEnd = 263063, XrefRangeStart = 263053, XrefRangeEnd = 263060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static DSA DecodeDSA(Il2CppStructArray<byte> privateKey, DSAParameters dsaParameters)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(privateKey);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dsaParameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
			}

			// Token: 0x06004DF1 RID: 19953 RVA: 0x0001D805 File Offset: 0x0001BA05
			public PrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013DE RID: 5086
			// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x0015F7EC File Offset: 0x0015D9EC
			// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x0001D80E File Offset: 0x0001BA0E
			public unsafe int _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170013DF RID: 5087
			// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x0015F814 File Offset: 0x0015DA14
			// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x0001D829 File Offset: 0x0001BA29
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170013E0 RID: 5088
			// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x0015F83C File Offset: 0x0015DA3C
			// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x0001D848 File Offset: 0x0001BA48
			public unsafe Il2CppStructArray<byte> _key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E1 RID: 5089
			// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x0015F86C File Offset: 0x0015DA6C
			// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x0001D867 File Offset: 0x0001BA67
			public unsafe ArrayList _list
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EEC RID: 16108
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04003EED RID: 16109
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04003EEE RID: 16110
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04003EEF RID: 16111
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04003EF0 RID: 16112
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EF1 RID: 16113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EF2 RID: 16114
			private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EF3 RID: 16115
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EF4 RID: 16116
			private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EF5 RID: 16117
			private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04003EF6 RID: 16118
			private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EF7 RID: 16119
			private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0;
		}

		// Token: 0x02000544 RID: 1348
		public class EncryptedPrivateKeyInfo : Object
		{
			// Token: 0x06004DFA RID: 19962 RVA: 0x0015F89C File Offset: 0x0015DA9C
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedPrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "EncryptedPrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr);
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_salt");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_iterations");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_data");
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663722);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663723);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663724);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663725);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663726);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663727);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663728);
			}

			// Token: 0x06004DFB RID: 19963 RVA: 0x0015F9A4 File Offset: 0x0015DBA4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DFC RID: 19964 RVA: 0x0015F9E0 File Offset: 0x0015DBE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 263065, RefRangeEnd = 263067, XrefRangeStart = 263063, XrefRangeEnd = 263065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedPrivateKeyInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170013E7 RID: 5095
			// (get) Token: 0x06004DFD RID: 19965 RVA: 0x0015FA2C File Offset: 0x0015DC2C
			public unsafe string Algorithm
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170013E8 RID: 5096
			// (get) Token: 0x06004DFE RID: 19966 RVA: 0x0015FA64 File Offset: 0x0015DC64
			public unsafe Il2CppStructArray<byte> EncryptedData
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 263068, RefRangeEnd = 263070, XrefRangeStart = 263067, XrefRangeEnd = 263068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x170013E9 RID: 5097
			// (get) Token: 0x06004DFF RID: 19967 RVA: 0x0015FAA4 File Offset: 0x0015DCA4
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 263076, RefRangeEnd = 263078, XrefRangeStart = 263070, XrefRangeEnd = 263076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x170013EA RID: 5098
			// (get) Token: 0x06004E00 RID: 19968 RVA: 0x0015FAE4 File Offset: 0x0015DCE4
			public unsafe int IterationCount
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004E01 RID: 19969 RVA: 0x0015FB20 File Offset: 0x0015DD20
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263093, RefRangeEnd = 263094, XrefRangeStart = 263078, XrefRangeEnd = 263093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Decode(Il2CppStructArray<byte> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004E02 RID: 19970 RVA: 0x0001D886 File Offset: 0x0001BA86
			public EncryptedPrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013E3 RID: 5091
			// (get) Token: 0x06004E03 RID: 19971 RVA: 0x0015FB64 File Offset: 0x0015DD64
			// (set) Token: 0x06004E04 RID: 19972 RVA: 0x0001D88F File Offset: 0x0001BA8F
			public unsafe string _algorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170013E4 RID: 5092
			// (get) Token: 0x06004E05 RID: 19973 RVA: 0x0015FB8C File Offset: 0x0015DD8C
			// (set) Token: 0x06004E06 RID: 19974 RVA: 0x0001D8AE File Offset: 0x0001BAAE
			public unsafe Il2CppStructArray<byte> _salt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013E5 RID: 5093
			// (get) Token: 0x06004E07 RID: 19975 RVA: 0x0015FBBC File Offset: 0x0015DDBC
			// (set) Token: 0x06004E08 RID: 19976 RVA: 0x0001D8CD File Offset: 0x0001BACD
			public unsafe int _iterations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations)) = value;
				}
			}

			// Token: 0x170013E6 RID: 5094
			// (get) Token: 0x06004E09 RID: 19977 RVA: 0x0015FBE4 File Offset: 0x0015DDE4
			// (set) Token: 0x06004E0A RID: 19978 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
			public unsafe Il2CppStructArray<byte> _data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EF8 RID: 16120
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04003EF9 RID: 16121
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x04003EFA RID: 16122
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x04003EFB RID: 16123
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x04003EFC RID: 16124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EFD RID: 16125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EFE RID: 16126
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x04003EFF RID: 16127
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003F00 RID: 16128
			private static readonly IntPtr NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003F01 RID: 16129
			private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

			// Token: 0x04003F02 RID: 16130
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;
		}
	}
}
