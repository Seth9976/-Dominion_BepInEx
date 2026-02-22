using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000030 RID: 48
	public class XmlDocumentType : XmlLinkedNode
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x0001B228 File Offset: 0x00019428
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocumentType()
		{
			Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDocumentType");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr);
			XmlDocumentType.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "name");
			XmlDocumentType.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "publicId");
			XmlDocumentType.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "systemId");
			XmlDocumentType.NativeFieldInfoPtr_internalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "internalSubset");
			XmlDocumentType.NativeFieldInfoPtr_namespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "namespaces");
			XmlDocumentType.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "entities");
			XmlDocumentType.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "notations");
			XmlDocumentType.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, "schemaInfo");
			XmlDocumentType.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664011);
			XmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664012);
			XmlDocumentType.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664013);
			XmlDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664014);
			XmlDocumentType.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664015);
			XmlDocumentType.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664016);
			XmlDocumentType.NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664017);
			XmlDocumentType.NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664018);
			XmlDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664019);
			XmlDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664020);
			XmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664021);
			XmlDocumentType.NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664022);
			XmlDocumentType.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664023);
			XmlDocumentType.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr, 100664024);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0001B410 File Offset: 0x00019610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15399, XrefRangeEnd = 15406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocumentType>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001B4A8 File Offset: 0x000196A8
		public unsafe override string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0001B4EC File Offset: 0x000196EC
		public unsafe override string LocalName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001B530 File Offset: 0x00019730
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001B578 File Offset: 0x00019778
		[CallerCount(0)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001B5D0 File Offset: 0x000197D0
		public unsafe override bool IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentType.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x0001B618 File Offset: 0x00019818
		public unsafe XmlNamedNodeMap Entities
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 15410, RefRangeEnd = 15412, XrefRangeStart = 15406, XrefRangeEnd = 15410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001B658 File Offset: 0x00019858
		public unsafe XmlNamedNodeMap Notations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15412, XrefRangeEnd = 15416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0001B698 File Offset: 0x00019898
		public unsafe string PublicId
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_PublicId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001B6D0 File Offset: 0x000198D0
		public unsafe string SystemId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0001B708 File Offset: 0x00019908
		public unsafe string InternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001B740 File Offset: 0x00019940
		public unsafe bool ParseWithNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001B77C File Offset: 0x0001997C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0001B7BC File Offset: 0x000199BC
		public unsafe SchemaInfo DtdSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentType.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x000038B4 File Offset: 0x00001AB4
		public XmlDocumentType(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001B800 File Offset: 0x00019A00
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x000038BD File Offset: 0x00001ABD
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001B828 File Offset: 0x00019A28
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x000038DC File Offset: 0x00001ADC
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001B850 File Offset: 0x00019A50
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000038FB File Offset: 0x00001AFB
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001B878 File Offset: 0x00019A78
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0000391A File Offset: 0x00001B1A
		public unsafe string internalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_internalSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_internalSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001B8A0 File Offset: 0x00019AA0
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003939 File Offset: 0x00001B39
		public unsafe bool namespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_namespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_namespaces)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003954 File Offset: 0x00001B54
		public unsafe XmlNamedNodeMap entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001B8F8 File Offset: 0x00019AF8
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003973 File Offset: 0x00001B73
		public unsafe XmlNamedNodeMap notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0001B928 File Offset: 0x00019B28
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003992 File Offset: 0x00001B92
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentType.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeFieldInfoPtr_internalSubset;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeFieldInfoPtr_namespaces;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x0400036C RID: 876
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x0400036D RID: 877
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_String_XmlDocument_0;

		// Token: 0x0400036E RID: 878
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400036F RID: 879
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000370 RID: 880
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000371 RID: 881
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000372 RID: 882
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000373 RID: 883
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Public_get_XmlNamedNodeMap_0;

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Public_get_XmlNamedNodeMap_0;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_get_PublicId_Public_get_String_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalSubset_Public_get_String_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_get_ParseWithNamespaces_Internal_get_Boolean_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0;
	}
}
