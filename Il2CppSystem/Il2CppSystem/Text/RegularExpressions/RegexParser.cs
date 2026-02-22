using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200005D RID: 93
	public sealed class RegexParser : Object
	{
		// Token: 0x06000670 RID: 1648 RVA: 0x0002879C File Offset: 0x0002699C
		// Note: this type is marked as 'beforefieldinit'.
		static RegexParser()
		{
			Il2CppClassPointerStore<RegexParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexParser>.NativeClassPtr);
			RegexParser.NativeFieldInfoPtr__stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_stack");
			RegexParser.NativeFieldInfoPtr__group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_group");
			RegexParser.NativeFieldInfoPtr__alternation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_alternation");
			RegexParser.NativeFieldInfoPtr__concatenation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_concatenation");
			RegexParser.NativeFieldInfoPtr__unit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_unit");
			RegexParser.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_pattern");
			RegexParser.NativeFieldInfoPtr__currentPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_currentPos");
			RegexParser.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_culture");
			RegexParser.NativeFieldInfoPtr__autocap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_autocap");
			RegexParser.NativeFieldInfoPtr__capcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capcount");
			RegexParser.NativeFieldInfoPtr__captop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_captop");
			RegexParser.NativeFieldInfoPtr__capsize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capsize");
			RegexParser.NativeFieldInfoPtr__caps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_caps");
			RegexParser.NativeFieldInfoPtr__capnames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnames");
			RegexParser.NativeFieldInfoPtr__capnumlist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnumlist");
			RegexParser.NativeFieldInfoPtr__capnamelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_capnamelist");
			RegexParser.NativeFieldInfoPtr__options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_options");
			RegexParser.NativeFieldInfoPtr__optionsStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_optionsStack");
			RegexParser.NativeFieldInfoPtr__ignoreNextParen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_ignoreNextParen");
			RegexParser.NativeFieldInfoPtr__category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, "_category");
			RegexParser.NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664145);
			RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664146);
			RegexParser.NativeMethodInfoPtr_SetPattern_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664147);
			RegexParser.NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664148);
			RegexParser.NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664149);
			RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664150);
			RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664151);
			RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664152);
			RegexParser.NativeMethodInfoPtr_ScanBlank_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664153);
			RegexParser.NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664154);
			RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664155);
			RegexParser.NativeMethodInfoPtr_ScanCapname_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664156);
			RegexParser.NativeMethodInfoPtr_ScanOctal_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664157);
			RegexParser.NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664158);
			RegexParser.NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664159);
			RegexParser.NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664160);
			RegexParser.NativeMethodInfoPtr_ScanControl_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664161);
			RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664162);
			RegexParser.NativeMethodInfoPtr_ScanOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664163);
			RegexParser.NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664164);
			RegexParser.NativeMethodInfoPtr_ParseProperty_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664165);
			RegexParser.NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664166);
			RegexParser.NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664167);
			RegexParser.NativeMethodInfoPtr_CountCaptures_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664168);
			RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664169);
			RegexParser.NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664170);
			RegexParser.NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664171);
			RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664172);
			RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664173);
			RegexParser.NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664174);
			RegexParser.NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664175);
			RegexParser.NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664176);
			RegexParser.NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664177);
			RegexParser.NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664178);
			RegexParser.NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664179);
			RegexParser.NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664180);
			RegexParser.NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664181);
			RegexParser.NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664182);
			RegexParser.NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664183);
			RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664184);
			RegexParser.NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664185);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664186);
			RegexParser.NativeMethodInfoPtr_PushGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664187);
			RegexParser.NativeMethodInfoPtr_PopGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664188);
			RegexParser.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664189);
			RegexParser.NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664190);
			RegexParser.NativeMethodInfoPtr_AddAlternate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664191);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664192);
			RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664193);
			RegexParser.NativeMethodInfoPtr_Unit_Internal_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664194);
			RegexParser.NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664195);
			RegexParser.NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664196);
			RegexParser.NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664197);
			RegexParser.NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664198);
			RegexParser.NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664199);
			RegexParser.NativeMethodInfoPtr_AddGroup_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664200);
			RegexParser.NativeMethodInfoPtr_PushOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664201);
			RegexParser.NativeMethodInfoPtr_PopOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664202);
			RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664203);
			RegexParser.NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664204);
			RegexParser.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664205);
			RegexParser.NativeMethodInfoPtr_Textpos_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664206);
			RegexParser.NativeMethodInfoPtr_Textto_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664207);
			RegexParser.NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664208);
			RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664209);
			RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664210);
			RegexParser.NativeMethodInfoPtr_MoveLeft_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664211);
			RegexParser.NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664212);
			RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664213);
			RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664214);
			RegexParser.NativeMethodInfoPtr_CharsRight_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexParser>.NativeClassPtr, 100664215);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00028EE8 File Offset: 0x000270E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39855, XrefRangeEnd = 39891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexTree Parse(string re, RegexOptions op)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(re);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexTree>(intPtr3) : null;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00028F3C File Offset: 0x0002713C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39891, XrefRangeEnd = 39902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexParser(CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00028F88 File Offset: 0x00027188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39902, XrefRangeEnd = 39904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPattern(string Re)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(Re);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_SetPattern_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00028FCC File Offset: 0x000271CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39904, XrefRangeEnd = 39908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset(RegexOptions topopts)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref topopts;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0002900C File Offset: 0x0002720C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39990, RefRangeEnd = 39991, XrefRangeStart = 39908, XrefRangeEnd = 39990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanRegex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0002904C File Offset: 0x0002724C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39991, XrefRangeEnd = 39992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass ScanCharClass(bool caseInsensitive)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caseInsensitive;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00029098 File Offset: 0x00027298
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40039, RefRangeEnd = 40045, XrefRangeStart = 39992, XrefRangeEnd = 40039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass ScanCharClass(bool caseInsensitive, bool scanOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref caseInsensitive;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scanOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000290F4 File Offset: 0x000272F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40061, RefRangeEnd = 40062, XrefRangeStart = 40045, XrefRangeEnd = 40061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanGroupOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00029134 File Offset: 0x00027334
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40087, RefRangeEnd = 40093, XrefRangeStart = 40062, XrefRangeEnd = 40087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanBlank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBlank_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00029168 File Offset: 0x00027368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40116, RefRangeEnd = 40117, XrefRangeStart = 40093, XrefRangeEnd = 40116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBackslash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x000291A8 File Offset: 0x000273A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40117, XrefRangeEnd = 40137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode ScanBasicBackslash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x000291E8 File Offset: 0x000273E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40144, RefRangeEnd = 40147, XrefRangeStart = 40137, XrefRangeEnd = 40144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ScanCapname()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCapname_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x00029220 File Offset: 0x00027420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40147, XrefRangeEnd = 40148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanOctal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOctal_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0002925C File Offset: 0x0002745C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40150, RefRangeEnd = 40154, XrefRangeStart = 40148, XrefRangeEnd = 40150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ScanDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00029298 File Offset: 0x00027498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40154, XrefRangeEnd = 40159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanHex(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000292E4 File Offset: 0x000274E4
		[CallerCount(0)]
		public unsafe static int HexDigit(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00029324 File Offset: 0x00027524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40159, XrefRangeEnd = 40160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanControl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanControl_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00029360 File Offset: 0x00027560
		[CallerCount(0)]
		public unsafe bool IsOnlyTopOption(RegexOptions option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref option;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x000293AC File Offset: 0x000275AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40169, RefRangeEnd = 40170, XrefRangeStart = 40160, XrefRangeEnd = 40169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x000293E0 File Offset: 0x000275E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40173, RefRangeEnd = 40174, XrefRangeStart = 40170, XrefRangeEnd = 40173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char ScanCharEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0002941C File Offset: 0x0002761C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40182, RefRangeEnd = 40184, XrefRangeStart = 40174, XrefRangeEnd = 40182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseProperty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_ParseProperty_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00029454 File Offset: 0x00027654
		[CallerCount(0)]
		public unsafe int TypeFromCode(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x000294A0 File Offset: 0x000276A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40184, RefRangeEnd = 40185, XrefRangeStart = 40184, XrefRangeEnd = 40184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexOptions OptionFromCode(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x000294E0 File Offset: 0x000276E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40223, RefRangeEnd = 40224, XrefRangeStart = 40185, XrefRangeEnd = 40223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CountCaptures()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CountCaptures_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00029514 File Offset: 0x00027714
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40231, RefRangeEnd = 40234, XrefRangeStart = 40224, XrefRangeEnd = 40231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureSlot(int i, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00029560 File Offset: 0x00027760
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40250, RefRangeEnd = 40251, XrefRangeStart = 40234, XrefRangeEnd = 40250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoteCaptureName(string name, int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x000295B0 File Offset: 0x000277B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40322, RefRangeEnd = 40323, XrefRangeStart = 40251, XrefRangeEnd = 40322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignNameSlots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x000295E4 File Offset: 0x000277E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40326, RefRangeEnd = 40327, XrefRangeStart = 40323, XrefRangeEnd = 40326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CaptureSlotFromName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00029634 File Offset: 0x00027834
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 40328, RefRangeEnd = 40332, XrefRangeStart = 40327, XrefRangeEnd = 40328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsCaptureSlot(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x00029680 File Offset: 0x00027880
		[CallerCount(0)]
		public unsafe bool IsCaptureName(string capname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000296D0 File Offset: 0x000278D0
		[CallerCount(0)]
		public unsafe bool UseOptionN()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0002970C File Offset: 0x0002790C
		[CallerCount(0)]
		public unsafe bool UseOptionI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00029748 File Offset: 0x00027948
		[CallerCount(0)]
		public unsafe bool UseOptionM()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x00029784 File Offset: 0x00027984
		[CallerCount(0)]
		public unsafe bool UseOptionS()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x000297C0 File Offset: 0x000279C0
		[CallerCount(0)]
		public unsafe bool UseOptionX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x000297FC File Offset: 0x000279FC
		[CallerCount(0)]
		public unsafe bool UseOptionE()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x00029838 File Offset: 0x00027A38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40333, RefRangeEnd = 40335, XrefRangeStart = 40332, XrefRangeEnd = 40333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpecial(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00029878 File Offset: 0x00027A78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40336, RefRangeEnd = 40337, XrefRangeStart = 40335, XrefRangeEnd = 40336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsStopperX(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x000298B8 File Offset: 0x00027AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40338, RefRangeEnd = 40339, XrefRangeStart = 40337, XrefRangeEnd = 40338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsQuantifier(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000298F8 File Offset: 0x00027AF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 40343, RefRangeEnd = 40346, XrefRangeStart = 40339, XrefRangeEnd = 40343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTrueQuantifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00029934 File Offset: 0x00027B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40346, XrefRangeEnd = 40347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSpace(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00029974 File Offset: 0x00027B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40372, RefRangeEnd = 40373, XrefRangeStart = 40347, XrefRangeEnd = 40372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(int pos, int cch, bool isReplacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cch;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isReplacement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000299D0 File Offset: 0x00027BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40373, RefRangeEnd = 40374, XrefRangeStart = 40373, XrefRangeEnd = 40373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00029A04 File Offset: 0x00027C04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40376, RefRangeEnd = 40377, XrefRangeStart = 40374, XrefRangeEnd = 40376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00029A38 File Offset: 0x00027C38
		[CallerCount(0)]
		public unsafe bool EmptyStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00029A74 File Offset: 0x00027C74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40384, RefRangeEnd = 40386, XrefRangeStart = 40377, XrefRangeEnd = 40384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGroup(RegexNode openGroup)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(openGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00029AB8 File Offset: 0x00027CB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40397, RefRangeEnd = 40398, XrefRangeStart = 40386, XrefRangeEnd = 40397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAlternate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddAlternate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x00029AEC File Offset: 0x00027CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40398, XrefRangeEnd = 40399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00029B20 File Offset: 0x00027D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40410, RefRangeEnd = 40411, XrefRangeStart = 40399, XrefRangeEnd = 40410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddConcatenate(bool lazy, int min, int max)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lazy;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00029B7C File Offset: 0x00027D7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexNode Unit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Unit_Internal_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr3) : null;
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00029BBC File Offset: 0x00027DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40419, RefRangeEnd = 40420, XrefRangeStart = 40411, XrefRangeEnd = 40419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitOne(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x00029BFC File Offset: 0x00027DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40428, RefRangeEnd = 40429, XrefRangeStart = 40420, XrefRangeEnd = 40428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitNotone(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00029C3C File Offset: 0x00027E3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40433, RefRangeEnd = 40435, XrefRangeStart = 40429, XrefRangeEnd = 40433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitSet(string cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00029C80 File Offset: 0x00027E80
		[CallerCount(0)]
		public unsafe void AddUnitNode(RegexNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00029CC4 File Offset: 0x00027EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40439, RefRangeEnd = 40441, XrefRangeStart = 40435, XrefRangeEnd = 40439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUnitType(int type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00029D04 File Offset: 0x00027F04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40444, RefRangeEnd = 40446, XrefRangeStart = 40441, XrefRangeEnd = 40444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddGroup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_AddGroup_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00029D38 File Offset: 0x00027F38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40450, RefRangeEnd = 40452, XrefRangeStart = 40446, XrefRangeEnd = 40450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PushOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00029D6C File Offset: 0x00027F6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40459, RefRangeEnd = 40461, XrefRangeStart = 40452, XrefRangeEnd = 40459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00029DA0 File Offset: 0x00027FA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 40462, RefRangeEnd = 40463, XrefRangeStart = 40461, XrefRangeEnd = 40462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EmptyOptionsStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00029DDC File Offset: 0x00027FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40468, RefRangeEnd = 40470, XrefRangeStart = 40463, XrefRangeEnd = 40468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopKeepOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00029E10 File Offset: 0x00028010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40470, XrefRangeEnd = 40486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentException MakeException(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00029E60 File Offset: 0x00028060
		[CallerCount(0)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textpos_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00029E9C File Offset: 0x0002809C
		[CallerCount(0)]
		public unsafe void Textto(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_Textto_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00029EDC File Offset: 0x000280DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40486, XrefRangeEnd = 40488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char MoveRightGetChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00029F18 File Offset: 0x00028118
		[CallerCount(0)]
		public unsafe void MoveRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00029F4C File Offset: 0x0002814C
		[CallerCount(0)]
		public unsafe void MoveRight(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00029F8C File Offset: 0x0002818C
		[CallerCount(0)]
		public unsafe void MoveLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_MoveLeft_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00029FC0 File Offset: 0x000281C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40488, XrefRangeEnd = 40490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0002A00C File Offset: 0x0002820C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40490, XrefRangeEnd = 40492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0002A048 File Offset: 0x00028248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 40492, XrefRangeEnd = 40494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char RightChar(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0002A094 File Offset: 0x00028294
		[CallerCount(0)]
		public unsafe int CharsRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexParser.NativeMethodInfoPtr_CharsRight_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000047EF File Offset: 0x000029EF
		public RegexParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0002A0D0 File Offset: 0x000282D0
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x000047F8 File Offset: 0x000029F8
		public unsafe RegexNode _stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0002A100 File Offset: 0x00028300
		// (set) Token: 0x060006BC RID: 1724 RVA: 0x00004817 File Offset: 0x00002A17
		public unsafe RegexNode _group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x0002A130 File Offset: 0x00028330
		// (set) Token: 0x060006BE RID: 1726 RVA: 0x00004836 File Offset: 0x00002A36
		public unsafe RegexNode _alternation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__alternation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006BF RID: 1727 RVA: 0x0002A160 File Offset: 0x00028360
		// (set) Token: 0x060006C0 RID: 1728 RVA: 0x00004855 File Offset: 0x00002A55
		public unsafe RegexNode _concatenation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__concatenation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0002A190 File Offset: 0x00028390
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x00004874 File Offset: 0x00002A74
		public unsafe RegexNode _unit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__unit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0002A1C0 File Offset: 0x000283C0
		// (set) Token: 0x060006C4 RID: 1732 RVA: 0x00004893 File Offset: 0x00002A93
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006C5 RID: 1733 RVA: 0x0002A1E8 File Offset: 0x000283E8
		// (set) Token: 0x060006C6 RID: 1734 RVA: 0x000048B2 File Offset: 0x00002AB2
		public unsafe int _currentPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__currentPos)) = value;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x0002A210 File Offset: 0x00028410
		// (set) Token: 0x060006C8 RID: 1736 RVA: 0x000048CD File Offset: 0x00002ACD
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0002A240 File Offset: 0x00028440
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x000048EC File Offset: 0x00002AEC
		public unsafe int _autocap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__autocap)) = value;
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x0002A268 File Offset: 0x00028468
		// (set) Token: 0x060006CC RID: 1740 RVA: 0x00004907 File Offset: 0x00002B07
		public unsafe int _capcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capcount)) = value;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x0002A290 File Offset: 0x00028490
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00004922 File Offset: 0x00002B22
		public unsafe int _captop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__captop)) = value;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0002A2B8 File Offset: 0x000284B8
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0000493D File Offset: 0x00002B3D
		public unsafe int _capsize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capsize)) = value;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0002A2E0 File Offset: 0x000284E0
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x00004958 File Offset: 0x00002B58
		public unsafe Hashtable _caps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__caps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0002A310 File Offset: 0x00028510
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00004977 File Offset: 0x00002B77
		public unsafe Hashtable _capnames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x0002A340 File Offset: 0x00028540
		// (set) Token: 0x060006D6 RID: 1750 RVA: 0x00004996 File Offset: 0x00002B96
		public unsafe Il2CppStructArray<int> _capnumlist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnumlist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0002A370 File Offset: 0x00028570
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x000049B5 File Offset: 0x00002BB5
		public unsafe List<string> _capnamelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__capnamelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0002A3A0 File Offset: 0x000285A0
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x000049D4 File Offset: 0x00002BD4
		public unsafe RegexOptions _options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__options)) = value;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0002A3C8 File Offset: 0x000285C8
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x000049EF File Offset: 0x00002BEF
		public unsafe List<RegexOptions> _optionsStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__optionsStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0002A3F8 File Offset: 0x000285F8
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x00004A0E File Offset: 0x00002C0E
		public unsafe bool _ignoreNextParen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexParser.NativeFieldInfoPtr__ignoreNextParen)) = value;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0002A420 File Offset: 0x00028620
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x00004A29 File Offset: 0x00002C29
		public unsafe static Il2CppStructArray<byte> _category
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexParser.NativeFieldInfoPtr__category, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexParser.NativeFieldInfoPtr__category, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr__stack;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr__group;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr__alternation;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr__concatenation;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr__unit;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr__currentPos;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr__autocap;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr__capcount;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr__captop;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr__capsize;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr__caps;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr__capnames;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr__capnumlist;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr__capnamelist;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr__options;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr__optionsStack;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr__ignoreNextParen;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeFieldInfoPtr__category;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_RegexTree_String_RegexOptions_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CultureInfo_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_SetPattern_Internal_Void_String_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Void_RegexOptions_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_ScanRegex_Internal_RegexNode_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharClass_Internal_RegexCharClass_Boolean_Boolean_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_ScanGroupOpen_Internal_RegexNode_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_ScanBlank_Internal_Void_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_ScanBackslash_Internal_RegexNode_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_ScanBasicBackslash_Internal_RegexNode_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_ScanCapname_Internal_String_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_ScanOctal_Internal_Char_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_ScanDecimal_Internal_Int32_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_ScanHex_Internal_Char_Int32_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_HexDigit_Internal_Static_Int32_Char_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_ScanControl_Internal_Char_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_IsOnlyTopOption_Internal_Boolean_RegexOptions_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_ScanOptions_Internal_Void_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_ScanCharEscape_Internal_Char_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_ParseProperty_Internal_String_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromCode_Internal_Int32_Char_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_OptionFromCode_Internal_Static_RegexOptions_Char_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_CountCaptures_Internal_Void_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureSlot_Internal_Void_Int32_Int32_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_NoteCaptureName_Internal_Void_String_Int32_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_AssignNameSlots_Internal_Void_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_CaptureSlotFromName_Internal_Int32_String_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureSlot_Internal_Boolean_Int32_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_IsCaptureName_Internal_Boolean_String_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionN_Internal_Boolean_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionI_Internal_Boolean_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionM_Internal_Boolean_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionS_Internal_Boolean_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionX_Internal_Boolean_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_UseOptionE_Internal_Boolean_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecial_Internal_Static_Boolean_Char_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_IsStopperX_Internal_Static_Boolean_Char_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_IsQuantifier_Internal_Static_Boolean_Char_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_IsTrueQuantifier_Internal_Boolean_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_IsSpace_Internal_Static_Boolean_Char_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_Int32_Int32_Boolean_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_PushGroup_Internal_Void_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_PopGroup_Internal_Void_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_EmptyStack_Internal_Boolean_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_StartGroup_Internal_Void_RegexNode_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_AddAlternate_Internal_Void_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_AddConcatenate_Internal_Void_Boolean_Int32_Int32_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_Unit_Internal_RegexNode_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitOne_Internal_Void_Char_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNotone_Internal_Void_Char_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitSet_Internal_Void_String_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitNode_Internal_Void_RegexNode_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_AddUnitType_Internal_Void_Int32_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_AddGroup_Internal_Void_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_PushOptions_Internal_Void_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_PopOptions_Internal_Void_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_EmptyOptionsStack_Internal_Boolean_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_PopKeepOptions_Internal_Void_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_MakeException_Internal_ArgumentException_String_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Internal_Int32_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Internal_Void_Int32_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_MoveRightGetChar_Internal_Char_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Internal_Void_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_MoveRight_Internal_Void_Int32_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_MoveLeft_Internal_Void_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Internal_Char_Int32_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Internal_Char_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_RightChar_Internal_Char_Int32_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_CharsRight_Internal_Int32_0;
	}
}
