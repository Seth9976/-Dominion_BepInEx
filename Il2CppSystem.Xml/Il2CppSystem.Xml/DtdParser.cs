using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200004A RID: 74
	public class DtdParser : Object
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00022E80 File Offset: 0x00021080
		// Note: this type is marked as 'beforefieldinit'.
		static DtdParser()
		{
			Il2CppClassPointerStore<DtdParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "DtdParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser>.NativeClassPtr);
			DtdParser.NativeFieldInfoPtr_readerAdapter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapter");
			DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "readerAdapterWithValidation");
			DtdParser.NativeFieldInfoPtr_nameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nameTable");
			DtdParser.NativeFieldInfoPtr_schemaInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "schemaInfo");
			DtdParser.NativeFieldInfoPtr_xmlCharType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "xmlCharType");
			DtdParser.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "systemId");
			DtdParser.NativeFieldInfoPtr_publicId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "publicId");
			DtdParser.NativeFieldInfoPtr_normalize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "normalize");
			DtdParser.NativeFieldInfoPtr_validate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "validate");
			DtdParser.NativeFieldInfoPtr_supportNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "supportNamespaces");
			DtdParser.NativeFieldInfoPtr_v1Compat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "v1Compat");
			DtdParser.NativeFieldInfoPtr_chars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "chars");
			DtdParser.NativeFieldInfoPtr_charsUsed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "charsUsed");
			DtdParser.NativeFieldInfoPtr_curPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "curPos");
			DtdParser.NativeFieldInfoPtr_scanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "scanningFunction");
			DtdParser.NativeFieldInfoPtr_nextScaningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "nextScaningFunction");
			DtdParser.NativeFieldInfoPtr_savedScanningFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "savedScanningFunction");
			DtdParser.NativeFieldInfoPtr_whitespaceSeen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "whitespaceSeen");
			DtdParser.NativeFieldInfoPtr_tokenStartPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "tokenStartPos");
			DtdParser.NativeFieldInfoPtr_colonPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "colonPos");
			DtdParser.NativeFieldInfoPtr_internalSubsetValueSb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "internalSubsetValueSb");
			DtdParser.NativeFieldInfoPtr_externalEntitiesDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalEntitiesDepth");
			DtdParser.NativeFieldInfoPtr_currentEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "currentEntityId");
			DtdParser.NativeFieldInfoPtr_freeFloatingDtd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "freeFloatingDtd");
			DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "hasFreeFloatingInternalSubset");
			DtdParser.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "stringBuilder");
			DtdParser.NativeFieldInfoPtr_condSectionDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionDepth");
			DtdParser.NativeFieldInfoPtr_literalLineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalLineInfo");
			DtdParser.NativeFieldInfoPtr_literalQuoteChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "literalQuoteChar");
			DtdParser.NativeFieldInfoPtr_documentBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "documentBaseUri");
			DtdParser.NativeFieldInfoPtr_externalDtdBaseUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "externalDtdBaseUri");
			DtdParser.NativeFieldInfoPtr_undeclaredNotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "undeclaredNotations");
			DtdParser.NativeFieldInfoPtr_condSectionEntityIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "condSectionEntityIds");
			DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664297);
			DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664298);
			DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664299);
			DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664300);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664301);
			DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664302);
			DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664303);
			DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664304);
			DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664305);
			DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664306);
			DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664307);
			DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664308);
			DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664309);
			DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664310);
			DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664311);
			DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664312);
			DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664313);
			DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664314);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664315);
			DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664316);
			DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664317);
			DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664318);
			DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664319);
			DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664320);
			DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664321);
			DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664322);
			DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664323);
			DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664324);
			DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664325);
			DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664326);
			DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664327);
			DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664328);
			DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664329);
			DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664330);
			DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664331);
			DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664332);
			DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664333);
			DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664334);
			DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664335);
			DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664336);
			DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664337);
			DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664338);
			DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664339);
			DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664340);
			DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664341);
			DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664342);
			DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664343);
			DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664344);
			DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664345);
			DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664346);
			DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664347);
			DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664348);
			DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664349);
			DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664350);
			DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664351);
			DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664352);
			DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664353);
			DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664354);
			DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664355);
			DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664356);
			DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664357);
			DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664358);
			DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664359);
			DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664360);
			DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664361);
			DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664362);
			DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664363);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664364);
			DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664365);
			DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664366);
			DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664367);
			DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664368);
			DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664369);
			DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664370);
			DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664371);
			DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664372);
			DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664373);
			DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664374);
			DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664375);
			DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664376);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664377);
			DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664378);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664379);
			DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664380);
			DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664381);
			DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664382);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664383);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664384);
			DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664385);
			DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664386);
			DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664387);
			DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664388);
			DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664389);
			DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664390);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664391);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664392);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664393);
			DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664394);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664395);
			DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664396);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664397);
			DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664398);
			DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664399);
			DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, 100664400);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00023964 File Offset: 0x00021B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17684, XrefRangeEnd = 17692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000239A0 File Offset: 0x00021BA0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 17703, RefRangeEnd = 17707, XrefRangeStart = 17692, XrefRangeEnd = 17703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDtdParser Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdParser>(intPtr3) : null;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000239D4 File Offset: 0x00021BD4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17740, RefRangeEnd = 17742, XrefRangeStart = 17707, XrefRangeEnd = 17740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(IDtdParserAdapter readerAdapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readerAdapter);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00023A18 File Offset: 0x00021C18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 17771, RefRangeEnd = 17772, XrefRangeStart = 17742, XrefRangeEnd = 17771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00023AB8 File Offset: 0x00021CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17772, XrefRangeEnd = 17774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveInternalSubset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00023B18 File Offset: 0x00021D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17774, XrefRangeEnd = 17776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdInfo System_Xml_IDtdParser_ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(baseUri);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(docTypeName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(publicId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(systemId);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(internalSubset);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(adapter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdInfo>(intPtr3) : null;
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000623 RID: 1571 RVA: 0x00023BC8 File Offset: 0x00021DC8
		public unsafe bool ParsingInternalSubset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00023C04 File Offset: 0x00021E04
		public unsafe bool IgnoreEntityReferences
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00023C40 File Offset: 0x00021E40
		public unsafe bool SaveInternalSubsetValue
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17776, XrefRangeEnd = 17779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00023C7C File Offset: 0x00021E7C
		public unsafe bool ParsingTopLevelMarkup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00023CB8 File Offset: 0x00021EB8
		public unsafe bool SupportNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x00023CF4 File Offset: 0x00021EF4
		public unsafe bool Normalize
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00023D30 File Offset: 0x00021F30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 17824, RefRangeEnd = 17826, XrefRangeStart = 17779, XrefRangeEnd = 17824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Parse_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00023D70 File Offset: 0x00021F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17826, XrefRangeEnd = 17843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInDocumentDtd(bool saveInternalSubset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref saveInternalSubset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00023DB0 File Offset: 0x00021FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17843, XrefRangeEnd = 17847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseFreeFloatingDtd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00023DE4 File Offset: 0x00021FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17847, XrefRangeEnd = 17848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseInternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00023E18 File Offset: 0x00022018
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 17859, RefRangeEnd = 17862, XrefRangeStart = 17848, XrefRangeEnd = 17859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00023E4C File Offset: 0x0002204C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 17935, RefRangeEnd = 17940, XrefRangeStart = 17862, XrefRangeEnd = 17935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseSubset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseSubset_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00023E80 File Offset: 0x00022080
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18016, RefRangeEnd = 18017, XrefRangeStart = 17940, XrefRangeEnd = 18016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00023EB4 File Offset: 0x000220B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18050, RefRangeEnd = 18051, XrefRangeStart = 18017, XrefRangeEnd = 18050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementDecl);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00023F18 File Offset: 0x00022118
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18070, RefRangeEnd = 18071, XrefRangeStart = 18051, XrefRangeEnd = 18070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreErrors;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00023F68 File Offset: 0x00022168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18127, RefRangeEnd = 18128, XrefRangeStart = 18071, XrefRangeEnd = 18127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00023F9C File Offset: 0x0002219C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18201, RefRangeEnd = 18202, XrefRangeStart = 18128, XrefRangeEnd = 18201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00023FEC File Offset: 0x000221EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18202, XrefRangeEnd = 18204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseHowMany(ParticleContentValidator pcv)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00024030 File Offset: 0x00022230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18237, RefRangeEnd = 18238, XrefRangeStart = 18204, XrefRangeEnd = 18237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pcv);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startParenEntityId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00024080 File Offset: 0x00022280
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18282, RefRangeEnd = 18283, XrefRangeStart = 18238, XrefRangeEnd = 18282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseEntityDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x000240B4 File Offset: 0x000222B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18311, RefRangeEnd = 18312, XrefRangeStart = 18283, XrefRangeEnd = 18311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseNotationDecl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x000240E8 File Offset: 0x000222E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18334, RefRangeEnd = 18335, XrefRangeStart = 18312, XrefRangeEnd = 18334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddUndeclaredNotation(string notationName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(notationName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0002412C File Offset: 0x0002232C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18362, RefRangeEnd = 18363, XrefRangeStart = 18335, XrefRangeEnd = 18362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00024160 File Offset: 0x00022360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18363, XrefRangeEnd = 18378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParsePI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParsePI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00024194 File Offset: 0x00022394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18407, RefRangeEnd = 18408, XrefRangeStart = 18378, XrefRangeEnd = 18407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseCondSection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseCondSection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000241C8 File Offset: 0x000223C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 18437, RefRangeEnd = 18441, XrefRangeStart = 18408, XrefRangeEnd = 18437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref idTokenType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref declType;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			publicId = IL2CPP.Il2CppStringToManaged(intPtr);
			systemId = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0002424C File Offset: 0x0002244C
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 18490, RefRangeEnd = 18536, XrefRangeStart = 18441, XrefRangeEnd = 18490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token GetToken(bool needWhiteSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref needWhiteSpace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00024298 File Offset: 0x00022498
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18541, RefRangeEnd = 18542, XrefRangeStart = 18536, XrefRangeEnd = 18541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSubsetContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x000242D4 File Offset: 0x000224D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18542, XrefRangeEnd = 18543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00024310 File Offset: 0x00022510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18543, XrefRangeEnd = 18544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanQNameExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0002434C File Offset: 0x0002254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18544, XrefRangeEnd = 18545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNmtokenExpected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00024388 File Offset: 0x00022588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18545, XrefRangeEnd = 18549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x000243C4 File Offset: 0x000225C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18549, XrefRangeEnd = 18550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanDoctype2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanDoctype2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00024400 File Offset: 0x00022600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18550, XrefRangeEnd = 18553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanClosingTag()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanClosingTag_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0002443C File Offset: 0x0002263C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18553, XrefRangeEnd = 18555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00024478 File Offset: 0x00022678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18555, XrefRangeEnd = 18564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x000244B4 File Offset: 0x000226B4
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x000244F0 File Offset: 0x000226F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18564, XrefRangeEnd = 18571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0002452C File Offset: 0x0002272C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18571, XrefRangeEnd = 18572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00024568 File Offset: 0x00022768
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18572, XrefRangeEnd = 18574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanElement6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x000245A4 File Offset: 0x000227A4
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanElement7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanElement7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x000245E0 File Offset: 0x000227E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18574, XrefRangeEnd = 18579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0002461C File Offset: 0x0002281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18579, XrefRangeEnd = 18606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x00024658 File Offset: 0x00022858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18606, XrefRangeEnd = 18609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00024694 File Offset: 0x00022894
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18609, XrefRangeEnd = 18611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist4_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x000246D0 File Offset: 0x000228D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18611, XrefRangeEnd = 18613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist5()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist5_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0002470C File Offset: 0x0002290C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18613, XrefRangeEnd = 18633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist6()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist6_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00024748 File Offset: 0x00022948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18633, XrefRangeEnd = 18638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanAttlist7()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanAttlist7_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00024784 File Offset: 0x00022984
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18805, RefRangeEnd = 18807, XrefRangeStart = 18638, XrefRangeEnd = 18805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref literalType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x000247D0 File Offset: 0x000229D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18816, RefRangeEnd = 18821, XrefRangeStart = 18807, XrefRangeEnd = 18816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName ScanEntityName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00024810 File Offset: 0x00022A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18821, XrefRangeEnd = 18826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanNotation1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNotation1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0002484C File Offset: 0x00022A4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18826, XrefRangeEnd = 18832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanSystemId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanSystemId_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00024888 File Offset: 0x00022A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18832, XrefRangeEnd = 18833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x000248C4 File Offset: 0x00022AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18833, XrefRangeEnd = 18838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00024900 File Offset: 0x00022B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18838, XrefRangeEnd = 18839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanEntity3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanEntity3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0002493C File Offset: 0x00022B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18839, XrefRangeEnd = 18845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanPublicId1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00024978 File Offset: 0x00022B78
		[CallerCount(0)]
		public unsafe DtdParser.Token ScanPublicId2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanPublicId2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000249B4 File Offset: 0x00022BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18845, XrefRangeEnd = 18862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection1_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x000249F0 File Offset: 0x00022BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18862, XrefRangeEnd = 18865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection2_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00024A2C File Offset: 0x00022C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18865, XrefRangeEnd = 18898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DtdParser.Token ScanCondSection3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanCondSection3_Private_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00024A68 File Offset: 0x00022C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18898, XrefRangeEnd = 18899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00024A9C File Offset: 0x00022C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18899, XrefRangeEnd = 18900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00024AD0 File Offset: 0x00022CD0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 18925, RefRangeEnd = 18934, XrefRangeStart = 18900, XrefRangeEnd = 18925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanQName(bool isQName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isQName;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x00024B10 File Offset: 0x00022D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18934, XrefRangeEnd = 18935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ReadDataInName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00024B4C File Offset: 0x00022D4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18948, RefRangeEnd = 18949, XrefRangeStart = 18935, XrefRangeEnd = 18948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanNmtoken()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ScanNmtoken_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x00024B80 File Offset: 0x00022D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 18950, RefRangeEnd = 18952, XrefRangeStart = 18949, XrefRangeEnd = 18950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatPublicKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00024BBC File Offset: 0x00022DBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18953, RefRangeEnd = 18954, XrefRangeStart = 18952, XrefRangeEnd = 18953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool EatSystemKeyword()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00024BF8 File Offset: 0x00022DF8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 18959, RefRangeEnd = 18970, XrefRangeStart = 18954, XrefRangeEnd = 18959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref canHavePrefix;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00024C44 File Offset: 0x00022E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18970, XrefRangeEnd = 18971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNameString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNameString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00024C7C File Offset: 0x00022E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNmtokenString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetNmtokenString_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00024CB4 File Offset: 0x00022EB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 18973, RefRangeEnd = 18977, XrefRangeStart = 18971, XrefRangeEnd = 18973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValue_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00024CEC File Offset: 0x00022EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18977, XrefRangeEnd = 18982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetValueWithStrippedSpaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00024D24 File Offset: 0x00022F24
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 18987, RefRangeEnd = 18992, XrefRangeStart = 18982, XrefRangeEnd = 18987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ReadData_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00024D60 File Offset: 0x00022F60
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 18999, RefRangeEnd = 19024, XrefRangeStart = 18992, XrefRangeEnd = 18999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00024D94 File Offset: 0x00022F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19024, XrefRangeEnd = 19025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00024DC8 File Offset: 0x00022FC8
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 19035, RefRangeEnd = 19063, XrefRangeStart = 19025, XrefRangeEnd = 19035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalSubsetValueEndPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00024E08 File Offset: 0x00023008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19063, XrefRangeEnd = 19065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref paramEntity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00024E70 File Offset: 0x00023070
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19078, RefRangeEnd = 19080, XrefRangeStart = 19065, XrefRangeEnd = 19078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inLiteral;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00024EE8 File Offset: 0x000230E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19088, RefRangeEnd = 19091, XrefRangeStart = 19080, XrefRangeEnd = 19088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HandleEntityEnd(bool inLiteral)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inLiteral;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00024F34 File Offset: 0x00023134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19106, RefRangeEnd = 19107, XrefRangeStart = 19091, XrefRangeEnd = 19106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref paramEntity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref mustBeDeclared;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inAttribute;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaEntity>(intPtr3) : null;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00024FB0 File Offset: 0x000231B0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 19120, RefRangeEnd = 19133, XrefRangeStart = 19107, XrefRangeEnd = 19120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref severity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00025024 File Offset: 0x00023224
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19146, RefRangeEnd = 19148, XrefRangeStart = 19133, XrefRangeEnd = 19146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00025088 File Offset: 0x00023288
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19154, RefRangeEnd = 19158, XrefRangeStart = 19148, XrefRangeEnd = 19154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref severity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000250D8 File Offset: 0x000232D8
		[CallerCount(0)]
		public unsafe bool IsAttributeValueType(DtdParser.Token token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x00025124 File Offset: 0x00023324
		public unsafe int LineNo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19158, XrefRangeEnd = 19162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00025160 File Offset: 0x00023360
		public unsafe int LinePos
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19162, XrefRangeEnd = 19165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x0002519C File Offset: 0x0002339C
		public unsafe string BaseUriStr
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 19174, RefRangeEnd = 19179, XrefRangeStart = 19165, XrefRangeEnd = 19174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x000251D4 File Offset: 0x000233D4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 19184, RefRangeEnd = 19194, XrefRangeStart = 19179, XrefRangeEnd = 19184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnUnexpectedError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00025208 File Offset: 0x00023408
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 19197, RefRangeEnd = 19209, XrefRangeStart = 19194, XrefRangeEnd = 19197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x00025258 File Offset: 0x00023458
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 19230, RefRangeEnd = 19267, XrefRangeStart = 19209, XrefRangeEnd = 19230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, string arg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(arg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x000252BC File Offset: 0x000234BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 19288, RefRangeEnd = 19294, XrefRangeStart = 19267, XrefRangeEnd = 19288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Throw(int curPos, string res, Il2CppStringArray args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref curPos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(res);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x00025320 File Offset: 0x00023520
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 19309, RefRangeEnd = 19313, XrefRangeStart = 19294, XrefRangeEnd = 19309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x00025390 File Offset: 0x00023590
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19317, RefRangeEnd = 19320, XrefRangeStart = 19313, XrefRangeEnd = 19317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pos;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invCharPos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000253F0 File Offset: 0x000235F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19320, XrefRangeEnd = 19324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00025450 File Offset: 0x00023650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19324, XrefRangeEnd = 19325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x000254A0 File Offset: 0x000236A0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 19335, RefRangeEnd = 19348, XrefRangeStart = 19325, XrefRangeEnd = 19335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00025504 File Offset: 0x00023704
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19350, RefRangeEnd = 19353, XrefRangeStart = 19348, XrefRangeEnd = 19350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ParseUnexpectedToken(int startPos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref startPos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00025548 File Offset: 0x00023748
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19368, RefRangeEnd = 19371, XrefRangeStart = 19353, XrefRangeEnd = 19368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string StripSpaces(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x000040AD File Offset: 0x000022AD
		public DtdParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00025584 File Offset: 0x00023784
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x000040B6 File Offset: 0x000022B6
		public unsafe IDtdParserAdapter readerAdapter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000255B4 File Offset: 0x000237B4
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x000040D5 File Offset: 0x000022D5
		public unsafe IDtdParserAdapterWithValidation readerAdapterWithValidation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDtdParserAdapterWithValidation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_readerAdapterWithValidation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000255E4 File Offset: 0x000237E4
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x000040F4 File Offset: 0x000022F4
		public unsafe XmlNameTable nameTable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlNameTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nameTable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00025614 File Offset: 0x00023814
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00004113 File Offset: 0x00002313
		public unsafe SchemaInfo schemaInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_schemaInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x00025644 File Offset: 0x00023844
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00004132 File Offset: 0x00002332
		public XmlCharType xmlCharType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType);
				return new XmlCharType(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_xmlCharType), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<XmlCharType>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00025674 File Offset: 0x00023874
		// (set) Token: 0x06000691 RID: 1681 RVA: 0x00004160 File Offset: 0x00002360
		public unsafe string systemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_systemId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0002569C File Offset: 0x0002389C
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0000417F File Offset: 0x0000237F
		public unsafe string publicId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_publicId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x000256C4 File Offset: 0x000238C4
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0000419E File Offset: 0x0000239E
		public unsafe bool normalize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_normalize)) = value;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x000256EC File Offset: 0x000238EC
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x000041B9 File Offset: 0x000023B9
		public unsafe bool validate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_validate)) = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x00025714 File Offset: 0x00023914
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x000041D4 File Offset: 0x000023D4
		public unsafe bool supportNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_supportNamespaces)) = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0002573C File Offset: 0x0002393C
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x000041EF File Offset: 0x000023EF
		public unsafe bool v1Compat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_v1Compat)) = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00025764 File Offset: 0x00023964
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0000420A File Offset: 0x0000240A
		public unsafe Il2CppStructArray<char> chars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_chars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00025794 File Offset: 0x00023994
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00004229 File Offset: 0x00002429
		public unsafe int charsUsed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_charsUsed)) = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x000257BC File Offset: 0x000239BC
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x00004244 File Offset: 0x00002444
		public unsafe int curPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_curPos)) = value;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x000257E4 File Offset: 0x000239E4
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0000425F File Offset: 0x0000245F
		public unsafe DtdParser.ScanningFunction scanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_scanningFunction)) = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0002580C File Offset: 0x00023A0C
		// (set) Token: 0x060006A5 RID: 1701 RVA: 0x0000427A File Offset: 0x0000247A
		public unsafe DtdParser.ScanningFunction nextScaningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_nextScaningFunction)) = value;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00025834 File Offset: 0x00023A34
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00004295 File Offset: 0x00002495
		public unsafe DtdParser.ScanningFunction savedScanningFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_savedScanningFunction)) = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0002585C File Offset: 0x00023A5C
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x000042B0 File Offset: 0x000024B0
		public unsafe bool whitespaceSeen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_whitespaceSeen)) = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00025884 File Offset: 0x00023A84
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000042CB File Offset: 0x000024CB
		public unsafe int tokenStartPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_tokenStartPos)) = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000258AC File Offset: 0x00023AAC
		// (set) Token: 0x060006AD RID: 1709 RVA: 0x000042E6 File Offset: 0x000024E6
		public unsafe int colonPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_colonPos)) = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000258D4 File Offset: 0x00023AD4
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x00004301 File Offset: 0x00002501
		public unsafe StringBuilder internalSubsetValueSb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_internalSubsetValueSb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x00025904 File Offset: 0x00023B04
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00004320 File Offset: 0x00002520
		public unsafe int externalEntitiesDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalEntitiesDepth)) = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0002592C File Offset: 0x00023B2C
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x0000433B File Offset: 0x0000253B
		public unsafe int currentEntityId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_currentEntityId)) = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x00025954 File Offset: 0x00023B54
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00004356 File Offset: 0x00002556
		public unsafe bool freeFloatingDtd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_freeFloatingDtd)) = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0002597C File Offset: 0x00023B7C
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x00004371 File Offset: 0x00002571
		public unsafe bool hasFreeFloatingInternalSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_hasFreeFloatingInternalSubset)) = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x000259A4 File Offset: 0x00023BA4
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0000438C File Offset: 0x0000258C
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x000259D4 File Offset: 0x00023BD4
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x000043AB File Offset: 0x000025AB
		public unsafe int condSectionDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionDepth)) = value;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x000259FC File Offset: 0x00023BFC
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x000043C6 File Offset: 0x000025C6
		public unsafe LineInfo literalLineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalLineInfo)) = value;
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00025A24 File Offset: 0x00023C24
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x000043E1 File Offset: 0x000025E1
		public unsafe char literalQuoteChar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_literalQuoteChar)) = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x00025A4C File Offset: 0x00023C4C
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x000043FC File Offset: 0x000025FC
		public unsafe string documentBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_documentBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00025A74 File Offset: 0x00023C74
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x0000441B File Offset: 0x0000261B
		public unsafe string externalDtdBaseUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_externalDtdBaseUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x00025A9C File Offset: 0x00023C9C
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0000443A File Offset: 0x0000263A
		public unsafe Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, DtdParser.UndeclaredNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_undeclaredNotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x00025ACC File Offset: 0x00023CCC
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x00004459 File Offset: 0x00002659
		public unsafe Il2CppStructArray<int> condSectionEntityIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.NativeFieldInfoPtr_condSectionEntityIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapter;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr_readerAdapterWithValidation;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeFieldInfoPtr_nameTable;

		// Token: 0x040004BB RID: 1211
		private static readonly IntPtr NativeFieldInfoPtr_schemaInfo;

		// Token: 0x040004BC RID: 1212
		private static readonly IntPtr NativeFieldInfoPtr_xmlCharType;

		// Token: 0x040004BD RID: 1213
		private static readonly IntPtr NativeFieldInfoPtr_systemId;

		// Token: 0x040004BE RID: 1214
		private static readonly IntPtr NativeFieldInfoPtr_publicId;

		// Token: 0x040004BF RID: 1215
		private static readonly IntPtr NativeFieldInfoPtr_normalize;

		// Token: 0x040004C0 RID: 1216
		private static readonly IntPtr NativeFieldInfoPtr_validate;

		// Token: 0x040004C1 RID: 1217
		private static readonly IntPtr NativeFieldInfoPtr_supportNamespaces;

		// Token: 0x040004C2 RID: 1218
		private static readonly IntPtr NativeFieldInfoPtr_v1Compat;

		// Token: 0x040004C3 RID: 1219
		private static readonly IntPtr NativeFieldInfoPtr_chars;

		// Token: 0x040004C4 RID: 1220
		private static readonly IntPtr NativeFieldInfoPtr_charsUsed;

		// Token: 0x040004C5 RID: 1221
		private static readonly IntPtr NativeFieldInfoPtr_curPos;

		// Token: 0x040004C6 RID: 1222
		private static readonly IntPtr NativeFieldInfoPtr_scanningFunction;

		// Token: 0x040004C7 RID: 1223
		private static readonly IntPtr NativeFieldInfoPtr_nextScaningFunction;

		// Token: 0x040004C8 RID: 1224
		private static readonly IntPtr NativeFieldInfoPtr_savedScanningFunction;

		// Token: 0x040004C9 RID: 1225
		private static readonly IntPtr NativeFieldInfoPtr_whitespaceSeen;

		// Token: 0x040004CA RID: 1226
		private static readonly IntPtr NativeFieldInfoPtr_tokenStartPos;

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeFieldInfoPtr_colonPos;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeFieldInfoPtr_internalSubsetValueSb;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeFieldInfoPtr_externalEntitiesDepth;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeFieldInfoPtr_currentEntityId;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_freeFloatingDtd;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_hasFreeFloatingInternalSubset;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_condSectionDepth;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_literalLineInfo;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_literalQuoteChar;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_documentBaseUri;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_externalDtdBaseUri;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredNotations;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_condSectionEntityIds;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_IDtdParser_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Void_IDtdParserAdapter_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr_InitializeFreeFloatingDtd_Private_Void_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseInternalDtd_Private_Virtual_Final_New_IDtdInfo_IDtdParserAdapter_Boolean_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdParser_ParseFreeFloatingDtd_Private_Virtual_Final_New_IDtdInfo_String_String_String_String_String_IDtdParserAdapter_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInternalSubset_Private_get_Boolean_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreEntityReferences_Private_get_Boolean_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveInternalSubsetValue_Private_get_Boolean_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingTopLevelMarkup_Private_get_Boolean_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_get_SupportNamespaces_Private_get_Boolean_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr_get_Normalize_Private_get_Boolean_0;

		// Token: 0x040004E5 RID: 1253
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Private_Void_Boolean_0;

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr_ParseInDocumentDtd_Private_Void_Boolean_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_ParseFreeFloatingDtd_Private_Void_0;

		// Token: 0x040004E8 RID: 1256
		private static readonly IntPtr NativeMethodInfoPtr_ParseInternalSubset_Private_Void_0;

		// Token: 0x040004E9 RID: 1257
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalSubset_Private_Void_0;

		// Token: 0x040004EA RID: 1258
		private static readonly IntPtr NativeMethodInfoPtr_ParseSubset_Private_Void_0;

		// Token: 0x040004EB RID: 1259
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDecl_Private_Void_0;

		// Token: 0x040004EC RID: 1260
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistType_Private_Void_SchemaAttDef_SchemaElementDecl_Boolean_0;

		// Token: 0x040004ED RID: 1261
		private static readonly IntPtr NativeMethodInfoPtr_ParseAttlistDefault_Private_Void_SchemaAttDef_Boolean_0;

		// Token: 0x040004EE RID: 1262
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementDecl_Private_Void_0;

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementOnlyContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x040004F0 RID: 1264
		private static readonly IntPtr NativeMethodInfoPtr_ParseHowMany_Private_Void_ParticleContentValidator_0;

		// Token: 0x040004F1 RID: 1265
		private static readonly IntPtr NativeMethodInfoPtr_ParseElementMixedContent_Private_Void_ParticleContentValidator_Int32_0;

		// Token: 0x040004F2 RID: 1266
		private static readonly IntPtr NativeMethodInfoPtr_ParseEntityDecl_Private_Void_0;

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeMethodInfoPtr_ParseNotationDecl_Private_Void_0;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeMethodInfoPtr_AddUndeclaredNotation_Private_Void_String_0;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeMethodInfoPtr_ParseComment_Private_Void_0;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeMethodInfoPtr_ParsePI_Private_Void_0;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_ParseCondSection_Private_Void_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_ParseExternalId_Private_Void_Token_Token_byref_String_byref_String_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_GetToken_Private_Token_Boolean_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr_ScanSubsetContent_Private_Token_0;

		// Token: 0x040004FB RID: 1275
		private static readonly IntPtr NativeMethodInfoPtr_ScanNameExpected_Private_Token_0;

		// Token: 0x040004FC RID: 1276
		private static readonly IntPtr NativeMethodInfoPtr_ScanQNameExpected_Private_Token_0;

		// Token: 0x040004FD RID: 1277
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtokenExpected_Private_Token_0;

		// Token: 0x040004FE RID: 1278
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype1_Private_Token_0;

		// Token: 0x040004FF RID: 1279
		private static readonly IntPtr NativeMethodInfoPtr_ScanDoctype2_Private_Token_0;

		// Token: 0x04000500 RID: 1280
		private static readonly IntPtr NativeMethodInfoPtr_ScanClosingTag_Private_Token_0;

		// Token: 0x04000501 RID: 1281
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement1_Private_Token_0;

		// Token: 0x04000502 RID: 1282
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement2_Private_Token_0;

		// Token: 0x04000503 RID: 1283
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement3_Private_Token_0;

		// Token: 0x04000504 RID: 1284
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement4_Private_Token_0;

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement5_Private_Token_0;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement6_Private_Token_0;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeMethodInfoPtr_ScanElement7_Private_Token_0;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist1_Private_Token_0;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist2_Private_Token_0;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist3_Private_Token_0;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist4_Private_Token_0;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist5_Private_Token_0;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist6_Private_Token_0;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_ScanAttlist7_Private_Token_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_ScanLiteral_Private_Token_LiteralType_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntityName_Private_XmlQualifiedName_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_ScanNotation1_Private_Token_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_ScanSystemId_Private_Token_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity1_Private_Token_0;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity2_Private_Token_0;

		// Token: 0x04000515 RID: 1301
		private static readonly IntPtr NativeMethodInfoPtr_ScanEntity3_Private_Token_0;

		// Token: 0x04000516 RID: 1302
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId1_Private_Token_0;

		// Token: 0x04000517 RID: 1303
		private static readonly IntPtr NativeMethodInfoPtr_ScanPublicId2_Private_Token_0;

		// Token: 0x04000518 RID: 1304
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection1_Private_Token_0;

		// Token: 0x04000519 RID: 1305
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection2_Private_Token_0;

		// Token: 0x0400051A RID: 1306
		private static readonly IntPtr NativeMethodInfoPtr_ScanCondSection3_Private_Token_0;

		// Token: 0x0400051B RID: 1307
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_Void_0;

		// Token: 0x0400051C RID: 1308
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_0;

		// Token: 0x0400051D RID: 1309
		private static readonly IntPtr NativeMethodInfoPtr_ScanQName_Private_Void_Boolean_0;

		// Token: 0x0400051E RID: 1310
		private static readonly IntPtr NativeMethodInfoPtr_ReadDataInName_Private_Boolean_0;

		// Token: 0x0400051F RID: 1311
		private static readonly IntPtr NativeMethodInfoPtr_ScanNmtoken_Private_Void_0;

		// Token: 0x04000520 RID: 1312
		private static readonly IntPtr NativeMethodInfoPtr_EatPublicKeyword_Private_Boolean_0;

		// Token: 0x04000521 RID: 1313
		private static readonly IntPtr NativeMethodInfoPtr_EatSystemKeyword_Private_Boolean_0;

		// Token: 0x04000522 RID: 1314
		private static readonly IntPtr NativeMethodInfoPtr_GetNameQualified_Private_XmlQualifiedName_Boolean_0;

		// Token: 0x04000523 RID: 1315
		private static readonly IntPtr NativeMethodInfoPtr_GetNameString_Private_String_0;

		// Token: 0x04000524 RID: 1316
		private static readonly IntPtr NativeMethodInfoPtr_GetNmtokenString_Private_String_0;

		// Token: 0x04000525 RID: 1317
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Private_String_0;

		// Token: 0x04000526 RID: 1318
		private static readonly IntPtr NativeMethodInfoPtr_GetValueWithStrippedSpaces_Private_String_0;

		// Token: 0x04000527 RID: 1319
		private static readonly IntPtr NativeMethodInfoPtr_ReadData_Private_Int32_0;

		// Token: 0x04000528 RID: 1320
		private static readonly IntPtr NativeMethodInfoPtr_LoadParsingBuffer_Private_Void_0;

		// Token: 0x04000529 RID: 1321
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_0;

		// Token: 0x0400052A RID: 1322
		private static readonly IntPtr NativeMethodInfoPtr_SaveParsingBuffer_Private_Void_Int32_0;

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_Boolean_Boolean_Boolean_0;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityReference_Private_Boolean_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_HandleEntityEnd_Private_Boolean_Boolean_0;

		// Token: 0x0400052E RID: 1326
		private static readonly IntPtr NativeMethodInfoPtr_VerifyEntityReference_Private_SchemaEntity_XmlQualifiedName_Boolean_Boolean_Boolean_0;

		// Token: 0x0400052F RID: 1327
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_Int32_XmlSeverityType_String_String_0;

		// Token: 0x04000530 RID: 1328
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_String_String_0;

		// Token: 0x04000531 RID: 1329
		private static readonly IntPtr NativeMethodInfoPtr_SendValidationEvent_Private_Void_XmlSeverityType_XmlSchemaException_0;

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeMethodInfoPtr_IsAttributeValueType_Private_Boolean_Token_0;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNo_Private_get_Int32_0;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePos_Private_get_Int32_0;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseUriStr_Private_get_String_0;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeMethodInfoPtr_OnUnexpectedError_Private_Void_0;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_0;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_String_0;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_Int32_String_Il2CppStringArray_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_Throw_Private_Void_String_String_Int32_Int32_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Int32_String_Int32_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidChar_Private_Void_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr_ThrowUnexpectedToken_Private_Void_Int32_String_String_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_ParseUnexpectedToken_Private_String_Int32_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_StripSpaces_Internal_Static_String_String_0;

		// Token: 0x02000124 RID: 292
		public enum Token
		{
			// Token: 0x04000E2F RID: 3631
			CDATA,
			// Token: 0x04000E30 RID: 3632
			ID,
			// Token: 0x04000E31 RID: 3633
			IDREF,
			// Token: 0x04000E32 RID: 3634
			IDREFS,
			// Token: 0x04000E33 RID: 3635
			ENTITY,
			// Token: 0x04000E34 RID: 3636
			ENTITIES,
			// Token: 0x04000E35 RID: 3637
			NMTOKEN,
			// Token: 0x04000E36 RID: 3638
			NMTOKENS,
			// Token: 0x04000E37 RID: 3639
			NOTATION,
			// Token: 0x04000E38 RID: 3640
			None,
			// Token: 0x04000E39 RID: 3641
			PERef,
			// Token: 0x04000E3A RID: 3642
			AttlistDecl,
			// Token: 0x04000E3B RID: 3643
			ElementDecl,
			// Token: 0x04000E3C RID: 3644
			EntityDecl,
			// Token: 0x04000E3D RID: 3645
			NotationDecl,
			// Token: 0x04000E3E RID: 3646
			Comment,
			// Token: 0x04000E3F RID: 3647
			PI,
			// Token: 0x04000E40 RID: 3648
			CondSectionStart,
			// Token: 0x04000E41 RID: 3649
			CondSectionEnd,
			// Token: 0x04000E42 RID: 3650
			Eof,
			// Token: 0x04000E43 RID: 3651
			REQUIRED,
			// Token: 0x04000E44 RID: 3652
			IMPLIED,
			// Token: 0x04000E45 RID: 3653
			FIXED,
			// Token: 0x04000E46 RID: 3654
			QName,
			// Token: 0x04000E47 RID: 3655
			Name,
			// Token: 0x04000E48 RID: 3656
			Nmtoken,
			// Token: 0x04000E49 RID: 3657
			Quote,
			// Token: 0x04000E4A RID: 3658
			LeftParen,
			// Token: 0x04000E4B RID: 3659
			RightParen,
			// Token: 0x04000E4C RID: 3660
			GreaterThan,
			// Token: 0x04000E4D RID: 3661
			Or,
			// Token: 0x04000E4E RID: 3662
			LeftBracket,
			// Token: 0x04000E4F RID: 3663
			RightBracket,
			// Token: 0x04000E50 RID: 3664
			PUBLIC,
			// Token: 0x04000E51 RID: 3665
			SYSTEM,
			// Token: 0x04000E52 RID: 3666
			Literal,
			// Token: 0x04000E53 RID: 3667
			DOCTYPE,
			// Token: 0x04000E54 RID: 3668
			NData,
			// Token: 0x04000E55 RID: 3669
			Percent,
			// Token: 0x04000E56 RID: 3670
			Star,
			// Token: 0x04000E57 RID: 3671
			QMark,
			// Token: 0x04000E58 RID: 3672
			Plus,
			// Token: 0x04000E59 RID: 3673
			PCDATA,
			// Token: 0x04000E5A RID: 3674
			Comma,
			// Token: 0x04000E5B RID: 3675
			ANY,
			// Token: 0x04000E5C RID: 3676
			EMPTY,
			// Token: 0x04000E5D RID: 3677
			IGNORE,
			// Token: 0x04000E5E RID: 3678
			INCLUDE
		}

		// Token: 0x02000125 RID: 293
		public enum ScanningFunction
		{
			// Token: 0x04000E60 RID: 3680
			SubsetContent,
			// Token: 0x04000E61 RID: 3681
			Name,
			// Token: 0x04000E62 RID: 3682
			QName,
			// Token: 0x04000E63 RID: 3683
			Nmtoken,
			// Token: 0x04000E64 RID: 3684
			Doctype1,
			// Token: 0x04000E65 RID: 3685
			Doctype2,
			// Token: 0x04000E66 RID: 3686
			Element1,
			// Token: 0x04000E67 RID: 3687
			Element2,
			// Token: 0x04000E68 RID: 3688
			Element3,
			// Token: 0x04000E69 RID: 3689
			Element4,
			// Token: 0x04000E6A RID: 3690
			Element5,
			// Token: 0x04000E6B RID: 3691
			Element6,
			// Token: 0x04000E6C RID: 3692
			Element7,
			// Token: 0x04000E6D RID: 3693
			Attlist1,
			// Token: 0x04000E6E RID: 3694
			Attlist2,
			// Token: 0x04000E6F RID: 3695
			Attlist3,
			// Token: 0x04000E70 RID: 3696
			Attlist4,
			// Token: 0x04000E71 RID: 3697
			Attlist5,
			// Token: 0x04000E72 RID: 3698
			Attlist6,
			// Token: 0x04000E73 RID: 3699
			Attlist7,
			// Token: 0x04000E74 RID: 3700
			Entity1,
			// Token: 0x04000E75 RID: 3701
			Entity2,
			// Token: 0x04000E76 RID: 3702
			Entity3,
			// Token: 0x04000E77 RID: 3703
			Notation1,
			// Token: 0x04000E78 RID: 3704
			CondSection1,
			// Token: 0x04000E79 RID: 3705
			CondSection2,
			// Token: 0x04000E7A RID: 3706
			CondSection3,
			// Token: 0x04000E7B RID: 3707
			Literal,
			// Token: 0x04000E7C RID: 3708
			SystemId,
			// Token: 0x04000E7D RID: 3709
			PublicId1,
			// Token: 0x04000E7E RID: 3710
			PublicId2,
			// Token: 0x04000E7F RID: 3711
			ClosingTag,
			// Token: 0x04000E80 RID: 3712
			ParamEntitySpace,
			// Token: 0x04000E81 RID: 3713
			None
		}

		// Token: 0x02000126 RID: 294
		public enum LiteralType
		{
			// Token: 0x04000E83 RID: 3715
			AttributeValue,
			// Token: 0x04000E84 RID: 3716
			EntityReplText,
			// Token: 0x04000E85 RID: 3717
			SystemOrPublicID
		}

		// Token: 0x02000127 RID: 295
		public class UndeclaredNotation : Object
		{
			// Token: 0x06001256 RID: 4694 RVA: 0x000549A8 File Offset: 0x00052BA8
			// Note: this type is marked as 'beforefieldinit'.
			static UndeclaredNotation()
			{
				Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "UndeclaredNotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr);
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "name");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "lineNo");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "linePos");
				DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, "next");
				DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr, 100664401);
			}

			// Token: 0x06001257 RID: 4695 RVA: 0x00054A38 File Offset: 0x00052C38
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17680, RefRangeEnd = 17681, XrefRangeStart = 17679, XrefRangeEnd = 17680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UndeclaredNotation(string name, int lineNo, int linePos)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.UndeclaredNotation>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNo;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.UndeclaredNotation.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001258 RID: 4696 RVA: 0x0000818B File Offset: 0x0000638B
			public UndeclaredNotation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066B RID: 1643
			// (get) Token: 0x06001259 RID: 4697 RVA: 0x00054AA0 File Offset: 0x00052CA0
			// (set) Token: 0x0600125A RID: 4698 RVA: 0x00008194 File Offset: 0x00006394
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700066C RID: 1644
			// (get) Token: 0x0600125B RID: 4699 RVA: 0x00054AC8 File Offset: 0x00052CC8
			// (set) Token: 0x0600125C RID: 4700 RVA: 0x000081B3 File Offset: 0x000063B3
			public unsafe int lineNo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_lineNo)) = value;
				}
			}

			// Token: 0x1700066D RID: 1645
			// (get) Token: 0x0600125D RID: 4701 RVA: 0x00054AF0 File Offset: 0x00052CF0
			// (set) Token: 0x0600125E RID: 4702 RVA: 0x000081CE File Offset: 0x000063CE
			public unsafe int linePos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_linePos)) = value;
				}
			}

			// Token: 0x1700066E RID: 1646
			// (get) Token: 0x0600125F RID: 4703 RVA: 0x00054B18 File Offset: 0x00052D18
			// (set) Token: 0x06001260 RID: 4704 RVA: 0x000081E9 File Offset: 0x000063E9
			public unsafe DtdParser.UndeclaredNotation next
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DtdParser.UndeclaredNotation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.UndeclaredNotation.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E86 RID: 3718
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x04000E87 RID: 3719
			private static readonly IntPtr NativeFieldInfoPtr_lineNo;

			// Token: 0x04000E88 RID: 3720
			private static readonly IntPtr NativeFieldInfoPtr_linePos;

			// Token: 0x04000E89 RID: 3721
			private static readonly IntPtr NativeFieldInfoPtr_next;

			// Token: 0x04000E8A RID: 3722
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Int32_0;
		}

		// Token: 0x02000128 RID: 296
		public class ParseElementOnlyContent_LocalFrame : Object
		{
			// Token: 0x06001261 RID: 4705 RVA: 0x00054B48 File Offset: 0x00052D48
			// Note: this type is marked as 'beforefieldinit'.
			static ParseElementOnlyContent_LocalFrame()
			{
				Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DtdParser>.NativeClassPtr, "ParseElementOnlyContent_LocalFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr);
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "startParenEntityId");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, "parsingSchema");
				DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr, 100664402);
			}

			// Token: 0x06001262 RID: 4706 RVA: 0x00054BB0 File Offset: 0x00052DB0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 17682, RefRangeEnd = 17684, XrefRangeStart = 17681, XrefRangeEnd = 17682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DtdParser.ParseElementOnlyContent_LocalFrame>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref startParentEntityIdParam;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DtdParser.ParseElementOnlyContent_LocalFrame.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001263 RID: 4707 RVA: 0x00008208 File Offset: 0x00006408
			public ParseElementOnlyContent_LocalFrame(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700066F RID: 1647
			// (get) Token: 0x06001264 RID: 4708 RVA: 0x00054BF8 File Offset: 0x00052DF8
			// (set) Token: 0x06001265 RID: 4709 RVA: 0x00008211 File Offset: 0x00006411
			public unsafe int startParenEntityId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_startParenEntityId)) = value;
				}
			}

			// Token: 0x17000670 RID: 1648
			// (get) Token: 0x06001266 RID: 4710 RVA: 0x00054C20 File Offset: 0x00052E20
			// (set) Token: 0x06001267 RID: 4711 RVA: 0x0000822C File Offset: 0x0000642C
			public unsafe DtdParser.Token parsingSchema
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DtdParser.ParseElementOnlyContent_LocalFrame.NativeFieldInfoPtr_parsingSchema)) = value;
				}
			}

			// Token: 0x04000E8B RID: 3723
			private static readonly IntPtr NativeFieldInfoPtr_startParenEntityId;

			// Token: 0x04000E8C RID: 3724
			private static readonly IntPtr NativeFieldInfoPtr_parsingSchema;

			// Token: 0x04000E8D RID: 3725
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
