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
	// Token: 0x0200002F RID: 47
	public sealed class PKCS8 : Object
	{
		// Token: 0x0600025A RID: 602 RVA: 0x00003069 File Offset: 0x00001269
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS8()
		{
			Il2CppClassPointerStore<PKCS8>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Cryptography", "PKCS8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8>.NativeClassPtr);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000308E File Offset: 0x0000128E
		public PKCS8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200003C RID: 60
		public class PrivateKeyInfo : Object
		{
			// Token: 0x06000343 RID: 835 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
			// Note: this type is marked as 'beforefieldinit'.
			static PrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "PrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr);
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_version");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_key");
				PKCS8.PrivateKeyInfo.NativeFieldInfoPtr__list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, "_list");
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663603);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663604);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663605);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663606);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663607);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663608);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663609);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663610);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663611);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663612);
				PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr, 100663613);
			}

			// Token: 0x06000344 RID: 836 RVA: 0x0000F648 File Offset: 0x0000D848
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10422, XrefRangeEnd = 10427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PrivateKeyInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS8.PrivateKeyInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000345 RID: 837 RVA: 0x0000F684 File Offset: 0x0000D884
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 10433, RefRangeEnd = 10437, XrefRangeStart = 10427, XrefRangeEnd = 10433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000346 RID: 838 RVA: 0x0000F6D0 File Offset: 0x0000D8D0
			public unsafe Il2CppStructArray<byte> PrivateKey
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 10440, RefRangeEnd = 10443, XrefRangeStart = 10437, XrefRangeEnd = 10440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000347 RID: 839 RVA: 0x0000F710 File Offset: 0x0000D910
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10459, RefRangeEnd = 10460, XrefRangeStart = 10443, XrefRangeEnd = 10459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000348 RID: 840 RVA: 0x0000F754 File Offset: 0x0000D954
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10464, RefRangeEnd = 10466, XrefRangeStart = 10460, XrefRangeEnd = 10464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000349 RID: 841 RVA: 0x0000F798 File Offset: 0x0000D998
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 10470, RefRangeEnd = 10477, XrefRangeStart = 10466, XrefRangeEnd = 10470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034A RID: 842 RVA: 0x0000F7EC File Offset: 0x0000D9EC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 10516, RefRangeEnd = 10519, XrefRangeStart = 10477, XrefRangeEnd = 10516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034B RID: 843 RVA: 0x0000F830 File Offset: 0x0000DA30
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10547, RefRangeEnd = 10548, XrefRangeStart = 10519, XrefRangeEnd = 10547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(RSA rsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(rsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600034C RID: 844 RVA: 0x0000F874 File Offset: 0x0000DA74
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 10555, RefRangeEnd = 10558, XrefRangeStart = 10548, XrefRangeEnd = 10555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x0600034D RID: 845 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 10558, XrefRangeEnd = 10560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(DSA dsa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(dsa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600034E RID: 846 RVA: 0x0000F914 File Offset: 0x0000DB14
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10577, RefRangeEnd = 10578, XrefRangeStart = 10560, XrefRangeEnd = 10577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppStructArray<byte> Encode(AsymmetricAlgorithm aa)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS8.PrivateKeyInfo.NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x0600034F RID: 847 RVA: 0x000035F2 File Offset: 0x000017F2
			public PrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000350 RID: 848 RVA: 0x0000F958 File Offset: 0x0000DB58
			// (set) Token: 0x06000351 RID: 849 RVA: 0x000035FB File Offset: 0x000017FB
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

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000352 RID: 850 RVA: 0x0000F980 File Offset: 0x0000DB80
			// (set) Token: 0x06000353 RID: 851 RVA: 0x00003616 File Offset: 0x00001816
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

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000354 RID: 852 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
			// (set) Token: 0x06000355 RID: 853 RVA: 0x00003635 File Offset: 0x00001835
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

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000356 RID: 854 RVA: 0x0000F9D8 File Offset: 0x0000DBD8
			// (set) Token: 0x06000357 RID: 855 RVA: 0x00003654 File Offset: 0x00001854
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

			// Token: 0x0400036E RID: 878
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x0400036F RID: 879
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x04000370 RID: 880
			private static readonly IntPtr NativeFieldInfoPtr__key;

			// Token: 0x04000371 RID: 881
			private static readonly IntPtr NativeFieldInfoPtr__list;

			// Token: 0x04000372 RID: 882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000373 RID: 883
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000374 RID: 884
			private static readonly IntPtr NativeMethodInfoPtr_get_PrivateKey_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000375 RID: 885
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000376 RID: 886
			private static readonly IntPtr NativeMethodInfoPtr_RemoveLeadingZero_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000377 RID: 887
			private static readonly IntPtr NativeMethodInfoPtr_Normalize_Private_Static_Il2CppStructArray_1_Byte_Il2CppStructArray_1_Byte_Int32_0;

			// Token: 0x04000378 RID: 888
			private static readonly IntPtr NativeMethodInfoPtr_DecodeRSA_Public_Static_RSA_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000379 RID: 889
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_RSA_0;

			// Token: 0x0400037A RID: 890
			private static readonly IntPtr NativeMethodInfoPtr_DecodeDSA_Public_Static_DSA_Il2CppStructArray_1_Byte_DSAParameters_0;

			// Token: 0x0400037B RID: 891
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_DSA_0;

			// Token: 0x0400037C RID: 892
			private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_Static_Il2CppStructArray_1_Byte_AsymmetricAlgorithm_0;
		}

		// Token: 0x0200003D RID: 61
		public class EncryptedPrivateKeyInfo : Object
		{
			// Token: 0x06000358 RID: 856 RVA: 0x0000FA08 File Offset: 0x0000DC08
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedPrivateKeyInfo()
			{
				Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS8>.NativeClassPtr, "EncryptedPrivateKeyInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr);
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__algorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_algorithm");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__salt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_salt");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__iterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_iterations");
				PKCS8.EncryptedPrivateKeyInfo.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, "_data");
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663614);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663615);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Algorithm_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663616);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663617);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663618);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663619);
				PKCS8.EncryptedPrivateKeyInfo.NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS8.EncryptedPrivateKeyInfo>.NativeClassPtr, 100663620);
			}

			// Token: 0x06000359 RID: 857 RVA: 0x0000FB10 File Offset: 0x0000DD10
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

			// Token: 0x0600035A RID: 858 RVA: 0x0000FB4C File Offset: 0x0000DD4C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 10580, RefRangeEnd = 10582, XrefRangeStart = 10578, XrefRangeEnd = 10580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600035B RID: 859 RVA: 0x0000FB98 File Offset: 0x0000DD98
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

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600035C RID: 860 RVA: 0x0000FBD0 File Offset: 0x0000DDD0
			public unsafe Il2CppStructArray<byte> EncryptedData
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 10583, RefRangeEnd = 10585, XrefRangeStart = 10582, XrefRangeEnd = 10583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x0600035D RID: 861 RVA: 0x0000FC10 File Offset: 0x0000DE10
			public unsafe Il2CppStructArray<byte> Salt
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 10591, RefRangeEnd = 10593, XrefRangeStart = 10585, XrefRangeEnd = 10591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x0600035E RID: 862 RVA: 0x0000FC50 File Offset: 0x0000DE50
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

			// Token: 0x0600035F RID: 863 RVA: 0x0000FC8C File Offset: 0x0000DE8C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 10608, RefRangeEnd = 10609, XrefRangeStart = 10593, XrefRangeEnd = 10608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

			// Token: 0x06000360 RID: 864 RVA: 0x00003673 File Offset: 0x00001873
			public EncryptedPrivateKeyInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000361 RID: 865 RVA: 0x0000FCD0 File Offset: 0x0000DED0
			// (set) Token: 0x06000362 RID: 866 RVA: 0x0000367C File Offset: 0x0000187C
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

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000363 RID: 867 RVA: 0x0000FCF8 File Offset: 0x0000DEF8
			// (set) Token: 0x06000364 RID: 868 RVA: 0x0000369B File Offset: 0x0000189B
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

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x06000365 RID: 869 RVA: 0x0000FD28 File Offset: 0x0000DF28
			// (set) Token: 0x06000366 RID: 870 RVA: 0x000036BA File Offset: 0x000018BA
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

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x06000367 RID: 871 RVA: 0x0000FD50 File Offset: 0x0000DF50
			// (set) Token: 0x06000368 RID: 872 RVA: 0x000036D5 File Offset: 0x000018D5
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

			// Token: 0x0400037D RID: 893
			private static readonly IntPtr NativeFieldInfoPtr__algorithm;

			// Token: 0x0400037E RID: 894
			private static readonly IntPtr NativeFieldInfoPtr__salt;

			// Token: 0x0400037F RID: 895
			private static readonly IntPtr NativeFieldInfoPtr__iterations;

			// Token: 0x04000380 RID: 896
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x04000381 RID: 897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000382 RID: 898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000383 RID: 899
			private static readonly IntPtr NativeMethodInfoPtr_get_Algorithm_Public_get_String_0;

			// Token: 0x04000384 RID: 900
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedData_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000385 RID: 901
			private static readonly IntPtr NativeMethodInfoPtr_get_Salt_Public_get_Il2CppStructArray_1_Byte_0;

			// Token: 0x04000386 RID: 902
			private static readonly IntPtr NativeMethodInfoPtr_get_IterationCount_Public_get_Int32_0;

			// Token: 0x04000387 RID: 903
			private static readonly IntPtr NativeMethodInfoPtr_Decode_Private_Void_Il2CppStructArray_1_Byte_0;
		}
	}
}
