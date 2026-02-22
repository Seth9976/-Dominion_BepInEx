using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Security
{
	// Token: 0x02000003 RID: 3
	public class AppleInAppPurchaseReceipt : Object
	{
		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		// Note: this type is marked as 'beforefieldinit'.
		static AppleInAppPurchaseReceipt()
		{
			Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.SecurityCore.dll", "UnityEngine.Purchasing.Security", "AppleInAppPurchaseReceipt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr);
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<productID>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__transactionID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<transactionID>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__purchaseDate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<purchaseDate>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__subscriptionExpirationDate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<subscriptionExpirationDate>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__cancellationDate_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<cancellationDate>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isFreeTrial_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<isFreeTrial>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<productType>k__BackingField");
			AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isIntroductoryPricePeriod_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, "<isIntroductoryPricePeriod>k__BackingField");
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_productID_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663297);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_transactionID_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663298);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_purchaseDate_Public_Virtual_Final_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663299);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_subscriptionExpirationDate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663300);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_cancellationDate_Public_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663301);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_isFreeTrial_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663302);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_productType_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663303);
			AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_isIntroductoryPricePeriod_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AppleInAppPurchaseReceipt>.NativeClassPtr, 100663304);
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000233C File Offset: 0x0000053C
		public unsafe virtual string productID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_productID_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002374 File Offset: 0x00000574
		public unsafe virtual string transactionID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_transactionID_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000023AC File Offset: 0x000005AC
		public unsafe virtual DateTime purchaseDate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_purchaseDate_Public_Virtual_Final_New_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000009 RID: 9 RVA: 0x000023E8 File Offset: 0x000005E8
		public unsafe DateTime subscriptionExpirationDate
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_subscriptionExpirationDate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002424 File Offset: 0x00000624
		public unsafe DateTime cancellationDate
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_cancellationDate_Public_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002460 File Offset: 0x00000660
		public unsafe int isFreeTrial
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_isFreeTrial_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000249C File Offset: 0x0000069C
		public unsafe int productType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_productType_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000024D8 File Offset: 0x000006D8
		public unsafe int isIntroductoryPricePeriod
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AppleInAppPurchaseReceipt.NativeMethodInfoPtr_get_isIntroductoryPricePeriod_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020B1 File Offset: 0x000002B1
		public AppleInAppPurchaseReceipt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002514 File Offset: 0x00000714
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020BA File Offset: 0x000002BA
		public unsafe string _productID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000253C File Offset: 0x0000073C
		// (set) Token: 0x06000012 RID: 18 RVA: 0x000020D9 File Offset: 0x000002D9
		public unsafe string _transactionID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__transactionID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__transactionID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002564 File Offset: 0x00000764
		// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F8 File Offset: 0x000002F8
		public unsafe DateTime _purchaseDate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__purchaseDate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__purchaseDate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x0000258C File Offset: 0x0000078C
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002113 File Offset: 0x00000313
		public unsafe DateTime _subscriptionExpirationDate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__subscriptionExpirationDate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__subscriptionExpirationDate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000025B4 File Offset: 0x000007B4
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000212E File Offset: 0x0000032E
		public unsafe DateTime _cancellationDate_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__cancellationDate_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__cancellationDate_k__BackingField)) = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000025DC File Offset: 0x000007DC
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002149 File Offset: 0x00000349
		public unsafe int _isFreeTrial_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isFreeTrial_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isFreeTrial_k__BackingField)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x00002604 File Offset: 0x00000804
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002164 File Offset: 0x00000364
		public unsafe int _productType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__productType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001D RID: 29 RVA: 0x0000262C File Offset: 0x0000082C
		// (set) Token: 0x0600001E RID: 30 RVA: 0x0000217F File Offset: 0x0000037F
		public unsafe int _isIntroductoryPricePeriod_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isIntroductoryPricePeriod_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AppleInAppPurchaseReceipt.NativeFieldInfoPtr__isIntroductoryPricePeriod_k__BackingField)) = value;
			}
		}

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr__productID_k__BackingField;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr__transactionID_k__BackingField;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr__purchaseDate_k__BackingField;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr__subscriptionExpirationDate_k__BackingField;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr__cancellationDate_k__BackingField;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeFieldInfoPtr__isFreeTrial_k__BackingField;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr__productType_k__BackingField;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr__isIntroductoryPricePeriod_k__BackingField;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_productID_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_transactionID_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_purchaseDate_Public_Virtual_Final_New_get_DateTime_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_subscriptionExpirationDate_Public_get_DateTime_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_cancellationDate_Public_get_DateTime_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_get_isFreeTrial_Public_get_Int32_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_get_productType_Public_get_Int32_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_get_isIntroductoryPricePeriod_Public_get_Int32_0;
	}
}
