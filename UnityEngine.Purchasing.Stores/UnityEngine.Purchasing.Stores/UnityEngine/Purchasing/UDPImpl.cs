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
	// Token: 0x02000042 RID: 66
	public class UDPImpl : JSONStore
	{
		// Token: 0x0600020B RID: 523 RVA: 0x0000CB10 File Offset: 0x0000AD10
		// Note: this type is marked as 'beforefieldinit'.
		static UDPImpl()
		{
			Il2CppClassPointerStore<UDPImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "UDPImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr);
			UDPImpl.NativeFieldInfoPtr_m_Bindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "m_Bindings");
			UDPImpl.NativeFieldInfoPtr_m_UserInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "m_UserInfo");
			UDPImpl.NativeFieldInfoPtr_m_LastInitError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "m_LastInitError");
			UDPImpl.NativeFieldInfoPtr_m_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "m_Initialized");
			UDPImpl.NativeFieldInfoPtr_m_DeferredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "m_DeferredCallback");
			UDPImpl.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeUDPStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663555);
			UDPImpl.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663556);
			UDPImpl.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663557);
			UDPImpl.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663558);
			UDPImpl.NativeMethodInfoPtr_OnPurchaseDeferred_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663559);
			UDPImpl.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663560);
			UDPImpl.NativeMethodInfoPtr_DictionaryToStringProperty_Private_Static_Void_Dictionary_2_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663561);
			UDPImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, 100663562);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000CC44 File Offset: 0x0000AE44
		[CallerCount(0)]
		public unsafe void SetNativeStore(INativeUDPStore nativeUdpStore)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nativeUdpStore);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeUDPStore_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000CC88 File Offset: 0x0000AE88
		[CallerCount(0)]
		public unsafe override void Initialize(IStoreCallback callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UDPImpl.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152761, XrefRangeEnd = 152777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UDPImpl.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000CD28 File Offset: 0x0000AF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152777, XrefRangeEnd = 152792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UDPImpl.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000CD88 File Offset: 0x0000AF88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 152802, RefRangeEnd = 152803, XrefRangeStart = 152792, XrefRangeEnd = 152802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPurchaseDeferred(string productId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(productId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.NativeMethodInfoPtr_OnPurchaseDeferred_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000CDCC File Offset: 0x0000AFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152803, XrefRangeEnd = 152806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UDPImpl.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000CE2C File Offset: 0x0000B02C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152806, XrefRangeEnd = 152820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DictionaryToStringProperty(Dictionary<string, Object> dic, Object info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dic);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(info);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.NativeMethodInfoPtr_DictionaryToStringProperty_Private_Static_Void_Dictionary_2_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000CE74 File Offset: 0x0000B074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152820, XrefRangeEnd = 152821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UDPImpl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000303D File Offset: 0x0000123D
		public UDPImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000215 RID: 533 RVA: 0x0000CEB0 File Offset: 0x0000B0B0
		// (set) Token: 0x06000216 RID: 534 RVA: 0x00003046 File Offset: 0x00001246
		public unsafe INativeUDPStore m_Bindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_Bindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<INativeUDPStore>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_Bindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000217 RID: 535 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
		// (set) Token: 0x06000218 RID: 536 RVA: 0x00003065 File Offset: 0x00001265
		public unsafe Object m_UserInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_UserInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_UserInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000219 RID: 537 RVA: 0x0000CF10 File Offset: 0x0000B110
		// (set) Token: 0x0600021A RID: 538 RVA: 0x00003084 File Offset: 0x00001284
		public unsafe string m_LastInitError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_LastInitError);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_LastInitError), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600021B RID: 539 RVA: 0x0000CF38 File Offset: 0x0000B138
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000030A3 File Offset: 0x000012A3
		public unsafe bool m_Initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_Initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_Initialized)) = value;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000CF60 File Offset: 0x0000B160
		// (set) Token: 0x0600021E RID: 542 RVA: 0x000030BE File Offset: 0x000012BE
		public unsafe Action<Product> m_DeferredCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_DeferredCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Product>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.NativeFieldInfoPtr_m_DeferredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeFieldInfoPtr_m_Bindings;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeFieldInfoPtr_m_UserInfo;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeFieldInfoPtr_m_LastInitError;

		// Token: 0x04000139 RID: 313
		private static readonly IntPtr NativeFieldInfoPtr_m_Initialized;

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeFieldInfoPtr_m_DeferredCallback;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_SetNativeStore_Public_Void_INativeUDPStore_0;

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseDeferred_Private_Void_String_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_DictionaryToStringProperty_Private_Static_Void_Dictionary_2_String_Object_Object_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000AE RID: 174
		[ObfuscatedName("UnityEngine.Purchasing.UDPImpl+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x06000675 RID: 1653 RVA: 0x0001ADDC File Offset: 0x00018FDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr);
				UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, "products");
				UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_retrieveCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, "retrieveCallback");
				UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663563);
				UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__RetrieveProducts_b__0_Internal_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663564);
				UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__RetrieveProducts_b__1_Internal_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663565);
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x0001AE80 File Offset: 0x00019080
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000677 RID: 1655 RVA: 0x0001AEBC File Offset: 0x000190BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152706, XrefRangeEnd = 152717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RetrieveProducts_b__0(bool success, string json)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__RetrieveProducts_b__0_Internal_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000678 RID: 1656 RVA: 0x0001AF0C File Offset: 0x0001910C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152717, XrefRangeEnd = 152726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RetrieveProducts_b__1(bool success, string message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__RetrieveProducts_b__1_Internal_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000679 RID: 1657 RVA: 0x0000544C File Offset: 0x0000364C
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001AF5C File Offset: 0x0001915C
			// (set) Token: 0x0600067B RID: 1659 RVA: 0x00005455 File Offset: 0x00003655
			public unsafe UDPImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UDPImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001AF8C File Offset: 0x0001918C
			// (set) Token: 0x0600067D RID: 1661 RVA: 0x00005474 File Offset: 0x00003674
			public unsafe ReadOnlyCollection<ProductDefinition> products
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_products);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x0600067E RID: 1662 RVA: 0x0001AFBC File Offset: 0x000191BC
			// (set) Token: 0x0600067F RID: 1663 RVA: 0x00005493 File Offset: 0x00003693
			public unsafe Action<bool, string> retrieveCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_retrieveCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool, string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_retrieveCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400043C RID: 1084
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400043D RID: 1085
			private static readonly IntPtr NativeFieldInfoPtr_products;

			// Token: 0x0400043E RID: 1086
			private static readonly IntPtr NativeFieldInfoPtr_retrieveCallback;

			// Token: 0x0400043F RID: 1087
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000440 RID: 1088
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__0_Internal_Void_Boolean_String_0;

			// Token: 0x04000441 RID: 1089
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__1_Internal_Void_Boolean_String_0;
		}

		// Token: 0x020000AF RID: 175
		[ObfuscatedName("UnityEngine.Purchasing.UDPImpl+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Object
		{
			// Token: 0x06000680 RID: 1664 RVA: 0x0001AFEC File Offset: 0x000191EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UDPImpl>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr);
				UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr, "product");
				UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				UDPImpl.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr, 100663566);
				UDPImpl.__c__DisplayClass11_0.NativeMethodInfoPtr__Purchase_b__0_Internal_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr, 100663567);
			}

			// Token: 0x06000681 RID: 1665 RVA: 0x0001B068 File Offset: 0x00019268
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UDPImpl.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000682 RID: 1666 RVA: 0x0001B0A4 File Offset: 0x000192A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152726, XrefRangeEnd = 152761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Purchase_b__0(bool success, string message)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref success;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UDPImpl.__c__DisplayClass11_0.NativeMethodInfoPtr__Purchase_b__0_Internal_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000683 RID: 1667 RVA: 0x000054B2 File Offset: 0x000036B2
			public __c__DisplayClass11_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x06000684 RID: 1668 RVA: 0x0001B0F4 File Offset: 0x000192F4
			// (set) Token: 0x06000685 RID: 1669 RVA: 0x000054BB File Offset: 0x000036BB
			public unsafe ProductDefinition product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr_product);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06000686 RID: 1670 RVA: 0x0001B124 File Offset: 0x00019324
			// (set) Token: 0x06000687 RID: 1671 RVA: 0x000054DA File Offset: 0x000036DA
			public unsafe UDPImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UDPImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UDPImpl.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000442 RID: 1090
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04000443 RID: 1091
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000444 RID: 1092
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000445 RID: 1093
			private static readonly IntPtr NativeMethodInfoPtr__Purchase_b__0_Internal_Void_Boolean_String_0;
		}
	}
}
