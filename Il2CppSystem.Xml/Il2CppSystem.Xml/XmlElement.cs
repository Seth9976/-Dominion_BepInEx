using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000031 RID: 49
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x06000484 RID: 1156 RVA: 0x0001B958 File Offset: 0x00019B58
		// Note: this type is marked as 'beforefieldinit'.
		static XmlElement()
		{
			Il2CppClassPointerStore<XmlElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlElement>.NativeClassPtr);
			XmlElement.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, "name");
			XmlElement.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, "attributes");
			XmlElement.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, "lastChild");
			XmlElement.NativeMethodInfoPtr__ctor_Internal_Void_XmlName_Boolean_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664025);
			XmlElement.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664026);
			XmlElement.NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664027);
			XmlElement.NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664028);
			XmlElement.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664029);
			XmlElement.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664030);
			XmlElement.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664031);
			XmlElement.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664032);
			XmlElement.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664033);
			XmlElement.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664034);
			XmlElement.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664035);
			XmlElement.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664036);
			XmlElement.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664037);
			XmlElement.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664038);
			XmlElement.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664039);
			XmlElement.NativeMethodInfoPtr_set_IsEmpty_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664040);
			XmlElement.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664041);
			XmlElement.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664042);
			XmlElement.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664043);
			XmlElement.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_XmlAttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664044);
			XmlElement.NativeMethodInfoPtr_get_HasAttributes_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664045);
			XmlElement.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_New_XmlAttribute_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664046);
			XmlElement.NativeMethodInfoPtr_RemoveAllAttributes_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664047);
			XmlElement.NativeMethodInfoPtr_RemoveAll_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664048);
			XmlElement.NativeMethodInfoPtr_RemoveAllChildren_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664049);
			XmlElement.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664050);
			XmlElement.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664051);
			XmlElement.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664052);
			XmlElement.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664053);
			XmlElement.NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlElement>.NativeClassPtr, 100664054);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001BC1C File Offset: 0x00019E1C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15422, RefRangeEnd = 15425, XrefRangeStart = 15416, XrefRangeEnd = 15422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement(XmlName name, bool empty, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref empty;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr__ctor_Internal_Void_XmlName_Boolean_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001BC88 File Offset: 0x00019E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15425, XrefRangeEnd = 15428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlElement>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x0001BD0C File Offset: 0x00019F0C
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x0001BD4C File Offset: 0x00019F4C
		public unsafe XmlName XmlName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001BD90 File Offset: 0x00019F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15428, XrefRangeEnd = 15452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0001BDE8 File Offset: 0x00019FE8
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15452, XrefRangeEnd = 15454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0001BE2C File Offset: 0x0001A02C
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0001BE70 File Offset: 0x0001A070
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 15454, RefRangeEnd = 15455, XrefRangeStart = 15454, XrefRangeEnd = 15454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x0001BF40 File Offset: 0x0001A140
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001BF8C File Offset: 0x0001A18C
		public unsafe override XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		public unsafe override bool IsContainer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x0001C020 File Offset: 0x0001A220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15455, XrefRangeEnd = 15460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x0001C090 File Offset: 0x0001A290
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x0001C0CC File Offset: 0x0001A2CC
		public unsafe bool IsEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr_set_IsEmpty_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x0001C10C File Offset: 0x0001A30C
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x0001C158 File Offset: 0x0001A358
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		[CallerCount(0)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001C1FC File Offset: 0x0001A3FC
		public unsafe override XmlAttributeCollection Attributes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15460, XrefRangeEnd = 15467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_XmlAttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x0001C248 File Offset: 0x0001A448
		public unsafe virtual bool HasAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_HasAttributes_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001C290 File Offset: 0x0001A490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15467, XrefRangeEnd = 15469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newAttr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_New_XmlAttribute_XmlAttribute_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001C2EC File Offset: 0x0001A4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15469, XrefRangeEnd = 15470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAllAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_RemoveAllAttributes_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x0001C328 File Offset: 0x0001A528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15470, XrefRangeEnd = 15471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemoveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_RemoveAll_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001C364 File Offset: 0x0001A564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15471, XrefRangeEnd = 15472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllChildren()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlElement.NativeMethodInfoPtr_RemoveAllChildren_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001E9 RID: 489
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x0001C398 File Offset: 0x0001A598
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15472, XrefRangeEnd = 15479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x0001C42C File Offset: 0x0001A62C
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15479, XrefRangeEnd = 15480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15480, XrefRangeEnd = 15482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x0001C47C File Offset: 0x0001A67C
		public unsafe override XmlNode NextSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0001C4C8 File Offset: 0x0001A6C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetParent(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlElement.NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x000039B1 File Offset: 0x00001BB1
		public XmlElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001C518 File Offset: 0x0001A718
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x000039BA File Offset: 0x00001BBA
		public unsafe XmlName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001C548 File Offset: 0x0001A748
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x000039D9 File Offset: 0x00001BD9
		public unsafe XmlAttributeCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlAttributeCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001C578 File Offset: 0x0001A778
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x000039F8 File Offset: 0x00001BF8
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlElement.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlName_Boolean_XmlDocument_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmpty_Public_get_Boolean_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEmpty_Public_set_Void_Boolean_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x0400038F RID: 911
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x04000390 RID: 912
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x04000391 RID: 913
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_get_XmlAttributeCollection_0;

		// Token: 0x04000392 RID: 914
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAttributes_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000393 RID: 915
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeNode_Public_Virtual_New_XmlAttribute_XmlAttribute_0;

		// Token: 0x04000394 RID: 916
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllAttributes_Public_Virtual_New_Void_0;

		// Token: 0x04000395 RID: 917
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Virtual_Void_0;

		// Token: 0x04000396 RID: 918
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllChildren_Internal_Void_0;

		// Token: 0x04000397 RID: 919
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x04000398 RID: 920
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0;

		// Token: 0x04000399 RID: 921
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x0400039A RID: 922
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSibling_Public_Virtual_get_XmlNode_0;

		// Token: 0x0400039B RID: 923
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0;
	}
}
