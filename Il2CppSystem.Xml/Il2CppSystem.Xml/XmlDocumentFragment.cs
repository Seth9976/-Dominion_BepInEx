using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002F RID: 47
	public class XmlDocumentFragment : XmlNode
	{
		// Token: 0x06000453 RID: 1107 RVA: 0x0001ACB0 File Offset: 0x00018EB0
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocumentFragment()
		{
			Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDocumentFragment");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr);
			XmlDocumentFragment.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, "lastChild");
			XmlDocumentFragment.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100663998);
			XmlDocumentFragment.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100663999);
			XmlDocumentFragment.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664000);
			XmlDocumentFragment.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664001);
			XmlDocumentFragment.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664002);
			XmlDocumentFragment.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664003);
			XmlDocumentFragment.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664004);
			XmlDocumentFragment.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664005);
			XmlDocumentFragment.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664006);
			XmlDocumentFragment.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664007);
			XmlDocumentFragment.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664008);
			XmlDocumentFragment.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664009);
			XmlDocumentFragment.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr, 100664010);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001ADF8 File Offset: 0x00018FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15391, XrefRangeEnd = 15392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentFragment(XmlDocument ownerDocument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocumentFragment>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ownerDocument);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocumentFragment.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0001AE44 File Offset: 0x00019044
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x0001AE88 File Offset: 0x00019088
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0001AECC File Offset: 0x000190CC
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x0001AF14 File Offset: 0x00019114
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0001AF60 File Offset: 0x00019160
		public unsafe override XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15392, XrefRangeEnd = 15394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x0001AFAC File Offset: 0x000191AC
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15394, XrefRangeEnd = 15399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001AFFC File Offset: 0x000191FC
		[CallerCount(0)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x0001B054 File Offset: 0x00019254
		public unsafe override bool IsContainer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x0001B09C File Offset: 0x0001929C
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x0001B0E8 File Offset: 0x000192E8
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001B138 File Offset: 0x00019338
		[CallerCount(0)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001B18C File Offset: 0x0001938C
		[CallerCount(0)]
		public unsafe override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocumentFragment.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0000388C File Offset: 0x00001A8C
		public XmlDocumentFragment(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x0001B1F8 File Offset: 0x000193F8
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003895 File Offset: 0x00001A95
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentFragment.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocumentFragment.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlDocument_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0;
	}
}
