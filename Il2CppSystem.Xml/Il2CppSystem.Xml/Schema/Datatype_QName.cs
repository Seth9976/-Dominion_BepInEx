using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000AB RID: 171
	public class Datatype_QName : Datatype_anySimpleType
	{
		// Token: 0x06000B7C RID: 2940 RVA: 0x00038258 File Offset: 0x00036458
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_QName()
		{
			Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_QName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr);
			Datatype_QName.NativeFieldInfoPtr_atomicValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, "atomicValueType");
			Datatype_QName.NativeFieldInfoPtr_listValueType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, "listValueType");
			Datatype_QName.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664991);
			Datatype_QName.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664992);
			Datatype_QName.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664993);
			Datatype_QName.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664994);
			Datatype_QName.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664995);
			Datatype_QName.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664996);
			Datatype_QName.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664997);
			Datatype_QName.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664998);
			Datatype_QName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr, 100664999);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00038364 File Offset: 0x00036564
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlValueConverter>(intPtr3) : null;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x000383C0 File Offset: 0x000365C0
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22985, XrefRangeEnd = 22989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000B7F RID: 2943 RVA: 0x0003840C File Offset: 0x0003660C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x00038454 File Offset: 0x00036654
		public unsafe override XmlTokenizedType TokenizedType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0003849C File Offset: 0x0003669C
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22989, XrefRangeEnd = 22993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x000384E8 File Offset: 0x000366E8
		public unsafe override Type ListValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22993, XrefRangeEnd = 22997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x00038534 File Offset: 0x00036734
		public unsafe override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0003857C File Offset: 0x0003677C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22997, XrefRangeEnd = 23018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_QName.NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typedValue = ((intPtr4 == 0) ? null : new Object(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr5) : null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00038620 File Offset: 0x00036820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23018, XrefRangeEnd = 23025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_QName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_QName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_QName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00005EC7 File Offset: 0x000040C7
		public Datatype_QName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0003865C File Offset: 0x0003685C
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x00005ED0 File Offset: 0x000040D0
		public new unsafe static Type atomicValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_QName.NativeFieldInfoPtr_atomicValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_QName.NativeFieldInfoPtr_atomicValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x00038684 File Offset: 0x00036884
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x00005EE2 File Offset: 0x000040E2
		public new unsafe static Type listValueType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_QName.NativeFieldInfoPtr_listValueType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_QName.NativeFieldInfoPtr_listValueType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400089F RID: 2207
		private static readonly IntPtr NativeFieldInfoPtr_atomicValueType;

		// Token: 0x040008A0 RID: 2208
		private static readonly IntPtr NativeFieldInfoPtr_listValueType;

		// Token: 0x040008A1 RID: 2209
		private static readonly IntPtr NativeMethodInfoPtr_CreateValueConverter_Internal_Virtual_XmlValueConverter_XmlSchemaType_0;

		// Token: 0x040008A2 RID: 2210
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040008A3 RID: 2211
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008A4 RID: 2212
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Public_Virtual_get_XmlTokenizedType_0;

		// Token: 0x040008A5 RID: 2213
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x040008A6 RID: 2214
		private static readonly IntPtr NativeMethodInfoPtr_get_ListValueType_Internal_Virtual_get_Type_0;

		// Token: 0x040008A7 RID: 2215
		private static readonly IntPtr NativeMethodInfoPtr_get_BuiltInWhitespaceFacet_Internal_Virtual_get_XmlSchemaWhiteSpace_0;

		// Token: 0x040008A8 RID: 2216
		private static readonly IntPtr NativeMethodInfoPtr_TryParseValue_Internal_Virtual_Exception_String_XmlNameTable_IXmlNamespaceResolver_byref_Object_0;

		// Token: 0x040008A9 RID: 2217
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
