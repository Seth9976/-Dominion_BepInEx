using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using MS.Internal.Xml.Cache;

namespace Il2CppSystem.Xml.XPath
{
	// Token: 0x02000069 RID: 105
	public class XPathDocument : Object
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x0002CA80 File Offset: 0x0002AC80
		// Note: this type is marked as 'beforefieldinit'.
		static XPathDocument()
		{
			Il2CppClassPointerStore<XPathDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.XPath", "XPathDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr);
			XPathDocument.NativeFieldInfoPtr_pageXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "pageXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_idxXmlNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "idxXmlNmsp");
			XPathDocument.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "nameTable");
			XPathDocument.NativeFieldInfoPtr_mapNmsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, "mapNmsp");
			XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100664647);
			XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100664648);
			XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocument>.NativeClassPtr, 100664649);
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002CB3C File Offset: 0x0002AD3C
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0002CB7C File Offset: 0x0002AD7C
		[CallerCount(0)]
		public unsafe int GetXmlNamespaceNode(out Il2CppReferenceArray<XPathNode> pageXmlNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageXmlNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0002CBDC File Offset: 0x0002ADDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 21226, RefRangeEnd = 21227, XrefRangeStart = 21220, XrefRangeEnd = 21226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LookupNamespaces(Il2CppReferenceArray<XPathNode> pageElem, int idxElem, out Il2CppReferenceArray<XPathNode> pageNmsp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxElem;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathDocument.NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			pageNmsp = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000049FD File Offset: 0x00002BFD
		public XPathDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0002CC5C File Offset: 0x0002AE5C
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00004A06 File Offset: 0x00002C06
		public unsafe Il2CppReferenceArray<XPathNode> pageXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_pageXmlNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0002CC8C File Offset: 0x0002AE8C
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00004A25 File Offset: 0x00002C25
		public unsafe int idxXmlNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_idxXmlNmsp)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00004A40 File Offset: 0x00002C40
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0002CCE4 File Offset: 0x0002AEE4
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x00004A5F File Offset: 0x00002C5F
		public unsafe Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XPathNodeRef, XPathNodeRef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocument.NativeFieldInfoPtr_mapNmsp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_pageXmlNmsp;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_idxXmlNmsp;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeFieldInfoPtr_mapNmsp;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlNamespaceNode_Internal_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespaces_Internal_Int32_Il2CppReferenceArray_1_XPathNode_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;
	}
}
