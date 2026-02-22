using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Net
{
	// Token: 0x020000F0 RID: 240
	[Serializable]
	public class CookieContainer : Object
	{
		// Token: 0x06000E04 RID: 3588 RVA: 0x00044DA4 File Offset: 0x00042FA4
		// Note: this type is marked as 'beforefieldinit'.
		static CookieContainer()
		{
			Il2CppClassPointerStore<CookieContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "CookieContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr);
			CookieContainer.NativeFieldInfoPtr_HeaderInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "HeaderInfo");
			CookieContainer.NativeFieldInfoPtr_m_domainTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_domainTable");
			CookieContainer.NativeFieldInfoPtr_m_maxCookieSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookieSize");
			CookieContainer.NativeFieldInfoPtr_m_maxCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookies");
			CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_maxCookiesPerDomain");
			CookieContainer.NativeFieldInfoPtr_m_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_count");
			CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, "m_fqdnMyDomain");
			CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665262);
			CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665263);
			CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665264);
			CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665265);
			CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665266);
			CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665267);
			CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665268);
			CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665269);
			CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665270);
			CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665271);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665272);
			CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr, 100665273);
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00044F50 File Offset: 0x00043150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48371, XrefRangeEnd = 48382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieContainer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookieContainer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00044F8C File Offset: 0x0004318C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48386, RefRangeEnd = 48388, XrefRangeStart = 48382, XrefRangeEnd = 48386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRemoveDomain(string key, PathList value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x00044FE0 File Offset: 0x000431E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48433, RefRangeEnd = 48434, XrefRangeStart = 48388, XrefRangeEnd = 48433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Cookie cookie, bool throwOnError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref throwOnError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00045030 File Offset: 0x00043230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48557, RefRangeEnd = 48559, XrefRangeStart = 48434, XrefRangeEnd = 48557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AgeCookies(string domain)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00045080 File Offset: 0x00043280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48565, RefRangeEnd = 48566, XrefRangeStart = 48559, XrefRangeEnd = 48565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ExpireCollection(CookieCollection cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x000450D0 File Offset: 0x000432D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48590, RefRangeEnd = 48591, XrefRangeStart = 48566, XrefRangeEnd = 48590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsLocalDomain(string host)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(host);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00045120 File Offset: 0x00043320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48653, RefRangeEnd = 48655, XrefRangeStart = 48591, XrefRangeEnd = 48653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection CookieCutter(Uri uri, string headerName, string setCookieHeader, bool isThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(headerName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(setCookieHeader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x000451A4 File Offset: 0x000433A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48703, RefRangeEnd = 48704, XrefRangeStart = 48655, XrefRangeEnd = 48703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookieCollection InternalGetCookies(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookieCollection>(intPtr3) : null;
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000451F4 File Offset: 0x000433F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48771, RefRangeEnd = 48773, XrefRangeStart = 48704, XrefRangeEnd = 48771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildCookieCollectionFromDomainMatches(Uri uri, bool isSecure, int port, CookieCollection cookies, List<string> domainAttribute, bool matchOnlyPlainCookie)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookies);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(domainAttribute);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref matchOnlyPlainCookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0E RID: 3598 RVA: 0x00045288 File Offset: 0x00043488
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48782, RefRangeEnd = 48784, XrefRangeStart = 48773, XrefRangeEnd = 48782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MergeUpdateCollections(CookieCollection destination, CookieCollection source, int port, bool isSecure, bool isPlainOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref port;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isSecure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPlainOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0F RID: 3599 RVA: 0x00045308 File Offset: 0x00043508
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48789, RefRangeEnd = 48790, XrefRangeStart = 48784, XrefRangeEnd = 48789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E10 RID: 3600 RVA: 0x00045350 File Offset: 0x00043550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48823, RefRangeEnd = 48824, XrefRangeStart = 48790, XrefRangeEnd = 48823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCookieHeader(Uri uri, out string optCookie2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CookieContainer.NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			optCookie2 = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00007820 File Offset: 0x00005A20
		public CookieContainer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E12 RID: 3602 RVA: 0x000453B4 File Offset: 0x000435B4
		// (set) Token: 0x06000E13 RID: 3603 RVA: 0x00007829 File Offset: 0x00005A29
		public unsafe static Il2CppReferenceArray<HeaderVariantInfo> HeaderInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HeaderVariantInfo>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CookieContainer.NativeFieldInfoPtr_HeaderInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000453DC File Offset: 0x000435DC
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x0000783B File Offset: 0x00005A3B
		public unsafe Hashtable m_domainTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_domainTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E16 RID: 3606 RVA: 0x0004540C File Offset: 0x0004360C
		// (set) Token: 0x06000E17 RID: 3607 RVA: 0x0000785A File Offset: 0x00005A5A
		public unsafe int m_maxCookieSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookieSize)) = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E18 RID: 3608 RVA: 0x00045434 File Offset: 0x00043634
		// (set) Token: 0x06000E19 RID: 3609 RVA: 0x00007875 File Offset: 0x00005A75
		public unsafe int m_maxCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookies)) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E1A RID: 3610 RVA: 0x0004545C File Offset: 0x0004365C
		// (set) Token: 0x06000E1B RID: 3611 RVA: 0x00007890 File Offset: 0x00005A90
		public unsafe int m_maxCookiesPerDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_maxCookiesPerDomain)) = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06000E1C RID: 3612 RVA: 0x00045484 File Offset: 0x00043684
		// (set) Token: 0x06000E1D RID: 3613 RVA: 0x000078AB File Offset: 0x00005AAB
		public unsafe int m_count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_count)) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x000454AC File Offset: 0x000436AC
		// (set) Token: 0x06000E1F RID: 3615 RVA: 0x000078C6 File Offset: 0x00005AC6
		public unsafe string m_fqdnMyDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookieContainer.NativeFieldInfoPtr_m_fqdnMyDomain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeFieldInfoPtr_HeaderInfo;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeFieldInfoPtr_m_domainTable;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookieSize;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookies;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeFieldInfoPtr_m_maxCookiesPerDomain;

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr_m_count;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeFieldInfoPtr_m_fqdnMyDomain;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr_AddRemoveDomain_Private_Void_String_PathList_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_Cookie_Boolean_0;

		// Token: 0x04000B23 RID: 2851
		private static readonly IntPtr NativeMethodInfoPtr_AgeCookies_Private_Boolean_String_0;

		// Token: 0x04000B24 RID: 2852
		private static readonly IntPtr NativeMethodInfoPtr_ExpireCollection_Private_Int32_CookieCollection_0;

		// Token: 0x04000B25 RID: 2853
		private static readonly IntPtr NativeMethodInfoPtr_IsLocalDomain_Internal_Boolean_String_0;

		// Token: 0x04000B26 RID: 2854
		private static readonly IntPtr NativeMethodInfoPtr_CookieCutter_Internal_CookieCollection_Uri_String_String_Boolean_0;

		// Token: 0x04000B27 RID: 2855
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetCookies_Internal_CookieCollection_Uri_0;

		// Token: 0x04000B28 RID: 2856
		private static readonly IntPtr NativeMethodInfoPtr_BuildCookieCollectionFromDomainMatches_Private_Void_Uri_Boolean_Int32_CookieCollection_List_1_String_Boolean_0;

		// Token: 0x04000B29 RID: 2857
		private static readonly IntPtr NativeMethodInfoPtr_MergeUpdateCollections_Private_Void_CookieCollection_CookieCollection_Int32_Boolean_Boolean_0;

		// Token: 0x04000B2A RID: 2858
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Public_String_Uri_0;

		// Token: 0x04000B2B RID: 2859
		private static readonly IntPtr NativeMethodInfoPtr_GetCookieHeader_Internal_String_Uri_byref_String_0;
	}
}
