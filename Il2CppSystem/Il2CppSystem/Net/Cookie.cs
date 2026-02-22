using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Net
{
	// Token: 0x020000E9 RID: 233
	[Serializable]
	public sealed class Cookie : Object
	{
		// Token: 0x06000D54 RID: 3412 RVA: 0x0004290C File Offset: 0x00040B0C
		// Note: this type is marked as 'beforefieldinit'.
		static Cookie()
		{
			Il2CppClassPointerStore<Cookie>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net", "Cookie");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cookie>.NativeClassPtr);
			Cookie.NativeFieldInfoPtr_PortSplitDelimiters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "PortSplitDelimiters");
			Cookie.NativeFieldInfoPtr_Reserved2Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "Reserved2Name");
			Cookie.NativeFieldInfoPtr_Reserved2Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "Reserved2Value");
			Cookie.NativeFieldInfoPtr_staticComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "staticComparer");
			Cookie.NativeFieldInfoPtr_m_comment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_comment");
			Cookie.NativeFieldInfoPtr_m_commentUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_commentUri");
			Cookie.NativeFieldInfoPtr_m_cookieVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_cookieVariant");
			Cookie.NativeFieldInfoPtr_m_discard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_discard");
			Cookie.NativeFieldInfoPtr_m_domain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domain");
			Cookie.NativeFieldInfoPtr_m_domain_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domain_implicit");
			Cookie.NativeFieldInfoPtr_m_expires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_expires");
			Cookie.NativeFieldInfoPtr_m_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_name");
			Cookie.NativeFieldInfoPtr_m_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_path");
			Cookie.NativeFieldInfoPtr_m_path_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_path_implicit");
			Cookie.NativeFieldInfoPtr_m_port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port");
			Cookie.NativeFieldInfoPtr_m_port_implicit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port_implicit");
			Cookie.NativeFieldInfoPtr_m_port_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_port_list");
			Cookie.NativeFieldInfoPtr_m_secure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_secure");
			Cookie.NativeFieldInfoPtr_m_httpOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_httpOnly");
			Cookie.NativeFieldInfoPtr_m_timeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_timeStamp");
			Cookie.NativeFieldInfoPtr_m_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_value");
			Cookie.NativeFieldInfoPtr_m_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_version");
			Cookie.NativeFieldInfoPtr_m_domainKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "m_domainKey");
			Cookie.NativeFieldInfoPtr_IsQuotedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "IsQuotedVersion");
			Cookie.NativeFieldInfoPtr_IsQuotedDomain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cookie>.NativeClassPtr, "IsQuotedDomain");
			Cookie.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665180);
			Cookie.NativeMethodInfoPtr_get_Comment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665181);
			Cookie.NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665182);
			Cookie.NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665183);
			Cookie.NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665184);
			Cookie.NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665185);
			Cookie.NativeMethodInfoPtr_get_Domain_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665186);
			Cookie.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665187);
			Cookie.NativeMethodInfoPtr_get__Domain_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665188);
			Cookie.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665189);
			Cookie.NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665190);
			Cookie.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665191);
			Cookie.NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665192);
			Cookie.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665193);
			Cookie.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665194);
			Cookie.NativeMethodInfoPtr_get__Path_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665195);
			Cookie.NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665196);
			Cookie.NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665197);
			Cookie.NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665198);
			Cookie.NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665199);
			Cookie.NativeMethodInfoPtr_set_Port_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665200);
			Cookie.NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665201);
			Cookie.NativeMethodInfoPtr_get__Port_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665202);
			Cookie.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665203);
			Cookie.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665204);
			Cookie.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665205);
			Cookie.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665206);
			Cookie.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665207);
			Cookie.NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665208);
			Cookie.NativeMethodInfoPtr_get_Version_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665209);
			Cookie.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665210);
			Cookie.NativeMethodInfoPtr_get__Version_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665211);
			Cookie.NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665212);
			Cookie.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665213);
			Cookie.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665214);
			Cookie.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cookie>.NativeClassPtr, 100665215);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00042E00 File Offset: 0x00041000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47808, XrefRangeEnd = 47822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cookie()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cookie>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000D56 RID: 3414 RVA: 0x00042E3C File Offset: 0x0004103C
		// (set) Token: 0x06000D57 RID: 3415 RVA: 0x00042E74 File Offset: 0x00041074
		public unsafe string Comment
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Comment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47822, XrefRangeEnd = 47824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000412 RID: 1042
		// (set) Token: 0x06000D58 RID: 3416 RVA: 0x00042EB8 File Offset: 0x000410B8
		public unsafe Uri CommentUri
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000413 RID: 1043
		// (set) Token: 0x06000D59 RID: 3417 RVA: 0x00042EFC File Offset: 0x000410FC
		public unsafe bool HttpOnly
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (set) Token: 0x06000D5A RID: 3418 RVA: 0x00042F3C File Offset: 0x0004113C
		public unsafe bool Discard
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06000D5B RID: 3419 RVA: 0x00042F7C File Offset: 0x0004117C
		// (set) Token: 0x06000D5C RID: 3420 RVA: 0x00042FB4 File Offset: 0x000411B4
		public unsafe string Domain
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Domain_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47824, XrefRangeEnd = 47827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000D5D RID: 3421 RVA: 0x00042FF8 File Offset: 0x000411F8
		public unsafe string _Domain
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47827, XrefRangeEnd = 47835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Domain_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x00043030 File Offset: 0x00041230
		public unsafe bool Expired
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 47840, RefRangeEnd = 47843, XrefRangeStart = 47835, XrefRangeEnd = 47840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0004306C File Offset: 0x0004126C
		public unsafe DateTime Expires
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x000430AC File Offset: 0x000412AC
		public unsafe string Name
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x000430E4 File Offset: 0x000412E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 47854, RefRangeEnd = 47857, XrefRangeStart = 47843, XrefRangeEnd = 47854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InternalSetName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000D62 RID: 3426 RVA: 0x00043134 File Offset: 0x00041334
		// (set) Token: 0x06000D63 RID: 3427 RVA: 0x0004316C File Offset: 0x0004136C
		public unsafe string Path
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47857, XrefRangeEnd = 47859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Path_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000D64 RID: 3428 RVA: 0x000431B0 File Offset: 0x000413B0
		public unsafe string _Path
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47859, XrefRangeEnd = 47864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Path_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000D65 RID: 3429 RVA: 0x000431E8 File Offset: 0x000413E8
		public unsafe bool Plain
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00043224 File Offset: 0x00041424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47864, XrefRangeEnd = 47865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsDomainEqualToHost(string domain, string host)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(domain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(host);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00043278 File Offset: 0x00041478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 47942, RefRangeEnd = 47943, XrefRangeStart = 47865, XrefRangeEnd = 47942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref variant;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLocalDomain;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localDomain);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref set_default;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isThrow;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00043310 File Offset: 0x00041510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47943, XrefRangeEnd = 47945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DomainCharsTest(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00043354 File Offset: 0x00041554
		public unsafe string Port
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47945, XrefRangeEnd = 47969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Port_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00043398 File Offset: 0x00041598
		public unsafe Il2CppStructArray<int> PortList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06000D6B RID: 3435 RVA: 0x000433D8 File Offset: 0x000415D8
		public unsafe string _Port
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47969, XrefRangeEnd = 47973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Port_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00043410 File Offset: 0x00041610
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x0004344C File Offset: 0x0004164C
		public unsafe bool Secure
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x0004348C File Offset: 0x0004168C
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x000434C4 File Offset: 0x000416C4
		public unsafe string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47973, XrefRangeEnd = 47975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06000D70 RID: 3440 RVA: 0x00043508 File Offset: 0x00041708
		public unsafe CookieVariant Variant
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00043544 File Offset: 0x00041744
		public unsafe string DomainKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x0004357C File Offset: 0x0004177C
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x000435B8 File Offset: 0x000417B8
		public unsafe int Version
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 41028, RefRangeEnd = 41035, XrefRangeStart = 41028, XrefRangeEnd = 41035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get_Version_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x000435F8 File Offset: 0x000417F8
		public unsafe string _Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47975, XrefRangeEnd = 47979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_get__Version_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00043630 File Offset: 0x00041830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47979, XrefRangeEnd = 47983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IComparer GetComparer()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer>(intPtr3) : null;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00043664 File Offset: 0x00041864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47983, XrefRangeEnd = 47989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x000436B4 File Offset: 0x000418B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 47989, XrefRangeEnd = 48016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x000436F0 File Offset: 0x000418F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48016, XrefRangeEnd = 48092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cookie.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00007313 File Offset: 0x00005513
		public Cookie(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00043728 File Offset: 0x00041928
		// (set) Token: 0x06000D7B RID: 3451 RVA: 0x0000731C File Offset: 0x0000551C
		public unsafe static Il2CppStructArray<char> PortSplitDelimiters
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_PortSplitDelimiters, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_PortSplitDelimiters, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x00043750 File Offset: 0x00041950
		// (set) Token: 0x06000D7D RID: 3453 RVA: 0x0000732E File Offset: 0x0000552E
		public unsafe static Il2CppStructArray<char> Reserved2Name
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_Reserved2Name, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_Reserved2Name, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D7E RID: 3454 RVA: 0x00043778 File Offset: 0x00041978
		// (set) Token: 0x06000D7F RID: 3455 RVA: 0x00007340 File Offset: 0x00005540
		public unsafe static Il2CppStructArray<char> Reserved2Value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_Reserved2Value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_Reserved2Value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D80 RID: 3456 RVA: 0x000437A0 File Offset: 0x000419A0
		// (set) Token: 0x06000D81 RID: 3457 RVA: 0x00007352 File Offset: 0x00005552
		public unsafe static Comparer staticComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Cookie.NativeFieldInfoPtr_staticComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Cookie.NativeFieldInfoPtr_staticComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D82 RID: 3458 RVA: 0x000437C8 File Offset: 0x000419C8
		// (set) Token: 0x06000D83 RID: 3459 RVA: 0x00007364 File Offset: 0x00005564
		public unsafe string m_comment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_comment);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_comment), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D84 RID: 3460 RVA: 0x000437F0 File Offset: 0x000419F0
		// (set) Token: 0x06000D85 RID: 3461 RVA: 0x00007383 File Offset: 0x00005583
		public unsafe Uri m_commentUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_commentUri);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_commentUri), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D86 RID: 3462 RVA: 0x00043820 File Offset: 0x00041A20
		// (set) Token: 0x06000D87 RID: 3463 RVA: 0x000073A2 File Offset: 0x000055A2
		public unsafe CookieVariant m_cookieVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_cookieVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_cookieVariant)) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x00043848 File Offset: 0x00041A48
		// (set) Token: 0x06000D89 RID: 3465 RVA: 0x000073BD File Offset: 0x000055BD
		public unsafe bool m_discard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_discard);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_discard)) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D8A RID: 3466 RVA: 0x00043870 File Offset: 0x00041A70
		// (set) Token: 0x06000D8B RID: 3467 RVA: 0x000073D8 File Offset: 0x000055D8
		public unsafe string m_domain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D8C RID: 3468 RVA: 0x00043898 File Offset: 0x00041A98
		// (set) Token: 0x06000D8D RID: 3469 RVA: 0x000073F7 File Offset: 0x000055F7
		public unsafe bool m_domain_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domain_implicit)) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D8E RID: 3470 RVA: 0x000438C0 File Offset: 0x00041AC0
		// (set) Token: 0x06000D8F RID: 3471 RVA: 0x00007412 File Offset: 0x00005612
		public unsafe DateTime m_expires
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_expires);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_expires)) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D90 RID: 3472 RVA: 0x000438E8 File Offset: 0x00041AE8
		// (set) Token: 0x06000D91 RID: 3473 RVA: 0x0000742D File Offset: 0x0000562D
		public unsafe string m_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D92 RID: 3474 RVA: 0x00043910 File Offset: 0x00041B10
		// (set) Token: 0x06000D93 RID: 3475 RVA: 0x0000744C File Offset: 0x0000564C
		public unsafe string m_path
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x00043938 File Offset: 0x00041B38
		// (set) Token: 0x06000D95 RID: 3477 RVA: 0x0000746B File Offset: 0x0000566B
		public unsafe bool m_path_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_path_implicit)) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D96 RID: 3478 RVA: 0x00043960 File Offset: 0x00041B60
		// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00007486 File Offset: 0x00005686
		public unsafe string m_port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x00043988 File Offset: 0x00041B88
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000074A5 File Offset: 0x000056A5
		public unsafe bool m_port_implicit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_implicit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_implicit)) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000439B0 File Offset: 0x00041BB0
		// (set) Token: 0x06000D9B RID: 3483 RVA: 0x000074C0 File Offset: 0x000056C0
		public unsafe Il2CppStructArray<int> m_port_list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_port_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000439E0 File Offset: 0x00041BE0
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000074DF File Offset: 0x000056DF
		public unsafe bool m_secure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_secure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_secure)) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x00043A08 File Offset: 0x00041C08
		// (set) Token: 0x06000D9F RID: 3487 RVA: 0x000074FA File Offset: 0x000056FA
		public unsafe bool m_httpOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_httpOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_httpOnly)) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00043A30 File Offset: 0x00041C30
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x00007515 File Offset: 0x00005715
		public unsafe DateTime m_timeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_timeStamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_timeStamp)) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00043A58 File Offset: 0x00041C58
		// (set) Token: 0x06000DA3 RID: 3491 RVA: 0x00007530 File Offset: 0x00005730
		public unsafe string m_value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00043A80 File Offset: 0x00041C80
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x0000754F File Offset: 0x0000574F
		public unsafe int m_version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_version)) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00043AA8 File Offset: 0x00041CA8
		// (set) Token: 0x06000DA7 RID: 3495 RVA: 0x0000756A File Offset: 0x0000576A
		public unsafe string m_domainKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domainKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_m_domainKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000DA8 RID: 3496 RVA: 0x00043AD0 File Offset: 0x00041CD0
		// (set) Token: 0x06000DA9 RID: 3497 RVA: 0x00007589 File Offset: 0x00005789
		public unsafe bool IsQuotedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedVersion)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00043AF8 File Offset: 0x00041CF8
		// (set) Token: 0x06000DAB RID: 3499 RVA: 0x000075A4 File Offset: 0x000057A4
		public unsafe bool IsQuotedDomain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedDomain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cookie.NativeFieldInfoPtr_IsQuotedDomain)) = value;
			}
		}

		// Token: 0x04000A8E RID: 2702
		private static readonly IntPtr NativeFieldInfoPtr_PortSplitDelimiters;

		// Token: 0x04000A8F RID: 2703
		private static readonly IntPtr NativeFieldInfoPtr_Reserved2Name;

		// Token: 0x04000A90 RID: 2704
		private static readonly IntPtr NativeFieldInfoPtr_Reserved2Value;

		// Token: 0x04000A91 RID: 2705
		private static readonly IntPtr NativeFieldInfoPtr_staticComparer;

		// Token: 0x04000A92 RID: 2706
		private static readonly IntPtr NativeFieldInfoPtr_m_comment;

		// Token: 0x04000A93 RID: 2707
		private static readonly IntPtr NativeFieldInfoPtr_m_commentUri;

		// Token: 0x04000A94 RID: 2708
		private static readonly IntPtr NativeFieldInfoPtr_m_cookieVariant;

		// Token: 0x04000A95 RID: 2709
		private static readonly IntPtr NativeFieldInfoPtr_m_discard;

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeFieldInfoPtr_m_domain;

		// Token: 0x04000A97 RID: 2711
		private static readonly IntPtr NativeFieldInfoPtr_m_domain_implicit;

		// Token: 0x04000A98 RID: 2712
		private static readonly IntPtr NativeFieldInfoPtr_m_expires;

		// Token: 0x04000A99 RID: 2713
		private static readonly IntPtr NativeFieldInfoPtr_m_name;

		// Token: 0x04000A9A RID: 2714
		private static readonly IntPtr NativeFieldInfoPtr_m_path;

		// Token: 0x04000A9B RID: 2715
		private static readonly IntPtr NativeFieldInfoPtr_m_path_implicit;

		// Token: 0x04000A9C RID: 2716
		private static readonly IntPtr NativeFieldInfoPtr_m_port;

		// Token: 0x04000A9D RID: 2717
		private static readonly IntPtr NativeFieldInfoPtr_m_port_implicit;

		// Token: 0x04000A9E RID: 2718
		private static readonly IntPtr NativeFieldInfoPtr_m_port_list;

		// Token: 0x04000A9F RID: 2719
		private static readonly IntPtr NativeFieldInfoPtr_m_secure;

		// Token: 0x04000AA0 RID: 2720
		private static readonly IntPtr NativeFieldInfoPtr_m_httpOnly;

		// Token: 0x04000AA1 RID: 2721
		private static readonly IntPtr NativeFieldInfoPtr_m_timeStamp;

		// Token: 0x04000AA2 RID: 2722
		private static readonly IntPtr NativeFieldInfoPtr_m_value;

		// Token: 0x04000AA3 RID: 2723
		private static readonly IntPtr NativeFieldInfoPtr_m_version;

		// Token: 0x04000AA4 RID: 2724
		private static readonly IntPtr NativeFieldInfoPtr_m_domainKey;

		// Token: 0x04000AA5 RID: 2725
		private static readonly IntPtr NativeFieldInfoPtr_IsQuotedVersion;

		// Token: 0x04000AA6 RID: 2726
		private static readonly IntPtr NativeFieldInfoPtr_IsQuotedDomain;

		// Token: 0x04000AA7 RID: 2727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000AA8 RID: 2728
		private static readonly IntPtr NativeMethodInfoPtr_get_Comment_Public_get_String_0;

		// Token: 0x04000AA9 RID: 2729
		private static readonly IntPtr NativeMethodInfoPtr_set_Comment_Public_set_Void_String_0;

		// Token: 0x04000AAA RID: 2730
		private static readonly IntPtr NativeMethodInfoPtr_set_CommentUri_Public_set_Void_Uri_0;

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeMethodInfoPtr_set_HttpOnly_Public_set_Void_Boolean_0;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeMethodInfoPtr_set_Discard_Public_set_Void_Boolean_0;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr_get_Domain_Public_get_String_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_set_Domain_Public_set_Void_String_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_get__Domain_Private_get_String_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_get_Expired_Public_get_Boolean_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_set_Expires_Public_set_Void_DateTime_0;

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetName_Internal_Boolean_String_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_set_Path_Public_set_Void_String_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get__Path_Private_get_String_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_get_Plain_Internal_get_Boolean_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_IsDomainEqualToHost_Private_Static_Boolean_String_String_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_VerifySetDefaults_Internal_Boolean_CookieVariant_Uri_Boolean_String_Boolean_Boolean_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_DomainCharsTest_Private_Static_Boolean_String_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_set_Port_Public_set_Void_String_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_get_PortList_Internal_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_get__Port_Private_get_String_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_get_Secure_Public_get_Boolean_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_set_Secure_Public_set_Void_Boolean_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_get_Variant_Internal_get_CookieVariant_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_get_DomainKey_Internal_get_String_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_get_Int32_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_set_Version_Public_set_Void_Int32_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_get__Version_Private_get_String_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_GetComparer_Internal_Static_IComparer_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
