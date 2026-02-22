using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000032 RID: 50
	public class XmlEntity : XmlNode
	{
		// Token: 0x060004AA RID: 1194 RVA: 0x0001C5A8 File Offset: 0x0001A7A8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlEntity()
		{
			Il2CppClassPointerStore<XmlEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr);
			XmlEntity.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "publicId");
			XmlEntity.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "systemId");
			XmlEntity.NativeFieldInfoPtr_notationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "notationName");
			XmlEntity.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "name");
			XmlEntity.NativeFieldInfoPtr_unparsedReplacementStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "unparsedReplacementStr");
			XmlEntity.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "baseURI");
			XmlEntity.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "lastChild");
			XmlEntity.NativeFieldInfoPtr_childrenFoliating = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, "childrenFoliating");
			XmlEntity.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664055);
			XmlEntity.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664056);
			XmlEntity.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664057);
			XmlEntity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664058);
			XmlEntity.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664059);
			XmlEntity.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664060);
			XmlEntity.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664061);
			XmlEntity.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664062);
			XmlEntity.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664063);
			XmlEntity.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664064);
			XmlEntity.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664065);
			XmlEntity.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664066);
			XmlEntity.NativeMethodInfoPtr_get_SystemId_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664067);
			XmlEntity.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664068);
			XmlEntity.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664069);
			XmlEntity.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr, 100664070);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001C7B8 File Offset: 0x0001A9B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15483, RefRangeEnd = 15485, XrefRangeStart = 15482, XrefRangeEnd = 15483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(strdata);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(notationName);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEntity.NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001C860 File Offset: 0x0001AA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15485, XrefRangeEnd = 15492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		public unsafe override bool IsReadOnly
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001C900 File Offset: 0x0001AB00
		public unsafe override string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x0001C944 File Offset: 0x0001AB44
		public unsafe override string LocalName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001C988 File Offset: 0x0001AB88
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0001C9CC File Offset: 0x0001ABCC
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15492, XrefRangeEnd = 15499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x0001CA1C File Offset: 0x0001AC1C
		public unsafe override bool IsContainer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x0001CA64 File Offset: 0x0001AC64
		// (set) Token: 0x060004B4 RID: 1204 RVA: 0x0001CAB0 File Offset: 0x0001ACB0
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15499, XrefRangeEnd = 15509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001CB00 File Offset: 0x0001AD00
		[CallerCount(0)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0001CB54 File Offset: 0x0001AD54
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0001CB9C File Offset: 0x0001AD9C
		public unsafe string SystemId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEntity.NativeMethodInfoPtr_get_SystemId_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001FC RID: 508
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15509, XrefRangeEnd = 15516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0001CC24 File Offset: 0x0001AE24
		public unsafe override string BaseURI
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlEntity.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001CC68 File Offset: 0x0001AE68
		[CallerCount(0)]
		public unsafe void SetBaseURI(string inBaseURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inBaseURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlEntity.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00003A17 File Offset: 0x00001C17
		public XmlEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x0001CCAC File Offset: 0x0001AEAC
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00003A20 File Offset: 0x00001C20
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x0001CCD4 File Offset: 0x0001AED4
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00003A3F File Offset: 0x00001C3F
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x0001CCFC File Offset: 0x0001AEFC
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00003A5E File Offset: 0x00001C5E
		public unsafe string notationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_notationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_notationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x0001CD24 File Offset: 0x0001AF24
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00003A7D File Offset: 0x00001C7D
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001CD4C File Offset: 0x0001AF4C
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00003A9C File Offset: 0x00001C9C
		public unsafe string unparsedReplacementStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_unparsedReplacementStr);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_unparsedReplacementStr), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x0001CD74 File Offset: 0x0001AF74
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003ABB File Offset: 0x00001CBB
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x0001CD9C File Offset: 0x0001AF9C
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00003ADA File Offset: 0x00001CDA
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003AF9 File Offset: 0x00001CF9
		public unsafe bool childrenFoliating
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_childrenFoliating);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlEntity.NativeFieldInfoPtr_childrenFoliating)) = value;
			}
		}

		// Token: 0x0400039C RID: 924
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x0400039D RID: 925
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_notationName;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeFieldInfoPtr_unparsedReplacementStr;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x040003A3 RID: 931
		private static readonly IntPtr NativeFieldInfoPtr_childrenFoliating;

		// Token: 0x040003A4 RID: 932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_String_String_String_XmlDocument_0;

		// Token: 0x040003A5 RID: 933
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x040003A6 RID: 934
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_get_String_0;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x040003B0 RID: 944
		private static readonly IntPtr NativeMethodInfoPtr_get_SystemId_Public_get_String_0;

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0;
	}
}
