using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000058 RID: 88
	public class FakeStore : JSONStore
	{
		// Token: 0x06000304 RID: 772 RVA: 0x0000FD14 File Offset: 0x0000DF14
		// Note: this type is marked as 'beforefieldinit'.
		static FakeStore()
		{
			Il2CppClassPointerStore<FakeStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "FakeStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeStore>.NativeClassPtr);
			FakeStore.NativeFieldInfoPtr_m_Biller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "m_Biller");
			FakeStore.NativeFieldInfoPtr_m_PurchasedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "m_PurchasedProducts");
			FakeStore.NativeFieldInfoPtr_purchaseCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "purchaseCalled");
			FakeStore.NativeFieldInfoPtr__unavailableProductId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "<unavailableProductId>k__BackingField");
			FakeStore.NativeFieldInfoPtr_UIMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "UIMode");
			FakeStore.NativeMethodInfoPtr_get_unavailableProductId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663671);
			FakeStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663672);
			FakeStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663673);
			FakeStore.NativeMethodInfoPtr_StoreRetrieveProducts_Public_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663674);
			FakeStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663675);
			FakeStore.NativeMethodInfoPtr_FakePurchase_Private_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663676);
			FakeStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663677);
			FakeStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663678);
			FakeStore.NativeMethodInfoPtr_StartUI_Protected_Virtual_New_Boolean_Object_DialogType_Action_2_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663679);
			FakeStore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663680);
			FakeStore.NativeMethodInfoPtr___n__0_Private_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, 100663681);
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000305 RID: 773 RVA: 0x0000FE84 File Offset: 0x0000E084
		public unsafe virtual string unavailableProductId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_get_unavailableProductId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000FEBC File Offset: 0x0000E0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154116, XrefRangeEnd = 154131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(IStoreCallback biller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(biller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FakeStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000FF0C File Offset: 0x0000E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154131, XrefRangeEnd = 154149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RetrieveProducts(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000FF50 File Offset: 0x0000E150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154231, RefRangeEnd = 154232, XrefRangeStart = 154149, XrefRangeEnd = 154231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StoreRetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefinitions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_StoreRetrieveProducts_Public_Void_ReadOnlyCollection_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000FF94 File Offset: 0x0000E194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154232, XrefRangeEnd = 154274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Purchase(string productJSON, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000FFE8 File Offset: 0x0000E1E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154310, RefRangeEnd = 154311, XrefRangeStart = 154274, XrefRangeEnd = 154310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FakePurchase(ProductDefinition product, string developerPayload)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(developerPayload);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_FakePurchase_Private_Void_ProductDefinition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x0001003C File Offset: 0x0000E23C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FinishTransaction(string productJSON, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productJSON);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00010090 File Offset: 0x0000E290
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FinishTransaction(ProductDefinition product, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FakeStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000100F0 File Offset: 0x0000E2F0
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool StartUI<T>(Object model, FakeStore.DialogType dialogType, Action<bool, T> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dialogType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FakeStore.MethodInfoStoreGeneric_StartUI_Protected_Virtual_New_Boolean_Object_DialogType_Action_2_Boolean_T_0<T>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00010168 File Offset: 0x0000E368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154311, XrefRangeEnd = 154318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FakeStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000101A4 File Offset: 0x0000E3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154318, XrefRangeEnd = 154319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0(string id, string receipt, string transactionID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.NativeMethodInfoPtr___n__0_Private_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003810 File Offset: 0x00001A10
		public FakeStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000311 RID: 785 RVA: 0x0001020C File Offset: 0x0000E40C
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00003819 File Offset: 0x00001A19
		public unsafe IStoreCallback m_Biller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_m_Biller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_m_Biller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000313 RID: 787 RVA: 0x0001023C File Offset: 0x0000E43C
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00003838 File Offset: 0x00001A38
		public unsafe List<string> m_PurchasedProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_m_PurchasedProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_m_PurchasedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0001026C File Offset: 0x0000E46C
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003857 File Offset: 0x00001A57
		public unsafe bool purchaseCalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_purchaseCalled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_purchaseCalled)) = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00010294 File Offset: 0x0000E494
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00003872 File Offset: 0x00001A72
		public unsafe string _unavailableProductId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr__unavailableProductId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr__unavailableProductId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000102BC File Offset: 0x0000E4BC
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00003891 File Offset: 0x00001A91
		public unsafe FakeStoreUIMode UIMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_UIMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.NativeFieldInfoPtr_UIMode)) = value;
			}
		}

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeFieldInfoPtr_m_Biller;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeFieldInfoPtr_m_PurchasedProducts;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeFieldInfoPtr_purchaseCalled;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeFieldInfoPtr__unavailableProductId_k__BackingField;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeFieldInfoPtr_UIMode;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_unavailableProductId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_StoreRetrieveProducts_Public_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_FakePurchase_Private_Void_ProductDefinition_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_StartUI_Protected_Virtual_New_Boolean_Object_DialogType_Action_2_Boolean_T_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Void_String_String_String_0;

		// Token: 0x020000B7 RID: 183
		public enum DialogType
		{
			// Token: 0x0400046A RID: 1130
			Purchase,
			// Token: 0x0400046B RID: 1131
			RetrieveProducts
		}

		// Token: 0x020000B8 RID: 184
		[ObfuscatedName("UnityEngine.Purchasing.FakeStore+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Object
		{
			// Token: 0x060006CA RID: 1738 RVA: 0x0001BD08 File Offset: 0x00019F08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr);
				FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr, "products");
				FakeStore.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr, 100663682);
				FakeStore.__c__DisplayClass13_0.NativeMethodInfoPtr__StoreRetrieveProducts_b__0_Internal_Void_Boolean_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr, 100663683);
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x0001BD84 File Offset: 0x00019F84
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeStore.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x0001BDC0 File Offset: 0x00019FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154085, XrefRangeEnd = 154092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StoreRetrieveProducts_b__0(bool allow, InitializationFailureReason failureReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allow;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failureReason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.__c__DisplayClass13_0.NativeMethodInfoPtr__StoreRetrieveProducts_b__0_Internal_Void_Boolean_InitializationFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x000056F5 File Offset: 0x000038F5
			public __c__DisplayClass13_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x060006CE RID: 1742 RVA: 0x0001BE0C File Offset: 0x0001A00C
			// (set) Token: 0x060006CF RID: 1743 RVA: 0x000056FE File Offset: 0x000038FE
			public unsafe FakeStore __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FakeStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B8 RID: 440
			// (get) Token: 0x060006D0 RID: 1744 RVA: 0x0001BE3C File Offset: 0x0001A03C
			// (set) Token: 0x060006D1 RID: 1745 RVA: 0x0000571D File Offset: 0x0000391D
			public unsafe List<ProductDescription> products
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr_products);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass13_0.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400046C RID: 1132
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400046D RID: 1133
			private static readonly IntPtr NativeFieldInfoPtr_products;

			// Token: 0x0400046E RID: 1134
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400046F RID: 1135
			private static readonly IntPtr NativeMethodInfoPtr__StoreRetrieveProducts_b__0_Internal_Void_Boolean_InitializationFailureReason_0;
		}

		// Token: 0x020000B9 RID: 185
		[ObfuscatedName("UnityEngine.Purchasing.FakeStore+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x060006D2 RID: 1746 RVA: 0x0001BE6C File Offset: 0x0001A06C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FakeStore>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr);
				FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr, "product");
				FakeStore.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr, 100663684);
				FakeStore.__c__DisplayClass15_0.NativeMethodInfoPtr__FakePurchase_b__0_Internal_Void_Boolean_PurchaseFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr, 100663685);
			}

			// Token: 0x060006D3 RID: 1747 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FakeStore.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D4 RID: 1748 RVA: 0x0001BF24 File Offset: 0x0001A124
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154092, XrefRangeEnd = 154116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FakePurchase_b__0(bool allow, PurchaseFailureReason failureReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref allow;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref failureReason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FakeStore.__c__DisplayClass15_0.NativeMethodInfoPtr__FakePurchase_b__0_Internal_Void_Boolean_PurchaseFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006D5 RID: 1749 RVA: 0x0000573C File Offset: 0x0000393C
			public __c__DisplayClass15_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001BF70 File Offset: 0x0001A170
			// (set) Token: 0x060006D7 RID: 1751 RVA: 0x00005745 File Offset: 0x00003945
			public unsafe FakeStore __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FakeStore>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x060006D8 RID: 1752 RVA: 0x0001BFA0 File Offset: 0x0001A1A0
			// (set) Token: 0x060006D9 RID: 1753 RVA: 0x00005764 File Offset: 0x00003964
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FakeStore.__c__DisplayClass15_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000470 RID: 1136
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000471 RID: 1137
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04000472 RID: 1138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000473 RID: 1139
			private static readonly IntPtr NativeMethodInfoPtr__FakePurchase_b__0_Internal_Void_Boolean_PurchaseFailureReason_0;
		}

		// Token: 0x020000BA RID: 186
		private sealed class MethodInfoStoreGeneric_StartUI_Protected_Virtual_New_Boolean_Object_DialogType_Action_2_Boolean_T_0<T>
		{
			// Token: 0x04000474 RID: 1140
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FakeStore.NativeMethodInfoPtr_StartUI_Protected_Virtual_New_Boolean_Object_DialogType_Action_2_Boolean_T_0, Il2CppClassPointerStore<FakeStore>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
