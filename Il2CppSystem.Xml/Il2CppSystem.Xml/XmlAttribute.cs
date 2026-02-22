using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000026 RID: 38
	public class XmlAttribute : XmlNode
	{
		// Token: 0x0600032B RID: 811 RVA: 0x00015A54 File Offset: 0x00013C54
		// Note: this type is marked as 'beforefieldinit'.
		static XmlAttribute()
		{
			Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr);
			XmlAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, "name");
			XmlAttribute.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, "lastChild");
			XmlAttribute.NativeMethodInfoPtr__ctor_Internal_Void_XmlName_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663827);
			XmlAttribute.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663828);
			XmlAttribute.NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663829);
			XmlAttribute.NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663830);
			XmlAttribute.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663831);
			XmlAttribute.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663832);
			XmlAttribute.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663833);
			XmlAttribute.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663834);
			XmlAttribute.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663835);
			XmlAttribute.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663836);
			XmlAttribute.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663837);
			XmlAttribute.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663838);
			XmlAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663839);
			XmlAttribute.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663840);
			XmlAttribute.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663841);
			XmlAttribute.NativeMethodInfoPtr_PrepareOwnerElementInElementIdAttrMap_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663842);
			XmlAttribute.NativeMethodInfoPtr_ResetOwnerElementInElementIdAttrMap_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663843);
			XmlAttribute.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663844);
			XmlAttribute.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663845);
			XmlAttribute.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663846);
			XmlAttribute.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663847);
			XmlAttribute.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663848);
			XmlAttribute.NativeMethodInfoPtr_get_Specified_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663849);
			XmlAttribute.NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663850);
			XmlAttribute.NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663851);
			XmlAttribute.NativeMethodInfoPtr_get_OwnerElement_Public_Virtual_New_get_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663852);
			XmlAttribute.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663853);
			XmlAttribute.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663854);
			XmlAttribute.NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr, 100663855);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00015CF0 File Offset: 0x00013EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14728, RefRangeEnd = 14729, XrefRangeStart = 14722, XrefRangeEnd = 14728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute(XmlName name, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr__ctor_Internal_Void_XmlName_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00015D50 File Offset: 0x00013F50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14736, RefRangeEnd = 14738, XrefRangeStart = 14729, XrefRangeEnd = 14736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlAttribute>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00015DD4 File Offset: 0x00013FD4
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00015E14 File Offset: 0x00014014
		public unsafe XmlName XmlName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00015E58 File Offset: 0x00014058
		[CallerCount(0)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000331 RID: 817 RVA: 0x00015EB0 File Offset: 0x000140B0
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00015EFC File Offset: 0x000140FC
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14738, XrefRangeEnd = 14740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000333 RID: 819 RVA: 0x00015F40 File Offset: 0x00014140
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00015F84 File Offset: 0x00014184
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000335 RID: 821 RVA: 0x00015FC8 File Offset: 0x000141C8
		public unsafe override string Prefix
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 14740, RefRangeEnd = 14742, XrefRangeStart = 14740, XrefRangeEnd = 14740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0001600C File Offset: 0x0001420C
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000337 RID: 823 RVA: 0x00016054 File Offset: 0x00014254
		public unsafe override XmlDocument OwnerDocument
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000338 RID: 824 RVA: 0x000160A0 File Offset: 0x000142A0
		// (set) Token: 0x06000339 RID: 825 RVA: 0x000160E4 File Offset: 0x000142E4
		public unsafe override string Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000153 RID: 339
		// (set) Token: 0x0600033A RID: 826 RVA: 0x00016134 File Offset: 0x00014334
		public unsafe override string InnerText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14747, RefRangeEnd = 14748, XrefRangeStart = 14742, XrefRangeEnd = 14747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00016184 File Offset: 0x00014384
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14754, RefRangeEnd = 14757, XrefRangeStart = 14748, XrefRangeEnd = 14754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PrepareOwnerElementInElementIdAttrMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr_PrepareOwnerElementInElementIdAttrMap_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x000161C0 File Offset: 0x000143C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14762, RefRangeEnd = 14765, XrefRangeStart = 14757, XrefRangeEnd = 14762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(oldInnerText);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlAttribute.NativeMethodInfoPtr_ResetOwnerElementInElementIdAttrMap_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00016204 File Offset: 0x00014404
		public unsafe override bool IsContainer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001624C File Offset: 0x0001444C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14765, XrefRangeEnd = 14770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600033F RID: 831 RVA: 0x000162BC File Offset: 0x000144BC
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00016308 File Offset: 0x00014508
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00016358 File Offset: 0x00014558
		[CallerCount(0)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000163AC File Offset: 0x000145AC
		public unsafe virtual bool Specified
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_Specified_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x000163F4 File Offset: 0x000145F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14775, RefRangeEnd = 14776, XrefRangeStart = 14771, XrefRangeEnd = 14775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode RemoveChild(XmlNode oldChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(oldChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00016450 File Offset: 0x00014650
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14780, RefRangeEnd = 14781, XrefRangeStart = 14776, XrefRangeEnd = 14780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode AppendChild(XmlNode newChild)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newChild);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000164AC File Offset: 0x000146AC
		public unsafe virtual XmlElement OwnerElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14781, XrefRangeEnd = 14782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_OwnerElement_Public_Virtual_New_get_XmlElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000164F8 File Offset: 0x000146F8
		public unsafe override string InnerXml
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14782, XrefRangeEnd = 14788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000347 RID: 839 RVA: 0x00016548 File Offset: 0x00014748
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14788, XrefRangeEnd = 14790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001658C File Offset: 0x0001478C
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlAttribute.NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00003205 File Offset: 0x00001405
		public XmlAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000165DC File Offset: 0x000147DC
		// (set) Token: 0x0600034B RID: 843 RVA: 0x0000320E File Offset: 0x0000140E
		public unsafe XmlName name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttribute.NativeFieldInfoPtr_name);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttribute.NativeFieldInfoPtr_name), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0001660C File Offset: 0x0001480C
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000322D File Offset: 0x0000142D
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttribute.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlAttribute.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlName_XmlDocument_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_String_String_String_XmlDocument_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlName_Internal_get_XmlName_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlName_Internal_set_Void_XmlName_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x04000283 RID: 643
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_Virtual_set_Void_String_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x04000288 RID: 648
		private static readonly IntPtr NativeMethodInfoPtr_PrepareOwnerElementInElementIdAttrMap_Internal_Boolean_0;

		// Token: 0x04000289 RID: 649
		private static readonly IntPtr NativeMethodInfoPtr_ResetOwnerElementInElementIdAttrMap_Internal_Void_String_0;

		// Token: 0x0400028A RID: 650
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x0400028B RID: 651
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0;

		// Token: 0x0400028C RID: 652
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x0400028D RID: 653
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x0400028E RID: 654
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x0400028F RID: 655
		private static readonly IntPtr NativeMethodInfoPtr_get_Specified_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04000290 RID: 656
		private static readonly IntPtr NativeMethodInfoPtr_RemoveChild_Public_Virtual_XmlNode_XmlNode_0;

		// Token: 0x04000291 RID: 657
		private static readonly IntPtr NativeMethodInfoPtr_AppendChild_Public_Virtual_XmlNode_XmlNode_0;

		// Token: 0x04000292 RID: 658
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerElement_Public_Virtual_New_get_XmlElement_0;

		// Token: 0x04000293 RID: 659
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x04000294 RID: 660
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x04000295 RID: 661
		private static readonly IntPtr NativeMethodInfoPtr_SetParent_Internal_Virtual_Void_XmlNode_0;
	}
}
