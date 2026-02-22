using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200002F RID: 47
	[Serializable]
	public class Uri : Object
	{
		// Token: 0x0600027F RID: 639 RVA: 0x0001A078 File Offset: 0x00018278
		// Note: this type is marked as 'beforefieldinit'.
		static Uri()
		{
			Il2CppClassPointerStore<Uri>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "Uri");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri>.NativeClassPtr);
			Uri.NativeFieldInfoPtr_UriSchemeFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFile");
			Uri.NativeFieldInfoPtr_UriSchemeFtp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeFtp");
			Uri.NativeFieldInfoPtr_UriSchemeGopher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeGopher");
			Uri.NativeFieldInfoPtr_UriSchemeHttp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttp");
			Uri.NativeFieldInfoPtr_UriSchemeHttps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeHttps");
			Uri.NativeFieldInfoPtr_UriSchemeWs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWs");
			Uri.NativeFieldInfoPtr_UriSchemeWss = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeWss");
			Uri.NativeFieldInfoPtr_UriSchemeMailto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeMailto");
			Uri.NativeFieldInfoPtr_UriSchemeNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNews");
			Uri.NativeFieldInfoPtr_UriSchemeNntp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNntp");
			Uri.NativeFieldInfoPtr_UriSchemeNetTcp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetTcp");
			Uri.NativeFieldInfoPtr_UriSchemeNetPipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriSchemeNetPipe");
			Uri.NativeFieldInfoPtr_SchemeDelimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "SchemeDelimiter");
			Uri.NativeFieldInfoPtr_m_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_String");
			Uri.NativeFieldInfoPtr_m_originalUnicodeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_originalUnicodeString");
			Uri.NativeFieldInfoPtr_m_Syntax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Syntax");
			Uri.NativeFieldInfoPtr_m_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_DnsSafeHost");
			Uri.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Flags");
			Uri.NativeFieldInfoPtr_m_Info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_Info");
			Uri.NativeFieldInfoPtr_m_iriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "m_iriParsing");
			Uri.NativeFieldInfoPtr_s_ConfigInitialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitialized");
			Uri.NativeFieldInfoPtr_s_ConfigInitializing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_ConfigInitializing");
			Uri.NativeFieldInfoPtr_s_IdnScope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IdnScope");
			Uri.NativeFieldInfoPtr_s_IriParsing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_IriParsing");
			Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "useDotNetRelativeOrAbsolute");
			Uri.NativeFieldInfoPtr_IsWindowsFileSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "IsWindowsFileSystem");
			Uri.NativeFieldInfoPtr_s_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "s_initLock");
			Uri.NativeFieldInfoPtr_HexLowerChars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "HexLowerChars");
			Uri.NativeFieldInfoPtr__WSchars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri>.NativeClassPtr, "_WSchars");
			Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663701);
			Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663702);
			Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663703);
			Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663704);
			Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663705);
			Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663706);
			Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663707);
			Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663708);
			Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663709);
			Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663710);
			Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663711);
			Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663712);
			Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663713);
			Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663714);
			Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663715);
			Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663716);
			Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663717);
			Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663718);
			Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663719);
			Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663720);
			Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663721);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663722);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663723);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663724);
			Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663725);
			Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663726);
			Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663727);
			Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663728);
			Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663729);
			Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663730);
			Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663731);
			Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663732);
			Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663733);
			Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663734);
			Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663735);
			Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663736);
			Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663737);
			Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663738);
			Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663739);
			Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663740);
			Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663741);
			Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663742);
			Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663743);
			Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663744);
			Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663745);
			Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663746);
			Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663747);
			Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663748);
			Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663749);
			Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663750);
			Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663751);
			Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663752);
			Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663753);
			Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663754);
			Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663755);
			Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663756);
			Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663757);
			Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663758);
			Uri.NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663759);
			Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663760);
			Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663761);
			Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663762);
			Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663763);
			Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663764);
			Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663765);
			Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663766);
			Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663767);
			Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663768);
			Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663769);
			Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663770);
			Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663771);
			Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663772);
			Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663773);
			Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663774);
			Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663775);
			Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663776);
			Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663777);
			Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663778);
			Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663779);
			Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663780);
			Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663781);
			Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663782);
			Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663783);
			Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663784);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663785);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663786);
			Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663787);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663788);
			Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663789);
			Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663790);
			Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663791);
			Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663792);
			Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663793);
			Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663794);
			Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663795);
			Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663796);
			Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663797);
			Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663798);
			Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663799);
			Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663800);
			Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663801);
			Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663802);
			Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663803);
			Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663804);
			Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663805);
			Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663806);
			Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663807);
			Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663808);
			Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663809);
			Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663810);
			Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663811);
			Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663812);
			Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663813);
			Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663814);
			Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663815);
			Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663816);
			Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri>.NativeClassPtr, 100663817);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000280 RID: 640 RVA: 0x0001AC10 File Offset: 0x00018E10
		public unsafe bool IsImplicitFile
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000281 RID: 641 RVA: 0x0001AC4C File Offset: 0x00018E4C
		public unsafe bool IsUncOrDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001AC88 File Offset: 0x00018E88
		public unsafe bool IsDosPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000283 RID: 643 RVA: 0x0001ACC4 File Offset: 0x00018EC4
		public unsafe bool IsUncPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000284 RID: 644 RVA: 0x0001AD00 File Offset: 0x00018F00
		public unsafe Uri.Flags HostType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostType_Private_get_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000285 RID: 645 RVA: 0x0001AD3C File Offset: 0x00018F3C
		public unsafe UriParser Syntax
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr3) : null;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000286 RID: 646 RVA: 0x0001AD7C File Offset: 0x00018F7C
		public unsafe bool IsNotAbsoluteUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34869, RefRangeEnd = 34870, XrefRangeStart = 34864, XrefRangeEnd = 34869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IriParsingStatic(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0001ADFC File Offset: 0x00018FFC
		public unsafe bool AllowIdn
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 34875, RefRangeEnd = 34883, XrefRangeStart = 34870, XrefRangeEnd = 34875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001AE38 File Offset: 0x00019038
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 34888, RefRangeEnd = 34892, XrefRangeStart = 34883, XrefRangeEnd = 34888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AllowIdnStatic(UriParser syntax, Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001AE94 File Offset: 0x00019094
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsIntranet(string schemeHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeHost);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0001AEE4 File Offset: 0x000190E4
		public unsafe bool UserDrivenParsing
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 34892, RefRangeEnd = 34894, XrefRangeStart = 34892, XrefRangeEnd = 34892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x0001AF20 File Offset: 0x00019120
		[CallerCount(0)]
		public unsafe void SetUserDrivenParsing()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600028D RID: 653 RVA: 0x0001AF54 File Offset: 0x00019154
		public unsafe ushort SecuredPathIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001AF90 File Offset: 0x00019190
		[CallerCount(0)]
		public unsafe bool NotAny(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001AFDC File Offset: 0x000191DC
		[CallerCount(0)]
		public unsafe bool InFact(Uri.Flags flags)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001B028 File Offset: 0x00019228
		[CallerCount(0)]
		public unsafe static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001B074 File Offset: 0x00019274
		[CallerCount(0)]
		public unsafe static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allFlags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001B0C0 File Offset: 0x000192C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34894, XrefRangeEnd = 34895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.UriInfo EnsureUriInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr3) : null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001B100 File Offset: 0x00019300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34895, XrefRangeEnd = 34896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001B134 File Offset: 0x00019334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34896, XrefRangeEnd = 34898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureHostString(bool allowDnsOptimization)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref allowDnsOptimization;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001B174 File Offset: 0x00019374
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 34905, RefRangeEnd = 34915, XrefRangeStart = 34898, XrefRangeEnd = 34905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001B1C0 File Offset: 0x000193C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 34917, RefRangeEnd = 34920, XrefRangeStart = 34915, XrefRangeEnd = 34917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(string uriString, UriKind uriKind)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001B21C File Offset: 0x0001941C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 34922, RefRangeEnd = 34926, XrefRangeStart = 34920, XrefRangeEnd = 34922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, string relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001B27C File Offset: 0x0001947C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34951, RefRangeEnd = 34952, XrefRangeStart = 34926, XrefRangeEnd = 34951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001B2E0 File Offset: 0x000194E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34964, RefRangeEnd = 34965, XrefRangeStart = 34952, XrefRangeEnd = 34964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri baseUri, Uri relativeUri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001B340 File Offset: 0x00019540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34965, XrefRangeEnd = 34985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativeStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(result);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			result = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001B3C4 File Offset: 0x000195C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 34997, RefRangeEnd = 34999, XrefRangeStart = 34985, XrefRangeEnd = 34997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UriFormatException GetException(ParsingError err)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001B404 File Offset: 0x00019604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 34999, XrefRangeEnd = 35019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001B468 File Offset: 0x00019668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35019, XrefRangeEnd = 35032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001B4C4 File Offset: 0x000196C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializationInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(streamingContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0001B520 File Offset: 0x00019720
		public unsafe string AbsolutePath
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 35040, RefRangeEnd = 35045, XrefRangeStart = 35032, XrefRangeEnd = 35040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0001B558 File Offset: 0x00019758
		public unsafe string PrivateAbsolutePath
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35045, XrefRangeEnd = 35051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0001B590 File Offset: 0x00019790
		public unsafe string AbsoluteUri
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 35057, RefRangeEnd = 35062, XrefRangeStart = 35051, XrefRangeEnd = 35057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001B5C8 File Offset: 0x000197C8
		public unsafe string LocalPath
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 35070, RefRangeEnd = 35077, XrefRangeStart = 35062, XrefRangeEnd = 35070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_LocalPath_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x0001B600 File Offset: 0x00019800
		public unsafe string Authority
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 35085, RefRangeEnd = 35091, XrefRangeStart = 35077, XrefRangeEnd = 35085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Authority_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0001B638 File Offset: 0x00019838
		public unsafe UriHostNameType HostNameType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 35096, RefRangeEnd = 35099, XrefRangeStart = 35091, XrefRangeEnd = 35096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x0001B674 File Offset: 0x00019874
		public unsafe bool IsDefaultPort
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35102, RefRangeEnd = 35103, XrefRangeStart = 35099, XrefRangeEnd = 35102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0001B6B0 File Offset: 0x000198B0
		public unsafe bool IsFile
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35107, RefRangeEnd = 35108, XrefRangeStart = 35103, XrefRangeEnd = 35107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001B6EC File Offset: 0x000198EC
		public unsafe bool IsLoopback
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35110, RefRangeEnd = 35111, XrefRangeStart = 35108, XrefRangeEnd = 35110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0001B728 File Offset: 0x00019928
		public unsafe string PathAndQuery
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 35114, RefRangeEnd = 35122, XrefRangeStart = 35111, XrefRangeEnd = 35114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x0001B760 File Offset: 0x00019960
		public unsafe bool IsUnc
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0001B79C File Offset: 0x0001999C
		public unsafe string Host
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 35130, RefRangeEnd = 35147, XrefRangeStart = 35122, XrefRangeEnd = 35130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Host_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001B7D4 File Offset: 0x000199D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35147, XrefRangeEnd = 35149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool StaticIsFile(UriParser syntax)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0001B818 File Offset: 0x00019A18
		public unsafe static Object InitializeLock
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35149, XrefRangeEnd = 35164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001B84C File Offset: 0x00019A4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35204, RefRangeEnd = 35205, XrefRangeStart = 35164, XrefRangeEnd = 35204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeUriConfig()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0001B874 File Offset: 0x00019A74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35233, RefRangeEnd = 35234, XrefRangeStart = 35205, XrefRangeEnd = 35233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLocalPath()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetLocalPath_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002AF RID: 687 RVA: 0x0001B8AC File Offset: 0x00019AAC
		public unsafe int Port
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 35239, RefRangeEnd = 35247, XrefRangeStart = 35234, XrefRangeEnd = 35239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Port_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0001B8E8 File Offset: 0x00019AE8
		public unsafe string Query
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35253, RefRangeEnd = 35255, XrefRangeStart = 35247, XrefRangeEnd = 35253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Query_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001B920 File Offset: 0x00019B20
		public unsafe string Fragment
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 35261, RefRangeEnd = 35264, XrefRangeStart = 35255, XrefRangeEnd = 35261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Fragment_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0001B958 File Offset: 0x00019B58
		public unsafe string Scheme
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 35264, RefRangeEnd = 35286, XrefRangeStart = 35264, XrefRangeEnd = 35264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_Scheme_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0001B990 File Offset: 0x00019B90
		public unsafe bool OriginalStringSwitched
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35286, XrefRangeEnd = 35287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0001B9CC File Offset: 0x00019BCC
		public unsafe string OriginalString
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 35288, RefRangeEnd = 35299, XrefRangeStart = 35287, XrefRangeEnd = 35288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_OriginalString_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001BA04 File Offset: 0x00019C04
		public unsafe string DnsSafeHost
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35299, XrefRangeEnd = 35304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001BA3C File Offset: 0x00019C3C
		public unsafe bool IsAbsoluteUri
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 35304, RefRangeEnd = 35309, XrefRangeStart = 35304, XrefRangeEnd = 35304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001BA78 File Offset: 0x00019C78
		public unsafe bool UserEscaped
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001BAB4 File Offset: 0x00019CB4
		public unsafe string UserInfo
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35317, RefRangeEnd = 35319, XrefRangeStart = 35309, XrefRangeEnd = 35317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_UserInfo_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001BAEC File Offset: 0x00019CEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35319, RefRangeEnd = 35320, XrefRangeStart = 35319, XrefRangeEnd = 35319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsGenDelim(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001BB2C File Offset: 0x00019D2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35331, RefRangeEnd = 35332, XrefRangeStart = 35320, XrefRangeEnd = 35331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckSchemeName(string schemeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(schemeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0001BB70 File Offset: 0x00019D70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35332, RefRangeEnd = 35333, XrefRangeStart = 35332, XrefRangeEnd = 35332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHexDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0001BBB0 File Offset: 0x00019DB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35333, RefRangeEnd = 35334, XrefRangeStart = 35333, XrefRangeEnd = 35333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int FromHex(char digit)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref digit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0001BBF0 File Offset: 0x00019DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35334, XrefRangeEnd = 35344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0001BC38 File Offset: 0x00019E38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35344, XrefRangeEnd = 35349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x0001BC7C File Offset: 0x00019E7C
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 35349, RefRangeEnd = 35373, XrefRangeStart = 35349, XrefRangeEnd = 35349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0001BCD0 File Offset: 0x00019ED0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 35373, RefRangeEnd = 35382, XrefRangeStart = 35373, XrefRangeEnd = 35373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(Uri uri1, Uri uri2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uri2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001BD24 File Offset: 0x00019F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35382, XrefRangeEnd = 35407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object comparand)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(comparand);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Uri.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0001BD7C File Offset: 0x00019F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35413, RefRangeEnd = 35414, XrefRangeStart = 35407, XrefRangeEnd = 35413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string InternalEscapeString(string rawString)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0001BDB8 File Offset: 0x00019FB8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 35419, RefRangeEnd = 35425, XrefRangeStart = 35414, XrefRangeEnd = 35419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0001BE30 File Offset: 0x0001A030
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35430, RefRangeEnd = 35431, XrefRangeStart = 35425, XrefRangeEnd = 35430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UriFormatException ParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UriFormatException>(intPtr3) : null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0001BE70 File Offset: 0x0001A070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35456, RefRangeEnd = 35457, XrefRangeStart = 35431, XrefRangeEnd = 35456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParsingError PrivateParseMinimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0001BEAC File Offset: 0x0001A0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35457, XrefRangeEnd = 35461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PrivateParseMinimalIri(string newHost, ushort idx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001BEFC File Offset: 0x0001A0FC
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 35497, RefRangeEnd = 35520, XrefRangeStart = 35461, XrefRangeEnd = 35497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUriInfo(Uri.Flags cF)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cF;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0001BF3C File Offset: 0x0001A13C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 35546, RefRangeEnd = 35555, XrefRangeStart = 35520, XrefRangeEnd = 35546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateHostString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0001BF70 File Offset: 0x0001A170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35564, RefRangeEnd = 35566, XrefRangeStart = 35555, XrefRangeEnd = 35564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(scopeId);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			scopeId = IL2CPP.Il2CppStringToManaged(intPtr);
			return IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35581, RefRangeEnd = 35582, XrefRangeStart = 35566, XrefRangeEnd = 35581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetHostViaCustomSyntax()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0001C030 File Offset: 0x0001A230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35582, XrefRangeEnd = 35583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0001C084 File Offset: 0x0001A284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35583, XrefRangeEnd = 35587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetEscapedParts(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0001C0C8 File Offset: 0x0001A2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35591, RefRangeEnd = 35592, XrefRangeStart = 35587, XrefRangeEnd = 35591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0001C11C File Offset: 0x0001A31C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35654, RefRangeEnd = 35656, XrefRangeStart = 35592, XrefRangeEnd = 35654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref parts;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nonCanonical;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0001C17C File Offset: 0x0001A37C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35660, RefRangeEnd = 35662, XrefRangeStart = 35656, XrefRangeEnd = 35660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetUriPartsFromUserString(UriComponents uriParts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriParts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0001C1C0 File Offset: 0x0001A3C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 35739, RefRangeEnd = 35742, XrefRangeStart = 35662, XrefRangeEnd = 35739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseRemaining()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseRemaining_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0001C1F4 File Offset: 0x0001A3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 35756, RefRangeEnd = 35758, XrefRangeStart = 35742, XrefRangeEnd = 35756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = uriString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0001C288 File Offset: 0x0001A488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35815, RefRangeEnd = 35816, XrefRangeStart = 35758, XrefRangeEnd = 35815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = lptr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nChars;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0001C2FC File Offset: 0x0001A4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35822, RefRangeEnd = 35823, XrefRangeStart = 35816, XrefRangeEnd = 35822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ref IntPtr ptr3 = ref ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr3 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0, 0, (void**)ptr2, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			syntax = ((intPtr4 == 0) ? null : new UriParser(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0001C370 File Offset: 0x0001A570
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35937, RefRangeEnd = 35938, XrefRangeStart = 35823, XrefRangeEnd = 35937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0001C428 File Offset: 0x0001A628
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 35983, RefRangeEnd = 35984, XrefRangeStart = 35938, XrefRangeEnd = 35983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userInfoString);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &justNormalized;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0001C524 File Offset: 0x0001A724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 35984, XrefRangeEnd = 36001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pString;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startInput;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref iriParsing;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasUnicode;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flags;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newHost);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &err;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			newHost = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0001C5EC File Offset: 0x0001A7EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36003, RefRangeEnd = 36005, XrefRangeStart = 36001, XrefRangeEnd = 36003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0001C658 File Offset: 0x0001A858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36005, XrefRangeEnd = 36006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0001C6C0 File Offset: 0x0001A8C0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 36028, RefRangeEnd = 36033, XrefRangeStart = 36006, XrefRangeEnd = 36028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = str;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &idx;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delim;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0001C734 File Offset: 0x0001A934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36078, RefRangeEnd = 36079, XrefRangeStart = 36033, XrefRangeEnd = 36078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> GetCanonicalPath(Il2CppStructArray<char> dest, ref int pos, UriFormat formatAs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref formatAs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0001C7A0 File Offset: 0x0001A9A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36087, RefRangeEnd = 36088, XrefRangeStart = 36079, XrefRangeEnd = 36087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = pch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch1;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch2;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0001C818 File Offset: 0x0001AA18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36110, RefRangeEnd = 36111, XrefRangeStart = 36088, XrefRangeEnd = 36110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> Compress(Il2CppStructArray<char> dest, ushort start, ref int destLength, UriParser syntax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &destLength;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syntax);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0001C88C File Offset: 0x0001AA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36120, RefRangeEnd = 36121, XrefRangeStart = 36111, XrefRangeEnd = 36120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CalculateCaseInsensitiveHashCode(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001C8D0 File Offset: 0x0001AAD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 36143, RefRangeEnd = 36144, XrefRangeStart = 36121, XrefRangeEnd = 36143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(basePart);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(relativePart);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0001C92C File Offset: 0x0001AB2C
		public unsafe bool HasAuthority
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 36144, RefRangeEnd = 36146, XrefRangeStart = 36144, XrefRangeEnd = 36144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001C968 File Offset: 0x0001AB68
		[CallerCount(0)]
		public unsafe static bool IsLWS(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001C9A8 File Offset: 0x0001ABA8
		[CallerCount(0)]
		public unsafe static bool IsAsciiLetter(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001C9E8 File Offset: 0x0001ABE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36149, RefRangeEnd = 36152, XrefRangeStart = 36146, XrefRangeEnd = 36149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAsciiLetterOrDigit(char character)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref character;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001CA28 File Offset: 0x0001AC28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36152, RefRangeEnd = 36154, XrefRangeStart = 36152, XrefRangeEnd = 36152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBidiControlCharacter(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0001CA68 File Offset: 0x0001AC68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36164, RefRangeEnd = 36166, XrefRangeStart = 36154, XrefRangeEnd = 36164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = strToClean;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001CABC File Offset: 0x0001ACBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36173, RefRangeEnd = 36175, XrefRangeStart = 36166, XrefRangeEnd = 36173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThis(string uri, bool dontEscape, UriKind uriKind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001CB1C File Offset: 0x0001AD1C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 36190, RefRangeEnd = 36197, XrefRangeStart = 36175, XrefRangeEnd = 36190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref err;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36197, XrefRangeEnd = 36198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForConfigLoad(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001CBDC File Offset: 0x0001ADDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36198, XrefRangeEnd = 36205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForUnicode(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001CC2C File Offset: 0x0001AE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36205, XrefRangeEnd = 36221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckForEscapedUnreserved(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001CC7C File Offset: 0x0001AE7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36228, RefRangeEnd = 36230, XrefRangeStart = 36221, XrefRangeEnd = 36228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Uri(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001CCF0 File Offset: 0x0001AEF0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 36232, RefRangeEnd = 36250, XrefRangeStart = 36230, XrefRangeEnd = 36232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponents(UriComponents components, UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref components;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref format;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001CD44 File Offset: 0x0001AF44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36261, RefRangeEnd = 36263, XrefRangeStart = 36250, XrefRangeEnd = 36261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string UnescapeDataString(string stringToUnescape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToUnescape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001CD80 File Offset: 0x0001AF80
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 36269, RefRangeEnd = 36282, XrefRangeStart = 36263, XrefRangeEnd = 36269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string EscapeDataString(string stringToEscape)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stringToEscape);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001CDBC File Offset: 0x0001AFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36282, XrefRangeEnd = 36284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref component;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001CE30 File Offset: 0x0001B030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36284, XrefRangeEnd = 36285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Uri(Uri.Flags flags, UriParser uriParser, string uri)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uriParser);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001CE9C File Offset: 0x0001B09C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36303, RefRangeEnd = 36305, XrefRangeStart = 36285, XrefRangeEnd = 36303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(uriString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dontEscape;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriKind;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(e);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			e = ((intPtr4 == 0) ? null : new UriFormatException(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr5) : null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001CF28 File Offset: 0x0001B128
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 36335, RefRangeEnd = 36338, XrefRangeStart = 36305, XrefRangeEnd = 36335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(relativeUri);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(newUriString);
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &userEscaped;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			newUriString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			e = ((intPtr5 == 0) ? null : new UriFormatException(intPtr5));
			IntPtr intPtr6 = intPtr3;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr6) : null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001CFD4 File Offset: 0x0001B1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 36338, XrefRangeEnd = 36348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetRelativeSerializationString(UriFormat format)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001D018 File Offset: 0x0001B218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36355, RefRangeEnd = 36357, XrefRangeStart = 36348, XrefRangeEnd = 36355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uriComponents;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uriFormat;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001D06C File Offset: 0x0001B26C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 36362, RefRangeEnd = 36364, XrefRangeStart = 36357, XrefRangeEnd = 36362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateThisFromUri(Uri otherUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00002F97 File Offset: 0x00001197
		public Uri(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x0001D0B0 File Offset: 0x0001B2B0
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00002FA0 File Offset: 0x000011A0
		public unsafe static string UriSchemeFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0001D0D0 File Offset: 0x0001B2D0
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00002FB2 File Offset: 0x000011B2
		public unsafe static string UriSchemeFtp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeFtp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0001D0F0 File Offset: 0x0001B2F0
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00002FC4 File Offset: 0x000011C4
		public unsafe static string UriSchemeGopher
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeGopher, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002FC RID: 764 RVA: 0x0001D110 File Offset: 0x0001B310
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00002FD6 File Offset: 0x000011D6
		public unsafe static string UriSchemeHttp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002FE RID: 766 RVA: 0x0001D130 File Offset: 0x0001B330
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00002FE8 File Offset: 0x000011E8
		public unsafe static string UriSchemeHttps
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeHttps, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000300 RID: 768 RVA: 0x0001D150 File Offset: 0x0001B350
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00002FFA File Offset: 0x000011FA
		public unsafe static string UriSchemeWs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWs, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWs, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000302 RID: 770 RVA: 0x0001D170 File Offset: 0x0001B370
		// (set) Token: 0x06000303 RID: 771 RVA: 0x0000300C File Offset: 0x0000120C
		public unsafe static string UriSchemeWss
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeWss, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeWss, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0001D190 File Offset: 0x0001B390
		// (set) Token: 0x06000305 RID: 773 RVA: 0x0000301E File Offset: 0x0000121E
		public unsafe static string UriSchemeMailto
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeMailto, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0001D1B0 File Offset: 0x0001B3B0
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00003030 File Offset: 0x00001230
		public unsafe static string UriSchemeNews
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNews, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNews, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001D1D0 File Offset: 0x0001B3D0
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00003042 File Offset: 0x00001242
		public unsafe static string UriSchemeNntp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNntp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0001D1F0 File Offset: 0x0001B3F0
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00003054 File Offset: 0x00001254
		public unsafe static string UriSchemeNetTcp
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetTcp, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0001D210 File Offset: 0x0001B410
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003066 File Offset: 0x00001266
		public unsafe static string UriSchemeNetPipe
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_UriSchemeNetPipe, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0001D230 File Offset: 0x0001B430
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00003078 File Offset: 0x00001278
		public unsafe static string SchemeDelimiter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_SchemeDelimiter, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0001D250 File Offset: 0x0001B450
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000308A File Offset: 0x0000128A
		public unsafe string m_String
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_String), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0001D278 File Offset: 0x0001B478
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000030A9 File Offset: 0x000012A9
		public unsafe string m_originalUnicodeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_originalUnicodeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0001D2A0 File Offset: 0x0001B4A0
		// (set) Token: 0x06000315 RID: 789 RVA: 0x000030C8 File Offset: 0x000012C8
		public unsafe UriParser m_Syntax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UriParser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Syntax), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000030E7 File Offset: 0x000012E7
		public unsafe string m_DnsSafeHost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0001D2F8 File Offset: 0x0001B4F8
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003106 File Offset: 0x00001306
		public unsafe Uri.Flags m_Flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Flags)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001D320 File Offset: 0x0001B520
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00003121 File Offset: 0x00001321
		public unsafe Uri.UriInfo m_Info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.UriInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_Info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0001D350 File Offset: 0x0001B550
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00003140 File Offset: 0x00001340
		public unsafe bool m_iriParsing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.NativeFieldInfoPtr_m_iriParsing)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001D378 File Offset: 0x0001B578
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0000315B File Offset: 0x0000135B
		public unsafe static bool s_ConfigInitialized
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitialized, (void*)(&value));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001D394 File Offset: 0x0001B594
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00003169 File Offset: 0x00001369
		public unsafe static bool s_ConfigInitializing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_ConfigInitializing, (void*)(&value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001D3B0 File Offset: 0x0001B5B0
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00003177 File Offset: 0x00001377
		public unsafe static UriIdnScope s_IdnScope
		{
			get
			{
				UriIdnScope uriIdnScope;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&uriIdnScope));
				return uriIdnScope;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IdnScope, (void*)(&value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0001D3CC File Offset: 0x0001B5CC
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00003185 File Offset: 0x00001385
		public unsafe static bool s_IriParsing
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_IriParsing, (void*)(&value));
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0001D3E8 File Offset: 0x0001B5E8
		// (set) Token: 0x06000327 RID: 807 RVA: 0x00003193 File Offset: 0x00001393
		public unsafe static bool useDotNetRelativeOrAbsolute
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_useDotNetRelativeOrAbsolute, (void*)(&value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0001D404 File Offset: 0x0001B604
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000031A1 File Offset: 0x000013A1
		public unsafe static bool IsWindowsFileSystem
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_IsWindowsFileSystem, (void*)(&value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0001D420 File Offset: 0x0001B620
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000031AF File Offset: 0x000013AF
		public unsafe static Object s_initLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_s_initLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_s_initLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0001D448 File Offset: 0x0001B648
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000031C1 File Offset: 0x000013C1
		public unsafe static Il2CppStructArray<char> HexLowerChars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr_HexLowerChars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr_HexLowerChars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0001D470 File Offset: 0x0001B670
		// (set) Token: 0x0600032F RID: 815 RVA: 0x000031D3 File Offset: 0x000013D3
		public unsafe static Il2CppStructArray<char> _WSchars
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Uri.NativeFieldInfoPtr__WSchars, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Uri.NativeFieldInfoPtr__WSchars, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFile;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeFtp;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeGopher;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttp;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeHttps;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWs;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeWss;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeMailto;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNews;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNntp;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetTcp;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeFieldInfoPtr_UriSchemeNetPipe;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeFieldInfoPtr_SchemeDelimiter;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_m_String;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_m_originalUnicodeString;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_m_Syntax;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeFieldInfoPtr_m_DnsSafeHost;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeFieldInfoPtr_m_Flags;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_Info;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_m_iriParsing;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitialized;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_s_ConfigInitializing;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeFieldInfoPtr_s_IdnScope;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeFieldInfoPtr_s_IriParsing;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeFieldInfoPtr_useDotNetRelativeOrAbsolute;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeFieldInfoPtr_IsWindowsFileSystem;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeFieldInfoPtr_s_initLock;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeFieldInfoPtr_HexLowerChars;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeFieldInfoPtr__WSchars;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_get_IsImplicitFile_Private_get_Boolean_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncOrDosPath_Private_get_Boolean_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDosPath_Private_get_Boolean_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUncPath_Private_get_Boolean_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_get_HostType_Private_get_Flags_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_get_Syntax_Private_get_UriParser_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotAbsoluteUri_Private_get_Boolean_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_IriParsingStatic_Internal_Static_Boolean_UriParser_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowIdn_Private_get_Boolean_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_AllowIdnStatic_Private_Boolean_UriParser_Flags_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_IsIntranet_Private_Boolean_String_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_get_UserDrivenParsing_Internal_get_Boolean_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_SetUserDrivenParsing_Private_Void_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_get_SecuredPathIndex_Private_get_UInt16_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_NotAny_Private_Boolean_Flags_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_InFact_Private_Boolean_Flags_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_StaticNotAny_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_StaticInFact_Private_Static_Boolean_Flags_Flags_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUriInfo_Private_UriInfo_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_EnsureParseRemaining_Private_Void_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_EnsureHostString_Private_Void_Boolean_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_UriKind_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_String_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_CreateUri_Private_Void_Uri_String_Boolean_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Uri_Uri_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_GetCombinedString_Private_Static_ParsingError_Uri_String_Boolean_byref_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Private_Static_UriFormatException_ParsingError_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsolutePath_Public_get_String_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_get_PrivateAbsolutePath_Private_get_String_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_get_AbsoluteUri_Public_get_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPath_Public_get_String_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_get_Authority_Public_get_String_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_get_HostNameType_Public_get_UriHostNameType_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultPort_Public_get_Boolean_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_get_IsFile_Public_get_Boolean_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoopback_Public_get_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_get_PathAndQuery_Public_get_String_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnc_Public_get_Boolean_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_get_Host_Public_get_String_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_StaticIsFile_Private_Static_Boolean_UriParser_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_get_InitializeLock_Private_Static_get_Object_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUriConfig_Private_Static_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalPath_Private_String_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_get_Port_Public_get_Int32_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_get_Query_Public_get_String_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_get_Fragment_Public_get_String_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_get_Scheme_Public_get_String_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalStringSwitched_Private_get_Boolean_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalString_Public_get_String_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_get_DnsSafeHost_Public_get_String_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbsoluteUri_Public_get_Boolean_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_get_UserEscaped_Public_get_Boolean_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_get_UserInfo_Public_get_String_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_IsGenDelim_Internal_Static_Boolean_Char_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemeName_Public_Static_Boolean_String_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_IsHexDigit_Public_Static_Boolean_Char_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_FromHex_Public_Static_Int32_Char_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Uri_Uri_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_InternalEscapeString_Internal_Static_String_String_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_ParseScheme_Private_Static_ParsingError_String_byref_Flags_byref_UriParser_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_ParseMinimal_Internal_UriFormatException_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimal_Private_ParsingError_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_PrivateParseMinimalIri_Private_Void_String_UInt16_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_CreateUriInfo_Private_Void_Flags_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostString_Private_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_CreateHostStringHelper_Private_Static_String_String_UInt16_UInt16_byref_Flags_byref_String_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_GetHostViaCustomSyntax_Private_Void_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_GetParts_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_GetEscapedParts_Private_String_UriComponents_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_GetUnescapedParts_Private_String_UriComponents_UriFormat_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ReCreateParts_Private_String_UriComponents_UInt16_UriFormat_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_GetUriPartsFromUserString_Private_String_UriComponents_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_ParseRemaining_Private_Void_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_ParseSchemeCheckImplicitFile_Private_Static_UInt16_ptr_Char_UInt16_byref_ParsingError_byref_Flags_byref_UriParser_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_CheckKnownSchemes_Private_Static_Boolean_ptr_Int64_UInt16_byref_UriParser_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_CheckSchemeSyntax_Private_Static_ParsingError_ptr_Char_UInt16_byref_UriParser_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelper_Private_UInt16_ptr_Char_UInt16_UInt16_byref_ParsingError_byref_Flags_UriParser_byref_String_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleDnsIri_Private_Void_ptr_Char_UInt16_Int32_Int32_Boolean_Boolean_UriParser_String_byref_Flags_byref_Boolean_byref_String_byref_ParsingError_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_CheckAuthorityHelperHandleAnyHostIri_Private_Void_ptr_Char_Int32_Int32_Boolean_Boolean_UriParser_byref_Flags_byref_String_byref_ParsingError_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_String_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_FindEndOfComponent_Private_Void_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_CheckCanonical_Private_Check_ptr_Char_byref_UInt16_UInt16_Char_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_GetCanonicalPath_Private_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_byref_Int32_UriFormat_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeOnly_Private_Static_Void_ptr_Char_Int32_byref_Int32_Char_Char_Char_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_Compress_Private_Static_Il2CppStructArray_1_Char_Il2CppStructArray_1_Char_UInt16_byref_Int32_UriParser_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCaseInsensitiveHashCode_Internal_Static_Int32_String_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_CombineUri_Private_Static_String_Uri_String_UriFormat_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAuthority_Internal_get_Boolean_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_IsLWS_Private_Static_Boolean_Char_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetter_Private_Static_Boolean_Char_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_IsAsciiLetterOrDigit_Internal_Static_Boolean_Char_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_IsBidiControlCharacter_Internal_Static_Boolean_Char_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_StripBidiControlCharacter_Internal_Static_String_ptr_Char_Int32_Int32_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_CreateThis_Private_Void_String_Boolean_UriKind_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_InitializeUri_Private_Void_ParsingError_UriKind_byref_UriFormatException_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_CheckForConfigLoad_Private_Boolean_String_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_CheckForUnicode_Private_Boolean_String_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_CheckForEscapedUnreserved_Private_Boolean_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_TryCreate_Public_Static_Boolean_String_UriKind_byref_Uri_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_GetComponents_Public_String_UriComponents_UriFormat_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_UnescapeDataString_Public_Static_String_String_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_EscapeDataString_Public_Static_String_String_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_EscapeUnescapeIri_Internal_String_String_Int32_Int32_UriComponents_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Flags_UriParser_String_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_CreateHelper_Internal_Static_Uri_String_Boolean_UriKind_byref_UriFormatException_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_ResolveHelper_Internal_Static_Uri_Uri_Uri_byref_String_byref_Boolean_byref_UriFormatException_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_GetRelativeSerializationString_Private_String_UriFormat_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentsHelper_Internal_String_UriComponents_UriFormat_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_CreateThisFromUri_Private_Void_Uri_0;

		// Token: 0x02000189 RID: 393
		[Flags]
		public enum Flags : ulong
		{
			// Token: 0x04001233 RID: 4659
			Zero = 0UL,
			// Token: 0x04001234 RID: 4660
			SchemeNotCanonical = 1UL,
			// Token: 0x04001235 RID: 4661
			UserNotCanonical = 2UL,
			// Token: 0x04001236 RID: 4662
			HostNotCanonical = 4UL,
			// Token: 0x04001237 RID: 4663
			PortNotCanonical = 8UL,
			// Token: 0x04001238 RID: 4664
			PathNotCanonical = 16UL,
			// Token: 0x04001239 RID: 4665
			QueryNotCanonical = 32UL,
			// Token: 0x0400123A RID: 4666
			FragmentNotCanonical = 64UL,
			// Token: 0x0400123B RID: 4667
			CannotDisplayCanonical = 127UL,
			// Token: 0x0400123C RID: 4668
			E_UserNotCanonical = 128UL,
			// Token: 0x0400123D RID: 4669
			E_HostNotCanonical = 256UL,
			// Token: 0x0400123E RID: 4670
			E_PortNotCanonical = 512UL,
			// Token: 0x0400123F RID: 4671
			E_PathNotCanonical = 1024UL,
			// Token: 0x04001240 RID: 4672
			E_QueryNotCanonical = 2048UL,
			// Token: 0x04001241 RID: 4673
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x04001242 RID: 4674
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x04001243 RID: 4675
			ShouldBeCompressed = 8192UL,
			// Token: 0x04001244 RID: 4676
			FirstSlashAbsent = 16384UL,
			// Token: 0x04001245 RID: 4677
			BackslashInPath = 32768UL,
			// Token: 0x04001246 RID: 4678
			IndexMask = 65535UL,
			// Token: 0x04001247 RID: 4679
			HostTypeMask = 458752UL,
			// Token: 0x04001248 RID: 4680
			HostNotParsed = 0UL,
			// Token: 0x04001249 RID: 4681
			IPv6HostType = 65536UL,
			// Token: 0x0400124A RID: 4682
			IPv4HostType = 131072UL,
			// Token: 0x0400124B RID: 4683
			DnsHostType = 196608UL,
			// Token: 0x0400124C RID: 4684
			UncHostType = 262144UL,
			// Token: 0x0400124D RID: 4685
			BasicHostType = 327680UL,
			// Token: 0x0400124E RID: 4686
			UnusedHostType = 393216UL,
			// Token: 0x0400124F RID: 4687
			UnknownHostType = 458752UL,
			// Token: 0x04001250 RID: 4688
			UserEscaped = 524288UL,
			// Token: 0x04001251 RID: 4689
			AuthorityFound = 1048576UL,
			// Token: 0x04001252 RID: 4690
			HasUserInfo = 2097152UL,
			// Token: 0x04001253 RID: 4691
			LoopbackHost = 4194304UL,
			// Token: 0x04001254 RID: 4692
			NotDefaultPort = 8388608UL,
			// Token: 0x04001255 RID: 4693
			UserDrivenParsing = 16777216UL,
			// Token: 0x04001256 RID: 4694
			CanonicalDnsHost = 33554432UL,
			// Token: 0x04001257 RID: 4695
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x04001258 RID: 4696
			DosPath = 134217728UL,
			// Token: 0x04001259 RID: 4697
			UncPath = 268435456UL,
			// Token: 0x0400125A RID: 4698
			ImplicitFile = 536870912UL,
			// Token: 0x0400125B RID: 4699
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x0400125C RID: 4700
			AllUriInfoSet = 2147483648UL,
			// Token: 0x0400125D RID: 4701
			IdnHost = 4294967296UL,
			// Token: 0x0400125E RID: 4702
			HasUnicode = 8589934592UL,
			// Token: 0x0400125F RID: 4703
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x04001260 RID: 4704
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x04001261 RID: 4705
			UnicodeHost = 68719476736UL,
			// Token: 0x04001262 RID: 4706
			IntranetUri = 137438953472UL,
			// Token: 0x04001263 RID: 4707
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x04001264 RID: 4708
			UserIriCanonical = 549755813888UL,
			// Token: 0x04001265 RID: 4709
			PathIriCanonical = 1099511627776UL,
			// Token: 0x04001266 RID: 4710
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x04001267 RID: 4711
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x04001268 RID: 4712
			IriCanonical = 8246337208320UL,
			// Token: 0x04001269 RID: 4713
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x0200018A RID: 394
		public class UriInfo : Object
		{
			// Token: 0x0600171B RID: 5915 RVA: 0x0006474C File Offset: 0x0006294C
			// Note: this type is marked as 'beforefieldinit'.
			static UriInfo()
			{
				Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "UriInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr);
				Uri.UriInfo.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Host");
				Uri.UriInfo.NativeFieldInfoPtr_ScopeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "ScopeId");
				Uri.UriInfo.NativeFieldInfoPtr_String = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "String");
				Uri.UriInfo.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "Offset");
				Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "DnsSafeHost");
				Uri.UriInfo.NativeFieldInfoPtr_MoreInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, "MoreInfo");
				Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr, 100663819);
			}

			// Token: 0x0600171C RID: 5916 RVA: 0x00064804 File Offset: 0x00062A04
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UriInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.UriInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.UriInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600171D RID: 5917 RVA: 0x0000C30C File Offset: 0x0000A50C
			public UriInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000772 RID: 1906
			// (get) Token: 0x0600171E RID: 5918 RVA: 0x00064840 File Offset: 0x00062A40
			// (set) Token: 0x0600171F RID: 5919 RVA: 0x0000C315 File Offset: 0x0000A515
			public unsafe string Host
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Host), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000773 RID: 1907
			// (get) Token: 0x06001720 RID: 5920 RVA: 0x00064868 File Offset: 0x00062A68
			// (set) Token: 0x06001721 RID: 5921 RVA: 0x0000C334 File Offset: 0x0000A534
			public unsafe string ScopeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_ScopeId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000774 RID: 1908
			// (get) Token: 0x06001722 RID: 5922 RVA: 0x00064890 File Offset: 0x00062A90
			// (set) Token: 0x06001723 RID: 5923 RVA: 0x0000C353 File Offset: 0x0000A553
			public unsafe string String
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_String), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000775 RID: 1909
			// (get) Token: 0x06001724 RID: 5924 RVA: 0x000648B8 File Offset: 0x00062AB8
			// (set) Token: 0x06001725 RID: 5925 RVA: 0x0000C372 File Offset: 0x0000A572
			public unsafe Uri.Offset Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x17000776 RID: 1910
			// (get) Token: 0x06001726 RID: 5926 RVA: 0x000648E0 File Offset: 0x00062AE0
			// (set) Token: 0x06001727 RID: 5927 RVA: 0x0000C38D File Offset: 0x0000A58D
			public unsafe string DnsSafeHost
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_DnsSafeHost), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000777 RID: 1911
			// (get) Token: 0x06001728 RID: 5928 RVA: 0x00064908 File Offset: 0x00062B08
			// (set) Token: 0x06001729 RID: 5929 RVA: 0x0000C3AC File Offset: 0x0000A5AC
			public unsafe Uri.MoreInfo MoreInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri.MoreInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.UriInfo.NativeFieldInfoPtr_MoreInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x0400126B RID: 4715
			private static readonly IntPtr NativeFieldInfoPtr_ScopeId;

			// Token: 0x0400126C RID: 4716
			private static readonly IntPtr NativeFieldInfoPtr_String;

			// Token: 0x0400126D RID: 4717
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x0400126E RID: 4718
			private static readonly IntPtr NativeFieldInfoPtr_DnsSafeHost;

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeFieldInfoPtr_MoreInfo;

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018B RID: 395
		[StructLayout(2)]
		public struct Offset
		{
			// Token: 0x0600172A RID: 5930 RVA: 0x00064938 File Offset: 0x00062B38
			// Note: this type is marked as 'beforefieldinit'.
			static Offset()
			{
				Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "Offset");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr);
				Uri.Offset.NativeFieldInfoPtr_Scheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Scheme");
				Uri.Offset.NativeFieldInfoPtr_User = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "User");
				Uri.Offset.NativeFieldInfoPtr_Host = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Host");
				Uri.Offset.NativeFieldInfoPtr_PortValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "PortValue");
				Uri.Offset.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Path");
				Uri.Offset.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Query");
				Uri.Offset.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "Fragment");
				Uri.Offset.NativeFieldInfoPtr_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, "End");
			}

			// Token: 0x0600172B RID: 5931 RVA: 0x0000C3CB File Offset: 0x0000A5CB
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Uri.Offset>.NativeClassPtr, ref this));
			}

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeFieldInfoPtr_Scheme;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeFieldInfoPtr_User;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeFieldInfoPtr_Host;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeFieldInfoPtr_PortValue;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x04001277 RID: 4727
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x04001278 RID: 4728
			private static readonly IntPtr NativeFieldInfoPtr_End;

			// Token: 0x04001279 RID: 4729
			[FieldOffset(0)]
			public ushort Scheme;

			// Token: 0x0400127A RID: 4730
			[FieldOffset(2)]
			public ushort User;

			// Token: 0x0400127B RID: 4731
			[FieldOffset(4)]
			public ushort Host;

			// Token: 0x0400127C RID: 4732
			[FieldOffset(6)]
			public ushort PortValue;

			// Token: 0x0400127D RID: 4733
			[FieldOffset(8)]
			public ushort Path;

			// Token: 0x0400127E RID: 4734
			[FieldOffset(10)]
			public ushort Query;

			// Token: 0x0400127F RID: 4735
			[FieldOffset(12)]
			public ushort Fragment;

			// Token: 0x04001280 RID: 4736
			[FieldOffset(14)]
			public ushort End;
		}

		// Token: 0x0200018C RID: 396
		public class MoreInfo : Object
		{
			// Token: 0x0600172C RID: 5932 RVA: 0x00064A04 File Offset: 0x00062C04
			// Note: this type is marked as 'beforefieldinit'.
			static MoreInfo()
			{
				Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Uri>.NativeClassPtr, "MoreInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr);
				Uri.MoreInfo.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Path");
				Uri.MoreInfo.NativeFieldInfoPtr_Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Query");
				Uri.MoreInfo.NativeFieldInfoPtr_Fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Fragment");
				Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "AbsoluteUri");
				Uri.MoreInfo.NativeFieldInfoPtr_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "Hash");
				Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, "RemoteUrl");
				Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr, 100663820);
			}

			// Token: 0x0600172D RID: 5933 RVA: 0x00064ABC File Offset: 0x00062CBC
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MoreInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Uri.MoreInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Uri.MoreInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600172E RID: 5934 RVA: 0x0000C3DD File Offset: 0x0000A5DD
			public MoreInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000778 RID: 1912
			// (get) Token: 0x0600172F RID: 5935 RVA: 0x00064AF8 File Offset: 0x00062CF8
			// (set) Token: 0x06001730 RID: 5936 RVA: 0x0000C3E6 File Offset: 0x0000A5E6
			public unsafe string Path
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000779 RID: 1913
			// (get) Token: 0x06001731 RID: 5937 RVA: 0x00064B20 File Offset: 0x00062D20
			// (set) Token: 0x06001732 RID: 5938 RVA: 0x0000C405 File Offset: 0x0000A605
			public unsafe string Query
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Query), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700077A RID: 1914
			// (get) Token: 0x06001733 RID: 5939 RVA: 0x00064B48 File Offset: 0x00062D48
			// (set) Token: 0x06001734 RID: 5940 RVA: 0x0000C424 File Offset: 0x0000A624
			public unsafe string Fragment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Fragment), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700077B RID: 1915
			// (get) Token: 0x06001735 RID: 5941 RVA: 0x00064B70 File Offset: 0x00062D70
			// (set) Token: 0x06001736 RID: 5942 RVA: 0x0000C443 File Offset: 0x0000A643
			public unsafe string AbsoluteUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_AbsoluteUri), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700077C RID: 1916
			// (get) Token: 0x06001737 RID: 5943 RVA: 0x00064B98 File Offset: 0x00062D98
			// (set) Token: 0x06001738 RID: 5944 RVA: 0x0000C462 File Offset: 0x0000A662
			public unsafe int Hash
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_Hash)) = value;
				}
			}

			// Token: 0x1700077D RID: 1917
			// (get) Token: 0x06001739 RID: 5945 RVA: 0x00064BC0 File Offset: 0x00062DC0
			// (set) Token: 0x0600173A RID: 5946 RVA: 0x0000C47D File Offset: 0x0000A67D
			public unsafe string RemoteUrl
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Uri.MoreInfo.NativeFieldInfoPtr_RemoteUrl), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001281 RID: 4737
			private static readonly IntPtr NativeFieldInfoPtr_Path;

			// Token: 0x04001282 RID: 4738
			private static readonly IntPtr NativeFieldInfoPtr_Query;

			// Token: 0x04001283 RID: 4739
			private static readonly IntPtr NativeFieldInfoPtr_Fragment;

			// Token: 0x04001284 RID: 4740
			private static readonly IntPtr NativeFieldInfoPtr_AbsoluteUri;

			// Token: 0x04001285 RID: 4741
			private static readonly IntPtr NativeFieldInfoPtr_Hash;

			// Token: 0x04001286 RID: 4742
			private static readonly IntPtr NativeFieldInfoPtr_RemoteUrl;

			// Token: 0x04001287 RID: 4743
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200018D RID: 397
		[Flags]
		public enum Check
		{
			// Token: 0x04001289 RID: 4745
			None = 0,
			// Token: 0x0400128A RID: 4746
			EscapedCanonical = 1,
			// Token: 0x0400128B RID: 4747
			DisplayCanonical = 2,
			// Token: 0x0400128C RID: 4748
			DotSlashAttn = 4,
			// Token: 0x0400128D RID: 4749
			DotSlashEscaped = 128,
			// Token: 0x0400128E RID: 4750
			BackslashInPath = 16,
			// Token: 0x0400128F RID: 4751
			ReservedFound = 32,
			// Token: 0x04001290 RID: 4752
			NotIriCanonical = 64,
			// Token: 0x04001291 RID: 4753
			FoundNonAscii = 8
		}
	}
}
