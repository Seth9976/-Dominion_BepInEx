using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000D RID: 13
	public class Product : Object
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00003A00 File Offset: 0x00001C00
		// Note: this type is marked as 'beforefieldinit'.
		static Product()
		{
			Il2CppClassPointerStore<Product>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "Product");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product>.NativeClassPtr);
			Product.NativeFieldInfoPtr__definition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "<definition>k__BackingField");
			Product.NativeFieldInfoPtr__metadata_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "<metadata>k__BackingField");
			Product.NativeFieldInfoPtr__availableToPurchase_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "<availableToPurchase>k__BackingField");
			Product.NativeFieldInfoPtr__transactionID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "<transactionID>k__BackingField");
			Product.NativeFieldInfoPtr__receipt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product>.NativeClassPtr, "<receipt>k__BackingField");
			Product.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663326);
			Product.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663327);
			Product.NativeMethodInfoPtr_get_definition_Public_get_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663328);
			Product.NativeMethodInfoPtr_set_definition_Private_set_Void_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663329);
			Product.NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663330);
			Product.NativeMethodInfoPtr_set_metadata_Internal_set_Void_ProductMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663331);
			Product.NativeMethodInfoPtr_get_availableToPurchase_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663332);
			Product.NativeMethodInfoPtr_set_availableToPurchase_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663333);
			Product.NativeMethodInfoPtr_get_transactionID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663334);
			Product.NativeMethodInfoPtr_set_transactionID_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663335);
			Product.NativeMethodInfoPtr_get_hasReceipt_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663336);
			Product.NativeMethodInfoPtr_get_receipt_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663337);
			Product.NativeMethodInfoPtr_set_receipt_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663338);
			Product.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663339);
			Product.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product>.NativeClassPtr, 100663340);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003BC0 File Offset: 0x00001DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130609, RefRangeEnd = 130610, XrefRangeStart = 130608, XrefRangeEnd = 130609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product(ProductDefinition definition, ProductMetadata metadata, string receipt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003C30 File Offset: 0x00001E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130611, RefRangeEnd = 130612, XrefRangeStart = 130610, XrefRangeEnd = 130611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product(ProductDefinition definition, ProductMetadata metadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00003C90 File Offset: 0x00001E90
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00003CD0 File Offset: 0x00001ED0
		public unsafe ProductDefinition definition
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_definition_Public_get_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_set_definition_Private_set_Void_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00003D14 File Offset: 0x00001F14
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00003D54 File Offset: 0x00001F54
		public unsafe ProductMetadata metadata
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductMetadata>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_set_metadata_Internal_set_Void_ProductMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003D98 File Offset: 0x00001F98
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00003DD4 File Offset: 0x00001FD4
		public unsafe bool availableToPurchase
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_availableToPurchase_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_set_availableToPurchase_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003E14 File Offset: 0x00002014
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00003E4C File Offset: 0x0000204C
		public unsafe string transactionID
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_transactionID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_set_transactionID_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003E90 File Offset: 0x00002090
		public unsafe bool hasReceipt
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 130613, RefRangeEnd = 130615, XrefRangeStart = 130612, XrefRangeEnd = 130613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_hasReceipt_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003ECC File Offset: 0x000020CC
		// (set) Token: 0x0600004F RID: 79 RVA: 0x00003F04 File Offset: 0x00002104
		public unsafe string receipt
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_get_receipt_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product.NativeMethodInfoPtr_set_receipt_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00003F48 File Offset: 0x00002148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130615, XrefRangeEnd = 130617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003FA0 File Offset: 0x000021A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000021E6 File Offset: 0x000003E6
		public Product(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003FE8 File Offset: 0x000021E8
		// (set) Token: 0x06000054 RID: 84 RVA: 0x000021EF File Offset: 0x000003EF
		public unsafe ProductDefinition _definition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__definition_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__definition_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00004018 File Offset: 0x00002218
		// (set) Token: 0x06000056 RID: 86 RVA: 0x0000220E File Offset: 0x0000040E
		public unsafe ProductMetadata _metadata_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__metadata_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductMetadata>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__metadata_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004048 File Offset: 0x00002248
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000222D File Offset: 0x0000042D
		public unsafe bool _availableToPurchase_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__availableToPurchase_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__availableToPurchase_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00004070 File Offset: 0x00002270
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002248 File Offset: 0x00000448
		public unsafe string _transactionID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__transactionID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__transactionID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004098 File Offset: 0x00002298
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002267 File Offset: 0x00000467
		public unsafe string _receipt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__receipt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product.NativeFieldInfoPtr__receipt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr__definition_k__BackingField;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr__metadata_k__BackingField;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr__availableToPurchase_k__BackingField;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr__transactionID_k__BackingField;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeFieldInfoPtr__receipt_k__BackingField;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_String_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ProductDefinition_ProductMetadata_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_get_definition_Public_get_ProductDefinition_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_set_definition_Private_set_Void_ProductDefinition_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_get_metadata_Public_get_ProductMetadata_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_set_metadata_Internal_set_Void_ProductMetadata_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_get_availableToPurchase_Public_get_Boolean_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_set_availableToPurchase_Internal_set_Void_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_get_transactionID_Public_get_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_set_transactionID_Internal_set_Void_String_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_get_hasReceipt_Public_get_Boolean_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_get_receipt_Public_get_String_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_set_receipt_Internal_set_Void_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
