using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200004F RID: 79
	public sealed class RegexCharClass : Object
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x00022B04 File Offset: 0x00020D04
		// Note: this type is marked as 'beforefieldinit'.
		static RegexCharClass()
		{
			Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexCharClass");
			RegexCharClass.NativeFieldInfoPtr__rangelist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_rangelist");
			RegexCharClass.NativeFieldInfoPtr__categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_categories");
			RegexCharClass.NativeFieldInfoPtr__canonical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_canonical");
			RegexCharClass.NativeFieldInfoPtr__negate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_negate");
			RegexCharClass.NativeFieldInfoPtr__subtractor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_subtractor");
			RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "InternalRegexIgnoreCase");
			RegexCharClass.NativeFieldInfoPtr_Space = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "Space");
			RegexCharClass.NativeFieldInfoPtr_NotSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpace");
			RegexCharClass.NativeFieldInfoPtr_Word = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "Word");
			RegexCharClass.NativeFieldInfoPtr_NotWord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWord");
			RegexCharClass.NativeFieldInfoPtr_SpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SpaceClass");
			RegexCharClass.NativeFieldInfoPtr_NotSpaceClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotSpaceClass");
			RegexCharClass.NativeFieldInfoPtr_WordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "WordClass");
			RegexCharClass.NativeFieldInfoPtr_NotWordClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotWordClass");
			RegexCharClass.NativeFieldInfoPtr_DigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "DigitClass");
			RegexCharClass.NativeFieldInfoPtr_NotDigitClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "NotDigitClass");
			RegexCharClass.NativeFieldInfoPtr__definedCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_definedCategories");
			RegexCharClass.NativeFieldInfoPtr__propTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_propTable");
			RegexCharClass.NativeFieldInfoPtr__lcTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "_lcTable");
			RegexCharClass.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663974);
			RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663975);
			RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663976);
			RegexCharClass.NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663977);
			RegexCharClass.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663978);
			RegexCharClass.NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663979);
			RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663980);
			RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663981);
			RegexCharClass.NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663982);
			RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663983);
			RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663984);
			RegexCharClass.NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663985);
			RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663986);
			RegexCharClass.NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663987);
			RegexCharClass.NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663988);
			RegexCharClass.NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663989);
			RegexCharClass.NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663990);
			RegexCharClass.NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663991);
			RegexCharClass.NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663992);
			RegexCharClass.NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663993);
			RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663994);
			RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663995);
			RegexCharClass.NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663996);
			RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663997);
			RegexCharClass.NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663998);
			RegexCharClass.NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100663999);
			RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664000);
			RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664001);
			RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664002);
			RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664003);
			RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664004);
			RegexCharClass.NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664005);
			RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664006);
			RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664007);
			RegexCharClass.NativeMethodInfoPtr_ToStringClass_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664008);
			RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664009);
			RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664010);
			RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, 100664011);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00022FA0 File Offset: 0x000211A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37787, RefRangeEnd = 37791, XrefRangeStart = 37776, XrefRangeEnd = 37787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00022FDC File Offset: 0x000211DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37791, XrefRangeEnd = 37792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref negate;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ranges);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(categories);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(subtraction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0002305C File Offset: 0x0002125C
		public unsafe bool CanMerge
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37792, RefRangeEnd = 37794, XrefRangeStart = 37792, XrefRangeEnd = 37792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700018B RID: 395
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00023098 File Offset: 0x00021298
		public unsafe bool Negate
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x000230D8 File Offset: 0x000212D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37795, RefRangeEnd = 37798, XrefRangeStart = 37794, XrefRangeEnd = 37795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddChar(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddChar_Internal_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00023118 File Offset: 0x00021318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37812, RefRangeEnd = 37814, XrefRangeStart = 37798, XrefRangeEnd = 37812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCharClass(RegexCharClass cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x0002315C File Offset: 0x0002135C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 37835, RefRangeEnd = 37838, XrefRangeStart = 37814, XrefRangeEnd = 37835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSet(string set)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSet_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x000231A0 File Offset: 0x000213A0
		[CallerCount(0)]
		public unsafe void AddSubtraction(RegexCharClass sub)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sub);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x000231E4 File Offset: 0x000213E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37848, RefRangeEnd = 37852, XrefRangeStart = 37838, XrefRangeEnd = 37848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRange(char first, char last)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref first;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00023230 File Offset: 0x00021430
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37882, RefRangeEnd = 37884, XrefRangeStart = 37852, XrefRangeEnd = 37882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref caseInsensitive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x000232A4 File Offset: 0x000214A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 37884, XrefRangeEnd = 37886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCategory(string category)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddCategory_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000232E8 File Offset: 0x000214E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 37895, RefRangeEnd = 37899, XrefRangeStart = 37886, XrefRangeEnd = 37895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercase(CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(culture);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0002332C File Offset: 0x0002152C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37917, RefRangeEnd = 37918, XrefRangeStart = 37899, XrefRangeEnd = 37917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddLowercaseRange(char chMin, char chMax, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0002338C File Offset: 0x0002158C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37934, RefRangeEnd = 37935, XrefRangeStart = 37918, XrefRangeEnd = 37934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddWord(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000233D8 File Offset: 0x000215D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37951, RefRangeEnd = 37952, XrefRangeStart = 37935, XrefRangeEnd = 37951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpace(bool ecma, bool negate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00023424 File Offset: 0x00021624
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37961, RefRangeEnd = 37962, XrefRangeStart = 37952, XrefRangeEnd = 37961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDigit(bool ecma, bool negate, string pattern)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ecma;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref negate;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00023484 File Offset: 0x00021684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37964, RefRangeEnd = 37966, XrefRangeStart = 37962, XrefRangeEnd = 37964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char SingletonChar(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x000234C8 File Offset: 0x000216C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37971, RefRangeEnd = 37973, XrefRangeStart = 37966, XrefRangeEnd = 37971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMergeable(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0002350C File Offset: 0x0002170C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 37981, RefRangeEnd = 37982, XrefRangeStart = 37973, XrefRangeEnd = 37981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsEmpty(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00023550 File Offset: 0x00021750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37993, RefRangeEnd = 37995, XrefRangeStart = 37982, XrefRangeEnd = 37993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingleton(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00023594 File Offset: 0x00021794
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38006, RefRangeEnd = 38007, XrefRangeStart = 37995, XrefRangeEnd = 38006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSingletonInverse(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000235D8 File Offset: 0x000217D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38007, XrefRangeEnd = 38009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSubtraction(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0002361C File Offset: 0x0002181C
		[CallerCount(0)]
		public unsafe static bool IsNegated(string set)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(set);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00023660 File Offset: 0x00021860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38019, RefRangeEnd = 38021, XrefRangeStart = 38009, XrefRangeEnd = 38019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsECMAWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000236A0 File Offset: 0x000218A0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 38029, RefRangeEnd = 38035, XrefRangeStart = 38021, XrefRangeEnd = 38029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWordChar(char ch)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000236E0 File Offset: 0x000218E0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 38039, RefRangeEnd = 38044, XrefRangeStart = 38035, XrefRangeEnd = 38039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClass(char ch, string set)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00023730 File Offset: 0x00021930
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 38063, RefRangeEnd = 38067, XrefRangeStart = 38044, XrefRangeEnd = 38063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassRecursive(char ch, string set, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00023790 File Offset: 0x00021990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 38067, XrefRangeEnd = 38075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0002380C File Offset: 0x00021A0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38094, RefRangeEnd = 38096, XrefRangeStart = 38075, XrefRangeEnd = 38094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(set);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mySetLength;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myCategoryLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00023888 File Offset: 0x00021A88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38098, RefRangeEnd = 38099, XrefRangeStart = 38096, XrefRangeEnd = 38098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chcategory;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(category);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000238F4 File Offset: 0x00021AF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 38106, RefRangeEnd = 38109, XrefRangeStart = 38099, XrefRangeEnd = 38106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string NegateCategory(string category)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00023930 File Offset: 0x00021B30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 38113, RefRangeEnd = 38116, XrefRangeStart = 38109, XrefRangeEnd = 38113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass Parse(string charClass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00023974 File Offset: 0x00021B74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 38146, RefRangeEnd = 38148, XrefRangeStart = 38116, XrefRangeEnd = 38146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RegexCharClass ParseRecursive(string charClass, int start)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(charClass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr3) : null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x000239C8 File Offset: 0x00021BC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 38149, RefRangeEnd = 38150, XrefRangeStart = 38148, XrefRangeEnd = 38149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RangeCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_RangeCount_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00023A04 File Offset: 0x00021C04
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 38999, RefRangeEnd = 39005, XrefRangeStart = 38150, XrefRangeEnd = 38999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToStringClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_ToStringClass_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00023A3C File Offset: 0x00021C3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 39007, RefRangeEnd = 39010, XrefRangeStart = 39005, XrefRangeEnd = 39007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexCharClass.SingleRange GetRangeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexCharClass.SingleRange>(intPtr3) : null;
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00023A88 File Offset: 0x00021C88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 39032, RefRangeEnd = 39033, XrefRangeStart = 39010, XrefRangeEnd = 39032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Canonicalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_Canonicalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00023ABC File Offset: 0x00021CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 39033, XrefRangeEnd = 39053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SetFromProperty(string capname, bool invert, string pattern)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(capname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invert;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(pattern);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00003C0B File Offset: 0x00001E0B
		public RegexCharClass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00023B18 File Offset: 0x00021D18
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00003C14 File Offset: 0x00001E14
		public unsafe List<RegexCharClass.SingleRange> _rangelist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RegexCharClass.SingleRange>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__rangelist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00023B48 File Offset: 0x00021D48
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00003C33 File Offset: 0x00001E33
		public unsafe StringBuilder _categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00023B78 File Offset: 0x00021D78
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00003C52 File Offset: 0x00001E52
		public unsafe bool _canonical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__canonical)) = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00023BA0 File Offset: 0x00021DA0
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00003C6D File Offset: 0x00001E6D
		public unsafe bool _negate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__negate)) = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00023BC8 File Offset: 0x00021DC8
		// (set) Token: 0x060004DB RID: 1243 RVA: 0x00003C88 File Offset: 0x00001E88
		public unsafe RegexCharClass _subtractor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCharClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.NativeFieldInfoPtr__subtractor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00023BF8 File Offset: 0x00021DF8
		// (set) Token: 0x060004DD RID: 1245 RVA: 0x00003CA7 File Offset: 0x00001EA7
		public unsafe static string InternalRegexIgnoreCase
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_InternalRegexIgnoreCase, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060004DE RID: 1246 RVA: 0x00023C18 File Offset: 0x00021E18
		// (set) Token: 0x060004DF RID: 1247 RVA: 0x00003CB9 File Offset: 0x00001EB9
		public unsafe static string Space
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_Space, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_Space, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00023C38 File Offset: 0x00021E38
		// (set) Token: 0x060004E1 RID: 1249 RVA: 0x00003CCB File Offset: 0x00001ECB
		public unsafe static string NotSpace
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotSpace, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotSpace, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00023C58 File Offset: 0x00021E58
		// (set) Token: 0x060004E3 RID: 1251 RVA: 0x00003CDD File Offset: 0x00001EDD
		public unsafe static string Word
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_Word, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_Word, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004E4 RID: 1252 RVA: 0x00023C78 File Offset: 0x00021E78
		// (set) Token: 0x060004E5 RID: 1253 RVA: 0x00003CEF File Offset: 0x00001EEF
		public unsafe static string NotWord
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotWord, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotWord, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00023C98 File Offset: 0x00021E98
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00003D01 File Offset: 0x00001F01
		public unsafe static string SpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_SpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00023CB8 File Offset: 0x00021EB8
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00003D13 File Offset: 0x00001F13
		public unsafe static string NotSpaceClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotSpaceClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00023CD8 File Offset: 0x00021ED8
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00003D25 File Offset: 0x00001F25
		public unsafe static string WordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_WordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_WordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00023CF8 File Offset: 0x00021EF8
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00003D37 File Offset: 0x00001F37
		public unsafe static string NotWordClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotWordClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00023D18 File Offset: 0x00021F18
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00003D49 File Offset: 0x00001F49
		public unsafe static string DigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_DigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00023D38 File Offset: 0x00021F38
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00003D5B File Offset: 0x00001F5B
		public unsafe static string NotDigitClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr_NotDigitClass, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00023D58 File Offset: 0x00021F58
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00003D6D File Offset: 0x00001F6D
		public unsafe static Dictionary<string, string> _definedCategories
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__definedCategories, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__definedCategories, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00023D80 File Offset: 0x00021F80
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00003D7F File Offset: 0x00001F7F
		public unsafe static Il2CppObjectBase _propTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__propTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppObjectBase>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__propTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00023DA8 File Offset: 0x00021FA8
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00003D91 File Offset: 0x00001F91
		public unsafe static Il2CppStructArray<RegexCharClass.LowerCaseMapping> _lcTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RegexCharClass.NativeFieldInfoPtr__lcTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RegexCharClass.LowerCaseMapping>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexCharClass.NativeFieldInfoPtr__lcTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeFieldInfoPtr__rangelist;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeFieldInfoPtr__categories;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeFieldInfoPtr__canonical;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeFieldInfoPtr__negate;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeFieldInfoPtr__subtractor;

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_InternalRegexIgnoreCase;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_Space;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_NotSpace;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_Word;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_NotWord;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_SpaceClass;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_NotSpaceClass;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_WordClass;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeFieldInfoPtr_NotWordClass;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeFieldInfoPtr_DigitClass;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeFieldInfoPtr_NotDigitClass;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeFieldInfoPtr__definedCategories;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeFieldInfoPtr__propTable;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr__lcTable;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Boolean_List_1_SingleRange_StringBuilder_RegexCharClass_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_CanMerge_Internal_get_Boolean_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_set_Negate_Internal_set_Void_Boolean_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_AddChar_Internal_Void_Char_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_AddCharClass_Internal_Void_RegexCharClass_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_AddSet_Private_Void_String_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_AddSubtraction_Internal_Void_RegexCharClass_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_AddRange_Internal_Void_Char_Char_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_AddCategoryFromName_Internal_Void_String_Boolean_Boolean_String_0;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_AddCategory_Private_Void_String_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercase_Internal_Void_CultureInfo_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_AddLowercaseRange_Private_Void_Char_Char_CultureInfo_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_AddWord_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_AddSpace_Internal_Void_Boolean_Boolean_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_AddDigit_Internal_Void_Boolean_Boolean_String_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_SingletonChar_Internal_Static_Char_String_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr_IsMergeable_Internal_Static_Boolean_String_0;

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Static_Boolean_String_0;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeMethodInfoPtr_IsSingleton_Internal_Static_Boolean_String_0;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_IsSingletonInverse_Internal_Static_Boolean_String_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_IsSubtraction_Private_Static_Boolean_String_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_IsNegated_Internal_Static_Boolean_String_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_IsECMAWordChar_Internal_Static_Boolean_Char_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_IsWordChar_Internal_Static_Boolean_Char_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_CharInClass_Internal_Static_Boolean_Char_String_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassRecursive_Internal_Static_Boolean_Char_String_Int32_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_CharInClassInternal_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategory_Private_Static_Boolean_Char_String_Int32_Int32_Int32_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_CharInCategoryGroup_Private_Static_Boolean_Char_UnicodeCategory_String_byref_Int32_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_NegateCategory_Private_Static_String_String_0;

		// Token: 0x040003C9 RID: 969
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_RegexCharClass_String_0;

		// Token: 0x040003CA RID: 970
		private static readonly IntPtr NativeMethodInfoPtr_ParseRecursive_Private_Static_RegexCharClass_String_Int32_0;

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeMethodInfoPtr_RangeCount_Private_Int32_0;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeMethodInfoPtr_ToStringClass_Internal_String_0;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_GetRangeAt_Private_SingleRange_Int32_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_Canonicalize_Private_Void_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_SetFromProperty_Private_Static_String_String_Boolean_String_0;

		// Token: 0x02000190 RID: 400
		[StructLayout(2)]
		public struct LowerCaseMapping
		{
			// Token: 0x0600173E RID: 5950 RVA: 0x00064C50 File Offset: 0x00062E50
			// Note: this type is marked as 'beforefieldinit'.
			static LowerCaseMapping()
			{
				Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "LowerCaseMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr);
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__chMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_chMin");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__chMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_chMax");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__lcOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_lcOp");
				RegexCharClass.LowerCaseMapping.NativeFieldInfoPtr__data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, "_data");
				RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, 100664012);
			}

			// Token: 0x0600173F RID: 5951 RVA: 0x00064CE0 File Offset: 0x00062EE0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 37677, RefRangeEnd = 37771, XrefRangeStart = 37677, XrefRangeEnd = 37677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LowerCaseMapping(char chMin, char chMax, int lcOp, int data)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref chMin;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref chMax;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lcOp;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.LowerCaseMapping.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001740 RID: 5952 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegexCharClass.LowerCaseMapping>.NativeClassPtr, ref this));
			}

			// Token: 0x04001296 RID: 4758
			private static readonly IntPtr NativeFieldInfoPtr__chMin;

			// Token: 0x04001297 RID: 4759
			private static readonly IntPtr NativeFieldInfoPtr__chMax;

			// Token: 0x04001298 RID: 4760
			private static readonly IntPtr NativeFieldInfoPtr__lcOp;

			// Token: 0x04001299 RID: 4761
			private static readonly IntPtr NativeFieldInfoPtr__data;

			// Token: 0x0400129A RID: 4762
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_Int32_Int32_0;

			// Token: 0x0400129B RID: 4763
			[FieldOffset(0)]
			public char _chMin;

			// Token: 0x0400129C RID: 4764
			[FieldOffset(2)]
			public char _chMax;

			// Token: 0x0400129D RID: 4765
			[FieldOffset(4)]
			public int _lcOp;

			// Token: 0x0400129E RID: 4766
			[FieldOffset(8)]
			public int _data;
		}

		// Token: 0x02000191 RID: 401
		public sealed class SingleRangeComparer : Object
		{
			// Token: 0x06001741 RID: 5953 RVA: 0x00064D3C File Offset: 0x00062F3C
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRangeComparer()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRangeComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr);
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664013);
				RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr, 100664014);
			}

			// Token: 0x06001742 RID: 5954 RVA: 0x00064D90 File Offset: 0x00062F90
			[CallerCount(0)]
			public unsafe int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001743 RID: 5955 RVA: 0x00064DF0 File Offset: 0x00062FF0
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleRangeComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass.SingleRangeComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRangeComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001744 RID: 5956 RVA: 0x0000C4EB File Offset: 0x0000A6EB
			public SingleRangeComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400129F RID: 4767
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_SingleRange_SingleRange_0;

			// Token: 0x040012A0 RID: 4768
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000192 RID: 402
		public sealed class SingleRange : Object
		{
			// Token: 0x06001745 RID: 5957 RVA: 0x00064E2C File Offset: 0x0006302C
			// Note: this type is marked as 'beforefieldinit'.
			static SingleRange()
			{
				Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RegexCharClass>.NativeClassPtr, "SingleRange");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr);
				RegexCharClass.SingleRange.NativeFieldInfoPtr__first = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "_first");
				RegexCharClass.SingleRange.NativeFieldInfoPtr__last = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, "_last");
				RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr, 100664015);
			}

			// Token: 0x06001746 RID: 5958 RVA: 0x00064E94 File Offset: 0x00063094
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 37772, RefRangeEnd = 37776, XrefRangeStart = 37771, XrefRangeEnd = 37772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SingleRange(char first, char last)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexCharClass.SingleRange>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref first;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref last;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexCharClass.SingleRange.NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001747 RID: 5959 RVA: 0x0000C4F4 File Offset: 0x0000A6F4
			public SingleRange(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700077E RID: 1918
			// (get) Token: 0x06001748 RID: 5960 RVA: 0x00064EEC File Offset: 0x000630EC
			// (set) Token: 0x06001749 RID: 5961 RVA: 0x0000C4FD File Offset: 0x0000A6FD
			public unsafe char _first
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__first);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__first)) = value;
				}
			}

			// Token: 0x1700077F RID: 1919
			// (get) Token: 0x0600174A RID: 5962 RVA: 0x00064F14 File Offset: 0x00063114
			// (set) Token: 0x0600174B RID: 5963 RVA: 0x0000C518 File Offset: 0x0000A718
			public unsafe char _last
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__last);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexCharClass.SingleRange.NativeFieldInfoPtr__last)) = value;
				}
			}

			// Token: 0x040012A1 RID: 4769
			private static readonly IntPtr NativeFieldInfoPtr__first;

			// Token: 0x040012A2 RID: 4770
			private static readonly IntPtr NativeFieldInfoPtr__last;

			// Token: 0x040012A3 RID: 4771
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_Char_0;
		}
	}
}
