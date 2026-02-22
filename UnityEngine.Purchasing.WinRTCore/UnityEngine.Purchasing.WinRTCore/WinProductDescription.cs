using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Default
{
	// Token: 0x02000004 RID: 4
	public class WinProductDescription : Object
	{
		// Token: 0x0600000A RID: 10 RVA: 0x000023B0 File Offset: 0x000005B0
		// Note: this type is marked as 'beforefieldinit'.
		static WinProductDescription()
		{
			Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.WinRTCore.dll", "UnityEngine.Purchasing.Default", "WinProductDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr);
			WinProductDescription.NativeFieldInfoPtr__platformSpecificID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<platformSpecificID>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__price_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<price>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__title_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<title>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__description_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<description>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__ISOCurrencyCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<ISOCurrencyCode>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__priceDecimal_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<priceDecimal>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__receipt_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<receipt>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__transactionID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<transactionID>k__BackingField");
			WinProductDescription.NativeFieldInfoPtr__consumable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, "<consumable>k__BackingField");
			WinProductDescription.NativeMethodInfoPtr_set_platformSpecificID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663302);
			WinProductDescription.NativeMethodInfoPtr_set_price_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663303);
			WinProductDescription.NativeMethodInfoPtr_set_title_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663304);
			WinProductDescription.NativeMethodInfoPtr_set_description_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663305);
			WinProductDescription.NativeMethodInfoPtr_set_ISOCurrencyCode_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663306);
			WinProductDescription.NativeMethodInfoPtr_set_priceDecimal_Private_set_Void_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663307);
			WinProductDescription.NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663308);
			WinProductDescription.NativeMethodInfoPtr_set_transactionID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663309);
			WinProductDescription.NativeMethodInfoPtr_set_consumable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663310);
			WinProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Decimal_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr, 100663311);
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000255C File Offset: 0x0000075C
		public unsafe string platformSpecificID
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_platformSpecificID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe string price
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_price_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000025E4 File Offset: 0x000007E4
		public unsafe string title
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_title_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe string description
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_description_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000266C File Offset: 0x0000086C
		public unsafe string ISOCurrencyCode
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_ISOCurrencyCode_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000026B0 File Offset: 0x000008B0
		public unsafe Decimal priceDecimal
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_priceDecimal_Private_set_Void_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000026F0 File Offset: 0x000008F0
		public unsafe string receipt
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002734 File Offset: 0x00000934
		public unsafe string transactionID
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_transactionID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000012 RID: 18
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002778 File Offset: 0x00000978
		public unsafe bool consumable
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr_set_consumable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000027B8 File Offset: 0x000009B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 107992, RefRangeEnd = 107993, XrefRangeStart = 107991, XrefRangeEnd = 107992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WinProductDescription(string id, string price, string title, string description, string isoCode, Decimal priceD, string receipt = null, string transactionId = null, bool consumable = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinProductDescription>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(price);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(description);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(isoCode);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priceD;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref consumable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinProductDescription.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Decimal_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000207D File Offset: 0x0000027D
		public WinProductDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002890 File Offset: 0x00000A90
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002086 File Offset: 0x00000286
		public unsafe string _platformSpecificID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__platformSpecificID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__platformSpecificID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000018 RID: 24 RVA: 0x000028B8 File Offset: 0x00000AB8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe string _price_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__price_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__price_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000020C4 File Offset: 0x000002C4
		public unsafe string _title_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__title_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__title_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002908 File Offset: 0x00000B08
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020E3 File Offset: 0x000002E3
		public unsafe string _description_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__description_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__description_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002930 File Offset: 0x00000B30
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002102 File Offset: 0x00000302
		public unsafe string _ISOCurrencyCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__ISOCurrencyCode_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__ISOCurrencyCode_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002958 File Offset: 0x00000B58
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002121 File Offset: 0x00000321
		public unsafe Decimal _priceDecimal_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__priceDecimal_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__priceDecimal_k__BackingField)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002980 File Offset: 0x00000B80
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000213C File Offset: 0x0000033C
		public unsafe string _receipt_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__receipt_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__receipt_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000029A8 File Offset: 0x00000BA8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x0000215B File Offset: 0x0000035B
		public unsafe string _transactionID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__transactionID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__transactionID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x000029D0 File Offset: 0x00000BD0
		// (set) Token: 0x06000027 RID: 39 RVA: 0x0000217A File Offset: 0x0000037A
		public unsafe bool _consumable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__consumable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinProductDescription.NativeFieldInfoPtr__consumable_k__BackingField)) = value;
			}
		}

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr__platformSpecificID_k__BackingField;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr__price_k__BackingField;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr__title_k__BackingField;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__description_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr__ISOCurrencyCode_k__BackingField;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr__priceDecimal_k__BackingField;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr__receipt_k__BackingField;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr__transactionID_k__BackingField;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr__consumable_k__BackingField;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_set_platformSpecificID_Private_set_Void_String_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_set_price_Private_set_Void_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_set_title_Private_set_Void_String_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_set_description_Private_set_Void_String_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_set_ISOCurrencyCode_Private_set_Void_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_set_priceDecimal_Private_set_Void_Decimal_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_set_receipt_Private_set_Void_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_set_transactionID_Private_set_Void_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_set_consumable_Private_set_Void_Boolean_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_String_String_Decimal_String_String_Boolean_0;
	}
}
