using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Extension
{
	// Token: 0x02000027 RID: 39
	public class ProductDescription : Object
	{
		// Token: 0x06000151 RID: 337 RVA: 0x00007C0C File Offset: 0x00005E0C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDescription()
		{
			Il2CppClassPointerStore<ProductDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing.Extension", "ProductDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr);
			ProductDescription.NativeFieldInfoPtr__storeSpecificId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, "<storeSpecificId>k__BackingField");
			ProductDescription.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, "type");
			ProductDescription.NativeFieldInfoPtr__metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, "<metadata>k__BackingField");
			ProductDescription.NativeFieldInfoPtr__receipt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, "<receipt>k__BackingField");
			ProductDescription.NativeFieldInfoPtr__transactionId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, "<transactionId>k__BackingField");
			ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663473);
			ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663474);
			ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663475);
			ProductDescription.NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663476);
			ProductDescription.NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663477);
			ProductDescription.NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663478);
			ProductDescription.NativeMethodInfoPtr_set_metadata_Private_set_Void_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663479);
			ProductDescription.NativeMethodInfoPtr_get_receipt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663480);
			ProductDescription.NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663481);
			ProductDescription.NativeMethodInfoPtr_get_transactionId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663482);
			ProductDescription.NativeMethodInfoPtr_set_transactionId_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr, 100663483);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00007D7C File Offset: 0x00005F7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 131348, RefRangeEnd = 131352, XrefRangeStart = 131347, XrefRangeEnd = 131348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00007E00 File Offset: 0x00006000
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131353, RefRangeEnd = 131355, XrefRangeStart = 131352, XrefRangeEnd = 131353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDescription(string id, ProductMetadata metadata, string receipt, string transactionId, ProductType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007E90 File Offset: 0x00006090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 131356, RefRangeEnd = 131358, XrefRangeStart = 131355, XrefRangeEnd = 131356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDescription(string id, ProductMetadata metadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00007EF0 File Offset: 0x000060F0
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00007F28 File Offset: 0x00006128
		public unsafe string storeSpecificId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00007F6C File Offset: 0x0000616C
		// (set) Token: 0x06000158 RID: 344 RVA: 0x00007FAC File Offset: 0x000061AC
		public unsafe ProductMetadata metadata
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductMetadata>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_set_metadata_Private_set_Void_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00007FF0 File Offset: 0x000061F0
		// (set) Token: 0x0600015A RID: 346 RVA: 0x00008028 File Offset: 0x00006228
		public unsafe string receipt
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_get_receipt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600015B RID: 347 RVA: 0x0000806C File Offset: 0x0000626C
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000080A4 File Offset: 0x000062A4
		public unsafe string transactionId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_get_transactionId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDescription.NativeMethodInfoPtr_set_transactionId_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000290A File Offset: 0x00000B0A
		public ProductDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000080E8 File Offset: 0x000062E8
		// (set) Token: 0x0600015F RID: 351 RVA: 0x00002913 File Offset: 0x00000B13
		public unsafe string _storeSpecificId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__storeSpecificId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__storeSpecificId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00008110 File Offset: 0x00006310
		// (set) Token: 0x06000161 RID: 353 RVA: 0x00002932 File Offset: 0x00000B32
		public unsafe ProductType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00008138 File Offset: 0x00006338
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000294D File Offset: 0x00000B4D
		public unsafe ProductMetadata _metadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__metadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__metadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00008168 File Offset: 0x00006368
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000296C File Offset: 0x00000B6C
		public unsafe string _receipt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__receipt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__receipt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000298B File Offset: 0x00000B8B
		public unsafe string _transactionId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__transactionId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDescription.NativeFieldInfoPtr__transactionId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr__storeSpecificId_k__BackingField;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeFieldInfoPtr__metadata_k__BackingField;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeFieldInfoPtr__receipt_k__BackingField;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr__transactionId_k__BackingField;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_String_String_ProductType_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ProductMetadata_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0;

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeMethodInfoPtr_set_metadata_Private_set_Void_ProductMetadata_0;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_get_receipt_Public_get_String_0;

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeMethodInfoPtr_get_transactionId_Public_get_String_0;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeMethodInfoPtr_set_transactionId_Public_set_Void_String_0;
	}
}
