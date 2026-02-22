using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000038 RID: 56
	public class XmlName : Object
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
		// Note: this type is marked as 'beforefieldinit'.
		static XmlName()
		{
			Il2CppClassPointerStore<XmlName>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlName>.NativeClassPtr);
			XmlName.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "prefix");
			XmlName.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "localName");
			XmlName.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "ns");
			XmlName.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "name");
			XmlName.NativeFieldInfoPtr_hashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "hashCode");
			XmlName.NativeFieldInfoPtr_ownerDoc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "ownerDoc");
			XmlName.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlName>.NativeClassPtr, "next");
			XmlName.NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664119);
			XmlName.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664120);
			XmlName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664121);
			XmlName.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664122);
			XmlName.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664123);
			XmlName.NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664124);
			XmlName.NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664125);
			XmlName.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664126);
			XmlName.NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664127);
			XmlName.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664128);
			XmlName.NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664129);
			XmlName.NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664130);
			XmlName.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664131);
			XmlName.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664132);
			XmlName.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664133);
			XmlName.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664134);
			XmlName.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlName>.NativeClassPtr, 100664135);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001E504 File Offset: 0x0001C704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16078, XrefRangeEnd = 16106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16106, XrefRangeEnd = 16107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hashCode;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ownerDoc);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000515 RID: 1301 RVA: 0x0001E658 File Offset: 0x0001C858
		public unsafe string LocalName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001E690 File Offset: 0x0001C890
		public unsafe string NamespaceURI
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001E6C8 File Offset: 0x0001C8C8
		public unsafe string Prefix
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000518 RID: 1304 RVA: 0x0001E700 File Offset: 0x0001C900
		public unsafe int HashCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0001E73C File Offset: 0x0001C93C
		public unsafe XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x0001E77C File Offset: 0x0001C97C
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 16113, RefRangeEnd = 16115, XrefRangeStart = 16107, XrefRangeEnd = 16113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001E7B4 File Offset: 0x0001C9B4
		public unsafe virtual XmlSchemaValidity Validity
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public unsafe virtual bool IsDefault
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001E844 File Offset: 0x0001CA44
		public unsafe virtual bool IsNil
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600051E RID: 1310 RVA: 0x0001E88C File Offset: 0x0001CA8C
		public unsafe virtual XmlSchemaSimpleType MemberType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600051F RID: 1311 RVA: 0x0001E8D8 File Offset: 0x0001CAD8
		public unsafe virtual XmlSchemaType SchemaType
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x0001E924 File Offset: 0x0001CB24
		public unsafe virtual XmlSchemaElement SchemaElement
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000521 RID: 1313 RVA: 0x0001E970 File Offset: 0x0001CB70
		public unsafe virtual XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001E9BC File Offset: 0x0001CBBC
		[CallerCount(0)]
		public unsafe virtual bool Equals(IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlName.NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x0001EA14 File Offset: 0x0001CC14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16116, RefRangeEnd = 16118, XrefRangeStart = 16115, XrefRangeEnd = 16116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetHashCode(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlName.NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00003C0D File Offset: 0x00001E0D
		public XmlName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001EA58 File Offset: 0x0001CC58
		// (set) Token: 0x06000526 RID: 1318 RVA: 0x00003C16 File Offset: 0x00001E16
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001EA80 File Offset: 0x0001CC80
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x00003C35 File Offset: 0x00001E35
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x00003C54 File Offset: 0x00001E54
		public unsafe string ns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
		// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003C73 File Offset: 0x00001E73
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0001EAF8 File Offset: 0x0001CCF8
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00003C92 File Offset: 0x00001E92
		public unsafe int hashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_hashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_hashCode)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0001EB20 File Offset: 0x0001CD20
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00003CAD File Offset: 0x00001EAD
		public unsafe XmlDocument ownerDoc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ownerDoc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_ownerDoc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0001EB50 File Offset: 0x0001CD50
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x00003CCC File Offset: 0x00001ECC
		public unsafe XmlName next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlName.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003EF RID: 1007
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_ns;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeFieldInfoPtr_hashCode;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeFieldInfoPtr_ownerDoc;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_XmlName_String_String_String_Int32_XmlDocument_XmlName_IXmlSchemaInfo_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_Int32_XmlDocument_XmlName_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_get_String_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr_get_HashCode_Public_get_Int32_0;

		// Token: 0x040003FC RID: 1020
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_get_XmlDocument_0;

		// Token: 0x040003FD RID: 1021
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040003FE RID: 1022
		private static readonly IntPtr NativeMethodInfoPtr_get_Validity_Public_Virtual_New_get_XmlSchemaValidity_0;

		// Token: 0x040003FF RID: 1023
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000400 RID: 1024
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNil_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000401 RID: 1025
		private static readonly IntPtr NativeMethodInfoPtr_get_MemberType_Public_Virtual_New_get_XmlSchemaSimpleType_0;

		// Token: 0x04000402 RID: 1026
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_Virtual_New_get_XmlSchemaType_0;

		// Token: 0x04000403 RID: 1027
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Public_Virtual_New_get_XmlSchemaElement_0;

		// Token: 0x04000404 RID: 1028
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Public_Virtual_New_get_XmlSchemaAttribute_0;

		// Token: 0x04000405 RID: 1029
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_New_Boolean_IXmlSchemaInfo_0;

		// Token: 0x04000406 RID: 1030
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Static_Int32_String_0;
	}
}
