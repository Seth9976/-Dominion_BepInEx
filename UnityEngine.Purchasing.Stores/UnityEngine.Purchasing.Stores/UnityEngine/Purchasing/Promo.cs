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
	// Token: 0x0200006F RID: 111
	public class Promo : Object
	{
		// Token: 0x06000448 RID: 1096 RVA: 0x00013F60 File Offset: 0x00012160
		// Note: this type is marked as 'beforefieldinit'.
		static Promo()
		{
			Il2CppClassPointerStore<Promo>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "Promo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Promo>.NativeClassPtr);
			Promo.NativeFieldInfoPtr_s_PromoPurchaser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_PromoPurchaser");
			Promo.NativeFieldInfoPtr_s_Unity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_Unity");
			Promo.NativeFieldInfoPtr_s_RuntimePlatform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_RuntimePlatform");
			Promo.NativeFieldInfoPtr_s_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_Logger");
			Promo.NativeFieldInfoPtr_s_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_Version");
			Promo.NativeFieldInfoPtr_s_Util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_Util");
			Promo.NativeFieldInfoPtr_s_WebUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_WebUtil");
			Promo.NativeFieldInfoPtr_s_IsReady = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_IsReady");
			Promo.NativeFieldInfoPtr_s_ProductJSON = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Promo>.NativeClassPtr, "s_ProductJSON");
			Promo.NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663821);
			Promo.NativeMethodInfoPtr_Version_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663822);
			Promo.NativeMethodInfoPtr_InitPromo_Internal_Static_Void_RuntimePlatform_ILogger_String_IUtil_IAsyncWebUtil_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663823);
			Promo.NativeMethodInfoPtr_UpdatePromoProductList_Private_Static_HashSet_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663824);
			Promo.NativeMethodInfoPtr_ProvideProductsToAds_Internal_Static_Void_JSONStore_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663825);
			Promo.NativeMethodInfoPtr_ProvideProductsToAds_Private_Static_Void_HashSet_1_Product_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663826);
			Promo.NativeMethodInfoPtr_QueryPromoProducts_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663827);
			Promo.NativeMethodInfoPtr_InitiatePromoPurchase_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663828);
			Promo.NativeMethodInfoPtr_InitiatePurchasingCommand_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663829);
			Promo.NativeMethodInfoPtr_ExecPromoPurchase_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Promo>.NativeClassPtr, 100663830);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0001410C File Offset: 0x0001230C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155315, XrefRangeEnd = 155317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsReady()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001413C File Offset: 0x0001233C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155317, XrefRangeEnd = 155319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Version()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_Version_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00014168 File Offset: 0x00012368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155319, XrefRangeEnd = 155325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitPromo(RuntimePlatform platform, ILogger logger, string version, IUtil util, IAsyncWebUtil webUtil)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref platform;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(version);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webUtil);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_InitPromo_Internal_Static_Void_RuntimePlatform_ILogger_String_IUtil_IAsyncWebUtil_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000141E4 File Offset: 0x000123E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155348, RefRangeEnd = 155349, XrefRangeStart = 155325, XrefRangeEnd = 155348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<Product> UpdatePromoProductList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_UpdatePromoProductList_Private_Static_HashSet_1_Product_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<Product>>(intPtr3) : null;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00014218 File Offset: 0x00012418
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155362, RefRangeEnd = 155366, XrefRangeStart = 155349, XrefRangeEnd = 155362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProvideProductsToAds(JSONStore purchaser, IStoreCallback manager)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(purchaser);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_ProvideProductsToAds_Internal_Static_Void_JSONStore_IStoreCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00014260 File Offset: 0x00012460
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155440, RefRangeEnd = 155441, XrefRangeStart = 155366, XrefRangeEnd = 155440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProvideProductsToAds(HashSet<Product> productsForAds)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productsForAds);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_ProvideProductsToAds_Private_Static_Void_HashSet_1_Product_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00014298 File Offset: 0x00012498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155441, XrefRangeEnd = 155443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string QueryPromoProducts()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_QueryPromoProducts_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000142C4 File Offset: 0x000124C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155443, XrefRangeEnd = 155444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitiatePromoPurchase(string itemRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_InitiatePromoPurchase_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00014308 File Offset: 0x00012508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155560, RefRangeEnd = 155561, XrefRangeStart = 155444, XrefRangeEnd = 155560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitiatePurchasingCommand(string command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_InitiatePurchasingCommand_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0001434C File Offset: 0x0001254C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155594, RefRangeEnd = 155596, XrefRangeStart = 155561, XrefRangeEnd = 155594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExecPromoPurchase(string itemRequest)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(itemRequest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Promo.NativeMethodInfoPtr_ExecPromoPurchase_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000042E4 File Offset: 0x000024E4
		public Promo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00014390 File Offset: 0x00012590
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x000042ED File Offset: 0x000024ED
		public unsafe static JSONStore s_PromoPurchaser
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_PromoPurchaser, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<JSONStore>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_PromoPurchaser, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000143B8 File Offset: 0x000125B8
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000042FF File Offset: 0x000024FF
		public unsafe static IStoreCallback s_Unity
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_Unity, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_Unity, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000143E0 File Offset: 0x000125E0
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00004311 File Offset: 0x00002511
		public unsafe static RuntimePlatform s_RuntimePlatform
		{
			get
			{
				RuntimePlatform runtimePlatform;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_RuntimePlatform, (void*)(&runtimePlatform));
				return runtimePlatform;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_RuntimePlatform, (void*)(&value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000143FC File Offset: 0x000125FC
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0000431F File Offset: 0x0000251F
		public unsafe static ILogger s_Logger
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_Logger, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_Logger, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00014424 File Offset: 0x00012624
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x00004331 File Offset: 0x00002531
		public unsafe static string s_Version
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_Version, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_Version, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00014444 File Offset: 0x00012644
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00004343 File Offset: 0x00002543
		public unsafe static IUtil s_Util
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_Util, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_Util, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x0001446C File Offset: 0x0001266C
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x00004355 File Offset: 0x00002555
		public unsafe static IAsyncWebUtil s_WebUtil
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_WebUtil, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_WebUtil, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00014494 File Offset: 0x00012694
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00004367 File Offset: 0x00002567
		public unsafe static bool s_IsReady
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_IsReady, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_IsReady, (void*)(&value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x000144B0 File Offset: 0x000126B0
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00004375 File Offset: 0x00002575
		public unsafe static string s_ProductJSON
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Promo.NativeFieldInfoPtr_s_ProductJSON, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Promo.NativeFieldInfoPtr_s_ProductJSON, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_s_PromoPurchaser;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeFieldInfoPtr_s_Unity;

		// Token: 0x040002C9 RID: 713
		private static readonly IntPtr NativeFieldInfoPtr_s_RuntimePlatform;

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeFieldInfoPtr_s_Logger;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeFieldInfoPtr_s_Version;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeFieldInfoPtr_s_Util;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeFieldInfoPtr_s_WebUtil;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeFieldInfoPtr_s_IsReady;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeFieldInfoPtr_s_ProductJSON;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_IsReady_Public_Static_Boolean_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_Version_Public_Static_String_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_InitPromo_Internal_Static_Void_RuntimePlatform_ILogger_String_IUtil_IAsyncWebUtil_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePromoProductList_Private_Static_HashSet_1_Product_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_ProvideProductsToAds_Internal_Static_Void_JSONStore_IStoreCallback_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_ProvideProductsToAds_Private_Static_Void_HashSet_1_Product_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_QueryPromoProducts_Public_Static_String_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePromoPurchase_Public_Static_Boolean_String_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_InitiatePurchasingCommand_Public_Static_Boolean_String_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_ExecPromoPurchase_Internal_Static_Boolean_String_0;
	}
}
