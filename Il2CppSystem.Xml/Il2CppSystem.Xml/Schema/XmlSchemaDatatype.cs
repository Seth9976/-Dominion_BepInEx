using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000ED RID: 237
	public class XmlSchemaDatatype : Object
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x0004455C File Offset: 0x0004275C
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaDatatype()
		{
			Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaDatatype");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665413);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665414);
			XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665415);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665416);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665417);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665418);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665419);
			XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665420);
			XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665421);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665422);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665423);
			XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665424);
			XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665425);
			XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665426);
			XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665427);
			XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr, 100665428);
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000446CC File Offset: 0x000428CC
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00044718 File Offset: 0x00042918
		public unsafe virtual XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E85 RID: 3717 RVA: 0x00044760 File Offset: 0x00042960
		[CallerCount(0)]
		public unsafe virtual Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000447E0 File Offset: 0x000429E0
		public unsafe virtual XmlSchemaDatatypeVariety Variety
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x06000E87 RID: 3719 RVA: 0x00044828 File Offset: 0x00042A28
		public unsafe virtual XmlTypeCode TypeCode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x00044870 File Offset: 0x00042A70
		public unsafe virtual XmlValueConverter ValueConverter
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x000448BC File Offset: 0x00042ABC
		public unsafe virtual RestrictionFacets Restriction
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
			}
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00044908 File Offset: 0x00042B08
		[CallerCount(0)]
		public unsafe virtual int Compare(Object value1, Object value2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E8B RID: 3723 RVA: 0x00044974 File Offset: 0x00042B74
		[CallerCount(0)]
		public unsafe virtual Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x00044A18 File Offset: 0x00042C18
		public unsafe virtual FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00044A64 File Offset: 0x00042C64
		public unsafe virtual XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00044AAC File Offset: 0x00042CAC
		[CallerCount(0)]
		public unsafe virtual bool IsEqual(Object o1, Object o2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(o2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaDatatype.NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x00044B18 File Offset: 0x00042D18
		public unsafe string TypeCodeString
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24587, RefRangeEnd = 24588, XrefRangeStart = 24580, XrefRangeEnd = 24587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00044B50 File Offset: 0x00042D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24588, XrefRangeEnd = 24634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string TypeCodeToString(XmlTypeCode typeCode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00044B94 File Offset: 0x00042D94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24638, RefRangeEnd = 24639, XrefRangeStart = 24634, XrefRangeEnd = 24638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00044BD4 File Offset: 0x00042DD4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaDatatype()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaDatatype>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaDatatype.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00006E05 File Offset: 0x00005005
		public XmlSchemaDatatype(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Abstract_Virtual_New_get_XmlTokenizedType_0;

		// Token: 0x04000AB8 RID: 2744
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Abstract_Virtual_New_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x04000AB9 RID: 2745
		private static readonly IntPtr NativeMethodInfoPtr_get_Variety_Public_Virtual_New_get_XmlSchemaDatatypeVariety_0;

		// Token: 0x04000ABA RID: 2746
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_New_get_XmlTypeCode_0;

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueConverter_Internal_Abstract_Virtual_New_get_XmlValueConverter_0;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeMethodInfoPtr_get_Restriction_Internal_Abstract_Virtual_New_get_RestrictionFacets_0;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Abstract_Virtual_New_Int32_Object_Object_0;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Abstract_Virtual_New_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Abstract_Virtual_New_get_FacetsChecker_0;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Abstract_Virtual_New_get_XmlSchemaWhiteSpace_0;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeMethodInfoPtr_IsEqual_Internal_Abstract_Virtual_New_Boolean_Object_Object_0;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCodeString_Internal_get_String_0;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_TypeCodeToString_Internal_String_XmlTypeCode_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlTokenizedType_Internal_Static_XmlSchemaDatatype_XmlTokenizedType_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
