using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000090 RID: 144
	public class Datatype_anySimpleType : DatatypeImplementation
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x00034404 File Offset: 0x00032604
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_anySimpleType()
		{
			Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_anySimpleType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr);
			Datatype_anySimpleType.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, "atomicValueType");
			Datatype_anySimpleType.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, "listValueType");
			Datatype_anySimpleType.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664850);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664851);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664852);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664853);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664854);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664855);
			Datatype_anySimpleType.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664856);
			Datatype_anySimpleType.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664857);
			Datatype_anySimpleType.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664858);
			Datatype_anySimpleType.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr, 100664859);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00034524 File Offset: 0x00032724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22441, XrefRangeEnd = 22445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000A99 RID: 2713 RVA: 0x00034580 File Offset: 0x00032780
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22445, XrefRangeEnd = 22449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000A9A RID: 2714 RVA: 0x000345CC File Offset: 0x000327CC
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22449, XrefRangeEnd = 22453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000A9B RID: 2715 RVA: 0x00034618 File Offset: 0x00032818
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x00034660 File Offset: 0x00032860
		public unsafe override Type ListValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22453, XrefRangeEnd = 22457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x000346AC File Offset: 0x000328AC
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06000A9E RID: 2718 RVA: 0x000346F4 File Offset: 0x000328F4
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0003473C File Offset: 0x0003293C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22457, XrefRangeEnd = 22459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Compare(Object value1, Object value2)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x000347A8 File Offset: 0x000329A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22459, XrefRangeEnd = 22460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_anySimpleType.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003484C File Offset: 0x00032A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22460, XrefRangeEnd = 22464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_anySimpleType()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_anySimpleType>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_anySimpleType.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00005B22 File Offset: 0x00003D22
		public Datatype_anySimpleType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x00034888 File Offset: 0x00032A88
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x00005B2B File Offset: 0x00003D2B
		public unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_anySimpleType.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_anySimpleType.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x000348B0 File Offset: 0x00032AB0
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x00005B3D File Offset: 0x00003D3D
		public unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_anySimpleType.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_anySimpleType.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
