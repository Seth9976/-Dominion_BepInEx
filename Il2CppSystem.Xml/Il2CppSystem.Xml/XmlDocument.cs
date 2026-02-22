using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200002E RID: 46
	public class XmlDocument : XmlNode
	{
		// Token: 0x060003AC RID: 940 RVA: 0x00018134 File Offset: 0x00016334
		// Note: this type is marked as 'beforefieldinit'.
		static XmlDocument()
		{
			Il2CppClassPointerStore<XmlDocument>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlDocument");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr);
			XmlDocument.NativeFieldInfoPtr_implementation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "implementation");
			XmlDocument.NativeFieldInfoPtr_domNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "domNameTable");
			XmlDocument.NativeFieldInfoPtr_lastChild = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "lastChild");
			XmlDocument.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "entities");
			XmlDocument.NativeFieldInfoPtr_htElementIdMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "htElementIdMap");
			XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "htElementIDAttrDecl");
			XmlDocument.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "schemaInfo");
			XmlDocument.NativeFieldInfoPtr_schemas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "schemas");
			XmlDocument.NativeFieldInfoPtr_reportValidity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "reportValidity");
			XmlDocument.NativeFieldInfoPtr_actualLoadingStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "actualLoadingStatus");
			XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeInsertingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeInsertedDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeRemovingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeRemovedDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeChangingDelegate");
			XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "onNodeChangedDelegate");
			XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "fEntRefNodesPresent");
			XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "fCDataNodesPresent");
			XmlDocument.NativeFieldInfoPtr_preserveWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "preserveWhitespace");
			XmlDocument.NativeFieldInfoPtr_isLoading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "isLoading");
			XmlDocument.NativeFieldInfoPtr_strDocumentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strDocumentName");
			XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strDocumentFragmentName");
			XmlDocument.NativeFieldInfoPtr_strCommentName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strCommentName");
			XmlDocument.NativeFieldInfoPtr_strTextName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strTextName");
			XmlDocument.NativeFieldInfoPtr_strCDataSectionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strCDataSectionName");
			XmlDocument.NativeFieldInfoPtr_strEntityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strEntityName");
			XmlDocument.NativeFieldInfoPtr_strID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strID");
			XmlDocument.NativeFieldInfoPtr_strXmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strXmlns");
			XmlDocument.NativeFieldInfoPtr_strXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strXml");
			XmlDocument.NativeFieldInfoPtr_strSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strSpace");
			XmlDocument.NativeFieldInfoPtr_strLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strLang");
			XmlDocument.NativeFieldInfoPtr_strEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strEmpty");
			XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strNonSignificantWhitespaceName");
			XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strSignificantWhitespaceName");
			XmlDocument.NativeFieldInfoPtr_strReservedXmlns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strReservedXmlns");
			XmlDocument.NativeFieldInfoPtr_strReservedXml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "strReservedXml");
			XmlDocument.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "baseURI");
			XmlDocument.NativeFieldInfoPtr_resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "resolver");
			XmlDocument.NativeFieldInfoPtr_bSetResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "bSetResolver");
			XmlDocument.NativeFieldInfoPtr_objLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "objLock");
			XmlDocument.NativeFieldInfoPtr_EmptyEnumerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "EmptyEnumerator");
			XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "NotKnownSchemaInfo");
			XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "ValidSchemaInfo");
			XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, "InvalidSchemaInfo");
			XmlDocument.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663920);
			XmlDocument.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663921);
			XmlDocument.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663922);
			XmlDocument.NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663923);
			XmlDocument.NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663924);
			XmlDocument.NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663925);
			XmlDocument.NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663926);
			XmlDocument.NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663927);
			XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663928);
			XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663929);
			XmlDocument.NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663930);
			XmlDocument.NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663931);
			XmlDocument.NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663932);
			XmlDocument.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663933);
			XmlDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663934);
			XmlDocument.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663935);
			XmlDocument.NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663936);
			XmlDocument.NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663937);
			XmlDocument.NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663938);
			XmlDocument.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663939);
			XmlDocument.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663940);
			XmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663941);
			XmlDocument.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663942);
			XmlDocument.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663943);
			XmlDocument.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663944);
			XmlDocument.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663945);
			XmlDocument.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663946);
			XmlDocument.NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663947);
			XmlDocument.NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663948);
			XmlDocument.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663949);
			XmlDocument.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663950);
			XmlDocument.NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663951);
			XmlDocument.NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663952);
			XmlDocument.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663953);
			XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663954);
			XmlDocument.NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663955);
			XmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663956);
			XmlDocument.NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663957);
			XmlDocument.NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663958);
			XmlDocument.NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663959);
			XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663960);
			XmlDocument.NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663961);
			XmlDocument.NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663962);
			XmlDocument.NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663963);
			XmlDocument.NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663964);
			XmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663965);
			XmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663966);
			XmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663967);
			XmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663968);
			XmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663969);
			XmlDocument.NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663970);
			XmlDocument.NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663971);
			XmlDocument.NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663972);
			XmlDocument.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663973);
			XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663974);
			XmlDocument.NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663975);
			XmlDocument.NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663976);
			XmlDocument.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663977);
			XmlDocument.NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663978);
			XmlDocument.NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663979);
			XmlDocument.NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663980);
			XmlDocument.NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663981);
			XmlDocument.NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663982);
			XmlDocument.NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663983);
			XmlDocument.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663984);
			XmlDocument.NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663985);
			XmlDocument.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663986);
			XmlDocument.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663987);
			XmlDocument.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663988);
			XmlDocument.NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663989);
			XmlDocument.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663990);
			XmlDocument.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663991);
			XmlDocument.NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663992);
			XmlDocument.NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663993);
			XmlDocument.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663994);
			XmlDocument.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663995);
			XmlDocument.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr, 100663996);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00018AD8 File Offset: 0x00016CD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15059, RefRangeEnd = 15060, XrefRangeStart = 15016, XrefRangeEnd = 15059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocument(XmlImplementation imp)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlDocument>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(imp);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00018B24 File Offset: 0x00016D24
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00018B64 File Offset: 0x00016D64
		public unsafe SchemaInfo DtdSchemaInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00018BA8 File Offset: 0x00016DA8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 15064, RefRangeEnd = 15070, XrefRangeStart = 15060, XrefRangeEnd = 15064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00018BE0 File Offset: 0x00016DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15070, XrefRangeEnd = 15072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00018C68 File Offset: 0x00016E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15072, XrefRangeEnd = 15074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00018CF0 File Offset: 0x00016EF0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 15076, RefRangeEnd = 15081, XrefRangeStart = 15074, XrefRangeEnd = 15076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(schemaInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00018D78 File Offset: 0x00016F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15082, RefRangeEnd = 15083, XrefRangeStart = 15081, XrefRangeEnd = 15082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00018DD8 File Offset: 0x00016FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15083, XrefRangeEnd = 15087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetIDInfoByElement_(XmlName eleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
			}
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00018E28 File Offset: 0x00017028
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 15092, RefRangeEnd = 15097, XrefRangeStart = 15087, XrefRangeEnd = 15092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlName GetIDInfoByElement(XmlName eleName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eleName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlName>(intPtr3) : null;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00018E78 File Offset: 0x00017078
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15119, RefRangeEnd = 15121, XrefRangeStart = 15097, XrefRangeEnd = 15119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<WeakReference>(intPtr3) : null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00018EDC File Offset: 0x000170DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15130, RefRangeEnd = 15133, XrefRangeStart = 15121, XrefRangeEnd = 15130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddElementWithId(string id, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00018F30 File Offset: 0x00017130
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15137, RefRangeEnd = 15141, XrefRangeStart = 15133, XrefRangeEnd = 15137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElementWithId(string id, XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00018F84 File Offset: 0x00017184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15141, XrefRangeEnd = 15142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNode CloneNode(bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref deep;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00018FDC File Offset: 0x000171DC
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00019024 File Offset: 0x00017224
		public unsafe override XmlNode ParentNode
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00019070 File Offset: 0x00017270
		public unsafe virtual XmlDocumentType DocumentType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15142, XrefRangeEnd = 15144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000190BC File Offset: 0x000172BC
		public unsafe virtual XmlDeclaration Declaration
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15144, XrefRangeEnd = 15145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00019108 File Offset: 0x00017308
		public unsafe XmlImplementation Implementation
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlImplementation>(intPtr3) : null;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00019148 File Offset: 0x00017348
		public unsafe override string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x0001918C File Offset: 0x0001738C
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x000191D0 File Offset: 0x000173D0
		public unsafe XmlElement DocumentElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15145, XrefRangeEnd = 15147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x00019210 File Offset: 0x00017410
		public unsafe override bool IsContainer
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00019258 File Offset: 0x00017458
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000192A4 File Offset: 0x000174A4
		public unsafe override XmlLinkedNode LastNode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000192F4 File Offset: 0x000174F4
		public unsafe override XmlDocument OwnerDocument
		{
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr3) : null;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00019340 File Offset: 0x00017540
		public unsafe XmlSchemaSet Schemas
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00019384 File Offset: 0x00017584
		public unsafe bool CanReportValidity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000193C0 File Offset: 0x000175C0
		public unsafe bool HasSetResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000193FC File Offset: 0x000175FC
		[CallerCount(0)]
		public unsafe XmlResolver GetResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0001943C File Offset: 0x0001763C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15147, XrefRangeEnd = 15150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidChildType(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00019490 File Offset: 0x00017690
		[CallerCount(0)]
		public unsafe bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000194EC File Offset: 0x000176EC
		[CallerCount(0)]
		public unsafe bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00019548 File Offset: 0x00017748
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000195B4 File Offset: 0x000177B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15157, RefRangeEnd = 15158, XrefRangeStart = 15150, XrefRangeEnd = 15157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute CreateAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00019604 File Offset: 0x00017804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15158, XrefRangeEnd = 15162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			namespaceURI = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00019678 File Offset: 0x00017878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15162, XrefRangeEnd = 15166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlCDataSection CreateCDataSection(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlCDataSection>(intPtr3) : null;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000196D4 File Offset: 0x000178D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15166, XrefRangeEnd = 15170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlComment CreateComment(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlComment>(intPtr3) : null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00019730 File Offset: 0x00017930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15170, XrefRangeEnd = 15180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000197C4 File Offset: 0x000179C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15180, XrefRangeEnd = 15184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDocumentFragment CreateDocumentFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentFragment>(intPtr3) : null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00019810 File Offset: 0x00017A10
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15188, RefRangeEnd = 15192, XrefRangeStart = 15184, XrefRangeEnd = 15188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlElement CreateElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00019860 File Offset: 0x00017A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15215, RefRangeEnd = 15216, XrefRangeStart = 15192, XrefRangeEnd = 15215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultAttributes(XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000198A4 File Offset: 0x00017AA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15224, RefRangeEnd = 15226, XrefRangeStart = 15216, XrefRangeEnd = 15224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x000198F4 File Offset: 0x00017AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15234, RefRangeEnd = 15236, XrefRangeStart = 15226, XrefRangeEnd = 15234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrPrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrLocalname);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrNamespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0001997C File Offset: 0x00017B7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15236, XrefRangeEnd = 15240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlEntityReference CreateEntityReference(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000199D8 File Offset: 0x00017BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15240, XrefRangeEnd = 15244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlProcessingInstruction>(intPtr3) : null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00019A48 File Offset: 0x00017C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15244, XrefRangeEnd = 15248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(version);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(encoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(standalone);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00019AC8 File Offset: 0x00017CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15248, XrefRangeEnd = 15252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlText CreateTextNode(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlText>(intPtr3) : null;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00019B24 File Offset: 0x00017D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15252, XrefRangeEnd = 15256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSignificantWhitespace>(intPtr3) : null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00019B80 File Offset: 0x00017D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15256, XrefRangeEnd = 15260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlWhitespace CreateWhitespace(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlWhitespace>(intPtr3) : null;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00019BDC File Offset: 0x00017DDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15283, RefRangeEnd = 15287, XrefRangeStart = 15260, XrefRangeEnd = 15283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00019C3C File Offset: 0x00017E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15287, XrefRangeEnd = 15290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromElem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toElem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00019C90 File Offset: 0x00017E90
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 15291, RefRangeEnd = 15294, XrefRangeStart = 15290, XrefRangeEnd = 15291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fromNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toNode);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deep;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00019CF4 File Offset: 0x00017EF4
		public unsafe XmlNameTable NameTable
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 14740, RefRangeEnd = 14742, XrefRangeStart = 14740, XrefRangeEnd = 14742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00019D34 File Offset: 0x00017F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15294, XrefRangeEnd = 15299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00019DB4 File Offset: 0x00017FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15299, XrefRangeEnd = 15303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00019E34 File Offset: 0x00018034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15303, XrefRangeEnd = 15309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(namespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlElement>(intPtr3) : null;
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00019EB4 File Offset: 0x000180B4
		public unsafe override bool IsReadOnly
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00019EFC File Offset: 0x000180FC
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00019F3C File Offset: 0x0001813C
		public unsafe XmlNamedNodeMap Entities
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15309, XrefRangeEnd = 15313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00019F80 File Offset: 0x00018180
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x00019FBC File Offset: 0x000181BC
		public unsafe bool IsLoading
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00019FFC File Offset: 0x000181FC
		public unsafe bool ActualLoadingStatus
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x0001A038 File Offset: 0x00018238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15313, XrefRangeEnd = 15316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReader SetupReader(XmlTextReader tr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReader>(intPtr3) : null;
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x0001A088 File Offset: 0x00018288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15316, XrefRangeEnd = 15322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(XmlReader reader)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0001A0D8 File Offset: 0x000182D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15322, XrefRangeEnd = 15334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LoadXml(string xml)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xml);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170001BA RID: 442
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0001A128 File Offset: 0x00018328
		public unsafe override string InnerText
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15334, XrefRangeEnd = 15341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001BB RID: 443
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x0001A178 File Offset: 0x00018378
		public unsafe override string InnerXml
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15341, XrefRangeEnd = 15348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0001A27C File Offset: 0x0001847C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 15349, RefRangeEnd = 15354, XrefRangeStart = 15348, XrefRangeEnd = 15349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventArgs>(intPtr3) : null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0001A2E0 File Offset: 0x000184E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15354, XrefRangeEnd = 15357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0001A330 File Offset: 0x00018530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15357, XrefRangeEnd = 15360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AfterEvent(XmlNodeChangedEventArgs args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0001A380 File Offset: 0x00018580
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15380, RefRangeEnd = 15381, XrefRangeStart = 15360, XrefRangeEnd = 15380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrPrefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrLocalname);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(attrNamespaceURI);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0001A408 File Offset: 0x00018608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15381, XrefRangeEnd = 15387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntity GetEntityNode(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntity>(intPtr3) : null;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x0001A458 File Offset: 0x00018658
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0001A49C File Offset: 0x0001869C
		[CallerCount(0)]
		public unsafe void SetBaseURI(string inBaseURI)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(inBaseURI);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlDocument.NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0001A4E0 File Offset: 0x000186E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15387, XrefRangeEnd = 15391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlDocument.NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x0000337F File Offset: 0x0000157F
		public XmlDocument(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x0001A550 File Offset: 0x00018750
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003388 File Offset: 0x00001588
		public unsafe XmlImplementation implementation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_implementation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlImplementation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_implementation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x0001A580 File Offset: 0x00018780
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x000033A7 File Offset: 0x000015A7
		public unsafe DomNameTable domNameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_domNameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DomNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_domNameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0001A5B0 File Offset: 0x000187B0
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x000033C6 File Offset: 0x000015C6
		public unsafe XmlLinkedNode lastChild
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_lastChild);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlLinkedNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_lastChild), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0001A5E0 File Offset: 0x000187E0
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000033E5 File Offset: 0x000015E5
		public unsafe XmlNamedNodeMap entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamedNodeMap>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x0001A610 File Offset: 0x00018810
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00003404 File Offset: 0x00001604
		public unsafe Hashtable htElementIdMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIdMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIdMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x0001A640 File Offset: 0x00018840
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00003423 File Offset: 0x00001623
		public unsafe Hashtable htElementIDAttrDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_htElementIDAttrDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001A670 File Offset: 0x00018870
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00003442 File Offset: 0x00001642
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x0001A6A0 File Offset: 0x000188A0
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00003461 File Offset: 0x00001661
		public unsafe XmlSchemaSet schemas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_schemas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x0001A6D0 File Offset: 0x000188D0
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00003480 File Offset: 0x00001680
		public unsafe bool reportValidity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_reportValidity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_reportValidity)) = value;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x0001A6F8 File Offset: 0x000188F8
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x0000349B File Offset: 0x0000169B
		public unsafe bool actualLoadingStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_actualLoadingStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_actualLoadingStatus)) = value;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0001A720 File Offset: 0x00018920
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000034B6 File Offset: 0x000016B6
		public unsafe XmlNodeChangedEventHandler onNodeInsertingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001A750 File Offset: 0x00018950
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000034D5 File Offset: 0x000016D5
		public unsafe XmlNodeChangedEventHandler onNodeInsertedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeInsertedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0001A780 File Offset: 0x00018980
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000034F4 File Offset: 0x000016F4
		public unsafe XmlNodeChangedEventHandler onNodeRemovingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x0001A7B0 File Offset: 0x000189B0
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00003513 File Offset: 0x00001713
		public unsafe XmlNodeChangedEventHandler onNodeRemovedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeRemovedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0001A7E0 File Offset: 0x000189E0
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00003532 File Offset: 0x00001732
		public unsafe XmlNodeChangedEventHandler onNodeChangingDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangingDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0001A810 File Offset: 0x00018A10
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003551 File Offset: 0x00001751
		public unsafe XmlNodeChangedEventHandler onNodeChangedDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNodeChangedEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_onNodeChangedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0001A840 File Offset: 0x00018A40
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00003570 File Offset: 0x00001770
		public unsafe bool fEntRefNodesPresent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fEntRefNodesPresent)) = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0001A868 File Offset: 0x00018A68
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000358B File Offset: 0x0000178B
		public unsafe bool fCDataNodesPresent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_fCDataNodesPresent)) = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0001A890 File Offset: 0x00018A90
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x000035A6 File Offset: 0x000017A6
		public unsafe bool preserveWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_preserveWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_preserveWhitespace)) = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0001A8B8 File Offset: 0x00018AB8
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000035C1 File Offset: 0x000017C1
		public unsafe bool isLoading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_isLoading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_isLoading)) = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000035DC File Offset: 0x000017DC
		public unsafe string strDocumentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0001A908 File Offset: 0x00018B08
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000035FB File Offset: 0x000017FB
		public unsafe string strDocumentFragmentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strDocumentFragmentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0001A930 File Offset: 0x00018B30
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0000361A File Offset: 0x0000181A
		public unsafe string strCommentName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCommentName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCommentName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0001A958 File Offset: 0x00018B58
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00003639 File Offset: 0x00001839
		public unsafe string strTextName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strTextName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strTextName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0001A980 File Offset: 0x00018B80
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003658 File Offset: 0x00001858
		public unsafe string strCDataSectionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCDataSectionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strCDataSectionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0001A9A8 File Offset: 0x00018BA8
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00003677 File Offset: 0x00001877
		public unsafe string strEntityName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEntityName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEntityName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00003696 File Offset: 0x00001896
		public unsafe string strID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0001A9F8 File Offset: 0x00018BF8
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x000036B5 File Offset: 0x000018B5
		public unsafe string strXmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001AA20 File Offset: 0x00018C20
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x000036D4 File Offset: 0x000018D4
		public unsafe string strXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001AA48 File Offset: 0x00018C48
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000036F3 File Offset: 0x000018F3
		public unsafe string strSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0001AA70 File Offset: 0x00018C70
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003712 File Offset: 0x00001912
		public unsafe string strLang
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strLang);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strLang), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001AA98 File Offset: 0x00018C98
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00003731 File Offset: 0x00001931
		public unsafe string strEmpty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEmpty);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strEmpty), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00003750 File Offset: 0x00001950
		public unsafe string strNonSignificantWhitespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strNonSignificantWhitespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001AAE8 File Offset: 0x00018CE8
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x0000376F File Offset: 0x0000196F
		public unsafe string strSignificantWhitespaceName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strSignificantWhitespaceName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0001AB10 File Offset: 0x00018D10
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x0000378E File Offset: 0x0000198E
		public unsafe string strReservedXmlns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXmlns);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXmlns), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0001AB38 File Offset: 0x00018D38
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000037AD File Offset: 0x000019AD
		public unsafe string strReservedXml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_strReservedXml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001AB60 File Offset: 0x00018D60
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000037CC File Offset: 0x000019CC
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0001AB88 File Offset: 0x00018D88
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000037EB File Offset: 0x000019EB
		public unsafe XmlResolver resolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_resolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001ABB8 File Offset: 0x00018DB8
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x0000380A File Offset: 0x00001A0A
		public unsafe bool bSetResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_bSetResolver);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_bSetResolver)) = value;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00003825 File Offset: 0x00001A25
		public unsafe Object objLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_objLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlDocument.NativeFieldInfoPtr_objLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001AC10 File Offset: 0x00018E10
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003844 File Offset: 0x00001A44
		public unsafe static EmptyEnumerator EmptyEnumerator
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_EmptyEnumerator, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmptyEnumerator>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_EmptyEnumerator, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001AC38 File Offset: 0x00018E38
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003856 File Offset: 0x00001A56
		public unsafe static IXmlSchemaInfo NotKnownSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_NotKnownSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0001AC60 File Offset: 0x00018E60
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003868 File Offset: 0x00001A68
		public unsafe static IXmlSchemaInfo ValidSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_ValidSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0001AC88 File Offset: 0x00018E88
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0000387A File Offset: 0x00001A7A
		public unsafe static IXmlSchemaInfo InvalidSchemaInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlSchemaInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XmlDocument.NativeFieldInfoPtr_InvalidSchemaInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeFieldInfoPtr_implementation;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_domNameTable;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeFieldInfoPtr_lastChild;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeFieldInfoPtr_htElementIdMap;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeFieldInfoPtr_htElementIDAttrDecl;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeFieldInfoPtr_schemas;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeFieldInfoPtr_reportValidity;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeFieldInfoPtr_actualLoadingStatus;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeFieldInfoPtr_onNodeInsertingDelegate;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeFieldInfoPtr_onNodeInsertedDelegate;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeFieldInfoPtr_onNodeRemovingDelegate;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeFieldInfoPtr_onNodeRemovedDelegate;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeFieldInfoPtr_onNodeChangingDelegate;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeFieldInfoPtr_onNodeChangedDelegate;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeFieldInfoPtr_fEntRefNodesPresent;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeFieldInfoPtr_fCDataNodesPresent;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_preserveWhitespace;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_isLoading;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_strDocumentName;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeFieldInfoPtr_strDocumentFragmentName;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeFieldInfoPtr_strCommentName;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeFieldInfoPtr_strTextName;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeFieldInfoPtr_strCDataSectionName;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeFieldInfoPtr_strEntityName;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeFieldInfoPtr_strID;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeFieldInfoPtr_strXmlns;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeFieldInfoPtr_strXml;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeFieldInfoPtr_strSpace;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_strLang;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeFieldInfoPtr_strEmpty;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeFieldInfoPtr_strNonSignificantWhitespaceName;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeFieldInfoPtr_strSignificantWhitespaceName;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeFieldInfoPtr_strReservedXmlns;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_strReservedXml;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_resolver;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_bSetResolver;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeFieldInfoPtr_objLock;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeFieldInfoPtr_EmptyEnumerator;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeFieldInfoPtr_NotKnownSchemaInfo;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr_ValidSchemaInfo;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeFieldInfoPtr_InvalidSchemaInfo;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_XmlImplementation_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdSchemaInfo_Internal_get_SchemaInfo_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdSchemaInfo_Internal_set_Void_SchemaInfo_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_CheckName_Internal_Static_Void_String_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_AddXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_GetXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_AddAttrXmlName_Internal_XmlName_String_String_String_IXmlSchemaInfo_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_AddIdInfo_Internal_Boolean_XmlName_XmlName_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_GetIDInfoByElement__Private_XmlName_XmlName_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_GetIDInfoByElement_Internal_XmlName_XmlName_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Private_WeakReference_ArrayList_XmlElement_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_AddElementWithId_Internal_Void_String_XmlElement_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_RemoveElementWithId_Internal_Void_String_XmlElement_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_CloneNode_Public_Virtual_XmlNode_Boolean_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentNode_Public_Virtual_get_XmlNode_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentType_Public_Virtual_New_get_XmlDocumentType_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_get_Declaration_Internal_Virtual_New_get_XmlDeclaration_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_get_Implementation_Public_get_XmlImplementation_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_get_DocumentElement_Public_get_XmlElement_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_get_IsContainer_Internal_Virtual_get_Boolean_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_get_LastNode_Internal_Virtual_get_XmlLinkedNode_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_set_LastNode_Internal_Virtual_set_Void_XmlLinkedNode_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_OwnerDocument_Public_Virtual_get_XmlDocument_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_set_Schemas_Public_set_Void_XmlSchemaSet_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_get_CanReportValidity_Internal_get_Boolean_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_get_HasSetResolver_Internal_get_Boolean_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_GetResolver_Internal_XmlResolver_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_IsValidChildType_Internal_Virtual_Boolean_XmlNodeType_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_HasNodeTypeInPrevSiblings_Private_Boolean_XmlNodeType_XmlNode_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_HasNodeTypeInNextSiblings_Private_Boolean_XmlNodeType_XmlNode_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_CanInsertAfter_Internal_Virtual_Boolean_XmlNode_XmlNode_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_XmlAttribute_String_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_SetDefaultNamespace_Internal_Void_String_String_byref_String_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_CreateCDataSection_Public_Virtual_New_XmlCDataSection_String_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_CreateComment_Public_Virtual_New_XmlComment_String_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocumentType_Public_Virtual_New_XmlDocumentType_String_String_String_String_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_CreateDocumentFragment_Public_Virtual_New_XmlDocumentFragment_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_XmlElement_String_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributes_Internal_Void_XmlElement_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_GetSchemaElementDecl_Private_SchemaElementDecl_XmlElement_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_PrepareDefaultAttribute_Private_XmlAttribute_SchemaAttDef_String_String_String_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntityReference_Public_Virtual_New_XmlEntityReference_String_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_CreateProcessingInstruction_Public_Virtual_New_XmlProcessingInstruction_String_String_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_CreateXmlDeclaration_Public_Virtual_New_XmlDeclaration_String_String_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_CreateTextNode_Public_Virtual_New_XmlText_String_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_CreateSignificantWhitespace_Public_Virtual_New_XmlSignificantWhitespace_String_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_CreateWhitespace_Public_Virtual_New_XmlWhitespace_String_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_ImportNodeInternal_Private_XmlNode_XmlNode_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_ImportAttributes_Private_Void_XmlNode_XmlNode_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_ImportChildren_Private_Void_XmlNode_XmlNode_Boolean_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_get_XmlNameTable_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_CreateAttribute_Public_Virtual_New_XmlAttribute_String_String_String_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_CreateDefaultAttribute_FamOrAssem_Virtual_New_XmlAttribute_String_String_String_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_CreateElement_Public_Virtual_New_XmlElement_String_String_String_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Internal_get_XmlNamedNodeMap_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_set_Entities_Internal_set_Void_XmlNamedNodeMap_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLoading_Internal_get_Boolean_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLoading_Internal_set_Void_Boolean_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_get_ActualLoadingStatus_Internal_get_Boolean_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_SetupReader_Private_XmlTextReader_XmlTextReader_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_XmlReader_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_LoadXml_Public_Virtual_New_Void_String_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerText_Public_Virtual_set_Void_String_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_set_InnerXml_Public_Virtual_set_Void_String_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_GetEventArgs_Internal_Virtual_XmlNodeChangedEventArgs_XmlNode_XmlNode_XmlNode_String_String_XmlNodeChangedAction_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_GetInsertEventArgsForLoad_Internal_XmlNodeChangedEventArgs_XmlNode_XmlNode_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_BeforeEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_AfterEvent_Internal_Virtual_Void_XmlNodeChangedEventArgs_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultAttribute_Internal_XmlAttribute_XmlElement_String_String_String_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_GetEntityNode_Internal_XmlEntity_String_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_SetBaseURI_Internal_Void_String_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_AppendChildForLoad_Internal_Virtual_XmlNode_XmlNode_XmlDocument_0;
	}
}
