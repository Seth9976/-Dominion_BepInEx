using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200001C RID: 28
	public class UnityPurchasing : Object
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00006D30 File Offset: 0x00004F30
		// Note: this type is marked as 'beforefieldinit'.
		static UnityPurchasing()
		{
			Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.dll", "UnityEngine.Purchasing", "UnityPurchasing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr);
			UnityPurchasing.NativeMethodInfoPtr_Initialize_Public_Static_Void_IStoreListener_ConfigurationBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr, 100663437);
			UnityPurchasing.NativeMethodInfoPtr_Initialize_Internal_Static_Void_IStoreListener_ConfigurationBuilder_ILogger_String_IUnityAnalytics_ICatalogProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr, 100663438);
			UnityPurchasing.NativeMethodInfoPtr_FetchAndMergeProducts_Internal_Static_Void_Boolean_HashSet_1_ProductDefinition_ICatalogProvider_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr, 100663439);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00006D9C File Offset: 0x00004F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131229, RefRangeEnd = 131230, XrefRangeStart = 131215, XrefRangeEnd = 131229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IStoreListener listener, ConfigurationBuilder builder)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.NativeMethodInfoPtr_Initialize_Public_Static_Void_IStoreListener_ConfigurationBuilder_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006DE4 File Offset: 0x00004FE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 131284, RefRangeEnd = 131285, XrefRangeStart = 131230, XrefRangeEnd = 131284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(IStoreListener listener, ConfigurationBuilder builder, ILogger logger, string persistentDatapath, IUnityAnalytics analytics, ICatalogProvider catalog)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(builder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(persistentDatapath);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(analytics);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(catalog);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.NativeMethodInfoPtr_Initialize_Internal_Static_Void_IStoreListener_ConfigurationBuilder_ILogger_String_IUnityAnalytics_ICatalogProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00006E78 File Offset: 0x00005078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131285, XrefRangeEnd = 131301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FetchAndMergeProducts(bool useCatalog, HashSet<ProductDefinition> localProductSet, ICatalogProvider catalog, Action<HashSet<ProductDefinition>> callback)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useCatalog;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(localProductSet);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(catalog);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.NativeMethodInfoPtr_FetchAndMergeProducts_Internal_Static_Void_Boolean_HashSet_1_ProductDefinition_ICatalogProvider_Action_1_HashSet_1_ProductDefinition_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000279D File Offset: 0x0000099D
		public UnityPurchasing(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_IStoreListener_ConfigurationBuilder_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_IStoreListener_ConfigurationBuilder_ILogger_String_IUnityAnalytics_ICatalogProvider_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_FetchAndMergeProducts_Internal_Static_Void_Boolean_HashSet_1_ProductDefinition_ICatalogProvider_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x02000030 RID: 48
		[ObfuscatedName("UnityEngine.Purchasing.UnityPurchasing+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000194 RID: 404 RVA: 0x00008ABC File Offset: 0x00006CBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr);
				UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_manager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr, "manager");
				UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_proxy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr, "proxy");
				UnityPurchasing.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr, 100663440);
				UnityPurchasing.__c__DisplayClass2_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr, 100663441);
			}

			// Token: 0x06000195 RID: 405 RVA: 0x00008B38 File Offset: 0x00006D38
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000196 RID: 406 RVA: 0x00008B74 File Offset: 0x00006D74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131184, XrefRangeEnd = 131186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__0(HashSet<ProductDefinition> response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.__c__DisplayClass2_0.NativeMethodInfoPtr__Initialize_b__0_Internal_Void_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000197 RID: 407 RVA: 0x00002AA0 File Offset: 0x00000CA0
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000198 RID: 408 RVA: 0x00008BB8 File Offset: 0x00006DB8
			// (set) Token: 0x06000199 RID: 409 RVA: 0x00002AA9 File Offset: 0x00000CA9
			public unsafe PurchasingManager manager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_manager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PurchasingManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_manager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x0600019A RID: 410 RVA: 0x00008BE8 File Offset: 0x00006DE8
			// (set) Token: 0x0600019B RID: 411 RVA: 0x00002AC8 File Offset: 0x00000CC8
			public unsafe StoreListenerProxy proxy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_proxy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoreListenerProxy>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass2_0.NativeFieldInfoPtr_proxy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000117 RID: 279
			private static readonly IntPtr NativeFieldInfoPtr_manager;

			// Token: 0x04000118 RID: 280
			private static readonly IntPtr NativeFieldInfoPtr_proxy;

			// Token: 0x04000119 RID: 281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400011A RID: 282
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__0_Internal_Void_HashSet_1_ProductDefinition_0;
		}

		// Token: 0x02000031 RID: 49
		[ObfuscatedName("UnityEngine.Purchasing.UnityPurchasing+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Object
		{
			// Token: 0x0600019C RID: 412 RVA: 0x00008C18 File Offset: 0x00006E18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityPurchasing>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr);
				UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_localProductSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr, "localProductSet");
				UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr, "callback");
				UnityPurchasing.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr, 100663442);
				UnityPurchasing.__c__DisplayClass3_0.NativeMethodInfoPtr__FetchAndMergeProducts_b__0_Internal_Void_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr, 100663443);
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00008C94 File Offset: 0x00006E94
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityPurchasing.__c__DisplayClass3_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00008CD0 File Offset: 0x00006ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131186, XrefRangeEnd = 131215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FetchAndMergeProducts_b__0(HashSet<ProductDefinition> cloudProducts)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(cloudProducts);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasing.__c__DisplayClass3_0.NativeMethodInfoPtr__FetchAndMergeProducts_b__0_Internal_Void_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00002AE7 File Offset: 0x00000CE7
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x060001A0 RID: 416 RVA: 0x00008D14 File Offset: 0x00006F14
			// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002AF0 File Offset: 0x00000CF0
			public unsafe HashSet<ProductDefinition> localProductSet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_localProductSet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_localProductSet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x060001A2 RID: 418 RVA: 0x00008D44 File Offset: 0x00006F44
			// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002B0F File Offset: 0x00000D0F
			public unsafe Action<HashSet<ProductDefinition>> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HashSet<ProductDefinition>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnityPurchasing.__c__DisplayClass3_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400011B RID: 283
			private static readonly IntPtr NativeFieldInfoPtr_localProductSet;

			// Token: 0x0400011C RID: 284
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400011D RID: 285
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400011E RID: 286
			private static readonly IntPtr NativeMethodInfoPtr__FetchAndMergeProducts_b__0_Internal_Void_HashSet_1_ProductDefinition_0;
		}
	}
}
