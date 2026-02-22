using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x0200006C RID: 108
	public class XPathNavigator : XPathItem
	{
		// Token: 0x06000857 RID: 2135 RVA: 0x0002D1CC File Offset: 0x0002B3CC
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNavigator()
		{
			Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr);
			XPathNavigator.NativeFieldInfoPtr_comparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "comparer");
			XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "NodeTypeLetter");
			XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "UniqueIdTbl");
			XPathNavigator.NativeFieldInfoPtr_ContentKindMasks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, "ContentKindMasks");
			XPathNavigator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664662);
			XPathNavigator.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664663);
			XPathNavigator.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664664);
			XPathNavigator.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664665);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664666);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664667);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664668);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664669);
			XPathNavigator.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664670);
			XPathNavigator.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664671);
			XPathNavigator.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664672);
			XPathNavigator.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664673);
			XPathNavigator.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664674);
			XPathNavigator.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664675);
			XPathNavigator.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664676);
			XPathNavigator.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664677);
			XPathNavigator.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664678);
			XPathNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664679);
			XPathNavigator.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664680);
			XPathNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664681);
			XPathNavigator.NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664682);
			XPathNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664683);
			XPathNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664684);
			XPathNavigator.NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664685);
			XPathNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664686);
			XPathNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664687);
			XPathNavigator.NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664688);
			XPathNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr, 100664689);
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x0002D47C File Offset: 0x0002B67C
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0002D4C0 File Offset: 0x0002B6C0
		public unsafe override XmlSchemaType XmlType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21227, XrefRangeEnd = 21234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0002D50C File Offset: 0x0002B70C
		public unsafe override Object TypedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21234, XrefRangeEnd = 21249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0002D558 File Offset: 0x0002B758
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21249, XrefRangeEnd = 21263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public unsafe override bool ValueAsBoolean
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21263, XrefRangeEnd = 21271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0002D5EC File Offset: 0x0002B7EC
		public unsafe override DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21271, XrefRangeEnd = 21279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600085E RID: 2142 RVA: 0x0002D634 File Offset: 0x0002B834
		public unsafe override double ValueAsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21279, XrefRangeEnd = 21287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0002D67C File Offset: 0x0002B87C
		public unsafe override int ValueAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21287, XrefRangeEnd = 21295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000860 RID: 2144 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
		public unsafe override long ValueAsLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21295, XrefRangeEnd = 21303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x0002D70C File Offset: 0x0002B90C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21303, XrefRangeEnd = 21312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x0002D77C File Offset: 0x0002B97C
		[CallerCount(0)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0002D7BC File Offset: 0x0002B9BC
		public unsafe virtual XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0002D808 File Offset: 0x0002BA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21312, XrefRangeEnd = 21317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0002D85C File Offset: 0x0002BA5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21317, XrefRangeEnd = 21331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string LookupPrefix(string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
		[CallerCount(0)]
		public unsafe virtual XPathNavigator Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNavigator>(intPtr3) : null;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0002D8FC File Offset: 0x0002BAFC
		public unsafe virtual XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x0002D944 File Offset: 0x0002BB44
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0002D988 File Offset: 0x0002BB88
		public unsafe virtual string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x0002D9CC File Offset: 0x0002BBCC
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0002DA10 File Offset: 0x0002BC10
		public unsafe virtual Object UnderlyingObject
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0002DA5C File Offset: 0x0002BC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21331, XrefRangeEnd = 21332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MoveToNamespace(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0002DAB4 File Offset: 0x0002BCB4
		[CallerCount(0)]
		public unsafe virtual bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x0002DB08 File Offset: 0x0002BD08
		[CallerCount(0)]
		public unsafe virtual bool MoveToNextNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x0002DB5C File Offset: 0x0002BD5C
		[CallerCount(0)]
		public unsafe virtual bool MoveToParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x0002DBA4 File Offset: 0x0002BDA4
		[CallerCount(0)]
		public unsafe virtual bool IsSamePosition(XPathNavigator other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		public unsafe virtual IXmlSchemaInfo SchemaInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21332, XrefRangeEnd = 21335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathNavigator.NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002DC48 File Offset: 0x0002BE48
		[CallerCount(0)]
		public unsafe static bool IsText(XPathNodeType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0002DC88 File Offset: 0x0002BE88
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathNavigator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNavigator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNavigator.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00004A87 File Offset: 0x00002C87
		public XPathNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0002DCC4 File Offset: 0x0002BEC4
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00004A90 File Offset: 0x00002C90
		public unsafe static XPathNavigatorKeyComparer comparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_comparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNavigatorKeyComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_comparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0002DCEC File Offset: 0x0002BEEC
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00004AA2 File Offset: 0x00002CA2
		public unsafe static Il2CppStructArray<char> NodeTypeLetter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_NodeTypeLetter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0002DD14 File Offset: 0x0002BF14
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00004AB4 File Offset: 0x00002CB4
		public unsafe static Il2CppStructArray<char> UniqueIdTbl
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_UniqueIdTbl, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00004AC6 File Offset: 0x00002CC6
		public unsafe static Il2CppStructArray<int> ContentKindMasks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XPathNavigator.NativeFieldInfoPtr_ContentKindMasks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XPathNavigator.NativeFieldInfoPtr_ContentKindMasks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_comparer;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeFieldInfoPtr_NodeTypeLetter;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeFieldInfoPtr_UniqueIdTbl;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeFieldInfoPtr_ContentKindMasks;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x0400069C RID: 1692
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x0400069D RID: 1693
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Abstract_Virtual_New_get_XmlNameTable_0;

		// Token: 0x0400069E RID: 1694
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_New_String_String_0;

		// Token: 0x0400069F RID: 1695
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_New_String_String_0;

		// Token: 0x040006A0 RID: 1696
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Abstract_Virtual_New_XPathNavigator_0;

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XPathNodeType_0;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_New_get_Object_0;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNamespace_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextNamespace_Public_Abstract_Virtual_New_Boolean_XPathNamespaceScope_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040006AA RID: 1706
		private static readonly IntPtr NativeMethodInfoPtr_IsSamePosition_Public_Abstract_Virtual_New_Boolean_XPathNavigator_0;

		// Token: 0x040006AB RID: 1707
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaInfo_Public_Virtual_New_get_IXmlSchemaInfo_0;

		// Token: 0x040006AC RID: 1708
		private static readonly IntPtr NativeMethodInfoPtr_IsText_Internal_Static_Boolean_XPathNodeType_0;

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
