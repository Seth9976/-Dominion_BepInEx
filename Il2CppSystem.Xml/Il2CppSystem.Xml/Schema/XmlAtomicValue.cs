using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.XPath;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E3 RID: 227
	public sealed class XmlAtomicValue : XPathItem
	{
		// Token: 0x06000E22 RID: 3618 RVA: 0x00043118 File Offset: 0x00041318
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAtomicValue()
		{
			Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlAtomicValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr);
			XmlAtomicValue.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "xmlType");
			XmlAtomicValue.NativeFieldInfoPtr_objVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "objVal");
			XmlAtomicValue.NativeFieldInfoPtr_clrType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "clrType");
			XmlAtomicValue.NativeFieldInfoPtr_unionVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "unionVal");
			XmlAtomicValue.NativeFieldInfoPtr_nsPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "nsPrefix");
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665369);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665370);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665371);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665372);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665373);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665374);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665375);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665376);
			XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665377);
			XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665378);
			XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665379);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665380);
			XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665381);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665382);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665383);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665384);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665385);
			XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665386);
			XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665387);
			XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665388);
			XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665389);
			XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, 100665390);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00043364 File Offset: 0x00041564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24342, XrefRangeEnd = 24343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, bool value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x000433C0 File Offset: 0x000415C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24344, RefRangeEnd = 24346, XrefRangeStart = 24343, XrefRangeEnd = 24344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x0004341C File Offset: 0x0004161C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24347, RefRangeEnd = 24349, XrefRangeStart = 24346, XrefRangeEnd = 24347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, double value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00043478 File Offset: 0x00041678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24350, RefRangeEnd = 24352, XrefRangeStart = 24349, XrefRangeEnd = 24350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, int value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x000434D4 File Offset: 0x000416D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24353, RefRangeEnd = 24355, XrefRangeStart = 24352, XrefRangeEnd = 24353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, long value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00043530 File Offset: 0x00041730
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 24356, RefRangeEnd = 24366, XrefRangeStart = 24355, XrefRangeEnd = 24356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00043590 File Offset: 0x00041790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24366, XrefRangeEnd = 24392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00043600 File Offset: 0x00041800
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 24393, RefRangeEnd = 24399, XrefRangeStart = 24392, XrefRangeEnd = 24393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00043660 File Offset: 0x00041860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24411, RefRangeEnd = 24413, XrefRangeStart = 24399, XrefRangeEnd = 24411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAtomicValue(XmlSchemaType xmlType, Object value, IXmlNamespaceResolver nsResolver)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x000436D0 File Offset: 0x000418D0
		[CallerCount(734)]
		[CachedScanResults(RefRangeStart = 3778, RefRangeEnd = 4512, XrefRangeStart = 3778, XrefRangeEnd = 4512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000E2D RID: 3629 RVA: 0x00043710 File Offset: 0x00041910
		public unsafe override XmlSchemaType XmlType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06000E2E RID: 3630 RVA: 0x00043750 File Offset: 0x00041950
		public unsafe override Type ValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24413, XrefRangeEnd = 24414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06000E2F RID: 3631 RVA: 0x00043790 File Offset: 0x00041990
		public unsafe override Object TypedValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24414, XrefRangeEnd = 24415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06000E30 RID: 3632 RVA: 0x000437D0 File Offset: 0x000419D0
		public unsafe override bool ValueAsBoolean
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24415, XrefRangeEnd = 24416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06000E31 RID: 3633 RVA: 0x0004380C File Offset: 0x00041A0C
		public unsafe override DateTime ValueAsDateTime
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24416, XrefRangeEnd = 24417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06000E32 RID: 3634 RVA: 0x00043848 File Offset: 0x00041A48
		public unsafe override double ValueAsDouble
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24417, XrefRangeEnd = 24418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x00043884 File Offset: 0x00041A84
		public unsafe override int ValueAsInt
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24418, XrefRangeEnd = 24419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x000438C0 File Offset: 0x00041AC0
		public unsafe override long ValueAsLong
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24419, XrefRangeEnd = 24420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000438FC File Offset: 0x00041AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24420, XrefRangeEnd = 24434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsResolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06000E36 RID: 3638 RVA: 0x00043960 File Offset: 0x00041B60
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24434, XrefRangeEnd = 24436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00043998 File Offset: 0x00041B98
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000439D0 File Offset: 0x00041BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24436, XrefRangeEnd = 24450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPrefixFromQName(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00006B36 File Offset: 0x00004D36
		public XmlAtomicValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000E3A RID: 3642 RVA: 0x00043A18 File Offset: 0x00041C18
		// (set) Token: 0x06000E3B RID: 3643 RVA: 0x00006B3F File Offset: 0x00004D3F
		public unsafe XmlSchemaType xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_xmlType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000E3C RID: 3644 RVA: 0x00043A48 File Offset: 0x00041C48
		// (set) Token: 0x06000E3D RID: 3645 RVA: 0x00006B5E File Offset: 0x00004D5E
		public unsafe Object objVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_objVal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000E3E RID: 3646 RVA: 0x00043A78 File Offset: 0x00041C78
		// (set) Token: 0x06000E3F RID: 3647 RVA: 0x00006B7D File Offset: 0x00004D7D
		public unsafe TypeCode clrType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_clrType)) = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000E40 RID: 3648 RVA: 0x00043AA0 File Offset: 0x00041CA0
		// (set) Token: 0x06000E41 RID: 3649 RVA: 0x00006B98 File Offset: 0x00004D98
		public unsafe XmlAtomicValue.Union unionVal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_unionVal)) = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000E42 RID: 3650 RVA: 0x00043AC8 File Offset: 0x00041CC8
		// (set) Token: 0x06000E43 RID: 3651 RVA: 0x00006BB3 File Offset: 0x00004DB3
		public unsafe XmlAtomicValue.NamespacePrefixForQName nsPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAtomicValue.NamespacePrefixForQName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NativeFieldInfoPtr_nsPrefix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeFieldInfoPtr_objVal;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeFieldInfoPtr_clrType;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeFieldInfoPtr_unionVal;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeFieldInfoPtr_nsPrefix;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Boolean_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_DateTime_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Double_0;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int32_0;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Int64_0;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_String_IXmlNamespaceResolver_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaType_Object_IXmlNamespaceResolver_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_Virtual_get_XmlSchemaType_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueType_Public_Virtual_get_Type_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_get_TypedValue_Public_Virtual_get_Object_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsBoolean_Public_Virtual_get_Boolean_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDateTime_Public_Virtual_get_DateTime_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsDouble_Public_Virtual_get_Double_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsInt_Public_Virtual_get_Int32_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueAsLong_Public_Virtual_get_Int64_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_ValueAs_Public_Virtual_Object_Type_IXmlNamespaceResolver_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000A89 RID: 2697
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000A8A RID: 2698
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefixFromQName_Private_String_String_0;

		// Token: 0x02000134 RID: 308
		[StructLayout(2)]
		public struct Union
		{
			// Token: 0x060012C9 RID: 4809 RVA: 0x00055B80 File Offset: 0x00053D80
			// Note: this type is marked as 'beforefieldinit'.
			static Union()
			{
				Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "Union");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr);
				XmlAtomicValue.Union.NativeFieldInfoPtr_boolVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "boolVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dblVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dblVal");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i64Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i64Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_i32Val = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "i32Val");
				XmlAtomicValue.Union.NativeFieldInfoPtr_dtVal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, "dtVal");
			}

			// Token: 0x060012CA RID: 4810 RVA: 0x000086C8 File Offset: 0x000068C8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlAtomicValue.Union>.NativeClassPtr, ref this));
			}

			// Token: 0x04000ECA RID: 3786
			private static readonly IntPtr NativeFieldInfoPtr_boolVal;

			// Token: 0x04000ECB RID: 3787
			private static readonly IntPtr NativeFieldInfoPtr_dblVal;

			// Token: 0x04000ECC RID: 3788
			private static readonly IntPtr NativeFieldInfoPtr_i64Val;

			// Token: 0x04000ECD RID: 3789
			private static readonly IntPtr NativeFieldInfoPtr_i32Val;

			// Token: 0x04000ECE RID: 3790
			private static readonly IntPtr NativeFieldInfoPtr_dtVal;

			// Token: 0x04000ECF RID: 3791
			[FieldOffset(0)]
			[MarshalAs(4)]
			public bool boolVal;

			// Token: 0x04000ED0 RID: 3792
			[FieldOffset(0)]
			public double dblVal;

			// Token: 0x04000ED1 RID: 3793
			[FieldOffset(0)]
			public long i64Val;

			// Token: 0x04000ED2 RID: 3794
			[FieldOffset(0)]
			public int i32Val;

			// Token: 0x04000ED3 RID: 3795
			[FieldOffset(0)]
			public DateTime dtVal;
		}

		// Token: 0x02000135 RID: 309
		public class NamespacePrefixForQName : Object
		{
			// Token: 0x060012CB RID: 4811 RVA: 0x00055C10 File Offset: 0x00053E10
			// Note: this type is marked as 'beforefieldinit'.
			static NamespacePrefixForQName()
			{
				Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlAtomicValue>.NativeClassPtr, "NamespacePrefixForQName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr);
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "prefix");
				XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, "ns");
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100665391);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100665392);
				XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr, 100665393);
			}

			// Token: 0x060012CC RID: 4812 RVA: 0x00055CA0 File Offset: 0x00053EA0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 24338, RefRangeEnd = 24340, XrefRangeStart = 24337, XrefRangeEnd = 24338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NamespacePrefixForQName(string prefix, string ns)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAtomicValue.NamespacePrefixForQName>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060012CD RID: 4813 RVA: 0x00055D00 File Offset: 0x00053F00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24340, XrefRangeEnd = 24341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x00055D48 File Offset: 0x00053F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24341, XrefRangeEnd = 24342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string LookupPrefix(string namespaceName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAtomicValue.NamespacePrefixForQName.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x000086DA File Offset: 0x000068DA
			public NamespacePrefixForQName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700068F RID: 1679
			// (get) Token: 0x060012D0 RID: 4816 RVA: 0x00055D90 File Offset: 0x00053F90
			// (set) Token: 0x060012D1 RID: 4817 RVA: 0x000086E3 File Offset: 0x000068E3
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000690 RID: 1680
			// (get) Token: 0x060012D2 RID: 4818 RVA: 0x00055DB8 File Offset: 0x00053FB8
			// (set) Token: 0x060012D3 RID: 4819 RVA: 0x00008702 File Offset: 0x00006902
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAtomicValue.NamespacePrefixForQName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04000ED4 RID: 3796
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04000ED5 RID: 3797
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04000ED6 RID: 3798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

			// Token: 0x04000ED7 RID: 3799
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_Final_New_String_String_0;

			// Token: 0x04000ED8 RID: 3800
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_Final_New_String_String_0;
		}
	}
}
