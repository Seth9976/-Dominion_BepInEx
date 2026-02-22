using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000010 RID: 16
	public class ProductMetadata : Object
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00004BB0 File Offset: 0x00002DB0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductMetadata()
		{
			Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "ProductMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr);
			ProductMetadata.NativeFieldInfoPtr__localizedPriceString_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, "<localizedPriceString>k__BackingField");
			ProductMetadata.NativeFieldInfoPtr__localizedTitle_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, "<localizedTitle>k__BackingField");
			ProductMetadata.NativeFieldInfoPtr__localizedDescription_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, "<localizedDescription>k__BackingField");
			ProductMetadata.NativeFieldInfoPtr__isoCurrencyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, "<isoCurrencyCode>k__BackingField");
			ProductMetadata.NativeFieldInfoPtr__localizedPrice_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, "<localizedPrice>k__BackingField");
			ProductMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663367);
			ProductMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663368);
			ProductMetadata.NativeMethodInfoPtr_get_localizedPriceString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663369);
			ProductMetadata.NativeMethodInfoPtr_set_localizedPriceString_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663370);
			ProductMetadata.NativeMethodInfoPtr_get_localizedTitle_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663371);
			ProductMetadata.NativeMethodInfoPtr_set_localizedTitle_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663372);
			ProductMetadata.NativeMethodInfoPtr_get_localizedDescription_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663373);
			ProductMetadata.NativeMethodInfoPtr_set_localizedDescription_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663374);
			ProductMetadata.NativeMethodInfoPtr_get_isoCurrencyCode_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663375);
			ProductMetadata.NativeMethodInfoPtr_set_isoCurrencyCode_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663376);
			ProductMetadata.NativeMethodInfoPtr_get_localizedPrice_Public_get_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663377);
			ProductMetadata.NativeMethodInfoPtr_set_localizedPrice_Internal_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr, 100663378);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004D34 File Offset: 0x00002F34
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130739, RefRangeEnd = 130745, XrefRangeStart = 130738, XrefRangeEnd = 130739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductMetadata(string priceString, string title, string description, string currencyCode, Decimal localizedPrice)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(priceString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currencyCode);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref localizedPrice;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004DC4 File Offset: 0x00002FC4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004E00 File Offset: 0x00003000
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00004E38 File Offset: 0x00003038
		public unsafe string localizedPriceString
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_get_localizedPriceString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_set_localizedPriceString_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004E7C File Offset: 0x0000307C
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00004EB4 File Offset: 0x000030B4
		public unsafe string localizedTitle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_get_localizedTitle_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_set_localizedTitle_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00004EF8 File Offset: 0x000030F8
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00004F30 File Offset: 0x00003130
		public unsafe string localizedDescription
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_get_localizedDescription_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_set_localizedDescription_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00004F74 File Offset: 0x00003174
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00004FAC File Offset: 0x000031AC
		public unsafe string isoCurrencyCode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_get_isoCurrencyCode_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_set_isoCurrencyCode_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00004FF0 File Offset: 0x000031F0
		// (set) Token: 0x06000095 RID: 149 RVA: 0x0000502C File Offset: 0x0000322C
		public unsafe Decimal localizedPrice
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_get_localizedPrice_Public_get_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductMetadata.NativeMethodInfoPtr_set_localizedPrice_Internal_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000023A7 File Offset: 0x000005A7
		public ProductMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000506C File Offset: 0x0000326C
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000023B0 File Offset: 0x000005B0
		public unsafe string _localizedPriceString_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedPriceString_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedPriceString_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00005094 File Offset: 0x00003294
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000023CF File Offset: 0x000005CF
		public unsafe string _localizedTitle_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedTitle_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedTitle_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000050BC File Offset: 0x000032BC
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000023EE File Offset: 0x000005EE
		public unsafe string _localizedDescription_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedDescription_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedDescription_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009D RID: 157 RVA: 0x000050E4 File Offset: 0x000032E4
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000240D File Offset: 0x0000060D
		public unsafe string _isoCurrencyCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__isoCurrencyCode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__isoCurrencyCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000510C File Offset: 0x0000330C
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x0000242C File Offset: 0x0000062C
		public unsafe Decimal _localizedPrice_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedPrice_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductMetadata.NativeFieldInfoPtr__localizedPrice_k__BackingField)) = value;
			}
		}

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeFieldInfoPtr__localizedPriceString_k__BackingField;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeFieldInfoPtr__localizedTitle_k__BackingField;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeFieldInfoPtr__localizedDescription_k__BackingField;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeFieldInfoPtr__isoCurrencyCode_k__BackingField;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeFieldInfoPtr__localizedPrice_k__BackingField;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_Decimal_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_get_localizedPriceString_Public_get_String_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_set_localizedPriceString_Internal_set_Void_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_localizedTitle_Public_get_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_set_localizedTitle_Internal_set_Void_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_get_localizedDescription_Public_get_String_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_set_localizedDescription_Internal_set_Void_String_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_get_isoCurrencyCode_Public_get_String_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_set_isoCurrencyCode_Internal_set_Void_String_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_localizedPrice_Public_get_Decimal_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_set_localizedPrice_Internal_set_Void_Decimal_0;
	}
}
