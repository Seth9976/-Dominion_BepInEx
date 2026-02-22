using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DE RID: 222
	public class SchemaInfo : Object
	{
		// Token: 0x06000DD8 RID: 3544 RVA: 0x000422AC File Offset: 0x000404AC
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaInfo()
		{
			Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr);
			SchemaInfo.NativeFieldInfoPtr_elementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDecls");
			SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "undeclaredElementDecls");
			SchemaInfo.NativeFieldInfoPtr_generalEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "generalEntities");
			SchemaInfo.NativeFieldInfoPtr_parameterEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "parameterEntities");
			SchemaInfo.NativeFieldInfoPtr_docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "docTypeName");
			SchemaInfo.NativeFieldInfoPtr_internalDtdSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "internalDtdSubset");
			SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasNonCDataAttributes");
			SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasDefaultAttributes");
			SchemaInfo.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "targetNamespaces");
			SchemaInfo.NativeFieldInfoPtr_attributeDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "attributeDecls");
			SchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "schemaType");
			SchemaInfo.NativeFieldInfoPtr_elementDeclsByType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDeclsByType");
			SchemaInfo.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "notations");
			SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665342);
			SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665343);
			SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665344);
			SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665345);
			SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665346);
			SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665347);
			SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665348);
			SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665349);
			SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665350);
			SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665351);
			SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665352);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665353);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665354);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665355);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665356);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665357);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100665358);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00042534 File Offset: 0x00040734
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 24265, RefRangeEnd = 24267, XrefRangeStart = 24232, XrefRangeEnd = 24265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700052A RID: 1322
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x00042570 File Offset: 0x00040770
		public unsafe XmlQualifiedName DocTypeName
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (set) Token: 0x06000DDB RID: 3547 RVA: 0x000425B4 File Offset: 0x000407B4
		public unsafe string InternalDtdSubset
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x000425F8 File Offset: 0x000407F8
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000DDD RID: 3549 RVA: 0x00042638 File Offset: 0x00040838
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000DDE RID: 3550 RVA: 0x00042678 File Offset: 0x00040878
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 24273, RefRangeEnd = 24280, XrefRangeStart = 24267, XrefRangeEnd = 24273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x000426B8 File Offset: 0x000408B8
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 24286, RefRangeEnd = 24292, XrefRangeStart = 24280, XrefRangeEnd = 24286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000DE0 RID: 3552 RVA: 0x000426F8 File Offset: 0x000408F8
		// (set) Token: 0x06000DE1 RID: 3553 RVA: 0x00042734 File Offset: 0x00040934
		public unsafe SchemaType SchemaType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24292, RefRangeEnd = 24293, XrefRangeStart = 24292, XrefRangeEnd = 24292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000DE2 RID: 3554 RVA: 0x00042774 File Offset: 0x00040974
		public unsafe Dictionary<string, SchemaNotation> Notations
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 24299, RefRangeEnd = 24304, XrefRangeStart = 24293, XrefRangeEnd = 24299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x000427B4 File Offset: 0x000409B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 24320, RefRangeEnd = 24321, XrefRangeStart = 24304, XrefRangeEnd = 24320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000DE4 RID: 3556 RVA: 0x000427E8 File Offset: 0x000409E8
		public unsafe virtual bool System.Xml.IDtdInfo.HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00042824 File Offset: 0x00040A24
		public unsafe virtual bool System.Xml.IDtdInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00042860 File Offset: 0x00040A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24321, XrefRangeEnd = 24330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdAttributeListInfo System_Xml_IDtdInfo_LookupAttributeList(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x000428C4 File Offset: 0x00040AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24330, XrefRangeEnd = 24337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdEntityInfo System_Xml_IDtdInfo_LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000DE8 RID: 3560 RVA: 0x00042914 File Offset: 0x00040B14
		public unsafe virtual XmlQualifiedName System.Xml.IDtdInfo.Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000DE9 RID: 3561 RVA: 0x00042954 File Offset: 0x00040B54
		public unsafe virtual string System.Xml.IDtdInfo.InternalDtdSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x000068CD File Offset: 0x00004ACD
		public SchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0004298C File Offset: 0x00040B8C
		// (set) Token: 0x06000DEC RID: 3564 RVA: 0x000068D6 File Offset: 0x00004AD6
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06000DED RID: 3565 RVA: 0x000429BC File Offset: 0x00040BBC
		// (set) Token: 0x06000DEE RID: 3566 RVA: 0x000068F5 File Offset: 0x00004AF5
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000DEF RID: 3567 RVA: 0x000429EC File Offset: 0x00040BEC
		// (set) Token: 0x06000DF0 RID: 3568 RVA: 0x00006914 File Offset: 0x00004B14
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> generalEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000DF1 RID: 3569 RVA: 0x00042A1C File Offset: 0x00040C1C
		// (set) Token: 0x06000DF2 RID: 3570 RVA: 0x00006933 File Offset: 0x00004B33
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x00042A4C File Offset: 0x00040C4C
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x00006952 File Offset: 0x00004B52
		public unsafe XmlQualifiedName docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00042A7C File Offset: 0x00040C7C
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x00006971 File Offset: 0x00004B71
		public unsafe string internalDtdSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x00042AA4 File Offset: 0x00040CA4
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x00006990 File Offset: 0x00004B90
		public unsafe bool hasNonCDataAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes)) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000DF9 RID: 3577 RVA: 0x00042ACC File Offset: 0x00040CCC
		// (set) Token: 0x06000DFA RID: 3578 RVA: 0x000069AB File Offset: 0x00004BAB
		public unsafe bool hasDefaultAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes)) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000DFB RID: 3579 RVA: 0x00042AF4 File Offset: 0x00040CF4
		// (set) Token: 0x06000DFC RID: 3580 RVA: 0x000069C6 File Offset: 0x00004BC6
		public unsafe Dictionary<string, bool> targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00042B24 File Offset: 0x00040D24
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000069E5 File Offset: 0x00004BE5
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000DFF RID: 3583 RVA: 0x00042B54 File Offset: 0x00040D54
		// (set) Token: 0x06000E00 RID: 3584 RVA: 0x00006A04 File Offset: 0x00004C04
		public unsafe SchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType)) = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000E01 RID: 3585 RVA: 0x00042B7C File Offset: 0x00040D7C
		// (set) Token: 0x06000E02 RID: 3586 RVA: 0x00006A1F File Offset: 0x00004C1F
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000E03 RID: 3587 RVA: 0x00042BAC File Offset: 0x00040DAC
		// (set) Token: 0x06000E04 RID: 3588 RVA: 0x00006A3E File Offset: 0x00004C3E
		public unsafe Dictionary<string, SchemaNotation> notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeFieldInfoPtr_elementDecls;

		// Token: 0x04000A3F RID: 2623
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredElementDecls;

		// Token: 0x04000A40 RID: 2624
		private static readonly IntPtr NativeFieldInfoPtr_generalEntities;

		// Token: 0x04000A41 RID: 2625
		private static readonly IntPtr NativeFieldInfoPtr_parameterEntities;

		// Token: 0x04000A42 RID: 2626
		private static readonly IntPtr NativeFieldInfoPtr_docTypeName;

		// Token: 0x04000A43 RID: 2627
		private static readonly IntPtr NativeFieldInfoPtr_internalDtdSubset;

		// Token: 0x04000A44 RID: 2628
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttributes;

		// Token: 0x04000A45 RID: 2629
		private static readonly IntPtr NativeFieldInfoPtr_hasDefaultAttributes;

		// Token: 0x04000A46 RID: 2630
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x04000A47 RID: 2631
		private static readonly IntPtr NativeFieldInfoPtr_attributeDecls;

		// Token: 0x04000A48 RID: 2632
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x04000A49 RID: 2633
		private static readonly IntPtr NativeFieldInfoPtr_elementDeclsByType;

		// Token: 0x04000A4A RID: 2634
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x04000A4B RID: 2635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000A4C RID: 2636
		private static readonly IntPtr NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04000A4D RID: 2637
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0;

		// Token: 0x04000A4E RID: 2638
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x04000A4F RID: 2639
		private static readonly IntPtr NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x04000A50 RID: 2640
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x04000A51 RID: 2641
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x04000A52 RID: 2642
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0;

		// Token: 0x04000A53 RID: 2643
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0;

		// Token: 0x04000A54 RID: 2644
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0;

		// Token: 0x04000A55 RID: 2645
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_0;

		// Token: 0x04000A56 RID: 2646
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A57 RID: 2647
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A58 RID: 2648
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x04000A59 RID: 2649
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0;

		// Token: 0x04000A5A RID: 2650
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0;

		// Token: 0x04000A5B RID: 2651
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0;
	}
}
