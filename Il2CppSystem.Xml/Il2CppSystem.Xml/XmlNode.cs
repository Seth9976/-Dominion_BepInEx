using System;
using System.Reflection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003B RID: 59
	[DefaultMember("Item")]
	public class XmlNode : Object
	{
		// Token: 0x0600055B RID: 1371 RVA: 0x0001F704 File Offset: 0x0001D904
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNode()
		{
			Il2CppClassPointerStore<XmlNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNode>.NativeClassPtr);
			XmlNode.NativeFieldInfoPtr_parentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, "parentNode");
			XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664170);
			XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664171);
			XmlNode.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664172);
			XmlNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664173);
			XmlNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664174);
			XmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664175);
			XmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664176);
			XmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664177);
			XmlNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664178);
			XmlNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664179);
			XmlNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664180);
			XmlNode.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664181);
			XmlNode.NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664182);
			XmlNode.NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664183);
			XmlNode.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664184);
			XmlNode.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664185);
			XmlNode.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664186);
			XmlNode.NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664187);
			XmlNode.NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664188);
			XmlNode.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664189);
			XmlNode.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664190);
			XmlNode.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664191);
			XmlNode.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664192);
			XmlNode.NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664193);
			XmlNode.NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664194);
			XmlNode.NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664195);
			XmlNode.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664196);
			XmlNode.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664197);
			XmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664198);
			XmlNode.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664199);
			XmlNode.NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664200);
			XmlNode.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664201);
			XmlNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664202);
			XmlNode.NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664203);
			XmlNode.NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664204);
			XmlNode.NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664205);
			XmlNode.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664206);
			XmlNode.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664207);
			XmlNode.NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664208);
			XmlNode.NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664209);
			XmlNode.NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664210);
			XmlNode.NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664211);
			XmlNode.NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664212);
			XmlNode.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664213);
			XmlNode.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664214);
			XmlNode.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664215);
			XmlNode.NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664216);
			XmlNode.NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664217);
			XmlNode.NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNode>.NativeClassPtr, 100664218);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001FB1C File Offset: 0x0001DD1C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001FB58 File Offset: 0x0001DD58
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 16248, RefRangeEnd = 16263, XrefRangeStart = 16247, XrefRangeEnd = 16248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode(XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNode>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x0001FBA4 File Offset: 0x0001DDA4
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600055F RID: 1375 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		// (set) Token: 0x06000560 RID: 1376 RVA: 0x0001FC2C File Offset: 0x0001DE2C
		public unsafe virtual string Value
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16263, XrefRangeEnd = 16282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x0001FC7C File Offset: 0x0001DE7C
		public unsafe virtual XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001FCC4 File Offset: 0x0001DEC4
		public unsafe virtual XmlNode ParentNode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16284, RefRangeEnd = 16285, XrefRangeStart = 16282, XrefRangeEnd = 16284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000563 RID: 1379 RVA: 0x0001FD10 File Offset: 0x0001DF10
		public unsafe virtual XmlNodeList ChildNodes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16285, XrefRangeEnd = 16289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeList>(intPtr3) : null;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001FD5C File Offset: 0x0001DF5C
		public unsafe virtual XmlNode PreviousSibling
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000565 RID: 1381 RVA: 0x0001FDA8 File Offset: 0x0001DFA8
		public unsafe virtual XmlNode NextSibling
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000566 RID: 1382 RVA: 0x0001FDF4 File Offset: 0x0001DFF4
		public unsafe virtual XmlAttributeCollection Attributes
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttributeCollection>(intPtr3) : null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x0001FE40 File Offset: 0x0001E040
		public unsafe virtual XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16289, XrefRangeEnd = 16291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x0001FE8C File Offset: 0x0001E08C
		public unsafe virtual XmlNode FirstChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		public unsafe virtual XmlNode LastChild
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001FF24 File Offset: 0x0001E124
		public unsafe virtual bool IsContainer
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x0001FF6C File Offset: 0x0001E16C
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x0001FFB8 File Offset: 0x0001E1B8
		public unsafe virtual XmlLinkedNode LastNode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr3) : null;
			}
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00020008 File Offset: 0x0001E208
		[CallerCount(0)]
		public unsafe bool AncestorNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00020058 File Offset: 0x0001E258
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16300, RefRangeEnd = 16302, XrefRangeStart = 16291, XrefRangeEnd = 16300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode RemoveChild(XmlNode oldChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x000200B4 File Offset: 0x0001E2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16309, RefRangeEnd = 16311, XrefRangeStart = 16302, XrefRangeEnd = 16309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AppendChild(XmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00020110 File Offset: 0x0001E310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16311, XrefRangeEnd = 16315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00020180 File Offset: 0x0001E380
		[CallerCount(48)]
		[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000201D4 File Offset: 0x0001E3D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refChild);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x00020240 File Offset: 0x0001E440
		public unsafe virtual bool HasChildNodes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00020288 File Offset: 0x0001E488
		[CallerCount(0)]
		public unsafe virtual XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x000202E0 File Offset: 0x0001E4E0
		[CallerCount(0)]
		public unsafe virtual void CopyChildren(XmlDocument doc, XmlNode container, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(container);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x00020350 File Offset: 0x0001E550
		public unsafe virtual string NamespaceURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16315, XrefRangeEnd = 16317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x00020394 File Offset: 0x0001E594
		public unsafe virtual string Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16317, XrefRangeEnd = 16319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x000203D8 File Offset: 0x0001E5D8
		public unsafe virtual string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0002041C File Offset: 0x0001E61C
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16319, XrefRangeEnd = 16322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00020464 File Offset: 0x0001E664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16322, XrefRangeEnd = 16325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReadOnlyParent(XmlNode n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000204A8 File Offset: 0x0001E6A8
		[CallerCount(0)]
		public unsafe virtual Object System_ICloneable_Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000204E8 File Offset: 0x0001E6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16325, XrefRangeEnd = 16329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00020528 File Offset: 0x0001E728
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16332, RefRangeEnd = 16334, XrefRangeStart = 16329, XrefRangeEnd = 16332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AppendChildText(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0002056C File Offset: 0x0001E76C
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x000205B0 File Offset: 0x0001E7B0
		public unsafe virtual string InnerText
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 16341, RefRangeEnd = 16344, XrefRangeStart = 16334, XrefRangeEnd = 16341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 16345, RefRangeEnd = 16347, XrefRangeStart = 16344, XrefRangeEnd = 16345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000247 RID: 583
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x00020600 File Offset: 0x0001E800
		public unsafe virtual string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16347, XrefRangeEnd = 16354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00020650 File Offset: 0x0001E850
		public unsafe virtual string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16354, XrefRangeEnd = 16357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00020694 File Offset: 0x0001E894
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 16357, RefRangeEnd = 16364, XrefRangeStart = 16357, XrefRangeEnd = 16357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x000206D0 File Offset: 0x0001E8D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16364, RefRangeEnd = 16365, XrefRangeStart = 16364, XrefRangeEnd = 16364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetParent(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00020720 File Offset: 0x0001E920
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 5326, RefRangeEnd = 5327, XrefRangeStart = 5326, XrefRangeEnd = 5327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetParentForLoad(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00020770 File Offset: 0x0001E970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16369, RefRangeEnd = 16371, XrefRangeStart = 16365, XrefRangeEnd = 16369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SplitName(string name, out string prefix, out string localName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			prefix = IL2CPP.Il2CppStringToManaged(intPtr);
			localName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000207DC File Offset: 0x0001E9DC
		[CallerCount(0)]
		public unsafe virtual XmlNode FindChild(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00020834 File Offset: 0x0001EA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16371, XrefRangeEnd = 16372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldParent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(oldValue);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(newValue);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref action;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x000208E8 File Offset: 0x0001EAE8
		[CallerCount(0)]
		public unsafe virtual void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00020938 File Offset: 0x0001EB38
		[CallerCount(0)]
		public unsafe virtual void AfterEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00020988 File Offset: 0x0001EB88
		public unsafe virtual bool IsText
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNode.NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x000209D0 File Offset: 0x0001EBD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16372, RefRangeEnd = 16374, XrefRangeStart = 16372, XrefRangeEnd = 16372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x00020A18 File Offset: 0x0001EC18
		[CallerCount(0)]
		public unsafe static void UnnestTextNodes(XmlNode prevNode, XmlNode nextNode)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prevNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nextNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNode.NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x00003DC2 File Offset: 0x00001FC2
		public XmlNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x00020A60 File Offset: 0x0001EC60
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x00003DCB File Offset: 0x00001FCB
		public unsafe XmlNode parentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNode.NativeFieldInfoPtr_parentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNode.NativeFieldInfoPtr_parentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeFieldInfoPtr_parentNode;

		// Token: 0x04000426 RID: 1062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000427 RID: 1063
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlDocument_0;

		// Token: 0x04000428 RID: 1064
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000429 RID: 1065
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_New_get_String_0;

		// Token: 0x0400042A RID: 1066
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400042B RID: 1067
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Abstract_Virtual_New_get_XmlNodeType_0;

		// Token: 0x0400042C RID: 1068
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x0400042D RID: 1069
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildNodes_Public_Virtual_New_get_XmlNodeList_0;

		// Token: 0x0400042E RID: 1070
		private static readonly IntPtr NativeMethodInfoPtr_get_PreviousSibling_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x0400042F RID: 1071
		private static readonly IntPtr NativeMethodInfoPtr_get_NextSibling_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000430 RID: 1072
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_Virtual_New_get_XmlAttributeCollection_0;

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_New_get_XmlDocument_0;

		// Token: 0x04000432 RID: 1074
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstChild_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000433 RID: 1075
		private static readonly IntPtr NativeMethodInfoPtr_get_LastChild_Public_Virtual_New_get_XmlNode_0;

		// Token: 0x04000434 RID: 1076
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000435 RID: 1077
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_New_get_XmlLinkedNode_0;

		// Token: 0x04000436 RID: 1078
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_New_set_Void_XmlLinkedNode_0;

		// Token: 0x04000437 RID: 1079
		private static readonly IntPtr NativeMethodInfoPtr_AncestorNode_Internal_Boolean_XmlNode_0;

		// Token: 0x04000438 RID: 1080
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000439 RID: 1081
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x0400043A RID: 1082
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x0400043B RID: 1083
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_New_Boolean_XmlNodeType_0;

		// Token: 0x0400043C RID: 1084
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_New_Boolean_XmlNode_XmlNode_0;

		// Token: 0x0400043D RID: 1085
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChildNodes_Public_Virtual_New_get_Boolean_0;

		// Token: 0x0400043E RID: 1086
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Abstract_Virtual_New_XmlNode_Boolean_0;

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_CopyChildren_Internal_Virtual_New_Void_XmlDocument_XmlNode_Boolean_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_New_get_String_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_New_get_String_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_HasReadOnlyParent_Internal_Static_Boolean_XmlNode_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildText_Private_Void_StringBuilder_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_get_InnerText_Public_Virtual_New_get_String_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_New_get_String_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAll_Public_Virtual_New_Void_0;

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Internal_Virtual_New_Void_XmlNode_0;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr_SetParentForLoad_Internal_Virtual_New_Void_XmlNode_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_SplitName_Internal_Static_Void_String_byref_String_byref_String_0;

		// Token: 0x04000450 RID: 1104
		private static readonly IntPtr NativeMethodInfoPtr_FindChild_Internal_Virtual_New_XmlNode_XmlNodeType_0;

		// Token: 0x04000451 RID: 1105
		private static readonly IntPtr NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_New_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x04000452 RID: 1106
		private static readonly IntPtr NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000453 RID: 1107
		private static readonly IntPtr NativeMethodInfoPtr_AfterEvent_Internal_Virtual_New_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000454 RID: 1108
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Internal_Virtual_New_get_Boolean_0;

		// Token: 0x04000455 RID: 1109
		private static readonly IntPtr NativeMethodInfoPtr_NestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0;

		// Token: 0x04000456 RID: 1110
		private static readonly IntPtr NativeMethodInfoPtr_UnnestTextNodes_Internal_Static_Void_XmlNode_XmlNode_0;
	}
}
