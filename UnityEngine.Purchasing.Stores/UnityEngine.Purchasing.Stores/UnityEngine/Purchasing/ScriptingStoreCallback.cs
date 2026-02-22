using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200003B RID: 59
	public class ScriptingStoreCallback : Object
	{
		// Token: 0x060001D9 RID: 473 RVA: 0x0000BF98 File Offset: 0x0000A198
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingStoreCallback()
		{
			Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "ScriptingStoreCallback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr);
			ScriptingStoreCallback.NativeFieldInfoPtr_m_ForwardTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "m_ForwardTo");
			ScriptingStoreCallback.NativeFieldInfoPtr_m_Util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "m_Util");
			ScriptingStoreCallback.NativeMethodInfoPtr__ctor_Public_Void_IStoreCallback_IUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663521);
			ScriptingStoreCallback.NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663522);
			ScriptingStoreCallback.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663523);
			ScriptingStoreCallback.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663524);
			ScriptingStoreCallback.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663525);
			ScriptingStoreCallback.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663526);
			ScriptingStoreCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, 100663527);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000C07C File Offset: 0x0000A27C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 5356, RefRangeEnd = 5400, XrefRangeStart = 5356, XrefRangeEnd = 5400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptingStoreCallback(IStoreCallback forwardTo, IUtil util)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(forwardTo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr__ctor_Public_Void_IStoreCallback_IUtil_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		public unsafe virtual ProductCollection products
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152286, XrefRangeEnd = 152290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductCollection>(intPtr3) : null;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000C11C File Offset: 0x0000A31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152290, XrefRangeEnd = 152304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnSetupFailed(InitializationFailureReason reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref reason;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000C15C File Offset: 0x0000A35C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152304, XrefRangeEnd = 152318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnProductsRetrieved(List<ProductDescription> products)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(products);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152318, XrefRangeEnd = 152332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000C208 File Offset: 0x0000A408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152332, XrefRangeEnd = 152346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAllPurchasesRetrieved(List<Product> purchasedProducts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchasedProducts);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000C24C File Offset: 0x0000A44C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152346, XrefRangeEnd = 152360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnPurchaseFailed(PurchaseFailureDescription desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002EB7 File Offset: 0x000010B7
		public ScriptingStoreCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000C290 File Offset: 0x0000A490
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00002EC0 File Offset: 0x000010C0
		public unsafe IStoreCallback m_ForwardTo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.NativeFieldInfoPtr_m_ForwardTo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.NativeFieldInfoPtr_m_ForwardTo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000C2C0 File Offset: 0x0000A4C0
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00002EDF File Offset: 0x000010DF
		public unsafe IUtil m_Util
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.NativeFieldInfoPtr_m_Util);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.NativeFieldInfoPtr_m_Util), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_ForwardTo;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_m_Util;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IStoreCallback_IUtil_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_get_products_Public_Virtual_Final_New_get_ProductCollection_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_OnSetupFailed_Public_Virtual_Final_New_Void_InitializationFailureReason_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_OnProductsRetrieved_Public_Virtual_Final_New_Void_List_1_ProductDescription_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseSucceeded_Public_Virtual_Final_New_Void_String_String_String_0;

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr_OnAllPurchasesRetrieved_Public_Virtual_Final_New_Void_List_1_Product_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_OnPurchaseFailed_Public_Virtual_Final_New_Void_PurchaseFailureDescription_0;

		// Token: 0x020000A9 RID: 169
		[ObfuscatedName("UnityEngine.Purchasing.ScriptingStoreCallback+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x06000649 RID: 1609 RVA: 0x0001A6F8 File Offset: 0x000188F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr);
				ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr_reason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr, "reason");
				ScriptingStoreCallback.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr, 100663528);
				ScriptingStoreCallback.__c__DisplayClass5_0.NativeMethodInfoPtr__OnSetupFailed_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr, 100663529);
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x0001A774 File Offset: 0x00018974
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x0001A7B0 File Offset: 0x000189B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152261, XrefRangeEnd = 152265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnSetupFailed_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass5_0.NativeMethodInfoPtr__OnSetupFailed_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x000052AF File Offset: 0x000034AF
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000195 RID: 405
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001A7E4 File Offset: 0x000189E4
			// (set) Token: 0x0600064E RID: 1614 RVA: 0x000052B8 File Offset: 0x000034B8
			public unsafe ScriptingStoreCallback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptingStoreCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000196 RID: 406
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001A814 File Offset: 0x00018A14
			// (set) Token: 0x06000650 RID: 1616 RVA: 0x000052D7 File Offset: 0x000034D7
			public unsafe InitializationFailureReason reason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr_reason);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass5_0.NativeFieldInfoPtr_reason)) = value;
				}
			}

			// Token: 0x04000426 RID: 1062
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000427 RID: 1063
			private static readonly IntPtr NativeFieldInfoPtr_reason;

			// Token: 0x04000428 RID: 1064
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000429 RID: 1065
			private static readonly IntPtr NativeMethodInfoPtr__OnSetupFailed_b__0_Internal_Void_0;
		}

		// Token: 0x020000AA RID: 170
		[ObfuscatedName("UnityEngine.Purchasing.ScriptingStoreCallback+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06000651 RID: 1617 RVA: 0x0001A83C File Offset: 0x00018A3C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr);
				ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr, "products");
				ScriptingStoreCallback.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr, 100663530);
				ScriptingStoreCallback.__c__DisplayClass6_0.NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr, 100663531);
			}

			// Token: 0x06000652 RID: 1618 RVA: 0x0001A8B8 File Offset: 0x00018AB8
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000653 RID: 1619 RVA: 0x0001A8F4 File Offset: 0x00018AF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152265, XrefRangeEnd = 152269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnProductsRetrieved_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass6_0.NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x000052F2 File Offset: 0x000034F2
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001A928 File Offset: 0x00018B28
			// (set) Token: 0x06000656 RID: 1622 RVA: 0x000052FB File Offset: 0x000034FB
			public unsafe ScriptingStoreCallback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptingStoreCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001A958 File Offset: 0x00018B58
			// (set) Token: 0x06000658 RID: 1624 RVA: 0x0000531A File Offset: 0x0000351A
			public unsafe List<ProductDescription> products
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr_products);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductDescription>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass6_0.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400042A RID: 1066
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400042B RID: 1067
			private static readonly IntPtr NativeFieldInfoPtr_products;

			// Token: 0x0400042C RID: 1068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400042D RID: 1069
			private static readonly IntPtr NativeMethodInfoPtr__OnProductsRetrieved_b__0_Internal_Void_0;
		}

		// Token: 0x020000AB RID: 171
		[ObfuscatedName("UnityEngine.Purchasing.ScriptingStoreCallback+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x06000659 RID: 1625 RVA: 0x0001A988 File Offset: 0x00018B88
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr);
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, "id");
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_receipt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, "receipt");
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_transactionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, "transactionID");
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, 100663532);
				ScriptingStoreCallback.__c__DisplayClass7_0.NativeMethodInfoPtr__OnPurchaseSucceeded_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr, 100663533);
			}

			// Token: 0x0600065A RID: 1626 RVA: 0x0001AA2C File Offset: 0x00018C2C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600065B RID: 1627 RVA: 0x0001AA68 File Offset: 0x00018C68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152269, XrefRangeEnd = 152272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPurchaseSucceeded_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass7_0.NativeMethodInfoPtr__OnPurchaseSucceeded_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600065C RID: 1628 RVA: 0x00005339 File Offset: 0x00003539
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001AA9C File Offset: 0x00018C9C
			// (set) Token: 0x0600065E RID: 1630 RVA: 0x00005342 File Offset: 0x00003542
			public unsafe ScriptingStoreCallback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptingStoreCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019A RID: 410
			// (get) Token: 0x0600065F RID: 1631 RVA: 0x0001AACC File Offset: 0x00018CCC
			// (set) Token: 0x06000660 RID: 1632 RVA: 0x00005361 File Offset: 0x00003561
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001AAF4 File Offset: 0x00018CF4
			// (set) Token: 0x06000662 RID: 1634 RVA: 0x00005380 File Offset: 0x00003580
			public unsafe string receipt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_receipt);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_receipt), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001AB1C File Offset: 0x00018D1C
			// (set) Token: 0x06000664 RID: 1636 RVA: 0x0000539F File Offset: 0x0000359F
			public unsafe string transactionID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_transactionID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass7_0.NativeFieldInfoPtr_transactionID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400042E RID: 1070
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400042F RID: 1071
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04000430 RID: 1072
			private static readonly IntPtr NativeFieldInfoPtr_receipt;

			// Token: 0x04000431 RID: 1073
			private static readonly IntPtr NativeFieldInfoPtr_transactionID;

			// Token: 0x04000432 RID: 1074
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000433 RID: 1075
			private static readonly IntPtr NativeMethodInfoPtr__OnPurchaseSucceeded_b__0_Internal_Void_0;
		}

		// Token: 0x020000AC RID: 172
		[ObfuscatedName("UnityEngine.Purchasing.ScriptingStoreCallback+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06000665 RID: 1637 RVA: 0x0001AB44 File Offset: 0x00018D44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr);
				ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr, "<>4__this");
				ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr_purchasedProducts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr, "purchasedProducts");
				ScriptingStoreCallback.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr, 100663534);
				ScriptingStoreCallback.__c__DisplayClass8_0.NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr, 100663535);
			}

			// Token: 0x06000666 RID: 1638 RVA: 0x0001ABC0 File Offset: 0x00018DC0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000667 RID: 1639 RVA: 0x0001ABFC File Offset: 0x00018DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152272, XrefRangeEnd = 152282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnAllPurchasesRetrieved_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass8_0.NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x000053BE File Offset: 0x000035BE
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001AC30 File Offset: 0x00018E30
			// (set) Token: 0x0600066A RID: 1642 RVA: 0x000053C7 File Offset: 0x000035C7
			public unsafe ScriptingStoreCallback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptingStoreCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001AC60 File Offset: 0x00018E60
			// (set) Token: 0x0600066C RID: 1644 RVA: 0x000053E6 File Offset: 0x000035E6
			public unsafe List<Product> purchasedProducts
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr_purchasedProducts);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Product>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass8_0.NativeFieldInfoPtr_purchasedProducts), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000434 RID: 1076
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000435 RID: 1077
			private static readonly IntPtr NativeFieldInfoPtr_purchasedProducts;

			// Token: 0x04000436 RID: 1078
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000437 RID: 1079
			private static readonly IntPtr NativeMethodInfoPtr__OnAllPurchasesRetrieved_b__0_Internal_Void_0;
		}

		// Token: 0x020000AD RID: 173
		[ObfuscatedName("UnityEngine.Purchasing.ScriptingStoreCallback+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600066D RID: 1645 RVA: 0x0001AC90 File Offset: 0x00018E90
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingStoreCallback>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr);
				ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr_desc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr, "desc");
				ScriptingStoreCallback.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr, 100663536);
				ScriptingStoreCallback.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPurchaseFailed_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr, 100663537);
			}

			// Token: 0x0600066E RID: 1646 RVA: 0x0001AD0C File Offset: 0x00018F0C
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptingStoreCallback.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600066F RID: 1647 RVA: 0x0001AD48 File Offset: 0x00018F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 152282, XrefRangeEnd = 152286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPurchaseFailed_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingStoreCallback.__c__DisplayClass10_0.NativeMethodInfoPtr__OnPurchaseFailed_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000670 RID: 1648 RVA: 0x00005405 File Offset: 0x00003605
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019F RID: 415
			// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001AD7C File Offset: 0x00018F7C
			// (set) Token: 0x06000672 RID: 1650 RVA: 0x0000540E File Offset: 0x0000360E
			public unsafe ScriptingStoreCallback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptingStoreCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001ADAC File Offset: 0x00018FAC
			// (set) Token: 0x06000674 RID: 1652 RVA: 0x0000542D File Offset: 0x0000362D
			public unsafe PurchaseFailureDescription desc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr_desc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchaseFailureDescription>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScriptingStoreCallback.__c__DisplayClass10_0.NativeFieldInfoPtr_desc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000438 RID: 1080
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000439 RID: 1081
			private static readonly IntPtr NativeFieldInfoPtr_desc;

			// Token: 0x0400043A RID: 1082
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400043B RID: 1083
			private static readonly IntPtr NativeMethodInfoPtr__OnPurchaseFailed_b__0_Internal_Void_0;
		}
	}
}
