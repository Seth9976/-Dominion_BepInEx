using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing.Models
{
	// Token: 0x02000086 RID: 134
	public class GooglePurchase : Object
	{
		// Token: 0x06000554 RID: 1364 RVA: 0x000176F8 File Offset: 0x000158F8
		// Note: this type is marked as 'beforefieldinit'.
		static GooglePurchase()
		{
			Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing.Models", "GooglePurchase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr);
			GooglePurchase.NativeFieldInfoPtr_javaPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "javaPurchase");
			GooglePurchase.NativeFieldInfoPtr_purchaseState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "purchaseState");
			GooglePurchase.NativeFieldInfoPtr_sku = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "sku");
			GooglePurchase.NativeFieldInfoPtr_orderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "orderId");
			GooglePurchase.NativeFieldInfoPtr_receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "receipt");
			GooglePurchase.NativeFieldInfoPtr_signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "signature");
			GooglePurchase.NativeFieldInfoPtr_originalJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "originalJson");
			GooglePurchase.NativeFieldInfoPtr_purchaseToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, "purchaseToken");
			GooglePurchase.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, 100663953);
			GooglePurchase.NativeMethodInfoPtr_IsAcknowledged_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, 100663954);
			GooglePurchase.NativeMethodInfoPtr_IsPurchased_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr, 100663955);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00017804 File Offset: 0x00015A04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157243, RefRangeEnd = 157244, XrefRangeStart = 157178, XrefRangeEnd = 157243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GooglePurchase(AndroidJavaObject purchase, AndroidJavaObject skuDetails)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GooglePurchase>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(skuDetails);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GooglePurchase.NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00017864 File Offset: 0x00015A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157244, XrefRangeEnd = 157247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsAcknowledged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePurchase.NativeMethodInfoPtr_IsAcknowledged_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x000178AC File Offset: 0x00015AAC
		[CallerCount(0)]
		public unsafe virtual bool IsPurchased()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GooglePurchase.NativeMethodInfoPtr_IsPurchased_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00004B0B File Offset: 0x00002D0B
		public GooglePurchase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x000178F4 File Offset: 0x00015AF4
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00004B14 File Offset: 0x00002D14
		public unsafe AndroidJavaObject javaPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_javaPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_javaPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00017924 File Offset: 0x00015B24
		// (set) Token: 0x0600055C RID: 1372 RVA: 0x00004B33 File Offset: 0x00002D33
		public unsafe int purchaseState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_purchaseState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_purchaseState)) = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x0001794C File Offset: 0x00015B4C
		// (set) Token: 0x0600055E RID: 1374 RVA: 0x00004B4E File Offset: 0x00002D4E
		public unsafe string sku
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_sku);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_sku), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x00017974 File Offset: 0x00015B74
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x00004B6D File Offset: 0x00002D6D
		public unsafe string orderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_orderId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_orderId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001799C File Offset: 0x00015B9C
		// (set) Token: 0x06000562 RID: 1378 RVA: 0x00004B8C File Offset: 0x00002D8C
		public unsafe string receipt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_receipt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_receipt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x000179C4 File Offset: 0x00015BC4
		// (set) Token: 0x06000564 RID: 1380 RVA: 0x00004BAB File Offset: 0x00002DAB
		public unsafe string signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_signature);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_signature), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x000179EC File Offset: 0x00015BEC
		// (set) Token: 0x06000566 RID: 1382 RVA: 0x00004BCA File Offset: 0x00002DCA
		public unsafe string originalJson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_originalJson);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_originalJson), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00017A14 File Offset: 0x00015C14
		// (set) Token: 0x06000568 RID: 1384 RVA: 0x00004BE9 File Offset: 0x00002DE9
		public unsafe string purchaseToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_purchaseToken);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GooglePurchase.NativeFieldInfoPtr_purchaseToken), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_javaPurchase;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr_purchaseState;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr_sku;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_orderId;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_receipt;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeFieldInfoPtr_signature;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_originalJson;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeFieldInfoPtr_purchaseToken;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AndroidJavaObject_AndroidJavaObject_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_IsAcknowledged_Public_Virtual_New_Boolean_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_IsPurchased_Public_Virtual_New_Boolean_0;
	}
}
