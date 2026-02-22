using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000053 RID: 83
	public class CloudCatalogImpl : Object
	{
		// Token: 0x060002C5 RID: 709 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		// Note: this type is marked as 'beforefieldinit'.
		static CloudCatalogImpl()
		{
			Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "CloudCatalogImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr);
			CloudCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "m_AsyncUtil");
			CloudCatalogImpl.NativeFieldInfoPtr_m_CacheFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "m_CacheFileName");
			CloudCatalogImpl.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "m_Logger");
			CloudCatalogImpl.NativeFieldInfoPtr_m_CatalogURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "m_CatalogURL");
			CloudCatalogImpl.NativeFieldInfoPtr_m_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "m_StoreName");
			CloudCatalogImpl.NativeMethodInfoPtr_CreateInstance_Public_Static_CloudCatalogImpl_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663647);
			CloudCatalogImpl.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_String_ILogger_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663648);
			CloudCatalogImpl.NativeMethodInfoPtr_FetchProducts_Public_Void_Action_1_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663649);
			CloudCatalogImpl.NativeMethodInfoPtr_FetchProducts_Internal_Void_Action_1_HashSet_1_ProductDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663650);
			CloudCatalogImpl.NativeMethodInfoPtr_ParseProductsFromJSON_Internal_Static_HashSet_1_ProductDefinition_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663651);
			CloudCatalogImpl.NativeMethodInfoPtr_CamelCaseToSnakeCase_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663652);
			CloudCatalogImpl.NativeMethodInfoPtr_TryPersistCatalog_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663653);
			CloudCatalogImpl.NativeMethodInfoPtr_TryLoadCachedCatalog_Private_HashSet_1_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, 100663654);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000F30C File Offset: 0x0000D50C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153856, RefRangeEnd = 153857, XrefRangeStart = 153801, XrefRangeEnd = 153856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CloudCatalogImpl CreateInstance(string storeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_CreateInstance_Public_Static_CloudCatalogImpl_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CloudCatalogImpl>(intPtr3) : null;
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000F350 File Offset: 0x0000D550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153857, XrefRangeEnd = 153858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CloudCatalogImpl(IAsyncWebUtil util, string cacheFile, ILogger logger, string catalogURL, string storeName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cacheFile);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(catalogURL);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_String_ILogger_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000F3E8 File Offset: 0x0000D5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153858, XrefRangeEnd = 153859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchProducts(Action<HashSet<ProductDefinition>> callback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_FetchProducts_Public_Void_Action_1_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000F42C File Offset: 0x0000D62C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153880, RefRangeEnd = 153882, XrefRangeStart = 153859, XrefRangeEnd = 153880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FetchProducts(Action<HashSet<ProductDefinition>> callback, int delayInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_FetchProducts_Internal_Void_Action_1_HashSet_1_ProductDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000F47C File Offset: 0x0000D67C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 153957, RefRangeEnd = 153959, XrefRangeStart = 153882, XrefRangeEnd = 153957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static HashSet<ProductDefinition> ParseProductsFromJSON(string json, string storeName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_ParseProductsFromJSON_Internal_Static_HashSet_1_ProductDefinition_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 153994, RefRangeEnd = 153995, XrefRangeStart = 153959, XrefRangeEnd = 153994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CamelCaseToSnakeCase(string s)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_CamelCaseToSnakeCase_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000F510 File Offset: 0x0000D710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154000, RefRangeEnd = 154001, XrefRangeStart = 153995, XrefRangeEnd = 154000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryPersistCatalog(string response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(response);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_TryPersistCatalog_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000F554 File Offset: 0x0000D754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154006, RefRangeEnd = 154008, XrefRangeStart = 154001, XrefRangeEnd = 154006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<ProductDefinition> TryLoadCachedCatalog()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.NativeMethodInfoPtr_TryLoadCachedCatalog_Private_HashSet_1_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<ProductDefinition>>(intPtr3) : null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000035C1 File Offset: 0x000017C1
		public CloudCatalogImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000F594 File Offset: 0x0000D794
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000035CA File Offset: 0x000017CA
		public unsafe IAsyncWebUtil m_AsyncUtil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x000035E9 File Offset: 0x000017E9
		public unsafe string m_CacheFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_CacheFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_CacheFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00003608 File Offset: 0x00001808
		public unsafe ILogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000F61C File Offset: 0x0000D81C
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00003627 File Offset: 0x00001827
		public unsafe string m_CatalogURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_CatalogURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_CatalogURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000F644 File Offset: 0x0000D844
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003646 File Offset: 0x00001846
		public unsafe string m_StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.NativeFieldInfoPtr_m_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncUtil;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheFileName;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogURL;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreName;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_CloudCatalogImpl_String_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_String_ILogger_String_String_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_FetchProducts_Public_Void_Action_1_HashSet_1_ProductDefinition_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_FetchProducts_Internal_Void_Action_1_HashSet_1_ProductDefinition_Int32_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_ParseProductsFromJSON_Internal_Static_HashSet_1_ProductDefinition_String_String_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_CamelCaseToSnakeCase_Internal_Static_String_String_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_TryPersistCatalog_Private_Void_String_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadCachedCatalog_Private_HashSet_1_ProductDefinition_0;

		// Token: 0x020000B5 RID: 181
		[ObfuscatedName("UnityEngine.Purchasing.CloudCatalogImpl+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x060006B1 RID: 1713 RVA: 0x0001B884 File Offset: 0x00019A84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr);
				CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, "<>4__this");
				CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, "callback");
				CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_delayInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, "delayInSeconds");
				CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, "<>9__2");
				CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663655);
				CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663656);
				CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__1_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663657);
				CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr, 100663658);
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x0001B950 File Offset: 0x00019B50
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCatalogImpl.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B3 RID: 1715 RVA: 0x0001B98C File Offset: 0x00019B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153732, XrefRangeEnd = 153754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FetchProducts_b__0(string response)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(response);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006B4 RID: 1716 RVA: 0x0001B9D0 File Offset: 0x00019BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153754, XrefRangeEnd = 153787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FetchProducts_b__1(string error)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(error);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__1_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006B5 RID: 1717 RVA: 0x0001BA14 File Offset: 0x00019C14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153787, XrefRangeEnd = 153789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _FetchProducts_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c__DisplayClass10_0.NativeMethodInfoPtr__FetchProducts_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006B6 RID: 1718 RVA: 0x00005635 File Offset: 0x00003835
			public __c__DisplayClass10_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0001BA48 File Offset: 0x00019C48
			// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0000563E File Offset: 0x0000383E
			public unsafe CloudCatalogImpl __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloudCatalogImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0001BA78 File Offset: 0x00019C78
			// (set) Token: 0x060006BA RID: 1722 RVA: 0x0000565D File Offset: 0x0000385D
			public unsafe Action<HashSet<ProductDefinition>> callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<HashSet<ProductDefinition>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x060006BB RID: 1723 RVA: 0x0001BAA8 File Offset: 0x00019CA8
			// (set) Token: 0x060006BC RID: 1724 RVA: 0x0000567C File Offset: 0x0000387C
			public unsafe int delayInSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_delayInSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr_delayInSeconds)) = value;
				}
			}

			// Token: 0x170001B3 RID: 435
			// (get) Token: 0x060006BD RID: 1725 RVA: 0x0001BAD0 File Offset: 0x00019CD0
			// (set) Token: 0x060006BE RID: 1726 RVA: 0x00005697 File Offset: 0x00003897
			public unsafe Action __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CloudCatalogImpl.__c__DisplayClass10_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400045B RID: 1115
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400045C RID: 1116
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x0400045D RID: 1117
			private static readonly IntPtr NativeFieldInfoPtr_delayInSeconds;

			// Token: 0x0400045E RID: 1118
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400045F RID: 1119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000460 RID: 1120
			private static readonly IntPtr NativeMethodInfoPtr__FetchProducts_b__0_Internal_Void_String_0;

			// Token: 0x04000461 RID: 1121
			private static readonly IntPtr NativeMethodInfoPtr__FetchProducts_b__1_Internal_Void_String_0;

			// Token: 0x04000462 RID: 1122
			private static readonly IntPtr NativeMethodInfoPtr__FetchProducts_b__2_Internal_Void_0;
		}

		// Token: 0x020000B6 RID: 182
		[ObfuscatedName("UnityEngine.Purchasing.CloudCatalogImpl+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006BF RID: 1727 RVA: 0x0001BB00 File Offset: 0x00019D00
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CloudCatalogImpl>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr);
				CloudCatalogImpl.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, "<>9");
				CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, "<>9__12_0");
				CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, "<>9__12_1");
				CloudCatalogImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, 100663660);
				CloudCatalogImpl.__c.NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_0_Internal_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, 100663661);
				CloudCatalogImpl.__c.NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_1_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr, 100663662);
			}

			// Token: 0x060006C0 RID: 1728 RVA: 0x0001BBA4 File Offset: 0x00019DA4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CloudCatalogImpl.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006C1 RID: 1729 RVA: 0x0001BBE0 File Offset: 0x00019DE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153789, XrefRangeEnd = 153800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CamelCaseToSnakeCase_b__12_0(char a, int b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref a;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c.NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_0_Internal_String_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x0001BC34 File Offset: 0x00019E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 153800, XrefRangeEnd = 153801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _CamelCaseToSnakeCase_b__12_1(string a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CloudCatalogImpl.__c.NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_1_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x000056B6 File Offset: 0x000038B6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0001BC90 File Offset: 0x00019E90
			// (set) Token: 0x060006C5 RID: 1733 RVA: 0x000056BF File Offset: 0x000038BF
			public unsafe static CloudCatalogImpl.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CloudCatalogImpl.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0001BCB8 File Offset: 0x00019EB8
			// (set) Token: 0x060006C7 RID: 1735 RVA: 0x000056D1 File Offset: 0x000038D1
			public unsafe static Func<char, int, string> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<char, int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0001BCE0 File Offset: 0x00019EE0
			// (set) Token: 0x060006C9 RID: 1737 RVA: 0x000056E3 File Offset: 0x000038E3
			public unsafe static Func<string, string, string> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CloudCatalogImpl.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000463 RID: 1123
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000464 RID: 1124
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04000465 RID: 1125
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x04000466 RID: 1126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000467 RID: 1127
			private static readonly IntPtr NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_0_Internal_String_Char_Int32_0;

			// Token: 0x04000468 RID: 1128
			private static readonly IntPtr NativeMethodInfoPtr__CamelCaseToSnakeCase_b__12_1_Internal_String_String_String_0;
		}
	}
}
