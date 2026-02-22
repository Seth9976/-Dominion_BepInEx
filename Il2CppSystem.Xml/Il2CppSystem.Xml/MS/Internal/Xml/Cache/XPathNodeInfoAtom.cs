using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000008 RID: 8
	public sealed class XPathNodeInfoAtom : Object
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00009F58 File Offset: 0x00008158
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNodeInfoAtom()
		{
			Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNodeInfoAtom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr);
			XPathNodeInfoAtom.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "localName");
			XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "namespaceUri");
			XPathNodeInfoAtom.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "prefix");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageParent");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageSibling");
			XPathNodeInfoAtom.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "doc");
			XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, "pageInfo");
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663340);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663341);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663342);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663343);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663344);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663345);
			XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNodeInfoAtom>.NativeClassPtr, 100663346);
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000A0A0 File Offset: 0x000082A0
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 8001, RefRangeEnd = 8014, XrefRangeStart = 8001, XrefRangeEnd = 8014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000A0E0 File Offset: 0x000082E0
		public unsafe string LocalName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000A118 File Offset: 0x00008318
		public unsafe string NamespaceUri
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000060 RID: 96 RVA: 0x0000A150 File Offset: 0x00008350
		public unsafe string Prefix
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000A188 File Offset: 0x00008388
		public unsafe Il2CppReferenceArray<XPathNode> SiblingPage
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000A1C8 File Offset: 0x000083C8
		public unsafe Il2CppReferenceArray<XPathNode> ParentPage
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr3) : null;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000A208 File Offset: 0x00008408
		public unsafe XPathDocument Document
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNodeInfoAtom.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000228F File Offset: 0x0000048F
		public XPathNodeInfoAtom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000A248 File Offset: 0x00008448
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002298 File Offset: 0x00000498
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000A270 File Offset: 0x00008470
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000022B7 File Offset: 0x000004B7
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000069 RID: 105 RVA: 0x0000A298 File Offset: 0x00008498
		// (set) Token: 0x0600006A RID: 106 RVA: 0x000022D6 File Offset: 0x000004D6
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006B RID: 107 RVA: 0x0000A2C0 File Offset: 0x000084C0
		// (set) Token: 0x0600006C RID: 108 RVA: 0x000022F5 File Offset: 0x000004F5
		public unsafe Il2CppReferenceArray<XPathNode> pageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000A2F0 File Offset: 0x000084F0
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002314 File Offset: 0x00000514
		public unsafe Il2CppReferenceArray<XPathNode> pageSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageSibling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000A320 File Offset: 0x00008520
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002333 File Offset: 0x00000533
		public unsafe XPathDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000A350 File Offset: 0x00008550
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002352 File Offset: 0x00000552
		public unsafe XPathNodePageInfo pageInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNodeInfoAtom.NativeFieldInfoPtr_pageInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_pageParent;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeFieldInfoPtr_pageSibling;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_pageInfo;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_SiblingPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentPage_Public_get_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;
	}
}
