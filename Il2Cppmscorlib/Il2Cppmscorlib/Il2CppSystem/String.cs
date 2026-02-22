using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x020000E7 RID: 231
	[DefaultMember("Item")]
	[Serializable]
	public sealed class String : Object
	{
		// Token: 0x06000FA4 RID: 4004 RVA: 0x00069BE0 File Offset: 0x00067DE0
		// Note: this type is marked as 'beforefieldinit'.
		static String()
		{
			Il2CppClassPointerStore<string>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "String");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<string>.NativeClassPtr);
			String.NativeFieldInfoPtr_m_stringLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "m_stringLength");
			String.NativeFieldInfoPtr_m_firstChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "m_firstChar");
			String.NativeFieldInfoPtr_TrimHead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimHead");
			String.NativeFieldInfoPtr_TrimTail = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimTail");
			String.NativeFieldInfoPtr_TrimBoth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "TrimBoth");
			String.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "Empty");
			String.NativeFieldInfoPtr_charPtrAlignConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "charPtrAlignConst");
			String.NativeFieldInfoPtr_alignConst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<string>.NativeClassPtr, "alignConst");
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665954);
			String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665955);
			String.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665956);
			String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665957);
			String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665958);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665959);
			String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665960);
			String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665961);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665962);
			String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665963);
			String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665964);
			String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665965);
			String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665966);
			String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665967);
			String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665968);
			String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665969);
			String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665970);
			String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665971);
			String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665972);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665973);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665974);
			String.NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665975);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665976);
			String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665977);
			String.NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665978);
			String.NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665979);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665980);
			String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665981);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665982);
			String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665983);
			String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665984);
			String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665985);
			String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665986);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665987);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665988);
			String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665989);
			String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665990);
			String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665991);
			String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665992);
			String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665993);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665994);
			String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665995);
			String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665996);
			String.NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665997);
			String.NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665998);
			String.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100665999);
			String.NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666000);
			String.NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666001);
			String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666002);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666003);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666004);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666005);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666006);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666007);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666008);
			String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666009);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666010);
			String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666011);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666012);
			String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666013);
			String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666014);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666015);
			String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666016);
			String.NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666017);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666018);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666019);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666020);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666021);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666022);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666023);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666024);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666025);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666026);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666027);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666028);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666029);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666030);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666031);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666032);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666033);
			String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666034);
			String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666035);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666036);
			String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666037);
			String.NativeMethodInfoPtr_ToLower_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666038);
			String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666039);
			String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666040);
			String.NativeMethodInfoPtr_ToUpper_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666041);
			String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666042);
			String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666043);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666044);
			String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666045);
			String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666046);
			String.NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666047);
			String.NativeMethodInfoPtr_Trim_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666048);
			String.NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666049);
			String.NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666050);
			String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666051);
			String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666052);
			String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666053);
			String.NativeMethodInfoPtr_Replace_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666054);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666055);
			String.NativeMethodInfoPtr_Remove_Public_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666056);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666057);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666058);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666059);
			String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666060);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666061);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666062);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666063);
			String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666064);
			String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666065);
			String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666066);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666067);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666068);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666069);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666070);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666071);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666072);
			String.NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666073);
			String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666074);
			String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666075);
			String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666076);
			String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666077);
			String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666078);
			String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666079);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666080);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666081);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666082);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666083);
			String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666084);
			String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666085);
			String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666086);
			String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666087);
			String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666088);
			String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666089);
			String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666090);
			String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666091);
			String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666092);
			String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666093);
			String.NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666094);
			String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666095);
			String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666096);
			String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666097);
			String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666098);
			String.NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666099);
			String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666100);
			String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666101);
			String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666102);
			String.NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666103);
			String.NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666104);
			String.NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666105);
			String.NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666106);
			String.NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666107);
			String.NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666108);
			String.NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666109);
			String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666110);
			String.NativeMethodInfoPtr_IsAscii_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666111);
			String.NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666112);
			String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666113);
			String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666114);
			String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666115);
			String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666116);
			String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666117);
			String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666118);
			String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666119);
			String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666120);
			String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666121);
			String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666122);
			String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666123);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666124);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666125);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666126);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666127);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666128);
			String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666129);
			String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666130);
			String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<string>.NativeClassPtr, 100666131);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0006AA98 File Offset: 0x00068C98
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 292283, RefRangeEnd = 292295, XrefRangeStart = 292282, XrefRangeEnd = 292283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, [Optional] Il2CppStringArray value)
		{
			if (value == null)
			{
				value = new Il2CppStringArray(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0006AAF4 File Offset: 0x00068CF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 292302, RefRangeEnd = 292306, XrefRangeStart = 292295, XrefRangeEnd = 292302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Join(string separator, Il2CppStringArray value, int startIndex, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0006AB60 File Offset: 0x00068D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292306, XrefRangeEnd = 292310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalIgnoreCaseHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 292311, RefRangeEnd = 292316, XrefRangeStart = 292310, XrefRangeEnd = 292311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool EqualsHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0006AC08 File Offset: 0x00068E08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 292320, RefRangeEnd = 292321, XrefRangeStart = 292316, XrefRangeEnd = 292320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalHelper(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x0006AC5C File Offset: 0x00068E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292321, XrefRangeEnd = 292325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0006ACAC File Offset: 0x00068EAC
		[CallerCount(176)]
		[CachedScanResults(RefRangeStart = 292326, RefRangeEnd = 292502, XrefRangeStart = 292325, XrefRangeEnd = 292326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x0006ACFC File Offset: 0x00068EFC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 292507, RefRangeEnd = 292515, XrefRangeStart = 292502, XrefRangeEnd = 292507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0006AD58 File Offset: 0x00068F58
		[CallerCount(939)]
		[CachedScanResults(RefRangeStart = 292516, RefRangeEnd = 293455, XrefRangeStart = 292515, XrefRangeEnd = 292516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x0006ADAC File Offset: 0x00068FAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 293460, RefRangeEnd = 293469, XrefRangeStart = 293455, XrefRangeEnd = 293460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(string a, string b, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0006AE10 File Offset: 0x00069010
		[CallerCount(939)]
		[CachedScanResults(RefRangeStart = 292516, RefRangeEnd = 293455, XrefRangeStart = 292516, XrefRangeEnd = 293455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x0006AE64 File Offset: 0x00069064
		[CallerCount(155)]
		[CachedScanResults(RefRangeStart = 293470, RefRangeEnd = 293625, XrefRangeStart = 293469, XrefRangeEnd = 293470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(string a, string b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0006AEB8 File Offset: 0x000690B8
		public unsafe char Chars
		{
			[CallerCount(1082)]
			[CachedScanResults(RefRangeStart = 293625, RefRangeEnd = 294707, XrefRangeStart = 293625, XrefRangeEnd = 293625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0006AF04 File Offset: 0x00069104
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 294709, RefRangeEnd = 294723, XrefRangeStart = 294707, XrefRangeEnd = 294709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(int sourceIndex, Il2CppStructArray<char> destination, int destinationIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourceIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destinationIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x0006AF70 File Offset: 0x00069170
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 294728, RefRangeEnd = 294741, XrefRangeStart = 294723, XrefRangeEnd = 294728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<char> ToCharArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x0006AFB0 File Offset: 0x000691B0
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 46039, RefRangeEnd = 46275, XrefRangeStart = 46039, XrefRangeEnd = 46275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrEmpty(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0006AFF4 File Offset: 0x000691F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294747, RefRangeEnd = 294749, XrefRangeStart = 294741, XrefRangeEnd = 294747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsNullOrWhiteSpace(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x0006B038 File Offset: 0x00069238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294750, RefRangeEnd = 294751, XrefRangeStart = 294749, XrefRangeEnd = 294750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x0006B074 File Offset: 0x00069274
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294750, RefRangeEnd = 294751, XrefRangeStart = 294750, XrefRangeEnd = 294751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetLegacyNonRandomizedHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x0006B0B0 File Offset: 0x000692B0
		[CallerCount(89)]
		[CachedScanResults(RefRangeStart = 294752, RefRangeEnd = 294841, XrefRangeStart = 294751, XrefRangeEnd = 294752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split([Optional] Il2CppStructArray<char> separator)
		{
			if (separator == null)
			{
				separator = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x0006B110 File Offset: 0x00069310
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 294842, RefRangeEnd = 294845, XrefRangeStart = 294841, XrefRangeEnd = 294842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStructArray<char> separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0006B170 File Offset: 0x00069370
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294851, RefRangeEnd = 294853, XrefRangeStart = 294845, XrefRangeEnd = 294851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray SplitInternal(Il2CppStructArray<char> separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x0006B1DC File Offset: 0x000693DC
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 294854, RefRangeEnd = 294893, XrefRangeStart = 294853, XrefRangeEnd = 294854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x0006B23C File Offset: 0x0006943C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294901, RefRangeEnd = 294902, XrefRangeStart = 294893, XrefRangeEnd = 294901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray Split(Il2CppStringArray separator, int count, StringSplitOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x0006B2A8 File Offset: 0x000694A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 294914, RefRangeEnd = 294916, XrefRangeStart = 294902, XrefRangeEnd = 294914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalSplitKeepEmptyEntries(Il2CppStructArray<int> sepList, Il2CppStructArray<int> lengthList, int numReplaces, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numReplaces;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x0006B328 File Offset: 0x00069528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294916, XrefRangeEnd = 294930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray InternalSplitOmitEmptyEntries(Il2CppStructArray<int> sepList, Il2CppStructArray<int> lengthList, int numReplaces, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numReplaces;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x0006B3A8 File Offset: 0x000695A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294933, RefRangeEnd = 294934, XrefRangeStart = 294930, XrefRangeEnd = 294933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MakeSeparatorList(Il2CppStructArray<char> separator, ref Il2CppStructArray<int> sepList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separator);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			sepList = ((intPtr4 == 0) ? null : new Il2CppStructArray<int>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0006B420 File Offset: 0x00069620
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294937, RefRangeEnd = 294938, XrefRangeStart = 294934, XrefRangeEnd = 294937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MakeSeparatorList(Il2CppStringArray separators, ref Il2CppStructArray<int> sepList, ref Il2CppStructArray<int> lengthList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(separators);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(sepList);
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(lengthList);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			sepList = ((intPtr5 == 0) ? null : new Il2CppStructArray<int>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			lengthList = ((intPtr6 == 0) ? null : new Il2CppStructArray<int>(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x0006B4C0 File Offset: 0x000696C0
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 294939, RefRangeEnd = 295007, XrefRangeStart = 294938, XrefRangeEnd = 294939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x0006B504 File Offset: 0x00069704
		[CallerCount(214)]
		[CachedScanResults(RefRangeStart = 295008, RefRangeEnd = 295222, XrefRangeStart = 295007, XrefRangeEnd = 295008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Substring(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0006B558 File Offset: 0x00069758
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 295224, RefRangeEnd = 295231, XrefRangeStart = 295222, XrefRangeEnd = 295224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string InternalSubString(int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x0006B5AC File Offset: 0x000697AC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 295237, RefRangeEnd = 295251, XrefRangeStart = 295231, XrefRangeEnd = 295237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x0006B604 File Offset: 0x00069804
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 295254, RefRangeEnd = 295264, XrefRangeStart = 295251, XrefRangeEnd = 295254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimEnd([Optional] Il2CppStructArray<char> trimChars)
		{
			if (trimChars == null)
			{
				trimChars = new Il2CppStructArray<char>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x0006B65C File Offset: 0x0006985C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295264, XrefRangeEnd = 295265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x0006B6A4 File Offset: 0x000698A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char* value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0006B708 File Offset: 0x00069908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(sbyte* value, int startIndex, int length, Encoding enc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x0006B780 File Offset: 0x00069980
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 295267, RefRangeEnd = 295273, XrefRangeStart = 295265, XrefRangeEnd = 295267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = bytes;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteLength;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0006B7D8 File Offset: 0x000699D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 295277, RefRangeEnd = 295284, XrefRangeStart = 295273, XrefRangeEnd = 295277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Normalize(NormalizationForm normalizationForm)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref normalizationForm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x0006B81C File Offset: 0x00069A1C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295285, RefRangeEnd = 295297, XrefRangeStart = 295284, XrefRangeEnd = 295285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FastAllocateString(int length)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x0006B854 File Offset: 0x00069A54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295297, XrefRangeEnd = 295304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FillStringChecked(string dest, int destPos, string src)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dest);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(src);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x0006B8AC File Offset: 0x00069AAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value, int startIndex, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0006B914 File Offset: 0x00069B14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(Il2CppStructArray<char> value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x0006B960 File Offset: 0x00069B60
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 295305, RefRangeEnd = 295315, XrefRangeStart = 295304, XrefRangeEnd = 295305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void wstrcpy(char* dmem, char* smem, int charCount)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dmem;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = smem;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref charCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0006B9AC File Offset: 0x00069BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295315, XrefRangeEnd = 295320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharArray(Il2CppStructArray<char> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0006B9F4 File Offset: 0x00069BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295322, RefRangeEnd = 295323, XrefRangeStart = 295320, XrefRangeEnd = 295322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharArrayStartLength(Il2CppStructArray<char> value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0006BA58 File Offset: 0x00069C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295323, XrefRangeEnd = 295324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int wcslen(char* ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0006BA94 File Offset: 0x00069C94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295332, RefRangeEnd = 295333, XrefRangeStart = 295324, XrefRangeEnd = 295332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharPtr(char* ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0006BAD8 File Offset: 0x00069CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295338, RefRangeEnd = 295339, XrefRangeStart = 295333, XrefRangeEnd = 295338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CtorCharPtrStartLength(char* ptr, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr2[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x0006BB38 File Offset: 0x00069D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe String(char c, int count)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<string>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0006BB90 File Offset: 0x00069D90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295343, RefRangeEnd = 295345, XrefRangeStart = 295339, XrefRangeEnd = 295343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x0006BBE4 File Offset: 0x00069DE4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295352, RefRangeEnd = 295355, XrefRangeStart = 295345, XrefRangeEnd = 295352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x0006BC48 File Offset: 0x00069E48
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 295360, RefRangeEnd = 295401, XrefRangeStart = 295355, XrefRangeEnd = 295360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x0006BCAC File Offset: 0x00069EAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295409, RefRangeEnd = 295411, XrefRangeStart = 295401, XrefRangeEnd = 295409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x0006BD20 File Offset: 0x00069F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295411, XrefRangeEnd = 295415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0006BDA0 File Offset: 0x00069FA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295415, RefRangeEnd = 295417, XrefRangeStart = 295415, XrefRangeEnd = 295415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0006BE40 File Offset: 0x0006A040
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295435, RefRangeEnd = 295447, XrefRangeStart = 295417, XrefRangeEnd = 295435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0006BECC File Offset: 0x0006A0CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295447, XrefRangeEnd = 295455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x0006BF1C File Offset: 0x0006A11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295455, XrefRangeEnd = 295459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(string strB)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strB);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0006BF6C File Offset: 0x0006A16C
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 295460, RefRangeEnd = 295497, XrefRangeStart = 295459, XrefRangeEnd = 295460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, string strB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0006BFC0 File Offset: 0x0006A1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295498, RefRangeEnd = 295499, XrefRangeStart = 295497, XrefRangeEnd = 295498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x0006C040 File Offset: 0x0006A240
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295504, RefRangeEnd = 295516, XrefRangeStart = 295499, XrefRangeEnd = 295504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Contains_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0006C090 File Offset: 0x0006A290
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295517, RefRangeEnd = 295529, XrefRangeStart = 295516, XrefRangeEnd = 295517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x0006C0E0 File Offset: 0x0006A2E0
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 295534, RefRangeEnd = 295569, XrefRangeStart = 295529, XrefRangeEnd = 295534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0006C13C File Offset: 0x0006A33C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295569, RefRangeEnd = 295573, XrefRangeStart = 295569, XrefRangeEnd = 295569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EndsWith(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x0006C188 File Offset: 0x0006A388
		[CallerCount(69)]
		[CachedScanResults(RefRangeStart = 295574, RefRangeEnd = 295643, XrefRangeStart = 295573, XrefRangeEnd = 295574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x0006C1D4 File Offset: 0x0006A3D4
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 295644, RefRangeEnd = 295662, XrefRangeStart = 295643, XrefRangeEnd = 295644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x0006C22C File Offset: 0x0006A42C
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 295663, RefRangeEnd = 295696, XrefRangeStart = 295662, XrefRangeEnd = 295663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0006C27C File Offset: 0x0006A47C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 295697, RefRangeEnd = 295702, XrefRangeStart = 295696, XrefRangeEnd = 295697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x0006C2D8 File Offset: 0x0006A4D8
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 295707, RefRangeEnd = 295732, XrefRangeStart = 295702, XrefRangeEnd = 295707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0006C328 File Offset: 0x0006A528
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 295733, RefRangeEnd = 295743, XrefRangeStart = 295732, XrefRangeEnd = 295733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x0006C384 File Offset: 0x0006A584
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 295744, RefRangeEnd = 295757, XrefRangeStart = 295743, XrefRangeEnd = 295744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295758, RefRangeEnd = 295759, XrefRangeStart = 295757, XrefRangeEnd = 295758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x0006C44C File Offset: 0x0006A64C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295764, RefRangeEnd = 295767, XrefRangeStart = 295759, XrefRangeEnd = 295764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x0006C4C4 File Offset: 0x0006A6C4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 295768, RefRangeEnd = 295778, XrefRangeStart = 295767, XrefRangeEnd = 295768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0006C510 File Offset: 0x0006A710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295779, RefRangeEnd = 295783, XrefRangeStart = 295778, XrefRangeEnd = 295779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x0006C568 File Offset: 0x0006A768
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295784, RefRangeEnd = 295788, XrefRangeStart = 295783, XrefRangeEnd = 295784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0006C5B8 File Offset: 0x0006A7B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295789, RefRangeEnd = 295791, XrefRangeStart = 295788, XrefRangeEnd = 295789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x0006C614 File Offset: 0x0006A814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295792, RefRangeEnd = 295794, XrefRangeStart = 295791, XrefRangeEnd = 295792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0006C664 File Offset: 0x0006A864
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295795, RefRangeEnd = 295799, XrefRangeStart = 295794, XrefRangeEnd = 295795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x0006C6C0 File Offset: 0x0006A8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295800, RefRangeEnd = 295802, XrefRangeStart = 295799, XrefRangeEnd = 295800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x0006C738 File Offset: 0x0006A938
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 295803, RefRangeEnd = 295812, XrefRangeStart = 295802, XrefRangeEnd = 295803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadLeft(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0006C78C File Offset: 0x0006A98C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295812, XrefRangeEnd = 295813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadRight(int totalWidth, char paddingChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0006C7E0 File Offset: 0x0006A9E0
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 295820, RefRangeEnd = 295846, XrefRangeStart = 295813, XrefRangeEnd = 295820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0006C830 File Offset: 0x0006AA30
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 295851, RefRangeEnd = 295888, XrefRangeStart = 295846, XrefRangeEnd = 295851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWith(string value, StringComparison comparisonType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref comparisonType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0006C88C File Offset: 0x0006AA8C
		[CallerCount(60)]
		[CachedScanResults(RefRangeStart = 295899, RefRangeEnd = 295959, XrefRangeStart = 295888, XrefRangeEnd = 295899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0006C8C4 File Offset: 0x0006AAC4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 295966, RefRangeEnd = 295980, XrefRangeStart = 295959, XrefRangeEnd = 295966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLower(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0006C90C File Offset: 0x0006AB0C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 295991, RefRangeEnd = 296003, XrefRangeStart = 295980, XrefRangeEnd = 295991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToLowerInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToLowerInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0006C944 File Offset: 0x0006AB44
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296014, RefRangeEnd = 296017, XrefRangeStart = 296003, XrefRangeEnd = 296014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0006C97C File Offset: 0x0006AB7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296024, RefRangeEnd = 296028, XrefRangeStart = 296017, XrefRangeEnd = 296024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpper(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0006C9C4 File Offset: 0x0006ABC4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 296039, RefRangeEnd = 296049, XrefRangeStart = 296028, XrefRangeEnd = 296039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToUpperInvariant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToUpperInvariant_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x0006C9FC File Offset: 0x0006ABFC
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0006CA34 File Offset: 0x0006AC34
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0006CA7C File Offset: 0x0006AC7C
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0006CABC File Offset: 0x0006ACBC
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsBOMWhitespace(char c)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0006CAFC File Offset: 0x0006ACFC
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 296050, RefRangeEnd = 296107, XrefRangeStart = 296049, XrefRangeEnd = 296050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Trim()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Trim_Public_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0006CB34 File Offset: 0x0006AD34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296120, RefRangeEnd = 296121, XrefRangeStart = 296107, XrefRangeEnd = 296120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimHelper(int trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref trimType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0006CB78 File Offset: 0x0006AD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296121, XrefRangeEnd = 296127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TrimHelper(Il2CppStructArray<char> trimChars, int trimType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trimChars);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref trimType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x0006CBD0 File Offset: 0x0006ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296127, XrefRangeEnd = 296130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateTrimmedString(int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref start;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x0006CC24 File Offset: 0x0006AE24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296135, RefRangeEnd = 296138, XrefRangeStart = 296130, XrefRangeEnd = 296135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Insert(int startIndex, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Insert_Public_String_Int32_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x0006CC7C File Offset: 0x0006AE7C
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 296144, RefRangeEnd = 296161, XrefRangeStart = 296138, XrefRangeEnd = 296144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(char oldChar, char newChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x0006CCD0 File Offset: 0x0006AED0
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 296164, RefRangeEnd = 296187, XrefRangeStart = 296161, XrefRangeEnd = 296164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Replace(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Replace_Public_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0006CD2C File Offset: 0x0006AF2C
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 296191, RefRangeEnd = 296232, XrefRangeStart = 296187, XrefRangeEnd = 296191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0006CD80 File Offset: 0x0006AF80
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 296249, RefRangeEnd = 296253, XrefRangeStart = 296232, XrefRangeEnd = 296249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Remove(int startIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Remove_Public_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0006CDC4 File Offset: 0x0006AFC4
		[CallerCount(65)]
		[CachedScanResults(RefRangeStart = 296258, RefRangeEnd = 296323, XrefRangeStart = 296253, XrefRangeEnd = 296258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0006CE14 File Offset: 0x0006B014
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 296328, RefRangeEnd = 296374, XrefRangeStart = 296323, XrefRangeEnd = 296328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0006CE74 File Offset: 0x0006B074
		[CallerCount(24)]
		[CachedScanResults(RefRangeStart = 296379, RefRangeEnd = 296403, XrefRangeStart = 296374, XrefRangeEnd = 296379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0006CEE8 File Offset: 0x0006B0E8
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 296408, RefRangeEnd = 296421, XrefRangeStart = 296403, XrefRangeEnd = 296408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x0006CF44 File Offset: 0x0006B144
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 296426, RefRangeEnd = 296443, XrefRangeStart = 296421, XrefRangeEnd = 296426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x0006CFA4 File Offset: 0x0006B1A4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 296448, RefRangeEnd = 296455, XrefRangeStart = 296443, XrefRangeEnd = 296448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x0006D018 File Offset: 0x0006B218
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296460, RefRangeEnd = 296462, XrefRangeStart = 296455, XrefRangeEnd = 296460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x0006D0A0 File Offset: 0x0006B2A0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 296467, RefRangeEnd = 296480, XrefRangeStart = 296462, XrefRangeEnd = 296467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(IFormatProvider provider, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x0006D110 File Offset: 0x0006B310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296480, XrefRangeEnd = 296484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatHelper(IFormatProvider provider, string format, ParamsArray args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x0006D178 File Offset: 0x0006B378
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296486, RefRangeEnd = 296488, XrefRangeStart = 296484, XrefRangeEnd = 296486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Copy(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Copy_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0006D1B4 File Offset: 0x0006B3B4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 296492, RefRangeEnd = 296503, XrefRangeStart = 296488, XrefRangeEnd = 296492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0006D204 File Offset: 0x0006B404
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 296507, RefRangeEnd = 296516, XrefRangeStart = 296503, XrefRangeEnd = 296507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(Object arg0, Object arg1, Object arg2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0006D264 File Offset: 0x0006B464
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 296553, RefRangeEnd = 296562, XrefRangeStart = 296516, XrefRangeEnd = 296553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0006D2B0 File Offset: 0x0006B4B0
		[CallerCount(699)]
		[CachedScanResults(RefRangeStart = 296566, RefRangeEnd = 297265, XrefRangeStart = 296562, XrefRangeEnd = 296566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x0006D300 File Offset: 0x0006B500
		[CallerCount(274)]
		[CachedScanResults(RefRangeStart = 297267, RefRangeEnd = 297541, XrefRangeStart = 297265, XrefRangeEnd = 297267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0006D360 File Offset: 0x0006B560
		[CallerCount(119)]
		[CachedScanResults(RefRangeStart = 297549, RefRangeEnd = 297668, XrefRangeStart = 297541, XrefRangeEnd = 297549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat(string str0, string str1, string str2, string str3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x0006D3D4 File Offset: 0x0006B5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297671, RefRangeEnd = 297673, XrefRangeStart = 297668, XrefRangeEnd = 297671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ConcatArray(Il2CppStringArray values, int totalLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x0006D420 File Offset: 0x0006B620
		[CallerCount(59)]
		[CachedScanResults(RefRangeStart = 297701, RefRangeEnd = 297760, XrefRangeStart = 297673, XrefRangeEnd = 297701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Concat([Optional] Il2CppStringArray values)
		{
			if (values == null)
			{
				values = new Il2CppStringArray(0L);
			}
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x0006D46C File Offset: 0x0006B66C
		[CallerCount(0)]
		public unsafe TypeCode GetTypeCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0006D4A8 File Offset: 0x0006B6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297760, XrefRangeEnd = 297764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_IConvertible_ToBoolean(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x0006D4F8 File Offset: 0x0006B6F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297764, XrefRangeEnd = 297768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char System_IConvertible_ToChar(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0006D548 File Offset: 0x0006B748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297768, XrefRangeEnd = 297772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe sbyte System_IConvertible_ToSByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x0006D598 File Offset: 0x0006B798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297772, XrefRangeEnd = 297776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe byte System_IConvertible_ToByte(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0006D5E8 File Offset: 0x0006B7E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297776, XrefRangeEnd = 297780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe short System_IConvertible_ToInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0006D638 File Offset: 0x0006B838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297780, XrefRangeEnd = 297784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ushort System_IConvertible_ToUInt16(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x0006D688 File Offset: 0x0006B888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297784, XrefRangeEnd = 297788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int System_IConvertible_ToInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0006D6D8 File Offset: 0x0006B8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297788, XrefRangeEnd = 297792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe uint System_IConvertible_ToUInt32(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x0006D728 File Offset: 0x0006B928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297792, XrefRangeEnd = 297796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe long System_IConvertible_ToInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0006D778 File Offset: 0x0006B978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297796, XrefRangeEnd = 297800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ulong System_IConvertible_ToUInt64(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0006D7C8 File Offset: 0x0006B9C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297800, XrefRangeEnd = 297804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float System_IConvertible_ToSingle(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x0006D818 File Offset: 0x0006BA18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297804, XrefRangeEnd = 297808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe double System_IConvertible_ToDouble(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x0006D868 File Offset: 0x0006BA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297808, XrefRangeEnd = 297812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Decimal System_IConvertible_ToDecimal(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x0006D8B8 File Offset: 0x0006BAB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297812, XrefRangeEnd = 297816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DateTime System_IConvertible_ToDateTime(IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0006D908 File Offset: 0x0006BB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297816, XrefRangeEnd = 297820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_IConvertible_ToType(Type type, IFormatProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x0006D96C File Offset: 0x0006BB6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297820, XrefRangeEnd = 297824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator<char> System_Collections_Generic_IEnumerable_System_Char__GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<char>>(intPtr3) : null;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x0006D9AC File Offset: 0x0006BBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297824, XrefRangeEnd = 297828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06001030 RID: 4144 RVA: 0x0006D9EC File Offset: 0x0006BBEC
		public unsafe int Length
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8799, RefRangeEnd = 8800, XrefRangeStart = 8799, XrefRangeEnd = 8800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0006DA28 File Offset: 0x0006BC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297833, RefRangeEnd = 297834, XrefRangeStart = 297828, XrefRangeEnd = 297833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenA;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lenB;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x0006DAB4 File Offset: 0x0006BCB4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 297836, RefRangeEnd = 297841, XrefRangeStart = 297834, XrefRangeEnd = 297836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0006DB1C File Offset: 0x0006BD1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297841, RefRangeEnd = 297845, XrefRangeStart = 297841, XrefRangeEnd = 297841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUnchecked(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x0006DB84 File Offset: 0x0006BD84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297847, RefRangeEnd = 297849, XrefRangeStart = 297845, XrefRangeEnd = 297847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfUnchecked(string value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x0006DBF0 File Offset: 0x0006BDF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297851, RefRangeEnd = 297855, XrefRangeStart = 297849, XrefRangeEnd = 297851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x0006DC5C File Offset: 0x0006BE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297855, XrefRangeEnd = 297857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IndexOfAnyUnchecked(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x0006DCC8 File Offset: 0x0006BEC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297858, RefRangeEnd = 297860, XrefRangeStart = 297857, XrefRangeEnd = 297858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0006DD30 File Offset: 0x0006BF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297860, RefRangeEnd = 297861, XrefRangeStart = 297860, XrefRangeEnd = 297860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfUnchecked(char value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x0006DD98 File Offset: 0x0006BF98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297862, RefRangeEnd = 297864, XrefRangeStart = 297861, XrefRangeEnd = 297862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAny(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x0006DE04 File Offset: 0x0006C004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297864, XrefRangeEnd = 297865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOfAnyUnchecked(Il2CppStructArray<char> anyOf, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anyOf);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x0006DE70 File Offset: 0x0006C070
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 297866, RefRangeEnd = 297870, XrefRangeStart = 297865, XrefRangeEnd = 297866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strA);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexA;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strB);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref indexB;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297870, XrefRangeEnd = 297877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceInternal(char oldChar, char newChar)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref oldChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newChar;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0006DF44 File Offset: 0x0006C144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297877, XrefRangeEnd = 297880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceInternal(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x0006DFA0 File Offset: 0x0006C1A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297887, RefRangeEnd = 297889, XrefRangeStart = 297880, XrefRangeEnd = 297887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceUnchecked(string oldValue, string newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x0006DFFC File Offset: 0x0006C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297889, XrefRangeEnd = 297902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReplaceFallback(string oldValue, string newValue, int testedCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref testedCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x0006E064 File Offset: 0x0006C264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 297911, RefRangeEnd = 297913, XrefRangeStart = 297902, XrefRangeEnd = 297911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string PadHelper(int totalWidth, char paddingChar, bool isRightPadded)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref totalWidth;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paddingChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRightPadded;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x0006E0C4 File Offset: 0x0006C2C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 297913, RefRangeEnd = 297914, XrefRangeStart = 297913, XrefRangeEnd = 297913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool StartsWithOrdinalUnchecked(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0006E114 File Offset: 0x0006C314
		[CallerCount(0)]
		public unsafe bool IsAscii()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_IsAscii_Internal_Boolean_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0006E150 File Offset: 0x0006C350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297914, XrefRangeEnd = 297916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CharCopy(char* dest, char* src, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0006E19C File Offset: 0x0006C39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297916, XrefRangeEnd = 297917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memset(byte* dest, int val, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x0006E1EC File Offset: 0x0006C3EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297917, XrefRangeEnd = 297918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void memcpy(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x0006E238 File Offset: 0x0006C438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297918, XrefRangeEnd = 297920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void bzero(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0006E278 File Offset: 0x0006C478
		[CallerCount(0)]
		public unsafe static void bzero_aligned_1(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0006E2B8 File Offset: 0x0006C4B8
		[CallerCount(0)]
		public unsafe static void bzero_aligned_2(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x0006E2F8 File Offset: 0x0006C4F8
		[CallerCount(0)]
		public unsafe static void bzero_aligned_4(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0006E338 File Offset: 0x0006C538
		[CallerCount(0)]
		public unsafe static void bzero_aligned_8(byte* dest, int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0006E378 File Offset: 0x0006C578
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_1(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_2(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x0006E410 File Offset: 0x0006C610
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_4(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x0006E45C File Offset: 0x0006C65C
		[CallerCount(0)]
		public unsafe static void memcpy_aligned_8(byte* dest, byte* src, int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = dest;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = src;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x0006E4A8 File Offset: 0x0006C6A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297920, XrefRangeEnd = 297922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0006E4EC File Offset: 0x0006C6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 297922, XrefRangeEnd = 297923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x0006E54C File Offset: 0x0006C74C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 297924, RefRangeEnd = 297927, XrefRangeStart = 297923, XrefRangeEnd = 297924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0006E590 File Offset: 0x0006C790
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 297928, RefRangeEnd = 297942, XrefRangeStart = 297927, XrefRangeEnd = 297928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char* value, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0006E5F0 File Offset: 0x0006C7F0
		[CallerCount(52)]
		[CachedScanResults(RefRangeStart = 297943, RefRangeEnd = 297995, XrefRangeStart = 297942, XrefRangeEnd = 297943, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val, int startIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0006E654 File Offset: 0x0006C854
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 297999, RefRangeEnd = 298019, XrefRangeStart = 297995, XrefRangeEnd = 297999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(Il2CppStructArray<char> val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(val);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x0006E69C File Offset: 0x0006C89C
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 298022, RefRangeEnd = 298033, XrefRangeStart = 298019, XrefRangeEnd = 298022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(char c, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x0006E6F0 File Offset: 0x0006C8F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 298040, RefRangeEnd = 298044, XrefRangeStart = 298033, XrefRangeEnd = 298040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string CreateString(sbyte* value, int startIndex, int length, Encoding enc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(String.NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0, IL2CPP.ManagedStringToIl2Cpp(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00005EE8 File Offset: 0x000040E8
		public static string Join(string separator, params string[] value)
		{
			return String.Join(separator, new Il2CppStringArray(value));
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00005EF6 File Offset: 0x000040F6
		public Il2CppStringArray Split(params char[] separator)
		{
			return this.Split(new Il2CppStructArray<char>(separator));
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00005F04 File Offset: 0x00004104
		public string Trim(params char[] trimChars)
		{
			return this.Trim(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00005F12 File Offset: 0x00004112
		public string TrimEnd(params char[] trimChars)
		{
			return this.TrimEnd(new Il2CppStructArray<char>(trimChars));
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00005F20 File Offset: 0x00004120
		public static string Format(string format, params Object[] args)
		{
			return String.Format(format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00005F2E File Offset: 0x0000412E
		public static string Format(IFormatProvider provider, string format, params Object[] args)
		{
			return String.Format(provider, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00005F3D File Offset: 0x0000413D
		public static string Concat(params Object[] args)
		{
			return String.Concat(new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00005F4A File Offset: 0x0000414A
		public static string Concat(params string[] values)
		{
			return String.Concat(new Il2CppStringArray(values));
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00005F57 File Offset: 0x00004157
		public String(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001060 RID: 4192 RVA: 0x0006E764 File Offset: 0x0006C964
		// (set) Token: 0x06001061 RID: 4193 RVA: 0x00005F60 File Offset: 0x00004160
		public unsafe int m_stringLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_stringLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_stringLength)) = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001062 RID: 4194 RVA: 0x0006E78C File Offset: 0x0006C98C
		// (set) Token: 0x06001063 RID: 4195 RVA: 0x00005F7B File Offset: 0x0000417B
		public unsafe char m_firstChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_firstChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.ManagedStringToIl2Cpp(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(String.NativeFieldInfoPtr_m_firstChar)) = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001064 RID: 4196 RVA: 0x0006E7B4 File Offset: 0x0006C9B4
		// (set) Token: 0x06001065 RID: 4197 RVA: 0x00005F96 File Offset: 0x00004196
		public unsafe static int TrimHead
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimHead, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimHead, (void*)(&value));
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x0006E7D0 File Offset: 0x0006C9D0
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x00005FA4 File Offset: 0x000041A4
		public unsafe static int TrimTail
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimTail, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimTail, (void*)(&value));
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x0006E7EC File Offset: 0x0006C9EC
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x00005FB2 File Offset: 0x000041B2
		public unsafe static int TrimBoth
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_TrimBoth, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_TrimBoth, (void*)(&value));
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0006E808 File Offset: 0x0006CA08
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x00005FC0 File Offset: 0x000041C0
		public unsafe static string Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_Empty, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600106C RID: 4204 RVA: 0x0006E828 File Offset: 0x0006CA28
		// (set) Token: 0x0600106D RID: 4205 RVA: 0x00005FD2 File Offset: 0x000041D2
		public unsafe static int charPtrAlignConst
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_charPtrAlignConst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_charPtrAlignConst, (void*)(&value));
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x0600106E RID: 4206 RVA: 0x0006E844 File Offset: 0x0006CA44
		// (set) Token: 0x0600106F RID: 4207 RVA: 0x00005FE0 File Offset: 0x000041E0
		public unsafe static int alignConst
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(String.NativeFieldInfoPtr_alignConst, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(String.NativeFieldInfoPtr_alignConst, (void*)(&value));
			}
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00005FEE File Offset: 0x000041EE
		public new static implicit operator String(string A_0)
		{
			if (A_0 == null)
			{
				return A_0;
			}
			return new String(IL2CPP.ManagedStringToIl2Cpp(A_0));
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00006000 File Offset: 0x00004200
		public static implicit operator string(String A_0)
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(A_0);
			if (intPtr == 0)
			{
				return null;
			}
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x04000D47 RID: 3399
		private static readonly IntPtr NativeFieldInfoPtr_m_stringLength;

		// Token: 0x04000D48 RID: 3400
		private static readonly IntPtr NativeFieldInfoPtr_m_firstChar;

		// Token: 0x04000D49 RID: 3401
		private static readonly IntPtr NativeFieldInfoPtr_TrimHead;

		// Token: 0x04000D4A RID: 3402
		private static readonly IntPtr NativeFieldInfoPtr_TrimTail;

		// Token: 0x04000D4B RID: 3403
		private static readonly IntPtr NativeFieldInfoPtr_TrimBoth;

		// Token: 0x04000D4C RID: 3404
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04000D4D RID: 3405
		private static readonly IntPtr NativeFieldInfoPtr_charPtrAlignConst;

		// Token: 0x04000D4E RID: 3406
		private static readonly IntPtr NativeFieldInfoPtr_alignConst;

		// Token: 0x04000D4F RID: 3407
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_0;

		// Token: 0x04000D50 RID: 3408
		private static readonly IntPtr NativeMethodInfoPtr_Join_Public_Static_String_String_Il2CppStringArray_Int32_Int32_0;

		// Token: 0x04000D51 RID: 3409
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalIgnoreCaseHelper_Private_Static_Int32_String_String_0;

		// Token: 0x04000D52 RID: 3410
		private static readonly IntPtr NativeMethodInfoPtr_EqualsHelper_Private_Static_Boolean_String_String_0;

		// Token: 0x04000D53 RID: 3411
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalHelper_Private_Static_Int32_String_String_0;

		// Token: 0x04000D54 RID: 3412
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000D55 RID: 3413
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_String_0;

		// Token: 0x04000D56 RID: 3414
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000D57 RID: 3415
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_0;

		// Token: 0x04000D58 RID: 3416
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Static_Boolean_String_String_StringComparison_0;

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_String_String_0;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_String_String_0;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeMethodInfoPtr_get_Chars_Public_get_Char_Int32_0;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrEmpty_Public_Static_Boolean_String_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_IsNullOrWhiteSpace_Public_Static_Boolean_String_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr_GetLegacyNonRandomizedHashCode_Internal_Int32_0;

		// Token: 0x04000D62 RID: 3426
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D63 RID: 3427
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStructArray_1_Char_StringSplitOptions_0;

		// Token: 0x04000D64 RID: 3428
		private static readonly IntPtr NativeMethodInfoPtr_SplitInternal_Internal_Il2CppStringArray_Il2CppStructArray_1_Char_Int32_StringSplitOptions_0;

		// Token: 0x04000D65 RID: 3429
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_StringSplitOptions_0;

		// Token: 0x04000D66 RID: 3430
		private static readonly IntPtr NativeMethodInfoPtr_Split_Public_Il2CppStringArray_Il2CppStringArray_Int32_StringSplitOptions_0;

		// Token: 0x04000D67 RID: 3431
		private static readonly IntPtr NativeMethodInfoPtr_InternalSplitKeepEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000D68 RID: 3432
		private static readonly IntPtr NativeMethodInfoPtr_InternalSplitOmitEmptyEntries_Private_Il2CppStringArray_Il2CppStructArray_1_Int32_Il2CppStructArray_1_Int32_Int32_Int32_0;

		// Token: 0x04000D69 RID: 3433
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStructArray_1_Char_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000D6A RID: 3434
		private static readonly IntPtr NativeMethodInfoPtr_MakeSeparatorList_Private_Int32_Il2CppStringArray_byref_Il2CppStructArray_1_Int32_byref_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000D6B RID: 3435
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_0;

		// Token: 0x04000D6C RID: 3436
		private static readonly IntPtr NativeMethodInfoPtr_Substring_Public_String_Int32_Int32_0;

		// Token: 0x04000D6D RID: 3437
		private static readonly IntPtr NativeMethodInfoPtr_InternalSubString_Private_String_Int32_Int32_0;

		// Token: 0x04000D6E RID: 3438
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D6F RID: 3439
		private static readonly IntPtr NativeMethodInfoPtr_TrimEnd_Public_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D70 RID: 3440
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_0;

		// Token: 0x04000D71 RID: 3441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_Int32_0;

		// Token: 0x04000D72 RID: 3442
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_SByte_Int32_Int32_Encoding_0;

		// Token: 0x04000D73 RID: 3443
		private static readonly IntPtr NativeMethodInfoPtr_CreateStringFromEncoding_Internal_Static_String_ptr_Byte_Int32_Encoding_0;

		// Token: 0x04000D74 RID: 3444
		private static readonly IntPtr NativeMethodInfoPtr_Normalize_Public_String_NormalizationForm_0;

		// Token: 0x04000D75 RID: 3445
		private static readonly IntPtr NativeMethodInfoPtr_FastAllocateString_Internal_Static_String_Int32_0;

		// Token: 0x04000D76 RID: 3446
		private static readonly IntPtr NativeMethodInfoPtr_FillStringChecked_Private_Static_Void_String_Int32_String_0;

		// Token: 0x04000D77 RID: 3447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000D78 RID: 3448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D79 RID: 3449
		private static readonly IntPtr NativeMethodInfoPtr_wstrcpy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

		// Token: 0x04000D7A RID: 3450
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharArray_Private_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D7B RID: 3451
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharArrayStartLength_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000D7C RID: 3452
		private static readonly IntPtr NativeMethodInfoPtr_wcslen_Private_Static_Int32_ptr_Char_0;

		// Token: 0x04000D7D RID: 3453
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharPtr_Private_String_ptr_Char_0;

		// Token: 0x04000D7E RID: 3454
		private static readonly IntPtr NativeMethodInfoPtr_CtorCharPtrStartLength_Private_String_ptr_Char_Int32_Int32_0;

		// Token: 0x04000D7F RID: 3455
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_0;

		// Token: 0x04000D80 RID: 3456
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_0;

		// Token: 0x04000D81 RID: 3457
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_0;

		// Token: 0x04000D82 RID: 3458
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_StringComparison_0;

		// Token: 0x04000D83 RID: 3459
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_String_Boolean_CultureInfo_0;

		// Token: 0x04000D84 RID: 3460
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000D85 RID: 3461
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_CultureInfo_CompareOptions_0;

		// Token: 0x04000D86 RID: 3462
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_String_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000D87 RID: 3463
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Object_0;

		// Token: 0x04000D88 RID: 3464
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_String_0;

		// Token: 0x04000D89 RID: 3465
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_String_0;

		// Token: 0x04000D8A RID: 3466
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinal_Public_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000D8B RID: 3467
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_String_0;

		// Token: 0x04000D8C RID: 3468
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_0;

		// Token: 0x04000D8D RID: 3469
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000D8E RID: 3470
		private static readonly IntPtr NativeMethodInfoPtr_EndsWith_Internal_Boolean_Char_0;

		// Token: 0x04000D8F RID: 3471
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_0;

		// Token: 0x04000D90 RID: 3472
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000D91 RID: 3473
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D92 RID: 3474
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000D93 RID: 3475
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_0;

		// Token: 0x04000D94 RID: 3476
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_0;

		// Token: 0x04000D95 RID: 3477
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x04000D96 RID: 3478
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_StringComparison_0;

		// Token: 0x04000D97 RID: 3479
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000D98 RID: 3480
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_0;

		// Token: 0x04000D99 RID: 3481
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_0;

		// Token: 0x04000D9A RID: 3482
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_0;

		// Token: 0x04000D9B RID: 3483
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000D9C RID: 3484
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_0;

		// Token: 0x04000D9D RID: 3485
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_StringComparison_0;

		// Token: 0x04000D9E RID: 3486
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_String_Int32_Int32_StringComparison_0;

		// Token: 0x04000D9F RID: 3487
		private static readonly IntPtr NativeMethodInfoPtr_PadLeft_Public_String_Int32_Char_0;

		// Token: 0x04000DA0 RID: 3488
		private static readonly IntPtr NativeMethodInfoPtr_PadRight_Public_String_Int32_Char_0;

		// Token: 0x04000DA1 RID: 3489
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_0;

		// Token: 0x04000DA2 RID: 3490
		private static readonly IntPtr NativeMethodInfoPtr_StartsWith_Public_Boolean_String_StringComparison_0;

		// Token: 0x04000DA3 RID: 3491
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_0;

		// Token: 0x04000DA4 RID: 3492
		private static readonly IntPtr NativeMethodInfoPtr_ToLower_Public_String_CultureInfo_0;

		// Token: 0x04000DA5 RID: 3493
		private static readonly IntPtr NativeMethodInfoPtr_ToLowerInvariant_Public_String_0;

		// Token: 0x04000DA6 RID: 3494
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_0;

		// Token: 0x04000DA7 RID: 3495
		private static readonly IntPtr NativeMethodInfoPtr_ToUpper_Public_String_CultureInfo_0;

		// Token: 0x04000DA8 RID: 3496
		private static readonly IntPtr NativeMethodInfoPtr_ToUpperInvariant_Public_String_0;

		// Token: 0x04000DA9 RID: 3497
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DAA RID: 3498
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_IFormatProvider_0;

		// Token: 0x04000DAB RID: 3499
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04000DAC RID: 3500
		private static readonly IntPtr NativeMethodInfoPtr_IsBOMWhitespace_Private_Static_Boolean_Char_0;

		// Token: 0x04000DAD RID: 3501
		private static readonly IntPtr NativeMethodInfoPtr_Trim_Public_String_0;

		// Token: 0x04000DAE RID: 3502
		private static readonly IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_Int32_0;

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeMethodInfoPtr_TrimHelper_Private_String_Il2CppStructArray_1_Char_Int32_0;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeMethodInfoPtr_CreateTrimmedString_Private_String_Int32_Int32_0;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_String_Int32_String_0;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_Char_Char_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_Replace_Public_String_String_String_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_Int32_0;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_String_Int32_0;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_0;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Object_Object_Object_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Object_Object_Object_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_Format_Public_Static_String_IFormatProvider_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_FormatHelper_Private_Static_String_IFormatProvider_String_ParamsArray_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Static_String_String_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Object_Object_Object_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_0;

		// Token: 0x04000DC5 RID: 3525
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_String_String_String_String_0;

		// Token: 0x04000DC6 RID: 3526
		private static readonly IntPtr NativeMethodInfoPtr_ConcatArray_Private_Static_String_Il2CppStringArray_Int32_0;

		// Token: 0x04000DC7 RID: 3527
		private static readonly IntPtr NativeMethodInfoPtr_Concat_Public_Static_String_Il2CppStringArray_0;

		// Token: 0x04000DC8 RID: 3528
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeCode_Public_Virtual_Final_New_TypeCode_0;

		// Token: 0x04000DC9 RID: 3529
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToBoolean_Private_Virtual_Final_New_Boolean_IFormatProvider_0;

		// Token: 0x04000DCA RID: 3530
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToChar_Private_Virtual_Final_New_Char_IFormatProvider_0;

		// Token: 0x04000DCB RID: 3531
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSByte_Private_Virtual_Final_New_SByte_IFormatProvider_0;

		// Token: 0x04000DCC RID: 3532
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToByte_Private_Virtual_Final_New_Byte_IFormatProvider_0;

		// Token: 0x04000DCD RID: 3533
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt16_Private_Virtual_Final_New_Int16_IFormatProvider_0;

		// Token: 0x04000DCE RID: 3534
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt16_Private_Virtual_Final_New_UInt16_IFormatProvider_0;

		// Token: 0x04000DCF RID: 3535
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt32_Private_Virtual_Final_New_Int32_IFormatProvider_0;

		// Token: 0x04000DD0 RID: 3536
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt32_Private_Virtual_Final_New_UInt32_IFormatProvider_0;

		// Token: 0x04000DD1 RID: 3537
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToInt64_Private_Virtual_Final_New_Int64_IFormatProvider_0;

		// Token: 0x04000DD2 RID: 3538
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToUInt64_Private_Virtual_Final_New_UInt64_IFormatProvider_0;

		// Token: 0x04000DD3 RID: 3539
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToSingle_Private_Virtual_Final_New_Single_IFormatProvider_0;

		// Token: 0x04000DD4 RID: 3540
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDouble_Private_Virtual_Final_New_Double_IFormatProvider_0;

		// Token: 0x04000DD5 RID: 3541
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDecimal_Private_Virtual_Final_New_Decimal_IFormatProvider_0;

		// Token: 0x04000DD6 RID: 3542
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToDateTime_Private_Virtual_Final_New_DateTime_IFormatProvider_0;

		// Token: 0x04000DD7 RID: 3543
		private static readonly IntPtr NativeMethodInfoPtr_System_IConvertible_ToType_Private_Virtual_Final_New_Object_Type_IFormatProvider_0;

		// Token: 0x04000DD8 RID: 3544
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Char__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Char_0;

		// Token: 0x04000DD9 RID: 3545
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000DDA RID: 3546
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04000DDB RID: 3547
		private static readonly IntPtr NativeMethodInfoPtr_CompareOrdinalUnchecked_Internal_Static_Int32_String_Int32_Int32_String_Int32_Int32_0;

		// Token: 0x04000DDC RID: 3548
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x04000DDD RID: 3549
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0;

		// Token: 0x04000DDE RID: 3550
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfUnchecked_Internal_Int32_String_Int32_Int32_0;

		// Token: 0x04000DDF RID: 3551
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DE0 RID: 3552
		private static readonly IntPtr NativeMethodInfoPtr_IndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DE1 RID: 3553
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Public_Int32_Char_Int32_Int32_0;

		// Token: 0x04000DE2 RID: 3554
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfUnchecked_Internal_Int32_Char_Int32_Int32_0;

		// Token: 0x04000DE3 RID: 3555
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAny_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DE4 RID: 3556
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOfAnyUnchecked_Private_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DE5 RID: 3557
		private static readonly IntPtr NativeMethodInfoPtr_nativeCompareOrdinalEx_Internal_Static_Int32_String_Int32_String_Int32_Int32_0;

		// Token: 0x04000DE6 RID: 3558
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInternal_Private_String_Char_Char_0;

		// Token: 0x04000DE7 RID: 3559
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceInternal_Internal_String_String_String_0;

		// Token: 0x04000DE8 RID: 3560
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceUnchecked_Private_String_String_String_0;

		// Token: 0x04000DE9 RID: 3561
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceFallback_Private_String_String_String_Int32_0;

		// Token: 0x04000DEA RID: 3562
		private static readonly IntPtr NativeMethodInfoPtr_PadHelper_Private_String_Int32_Char_Boolean_0;

		// Token: 0x04000DEB RID: 3563
		private static readonly IntPtr NativeMethodInfoPtr_StartsWithOrdinalUnchecked_Internal_Boolean_String_0;

		// Token: 0x04000DEC RID: 3564
		private static readonly IntPtr NativeMethodInfoPtr_IsAscii_Internal_Boolean_0;

		// Token: 0x04000DED RID: 3565
		private static readonly IntPtr NativeMethodInfoPtr_CharCopy_Internal_Static_Void_ptr_Char_ptr_Char_Int32_0;

		// Token: 0x04000DEE RID: 3566
		private static readonly IntPtr NativeMethodInfoPtr_memset_Private_Static_Void_ptr_Byte_Int32_Int32_0;

		// Token: 0x04000DEF RID: 3567
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_Private_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000DF0 RID: 3568
		private static readonly IntPtr NativeMethodInfoPtr_bzero_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000DF1 RID: 3569
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_1_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000DF2 RID: 3570
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_2_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000DF3 RID: 3571
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_4_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000DF4 RID: 3572
		private static readonly IntPtr NativeMethodInfoPtr_bzero_aligned_8_Internal_Static_Void_ptr_Byte_Int32_0;

		// Token: 0x04000DF5 RID: 3573
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_1_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000DF6 RID: 3574
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_2_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000DF7 RID: 3575
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_4_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000DF8 RID: 3576
		private static readonly IntPtr NativeMethodInfoPtr_memcpy_aligned_8_Internal_Static_Void_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x04000DF9 RID: 3577
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_0;

		// Token: 0x04000DFA RID: 3578
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_0;

		// Token: 0x04000DFB RID: 3579
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_0;

		// Token: 0x04000DFC RID: 3580
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_Char_Int32_Int32_0;

		// Token: 0x04000DFD RID: 3581
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x04000DFE RID: 3582
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Il2CppStructArray_1_Char_0;

		// Token: 0x04000DFF RID: 3583
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_Char_Int32_0;

		// Token: 0x04000E00 RID: 3584
		private static readonly IntPtr NativeMethodInfoPtr_CreateString_Private_String_ptr_SByte_Int32_Int32_Encoding_0;
	}
}
