using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200003A RID: 58
	public class XmlNamedNodeMap : Object
	{
		// Token: 0x06000549 RID: 1353 RVA: 0x0001F124 File Offset: 0x0001D324
		// Note: this type is marked as 'beforefieldinit'.
		static XmlNamedNodeMap()
		{
			Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlNamedNodeMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr);
			XmlNamedNodeMap.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "parent");
			XmlNamedNodeMap.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "nodes");
			XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664148);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664149);
			XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664150);
			XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664151);
			XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664152);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664153);
			XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664154);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664155);
			XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664156);
			XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664157);
			XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664158);
			XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, 100664159);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001F26C File Offset: 0x0001D46C
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamedNodeMap(XmlNode parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16202, XrefRangeEnd = 16207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode GetNamedItem(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x0001F314 File Offset: 0x0001D514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16207, XrefRangeEnd = 16212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode SetNamedItem(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001F370 File Offset: 0x0001D570
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16213, RefRangeEnd = 16214, XrefRangeStart = 16212, XrefRangeEnd = 16213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x0001F3B8 File Offset: 0x0001D5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16214, XrefRangeEnd = 16215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001F404 File Offset: 0x0001D604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16215, XrefRangeEnd = 16219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x0001F454 File Offset: 0x0001D654
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16224, RefRangeEnd = 16226, XrefRangeStart = 16219, XrefRangeEnd = 16224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int FindNodeOffset(string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x0001F4B4 File Offset: 0x0001D6B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16230, RefRangeEnd = 16232, XrefRangeStart = 16226, XrefRangeEnd = 16230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNode(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x0001F510 File Offset: 0x0001D710
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16234, RefRangeEnd = 16235, XrefRangeStart = 16232, XrefRangeEnd = 16234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode AddNodeForLoad(XmlNode node, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x0001F580 File Offset: 0x0001D780
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 16239, RefRangeEnd = 16242, XrefRangeStart = 16235, XrefRangeEnd = 16239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode RemoveNodeAt(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[CallerCount(0)]
		public unsafe XmlNode ReplaceNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0001F638 File Offset: 0x0001D838
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16246, RefRangeEnd = 16247, XrefRangeStart = 16242, XrefRangeEnd = 16246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlNode InsertNodeAt(int i, XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlNamedNodeMap.NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00003D6C File Offset: 0x00001F6C
		public XmlNamedNodeMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001F6A4 File Offset: 0x0001D8A4
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x00003D75 File Offset: 0x00001F75
		public unsafe XmlNode parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001F6D4 File Offset: 0x0001D8D4
		// (set) Token: 0x0600055A RID: 1370 RVA: 0x00003D94 File Offset: 0x00001F94
		public XmlNamedNodeMap.SmallXmlNodeList nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes);
				return new XmlNamedNodeMap.SmallXmlNodeList(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.NativeFieldInfoPtr_nodes), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000417 RID: 1047
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000418 RID: 1048
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x04000419 RID: 1049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNode_0;

		// Token: 0x0400041A RID: 1050
		private static readonly IntPtr NativeMethodInfoPtr_GetNamedItem_Public_Virtual_New_XmlNode_String_0;

		// Token: 0x0400041B RID: 1051
		private static readonly IntPtr NativeMethodInfoPtr_SetNamedItem_Public_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x0400041C RID: 1052
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x0400041D RID: 1053
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_New_IEnumerator_0;

		// Token: 0x0400041E RID: 1054
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_0;

		// Token: 0x0400041F RID: 1055
		private static readonly IntPtr NativeMethodInfoPtr_FindNodeOffset_Internal_Int32_String_String_0;

		// Token: 0x04000420 RID: 1056
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Internal_Virtual_New_XmlNode_XmlNode_0;

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeMethodInfoPtr_AddNodeForLoad_Internal_Virtual_New_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_RemoveNodeAt_Internal_Virtual_New_XmlNode_Int32_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_ReplaceNodeAt_Internal_XmlNode_Int32_XmlNode_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_InsertNodeAt_Internal_Virtual_New_XmlNode_Int32_XmlNode_0;

		// Token: 0x02000122 RID: 290
		public sealed class SmallXmlNodeList : ValueType
		{
			// Token: 0x06001242 RID: 4674 RVA: 0x00054598 File Offset: 0x00052798
			// Note: this type is marked as 'beforefieldinit'.
			static SmallXmlNodeList()
			{
				Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap>.NativeClassPtr, "SmallXmlNodeList");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr);
				XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "field");
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664160);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664161);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664162);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664163);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664164);
				XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, 100664165);
			}

			// Token: 0x17000666 RID: 1638
			// (get) Token: 0x06001243 RID: 4675 RVA: 0x00054650 File Offset: 0x00052850
			public unsafe int Count
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 16165, RefRangeEnd = 16168, XrefRangeStart = 16163, XrefRangeEnd = 16165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000667 RID: 1639
			public unsafe Object this[int index]
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 16170, RefRangeEnd = 16180, XrefRangeStart = 16168, XrefRangeEnd = 16170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref index;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x000546E8 File Offset: 0x000528E8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 16184, RefRangeEnd = 16186, XrefRangeStart = 16180, XrefRangeEnd = 16184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Add_Public_Void_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001246 RID: 4678 RVA: 0x00054730 File Offset: 0x00052930
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16188, RefRangeEnd = 16189, XrefRangeStart = 16186, XrefRangeEnd = 16188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void RemoveAt(int index)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001247 RID: 4679 RVA: 0x00054774 File Offset: 0x00052974
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16193, RefRangeEnd = 16194, XrefRangeStart = 16189, XrefRangeEnd = 16193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Insert(int index, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001248 RID: 4680 RVA: 0x000547CC File Offset: 0x000529CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16201, RefRangeEnd = 16202, XrefRangeStart = 16194, XrefRangeEnd = 16201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001249 RID: 4681 RVA: 0x000080EF File Offset: 0x000062EF
			public SmallXmlNodeList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600124A RID: 4682 RVA: 0x000080F8 File Offset: 0x000062F8
			public SmallXmlNodeList()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr))
			{
			}

			// Token: 0x17000665 RID: 1637
			// (get) Token: 0x0600124B RID: 4683 RVA: 0x00054810 File Offset: 0x00052A10
			// (set) Token: 0x0600124C RID: 4684 RVA: 0x0000810A File Offset: 0x0000630A
			public unsafe Object field
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.NativeFieldInfoPtr_field), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E23 RID: 3619
			private static readonly IntPtr NativeFieldInfoPtr_field;

			// Token: 0x04000E24 RID: 3620
			private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

			// Token: 0x04000E25 RID: 3621
			private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

			// Token: 0x04000E26 RID: 3622
			private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_0;

			// Token: 0x04000E27 RID: 3623
			private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Void_Int32_0;

			// Token: 0x04000E28 RID: 3624
			private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Void_Int32_Object_0;

			// Token: 0x04000E29 RID: 3625
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_IEnumerator_0;

			// Token: 0x02000144 RID: 324
			public class SingleObjectEnumerator : Object
			{
				// Token: 0x0600130D RID: 4877 RVA: 0x000565FC File Offset: 0x000547FC
				// Note: this type is marked as 'beforefieldinit'.
				static SingleObjectEnumerator()
				{
					Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList>.NativeClassPtr, "SingleObjectEnumerator");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "loneValue");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, "position");
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100664166);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100664167);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100664168);
					XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr, 100664169);
				}

				// Token: 0x0600130E RID: 4878 RVA: 0x000566A0 File Offset: 0x000548A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16162, XrefRangeEnd = 16163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe SingleObjectEnumerator(Object value)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x170006A1 RID: 1697
				// (get) Token: 0x0600130F RID: 4879 RVA: 0x000566EC File Offset: 0x000548EC
				public unsafe virtual Object Current
				{
					[CallerCount(0)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x06001310 RID: 4880 RVA: 0x0005672C File Offset: 0x0005492C
				[CallerCount(0)]
				public unsafe virtual bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001311 RID: 4881 RVA: 0x00056768 File Offset: 0x00054968
				[CallerCount(0)]
				public unsafe virtual void Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001312 RID: 4882 RVA: 0x000089DE File Offset: 0x00006BDE
				public SingleObjectEnumerator(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700069F RID: 1695
				// (get) Token: 0x06001313 RID: 4883 RVA: 0x0005679C File Offset: 0x0005499C
				// (set) Token: 0x06001314 RID: 4884 RVA: 0x000089E7 File Offset: 0x00006BE7
				public unsafe Object loneValue
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_loneValue), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170006A0 RID: 1696
				// (get) Token: 0x06001315 RID: 4885 RVA: 0x000567CC File Offset: 0x000549CC
				// (set) Token: 0x06001316 RID: 4886 RVA: 0x00008A06 File Offset: 0x00006C06
				public unsafe int position
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlNamedNodeMap.SmallXmlNodeList.SingleObjectEnumerator.NativeFieldInfoPtr_position)) = value;
					}
				}

				// Token: 0x04000F12 RID: 3858
				private static readonly IntPtr NativeFieldInfoPtr_loneValue;

				// Token: 0x04000F13 RID: 3859
				private static readonly IntPtr NativeFieldInfoPtr_position;

				// Token: 0x04000F14 RID: 3860
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

				// Token: 0x04000F15 RID: 3861
				private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Virtual_Final_New_get_Object_0;

				// Token: 0x04000F16 RID: 3862
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Virtual_Final_New_Boolean_0;

				// Token: 0x04000F17 RID: 3863
				private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Final_New_Void_0;
			}
		}
	}
}
