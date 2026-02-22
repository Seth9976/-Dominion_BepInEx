using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.ObjectModel;
using Uniject;
using UnityEngine.Purchasing.Default;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000080 RID: 128
	public class WinRTStore : AbstractStore
	{
		// Token: 0x060004EE RID: 1262 RVA: 0x00015D8C File Offset: 0x00013F8C
		// Note: this type is marked as 'beforefieldinit'.
		static WinRTStore()
		{
			Il2CppClassPointerStore<WinRTStore>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "WinRTStore");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr);
			WinRTStore.NativeFieldInfoPtr_win8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "win8");
			WinRTStore.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "callback");
			WinRTStore.NativeFieldInfoPtr_util = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "util");
			WinRTStore.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "logger");
			WinRTStore.NativeFieldInfoPtr_m_CanReceivePurchases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "m_CanReceivePurchases");
			WinRTStore.NativeMethodInfoPtr__ctor_Public_Void_IWindowsIAP_IUtil_ILogger_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663882);
			WinRTStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663883);
			WinRTStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663884);
			WinRTStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663885);
			WinRTStore.NativeMethodInfoPtr_init_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663886);
			WinRTStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663887);
			WinRTStore.NativeMethodInfoPtr_restoreTransactions_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, 100663888);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00015EAC File Offset: 0x000140AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156483, XrefRangeEnd = 156484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WinRTStore(IWindowsIAP win8, IUtil util, ILogger logger)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(win8);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.NativeMethodInfoPtr__ctor_Public_Void_IWindowsIAP_IUtil_ILogger_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00015F1C File Offset: 0x0001411C
		[CallerCount(0)]
		public unsafe override void Initialize(IStoreCallback biller)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(biller);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinRTStore.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00015F6C File Offset: 0x0001416C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156484, XrefRangeEnd = 156532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(productDefs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinRTStore.NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00015FBC File Offset: 0x000141BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156532, XrefRangeEnd = 156536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinRTStore.NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001601C File Offset: 0x0001421C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156536, XrefRangeEnd = 156542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void init(int delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.NativeMethodInfoPtr_init_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001605C File Offset: 0x0001425C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156542, XrefRangeEnd = 156546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WinRTStore.NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x000160BC File Offset: 0x000142BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156546, XrefRangeEnd = 156549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void restoreTransactions(bool pausing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pausing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.NativeMethodInfoPtr_restoreTransactions_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000048FE File Offset: 0x00002AFE
		public WinRTStore(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000160FC File Offset: 0x000142FC
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x00004907 File Offset: 0x00002B07
		public unsafe IWindowsIAP win8
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_win8);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IWindowsIAP>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_win8), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0001612C File Offset: 0x0001432C
		// (set) Token: 0x060004FA RID: 1274 RVA: 0x00004926 File Offset: 0x00002B26
		public unsafe IStoreCallback callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IStoreCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x0001615C File Offset: 0x0001435C
		// (set) Token: 0x060004FC RID: 1276 RVA: 0x00004945 File Offset: 0x00002B45
		public unsafe IUtil util
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_util);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_util), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004FD RID: 1277 RVA: 0x0001618C File Offset: 0x0001438C
		// (set) Token: 0x060004FE RID: 1278 RVA: 0x00004964 File Offset: 0x00002B64
		public unsafe ILogger logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x000161BC File Offset: 0x000143BC
		// (set) Token: 0x06000500 RID: 1280 RVA: 0x00004983 File Offset: 0x00002B83
		public unsafe bool m_CanReceivePurchases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_m_CanReceivePurchases);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WinRTStore.NativeFieldInfoPtr_m_CanReceivePurchases)) = value;
			}
		}

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeFieldInfoPtr_win8;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeFieldInfoPtr_util;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_m_CanReceivePurchases;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IWindowsIAP_IUtil_ILogger_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_IStoreCallback_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_RetrieveProducts_Public_Virtual_Void_ReadOnlyCollection_1_ProductDefinition_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_FinishTransaction_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_init_Private_Void_Int32_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_Purchase_Public_Virtual_Void_ProductDefinition_String_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_restoreTransactions_Public_Void_Boolean_0;

		// Token: 0x020000C4 RID: 196
		[ObfuscatedName("UnityEngine.Purchasing.WinRTStore+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600071A RID: 1818 RVA: 0x0001CBB4 File Offset: 0x0001ADB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WinRTStore>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr);
				WinRTStore.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, "<>9");
				WinRTStore.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, "<>9__8_0");
				WinRTStore.__c.NativeFieldInfoPtr___9__8_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, "<>9__8_1");
				WinRTStore.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, 100663890);
				WinRTStore.__c.NativeMethodInfoPtr__RetrieveProducts_b__8_0_Internal_Boolean_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, 100663891);
				WinRTStore.__c.NativeMethodInfoPtr__RetrieveProducts_b__8_1_Internal_WinProductDescription_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr, 100663892);
			}

			// Token: 0x0600071B RID: 1819 RVA: 0x0001CC58 File Offset: 0x0001AE58
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WinRTStore.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600071C RID: 1820 RVA: 0x0001CC94 File Offset: 0x0001AE94
			[CallerCount(0)]
			public unsafe bool _RetrieveProducts_b__8_0(ProductDefinition def)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.__c.NativeMethodInfoPtr__RetrieveProducts_b__8_0_Internal_Boolean_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600071D RID: 1821 RVA: 0x0001CCE4 File Offset: 0x0001AEE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156468, XrefRangeEnd = 156483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WinProductDescription _RetrieveProducts_b__8_1(ProductDefinition def)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(def);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WinRTStore.__c.NativeMethodInfoPtr__RetrieveProducts_b__8_1_Internal_WinProductDescription_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WinProductDescription>(intPtr3) : null;
				}
			}

			// Token: 0x0600071E RID: 1822 RVA: 0x00005957 File Offset: 0x00003B57
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x0600071F RID: 1823 RVA: 0x0001CD34 File Offset: 0x0001AF34
			// (set) Token: 0x06000720 RID: 1824 RVA: 0x00005960 File Offset: 0x00003B60
			public unsafe static WinRTStore.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WinRTStore.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WinRTStore.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WinRTStore.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000721 RID: 1825 RVA: 0x0001CD5C File Offset: 0x0001AF5C
			// (set) Token: 0x06000722 RID: 1826 RVA: 0x00005972 File Offset: 0x00003B72
			public unsafe static Func<ProductDefinition, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WinRTStore.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WinRTStore.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000723 RID: 1827 RVA: 0x0001CD84 File Offset: 0x0001AF84
			// (set) Token: 0x06000724 RID: 1828 RVA: 0x00005984 File Offset: 0x00003B84
			public unsafe static Func<ProductDefinition, WinProductDescription> __9__8_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WinRTStore.__c.NativeFieldInfoPtr___9__8_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ProductDefinition, WinProductDescription>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WinRTStore.__c.NativeFieldInfoPtr___9__8_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400049C RID: 1180
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400049D RID: 1181
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400049E RID: 1182
			private static readonly IntPtr NativeFieldInfoPtr___9__8_1;

			// Token: 0x0400049F RID: 1183
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004A0 RID: 1184
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__8_0_Internal_Boolean_ProductDefinition_0;

			// Token: 0x040004A1 RID: 1185
			private static readonly IntPtr NativeMethodInfoPtr__RetrieveProducts_b__8_1_Internal_WinProductDescription_ProductDefinition_0;
		}
	}
}
