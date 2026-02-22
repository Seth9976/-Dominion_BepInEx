using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000051 RID: 81
	public class JSONStore : AbstractStore
	{
		// Token: 0x06000288 RID: 648 RVA: 0x0000E460 File Offset: 0x0000C660
		// Note: this type is marked as 'beforefieldinit'.
		static JSONStore()
		{
			Il2CppClassPointerStore<JSONStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "JSONStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JSONStore>.NativeClassPtr);
			JSONStore.NativeFieldInfoPtr_m_managedStore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_managedStore");
			JSONStore.NativeFieldInfoPtr_unity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "unity");
			JSONStore.NativeFieldInfoPtr_store = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "store");
			JSONStore.NativeFieldInfoPtr_isManagedStoreEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "isManagedStoreEnabled");
			JSONStore.NativeFieldInfoPtr_m_profileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_profileData");
			JSONStore.NativeFieldInfoPtr_m_Module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_Module");
			JSONStore.NativeFieldInfoPtr_m_BuilderProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_BuilderProducts");
			JSONStore.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_Logger");
			JSONStore.NativeFieldInfoPtr_m_EventQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_EventQueue");
			JSONStore.NativeFieldInfoPtr_promoPayload = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "promoPayload");
			JSONStore.NativeFieldInfoPtr_catalogDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "catalogDisabled");
			JSONStore.NativeFieldInfoPtr_eventsDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "eventsDisabled");
			JSONStore.NativeFieldInfoPtr_iapBaseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "iapBaseUrl");
			JSONStore.NativeFieldInfoPtr_eventBaseUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "eventBaseUrl");
			JSONStore.NativeFieldInfoPtr_lastPurchaseFailureDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "lastPurchaseFailureDescription");
			JSONStore.NativeFieldInfoPtr__lastPurchaseErrorCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "_lastPurchaseErrorCode");
			JSONStore.NativeFieldInfoPtr_m_persistentDataPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "m_persistentDataPath");
			JSONStore.NativeFieldInfoPtr_kStoreSpecificErrorCodeKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, "kStoreSpecificErrorCodeKey");
			JSONStore.NativeMethodInfoPtr_get_disableStoreCatalog_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663626);
			JSONStore.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663627);
			JSONStore.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663628);
			JSONStore.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663629);
			JSONStore.NativeMethodInfoPtr_UnityEngine_Purchasing_IStoreInternal_SetModule_Private_Virtual_Final_New_Void_StandardPurchasingModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663630);
			JSONStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663631);
			JSONStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663632);
			JSONStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663633);
			JSONStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663634);
			JSONStore.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663635);
			JSONStore.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663636);
			JSONStore.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663637);
			JSONStore.NativeMethodInfoPtr_SendPurchaseSucceededEvent_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663638);
			JSONStore.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663639);
			JSONStore.NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_PurchaseFailureDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663640);
			JSONStore.NativeMethodInfoPtr_SendPurchaseFailedEvent_Protected_Void_PurchaseFailureDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663641);
			JSONStore.NativeMethodInfoPtr_ParseStoreSpecificPurchaseErrorCode_Private_StoreSpecificPurchaseErrorCode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JSONStore>.NativeClassPtr, 100663642);
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000289 RID: 649 RVA: 0x0000E74C File Offset: 0x0000C94C
		public unsafe virtual bool disableStoreCatalog
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_get_disableStoreCatalog_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000E788 File Offset: 0x0000C988
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 153454, RefRangeEnd = 153462, XrefRangeStart = 153443, XrefRangeEnd = 153454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONStore()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONStore>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000E7C4 File Offset: 0x0000C9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153462, XrefRangeEnd = 153483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JSONStore(string persistentDataPath)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JSONStore>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(persistentDataPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0000E810 File Offset: 0x0000CA10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetNativeStore(INativeStore native)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(native);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000E854 File Offset: 0x0000CA54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153483, XrefRangeEnd = 153487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_Purchasing_IStoreInternal_SetModule(StandardPurchasingModule module)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(module);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_UnityEngine_Purchasing_IStoreInternal_SetModule_Private_Virtual_Final_New_Void_StandardPurchasingModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000E898 File Offset: 0x0000CA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153487, XrefRangeEnd = 153497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(IStoreCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000E8E8 File Offset: 0x0000CAE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153497, XrefRangeEnd = 153502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000E938 File Offset: 0x0000CB38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153502, XrefRangeEnd = 153555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Purchase(ProductDefinition product, string developerPayload)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0000E998 File Offset: 0x0000CB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153555, XrefRangeEnd = 153561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000E9F8 File Offset: 0x0000CBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153561, XrefRangeEnd = 153579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSetupFailed(string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(reason);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000EA3C File Offset: 0x0000CC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153579, XrefRangeEnd = 153585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProductsRetrieved(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000EA8C File Offset: 0x0000CC8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153590, RefRangeEnd = 153592, XrefRangeStart = 153585, XrefRangeEnd = 153590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseSucceeded(string id, string receipt, string transactionID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JSONStore.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_New_Void_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000EB00 File Offset: 0x0000CD00
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPurchaseSucceededEvent(string id, string receipt, string transactionID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_SendPurchaseSucceededEvent_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153592, XrefRangeEnd = 153594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseFailed(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000EBAC File Offset: 0x0000CDAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 153599, RefRangeEnd = 153602, XrefRangeStart = 153594, XrefRangeEnd = 153599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseFailed(PurchaseFailureDescription failure, string json = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(failure);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_PurchaseFailureDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000EC00 File Offset: 0x0000CE00
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPurchaseFailedEvent(PurchaseFailureDescription failure, string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(failure);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(json);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_SendPurchaseFailedEvent_Protected_Void_PurchaseFailureDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000EC54 File Offset: 0x0000CE54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153637, RefRangeEnd = 153638, XrefRangeStart = 153602, XrefRangeEnd = 153637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreSpecificPurchaseErrorCode ParseStoreSpecificPurchaseErrorCode(string json)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JSONStore.NativeMethodInfoPtr_ParseStoreSpecificPurchaseErrorCode_Private_StoreSpecificPurchaseErrorCode_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00003391 File Offset: 0x00001591
		public JSONStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600029B RID: 667 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		// (set) Token: 0x0600029C RID: 668 RVA: 0x0000339A File Offset: 0x0000159A
		public unsafe StoreCatalogImpl m_managedStore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_managedStore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreCatalogImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_managedStore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000033B9 File Offset: 0x000015B9
		public unsafe IStoreCallback unity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_unity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_unity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000ED04 File Offset: 0x0000CF04
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x000033D8 File Offset: 0x000015D8
		public unsafe INativeStore store
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_store);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_store), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000ED34 File Offset: 0x0000CF34
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x000033F7 File Offset: 0x000015F7
		public unsafe bool isManagedStoreEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_isManagedStoreEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_isManagedStoreEnabled)) = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0000ED5C File Offset: 0x0000CF5C
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00003412 File Offset: 0x00001612
		public unsafe ProfileData m_profileData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_profileData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_profileData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0000ED8C File Offset: 0x0000CF8C
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00003431 File Offset: 0x00001631
		public unsafe StandardPurchasingModule m_Module
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_Module);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StandardPurchasingModule>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_Module), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0000EDBC File Offset: 0x0000CFBC
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00003450 File Offset: 0x00001650
		public unsafe HashSet<ProductDefinition> m_BuilderProducts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_BuilderProducts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_BuilderProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0000EDEC File Offset: 0x0000CFEC
		// (set) Token: 0x060002AA RID: 682 RVA: 0x0000346F File Offset: 0x0000166F
		public unsafe ILogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002AB RID: 683 RVA: 0x0000EE1C File Offset: 0x0000D01C
		// (set) Token: 0x060002AC RID: 684 RVA: 0x0000348E File Offset: 0x0000168E
		public unsafe EventQueue m_EventQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_EventQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventQueue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_EventQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002AD RID: 685 RVA: 0x0000EE4C File Offset: 0x0000D04C
		// (set) Token: 0x060002AE RID: 686 RVA: 0x000034AD File Offset: 0x000016AD
		public unsafe Dictionary<string, Object> promoPayload
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_promoPayload);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_promoPayload), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0000EE7C File Offset: 0x0000D07C
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x000034CC File Offset: 0x000016CC
		public unsafe bool catalogDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_catalogDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_catalogDisabled)) = value;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0000EEA4 File Offset: 0x0000D0A4
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x000034E7 File Offset: 0x000016E7
		public unsafe bool eventsDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_eventsDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_eventsDisabled)) = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000EECC File Offset: 0x0000D0CC
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00003502 File Offset: 0x00001702
		public unsafe string iapBaseUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_iapBaseUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_iapBaseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00003521 File Offset: 0x00001721
		public unsafe string eventBaseUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_eventBaseUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_eventBaseUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000EF1C File Offset: 0x0000D11C
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00003540 File Offset: 0x00001740
		public unsafe PurchaseFailureDescription lastPurchaseFailureDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_lastPurchaseFailureDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseFailureDescription>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_lastPurchaseFailureDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000EF4C File Offset: 0x0000D14C
		// (set) Token: 0x060002BA RID: 698 RVA: 0x0000355F File Offset: 0x0000175F
		public unsafe StoreSpecificPurchaseErrorCode _lastPurchaseErrorCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr__lastPurchaseErrorCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr__lastPurchaseErrorCode)) = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000EF74 File Offset: 0x0000D174
		// (set) Token: 0x060002BC RID: 700 RVA: 0x0000357A File Offset: 0x0000177A
		public unsafe string m_persistentDataPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_persistentDataPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_m_persistentDataPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002BD RID: 701 RVA: 0x0000EF9C File Offset: 0x0000D19C
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00003599 File Offset: 0x00001799
		public unsafe string kStoreSpecificErrorCodeKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_kStoreSpecificErrorCodeKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JSONStore.NativeFieldInfoPtr_kStoreSpecificErrorCodeKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_m_managedStore;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_unity;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_store;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_isManagedStoreEnabled;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_profileData;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_Module;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_BuilderProducts;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_m_EventQueue;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_promoPayload;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_catalogDisabled;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_eventsDisabled;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_iapBaseUrl;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr_eventBaseUrl;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_lastPurchaseFailureDescription;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr__lastPurchaseErrorCode;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_m_persistentDataPath;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_kStoreSpecificErrorCodeKey;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_disableStoreCatalog_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeStore_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_Purchasing_IStoreInternal_SetModule_Private_Virtual_Final_New_Void_StandardPurchasingModule_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_New_Void_String_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_New_Void_String_String_String_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_SendPurchaseSucceededEvent_Protected_Void_String_String_String_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Void_PurchaseFailureDescription_String_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_SendPurchaseFailedEvent_Protected_Void_PurchaseFailureDescription_String_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_ParseStoreSpecificPurchaseErrorCode_Private_StoreSpecificPurchaseErrorCode_String_0;
	}
}
