using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;
using Il2CppSystem.Threading.Tasks;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000024 RID: 36
	public class XmlTextReaderImpl : XmlReader
	{
		// Token: 0x060001A3 RID: 419 RVA: 0x0000F250 File Offset: 0x0000D450
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTextReaderImpl()
		{
			Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlTextReaderImpl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr);
			XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "laterInitParam");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlCharType");
			XmlTextReaderImpl.NativeFieldInfoPtr_ps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ps");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextNextParsingFunction");
			XmlTextReaderImpl.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nodes");
			XmlTextReaderImpl.NativeFieldInfoPtr_curNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curNode");
			XmlTextReaderImpl.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "index");
			XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "curAttrIndex");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrHashtable");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplWalkCount");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrNeedNamespaceLookup");
			XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fullAttrCleanup");
			XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attrDuplSortingArray");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTable");
			XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nameTableFromSettings");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolver");
			XmlTextReaderImpl.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "url");
			XmlTextReaderImpl.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "normalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "supportNamespaces");
			XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "whitespaceHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdProcessing");
			XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "entityHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignorePIs");
			XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ignoreComments");
			XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "checkCharacters");
			XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lineNumberOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "linePositionOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_closeInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "closeInput");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "maxCharactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "v1Compat");
			XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "namespaceManager");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastPrefix");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStack");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingStatesStackTop");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedBaseUri");
			XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "reportedEncoding");
			XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "dtdInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentType");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragmentParserContext");
			XmlTextReaderImpl.NativeFieldInfoPtr_fragment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "fragment");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDecoder");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadState");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLineInfo");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadDepth");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftStartPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "incReadLeftEndPos");
			XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "attributeValueBaseEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "emptyEntityInAttributeResolved");
			XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validationEventHandling");
			XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "onDefaultAttributeUse");
			XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "validatingReaderCompatFlag");
			XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "addDefaultAttributesAndNormalize");
			XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "stringBuilder");
			XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "rootElementParsed");
			XmlTextReaderImpl.NativeFieldInfoPtr_standalone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "standalone");
			XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "nextEntityId");
			XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parsingMode");
			XmlTextReaderImpl.NativeFieldInfoPtr_readState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readState");
			XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "lastEntity");
			XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "afterResetState");
			XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "documentStartBytePos");
			XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "readValueOffset");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersInDocument");
			XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "charactersFromEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "currentEntities");
			XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "disableUndeclaredEntityCheck");
			XmlTextReaderImpl.NativeFieldInfoPtr_outerReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "outerReader");
			XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "xmlResolverIsSet");
			XmlTextReaderImpl.NativeFieldInfoPtr_Xml = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "Xml");
			XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlNs");
			XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "parseText_dummyTask");
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663524);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663525);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663526);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663527);
			XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663528);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663529);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663530);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663531);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663532);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663533);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663534);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663535);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663536);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663537);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663538);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663539);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663540);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663541);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663542);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663543);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663544);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663545);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663546);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663547);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663548);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663549);
			XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663550);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663551);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663552);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663553);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663554);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663555);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663556);
			XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663557);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663558);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663559);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663560);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663561);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663562);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663563);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663564);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663565);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663566);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663567);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663568);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663569);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663570);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663571);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663572);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663573);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663574);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663575);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663576);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663577);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663578);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663579);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663580);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663581);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663582);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663583);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663584);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663585);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663586);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663587);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663588);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663589);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663590);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663591);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663592);
			XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663593);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663594);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663595);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663596);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663597);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663598);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663599);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663600);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663601);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663602);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663603);
			XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663604);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663605);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663606);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663607);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663608);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663609);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663610);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663611);
			XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663612);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663613);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663614);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663615);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663616);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663617);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663618);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663619);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663620);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663621);
			XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663622);
			XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663623);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663624);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663625);
			XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663626);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663627);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663628);
			XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663629);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663630);
			XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663631);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663632);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663633);
			XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663634);
			XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663635);
			XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663636);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663637);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663638);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663639);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663640);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663641);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663642);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663643);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663644);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663645);
			XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663646);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663647);
			XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663648);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663649);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663650);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663651);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663652);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663653);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663654);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663655);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663656);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663657);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663658);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663659);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663660);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663661);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663662);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663663);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663664);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663665);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663666);
			XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663667);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663668);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663669);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663670);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663671);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663672);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663673);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663674);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663675);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663676);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663677);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663678);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663679);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663680);
			XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663681);
			XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663682);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663683);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663684);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663685);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663686);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663687);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663688);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663689);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663690);
			XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663691);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663692);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663693);
			XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663694);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663695);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663696);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663697);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663698);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663699);
			XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663700);
			XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663701);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663702);
			XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663703);
			XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663704);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663705);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663706);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663707);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663708);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663709);
			XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663710);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663711);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663712);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663713);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663714);
			XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663715);
			XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663716);
			XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663717);
			XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663718);
			XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663719);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663720);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663721);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663722);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663723);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663724);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663725);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663726);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663727);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663728);
			XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663729);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663730);
			XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663731);
			XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663732);
			XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663733);
			XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663734);
			XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663735);
			XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663736);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663737);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663738);
			XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663739);
			XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663740);
			XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663741);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663742);
			XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663743);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663744);
			XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, 100663745);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000109C8 File Offset: 0x0000EBC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 12543, RefRangeEnd = 12548, XrefRangeStart = 12496, XrefRangeEnd = 12543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00010A14 File Offset: 0x0000EC14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12548, XrefRangeEnd = 12558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00010A74 File Offset: 0x0000EC74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12558, XrefRangeEnd = 12566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00010AE4 File Offset: 0x0000ECE4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12577, RefRangeEnd = 12579, XrefRangeStart = 12566, XrefRangeEnd = 12577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fragType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00010B50 File Offset: 0x0000ED50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12595, RefRangeEnd = 12596, XrefRangeStart = 12579, XrefRangeEnd = 12595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00010BB0 File Offset: 0x0000EDB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12617, RefRangeEnd = 12618, XrefRangeStart = 12596, XrefRangeEnd = 12617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitUriString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitUriString_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00010BE4 File Offset: 0x0000EDE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12618, XrefRangeEnd = 12622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitStream()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitStream_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00010C18 File Offset: 0x0000EE18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12622, XrefRangeEnd = 12625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitTextReader()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public unsafe override XmlReaderSettings Settings
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12625, XrefRangeEnd = 12672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReaderSettings>(intPtr3) : null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00010C98 File Offset: 0x0000EE98
		public unsafe override XmlNodeType NodeType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00010CE0 File Offset: 0x0000EEE0
		public unsafe override string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12672, XrefRangeEnd = 12674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00010D24 File Offset: 0x0000EF24
		public unsafe override string LocalName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00010D68 File Offset: 0x0000EF68
		public unsafe override string NamespaceURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00010DAC File Offset: 0x0000EFAC
		public unsafe override string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public unsafe override string Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12674, XrefRangeEnd = 12689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x00010E34 File Offset: 0x0000F034
		public unsafe override string BaseURI
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00010E78 File Offset: 0x0000F078
		public unsafe override bool IsEmptyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12689, XrefRangeEnd = 12691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		public unsafe override bool IsDefault
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12691, XrefRangeEnd = 12693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00010F08 File Offset: 0x0000F108
		public unsafe override ReadState ReadState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00010F50 File Offset: 0x0000F150
		public unsafe override XmlNameTable NameTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00010F9C File Offset: 0x0000F19C
		public unsafe override bool CanResolveEntity
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12694, XrefRangeEnd = 12697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToAttribute(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001103C File Offset: 0x0000F23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12697, XrefRangeEnd = 12698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToFirstAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00011084 File Offset: 0x0000F284
		[CallerCount(0)]
		public unsafe override bool MoveToNextAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000110CC File Offset: 0x0000F2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12698, XrefRangeEnd = 12700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MoveToElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00011114 File Offset: 0x0000F314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12700, XrefRangeEnd = 12706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00011148 File Offset: 0x0000F348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12706, XrefRangeEnd = 12742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00011190 File Offset: 0x0000F390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12742, XrefRangeEnd = 12748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x000111CC File Offset: 0x0000F3CC
		[CallerCount(0)]
		public unsafe override string LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00011220 File Offset: 0x0000F420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12748, XrefRangeEnd = 12751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ReadAttributeValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00011268 File Offset: 0x0000F468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12751, XrefRangeEnd = 12761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ResolveEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000128 RID: 296
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x000112A4 File Offset: 0x0000F4A4
		public unsafe XmlReader OuterReader
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000112E8 File Offset: 0x0000F4E8
		[CallerCount(0)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupNamespace(string prefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00011330 File Offset: 0x0000F530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12761, XrefRangeEnd = 12762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string System_Xml_IXmlNamespaceResolver_LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00011378 File Offset: 0x0000F578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupPrefix(string namespaceName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000129 RID: 297
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x000113C0 File Offset: 0x0000F5C0
		public unsafe bool Namespaces
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12769, RefRangeEnd = 12771, XrefRangeStart = 12762, XrefRangeEnd = 12769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012A RID: 298
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00011400 File Offset: 0x0000F600
		public unsafe EntityHandling EntityHandling
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012B RID: 299
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x00011440 File Offset: 0x0000F640
		public unsafe XmlResolver XmlResolver
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12771, RefRangeEnd = 12773, XrefRangeStart = 12771, XrefRangeEnd = 12771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00011484 File Offset: 0x0000F684
		public unsafe XmlNameTable DtdParserProxy_NameTable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12693, RefRangeEnd = 12694, XrefRangeStart = 12693, XrefRangeEnd = 12694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060001CB RID: 459 RVA: 0x000114C4 File Offset: 0x0000F6C4
		public unsafe IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060001CC RID: 460 RVA: 0x00011504 File Offset: 0x0000F704
		public unsafe bool DtdParserProxy_DtdValidation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12773, RefRangeEnd = 12774, XrefRangeStart = 12773, XrefRangeEnd = 12773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060001CD RID: 461 RVA: 0x00011540 File Offset: 0x0000F740
		public unsafe bool DtdParserProxy_Normalization
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0001157C File Offset: 0x0000F77C
		public unsafe bool DtdParserProxy_Namespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000115B8 File Offset: 0x0000F7B8
		public unsafe bool DtdParserProxy_V1CompatibilityMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x000115F4 File Offset: 0x0000F7F4
		public unsafe Uri DtdParserProxy_BaseUri
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12778, RefRangeEnd = 12779, XrefRangeStart = 12774, XrefRangeEnd = 12778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00011634 File Offset: 0x0000F834
		public unsafe bool DtdParserProxy_IsEof
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12779, RefRangeEnd = 12780, XrefRangeStart = 12779, XrefRangeEnd = 12779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00011670 File Offset: 0x0000F870
		public unsafe Il2CppStructArray<char> DtdParserProxy_ParsingBuffer
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000116B0 File Offset: 0x0000F8B0
		public unsafe int DtdParserProxy_ParsingBufferLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12780, RefRangeEnd = 12781, XrefRangeStart = 12780, XrefRangeEnd = 12780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x000116EC File Offset: 0x0000F8EC
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x00011728 File Offset: 0x0000F928
		public unsafe int DtdParserProxy_CurrentPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12781, RefRangeEnd = 12782, XrefRangeStart = 12781, XrefRangeEnd = 12781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12782, RefRangeEnd = 12783, XrefRangeStart = 12782, XrefRangeEnd = 12782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00011768 File Offset: 0x0000F968
		public unsafe int DtdParserProxy_EntityStackLength
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12783, RefRangeEnd = 12784, XrefRangeStart = 12783, XrefRangeEnd = 12783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000117A4 File Offset: 0x0000F9A4
		public unsafe bool DtdParserProxy_IsEntityEolNormalized
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12784, RefRangeEnd = 12785, XrefRangeStart = 12784, XrefRangeEnd = 12784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000117E0 File Offset: 0x0000F9E0
		public unsafe IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00011820 File Offset: 0x0000FA20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12785, RefRangeEnd = 12786, XrefRangeStart = 12785, XrefRangeEnd = 12785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00011860 File Offset: 0x0000FA60
		public unsafe int DtdParserProxy_LineNo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12786, RefRangeEnd = 12787, XrefRangeStart = 12786, XrefRangeEnd = 12786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0001189C File Offset: 0x0000FA9C
		public unsafe int DtdParserProxy_LineStartPosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12787, RefRangeEnd = 12788, XrefRangeStart = 12787, XrefRangeEnd = 12787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000118D8 File Offset: 0x0000FAD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12789, RefRangeEnd = 12790, XrefRangeStart = 12788, XrefRangeEnd = 12789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00011914 File Offset: 0x0000FB14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12794, RefRangeEnd = 12795, XrefRangeStart = 12790, XrefRangeEnd = 12794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00011964 File Offset: 0x0000FB64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12796, RefRangeEnd = 12797, XrefRangeStart = 12795, XrefRangeEnd = 12796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000119C0 File Offset: 0x0000FBC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12799, RefRangeEnd = 12800, XrefRangeStart = 12797, XrefRangeEnd = 12799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParsePI(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00011A04 File Offset: 0x0000FC04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12811, RefRangeEnd = 12812, XrefRangeStart = 12800, XrefRangeEnd = 12811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_ParseComment(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00011A48 File Offset: 0x0000FC48
		public unsafe bool IsResolverNull
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00011A84 File Offset: 0x0000FC84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12812, XrefRangeEnd = 12816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlResolver GetTempResolver()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr3) : null;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00011AC4 File Offset: 0x0000FCC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12822, RefRangeEnd = 12823, XrefRangeStart = 12816, XrefRangeEnd = 12822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00011B20 File Offset: 0x0000FD20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12827, RefRangeEnd = 12828, XrefRangeStart = 12823, XrefRangeEnd = 12827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00011B8C File Offset: 0x0000FD8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12836, RefRangeEnd = 12837, XrefRangeStart = 12828, XrefRangeEnd = 12836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00011BEC File Offset: 0x0000FDEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12841, RefRangeEnd = 12842, XrefRangeStart = 12837, XrefRangeEnd = 12841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00011C40 File Offset: 0x0000FE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12843, RefRangeEnd = 12844, XrefRangeStart = 12842, XrefRangeEnd = 12843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00011C84 File Offset: 0x0000FE84
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12849, RefRangeEnd = 12850, XrefRangeStart = 12844, XrefRangeEnd = 12849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12855, RefRangeEnd = 12856, XrefRangeStart = 12850, XrefRangeEnd = 12855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00011D44 File Offset: 0x0000FF44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12859, RefRangeEnd = 12861, XrefRangeStart = 12856, XrefRangeEnd = 12859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00011DA8 File Offset: 0x0000FFA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12864, RefRangeEnd = 12865, XrefRangeStart = 12861, XrefRangeEnd = 12864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00011E0C File Offset: 0x0001000C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12872, RefRangeEnd = 12874, XrefRangeStart = 12865, XrefRangeEnd = 12872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int pos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00011E5C File Offset: 0x0001005C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 12879, RefRangeEnd = 12881, XrefRangeStart = 12874, XrefRangeEnd = 12879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00011EA0 File Offset: 0x000100A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12881, XrefRangeEnd = 12892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00011F00 File Offset: 0x00010100
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 12901, RefRangeEnd = 12905, XrefRangeStart = 12892, XrefRangeEnd = 12901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00011F54 File Offset: 0x00010154
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12905, XrefRangeEnd = 12912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00011FC4 File Offset: 0x000101C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 12921, RefRangeEnd = 12925, XrefRangeStart = 12912, XrefRangeEnd = 12921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00012018 File Offset: 0x00010218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12925, XrefRangeEnd = 12932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, string arg, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00012080 File Offset: 0x00010280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12941, RefRangeEnd = 12942, XrefRangeStart = 12932, XrefRangeEnd = 12941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000120E8 File Offset: 0x000102E8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 12954, RefRangeEnd = 12964, XrefRangeStart = 12942, XrefRangeEnd = 12954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(Exception e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Throw_Private_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0001212C File Offset: 0x0001032C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12964, XrefRangeEnd = 12973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReThrow(Exception e, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0001218C File Offset: 0x0001038C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12973, XrefRangeEnd = 12984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000121D0 File Offset: 0x000103D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12984, XrefRangeEnd = 12991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00012224 File Offset: 0x00010424
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12991, XrefRangeEnd = 12998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowWithoutLineInfo(string res, Il2CppStringArray args, Exception innerException)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(res);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0001228C File Offset: 0x0001048C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12998, XrefRangeEnd = 13002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(Il2CppStructArray<char> data, int length, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x000122EC File Offset: 0x000104EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13002, RefRangeEnd = 13003, XrefRangeStart = 13002, XrefRangeEnd = 13002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetErrorState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetErrorState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00012320 File Offset: 0x00010520
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13015, RefRangeEnd = 13018, XrefRangeStart = 13003, XrefRangeEnd = 13015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000123A0 File Offset: 0x000105A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13018, XrefRangeEnd = 13021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exception);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060001FD RID: 509 RVA: 0x000123F0 File Offset: 0x000105F0
		public unsafe bool InAttributeValueIterator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0001242C File Offset: 0x0001062C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13026, RefRangeEnd = 13029, XrefRangeStart = 13021, XrefRangeEnd = 13026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishAttributeValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00012460 File Offset: 0x00010660
		public unsafe bool DtdValidation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12773, RefRangeEnd = 12774, XrefRangeStart = 12773, XrefRangeEnd = 12774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0001249C File Offset: 0x0001069C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13029, XrefRangeEnd = 13030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00012504 File Offset: 0x00010704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13030, XrefRangeEnd = 13031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00012580 File Offset: 0x00010780
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13054, RefRangeEnd = 13062, XrefRangeStart = 13031, XrefRangeEnd = 13054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Il2CppStructArray<byte> bytes, int byteCount, Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bytes);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref byteCount;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(encoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0001261C File Offset: 0x0001081C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13062, XrefRangeEnd = 13063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00012670 File Offset: 0x00010870
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13068, RefRangeEnd = 13076, XrefRangeStart = 13063, XrefRangeEnd = 13068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000126D8 File Offset: 0x000108D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 13080, RefRangeEnd = 13085, XrefRangeStart = 13076, XrefRangeEnd = 13080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUriStr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(originalEncoding);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(str);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00012740 File Offset: 0x00010940
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13101, RefRangeEnd = 13103, XrefRangeStart = 13085, XrefRangeEnd = 13101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fragmentType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parserContext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowXmlDeclFragment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000127A0 File Offset: 0x000109A0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 13105, RefRangeEnd = 13110, XrefRangeStart = 13103, XrefRangeEnd = 13105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessDtdFromParserContext(XmlParserContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000127E4 File Offset: 0x000109E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13133, RefRangeEnd = 13134, XrefRangeStart = 13110, XrefRangeEnd = 13133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00012818 File Offset: 0x00010A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13134, XrefRangeEnd = 13146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenUrlDelegate(Object xmlResolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xmlResolver);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0001285C File Offset: 0x00010A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13158, RefRangeEnd = 13159, XrefRangeStart = 13146, XrefRangeEnd = 13158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding DetectEncoding()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001289C File Offset: 0x00010A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13168, RefRangeEnd = 13170, XrefRangeStart = 13159, XrefRangeEnd = 13168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEncoding(Encoding encoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(encoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x000128E0 File Offset: 0x00010AE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13175, RefRangeEnd = 13176, XrefRangeStart = 13170, XrefRangeEnd = 13175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncoding(Encoding newEncoding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newEncoding);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00012924 File Offset: 0x00010B24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13201, RefRangeEnd = 13202, XrefRangeStart = 13176, XrefRangeEnd = 13201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Encoding CheckEncoding(string newEncodingName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newEncodingName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00012974 File Offset: 0x00010B74
		[CallerCount(0)]
		public unsafe void UnDecodeChars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnDecodeChars_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000129A8 File Offset: 0x00010BA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13207, RefRangeEnd = 13209, XrefRangeStart = 13202, XrefRangeEnd = 13207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchEncodingToUTF8()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000129DC File Offset: 0x00010BDC
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 13232, RefRangeEnd = 13267, XrefRangeStart = 13209, XrefRangeEnd = 13232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00012A18 File Offset: 0x00010C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13269, RefRangeEnd = 13270, XrefRangeStart = 13267, XrefRangeEnd = 13269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetChars(int maxCharsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref maxCharsCount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00012A64 File Offset: 0x00010C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13273, RefRangeEnd = 13274, XrefRangeStart = 13270, XrefRangeEnd = 13273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvalidCharRecovery(ref int bytesCount, out int charsCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &bytesCount;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charsCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00012AB0 File Offset: 0x00010CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13274, XrefRangeEnd = 13280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool closeInput)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref closeInput;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00012AF0 File Offset: 0x00010CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13280, XrefRangeEnd = 13281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShiftBuffer(int sourcePos, int destPos, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref sourcePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00012B4C File Offset: 0x00010D4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13428, RefRangeEnd = 13431, XrefRangeStart = 13281, XrefRangeEnd = 13428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseXmlDeclaration(bool isTextDecl)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isTextDecl;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00012B98 File Offset: 0x00010D98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13445, RefRangeEnd = 13446, XrefRangeStart = 13431, XrefRangeEnd = 13445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDocumentContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00012BD4 File Offset: 0x00010DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13454, RefRangeEnd = 13455, XrefRangeStart = 13446, XrefRangeEnd = 13454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseElementContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00012C10 File Offset: 0x00010E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13455, XrefRangeEnd = 13496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnclosedElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00012C44 File Offset: 0x00010E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13496, XrefRangeEnd = 13517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00012C78 File Offset: 0x00010E78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13590, RefRangeEnd = 13592, XrefRangeStart = 13517, XrefRangeEnd = 13590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDefaultAttributesAndNormalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00012CAC File Offset: 0x00010EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13592, XrefRangeEnd = 13613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEndElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEndElement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00012CE0 File Offset: 0x00010EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13613, XrefRangeEnd = 13657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(startTag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00012D24 File Offset: 0x00010F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13657, XrefRangeEnd = 13697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00012D58 File Offset: 0x00010F58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13698, RefRangeEnd = 13699, XrefRangeStart = 13697, XrefRangeEnd = 13698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ElementNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00012D8C File Offset: 0x00010F8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13700, RefRangeEnd = 13702, XrefRangeStart = 13699, XrefRangeEnd = 13700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeNamespaceLookup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00012DC0 File Offset: 0x00010FC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13712, RefRangeEnd = 13713, XrefRangeStart = 13702, XrefRangeEnd = 13712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttributeDuplCheck()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00012DF4 File Offset: 0x00010FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13720, RefRangeEnd = 13722, XrefRangeStart = 13713, XrefRangeEnd = 13720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00012E38 File Offset: 0x00011038
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13725, RefRangeEnd = 13727, XrefRangeStart = 13722, XrefRangeEnd = 13725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00012E7C File Offset: 0x0001107C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13742, RefRangeEnd = 13744, XrefRangeStart = 13727, XrefRangeEnd = 13742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00012EC0 File Offset: 0x000110C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13828, RefRangeEnd = 13830, XrefRangeStart = 13744, XrefRangeEnd = 13828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quoteChar;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00012F20 File Offset: 0x00011120
		[CallerCount(0)]
		public unsafe void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chunk);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(lastChunk);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			lastChunk = ((intPtr4 == 0) ? null : new XmlTextReaderImpl.NodeData(intPtr4));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00012F9C File Offset: 0x0001119C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 13860, RefRangeEnd = 13862, XrefRangeStart = 13830, XrefRangeEnd = 13860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00012FD8 File Offset: 0x000111D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 13887, RefRangeEnd = 13895, XrefRangeStart = 13862, XrefRangeEnd = 13887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseText(out int startPos, out int endPos, ref int outOrChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &endPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outOrChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00013040 File Offset: 0x00011240
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 13903, RefRangeEnd = 13907, XrefRangeStart = 13895, XrefRangeEnd = 13903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPartialValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishPartialValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00013074 File Offset: 0x00011274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13907, XrefRangeEnd = 13911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishOtherValueIterator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000130A8 File Offset: 0x000112A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13912, RefRangeEnd = 13915, XrefRangeStart = 13911, XrefRangeEnd = 13912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPartialTextValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000130DC File Offset: 0x000112DC
		[CallerCount(0)]
		public unsafe void FinishReadValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00013110 File Offset: 0x00011310
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 13918, RefRangeEnd = 13922, XrefRangeStart = 13915, XrefRangeEnd = 13918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00013144 File Offset: 0x00011344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 13922, XrefRangeEnd = 13936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishReadElementContentAsBinary()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00013178 File Offset: 0x00011378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13945, RefRangeEnd = 13946, XrefRangeStart = 13936, XrefRangeEnd = 13945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseRootLevelWhitespace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000131B4 File Offset: 0x000113B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 13951, RefRangeEnd = 13952, XrefRangeStart = 13946, XrefRangeEnd = 13951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000131E8 File Offset: 0x000113E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 13961, RefRangeEnd = 13964, XrefRangeStart = 13952, XrefRangeEnd = 13961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isInAttributeValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expandType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charRefEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00013250 File Offset: 0x00011450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14014, RefRangeEnd = 14017, XrefRangeStart = 13964, XrefRangeEnd = 14014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isInAttributeValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pushFakeEntityIfNullResolver;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entityStartLinePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000232 RID: 562 RVA: 0x000132C8 File Offset: 0x000114C8
		public unsafe bool InEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00013304 File Offset: 0x00011504
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14020, RefRangeEnd = 14024, XrefRangeStart = 14017, XrefRangeEnd = 14020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool checkEntityNesting)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref checkEntityNesting;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00013350 File Offset: 0x00011550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14024, XrefRangeEnd = 14030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupEndEntityNodeInContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00013384 File Offset: 0x00011584
		[CallerCount(0)]
		public unsafe void SetupEndEntityNodeInAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000133B8 File Offset: 0x000115B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14030, XrefRangeEnd = 14031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000133F4 File Offset: 0x000115F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14054, RefRangeEnd = 14057, XrefRangeStart = 14031, XrefRangeEnd = 14054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(piInDtdStringBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00013444 File Offset: 0x00011644
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14072, RefRangeEnd = 14075, XrefRangeStart = 14057, XrefRangeEnd = 14072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParsePIValue(out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &outStartPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001349C File Offset: 0x0001169C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14075, XrefRangeEnd = 14076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseComment_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000134D8 File Offset: 0x000116D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14076, XrefRangeEnd = 14077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCData_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001350C File Offset: 0x0001170C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14078, RefRangeEnd = 14082, XrefRangeStart = 14077, XrefRangeEnd = 14078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCDataOrComment(XmlNodeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001354C File Offset: 0x0001174C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14088, RefRangeEnd = 14089, XrefRangeStart = 14082, XrefRangeEnd = 14088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outStartPos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &outEndPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x000135B4 File Offset: 0x000117B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14089, XrefRangeEnd = 14106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseDoctypeDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000135F0 File Offset: 0x000117F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14106, XrefRangeEnd = 14130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00013624 File Offset: 0x00011824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14165, RefRangeEnd = 14166, XrefRangeStart = 14130, XrefRangeEnd = 14165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00013658 File Offset: 0x00011858
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14175, RefRangeEnd = 14177, XrefRangeStart = 14166, XrefRangeEnd = 14175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipPublicOrSystemIdLiteral()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001368C File Offset: 0x0001188C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14193, RefRangeEnd = 14195, XrefRangeStart = 14177, XrefRangeEnd = 14193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipUntil(char stopChar, bool recognizeLiterals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref recognizeLiterals;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000136D8 File Offset: 0x000118D8
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 14205, RefRangeEnd = 14220, XrefRangeStart = 14195, XrefRangeEnd = 14205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EatWhitespaces(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00013728 File Offset: 0x00011928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14220, XrefRangeEnd = 14222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00013790 File Offset: 0x00011990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14222, XrefRangeEnd = 14226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000137FC File Offset: 0x000119FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14242, RefRangeEnd = 14246, XrefRangeStart = 14226, XrefRangeEnd = 14242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &charCount;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00013884 File Offset: 0x00011A84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14248, RefRangeEnd = 14250, XrefRangeStart = 14246, XrefRangeEnd = 14248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000138E0 File Offset: 0x00011AE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14252, RefRangeEnd = 14255, XrefRangeStart = 14250, XrefRangeEnd = 14252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref expand;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001394C File Offset: 0x00011B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14255, XrefRangeEnd = 14256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseName_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00013988 File Offset: 0x00011B88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14257, RefRangeEnd = 14258, XrefRangeStart = 14256, XrefRangeEnd = 14257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &colonPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000139D4 File Offset: 0x00011BD4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 14269, RefRangeEnd = 14278, XrefRangeStart = 14258, XrefRangeEnd = 14269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ParseQName(bool isQName, int startOffset, out int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00013A3C File Offset: 0x00011C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14278, XrefRangeEnd = 14279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName(ref int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00013A88 File Offset: 0x00011C88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14281, RefRangeEnd = 14285, XrefRangeStart = 14279, XrefRangeEnd = 14281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseEntityName_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x00013AC0 File Offset: 0x00011CC0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 14294, RefRangeEnd = 14302, XrefRangeStart = 14285, XrefRangeEnd = 14294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00013B1C File Offset: 0x00011D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14302, XrefRangeEnd = 14311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nodeDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00013B78 File Offset: 0x00011D78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14313, RefRangeEnd = 14316, XrefRangeStart = 14311, XrefRangeEnd = 14313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attrDepth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14323, RefRangeEnd = 14324, XrefRangeStart = 14316, XrefRangeEnd = 14323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref endNamePos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref colonPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00013C34 File Offset: 0x00011E34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14330, RefRangeEnd = 14332, XrefRangeStart = 14324, XrefRangeEnd = 14330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00013CA8 File Offset: 0x00011EA8
		[CallerCount(0)]
		public unsafe void PopElementContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopElementContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00013CDC File Offset: 0x00011EDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 12785, RefRangeEnd = 12786, XrefRangeStart = 12785, XrefRangeEnd = 12786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnNewLine(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00013D1C File Offset: 0x00011F1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14335, RefRangeEnd = 14336, XrefRangeStart = 14332, XrefRangeEnd = 14335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEof()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OnEof_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00013D50 File Offset: 0x00011F50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14337, RefRangeEnd = 14340, XrefRangeStart = 14336, XrefRangeEnd = 14337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00013D98 File Offset: 0x00011F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14354, RefRangeEnd = 14356, XrefRangeStart = 14340, XrefRangeEnd = 14354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00013E00 File Offset: 0x00012000
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14356, RefRangeEnd = 14361, XrefRangeStart = 14356, XrefRangeEnd = 14356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ResetAttributes_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00013E34 File Offset: 0x00012034
		[CallerCount(0)]
		public unsafe void FullAttributeCleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00013E68 File Offset: 0x00012068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14365, RefRangeEnd = 14367, XrefRangeStart = 14361, XrefRangeEnd = 14365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00013E9C File Offset: 0x0001209C
		[CallerCount(0)]
		public unsafe void PopXmlContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopXmlContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00013ED0 File Offset: 0x000120D0
		[CallerCount(0)]
		public unsafe XmlNodeType GetWhitespaceType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00013F0C File Offset: 0x0001210C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14367, RefRangeEnd = 14370, XrefRangeStart = 14367, XrefRangeEnd = 14367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNodeType GetTextNodeType(int orChars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref orChars;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00013F58 File Offset: 0x00012158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14383, RefRangeEnd = 14384, XrefRangeStart = 14370, XrefRangeEnd = 14383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseUri);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entityName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00013FD4 File Offset: 0x000121D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14407, RefRangeEnd = 14409, XrefRangeStart = 14384, XrefRangeEnd = 14407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool OpenAndPush(Uri uri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00014024 File Offset: 0x00012224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14418, RefRangeEnd = 14419, XrefRangeStart = 14409, XrefRangeEnd = 14418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PushExternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00014074 File Offset: 0x00012274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14441, RefRangeEnd = 14443, XrefRangeStart = 14419, XrefRangeEnd = 14441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushInternalEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000140B8 File Offset: 0x000122B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14447, RefRangeEnd = 14448, XrefRangeStart = 14443, XrefRangeEnd = 14447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000140EC File Offset: 0x000122EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14463, RefRangeEnd = 14465, XrefRangeStart = 14448, XrefRangeEnd = 14463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterEntity(IDtdEntityInfo entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00014130 File Offset: 0x00012330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14465, XrefRangeEnd = 14468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_UnregisterEntity_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00014164 File Offset: 0x00012364
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 14479, RefRangeEnd = 14484, XrefRangeStart = 14468, XrefRangeEnd = 14479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PushParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00014198 File Offset: 0x00012398
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14485, RefRangeEnd = 14489, XrefRangeStart = 14484, XrefRangeEnd = 14485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopParsingState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_PopParsingState_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000141CC File Offset: 0x000123CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14492, RefRangeEnd = 14493, XrefRangeStart = 14489, XrefRangeEnd = 14492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int IncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_IncrementalRead_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00014208 File Offset: 0x00012408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14493, XrefRangeEnd = 14498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishIncrementalRead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0001423C File Offset: 0x0001243C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14498, XrefRangeEnd = 14501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseFragmentAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00014278 File Offset: 0x00012478
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14523, RefRangeEnd = 14524, XrefRangeStart = 14501, XrefRangeEnd = 14523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ParseAttributeValueChunk()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000142B4 File Offset: 0x000124B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14524, XrefRangeEnd = 14525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseXmlDeclarationFragment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000142E8 File Offset: 0x000124E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14525, XrefRangeEnd = 14526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00014338 File Offset: 0x00012538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14526, XrefRangeEnd = 14527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001437C File Offset: 0x0001257C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14530, RefRangeEnd = 14531, XrefRangeStart = 14527, XrefRangeEnd = 14530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000143E0 File Offset: 0x000125E0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14560, RefRangeEnd = 14563, XrefRangeStart = 14531, XrefRangeEnd = 14560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(expectedToken1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(expectedToken2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00014434 File Offset: 0x00012634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14563, XrefRangeEnd = 14564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00014478 File Offset: 0x00012678
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 14566, RefRangeEnd = 14569, XrefRangeStart = 14564, XrefRangeEnd = 14566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000144B0 File Offset: 0x000126B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14569, XrefRangeEnd = 14576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowExpectingWhitespace(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000144F0 File Offset: 0x000126F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14576, XrefRangeEnd = 14577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfAttributeWithoutPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00014540 File Offset: 0x00012740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14577, XrefRangeEnd = 14579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetIndexOfAttributeWithPrefix(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00014590 File Offset: 0x00012790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14579, XrefRangeEnd = 14580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ZeroEndingStream(int pos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x000145DC File Offset: 0x000127DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 14593, RefRangeEnd = 14595, XrefRangeStart = 14580, XrefRangeEnd = 14593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDtdFromParserContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00014610 File Offset: 0x00012810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14595, XrefRangeEnd = 14596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref moveIfOnContentNode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001465C File Offset: 0x0001285C
		public unsafe override IDtdInfo DtdInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000146A8 File Offset: 0x000128A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14601, RefRangeEnd = 14602, XrefRangeStart = 14596, XrefRangeEnd = 14601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDtdInfo(IDtdInfo newDtdInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newDtdInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000141 RID: 321
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000146EC File Offset: 0x000128EC
		public unsafe bool XmlValidatingReaderCompatibilityMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14608, RefRangeEnd = 14609, XrefRangeStart = 14602, XrefRangeEnd = 14608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001472C File Offset: 0x0001292C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14649, RefRangeEnd = 14650, XrefRangeStart = 14609, XrefRangeEnd = 14649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nameSortedNodeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defAttrInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref definedInDtd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameSortedNodeData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001479C File Offset: 0x0001299C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14662, RefRangeEnd = 14663, XrefRangeStart = 14650, XrefRangeEnd = 14662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLineNo;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref valueLinePos;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isXmlAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
		}

		// Token: 0x17000142 RID: 322
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0001486C File Offset: 0x00012A6C
		public unsafe bool DisableUndeclaredEntityCheck
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000148AC File Offset: 0x00012AAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 14666, RefRangeEnd = 14670, XrefRangeStart = 14663, XrefRangeEnd = 14666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref characters;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inEntityReference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000148F8 File Offset: 0x00012AF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14685, RefRangeEnd = 14686, XrefRangeStart = 14670, XrefRangeEnd = 14685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00014934 File Offset: 0x00012B34
		[CallerCount(0)]
		public unsafe static void StripSpaces(Il2CppStructArray<char> value, int index, ref int len)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00014988 File Offset: 0x00012B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14686, XrefRangeEnd = 14687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopyChars(Il2CppStructArray<char> src, int srcOffset, Il2CppStructArray<char> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000149FC File Offset: 0x00012BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 14687, XrefRangeEnd = 14688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockCopy(Il2CppStructArray<byte> src, int srcOffset, Il2CppStructArray<byte> dst, int dstOffset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(src);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref srcOffset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dst);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dstOffset;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000028D2 File Offset: 0x00000AD2
		public XmlTextReaderImpl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00014A70 File Offset: 0x00012C70
		// (set) Token: 0x06000284 RID: 644 RVA: 0x000028DB File Offset: 0x00000ADB
		public unsafe XmlTextReaderImpl.LaterInitParam laterInitParam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.LaterInitParam>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_laterInitParam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00014AA0 File Offset: 0x00012CA0
		// (set) Token: 0x06000286 RID: 646 RVA: 0x000028FA File Offset: 0x00000AFA
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00014AD0 File Offset: 0x00012CD0
		// (set) Token: 0x06000288 RID: 648 RVA: 0x00002928 File Offset: 0x00000B28
		public XmlTextReaderImpl.ParsingState ps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps);
				return new XmlTextReaderImpl.ParsingState(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ps), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000289 RID: 649 RVA: 0x00014B00 File Offset: 0x00012D00
		// (set) Token: 0x0600028A RID: 650 RVA: 0x00002956 File Offset: 0x00000B56
		public unsafe XmlTextReaderImpl.ParsingFunction parsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingFunction)) = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00014B28 File Offset: 0x00012D28
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00002971 File Offset: 0x00000B71
		public unsafe XmlTextReaderImpl.ParsingFunction nextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextParsingFunction)) = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600028D RID: 653 RVA: 0x00014B50 File Offset: 0x00012D50
		// (set) Token: 0x0600028E RID: 654 RVA: 0x0000298C File Offset: 0x00000B8C
		public unsafe XmlTextReaderImpl.ParsingFunction nextNextParsingFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextNextParsingFunction)) = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00014B78 File Offset: 0x00012D78
		// (set) Token: 0x06000290 RID: 656 RVA: 0x000029A7 File Offset: 0x00000BA7
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> nodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00014BA8 File Offset: 0x00012DA8
		// (set) Token: 0x06000292 RID: 658 RVA: 0x000029C6 File Offset: 0x00000BC6
		public unsafe XmlTextReaderImpl.NodeData curNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00014BD8 File Offset: 0x00012DD8
		// (set) Token: 0x06000294 RID: 660 RVA: 0x000029E5 File Offset: 0x00000BE5
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00014C00 File Offset: 0x00012E00
		// (set) Token: 0x06000296 RID: 662 RVA: 0x00002A00 File Offset: 0x00000C00
		public unsafe int curAttrIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_curAttrIndex)) = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00014C28 File Offset: 0x00012E28
		// (set) Token: 0x06000298 RID: 664 RVA: 0x00002A1B File Offset: 0x00000C1B
		public unsafe int attrCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrCount)) = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000299 RID: 665 RVA: 0x00014C50 File Offset: 0x00012E50
		// (set) Token: 0x0600029A RID: 666 RVA: 0x00002A36 File Offset: 0x00000C36
		public unsafe int attrHashtable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrHashtable)) = value;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00014C78 File Offset: 0x00012E78
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00002A51 File Offset: 0x00000C51
		public unsafe int attrDuplWalkCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplWalkCount)) = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00014CA0 File Offset: 0x00012EA0
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00002A6C File Offset: 0x00000C6C
		public unsafe bool attrNeedNamespaceLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrNeedNamespaceLookup)) = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00014CC8 File Offset: 0x00012EC8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00002A87 File Offset: 0x00000C87
		public unsafe bool fullAttrCleanup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fullAttrCleanup)) = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00014CF0 File Offset: 0x00012EF0
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00002AA2 File Offset: 0x00000CA2
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.NodeData> attrDuplSortingArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.NodeData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attrDuplSortingArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00014D20 File Offset: 0x00012F20
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00002AC1 File Offset: 0x00000CC1
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00014D50 File Offset: 0x00012F50
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public unsafe bool nameTableFromSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nameTableFromSettings)) = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x00014D78 File Offset: 0x00012F78
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x00002AFB File Offset: 0x00000CFB
		public unsafe XmlResolver xmlResolver
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x00014DA8 File Offset: 0x00012FA8
		// (set) Token: 0x060002AA RID: 682 RVA: 0x00002B1A File Offset: 0x00000D1A
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00014DD0 File Offset: 0x00012FD0
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00002B39 File Offset: 0x00000D39
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00014DF8 File Offset: 0x00012FF8
		// (set) Token: 0x060002AE RID: 686 RVA: 0x00002B54 File Offset: 0x00000D54
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002AF RID: 687 RVA: 0x00014E20 File Offset: 0x00013020
		// (set) Token: 0x060002B0 RID: 688 RVA: 0x00002B6F File Offset: 0x00000D6F
		public unsafe WhitespaceHandling whitespaceHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_whitespaceHandling)) = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x00014E48 File Offset: 0x00013048
		// (set) Token: 0x060002B2 RID: 690 RVA: 0x00002B8A File Offset: 0x00000D8A
		public unsafe DtdProcessing dtdProcessing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdProcessing)) = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00014E70 File Offset: 0x00013070
		// (set) Token: 0x060002B4 RID: 692 RVA: 0x00002BA5 File Offset: 0x00000DA5
		public unsafe EntityHandling entityHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_entityHandling)) = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x00014E98 File Offset: 0x00013098
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public unsafe bool ignorePIs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignorePIs)) = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00014EC0 File Offset: 0x000130C0
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00002BDB File Offset: 0x00000DDB
		public unsafe bool ignoreComments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_ignoreComments)) = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x00014EE8 File Offset: 0x000130E8
		// (set) Token: 0x060002BA RID: 698 RVA: 0x00002BF6 File Offset: 0x00000DF6
		public unsafe bool checkCharacters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_checkCharacters)) = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00014F10 File Offset: 0x00013110
		// (set) Token: 0x060002BC RID: 700 RVA: 0x00002C11 File Offset: 0x00000E11
		public unsafe int lineNumberOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lineNumberOffset)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060002BD RID: 701 RVA: 0x00014F38 File Offset: 0x00013138
		// (set) Token: 0x060002BE RID: 702 RVA: 0x00002C2C File Offset: 0x00000E2C
		public unsafe int linePositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_linePositionOffset)) = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00014F60 File Offset: 0x00013160
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x00002C47 File Offset: 0x00000E47
		public unsafe bool closeInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_closeInput)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00014F88 File Offset: 0x00013188
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x00002C62 File Offset: 0x00000E62
		public unsafe long maxCharactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersInDocument)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00014FB0 File Offset: 0x000131B0
		// (set) Token: 0x060002C4 RID: 708 RVA: 0x00002C7D File Offset: 0x00000E7D
		public unsafe long maxCharactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_maxCharactersFromEntities)) = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060002C5 RID: 709 RVA: 0x00014FD8 File Offset: 0x000131D8
		// (set) Token: 0x060002C6 RID: 710 RVA: 0x00002C98 File Offset: 0x00000E98
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00015000 File Offset: 0x00013200
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00002CB3 File Offset: 0x00000EB3
		public unsafe XmlNamespaceManager namespaceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_namespaceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00015030 File Offset: 0x00013230
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00002CD2 File Offset: 0x00000ED2
		public unsafe string lastPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00015058 File Offset: 0x00013258
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public unsafe XmlTextReaderImpl.XmlContext xmlContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00015088 File Offset: 0x00013288
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00002D10 File Offset: 0x00000F10
		public unsafe Il2CppReferenceArray<XmlTextReaderImpl.ParsingState> parsingStatesStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<XmlTextReaderImpl.ParsingState>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000150B8 File Offset: 0x000132B8
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x00002D2F File Offset: 0x00000F2F
		public unsafe int parsingStatesStackTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingStatesStackTop)) = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000150E0 File Offset: 0x000132E0
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00002D4A File Offset: 0x00000F4A
		public unsafe string reportedBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00015108 File Offset: 0x00013308
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00002D69 File Offset: 0x00000F69
		public unsafe Encoding reportedEncoding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_reportedEncoding), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00015138 File Offset: 0x00013338
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x00002D88 File Offset: 0x00000F88
		public unsafe IDtdInfo dtdInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_dtdInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00015168 File Offset: 0x00013368
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x00002DA7 File Offset: 0x00000FA7
		public unsafe XmlNodeType fragmentType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentType)) = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00015190 File Offset: 0x00013390
		// (set) Token: 0x060002DA RID: 730 RVA: 0x00002DC2 File Offset: 0x00000FC2
		public unsafe XmlParserContext fragmentParserContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragmentParserContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000151C0 File Offset: 0x000133C0
		// (set) Token: 0x060002DC RID: 732 RVA: 0x00002DE1 File Offset: 0x00000FE1
		public unsafe bool fragment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_fragment)) = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000151E8 File Offset: 0x000133E8
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00002DFC File Offset: 0x00000FFC
		public unsafe IncrementalReadDecoder incReadDecoder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncrementalReadDecoder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDecoder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00015218 File Offset: 0x00013418
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x00002E1B File Offset: 0x0000101B
		public unsafe XmlTextReaderImpl.IncrementalReadState incReadState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadState)) = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x00015240 File Offset: 0x00013440
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x00002E36 File Offset: 0x00001036
		public unsafe LineInfo incReadLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLineInfo)) = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00015268 File Offset: 0x00013468
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x00002E51 File Offset: 0x00001051
		public unsafe int incReadDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadDepth)) = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00015290 File Offset: 0x00013490
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002E6C File Offset: 0x0000106C
		public unsafe int incReadLeftStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftStartPos)) = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000152B8 File Offset: 0x000134B8
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002E87 File Offset: 0x00001087
		public unsafe int incReadLeftEndPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_incReadLeftEndPos)) = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x000152E0 File Offset: 0x000134E0
		// (set) Token: 0x060002EA RID: 746 RVA: 0x00002EA2 File Offset: 0x000010A2
		public unsafe int attributeValueBaseEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_attributeValueBaseEntityId)) = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00015308 File Offset: 0x00013508
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002EBD File Offset: 0x000010BD
		public unsafe bool emptyEntityInAttributeResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_emptyEntityInAttributeResolved)) = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00015330 File Offset: 0x00013530
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00002ED8 File Offset: 0x000010D8
		public unsafe IValidationEventHandling validationEventHandling
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validationEventHandling), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00015360 File Offset: 0x00013560
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002EF7 File Offset: 0x000010F7
		public unsafe XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_onDefaultAttributeUse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00015390 File Offset: 0x00013590
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002F16 File Offset: 0x00001116
		public unsafe bool validatingReaderCompatFlag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_validatingReaderCompatFlag)) = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x000153B8 File Offset: 0x000135B8
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00002F31 File Offset: 0x00001131
		public unsafe bool addDefaultAttributesAndNormalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_addDefaultAttributesAndNormalize)) = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x000153E0 File Offset: 0x000135E0
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00002F4C File Offset: 0x0000114C
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00015410 File Offset: 0x00013610
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00002F6B File Offset: 0x0000116B
		public unsafe bool rootElementParsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_rootElementParsed)) = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00015438 File Offset: 0x00013638
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00002F86 File Offset: 0x00001186
		public unsafe bool standalone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_standalone)) = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00015460 File Offset: 0x00013660
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00002FA1 File Offset: 0x000011A1
		public unsafe int nextEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_nextEntityId)) = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00015488 File Offset: 0x00013688
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00002FBC File Offset: 0x000011BC
		public unsafe XmlTextReaderImpl.ParsingMode parsingMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parsingMode)) = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000154B0 File Offset: 0x000136B0
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00002FD7 File Offset: 0x000011D7
		public unsafe ReadState readState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readState)) = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000301 RID: 769 RVA: 0x000154D8 File Offset: 0x000136D8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00002FF2 File Offset: 0x000011F2
		public unsafe IDtdEntityInfo lastEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_lastEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00015508 File Offset: 0x00013708
		// (set) Token: 0x06000304 RID: 772 RVA: 0x00003011 File Offset: 0x00001211
		public unsafe bool afterResetState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_afterResetState)) = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00015530 File Offset: 0x00013730
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0000302C File Offset: 0x0000122C
		public unsafe int documentStartBytePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_documentStartBytePos)) = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00015558 File Offset: 0x00013758
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00003047 File Offset: 0x00001247
		public unsafe int readValueOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_readValueOffset)) = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00015580 File Offset: 0x00013780
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00003062 File Offset: 0x00001262
		public unsafe long charactersInDocument
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersInDocument)) = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600030B RID: 779 RVA: 0x000155A8 File Offset: 0x000137A8
		// (set) Token: 0x0600030C RID: 780 RVA: 0x0000307D File Offset: 0x0000127D
		public unsafe long charactersFromEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_charactersFromEntities)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000155D0 File Offset: 0x000137D0
		// (set) Token: 0x0600030E RID: 782 RVA: 0x00003098 File Offset: 0x00001298
		public unsafe Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IDtdEntityInfo, IDtdEntityInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_currentEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600030F RID: 783 RVA: 0x00015600 File Offset: 0x00013800
		// (set) Token: 0x06000310 RID: 784 RVA: 0x000030B7 File Offset: 0x000012B7
		public unsafe bool disableUndeclaredEntityCheck
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_disableUndeclaredEntityCheck)) = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00015628 File Offset: 0x00013828
		// (set) Token: 0x06000312 RID: 786 RVA: 0x000030D2 File Offset: 0x000012D2
		public unsafe XmlReader outerReader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_outerReader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00015658 File Offset: 0x00013858
		// (set) Token: 0x06000314 RID: 788 RVA: 0x000030F1 File Offset: 0x000012F1
		public unsafe bool xmlResolverIsSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_xmlResolverIsSet)) = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00015680 File Offset: 0x00013880
		// (set) Token: 0x06000316 RID: 790 RVA: 0x0000310C File Offset: 0x0000130C
		public unsafe string Xml
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_Xml), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000317 RID: 791 RVA: 0x000156A8 File Offset: 0x000138A8
		// (set) Token: 0x06000318 RID: 792 RVA: 0x0000312B File Offset: 0x0000132B
		public unsafe string XmlNs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_XmlNs), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000319 RID: 793 RVA: 0x000156D0 File Offset: 0x000138D0
		// (set) Token: 0x0600031A RID: 794 RVA: 0x0000314A File Offset: 0x0000134A
		public unsafe Task<Tuple<int, int, int, bool>> parseText_dummyTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<Tuple<int, int, int, bool>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NativeFieldInfoPtr_parseText_dummyTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_laterInitParam;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_ps;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeFieldInfoPtr_parsingFunction;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeFieldInfoPtr_nextParsingFunction;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_nextNextParsingFunction;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_nodes;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_curNode;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_curAttrIndex;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeFieldInfoPtr_attrCount;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeFieldInfoPtr_attrHashtable;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplWalkCount;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeFieldInfoPtr_attrNeedNamespaceLookup;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeFieldInfoPtr_fullAttrCleanup;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeFieldInfoPtr_attrDuplSortingArray;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeFieldInfoPtr_nameTableFromSettings;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolver;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceHandling;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeFieldInfoPtr_dtdProcessing;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeFieldInfoPtr_entityHandling;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeFieldInfoPtr_ignorePIs;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeFieldInfoPtr_ignoreComments;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeFieldInfoPtr_checkCharacters;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeFieldInfoPtr_lineNumberOffset;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeFieldInfoPtr_linePositionOffset;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_closeInput;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersInDocument;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_maxCharactersFromEntities;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeFieldInfoPtr_namespaceManager;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeFieldInfoPtr_lastPrefix;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeFieldInfoPtr_xmlContext;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStack;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeFieldInfoPtr_parsingStatesStackTop;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_reportedBaseUri;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_reportedEncoding;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeFieldInfoPtr_dtdInfo;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeFieldInfoPtr_fragmentType;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeFieldInfoPtr_fragmentParserContext;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeFieldInfoPtr_fragment;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeFieldInfoPtr_incReadDecoder;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeFieldInfoPtr_incReadState;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeFieldInfoPtr_incReadLineInfo;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeFieldInfoPtr_incReadDepth;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftStartPos;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeFieldInfoPtr_incReadLeftEndPos;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeFieldInfoPtr_attributeValueBaseEntityId;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeFieldInfoPtr_emptyEntityInAttributeResolved;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeFieldInfoPtr_validationEventHandling;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeFieldInfoPtr_onDefaultAttributeUse;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeFieldInfoPtr_validatingReaderCompatFlag;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_addDefaultAttributesAndNormalize;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeFieldInfoPtr_rootElementParsed;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeFieldInfoPtr_standalone;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeFieldInfoPtr_nextEntityId;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeFieldInfoPtr_parsingMode;

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_readState;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_lastEntity;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_afterResetState;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_documentStartBytePos;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_readValueOffset;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_charactersInDocument;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_charactersFromEntities;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_currentEntities;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_disableUndeclaredEntityCheck;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_outerReader;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_xmlResolverIsSet;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_Xml;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_XmlNs;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_parseText_dummyTask;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlNameTable_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_TextReader_XmlNameTable_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_TextReader_XmlNameTable_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlNodeType_XmlParserContext_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_XmlParserContext_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitUriString_Private_Void_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitStream_Private_Void_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitTextReader_Private_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_get_Settings_Public_Virtual_get_XmlReaderSettings_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_Virtual_get_XmlNodeType_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_Virtual_get_String_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_get_NamespaceURI_Public_Virtual_get_String_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_Virtual_get_String_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_get_String_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Public_Virtual_get_String_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Public_Virtual_get_Boolean_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDefault_Public_Virtual_get_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadState_Public_Virtual_get_ReadState_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_get_NameTable_Public_Virtual_get_XmlNameTable_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_get_CanResolveEntity_Public_Virtual_get_Boolean_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_MoveToAttribute_Public_Virtual_Boolean_String_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_MoveToFirstAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextAttribute_Public_Virtual_Boolean_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_MoveToElement_Public_Virtual_Boolean_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_FinishInit_Private_Void_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Boolean_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttributeValue_Public_Virtual_Boolean_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_ResolveEntity_Public_Virtual_Void_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_set_OuterReader_Internal_set_Void_XmlReader_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupNamespace_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IXmlNamespaceResolver_LookupPrefix_Private_Virtual_Final_New_String_String_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Internal_String_String_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespaces_Internal_set_Void_Boolean_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityHandling_Internal_set_Void_EntityHandling_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlResolver_Internal_set_Void_XmlResolver_0;

		// Token: 0x040001B6 RID: 438
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NameTable_Internal_get_XmlNameTable_0;

		// Token: 0x040001B7 RID: 439
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_NamespaceResolver_Internal_get_IXmlNamespaceResolver_0;

		// Token: 0x040001B8 RID: 440
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_DtdValidation_Internal_get_Boolean_0;

		// Token: 0x040001B9 RID: 441
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Normalization_Internal_get_Boolean_0;

		// Token: 0x040001BA RID: 442
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_Namespaces_Internal_get_Boolean_0;

		// Token: 0x040001BB RID: 443
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_V1CompatibilityMode_Internal_get_Boolean_0;

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_BaseUri_Internal_get_Uri_0;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEof_Internal_get_Boolean_0;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBuffer_Internal_get_Il2CppStructArray_1_Char_0;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ParsingBufferLength_Internal_get_Int32_0;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_CurrentPosition_Internal_get_Int32_0;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_set_DtdParserProxy_CurrentPosition_Internal_set_Void_Int32_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_EntityStackLength_Internal_get_Int32_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_IsEntityEolNormalized_Internal_get_Boolean_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_ValidationEventHandling_Internal_get_IValidationEventHandling_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnNewLine_Internal_Void_Int32_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineNo_Internal_get_Int32_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdParserProxy_LineStartPosition_Internal_get_Int32_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ReadData_Internal_Int32_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNumericCharRef_Internal_Int32_StringBuilder_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseNamedCharRef_Internal_Int32_Boolean_StringBuilder_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParsePI_Internal_Void_StringBuilder_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_ParseComment_Internal_Void_StringBuilder_0;

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeMethodInfoPtr_get_IsResolverNull_Private_get_Boolean_0;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeMethodInfoPtr_GetTempResolver_Private_XmlResolver_0;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushEntity_Internal_Boolean_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PopEntity_Internal_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushExternalSubset_Internal_Boolean_String_String_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_PushInternalDtd_Internal_Void_String_String_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_Throw_Internal_Void_Exception_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnSystemId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_DtdParserProxy_OnPublicId_Internal_Void_String_LineInfo_LineInfo_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Int32_Int32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_0;

		// Token: 0x040001DC RID: 476
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x040001DD RID: 477
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x040001DE RID: 478
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Exception_0;

		// Token: 0x040001DF RID: 479
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x040001E0 RID: 480
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Exception_0;

		// Token: 0x040001E1 RID: 481
		private static readonly IntPtr NativeMethodInfoPtr_ReThrow_Private_Void_Exception_Int32_Int32_0;

		// Token: 0x040001E2 RID: 482
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_0;

		// Token: 0x040001E3 RID: 483
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_String_0;

		// Token: 0x040001E4 RID: 484
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWithoutLineInfo_Private_Void_String_Il2CppStringArray_Exception_0;

		// Token: 0x040001E5 RID: 485
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040001E6 RID: 486
		private static readonly IntPtr NativeMethodInfoPtr_SetErrorState_Private_Void_0;

		// Token: 0x040001E7 RID: 487
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_Int32_Int32_0;

		// Token: 0x040001E8 RID: 488
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x040001E9 RID: 489
		private static readonly IntPtr NativeMethodInfoPtr_get_InAttributeValueIterator_Private_get_Boolean_0;

		// Token: 0x040001EA RID: 490
		private static readonly IntPtr NativeMethodInfoPtr_FinishAttributeValueIterator_Private_Void_0;

		// Token: 0x040001EB RID: 491
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdValidation_Private_get_Boolean_0;

		// Token: 0x040001EC RID: 492
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_Stream_Encoding_0;

		// Token: 0x040001ED RID: 493
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Encoding_0;

		// Token: 0x040001EE RID: 494
		private static readonly IntPtr NativeMethodInfoPtr_InitStreamInput_Private_Void_Uri_String_Stream_Il2CppStructArray_1_Byte_Int32_Encoding_0;

		// Token: 0x040001EF RID: 495
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_TextReader_0;

		// Token: 0x040001F0 RID: 496
		private static readonly IntPtr NativeMethodInfoPtr_InitTextReaderInput_Private_Void_String_Uri_TextReader_0;

		// Token: 0x040001F1 RID: 497
		private static readonly IntPtr NativeMethodInfoPtr_InitStringInput_Private_Void_String_Encoding_String_0;

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_InitFragmentReader_Private_Void_XmlNodeType_XmlParserContext_Boolean_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_ProcessDtdFromParserContext_Private_Void_XmlParserContext_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrl_Private_Void_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_OpenUrlDelegate_Private_Void_Object_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_DetectEncoding_Private_Encoding_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_SetupEncoding_Private_Void_Encoding_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncoding_Private_Void_Encoding_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_CheckEncoding_Private_Encoding_String_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_UnDecodeChars_Private_Void_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr_SwitchEncodingToUTF8_Private_Void_0;

		// Token: 0x040001FC RID: 508
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x040001FD RID: 509
		private static readonly IntPtr NativeMethodInfoPtr_GetChars_Private_Int32_Int32_0;

		// Token: 0x040001FE RID: 510
		private static readonly IntPtr NativeMethodInfoPtr_InvalidCharRecovery_Private_Void_byref_Int32_byref_Int32_0;

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr_ShiftBuffer_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000201 RID: 513
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclaration_Private_Boolean_Boolean_0;

		// Token: 0x04000202 RID: 514
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentContent_Private_Boolean_0;

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementContent_Private_Boolean_0;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnclosedElements_Private_Void_0;

		// Token: 0x04000205 RID: 517
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Private_Void_0;

		// Token: 0x04000206 RID: 518
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributesAndNormalize_Private_Void_0;

		// Token: 0x04000207 RID: 519
		private static readonly IntPtr NativeMethodInfoPtr_ParseEndElement_Private_Void_0;

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_ThrowTagMismatch_Private_Void_NodeData_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributes_Private_Void_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr_ElementNamespaceLookup_Private_Void_0;

		// Token: 0x0400020B RID: 523
		private static readonly IntPtr NativeMethodInfoPtr_AttributeNamespaceLookup_Private_Void_0;

		// Token: 0x0400020C RID: 524
		private static readonly IntPtr NativeMethodInfoPtr_AttributeDuplCheck_Private_Void_0;

		// Token: 0x0400020D RID: 525
		private static readonly IntPtr NativeMethodInfoPtr_OnDefaultNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x0400020E RID: 526
		private static readonly IntPtr NativeMethodInfoPtr_OnNamespaceDecl_Private_Void_NodeData_0;

		// Token: 0x0400020F RID: 527
		private static readonly IntPtr NativeMethodInfoPtr_OnXmlReservedAttribute_Private_Void_NodeData_0;

		// Token: 0x04000210 RID: 528
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueSlow_Private_Void_Int32_Char_NodeData_0;

		// Token: 0x04000211 RID: 529
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeChunkToList_Private_Void_NodeData_NodeData_byref_NodeData_0;

		// Token: 0x04000212 RID: 530
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_0;

		// Token: 0x04000213 RID: 531
		private static readonly IntPtr NativeMethodInfoPtr_ParseText_Private_Boolean_byref_Int32_byref_Int32_byref_Int32_0;

		// Token: 0x04000214 RID: 532
		private static readonly IntPtr NativeMethodInfoPtr_FinishPartialValue_Private_Void_0;

		// Token: 0x04000215 RID: 533
		private static readonly IntPtr NativeMethodInfoPtr_FinishOtherValueIterator_Private_Void_0;

		// Token: 0x04000216 RID: 534
		private static readonly IntPtr NativeMethodInfoPtr_SkipPartialTextValue_Private_Void_0;

		// Token: 0x04000217 RID: 535
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadValueChunk_Private_Void_0;

		// Token: 0x04000218 RID: 536
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadContentAsBinary_Private_Void_0;

		// Token: 0x04000219 RID: 537
		private static readonly IntPtr NativeMethodInfoPtr_FinishReadElementContentAsBinary_Private_Void_0;

		// Token: 0x0400021A RID: 538
		private static readonly IntPtr NativeMethodInfoPtr_ParseRootLevelWhitespace_Private_Boolean_0;

		// Token: 0x0400021B RID: 539
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityReference_Private_Void_0;

		// Token: 0x0400021C RID: 540
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_EntityType_Boolean_EntityExpandType_byref_Int32_0;

		// Token: 0x0400021D RID: 541
		private static readonly IntPtr NativeMethodInfoPtr_HandleGeneralEntityReference_Private_EntityType_String_Boolean_Boolean_Int32_0;

		// Token: 0x0400021E RID: 542
		private static readonly IntPtr NativeMethodInfoPtr_get_InEntity_Private_get_Boolean_0;

		// Token: 0x0400021F RID: 543
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x04000220 RID: 544
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInContent_Private_Void_0;

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_SetupEndEntityNodeInAttribute_Private_Void_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Boolean_StringBuilder_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr_ParsePIValue_Private_Boolean_byref_Int32_byref_Int32_0;

		// Token: 0x04000225 RID: 549
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Boolean_0;

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_ParseCData_Private_Void_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Void_XmlNodeType_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_ParseCDataOrComment_Private_Boolean_XmlNodeType_byref_Int32_byref_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_ParseDoctypeDecl_Private_Boolean_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtd_Private_Void_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_SkipDtd_Private_Void_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_SkipPublicOrSystemIdLiteral_Private_Void_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_SkipUntil_Private_Void_Char_Boolean_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_EatWhitespaces_Private_Int32_StringBuilder_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_ParseCharRefInline_Private_Int32_Int32_byref_Int32_byref_EntityType_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRef_Private_Int32_Boolean_StringBuilder_byref_EntityType_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr_ParseNumericCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_byref_Int32_byref_EntityType_0;

		// Token: 0x04000232 RID: 562
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRef_Private_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000233 RID: 563
		private static readonly IntPtr NativeMethodInfoPtr_ParseNamedCharRefInline_Private_Int32_Int32_Boolean_StringBuilder_0;

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeMethodInfoPtr_ParseName_Private_Int32_0;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_byref_Int32_0;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr_ParseQName_Private_Int32_Boolean_Int32_byref_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_byref_Int32_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityName_Private_String_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr_AddNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_AllocNode_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_AddAttributeNoChecks_Private_NodeData_String_Int32_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_Int32_Int32_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_AddAttribute_Private_NodeData_String_String_String_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_PopElementContext_Private_Void_0;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr_OnNewLine_Private_Void_Int32_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_OnEof_Private_Void_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Private_String_NodeData_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Private_Void_String_String_NodeData_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_ResetAttributes_Private_Void_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_FullAttributeCleanup_Private_Void_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_PushXmlContext_Private_Void_0;

		// Token: 0x04000246 RID: 582
		private static readonly IntPtr NativeMethodInfoPtr_PopXmlContext_Private_Void_0;

		// Token: 0x04000247 RID: 583
		private static readonly IntPtr NativeMethodInfoPtr_GetWhitespaceType_Private_XmlNodeType_0;

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeMethodInfoPtr_GetTextNodeType_Private_XmlNodeType_Int32_0;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntityOrSubset_Private_Void_String_String_Uri_String_0;

		// Token: 0x0400024A RID: 586
		private static readonly IntPtr NativeMethodInfoPtr_OpenAndPush_Private_Boolean_Uri_0;

		// Token: 0x0400024B RID: 587
		private static readonly IntPtr NativeMethodInfoPtr_PushExternalEntity_Private_Boolean_IDtdEntityInfo_0;

		// Token: 0x0400024C RID: 588
		private static readonly IntPtr NativeMethodInfoPtr_PushInternalEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x0400024D RID: 589
		private static readonly IntPtr NativeMethodInfoPtr_PopEntity_Private_Void_0;

		// Token: 0x0400024E RID: 590
		private static readonly IntPtr NativeMethodInfoPtr_RegisterEntity_Private_Void_IDtdEntityInfo_0;

		// Token: 0x0400024F RID: 591
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterEntity_Private_Void_0;

		// Token: 0x04000250 RID: 592
		private static readonly IntPtr NativeMethodInfoPtr_PushParsingState_Private_Void_0;

		// Token: 0x04000251 RID: 593
		private static readonly IntPtr NativeMethodInfoPtr_PopParsingState_Private_Void_0;

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeMethodInfoPtr_IncrementalRead_Private_Int32_0;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeMethodInfoPtr_FinishIncrementalRead_Private_Void_0;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeMethodInfoPtr_ParseFragmentAttribute_Private_Boolean_0;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttributeValueChunk_Private_Boolean_0;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationFragment_Private_Void_0;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_0;

		// Token: 0x04000259 RID: 601
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x0400025A RID: 602
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_String_String_0;

		// Token: 0x0400025B RID: 603
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x0400025C RID: 604
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_0;

		// Token: 0x0400025D RID: 605
		private static readonly IntPtr NativeMethodInfoPtr_ThrowExpectingWhitespace_Private_Void_Int32_0;

		// Token: 0x0400025E RID: 606
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithoutPrefix_Private_Int32_String_0;

		// Token: 0x0400025F RID: 607
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexOfAttributeWithPrefix_Private_Int32_String_0;

		// Token: 0x04000260 RID: 608
		private static readonly IntPtr NativeMethodInfoPtr_ZeroEndingStream_Private_Boolean_Int32_0;

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeMethodInfoPtr_ParseDtdFromParserContext_Private_Void_0;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeMethodInfoPtr_MoveToNextContentNode_Private_Boolean_Boolean_0;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeMethodInfoPtr_get_DtdInfo_Internal_Virtual_get_IDtdInfo_0;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeMethodInfoPtr_SetDtdInfo_Internal_Void_IDtdInfo_0;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlValidatingReaderCompatibilityMode_Internal_set_Void_Boolean_0;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeDtd_Private_Boolean_IDtdDefaultAttributeInfo_Boolean_Il2CppReferenceArray_1_NodeData_0;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeMethodInfoPtr_AddDefaultAttributeInternal_Private_NodeData_String_String_String_String_Int32_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeMethodInfoPtr_set_DisableUndeclaredEntityCheck_Internal_set_Void_Boolean_0;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeMethodInfoPtr_RegisterConsumedCharacters_Private_Void_Int64_Boolean_0;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_byref_Int32_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopyChars_Internal_Static_Void_Il2CppStructArray_1_Char_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_BlockCopy_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x02000114 RID: 276
		public enum ParsingFunction
		{
			// Token: 0x04000D5E RID: 3422
			ElementContent,
			// Token: 0x04000D5F RID: 3423
			NoData,
			// Token: 0x04000D60 RID: 3424
			OpenUrl,
			// Token: 0x04000D61 RID: 3425
			SwitchToInteractive,
			// Token: 0x04000D62 RID: 3426
			SwitchToInteractiveXmlDecl,
			// Token: 0x04000D63 RID: 3427
			DocumentContent,
			// Token: 0x04000D64 RID: 3428
			MoveToElementContent,
			// Token: 0x04000D65 RID: 3429
			PopElementContext,
			// Token: 0x04000D66 RID: 3430
			PopEmptyElementContext,
			// Token: 0x04000D67 RID: 3431
			ResetAttributesRootLevel,
			// Token: 0x04000D68 RID: 3432
			Error,
			// Token: 0x04000D69 RID: 3433
			Eof,
			// Token: 0x04000D6A RID: 3434
			ReaderClosed,
			// Token: 0x04000D6B RID: 3435
			EntityReference,
			// Token: 0x04000D6C RID: 3436
			InIncrementalRead,
			// Token: 0x04000D6D RID: 3437
			FragmentAttribute,
			// Token: 0x04000D6E RID: 3438
			ReportEndEntity,
			// Token: 0x04000D6F RID: 3439
			AfterResolveEntityInContent,
			// Token: 0x04000D70 RID: 3440
			AfterResolveEmptyEntityInContent,
			// Token: 0x04000D71 RID: 3441
			XmlDeclarationFragment,
			// Token: 0x04000D72 RID: 3442
			GoToEof,
			// Token: 0x04000D73 RID: 3443
			PartialTextValue,
			// Token: 0x04000D74 RID: 3444
			InReadAttributeValue,
			// Token: 0x04000D75 RID: 3445
			InReadValueChunk,
			// Token: 0x04000D76 RID: 3446
			InReadContentAsBinary,
			// Token: 0x04000D77 RID: 3447
			InReadElementContentAsBinary
		}

		// Token: 0x02000115 RID: 277
		public enum ParsingMode
		{
			// Token: 0x04000D79 RID: 3449
			Full,
			// Token: 0x04000D7A RID: 3450
			SkipNode,
			// Token: 0x04000D7B RID: 3451
			SkipContent
		}

		// Token: 0x02000116 RID: 278
		public enum EntityType
		{
			// Token: 0x04000D7D RID: 3453
			CharacterDec,
			// Token: 0x04000D7E RID: 3454
			CharacterHex,
			// Token: 0x04000D7F RID: 3455
			CharacterNamed,
			// Token: 0x04000D80 RID: 3456
			Expanded,
			// Token: 0x04000D81 RID: 3457
			Skipped,
			// Token: 0x04000D82 RID: 3458
			FakeExpanded,
			// Token: 0x04000D83 RID: 3459
			Unexpanded,
			// Token: 0x04000D84 RID: 3460
			ExpandedInAttribute
		}

		// Token: 0x02000117 RID: 279
		public enum EntityExpandType
		{
			// Token: 0x04000D86 RID: 3462
			All,
			// Token: 0x04000D87 RID: 3463
			OnlyGeneral,
			// Token: 0x04000D88 RID: 3464
			OnlyCharacter
		}

		// Token: 0x02000118 RID: 280
		public enum IncrementalReadState
		{
			// Token: 0x04000D8A RID: 3466
			Text,
			// Token: 0x04000D8B RID: 3467
			StartTag,
			// Token: 0x04000D8C RID: 3468
			PI,
			// Token: 0x04000D8D RID: 3469
			CDATA,
			// Token: 0x04000D8E RID: 3470
			Comment,
			// Token: 0x04000D8F RID: 3471
			Attributes,
			// Token: 0x04000D90 RID: 3472
			AttributeValue,
			// Token: 0x04000D91 RID: 3473
			ReadData,
			// Token: 0x04000D92 RID: 3474
			EndElement,
			// Token: 0x04000D93 RID: 3475
			End,
			// Token: 0x04000D94 RID: 3476
			ReadValueChunk_OnCachedValue,
			// Token: 0x04000D95 RID: 3477
			ReadValueChunk_OnPartialValue,
			// Token: 0x04000D96 RID: 3478
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04000D97 RID: 3479
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x04000D98 RID: 3480
			ReadContentAsBinary_End
		}

		// Token: 0x02000119 RID: 281
		public class LaterInitParam : Object
		{
			// Token: 0x06001170 RID: 4464 RVA: 0x00051B8C File Offset: 0x0004FD8C
			// Note: this type is marked as 'beforefieldinit'.
			static LaterInitParam()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "LaterInitParam");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr);
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "useAsync");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputStream");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputBytes");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputByteCount");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputbaseUri");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriStr");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputUriResolver");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputContext");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "inputTextReader");
				XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.LaterInitParam>.NativeClassPtr, "initType");
			}

			// Token: 0x06001171 RID: 4465 RVA: 0x000079CB File Offset: 0x00005BCB
			public LaterInitParam(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x06001172 RID: 4466 RVA: 0x00051C80 File Offset: 0x0004FE80
			// (set) Token: 0x06001173 RID: 4467 RVA: 0x000079D4 File Offset: 0x00005BD4
			public unsafe bool useAsync
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_useAsync)) = value;
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x06001174 RID: 4468 RVA: 0x00051CA8 File Offset: 0x0004FEA8
			// (set) Token: 0x06001175 RID: 4469 RVA: 0x000079EF File Offset: 0x00005BEF
			public unsafe Stream inputStream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputStream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x06001176 RID: 4470 RVA: 0x00051CD8 File Offset: 0x0004FED8
			// (set) Token: 0x06001177 RID: 4471 RVA: 0x00007A0E File Offset: 0x00005C0E
			public unsafe Il2CppStructArray<byte> inputBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputBytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000614 RID: 1556
			// (get) Token: 0x06001178 RID: 4472 RVA: 0x00051D08 File Offset: 0x0004FF08
			// (set) Token: 0x06001179 RID: 4473 RVA: 0x00007A2D File Offset: 0x00005C2D
			public unsafe int inputByteCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputByteCount)) = value;
				}
			}

			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x0600117A RID: 4474 RVA: 0x00051D30 File Offset: 0x0004FF30
			// (set) Token: 0x0600117B RID: 4475 RVA: 0x00007A48 File Offset: 0x00005C48
			public unsafe Uri inputbaseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputbaseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x0600117C RID: 4476 RVA: 0x00051D60 File Offset: 0x0004FF60
			// (set) Token: 0x0600117D RID: 4477 RVA: 0x00007A67 File Offset: 0x00005C67
			public unsafe string inputUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x0600117E RID: 4478 RVA: 0x00051D88 File Offset: 0x0004FF88
			// (set) Token: 0x0600117F RID: 4479 RVA: 0x00007A86 File Offset: 0x00005C86
			public unsafe XmlResolver inputUriResolver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlResolver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputUriResolver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x06001180 RID: 4480 RVA: 0x00051DB8 File Offset: 0x0004FFB8
			// (set) Token: 0x06001181 RID: 4481 RVA: 0x00007AA5 File Offset: 0x00005CA5
			public unsafe XmlParserContext inputContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000619 RID: 1561
			// (get) Token: 0x06001182 RID: 4482 RVA: 0x00051DE8 File Offset: 0x0004FFE8
			// (set) Token: 0x06001183 RID: 4483 RVA: 0x00007AC4 File Offset: 0x00005CC4
			public unsafe TextReader inputTextReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_inputTextReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x06001184 RID: 4484 RVA: 0x00051E18 File Offset: 0x00050018
			// (set) Token: 0x06001185 RID: 4485 RVA: 0x00007AE3 File Offset: 0x00005CE3
			public unsafe XmlTextReaderImpl.InitInputType initType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.LaterInitParam.NativeFieldInfoPtr_initType)) = value;
				}
			}

			// Token: 0x04000D99 RID: 3481
			private static readonly IntPtr NativeFieldInfoPtr_useAsync;

			// Token: 0x04000D9A RID: 3482
			private static readonly IntPtr NativeFieldInfoPtr_inputStream;

			// Token: 0x04000D9B RID: 3483
			private static readonly IntPtr NativeFieldInfoPtr_inputBytes;

			// Token: 0x04000D9C RID: 3484
			private static readonly IntPtr NativeFieldInfoPtr_inputByteCount;

			// Token: 0x04000D9D RID: 3485
			private static readonly IntPtr NativeFieldInfoPtr_inputbaseUri;

			// Token: 0x04000D9E RID: 3486
			private static readonly IntPtr NativeFieldInfoPtr_inputUriStr;

			// Token: 0x04000D9F RID: 3487
			private static readonly IntPtr NativeFieldInfoPtr_inputUriResolver;

			// Token: 0x04000DA0 RID: 3488
			private static readonly IntPtr NativeFieldInfoPtr_inputContext;

			// Token: 0x04000DA1 RID: 3489
			private static readonly IntPtr NativeFieldInfoPtr_inputTextReader;

			// Token: 0x04000DA2 RID: 3490
			private static readonly IntPtr NativeFieldInfoPtr_initType;
		}

		// Token: 0x0200011A RID: 282
		public enum InitInputType
		{
			// Token: 0x04000DA4 RID: 3492
			UriString,
			// Token: 0x04000DA5 RID: 3493
			Stream,
			// Token: 0x04000DA6 RID: 3494
			TextReader,
			// Token: 0x04000DA7 RID: 3495
			Invalid
		}

		// Token: 0x0200011B RID: 283
		public sealed class ParsingState : ValueType
		{
			// Token: 0x06001186 RID: 4486 RVA: 0x00051E40 File Offset: 0x00050040
			// Note: this type is marked as 'beforefieldinit'.
			static ParsingState()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "ParsingState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr);
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "chars");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "charsUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "encoding");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "appendMode");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "stream");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "decoder");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytes");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytePos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "bytesUsed");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "textReader");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineNo");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "lineStartPos");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUriStr");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "baseUri");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "isStreamEof");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entity");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "eolNormalized");
				XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, "entityResolvedManually");
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100663746);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100663747);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100663748);
				XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr, 100663749);
			}

			// Token: 0x06001187 RID: 4487 RVA: 0x00052060 File Offset: 0x00050260
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12069, RefRangeEnd = 12070, XrefRangeStart = 12067, XrefRangeEnd = 12069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001188 RID: 4488 RVA: 0x00052098 File Offset: 0x00050298
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 12070, RefRangeEnd = 12073, XrefRangeStart = 12070, XrefRangeEnd = 12070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Close(bool closeInput)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref closeInput;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_Close_Internal_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001189 RID: 4489 RVA: 0x000520DC File Offset: 0x000502DC
			public unsafe int LineNo
			{
				[CallerCount(3)]
				[CachedScanResults(RefRangeStart = 11837, RefRangeEnd = 11840, XrefRangeStart = 11837, XrefRangeEnd = 11840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x0600118A RID: 4490 RVA: 0x00052120 File Offset: 0x00050320
			public unsafe int LinePos
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 12073, RefRangeEnd = 12097, XrefRangeStart = 12073, XrefRangeEnd = 12073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.ParsingState.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600118B RID: 4491 RVA: 0x00007AFE File Offset: 0x00005CFE
			public ParsingState(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600118C RID: 4492 RVA: 0x00007B07 File Offset: 0x00005D07
			public ParsingState()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.ParsingState>.NativeClassPtr))
			{
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x0600118D RID: 4493 RVA: 0x00052164 File Offset: 0x00050364
			// (set) Token: 0x0600118E RID: 4494 RVA: 0x00007B19 File Offset: 0x00005D19
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x0600118F RID: 4495 RVA: 0x00052194 File Offset: 0x00050394
			// (set) Token: 0x06001190 RID: 4496 RVA: 0x00007B38 File Offset: 0x00005D38
			public unsafe int charPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charPos)) = value;
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001191 RID: 4497 RVA: 0x000521BC File Offset: 0x000503BC
			// (set) Token: 0x06001192 RID: 4498 RVA: 0x00007B53 File Offset: 0x00005D53
			public unsafe int charsUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_charsUsed)) = value;
				}
			}

			// Token: 0x1700061E RID: 1566
			// (get) Token: 0x06001193 RID: 4499 RVA: 0x000521E4 File Offset: 0x000503E4
			// (set) Token: 0x06001194 RID: 4500 RVA: 0x00007B6E File Offset: 0x00005D6E
			public unsafe Encoding encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_encoding), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001195 RID: 4501 RVA: 0x00052214 File Offset: 0x00050414
			// (set) Token: 0x06001196 RID: 4502 RVA: 0x00007B8D File Offset: 0x00005D8D
			public unsafe bool appendMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_appendMode)) = value;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001197 RID: 4503 RVA: 0x0005223C File Offset: 0x0005043C
			// (set) Token: 0x06001198 RID: 4504 RVA: 0x00007BA8 File Offset: 0x00005DA8
			public unsafe Stream stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001199 RID: 4505 RVA: 0x0005226C File Offset: 0x0005046C
			// (set) Token: 0x0600119A RID: 4506 RVA: 0x00007BC7 File Offset: 0x00005DC7
			public unsafe Decoder decoder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Decoder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_decoder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x0600119B RID: 4507 RVA: 0x0005229C File Offset: 0x0005049C
			// (set) Token: 0x0600119C RID: 4508 RVA: 0x00007BE6 File Offset: 0x00005DE6
			public unsafe Il2CppStructArray<byte> bytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000623 RID: 1571
			// (get) Token: 0x0600119D RID: 4509 RVA: 0x000522CC File Offset: 0x000504CC
			// (set) Token: 0x0600119E RID: 4510 RVA: 0x00007C05 File Offset: 0x00005E05
			public unsafe int bytePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytePos)) = value;
				}
			}

			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x0600119F RID: 4511 RVA: 0x000522F4 File Offset: 0x000504F4
			// (set) Token: 0x060011A0 RID: 4512 RVA: 0x00007C20 File Offset: 0x00005E20
			public unsafe int bytesUsed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_bytesUsed)) = value;
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0005231C File Offset: 0x0005051C
			// (set) Token: 0x060011A2 RID: 4514 RVA: 0x00007C3B File Offset: 0x00005E3B
			public unsafe TextReader textReader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_textReader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0005234C File Offset: 0x0005054C
			// (set) Token: 0x060011A4 RID: 4516 RVA: 0x00007C5A File Offset: 0x00005E5A
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00052374 File Offset: 0x00050574
			// (set) Token: 0x060011A6 RID: 4518 RVA: 0x00007C75 File Offset: 0x00005E75
			public unsafe int lineStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_lineStartPos)) = value;
				}
			}

			// Token: 0x17000628 RID: 1576
			// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0005239C File Offset: 0x0005059C
			// (set) Token: 0x060011A8 RID: 4520 RVA: 0x00007C90 File Offset: 0x00005E90
			public unsafe string baseUriStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUriStr), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000523C4 File Offset: 0x000505C4
			// (set) Token: 0x060011AA RID: 4522 RVA: 0x00007CAF File Offset: 0x00005EAF
			public unsafe Uri baseUri
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_baseUri), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x060011AB RID: 4523 RVA: 0x000523F4 File Offset: 0x000505F4
			// (set) Token: 0x060011AC RID: 4524 RVA: 0x00007CCE File Offset: 0x00005ECE
			public unsafe bool isEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isEof)) = value;
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x060011AD RID: 4525 RVA: 0x0005241C File Offset: 0x0005061C
			// (set) Token: 0x060011AE RID: 4526 RVA: 0x00007CE9 File Offset: 0x00005EE9
			public unsafe bool isStreamEof
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_isStreamEof)) = value;
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x060011AF RID: 4527 RVA: 0x00052444 File Offset: 0x00050644
			// (set) Token: 0x060011B0 RID: 4528 RVA: 0x00007D04 File Offset: 0x00005F04
			public unsafe IDtdEntityInfo entity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700062D RID: 1581
			// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00052474 File Offset: 0x00050674
			// (set) Token: 0x060011B2 RID: 4530 RVA: 0x00007D23 File Offset: 0x00005F23
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0005249C File Offset: 0x0005069C
			// (set) Token: 0x060011B4 RID: 4532 RVA: 0x00007D3E File Offset: 0x00005F3E
			public unsafe bool eolNormalized
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_eolNormalized)) = value;
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x060011B5 RID: 4533 RVA: 0x000524C4 File Offset: 0x000506C4
			// (set) Token: 0x060011B6 RID: 4534 RVA: 0x00007D59 File Offset: 0x00005F59
			public unsafe bool entityResolvedManually
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.ParsingState.NativeFieldInfoPtr_entityResolvedManually)) = value;
				}
			}

			// Token: 0x04000DA8 RID: 3496
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04000DA9 RID: 3497
			private static readonly IntPtr NativeFieldInfoPtr_charPos;

			// Token: 0x04000DAA RID: 3498
			private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

			// Token: 0x04000DAB RID: 3499
			private static readonly IntPtr NativeFieldInfoPtr_encoding;

			// Token: 0x04000DAC RID: 3500
			private static readonly IntPtr NativeFieldInfoPtr_appendMode;

			// Token: 0x04000DAD RID: 3501
			private static readonly IntPtr NativeFieldInfoPtr_stream;

			// Token: 0x04000DAE RID: 3502
			private static readonly IntPtr NativeFieldInfoPtr_decoder;

			// Token: 0x04000DAF RID: 3503
			private static readonly IntPtr NativeFieldInfoPtr_bytes;

			// Token: 0x04000DB0 RID: 3504
			private static readonly IntPtr NativeFieldInfoPtr_bytePos;

			// Token: 0x04000DB1 RID: 3505
			private static readonly IntPtr NativeFieldInfoPtr_bytesUsed;

			// Token: 0x04000DB2 RID: 3506
			private static readonly IntPtr NativeFieldInfoPtr_textReader;

			// Token: 0x04000DB3 RID: 3507
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x04000DB4 RID: 3508
			private static readonly IntPtr NativeFieldInfoPtr_lineStartPos;

			// Token: 0x04000DB5 RID: 3509
			private static readonly IntPtr NativeFieldInfoPtr_baseUriStr;

			// Token: 0x04000DB6 RID: 3510
			private static readonly IntPtr NativeFieldInfoPtr_baseUri;

			// Token: 0x04000DB7 RID: 3511
			private static readonly IntPtr NativeFieldInfoPtr_isEof;

			// Token: 0x04000DB8 RID: 3512
			private static readonly IntPtr NativeFieldInfoPtr_isStreamEof;

			// Token: 0x04000DB9 RID: 3513
			private static readonly IntPtr NativeFieldInfoPtr_entity;

			// Token: 0x04000DBA RID: 3514
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x04000DBB RID: 3515
			private static readonly IntPtr NativeFieldInfoPtr_eolNormalized;

			// Token: 0x04000DBC RID: 3516
			private static readonly IntPtr NativeFieldInfoPtr_entityResolvedManually;

			// Token: 0x04000DBD RID: 3517
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x04000DBE RID: 3518
			private static readonly IntPtr NativeMethodInfoPtr_Close_Internal_Void_Boolean_0;

			// Token: 0x04000DBF RID: 3519
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x04000DC0 RID: 3520
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;
		}

		// Token: 0x0200011C RID: 284
		public class XmlContext : Object
		{
			// Token: 0x060011B7 RID: 4535 RVA: 0x000524EC File Offset: 0x000506EC
			// Note: this type is marked as 'beforefieldinit'.
			static XmlContext()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "XmlContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr);
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlSpace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "xmlLang");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "defaultNamespace");
				XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, "previousContext");
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100663750);
				XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr, 100663751);
			}

			// Token: 0x060011B8 RID: 4536 RVA: 0x00052590 File Offset: 0x00050790
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12101, RefRangeEnd = 12102, XrefRangeStart = 12097, XrefRangeEnd = 12101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlContext()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011B9 RID: 4537 RVA: 0x000525CC File Offset: 0x000507CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12103, RefRangeEnd = 12104, XrefRangeStart = 12102, XrefRangeEnd = 12103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe XmlContext(XmlTextReaderImpl.XmlContext previousContext)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.XmlContext>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousContext);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.XmlContext.NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011BA RID: 4538 RVA: 0x00007D74 File Offset: 0x00005F74
			public XmlContext(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000632 RID: 1586
			// (get) Token: 0x060011BB RID: 4539 RVA: 0x00052618 File Offset: 0x00050818
			// (set) Token: 0x060011BC RID: 4540 RVA: 0x00007D7D File Offset: 0x00005F7D
			public unsafe XmlSpace xmlSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlSpace)) = value;
				}
			}

			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x060011BD RID: 4541 RVA: 0x00052640 File Offset: 0x00050840
			// (set) Token: 0x060011BE RID: 4542 RVA: 0x00007D98 File Offset: 0x00005F98
			public unsafe string xmlLang
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_xmlLang), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x060011BF RID: 4543 RVA: 0x00052668 File Offset: 0x00050868
			// (set) Token: 0x060011C0 RID: 4544 RVA: 0x00007DB7 File Offset: 0x00005FB7
			public unsafe string defaultNamespace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_defaultNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00052690 File Offset: 0x00050890
			// (set) Token: 0x060011C2 RID: 4546 RVA: 0x00007DD6 File Offset: 0x00005FD6
			public unsafe XmlTextReaderImpl.XmlContext previousContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.XmlContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.XmlContext.NativeFieldInfoPtr_previousContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DC1 RID: 3521
			private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

			// Token: 0x04000DC2 RID: 3522
			private static readonly IntPtr NativeFieldInfoPtr_xmlLang;

			// Token: 0x04000DC3 RID: 3523
			private static readonly IntPtr NativeFieldInfoPtr_defaultNamespace;

			// Token: 0x04000DC4 RID: 3524
			private static readonly IntPtr NativeFieldInfoPtr_previousContext;

			// Token: 0x04000DC5 RID: 3525
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04000DC6 RID: 3526
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlContext_0;
		}

		// Token: 0x0200011D RID: 285
		public class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x060011C3 RID: 4547 RVA: 0x000526C0 File Offset: 0x000508C0
			// Note: this type is marked as 'beforefieldinit'.
			static NoNamespaceManager()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NoNamespaceManager");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663752);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663753);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663754);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663755);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663756);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663757);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663758);
				XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr, 100663759);
			}

			// Token: 0x060011C4 RID: 4548 RVA: 0x0005278C File Offset: 0x0005098C
			[CallerCount(114)]
			[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12104, XrefRangeEnd = 12105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NoNamespaceManager()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NoNamespaceManager>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x060011C5 RID: 4549 RVA: 0x000527C8 File Offset: 0x000509C8
			public unsafe override string DefaultNamespace
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12219, XrefRangeEnd = 12221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011C6 RID: 4550 RVA: 0x0005280C File Offset: 0x00050A0C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void PushScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011C7 RID: 4551 RVA: 0x00052848 File Offset: 0x00050A48
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 11757, RefRangeEnd = 11805, XrefRangeStart = 11757, XrefRangeEnd = 11805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool PopScope()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060011C8 RID: 4552 RVA: 0x00052890 File Offset: 0x00050A90
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void AddNamespace(string prefix, string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(uri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011C9 RID: 4553 RVA: 0x000528F0 File Offset: 0x00050AF0
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerator GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x060011CA RID: 4554 RVA: 0x0005293C File Offset: 0x00050B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12221, XrefRangeEnd = 12223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupNamespace(string prefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011CB RID: 4555 RVA: 0x00052990 File Offset: 0x00050B90
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string LookupPrefix(string uri)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(uri);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTextReaderImpl.NoNamespaceManager.NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011CC RID: 4556 RVA: 0x00007DF5 File Offset: 0x00005FF5
			public NoNamespaceManager(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000DC7 RID: 3527
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000DC8 RID: 3528
			private static readonly IntPtr NativeMethodInfoPtr_get_DefaultNamespace_Public_Virtual_get_String_0;

			// Token: 0x04000DC9 RID: 3529
			private static readonly IntPtr NativeMethodInfoPtr_PushScope_Public_Virtual_Void_0;

			// Token: 0x04000DCA RID: 3530
			private static readonly IntPtr NativeMethodInfoPtr_PopScope_Public_Virtual_Boolean_0;

			// Token: 0x04000DCB RID: 3531
			private static readonly IntPtr NativeMethodInfoPtr_AddNamespace_Public_Virtual_Void_String_String_0;

			// Token: 0x04000DCC RID: 3532
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_IEnumerator_0;

			// Token: 0x04000DCD RID: 3533
			private static readonly IntPtr NativeMethodInfoPtr_LookupNamespace_Public_Virtual_String_String_0;

			// Token: 0x04000DCE RID: 3534
			private static readonly IntPtr NativeMethodInfoPtr_LookupPrefix_Public_Virtual_String_String_0;
		}

		// Token: 0x0200011E RID: 286
		public class DtdParserProxy : Object
		{
			// Token: 0x060011CD RID: 4557 RVA: 0x000529E4 File Offset: 0x00050BE4
			// Note: this type is marked as 'beforefieldinit'.
			static DtdParserProxy()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdParserProxy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr);
				XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, "reader");
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663760);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663761);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663762);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663763);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663764);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663765);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663766);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663767);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663768);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663769);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663770);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663771);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663772);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663773);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663774);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663775);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663776);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663777);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663778);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663779);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663780);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663781);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663782);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663783);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663784);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663785);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663786);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663787);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663788);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663789);
				XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr, 100663790);
			}

			// Token: 0x060011CE RID: 4558 RVA: 0x00052C90 File Offset: 0x00050E90
			[CallerCount(50)]
			[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12223, XrefRangeEnd = 12224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdParserProxy(XmlTextReaderImpl reader)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdParserProxy>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(reader);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x060011CF RID: 4559 RVA: 0x00052CDC File Offset: 0x00050EDC
			public unsafe virtual XmlNameTable System.Xml.IDtdParserAdapter.NameTable
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr3) : null;
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00052D1C File Offset: 0x00050F1C
			public unsafe virtual IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IXmlNamespaceResolver>(intPtr3) : null;
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00052D5C File Offset: 0x00050F5C
			public unsafe virtual Uri System.Xml.IDtdParserAdapter.BaseUri
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12274, XrefRangeEnd = 12276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Uri>(intPtr3) : null;
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00052D9C File Offset: 0x00050F9C
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEof
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12276, XrefRangeEnd = 12278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700063C RID: 1596
			// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00052DD8 File Offset: 0x00050FD8
			public unsafe virtual Il2CppStructArray<char> System.Xml.IDtdParserAdapter.ParsingBuffer
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12278, XrefRangeEnd = 12280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
				}
			}

			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00052E18 File Offset: 0x00051018
			public unsafe virtual int System.Xml.IDtdParserAdapter.ParsingBufferLength
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12280, XrefRangeEnd = 12282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00052E54 File Offset: 0x00051054
			// (set) Token: 0x060011D6 RID: 4566 RVA: 0x00052E90 File Offset: 0x00051090
			public unsafe virtual int System.Xml.IDtdParserAdapter.CurrentPosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12282, XrefRangeEnd = 12284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12284, XrefRangeEnd = 12286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x060011D7 RID: 4567 RVA: 0x00052ED0 File Offset: 0x000510D0
			public unsafe virtual int System.Xml.IDtdParserAdapter.EntityStackLength
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12286, XrefRangeEnd = 12288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00052F0C File Offset: 0x0005110C
			public unsafe virtual bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12288, XrefRangeEnd = 12290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011D9 RID: 4569 RVA: 0x00052F48 File Offset: 0x00051148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12290, XrefRangeEnd = 12292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnNewLine(int pos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref pos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x17000641 RID: 1601
			// (get) Token: 0x060011DA RID: 4570 RVA: 0x00052F88 File Offset: 0x00051188
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineNo
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12292, XrefRangeEnd = 12294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000642 RID: 1602
			// (get) Token: 0x060011DB RID: 4571 RVA: 0x00052FC4 File Offset: 0x000511C4
			public unsafe virtual int System.Xml.IDtdParserAdapter.LineStartPosition
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12294, XrefRangeEnd = 12296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011DC RID: 4572 RVA: 0x00053000 File Offset: 0x00051200
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12296, XrefRangeEnd = 12298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ReadData()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060011DD RID: 4573 RVA: 0x0005303C File Offset: 0x0005123C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12298, XrefRangeEnd = 12300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011DE RID: 4574 RVA: 0x0005308C File Offset: 0x0005128C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12300, XrefRangeEnd = 12302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_Xml_IDtdParserAdapter_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref expand;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(internalSubsetBuilder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x000530E8 File Offset: 0x000512E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12302, XrefRangeEnd = 12304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParsePI(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011E0 RID: 4576 RVA: 0x0005312C File Offset: 0x0005132C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12304, XrefRangeEnd = 12306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_ParseComment(StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011E1 RID: 4577 RVA: 0x00053170 File Offset: 0x00051370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12306, XrefRangeEnd = 12308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushEntity(IDtdEntityInfo entity, out int entityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &entityId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060011E2 RID: 4578 RVA: 0x000531CC File Offset: 0x000513CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12308, XrefRangeEnd = 12310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &newEntityId;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				oldEntity = ((intPtr4 == 0) ? null : new IDtdEntityInfo(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x060011E3 RID: 4579 RVA: 0x00053238 File Offset: 0x00051438
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12310, XrefRangeEnd = 12312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual bool System_Xml_IDtdParserAdapter_PushExternalSubset(string systemId, string publicId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060011E4 RID: 4580 RVA: 0x00053298 File Offset: 0x00051498
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12312, XrefRangeEnd = 12314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_PushInternalDtd(string baseUri, string internalDtd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalDtd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011E5 RID: 4581 RVA: 0x000532EC File Offset: 0x000514EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12314, XrefRangeEnd = 12316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_Throw(Exception e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011E6 RID: 4582 RVA: 0x00053330 File Offset: 0x00051530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12316, XrefRangeEnd = 12318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(systemId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref systemLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011E7 RID: 4583 RVA: 0x00053390 File Offset: 0x00051590
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12318, XrefRangeEnd = 12320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual void System_Xml_IDtdParserAdapter_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(publicId);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref keywordLineInfo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref publicLiteralLineInfo;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000643 RID: 1603
			// (get) Token: 0x060011E8 RID: 4584 RVA: 0x000533F0 File Offset: 0x000515F0
			public unsafe virtual bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12320, XrefRangeEnd = 12322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000644 RID: 1604
			// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0005342C File Offset: 0x0005162C
			public unsafe virtual IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IValidationEventHandling>(intPtr3) : null;
				}
			}

			// Token: 0x17000645 RID: 1605
			// (get) Token: 0x060011EA RID: 4586 RVA: 0x0005346C File Offset: 0x0005166C
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Normalization
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000646 RID: 1606
			// (get) Token: 0x060011EB RID: 4587 RVA: 0x000534A8 File Offset: 0x000516A8
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.Namespaces
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000647 RID: 1607
			// (get) Token: 0x060011EC RID: 4588 RVA: 0x000534E4 File Offset: 0x000516E4
			public unsafe virtual bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdParserProxy.NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060011ED RID: 4589 RVA: 0x00007DFE File Offset: 0x00005FFE
			public DtdParserProxy(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x060011EE RID: 4590 RVA: 0x00053520 File Offset: 0x00051720
			// (set) Token: 0x060011EF RID: 4591 RVA: 0x00007E07 File Offset: 0x00006007
			public unsafe XmlTextReaderImpl reader
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.DtdParserProxy.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DCF RID: 3535
			private static readonly IntPtr NativeFieldInfoPtr_reader;

			// Token: 0x04000DD0 RID: 3536
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlTextReaderImpl_0;

			// Token: 0x04000DD1 RID: 3537
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NameTable_Private_Virtual_Final_New_get_XmlNameTable_0;

			// Token: 0x04000DD2 RID: 3538
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_NamespaceResolver_Private_Virtual_Final_New_get_IXmlNamespaceResolver_0;

			// Token: 0x04000DD3 RID: 3539
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_BaseUri_Private_Virtual_Final_New_get_Uri_0;

			// Token: 0x04000DD4 RID: 3540
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEof_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000DD5 RID: 3541
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBuffer_Private_Virtual_Final_New_get_Il2CppStructArray_1_Char_0;

			// Token: 0x04000DD6 RID: 3542
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_ParsingBufferLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000DD7 RID: 3543
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_CurrentPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000DD8 RID: 3544
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_set_CurrentPosition_Private_Virtual_Final_New_set_Void_Int32_0;

			// Token: 0x04000DD9 RID: 3545
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_EntityStackLength_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000DDA RID: 3546
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_IsEntityEolNormalized_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000DDB RID: 3547
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnNewLine_Private_Virtual_Final_New_Void_Int32_0;

			// Token: 0x04000DDC RID: 3548
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineNo_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000DDD RID: 3549
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_get_LineStartPosition_Private_Virtual_Final_New_get_Int32_0;

			// Token: 0x04000DDE RID: 3550
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ReadData_Private_Virtual_Final_New_Int32_0;

			// Token: 0x04000DDF RID: 3551
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNumericCharRef_Private_Virtual_Final_New_Int32_StringBuilder_0;

			// Token: 0x04000DE0 RID: 3552
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseNamedCharRef_Private_Virtual_Final_New_Int32_Boolean_StringBuilder_0;

			// Token: 0x04000DE1 RID: 3553
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParsePI_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x04000DE2 RID: 3554
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_ParseComment_Private_Virtual_Final_New_Void_StringBuilder_0;

			// Token: 0x04000DE3 RID: 3555
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushEntity_Private_Virtual_Final_New_Boolean_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x04000DE4 RID: 3556
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PopEntity_Private_Virtual_Final_New_Boolean_byref_IDtdEntityInfo_byref_Int32_0;

			// Token: 0x04000DE5 RID: 3557
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushExternalSubset_Private_Virtual_Final_New_Boolean_String_String_0;

			// Token: 0x04000DE6 RID: 3558
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_PushInternalDtd_Private_Virtual_Final_New_Void_String_String_0;

			// Token: 0x04000DE7 RID: 3559
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_Throw_Private_Virtual_Final_New_Void_Exception_0;

			// Token: 0x04000DE8 RID: 3560
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnSystemId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x04000DE9 RID: 3561
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapter_OnPublicId_Private_Virtual_Final_New_Void_String_LineInfo_LineInfo_0;

			// Token: 0x04000DEA RID: 3562
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_DtdValidation_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000DEB RID: 3563
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterWithValidation_get_ValidationEventHandling_Private_Virtual_Final_New_get_IValidationEventHandling_0;

			// Token: 0x04000DEC RID: 3564
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Normalization_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000DED RID: 3565
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_Namespaces_Private_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04000DEE RID: 3566
			private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParserAdapterV1_get_V1CompatibilityMode_Private_Virtual_Final_New_get_Boolean_0;
		}

		// Token: 0x0200011F RID: 287
		public class NodeData : Object
		{
			// Token: 0x060011F0 RID: 4592 RVA: 0x00053550 File Offset: 0x00051750
			// Note: this type is marked as 'beforefieldinit'.
			static NodeData()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "NodeData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr);
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "s_None");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "type");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "localName");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "prefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "ns");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nameWPrefix");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "value");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "chars");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueStartPos");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "valueLength");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "lineInfo2");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "quoteChar");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "depth");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "isEmptyOrDefault");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "entityId");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "xmlContextPushed");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "nextAttrValueChunk");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "schemaType");
				XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, "typedValue");
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663791);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663792);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663793);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663794);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663795);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663796);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663797);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663798);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663799);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663800);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663801);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663802);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663803);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663804);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663805);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663806);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663807);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663808);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663809);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663810);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663811);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663812);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663813);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663814);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663815);
				XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr, 100663816);
			}

			// Token: 0x1700065C RID: 1628
			// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00053914 File Offset: 0x00051B14
			public unsafe static XmlTextReaderImpl.NodeData None
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 12336, RefRangeEnd = 12338, XrefRangeStart = 12322, XrefRangeEnd = 12336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr3) : null;
				}
			}

			// Token: 0x060011F2 RID: 4594 RVA: 0x00053948 File Offset: 0x00051B48
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 12343, RefRangeEnd = 12351, XrefRangeStart = 12338, XrefRangeEnd = 12343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NodeData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.NodeData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700065D RID: 1629
			// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00053984 File Offset: 0x00051B84
			public unsafe int LineNo
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 11932, RefRangeEnd = 11934, XrefRangeStart = 11932, XrefRangeEnd = 11934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700065E RID: 1630
			// (get) Token: 0x060011F4 RID: 4596 RVA: 0x000539C0 File Offset: 0x00051BC0
			public unsafe int LinePos
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 12351, RefRangeEnd = 12355, XrefRangeStart = 12351, XrefRangeEnd = 12351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700065F RID: 1631
			// (get) Token: 0x060011F5 RID: 4597 RVA: 0x000539FC File Offset: 0x00051BFC
			// (set) Token: 0x060011F6 RID: 4598 RVA: 0x00053A38 File Offset: 0x00051C38
			public unsafe bool IsEmptyElement
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 12355, RefRangeEnd = 12356, XrefRangeStart = 12355, XrefRangeEnd = 12355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000660 RID: 1632
			// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00053A78 File Offset: 0x00051C78
			// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00053AB4 File Offset: 0x00051CB4
			public unsafe bool IsDefaultAttribute
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 12356, RefRangeEnd = 12357, XrefRangeStart = 12356, XrefRangeEnd = 12356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x17000661 RID: 1633
			// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00053AF4 File Offset: 0x00051CF4
			public unsafe bool ValueBuffered
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17000662 RID: 1634
			// (get) Token: 0x060011FA RID: 4602 RVA: 0x00053B30 File Offset: 0x00051D30
			public unsafe string StringValue
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 12358, RefRangeEnd = 12365, XrefRangeStart = 12357, XrefRangeEnd = 12358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_get_StringValue_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060011FB RID: 4603 RVA: 0x00053B68 File Offset: 0x00051D68
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12366, RefRangeEnd = 12368, XrefRangeStart = 12365, XrefRangeEnd = 12366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void TrimSpacesInValue()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011FC RID: 4604 RVA: 0x00053B9C File Offset: 0x00051D9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 12372, RefRangeEnd = 12373, XrefRangeStart = 12368, XrefRangeEnd = 12372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear(XmlNodeType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060011FD RID: 4605 RVA: 0x00053BDC File Offset: 0x00051DDC
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 12378, RefRangeEnd = 12383, XrefRangeStart = 12373, XrefRangeEnd = 12378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ClearName()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_ClearName_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011FE RID: 4606 RVA: 0x00053C10 File Offset: 0x00051E10
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 12384, RefRangeEnd = 12395, XrefRangeStart = 12383, XrefRangeEnd = 12384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLineInfo(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060011FF RID: 4607 RVA: 0x00053C5C File Offset: 0x00051E5C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12396, RefRangeEnd = 12398, XrefRangeStart = 12395, XrefRangeEnd = 12396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetLineInfo2(int lineNo, int linePos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref lineNo;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x00053CA8 File Offset: 0x00051EA8
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 12399, RefRangeEnd = 12405, XrefRangeStart = 12398, XrefRangeEnd = 12399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00053CF8 File Offset: 0x00051EF8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12406, RefRangeEnd = 12408, XrefRangeStart = 12405, XrefRangeEnd = 12406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValueNode(XmlNodeType type, Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(chars);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001202 RID: 4610 RVA: 0x00053D64 File Offset: 0x00051F64
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 12413, RefRangeEnd = 12424, XrefRangeStart = 12408, XrefRangeEnd = 12413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x00053DB4 File Offset: 0x00051FB4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 12427, RefRangeEnd = 12431, XrefRangeStart = 12424, XrefRangeEnd = 12427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(nameWPrefix);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001204 RID: 4612 RVA: 0x00053E2C File Offset: 0x0005202C
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 12431, RefRangeEnd = 12444, XrefRangeStart = 12431, XrefRangeEnd = 12431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001205 RID: 4613 RVA: 0x00053E70 File Offset: 0x00052070
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 12444, RefRangeEnd = 12447, XrefRangeStart = 12444, XrefRangeEnd = 12444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetValue(Il2CppStructArray<char> chars, int startPos, int len)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(chars);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startPos;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001206 RID: 4614 RVA: 0x00053ED0 File Offset: 0x000520D0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12448, RefRangeEnd = 12450, XrefRangeStart = 12447, XrefRangeEnd = 12448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnBufferInvalidated()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001207 RID: 4615 RVA: 0x00053F04 File Offset: 0x00052104
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 12451, RefRangeEnd = 12453, XrefRangeStart = 12450, XrefRangeEnd = 12451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyTo(int valueOffset, StringBuilder sb)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref valueOffset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001208 RID: 4616 RVA: 0x00053F54 File Offset: 0x00052154
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 12456, RefRangeEnd = 12462, XrefRangeStart = 12453, XrefRangeEnd = 12456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06001209 RID: 4617 RVA: 0x00053F9C File Offset: 0x0005219C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12462, XrefRangeEnd = 12465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string CreateNameWPrefix(XmlNameTable nt)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(nt);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600120A RID: 4618 RVA: 0x00053FE4 File Offset: 0x000521E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12465, XrefRangeEnd = 12471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int System_IComparable_CompareTo(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.NodeData.NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600120B RID: 4619 RVA: 0x00007E26 File Offset: 0x00006026
			public NodeData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000648 RID: 1608
			// (get) Token: 0x0600120C RID: 4620 RVA: 0x00054034 File Offset: 0x00052234
			// (set) Token: 0x0600120D RID: 4621 RVA: 0x00007E2F File Offset: 0x0000602F
			public unsafe static XmlTextReaderImpl.NodeData s_None
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_s_None, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000649 RID: 1609
			// (get) Token: 0x0600120E RID: 4622 RVA: 0x0005405C File Offset: 0x0005225C
			// (set) Token: 0x0600120F RID: 4623 RVA: 0x00007E41 File Offset: 0x00006041
			public unsafe XmlNodeType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x1700064A RID: 1610
			// (get) Token: 0x06001210 RID: 4624 RVA: 0x00054084 File Offset: 0x00052284
			// (set) Token: 0x06001211 RID: 4625 RVA: 0x00007E5C File Offset: 0x0000605C
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064B RID: 1611
			// (get) Token: 0x06001212 RID: 4626 RVA: 0x000540AC File Offset: 0x000522AC
			// (set) Token: 0x06001213 RID: 4627 RVA: 0x00007E7B File Offset: 0x0000607B
			public unsafe string prefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064C RID: 1612
			// (get) Token: 0x06001214 RID: 4628 RVA: 0x000540D4 File Offset: 0x000522D4
			// (set) Token: 0x06001215 RID: 4629 RVA: 0x00007E9A File Offset: 0x0000609A
			public unsafe string ns
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_ns), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064D RID: 1613
			// (get) Token: 0x06001216 RID: 4630 RVA: 0x000540FC File Offset: 0x000522FC
			// (set) Token: 0x06001217 RID: 4631 RVA: 0x00007EB9 File Offset: 0x000060B9
			public unsafe string nameWPrefix
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nameWPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064E RID: 1614
			// (get) Token: 0x06001218 RID: 4632 RVA: 0x00054124 File Offset: 0x00052324
			// (set) Token: 0x06001219 RID: 4633 RVA: 0x00007ED8 File Offset: 0x000060D8
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700064F RID: 1615
			// (get) Token: 0x0600121A RID: 4634 RVA: 0x0005414C File Offset: 0x0005234C
			// (set) Token: 0x0600121B RID: 4635 RVA: 0x00007EF7 File Offset: 0x000060F7
			public unsafe Il2CppStructArray<char> chars
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000650 RID: 1616
			// (get) Token: 0x0600121C RID: 4636 RVA: 0x0005417C File Offset: 0x0005237C
			// (set) Token: 0x0600121D RID: 4637 RVA: 0x00007F16 File Offset: 0x00006116
			public unsafe int valueStartPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueStartPos)) = value;
				}
			}

			// Token: 0x17000651 RID: 1617
			// (get) Token: 0x0600121E RID: 4638 RVA: 0x000541A4 File Offset: 0x000523A4
			// (set) Token: 0x0600121F RID: 4639 RVA: 0x00007F31 File Offset: 0x00006131
			public unsafe int valueLength
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_valueLength)) = value;
				}
			}

			// Token: 0x17000652 RID: 1618
			// (get) Token: 0x06001220 RID: 4640 RVA: 0x000541CC File Offset: 0x000523CC
			// (set) Token: 0x06001221 RID: 4641 RVA: 0x00007F4C File Offset: 0x0000614C
			public unsafe LineInfo lineInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo)) = value;
				}
			}

			// Token: 0x17000653 RID: 1619
			// (get) Token: 0x06001222 RID: 4642 RVA: 0x000541F4 File Offset: 0x000523F4
			// (set) Token: 0x06001223 RID: 4643 RVA: 0x00007F67 File Offset: 0x00006167
			public unsafe LineInfo lineInfo2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_lineInfo2)) = value;
				}
			}

			// Token: 0x17000654 RID: 1620
			// (get) Token: 0x06001224 RID: 4644 RVA: 0x0005421C File Offset: 0x0005241C
			// (set) Token: 0x06001225 RID: 4645 RVA: 0x00007F82 File Offset: 0x00006182
			public unsafe char quoteChar
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_quoteChar)) = value;
				}
			}

			// Token: 0x17000655 RID: 1621
			// (get) Token: 0x06001226 RID: 4646 RVA: 0x00054244 File Offset: 0x00052444
			// (set) Token: 0x06001227 RID: 4647 RVA: 0x00007F9D File Offset: 0x0000619D
			public unsafe int depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000656 RID: 1622
			// (get) Token: 0x06001228 RID: 4648 RVA: 0x0005426C File Offset: 0x0005246C
			// (set) Token: 0x06001229 RID: 4649 RVA: 0x00007FB8 File Offset: 0x000061B8
			public unsafe bool isEmptyOrDefault
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_isEmptyOrDefault)) = value;
				}
			}

			// Token: 0x17000657 RID: 1623
			// (get) Token: 0x0600122A RID: 4650 RVA: 0x00054294 File Offset: 0x00052494
			// (set) Token: 0x0600122B RID: 4651 RVA: 0x00007FD3 File Offset: 0x000061D3
			public unsafe int entityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_entityId)) = value;
				}
			}

			// Token: 0x17000658 RID: 1624
			// (get) Token: 0x0600122C RID: 4652 RVA: 0x000542BC File Offset: 0x000524BC
			// (set) Token: 0x0600122D RID: 4653 RVA: 0x00007FEE File Offset: 0x000061EE
			public unsafe bool xmlContextPushed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_xmlContextPushed)) = value;
				}
			}

			// Token: 0x17000659 RID: 1625
			// (get) Token: 0x0600122E RID: 4654 RVA: 0x000542E4 File Offset: 0x000524E4
			// (set) Token: 0x0600122F RID: 4655 RVA: 0x00008009 File Offset: 0x00006209
			public unsafe XmlTextReaderImpl.NodeData nextAttrValueChunk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTextReaderImpl.NodeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_nextAttrValueChunk), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065A RID: 1626
			// (get) Token: 0x06001230 RID: 4656 RVA: 0x00054314 File Offset: 0x00052514
			// (set) Token: 0x06001231 RID: 4657 RVA: 0x00008028 File Offset: 0x00006228
			public unsafe Object schemaType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_schemaType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700065B RID: 1627
			// (get) Token: 0x06001232 RID: 4658 RVA: 0x00054344 File Offset: 0x00052544
			// (set) Token: 0x06001233 RID: 4659 RVA: 0x00008047 File Offset: 0x00006247
			public unsafe Object typedValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTextReaderImpl.NodeData.NativeFieldInfoPtr_typedValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000DEF RID: 3567
			private static readonly IntPtr NativeFieldInfoPtr_s_None;

			// Token: 0x04000DF0 RID: 3568
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04000DF1 RID: 3569
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x04000DF2 RID: 3570
			private static readonly IntPtr NativeFieldInfoPtr_prefix;

			// Token: 0x04000DF3 RID: 3571
			private static readonly IntPtr NativeFieldInfoPtr_ns;

			// Token: 0x04000DF4 RID: 3572
			private static readonly IntPtr NativeFieldInfoPtr_nameWPrefix;

			// Token: 0x04000DF5 RID: 3573
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000DF6 RID: 3574
			private static readonly IntPtr NativeFieldInfoPtr_chars;

			// Token: 0x04000DF7 RID: 3575
			private static readonly IntPtr NativeFieldInfoPtr_valueStartPos;

			// Token: 0x04000DF8 RID: 3576
			private static readonly IntPtr NativeFieldInfoPtr_valueLength;

			// Token: 0x04000DF9 RID: 3577
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

			// Token: 0x04000DFA RID: 3578
			private static readonly IntPtr NativeFieldInfoPtr_lineInfo2;

			// Token: 0x04000DFB RID: 3579
			private static readonly IntPtr NativeFieldInfoPtr_quoteChar;

			// Token: 0x04000DFC RID: 3580
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x04000DFD RID: 3581
			private static readonly IntPtr NativeFieldInfoPtr_isEmptyOrDefault;

			// Token: 0x04000DFE RID: 3582
			private static readonly IntPtr NativeFieldInfoPtr_entityId;

			// Token: 0x04000DFF RID: 3583
			private static readonly IntPtr NativeFieldInfoPtr_xmlContextPushed;

			// Token: 0x04000E00 RID: 3584
			private static readonly IntPtr NativeFieldInfoPtr_nextAttrValueChunk;

			// Token: 0x04000E01 RID: 3585
			private static readonly IntPtr NativeFieldInfoPtr_schemaType;

			// Token: 0x04000E02 RID: 3586
			private static readonly IntPtr NativeFieldInfoPtr_typedValue;

			// Token: 0x04000E03 RID: 3587
			private static readonly IntPtr NativeMethodInfoPtr_get_None_Internal_Static_get_NodeData_0;

			// Token: 0x04000E04 RID: 3588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x04000E05 RID: 3589
			private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Internal_get_Int32_0;

			// Token: 0x04000E06 RID: 3590
			private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Internal_get_Int32_0;

			// Token: 0x04000E07 RID: 3591
			private static readonly IntPtr NativeMethodInfoPtr_get_IsEmptyElement_Internal_get_Boolean_0;

			// Token: 0x04000E08 RID: 3592
			private static readonly IntPtr NativeMethodInfoPtr_set_IsEmptyElement_Internal_set_Void_Boolean_0;

			// Token: 0x04000E09 RID: 3593
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDefaultAttribute_Internal_get_Boolean_0;

			// Token: 0x04000E0A RID: 3594
			private static readonly IntPtr NativeMethodInfoPtr_set_IsDefaultAttribute_Internal_set_Void_Boolean_0;

			// Token: 0x04000E0B RID: 3595
			private static readonly IntPtr NativeMethodInfoPtr_get_ValueBuffered_Internal_get_Boolean_0;

			// Token: 0x04000E0C RID: 3596
			private static readonly IntPtr NativeMethodInfoPtr_get_StringValue_Internal_get_String_0;

			// Token: 0x04000E0D RID: 3597
			private static readonly IntPtr NativeMethodInfoPtr_TrimSpacesInValue_Internal_Void_0;

			// Token: 0x04000E0E RID: 3598
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0;

			// Token: 0x04000E0F RID: 3599
			private static readonly IntPtr NativeMethodInfoPtr_ClearName_Internal_Void_0;

			// Token: 0x04000E10 RID: 3600
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

			// Token: 0x04000E11 RID: 3601
			private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo2_Internal_Void_Int32_Int32_0;

			// Token: 0x04000E12 RID: 3602
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x04000E13 RID: 3603
			private static readonly IntPtr NativeMethodInfoPtr_SetValueNode_Internal_Void_XmlNodeType_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04000E14 RID: 3604
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_0;

			// Token: 0x04000E15 RID: 3605
			private static readonly IntPtr NativeMethodInfoPtr_SetNamedNode_Internal_Void_XmlNodeType_String_String_String_0;

			// Token: 0x04000E16 RID: 3606
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_String_0;

			// Token: 0x04000E17 RID: 3607
			private static readonly IntPtr NativeMethodInfoPtr_SetValue_Internal_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

			// Token: 0x04000E18 RID: 3608
			private static readonly IntPtr NativeMethodInfoPtr_OnBufferInvalidated_Internal_Void_0;

			// Token: 0x04000E19 RID: 3609
			private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Internal_Void_Int32_StringBuilder_0;

			// Token: 0x04000E1A RID: 3610
			private static readonly IntPtr NativeMethodInfoPtr_GetNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x04000E1B RID: 3611
			private static readonly IntPtr NativeMethodInfoPtr_CreateNameWPrefix_Internal_String_XmlNameTable_0;

			// Token: 0x04000E1C RID: 3612
			private static readonly IntPtr NativeMethodInfoPtr_System_IComparable_CompareTo_Private_Virtual_Final_New_Int32_Object_0;
		}

		// Token: 0x02000120 RID: 288
		public class DtdDefaultAttributeInfoToNodeDataComparer : Object
		{
			// Token: 0x06001234 RID: 4660 RVA: 0x00054374 File Offset: 0x00052574
			// Note: this type is marked as 'beforefieldinit'.
			static DtdDefaultAttributeInfoToNodeDataComparer()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "DtdDefaultAttributeInfoToNodeDataComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, "s_instance");
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100663817);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100663818);
				XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr, 100663819);
			}

			// Token: 0x17000664 RID: 1636
			// (get) Token: 0x06001235 RID: 4661 RVA: 0x000543F0 File Offset: 0x000525F0
			public unsafe static IComparer<Object> Instance
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12471, XrefRangeEnd = 12475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr3) : null;
				}
			}

			// Token: 0x06001236 RID: 4662 RVA: 0x00054424 File Offset: 0x00052624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 12475, XrefRangeEnd = 12496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(Object x, Object y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001237 RID: 4663 RVA: 0x00054484 File Offset: 0x00052684
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DtdDefaultAttributeInfoToNodeDataComparer()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001238 RID: 4664 RVA: 0x00008066 File Offset: 0x00006266
			public DtdDefaultAttributeInfoToNodeDataComparer(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000663 RID: 1635
			// (get) Token: 0x06001239 RID: 4665 RVA: 0x000544C0 File Offset: 0x000526C0
			// (set) Token: 0x0600123A RID: 4666 RVA: 0x0000806F File Offset: 0x0000626F
			public unsafe static IComparer<Object> s_instance
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IComparer<Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(XmlTextReaderImpl.DtdDefaultAttributeInfoToNodeDataComparer.NativeFieldInfoPtr_s_instance, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E1D RID: 3613
			private static readonly IntPtr NativeFieldInfoPtr_s_instance;

			// Token: 0x04000E1E RID: 3614
			private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Internal_Static_get_IComparer_1_Object_0;

			// Token: 0x04000E1F RID: 3615
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;

			// Token: 0x04000E20 RID: 3616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000121 RID: 289
		public sealed class OnDefaultAttributeUseDelegate : MulticastDelegate
		{
			// Token: 0x0600123B RID: 4667 RVA: 0x00008081 File Offset: 0x00006281
			// Note: this type is marked as 'beforefieldinit'.
			static OnDefaultAttributeUseDelegate()
			{
				Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XmlTextReaderImpl>.NativeClassPtr, "OnDefaultAttributeUseDelegate");
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100663821);
				XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr, 100663822);
			}

			// Token: 0x0600123C RID: 4668 RVA: 0x000544E8 File Offset: 0x000526E8
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnDefaultAttributeUseDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600123D RID: 4669 RVA: 0x00054544 File Offset: 0x00052744
			[CallerCount(34)]
			[CachedScanResults(RefRangeStart = 10628, RefRangeEnd = 10662, XrefRangeStart = 10628, XrefRangeEnd = 10662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultAttribute);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(coreReader);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTextReaderImpl.OnDefaultAttributeUseDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600123E RID: 4670 RVA: 0x000080BF File Offset: 0x000062BF
			public OnDefaultAttributeUseDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600123F RID: 4671 RVA: 0x000080C8 File Offset: 0x000062C8
			public static implicit operator XmlTextReaderImpl.OnDefaultAttributeUseDelegate(Action<IDtdDefaultAttributeInfo, XmlTextReaderImpl> A_0)
			{
				return DelegateSupport.ConvertDelegate<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>(A_0);
			}

			// Token: 0x06001240 RID: 4672 RVA: 0x000080D0 File Offset: 0x000062D0
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator +(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
			}

			// Token: 0x06001241 RID: 4673 RVA: 0x000080DE File Offset: 0x000062DE
			public static XmlTextReaderImpl.OnDefaultAttributeUseDelegate operator -(XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_0, XmlTextReaderImpl.OnDefaultAttributeUseDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<XmlTextReaderImpl.OnDefaultAttributeUseDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04000E21 RID: 3617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04000E22 RID: 3618
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_IDtdDefaultAttributeInfo_XmlTextReaderImpl_0;
		}
	}
}
