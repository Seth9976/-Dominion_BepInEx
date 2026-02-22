using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000F RID: 15
	public class ProductDefinition : Object
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00004428 File Offset: 0x00002628
		// Note: this type is marked as 'beforefieldinit'.
		static ProductDefinition()
		{
			Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "ProductDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr);
			ProductDefinition.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<id>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__storeSpecificId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<storeSpecificId>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<type>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr__enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "<enabled>k__BackingField");
			ProductDefinition.NativeFieldInfoPtr_m_Payouts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, "m_Payouts");
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663351);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663352);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_IEnumerable_1_PayoutDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663353);
			ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663354);
			ProductDefinition.NativeMethodInfoPtr_get_id_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663355);
			ProductDefinition.NativeMethodInfoPtr_set_id_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663356);
			ProductDefinition.NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663357);
			ProductDefinition.NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663358);
			ProductDefinition.NativeMethodInfoPtr_get_type_Public_get_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663359);
			ProductDefinition.NativeMethodInfoPtr_set_type_Private_set_Void_ProductType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663360);
			ProductDefinition.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663361);
			ProductDefinition.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663362);
			ProductDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663363);
			ProductDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663364);
			ProductDefinition.NativeMethodInfoPtr_get_payouts_Public_get_IEnumerable_1_PayoutDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663365);
			ProductDefinition.NativeMethodInfoPtr_SetPayouts_Internal_Void_IEnumerable_1_PayoutDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr, 100663366);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000045FC File Offset: 0x000027FC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 130698, RefRangeEnd = 130706, XrefRangeStart = 130689, XrefRangeEnd = 130698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition(string id, string storeSpecificId, ProductType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeSpecificId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00004668 File Offset: 0x00002868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130706, XrefRangeEnd = 130715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeSpecificId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000046E4 File Offset: 0x000028E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130715, XrefRangeEnd = 130728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition(string id, string storeSpecificId, ProductType type, bool enabled, IEnumerable<PayoutDefinition> payouts)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeSpecificId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(payouts);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_IEnumerable_1_PayoutDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00004770 File Offset: 0x00002970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130728, XrefRangeEnd = 130729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition(string id, ProductType type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductDefinition>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000047CC File Offset: 0x000029CC
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00004804 File Offset: 0x00002A04
		public unsafe string id
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_id_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_id_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00004848 File Offset: 0x00002A48
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00004880 File Offset: 0x00002A80
		public unsafe string storeSpecificId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000048C4 File Offset: 0x00002AC4
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00004900 File Offset: 0x00002B00
		public unsafe ProductType type
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_type_Public_get_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_type_Private_set_Void_ProductType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00004940 File Offset: 0x00002B40
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000497C File Offset: 0x00002B7C
		public unsafe bool enabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000049BC File Offset: 0x00002BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130729, XrefRangeEnd = 130732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00004A14 File Offset: 0x00002C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductDefinition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00004A5C File Offset: 0x00002C5C
		public unsafe IEnumerable<PayoutDefinition> payouts
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_get_payouts_Public_get_IEnumerable_1_PayoutDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<PayoutDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004A9C File Offset: 0x00002C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130732, XrefRangeEnd = 130738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPayouts(IEnumerable<PayoutDefinition> newPayouts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPayouts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductDefinition.NativeMethodInfoPtr_SetPayouts_Internal_Void_IEnumerable_1_PayoutDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000230B File Offset: 0x0000050B
		public ProductDefinition(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004AE0 File Offset: 0x00002CE0
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00002314 File Offset: 0x00000514
		public unsafe string _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__id_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__id_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004B08 File Offset: 0x00002D08
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00002333 File Offset: 0x00000533
		public unsafe string _storeSpecificId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__storeSpecificId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__storeSpecificId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004B30 File Offset: 0x00002D30
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00002352 File Offset: 0x00000552
		public unsafe ProductType _type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__type_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__type_k__BackingField)) = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004B58 File Offset: 0x00002D58
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000236D File Offset: 0x0000056D
		public unsafe bool _enabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__enabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr__enabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004B80 File Offset: 0x00002D80
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00002388 File Offset: 0x00000588
		public unsafe List<PayoutDefinition> m_Payouts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_m_Payouts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PayoutDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductDefinition.NativeFieldInfoPtr_m_Payouts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr__storeSpecificId_k__BackingField;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__type_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__enabled_k__BackingField;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_Payouts;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_ProductType_Boolean_IEnumerable_1_PayoutDefinition_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ProductType_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_get_String_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Private_set_Void_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_get_storeSpecificId_Public_get_String_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_set_storeSpecificId_Private_set_Void_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get_ProductType_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Private_set_Void_ProductType_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_get_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_set_enabled_Private_set_Void_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_payouts_Public_get_IEnumerable_1_PayoutDefinition_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_SetPayouts_Internal_Void_IEnumerable_1_PayoutDefinition_0;
	}
}
