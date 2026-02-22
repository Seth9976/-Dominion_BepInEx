using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000061 RID: 97
	public class StoreCatalogImpl : Object
	{
		// Token: 0x0600037B RID: 891 RVA: 0x000115C8 File Offset: 0x0000F7C8
		// Note: this type is marked as 'beforefieldinit'.
		static StoreCatalogImpl()
		{
			Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "StoreCatalogImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr);
			StoreCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "m_AsyncUtil");
			StoreCatalogImpl.NativeFieldInfoPtr_m_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "m_Logger");
			StoreCatalogImpl.NativeFieldInfoPtr_m_CatalogURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "m_CatalogURL");
			StoreCatalogImpl.NativeFieldInfoPtr_m_StoreName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "m_StoreName");
			StoreCatalogImpl.NativeFieldInfoPtr_m_cachedStoreCatalogReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "m_cachedStoreCatalogReference");
			StoreCatalogImpl.NativeFieldInfoPtr_profile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, "profile");
			StoreCatalogImpl.NativeMethodInfoPtr_CreateInstance_Public_Static_StoreCatalogImpl_String_String_IAsyncWebUtil_ILogger_IUtil_JSONStore_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, 100663729);
			StoreCatalogImpl.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_ILogger_String_String_FileReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr, 100663730);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00011698 File Offset: 0x0000F898
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154864, RefRangeEnd = 154865, XrefRangeStart = 154814, XrefRangeEnd = 154864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static StoreCatalogImpl CreateInstance(string storeName, string baseUrl, IAsyncWebUtil webUtil, ILogger logger, IUtil util, JSONStore baseStore = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(storeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUrl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(webUtil);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(util);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseStore);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreCatalogImpl.NativeMethodInfoPtr_CreateInstance_Public_Static_StoreCatalogImpl_String_String_IAsyncWebUtil_ILogger_IUtil_JSONStore_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StoreCatalogImpl>(intPtr3) : null;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00011738 File Offset: 0x0000F938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoreCatalogImpl(IAsyncWebUtil util, ILogger logger, string catalogURL, string storeName, FileReference fileReference)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoreCatalogImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(util);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(catalogURL);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(storeName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(fileReference);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoreCatalogImpl.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_ILogger_String_String_FileReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00003BFE File Offset: 0x00001DFE
		public StoreCatalogImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600037F RID: 895 RVA: 0x000117D0 File Offset: 0x0000F9D0
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003C07 File Offset: 0x00001E07
		public unsafe IAsyncWebUtil m_AsyncUtil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncWebUtil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_AsyncUtil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00011800 File Offset: 0x0000FA00
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003C26 File Offset: 0x00001E26
		public unsafe ILogger m_Logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_Logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ILogger>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_Logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00011830 File Offset: 0x0000FA30
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00003C45 File Offset: 0x00001E45
		public unsafe string m_CatalogURL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_CatalogURL);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_CatalogURL), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00011858 File Offset: 0x0000FA58
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00003C64 File Offset: 0x00001E64
		public unsafe string m_StoreName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_StoreName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_StoreName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00011880 File Offset: 0x0000FA80
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00003C83 File Offset: 0x00001E83
		public unsafe FileReference m_cachedStoreCatalogReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_cachedStoreCatalogReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FileReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoreCatalogImpl.NativeFieldInfoPtr_m_cachedStoreCatalogReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000389 RID: 905 RVA: 0x000118B0 File Offset: 0x0000FAB0
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00003CA2 File Offset: 0x00001EA2
		public unsafe static ProfileData profile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StoreCatalogImpl.NativeFieldInfoPtr_profile, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfileData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StoreCatalogImpl.NativeFieldInfoPtr_profile, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeFieldInfoPtr_m_AsyncUtil;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeFieldInfoPtr_m_Logger;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeFieldInfoPtr_m_CatalogURL;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreName;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeFieldInfoPtr_m_cachedStoreCatalogReference;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeFieldInfoPtr_profile;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_StoreCatalogImpl_String_String_IAsyncWebUtil_ILogger_IUtil_JSONStore_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncWebUtil_ILogger_String_String_FileReference_0;
	}
}
