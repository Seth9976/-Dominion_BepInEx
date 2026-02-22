using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000004 RID: 4
	public sealed class XPathNode : ValueType
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00009148 File Offset: 0x00007348
		// Note: this type is marked as 'beforefieldinit'.
		static XPathNode()
		{
			Il2CppClassPointerStore<XPathNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathNode>.NativeClassPtr);
			XPathNode.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "info");
			XPathNode.NativeFieldInfoPtr_idxSibling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxSibling");
			XPathNode.NativeFieldInfoPtr_idxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxParent");
			XPathNode.NativeFieldInfoPtr_idxSimilar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "idxSimilar");
			XPathNode.NativeFieldInfoPtr_posOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "posOffset");
			XPathNode.NativeFieldInfoPtr_props = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "props");
			XPathNode.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, "value");
			XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663313);
			XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663314);
			XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663315);
			XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663316);
			XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663317);
			XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663318);
			XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663319);
			XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663320);
			XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663321);
			XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663322);
			XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663323);
			XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663324);
			XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663325);
			XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathNode>.NativeClassPtr, 100663326);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000931C File Offset: 0x0000751C
		public unsafe XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00009360 File Offset: 0x00007560
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000022 RID: 34 RVA: 0x0000939C File Offset: 0x0000759C
		public unsafe string LocalName
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 11669, RefRangeEnd = 11672, XrefRangeStart = 11669, XrefRangeEnd = 11669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000093D8 File Offset: 0x000075D8
		public unsafe string NamespaceUri
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00009414 File Offset: 0x00007614
		public unsafe XPathDocument Document
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00009458 File Offset: 0x00007658
		public unsafe XPathNodePageInfo PageInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNodePageInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000949C File Offset: 0x0000769C
		[CallerCount(0)]
		public unsafe int GetParent(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00009500 File Offset: 0x00007700
		[CallerCount(0)]
		public unsafe int GetSibling(out Il2CppReferenceArray<XPathNode> pageNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				pageNode = ((intPtr4 == 0) ? null : new Il2CppReferenceArray<XPathNode>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00009564 File Offset: 0x00007764
		public unsafe bool IsXmlNamespaceNode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 11675, RefRangeEnd = 11676, XrefRangeStart = 11672, XrefRangeEnd = 11675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000095A8 File Offset: 0x000077A8
		public unsafe bool HasSibling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000095EC File Offset: 0x000077EC
		public unsafe bool HasCollapsedText
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00009630 File Offset: 0x00007830
		public unsafe bool IsText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11676, XrefRangeEnd = 11679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00009674 File Offset: 0x00007874
		public unsafe bool HasNamespaceDecls
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000096B8 File Offset: 0x000078B8
		public unsafe string Value
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathNode.NativeMethodInfoPtr_get_Value_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020F3 File Offset: 0x000002F3
		public XPathNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020FC File Offset: 0x000002FC
		public XPathNode()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathNode>.NativeClassPtr))
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000096F4 File Offset: 0x000078F4
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0000210E File Offset: 0x0000030E
		public unsafe XPathNodeInfoAtom info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_info);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XPathNodeInfoAtom>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_info), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00009724 File Offset: 0x00007924
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0000212D File Offset: 0x0000032D
		public unsafe ushort idxSibling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSibling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSibling)) = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0000974C File Offset: 0x0000794C
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00002148 File Offset: 0x00000348
		public unsafe ushort idxParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxParent)) = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00009774 File Offset: 0x00007974
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00002163 File Offset: 0x00000363
		public unsafe ushort idxSimilar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSimilar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_idxSimilar)) = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000979C File Offset: 0x0000799C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000217E File Offset: 0x0000037E
		public unsafe ushort posOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_posOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_posOffset)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003A RID: 58 RVA: 0x000097C4 File Offset: 0x000079C4
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00002199 File Offset: 0x00000399
		public unsafe uint props
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_props);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_props)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003C RID: 60 RVA: 0x000097EC File Offset: 0x000079EC
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021B4 File Offset: 0x000003B4
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathNode.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_idxSibling;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr_idxParent;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr_idxSimilar;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeFieldInfoPtr_posOffset;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_props;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XPathNodeType_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceUri_Public_get_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_Document_Public_get_XPathDocument_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_PageInfo_Public_get_XPathNodePageInfo_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_GetParent_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetSibling_Public_Int32_byref_Il2CppReferenceArray_1_XPathNode_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXmlNamespaceNode_Public_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSibling_Public_get_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_HasCollapsedText_Public_get_Boolean_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_IsText_Public_get_Boolean_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNamespaceDecls_Public_get_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_String_0;
	}
}
