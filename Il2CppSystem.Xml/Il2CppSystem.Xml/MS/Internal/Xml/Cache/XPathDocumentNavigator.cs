using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Xml;
using Il2CppSystem.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	// Token: 0x02000003 RID: 3
	public sealed class XPathDocumentNavigator : XPathNavigator
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00008B48 File Offset: 0x00006D48
		// Note: this type is marked as 'beforefieldinit'.
		static XPathDocumentNavigator()
		{
			Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "MS.Internal.Xml.Cache", "XPathDocumentNavigator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr);
			XPathDocumentNavigator.NativeFieldInfoPtr_pageCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "pageCurrent");
			XPathDocumentNavigator.NativeFieldInfoPtr_pageParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "pageParent");
			XPathDocumentNavigator.NativeFieldInfoPtr_idxCurrent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "idxCurrent");
			XPathDocumentNavigator.NativeFieldInfoPtr_idxParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, "idxParent");
			XPathDocumentNavigator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663299);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663300);
			XPathDocumentNavigator.NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663301);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663302);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663303);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663304);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663305);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663306);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663307);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663308);
			XPathDocumentNavigator.NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663309);
			XPathDocumentNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663310);
			XPathDocumentNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663311);
			XPathDocumentNavigator.NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr, 100663312);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00008CE0 File Offset: 0x00006EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11633, XrefRangeEnd = 11637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XPathDocumentNavigator(Il2CppReferenceArray<XPathNode> pageCurrent, int idxCurrent, Il2CppReferenceArray<XPathNode> pageParent, int idxParent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XPathDocumentNavigator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pageCurrent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxCurrent;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pageParent);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref idxParent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00008D5C File Offset: 0x00006F5C
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11637, XrefRangeEnd = 11649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00008D94 File Offset: 0x00006F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11649, XrefRangeEnd = 11656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XPathNavigator Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XPathNavigator>(intPtr3) : null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00008DD4 File Offset: 0x00006FD4
		public unsafe override XPathNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00008E10 File Offset: 0x00007010
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00008E48 File Offset: 0x00007048
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00008E80 File Offset: 0x00007080
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00008EB8 File Offset: 0x000070B8
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00008EF8 File Offset: 0x000070F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11656, XrefRangeEnd = 11663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref namespaceScope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00008F44 File Offset: 0x00007144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11663, XrefRangeEnd = 11667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToNextNamespace(XPathNamespaceScope scope)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref scope;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00008F90 File Offset: 0x00007190
		[CallerCount(0)]
		public unsafe override bool MoveToParent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00008FCC File Offset: 0x000071CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 11667, XrefRangeEnd = 11669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsSamePosition(XPathNavigator other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000901C File Offset: 0x0000721C
		public unsafe override Object UnderlyingObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000905C File Offset: 0x0000725C
		[CallerCount(0)]
		public unsafe int GetPositionHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XPathDocumentNavigator.NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002076 File Offset: 0x00000276
		public XPathDocumentNavigator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00009098 File Offset: 0x00007298
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000207F File Offset: 0x0000027F
		public unsafe Il2CppReferenceArray<XPathNode> pageCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_pageCurrent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_pageCurrent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000019 RID: 25 RVA: 0x000090C8 File Offset: 0x000072C8
		// (set) Token: 0x0600001A RID: 26 RVA: 0x0000209E File Offset: 0x0000029E
		public unsafe Il2CppReferenceArray<XPathNode> pageParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_pageParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XPathNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_pageParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000090F8 File Offset: 0x000072F8
		// (set) Token: 0x0600001C RID: 28 RVA: 0x000020BD File Offset: 0x000002BD
		public unsafe int idxCurrent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_idxCurrent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_idxCurrent)) = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00009120 File Offset: 0x00007320
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000020D8 File Offset: 0x000002D8
		public unsafe int idxParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_idxParent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XPathDocumentNavigator.NativeFieldInfoPtr_idxParent)) = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_pageCurrent;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_pageParent;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_idxCurrent;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_idxParent;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_XPathNode_Int32_Il2CppReferenceArray_1_XPathNode_Int32_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_XPathNavigator_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XPathNodeType_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextNamespace_Public_Virtual_Boolean_XPathNamespaceScope_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_MoveToParent_Public_Virtual_Boolean_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_IsSamePosition_Public_Virtual_Boolean_XPathNavigator_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_UnderlyingObject_Public_Virtual_get_Object_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionHashCode_Public_Int32_0;
	}
}
