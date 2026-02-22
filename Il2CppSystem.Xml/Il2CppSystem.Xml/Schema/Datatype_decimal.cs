using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000097 RID: 151
	public class Datatype_decimal : Datatype_anySimpleType
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00035CAC File Offset: 0x00033EAC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_decimal()
		{
			Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_decimal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr);
			Datatype_decimal.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, "atomicValueType");
			Datatype_decimal.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, "listValueType");
			Datatype_decimal.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_decimal.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664906);
			Datatype_decimal.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664907);
			Datatype_decimal.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664908);
			Datatype_decimal.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664909);
			Datatype_decimal.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664910);
			Datatype_decimal.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664911);
			Datatype_decimal.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664912);
			Datatype_decimal.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664913);
			Datatype_decimal.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr, 100664914);
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00035DCC File Offset: 0x00033FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22634, XrefRangeEnd = 22635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00035E28 File Offset: 0x00034028
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22635, XrefRangeEnd = 22639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00035E74 File Offset: 0x00034074
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00035EBC File Offset: 0x000340BC
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22639, XrefRangeEnd = 22643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00035F08 File Offset: 0x00034108
		public unsafe override Type ListValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22643, XrefRangeEnd = 22647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00035F54 File Offset: 0x00034154
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00035F9C File Offset: 0x0003419C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22647, XrefRangeEnd = 22651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00036008 File Offset: 0x00034208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22651, XrefRangeEnd = 22665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_decimal.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x000360AC File Offset: 0x000342AC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 22672, RefRangeEnd = 22681, XrefRangeStart = 22665, XrefRangeEnd = 22672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_decimal()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_decimal>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_decimal.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00005BF1 File Offset: 0x00003DF1
		public Datatype_decimal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000360E8 File Offset: 0x000342E8
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x00005BFA File Offset: 0x00003DFA
		public new unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_decimal.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_decimal.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x00036110 File Offset: 0x00034310
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x00005C0C File Offset: 0x00003E0C
		public new unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_decimal.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_decimal.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x00036138 File Offset: 0x00034338
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x00005C1E File Offset: 0x00003E1E
		public unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_decimal.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_decimal.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Internal_Virtual_Int32_Object_Object_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
