using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem
{
	// Token: 0x02000039 RID: 57
	public class UriParser : Object
	{
		// Token: 0x06000345 RID: 837 RVA: 0x0001DD04 File Offset: 0x0001BF04
		// Note: this type is marked as 'beforefieldinit'.
		static UriParser()
		{
			Il2CppClassPointerStore<UriParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "UriParser");
			UriParser.NativeFieldInfoPtr_m_Table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Table");
			UriParser.NativeFieldInfoPtr_m_TempTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_TempTable");
			UriParser.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Flags");
			UriParser.NativeFieldInfoPtr_m_UpdatableFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlags");
			UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_UpdatableFlagsUsed");
			UriParser.NativeFieldInfoPtr_m_Port = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Port");
			UriParser.NativeFieldInfoPtr_m_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "m_Scheme");
			UriParser.NativeFieldInfoPtr_HttpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpUri");
			UriParser.NativeFieldInfoPtr_HttpsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpsUri");
			UriParser.NativeFieldInfoPtr_WsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WsUri");
			UriParser.NativeFieldInfoPtr_WssUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "WssUri");
			UriParser.NativeFieldInfoPtr_FtpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FtpUri");
			UriParser.NativeFieldInfoPtr_FileUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileUri");
			UriParser.NativeFieldInfoPtr_GopherUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "GopherUri");
			UriParser.NativeFieldInfoPtr_NntpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NntpUri");
			UriParser.NativeFieldInfoPtr_NewsUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NewsUri");
			UriParser.NativeFieldInfoPtr_MailToUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "MailToUri");
			UriParser.NativeFieldInfoPtr_UuidUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "UuidUri");
			UriParser.NativeFieldInfoPtr_TelnetUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "TelnetUri");
			UriParser.NativeFieldInfoPtr_LdapUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "LdapUri");
			UriParser.NativeFieldInfoPtr_NetTcpUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetTcpUri");
			UriParser.NativeFieldInfoPtr_NetPipeUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "NetPipeUri");
			UriParser.NativeFieldInfoPtr_VsMacrosUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "VsMacrosUri");
			UriParser.NativeFieldInfoPtr_s_QuirksVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "s_QuirksVersion");
			UriParser.NativeFieldInfoPtr_HttpSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "HttpSyntaxFlags");
			UriParser.NativeFieldInfoPtr_FileSyntaxFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "FileSyntaxFlags");
			UriParser.NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663837);
			UriParser.NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663838);
			UriParser.NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663839);
			UriParser.NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663840);
			UriParser.NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663841);
			UriParser.NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663842);
			UriParser.NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663843);
			UriParser.NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663845);
			UriParser.NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663846);
			UriParser.NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663847);
			UriParser.NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663848);
			UriParser.NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663849);
			UriParser.NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663850);
			UriParser.NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663851);
			UriParser.NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663852);
			UriParser.NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663853);
			UriParser.NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663854);
			UriParser.NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663855);
			UriParser.NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663856);
			UriParser.NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser>.NativeClassPtr, 100663857);
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0001E0C4 File Offset: 0x0001C2C4
		public unsafe string SchemeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0001E0FC File Offset: 0x0001C2FC
		public unsafe int DefaultPort
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001E138 File Offset: 0x0001C338
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UriParser OnNewUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001E184 File Offset: 0x0001C384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36634, XrefRangeEnd = 36635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001E1F4 File Offset: 0x0001C3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36635, XrefRangeEnd = 36644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0001E27C File Offset: 0x0001C47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36644, XrefRangeEnd = 36686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetComponents(Uri uri, UriComponents components, UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref components;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UriParser.NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001E2EC File Offset: 0x0001C4EC
		public unsafe static bool ShouldUseLegacyV2Quirks
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 36690, RefRangeEnd = 36697, XrefRangeStart = 36686, XrefRangeEnd = 36690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0001E31C File Offset: 0x0001C51C
		public unsafe UriSyntaxFlags Flags
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0001E358 File Offset: 0x0001C558
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36700, RefRangeEnd = 36703, XrefRangeStart = 36697, XrefRangeEnd = 36700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool NotAny(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0001E3A4 File Offset: 0x0001C5A4
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 36706, RefRangeEnd = 36741, XrefRangeStart = 36703, XrefRangeEnd = 36706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool InFact(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0001E3F0 File Offset: 0x0001C5F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36744, RefRangeEnd = 36745, XrefRangeStart = 36741, XrefRangeEnd = 36744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllSet(UriSyntaxFlags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0001E43C File Offset: 0x0001C63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36745, XrefRangeEnd = 36748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expected;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0001E494 File Offset: 0x0001C694
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36751, RefRangeEnd = 36752, XrefRangeStart = 36748, XrefRangeEnd = 36751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriParser(UriSyntaxFlags flags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0001E4DC File Offset: 0x0001C6DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36795, RefRangeEnd = 36796, XrefRangeStart = 36752, XrefRangeEnd = 36795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0001E520 File Offset: 0x0001C720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36796, XrefRangeEnd = 36808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriParser GetSyntax(string lwrCaseScheme)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0001E564 File Offset: 0x0001C764
		public unsafe bool IsSimple
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 36808, RefRangeEnd = 36818, XrefRangeStart = 36808, XrefRangeEnd = 36808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0001E5A0 File Offset: 0x0001C7A0
		[CallerCount(0)]
		public unsafe UriParser InternalOnNewUri()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0001E5E0 File Offset: 0x0001C7E0
		[CallerCount(0)]
		public unsafe void InternalValidate(Uri thisUri, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisUri);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0001E644 File Offset: 0x0001C844
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36818, RefRangeEnd = 36820, XrefRangeStart = 36818, XrefRangeEnd = 36818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisBaseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriLink);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			parsingError = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0001E6C4 File Offset: 0x0001C8C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36820, RefRangeEnd = 36823, XrefRangeStart = 36820, XrefRangeEnd = 36820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriComponents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00003209 File Offset: 0x00001409
		public UriParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001E728 File Offset: 0x0001C928
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00003212 File Offset: 0x00001412
		public unsafe static Dictionary<string, UriParser> m_Table
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_m_Table, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_m_Table, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0001E750 File Offset: 0x0001C950
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00003224 File Offset: 0x00001424
		public unsafe static Dictionary<string, UriParser> m_TempTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_m_TempTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, UriParser>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_m_TempTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0001E778 File Offset: 0x0001C978
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00003236 File Offset: 0x00001436
		public unsafe UriSyntaxFlags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0001E7A0 File Offset: 0x0001C9A0
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00003251 File Offset: 0x00001451
		public unsafe UriSyntaxFlags m_UpdatableFlags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlags)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0001E7C8 File Offset: 0x0001C9C8
		// (set) Token: 0x06000364 RID: 868 RVA: 0x0000326C File Offset: 0x0000146C
		public unsafe bool m_UpdatableFlagsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_UpdatableFlagsUsed)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000365 RID: 869 RVA: 0x0001E7F0 File Offset: 0x0001C9F0
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00003287 File Offset: 0x00001487
		public unsafe int m_Port
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Port);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Port)) = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0001E818 File Offset: 0x0001CA18
		// (set) Token: 0x06000368 RID: 872 RVA: 0x000032A2 File Offset: 0x000014A2
		public unsafe string m_Scheme
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Scheme);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UriParser.NativeFieldInfoPtr_m_Scheme), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0001E840 File Offset: 0x0001CA40
		// (set) Token: 0x0600036A RID: 874 RVA: 0x000032C1 File Offset: 0x000014C1
		public unsafe static UriParser HttpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0001E868 File Offset: 0x0001CA68
		// (set) Token: 0x0600036C RID: 876 RVA: 0x000032D3 File Offset: 0x000014D3
		public unsafe static UriParser HttpsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0001E890 File Offset: 0x0001CA90
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000032E5 File Offset: 0x000014E5
		public unsafe static UriParser WsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_WsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_WsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0001E8B8 File Offset: 0x0001CAB8
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000032F7 File Offset: 0x000014F7
		public unsafe static UriParser WssUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_WssUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_WssUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0001E8E0 File Offset: 0x0001CAE0
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00003309 File Offset: 0x00001509
		public unsafe static UriParser FtpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FtpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FtpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000373 RID: 883 RVA: 0x0001E908 File Offset: 0x0001CB08
		// (set) Token: 0x06000374 RID: 884 RVA: 0x0000331B File Offset: 0x0000151B
		public unsafe static UriParser FileUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FileUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FileUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000375 RID: 885 RVA: 0x0001E930 File Offset: 0x0001CB30
		// (set) Token: 0x06000376 RID: 886 RVA: 0x0000332D File Offset: 0x0000152D
		public unsafe static UriParser GopherUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_GopherUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_GopherUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001E958 File Offset: 0x0001CB58
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0000333F File Offset: 0x0000153F
		public unsafe static UriParser NntpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NntpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NntpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001E980 File Offset: 0x0001CB80
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00003351 File Offset: 0x00001551
		public unsafe static UriParser NewsUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NewsUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NewsUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0001E9A8 File Offset: 0x0001CBA8
		// (set) Token: 0x0600037C RID: 892 RVA: 0x00003363 File Offset: 0x00001563
		public unsafe static UriParser MailToUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_MailToUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_MailToUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600037D RID: 893 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
		// (set) Token: 0x0600037E RID: 894 RVA: 0x00003375 File Offset: 0x00001575
		public unsafe static UriParser UuidUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_UuidUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_UuidUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0001E9F8 File Offset: 0x0001CBF8
		// (set) Token: 0x06000380 RID: 896 RVA: 0x00003387 File Offset: 0x00001587
		public unsafe static UriParser TelnetUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_TelnetUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_TelnetUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0001EA20 File Offset: 0x0001CC20
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00003399 File Offset: 0x00001599
		public unsafe static UriParser LdapUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_LdapUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_LdapUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0001EA48 File Offset: 0x0001CC48
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000033AB File Offset: 0x000015AB
		public unsafe static UriParser NetTcpUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetTcpUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetTcpUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0001EA70 File Offset: 0x0001CC70
		// (set) Token: 0x06000386 RID: 902 RVA: 0x000033BD File Offset: 0x000015BD
		public unsafe static UriParser NetPipeUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_NetPipeUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_NetPipeUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0001EA98 File Offset: 0x0001CC98
		// (set) Token: 0x06000388 RID: 904 RVA: 0x000033CF File Offset: 0x000015CF
		public unsafe static UriParser VsMacrosUri
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_VsMacrosUri, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_VsMacrosUri, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0001EAC0 File Offset: 0x0001CCC0
		// (set) Token: 0x0600038A RID: 906 RVA: 0x000033E1 File Offset: 0x000015E1
		public unsafe static UriParser.UriQuirksVersion s_QuirksVersion
		{
			get
			{
				UriParser.UriQuirksVersion uriQuirksVersion;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_s_QuirksVersion, (void*)(&uriQuirksVersion));
				return uriQuirksVersion;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_s_QuirksVersion, (void*)(&value));
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600038B RID: 907 RVA: 0x0001EADC File Offset: 0x0001CCDC
		// (set) Token: 0x0600038C RID: 908 RVA: 0x000033EF File Offset: 0x000015EF
		public unsafe static UriSyntaxFlags HttpSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_HttpSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600038D RID: 909 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		// (set) Token: 0x0600038E RID: 910 RVA: 0x000033FD File Offset: 0x000015FD
		public unsafe static UriSyntaxFlags FileSyntaxFlags
		{
			get
			{
				UriSyntaxFlags uriSyntaxFlags;
				IL2CPP.il2cpp_field_static_get_value(UriParser.NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&uriSyntaxFlags));
				return uriSyntaxFlags;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UriParser.NativeFieldInfoPtr_FileSyntaxFlags, (void*)(&value));
			}
		}

		// Token: 0x04000298 RID: 664
		private static readonly IntPtr NativeFieldInfoPtr_m_Table;

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeFieldInfoPtr_m_TempTable;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x0400029B RID: 667
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatableFlags;

		// Token: 0x0400029C RID: 668
		private static readonly IntPtr NativeFieldInfoPtr_m_UpdatableFlagsUsed;

		// Token: 0x0400029D RID: 669
		private static readonly IntPtr NativeFieldInfoPtr_m_Port;

		// Token: 0x0400029E RID: 670
		private static readonly IntPtr NativeFieldInfoPtr_m_Scheme;

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeFieldInfoPtr_HttpUri;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeFieldInfoPtr_HttpsUri;

		// Token: 0x040002A1 RID: 673
		private static readonly IntPtr NativeFieldInfoPtr_WsUri;

		// Token: 0x040002A2 RID: 674
		private static readonly IntPtr NativeFieldInfoPtr_WssUri;

		// Token: 0x040002A3 RID: 675
		private static readonly IntPtr NativeFieldInfoPtr_FtpUri;

		// Token: 0x040002A4 RID: 676
		private static readonly IntPtr NativeFieldInfoPtr_FileUri;

		// Token: 0x040002A5 RID: 677
		private static readonly IntPtr NativeFieldInfoPtr_GopherUri;

		// Token: 0x040002A6 RID: 678
		private static readonly IntPtr NativeFieldInfoPtr_NntpUri;

		// Token: 0x040002A7 RID: 679
		private static readonly IntPtr NativeFieldInfoPtr_NewsUri;

		// Token: 0x040002A8 RID: 680
		private static readonly IntPtr NativeFieldInfoPtr_MailToUri;

		// Token: 0x040002A9 RID: 681
		private static readonly IntPtr NativeFieldInfoPtr_UuidUri;

		// Token: 0x040002AA RID: 682
		private static readonly IntPtr NativeFieldInfoPtr_TelnetUri;

		// Token: 0x040002AB RID: 683
		private static readonly IntPtr NativeFieldInfoPtr_LdapUri;

		// Token: 0x040002AC RID: 684
		private static readonly IntPtr NativeFieldInfoPtr_NetTcpUri;

		// Token: 0x040002AD RID: 685
		private static readonly IntPtr NativeFieldInfoPtr_NetPipeUri;

		// Token: 0x040002AE RID: 686
		private static readonly IntPtr NativeFieldInfoPtr_VsMacrosUri;

		// Token: 0x040002AF RID: 687
		private static readonly IntPtr NativeFieldInfoPtr_s_QuirksVersion;

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_HttpSyntaxFlags;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_FileSyntaxFlags;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemeName_Internal_get_String_0;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPort_Internal_get_Int32_0;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeMethodInfoPtr_OnNewUri_Protected_Virtual_New_UriParser_0;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeMethodInfoPtr_InitializeAndValidate_Protected_Virtual_New_Void_Uri_byref_UriFormatException_0;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Protected_Virtual_New_String_Uri_Uri_byref_UriFormatException_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Protected_Virtual_New_String_Uri_UriComponents_UriFormat_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldUseLegacyV2Quirks_Internal_Static_get_Boolean_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_Flags_Internal_get_UriSyntaxFlags_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_NotAny_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_InFact_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr_IsAllSet_Internal_Boolean_UriSyntaxFlags_0;

		// Token: 0x040002BD RID: 701
		private static readonly IntPtr NativeMethodInfoPtr_IsFullMatch_Private_Boolean_UriSyntaxFlags_UriSyntaxFlags_0;

		// Token: 0x040002BE RID: 702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UriSyntaxFlags_0;

		// Token: 0x040002BF RID: 703
		private static readonly IntPtr NativeMethodInfoPtr_FindOrFetchAsUnknownV1Syntax_Internal_Static_UriParser_String_0;

		// Token: 0x040002C0 RID: 704
		private static readonly IntPtr NativeMethodInfoPtr_GetSyntax_Internal_Static_UriParser_String_0;

		// Token: 0x040002C1 RID: 705
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSimple_Internal_get_Boolean_0;

		// Token: 0x040002C2 RID: 706
		private static readonly IntPtr NativeMethodInfoPtr_InternalOnNewUri_Internal_UriParser_0;

		// Token: 0x040002C3 RID: 707
		private static readonly IntPtr NativeMethodInfoPtr_InternalValidate_Internal_Void_Uri_byref_UriFormatException_0;

		// Token: 0x040002C4 RID: 708
		private static readonly IntPtr NativeMethodInfoPtr_InternalResolve_Internal_String_Uri_Uri_byref_UriFormatException_0;

		// Token: 0x040002C5 RID: 709
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetComponents_Internal_String_Uri_UriComponents_UriFormat_0;

		// Token: 0x0200018E RID: 398
		public enum UriQuirksVersion
		{
			// Token: 0x04001293 RID: 4755
			V2 = 2,
			// Token: 0x04001294 RID: 4756
			V3
		}

		// Token: 0x0200018F RID: 399
		public class BuiltInUriParser : UriParser
		{
			// Token: 0x0600173B RID: 5947 RVA: 0x0000C49C File Offset: 0x0000A69C
			// Note: this type is marked as 'beforefieldinit'.
			static BuiltInUriParser()
			{
				Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UriParser>.NativeClassPtr, "BuiltInUriParser");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr);
				UriParser.BuiltInUriParser.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr, 100663858);
			}

			// Token: 0x0600173C RID: 5948 RVA: 0x00064BE8 File Offset: 0x00062DE8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 36633, RefRangeEnd = 36634, XrefRangeStart = 36629, XrefRangeEnd = 36633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BuiltInUriParser(string lwrCaseScheme, int defaultPort, UriSyntaxFlags syntaxFlags)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UriParser.BuiltInUriParser>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(lwrCaseScheme);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultPort;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref syntaxFlags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UriParser.BuiltInUriParser.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600173D RID: 5949 RVA: 0x0000C4D0 File Offset: 0x0000A6D0
			public BuiltInUriParser(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001295 RID: 4757
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_UriSyntaxFlags_0;
		}
	}
}
