using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x0200006A RID: 106
	public class XPathItem : Object
	{
		// Token: 0x06000849 RID: 2121 RVA: 0x0002CD14 File Offset: 0x0002AF14
		// Note: this type is marked as 'beforefieldinit'.
		static XPathItem()
		{
			Il2CppClassPointerStore<XPathItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathItem>.NativeClassPtr);
			XPathItem.NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664650);
			XPathItem.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664651);
			XPathItem.NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664652);
			XPathItem.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664653);
			XPathItem.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664654);
			XPathItem.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664655);
			XPathItem.NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664656);
			XPathItem.NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664657);
			XPathItem.NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664658);
			XPathItem.NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664659);
			XPathItem.NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664660);
			XPathItem.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathItem>.NativeClassPtr, 100664661);
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0002CE34 File Offset: 0x0002B034
		public unsafe virtual XmlSchemaType XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0002CE80 File Offset: 0x0002B080
		public unsafe virtual string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x0002CEC4 File Offset: 0x0002B0C4
		public unsafe virtual Object TypedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x0002CF10 File Offset: 0x0002B110
		public unsafe virtual Type ValueType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x0002CF5C File Offset: 0x0002B15C
		public unsafe virtual bool ValueAsBoolean
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0002CFA4 File Offset: 0x0002B1A4
		public unsafe virtual DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x0002CFEC File Offset: 0x0002B1EC
		public unsafe virtual double ValueAsDouble
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0002D034 File Offset: 0x0002B234
		public unsafe virtual int ValueAsInt
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0002D07C File Offset: 0x0002B27C
		public unsafe virtual long ValueAsLong
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0002D0C4 File Offset: 0x0002B2C4
		[CallerCount(0)]
		public unsafe virtual Object ValueAs(Type returnType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(returnType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0002D120 File Offset: 0x0002B320
		[CallerCount(0)]
		public unsafe virtual Object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XPathItem.NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0002D190 File Offset: 0x0002B390
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathItem.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00004A7E File Offset: 0x00002C7E
		public XPathItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Abstract_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Abstract_Virtual_New_get_Type_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Abstract_Virtual_New_get_DateTime_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Abstract_Virtual_New_get_Double_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_New_Object_Type_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Abstract_Virtual_New_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
