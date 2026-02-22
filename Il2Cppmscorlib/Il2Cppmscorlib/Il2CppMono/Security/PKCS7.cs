using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security
{
	// Token: 0x02000021 RID: 33
	public sealed class PKCS7 : Object
	{
		// Token: 0x060001DD RID: 477 RVA: 0x00002BDF File Offset: 0x00000DDF
		// Note: this type is marked as 'beforefieldinit'.
		static PKCS7()
		{
			Il2CppClassPointerStore<PKCS7>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Security", "PKCS7");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7>.NativeClassPtr);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002C04 File Offset: 0x00000E04
		public PKCS7(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200053F RID: 1343
		public class ContentInfo : Object
		{
			// Token: 0x06004DA6 RID: 19878 RVA: 0x0015E5F4 File Offset: 0x0015C7F4
			// Note: this type is marked as 'beforefieldinit'.
			static ContentInfo()
			{
				Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "ContentInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr);
				PKCS7.ContentInfo.NativeFieldInfoPtr_contentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "contentType");
				PKCS7.ContentInfo.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, "content");
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663538);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663539);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663540);
				PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663541);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663542);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663543);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663544);
				PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663545);
				PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663546);
				PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr, 100663547);
			}

			// Token: 0x06004DA7 RID: 19879 RVA: 0x0015E710 File Offset: 0x0015C910
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260480, RefRangeEnd = 260481, XrefRangeStart = 260475, XrefRangeEnd = 260480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DA8 RID: 19880 RVA: 0x0015E74C File Offset: 0x0015C94C
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260486, RefRangeEnd = 260491, XrefRangeStart = 260481, XrefRangeEnd = 260486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(string oid)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DA9 RID: 19881 RVA: 0x0015E798 File Offset: 0x0015C998
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260496, RefRangeEnd = 260501, XrefRangeStart = 260491, XrefRangeEnd = 260496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(Il2CppStructArray<byte> data)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004DAA RID: 19882 RVA: 0x0015E7E4 File Offset: 0x0015C9E4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 260510, RefRangeEnd = 260513, XrefRangeStart = 260501, XrefRangeEnd = 260510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ContentInfo(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.ContentInfo>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170013C7 RID: 5063
			// (get) Token: 0x06004DAB RID: 19883 RVA: 0x0015E830 File Offset: 0x0015CA30
			public unsafe ASN1 ASN1
			{
				[CallerCount(5)]
				[CachedScanResults(RefRangeStart = 260521, RefRangeEnd = 260526, XrefRangeStart = 260513, XrefRangeEnd = 260521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}

			// Token: 0x170013C8 RID: 5064
			// (get) Token: 0x06004DAC RID: 19884 RVA: 0x0015E870 File Offset: 0x0015CA70
			// (set) Token: 0x06004DAD RID: 19885 RVA: 0x0015E8B0 File Offset: 0x0015CAB0
			public unsafe ASN1 Content
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_Content_Public_get_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
				[CallerCount(0)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x170013C9 RID: 5065
			// (get) Token: 0x06004DAE RID: 19886 RVA: 0x0015E8F4 File Offset: 0x0015CAF4
			// (set) Token: 0x06004DAF RID: 19887 RVA: 0x0015E92C File Offset: 0x0015CB2C
			public unsafe string ContentType
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_get_ContentType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06004DB0 RID: 19888 RVA: 0x0015E970 File Offset: 0x0015CB70
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 260521, RefRangeEnd = 260526, XrefRangeStart = 260521, XrefRangeEnd = 260526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ASN1 GetASN1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.ContentInfo.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}

			// Token: 0x06004DB1 RID: 19889 RVA: 0x0001D65E File Offset: 0x0001B85E
			public ContentInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013C5 RID: 5061
			// (get) Token: 0x06004DB2 RID: 19890 RVA: 0x0015E9B0 File Offset: 0x0015CBB0
			// (set) Token: 0x06004DB3 RID: 19891 RVA: 0x0001D667 File Offset: 0x0001B867
			public unsafe string contentType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_contentType), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170013C6 RID: 5062
			// (get) Token: 0x06004DB4 RID: 19892 RVA: 0x0015E9D8 File Offset: 0x0015CBD8
			// (set) Token: 0x06004DB5 RID: 19893 RVA: 0x0001D686 File Offset: 0x0001B886
			public unsafe ASN1 content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.ContentInfo.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003EC0 RID: 16064
			private static readonly IntPtr NativeFieldInfoPtr_contentType;

			// Token: 0x04003EC1 RID: 16065
			private static readonly IntPtr NativeFieldInfoPtr_content;

			// Token: 0x04003EC2 RID: 16066
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003EC3 RID: 16067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

			// Token: 0x04003EC4 RID: 16068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Byte_0;

			// Token: 0x04003EC5 RID: 16069
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04003EC6 RID: 16070
			private static readonly IntPtr NativeMethodInfoPtr_get_ASN1_Public_get_ASN1_0;

			// Token: 0x04003EC7 RID: 16071
			private static readonly IntPtr NativeMethodInfoPtr_get_Content_Public_get_ASN1_0;

			// Token: 0x04003EC8 RID: 16072
			private static readonly IntPtr NativeMethodInfoPtr_set_Content_Public_set_Void_ASN1_0;

			// Token: 0x04003EC9 RID: 16073
			private static readonly IntPtr NativeMethodInfoPtr_get_ContentType_Public_get_String_0;

			// Token: 0x04003ECA RID: 16074
			private static readonly IntPtr NativeMethodInfoPtr_set_ContentType_Public_set_Void_String_0;

			// Token: 0x04003ECB RID: 16075
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;
		}

		// Token: 0x02000540 RID: 1344
		public class EncryptedData : Object
		{
			// Token: 0x06004DB6 RID: 19894 RVA: 0x0015EA08 File Offset: 0x0015CC08
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptedData()
			{
				Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PKCS7>.NativeClassPtr, "EncryptedData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr);
				PKCS7.EncryptedData.NativeFieldInfoPtr__version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_version");
				PKCS7.EncryptedData.NativeFieldInfoPtr__content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_content");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encryptionAlgorithm");
				PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, "_encrypted");
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663548);
				PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663549);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663550);
				PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr, 100663551);
			}

			// Token: 0x06004DB7 RID: 19895 RVA: 0x0015EAD4 File Offset: 0x0015CCD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004DB8 RID: 19896 RVA: 0x0015EB10 File Offset: 0x0015CD10
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 260547, RefRangeEnd = 260548, XrefRangeStart = 260526, XrefRangeEnd = 260547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptedData(ASN1 asn1)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PKCS7.EncryptedData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asn1);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr__ctor_Public_Void_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170013CE RID: 5070
			// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x0015EB5C File Offset: 0x0015CD5C
			public unsafe PKCS7.ContentInfo EncryptionAlgorithm
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr3) : null;
				}
			}

			// Token: 0x170013CF RID: 5071
			// (get) Token: 0x06004DBA RID: 19898 RVA: 0x0015EB9C File Offset: 0x0015CD9C
			public unsafe Il2CppStructArray<byte> EncryptedContent
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 260551, RefRangeEnd = 260552, XrefRangeStart = 260548, XrefRangeEnd = 260551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PKCS7.EncryptedData.NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
				}
			}

			// Token: 0x06004DBB RID: 19899 RVA: 0x0001D6A5 File Offset: 0x0001B8A5
			public EncryptedData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013CA RID: 5066
			// (get) Token: 0x06004DBC RID: 19900 RVA: 0x0015EBDC File Offset: 0x0015CDDC
			// (set) Token: 0x06004DBD RID: 19901 RVA: 0x0001D6AE File Offset: 0x0001B8AE
			public unsafe byte _version
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__version)) = value;
				}
			}

			// Token: 0x170013CB RID: 5067
			// (get) Token: 0x06004DBE RID: 19902 RVA: 0x0015EC04 File Offset: 0x0015CE04
			// (set) Token: 0x06004DBF RID: 19903 RVA: 0x0001D6C9 File Offset: 0x0001B8C9
			public unsafe PKCS7.ContentInfo _content
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__content), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CC RID: 5068
			// (get) Token: 0x06004DC0 RID: 19904 RVA: 0x0015EC34 File Offset: 0x0015CE34
			// (set) Token: 0x06004DC1 RID: 19905 RVA: 0x0001D6E8 File Offset: 0x0001B8E8
			public unsafe PKCS7.ContentInfo _encryptionAlgorithm
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PKCS7.ContentInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encryptionAlgorithm), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013CD RID: 5069
			// (get) Token: 0x06004DC2 RID: 19906 RVA: 0x0015EC64 File Offset: 0x0015CE64
			// (set) Token: 0x06004DC3 RID: 19907 RVA: 0x0001D707 File Offset: 0x0001B907
			public unsafe Il2CppStructArray<byte> _encrypted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PKCS7.EncryptedData.NativeFieldInfoPtr__encrypted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003ECC RID: 16076
			private static readonly IntPtr NativeFieldInfoPtr__version;

			// Token: 0x04003ECD RID: 16077
			private static readonly IntPtr NativeFieldInfoPtr__content;

			// Token: 0x04003ECE RID: 16078
			private static readonly IntPtr NativeFieldInfoPtr__encryptionAlgorithm;

			// Token: 0x04003ECF RID: 16079
			private static readonly IntPtr NativeFieldInfoPtr__encrypted;

			// Token: 0x04003ED0 RID: 16080
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04003ED1 RID: 16081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ASN1_0;

			// Token: 0x04003ED2 RID: 16082
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptionAlgorithm_Public_get_ContentInfo_0;

			// Token: 0x04003ED3 RID: 16083
			private static readonly IntPtr NativeMethodInfoPtr_get_EncryptedContent_Public_get_Il2CppStructArray_1_Byte_0;
		}
	}
}
