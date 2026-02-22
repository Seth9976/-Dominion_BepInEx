using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text.RegularExpressions;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000D2 RID: 210
	public class StringFacetsChecker : FacetsChecker
	{
		// Token: 0x06000CDA RID: 3290 RVA: 0x0003E404 File Offset: 0x0003C604
		// Note: this type is marked as 'beforefieldinit'.
		static StringFacetsChecker()
		{
			Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "StringFacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr);
			StringFacetsChecker.NativeFieldInfoPtr_languagePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, "languagePattern");
			StringFacetsChecker.NativeMethodInfoPtr_get_LanguagePattern_Private_Static_get_Regex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665200);
			StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665201);
			StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665202);
			StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Exception_String_XmlSchemaDatatype_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665203);
			StringFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665204);
			StringFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_String_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665205);
			StringFacetsChecker.NativeMethodInfoPtr_CheckBuiltInFacets_Private_Exception_String_XmlTypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665206);
			StringFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr, 100665207);
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x0003E4E8 File Offset: 0x0003C6E8
		public unsafe static Regex LanguagePattern
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23799, XrefRangeEnd = 23810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFacetsChecker.NativeMethodInfoPtr_get_LanguagePattern_Private_Static_get_Regex_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr3) : null;
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0003E51C File Offset: 0x0003C71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23810, XrefRangeEnd = 23811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0003E58C File Offset: 0x0003C78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23811, XrefRangeEnd = 23812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0003E5FC File Offset: 0x0003C7FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 23825, RefRangeEnd = 23828, XrefRangeStart = 23812, XrefRangeEnd = 23825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckValueFacets(string value, XmlSchemaDatatype datatype, bool verifyUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyUri;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Exception_String_XmlSchemaDatatype_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0003E66C File Offset: 0x0003C86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23828, XrefRangeEnd = 23837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StringFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0003E6E8 File Offset: 0x0003C8E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23837, XrefRangeEnd = 23846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchEnumeration(string value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_String_ArrayList_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0003E75C File Offset: 0x0003C95C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 23898, RefRangeEnd = 23899, XrefRangeStart = 23846, XrefRangeEnd = 23898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckBuiltInFacets(string s, XmlTypeCode typeCode, bool verifyUri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref verifyUri;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFacetsChecker.NativeMethodInfoPtr_CheckBuiltInFacets_Private_Exception_String_XmlTypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0003E7C8 File Offset: 0x0003C9C8
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringFacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringFacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringFacetsChecker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0000632C File Offset: 0x0000452C
		public StringFacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x0003E804 File Offset: 0x0003CA04
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00006335 File Offset: 0x00004535
		public unsafe static Regex languagePattern
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StringFacetsChecker.NativeFieldInfoPtr_languagePattern, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StringFacetsChecker.NativeFieldInfoPtr_languagePattern, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeFieldInfoPtr_languagePattern;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_get_LanguagePattern_Private_Static_get_Regex_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_String_XmlSchemaDatatype_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Exception_String_XmlSchemaDatatype_Boolean_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Private_Boolean_String_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr_CheckBuiltInFacets_Private_Exception_String_XmlTypeCode_Boolean_0;

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
