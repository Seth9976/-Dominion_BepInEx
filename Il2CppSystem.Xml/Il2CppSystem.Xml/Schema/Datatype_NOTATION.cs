using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B7 RID: 183
	public class Datatype_NOTATION : Datatype_anySimpleType
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x00039300 File Offset: 0x00037500
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_NOTATION()
		{
			Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_NOTATION");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr);
			Datatype_NOTATION.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, "atomicValueType");
			Datatype_NOTATION.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, "listValueType");
			Datatype_NOTATION.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665030);
			Datatype_NOTATION.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665031);
			Datatype_NOTATION.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665032);
			Datatype_NOTATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665033);
			Datatype_NOTATION.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665034);
			Datatype_NOTATION.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665035);
			Datatype_NOTATION.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665036);
			Datatype_NOTATION.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665037);
			Datatype_NOTATION.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr, 100665038);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0003940C File Offset: 0x0003760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x00039468 File Offset: 0x00037668
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23033, XrefRangeEnd = 23037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x000394B4 File Offset: 0x000376B4
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x000394FC File Offset: 0x000376FC
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 14937, RefRangeEnd = 14950, XrefRangeStart = 14937, XrefRangeEnd = 14950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x00039544 File Offset: 0x00037744
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23037, XrefRangeEnd = 23041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x00039590 File Offset: 0x00037790
		public unsafe override Type ListValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23041, XrefRangeEnd = 23045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x000395DC File Offset: 0x000377DC
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x00039624 File Offset: 0x00037824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23045, XrefRangeEnd = 23066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out Object typedValue)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_NOTATION.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000396C8 File Offset: 0x000378C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23066, XrefRangeEnd = 23073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_NOTATION()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_NOTATION>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_NOTATION.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00005F57 File Offset: 0x00004157
		public Datatype_NOTATION(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06000BC9 RID: 3017 RVA: 0x00039704 File Offset: 0x00037904
		// (set) Token: 0x06000BCA RID: 3018 RVA: 0x00005F60 File Offset: 0x00004160
		public new unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_NOTATION.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_NOTATION.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06000BCB RID: 3019 RVA: 0x0003972C File Offset: 0x0003792C
		// (set) Token: 0x06000BCC RID: 3020 RVA: 0x00005F72 File Offset: 0x00004172
		public new unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_NOTATION.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_NOTATION.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
