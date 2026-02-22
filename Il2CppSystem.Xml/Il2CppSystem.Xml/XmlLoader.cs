using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000037 RID: 55
	public class XmlLoader : Object
	{
		// Token: 0x060004F0 RID: 1264 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		// Note: this type is marked as 'beforefieldinit'.
		static XmlLoader()
		{
			Il2CppClassPointerStore<XmlLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "XmlLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr);
			XmlLoader.NativeFieldInfoPtr_doc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "doc");
			XmlLoader.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "reader");
			XmlLoader.NativeFieldInfoPtr_preserveWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, "preserveWhitespace");
			XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664093);
			XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664094);
			XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664095);
			XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664096);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664097);
			XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664098);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664099);
			XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664100);
			XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664101);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664102);
			XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664103);
			XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664104);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664105);
			XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664106);
			XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664107);
			XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664108);
			XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664109);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664110);
			XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664111);
			XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664112);
			XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664113);
			XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664114);
			XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664115);
			XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664116);
			XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664117);
			XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr, 100664118);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlLoader()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001DA78 File Offset: 0x0001BC78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15580, RefRangeEnd = 15581, XrefRangeStart = 15567, XrefRangeEnd = 15580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(XmlDocument doc, XmlReader reader, bool preserveWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(reader);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref preserveWhitespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001DADC File Offset: 0x0001BCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15581, XrefRangeEnd = 15582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocSequence(XmlDocument parentDoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentDoc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001DB20 File Offset: 0x0001BD20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15600, RefRangeEnd = 15604, XrefRangeStart = 15582, XrefRangeEnd = 15600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNode(bool skipOverWhitespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skipOverWhitespace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
			}
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001DB6C File Offset: 0x0001BD6C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15610, RefRangeEnd = 15612, XrefRangeStart = 15604, XrefRangeEnd = 15610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001DBAC File Offset: 0x0001BDAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15612, XrefRangeEnd = 15618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001DBEC File Offset: 0x0001BDEC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 15637, RefRangeEnd = 15643, XrefRangeStart = 15618, XrefRangeEnd = 15637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadAttributeValue(XmlNode parent, bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001DC3C File Offset: 0x0001BE3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15654, RefRangeEnd = 15656, XrefRangeStart = 15643, XrefRangeEnd = 15654, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlEntityReference LoadEntityReferenceNode(bool direct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref direct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlEntityReference>(intPtr3) : null;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001DC88 File Offset: 0x0001BE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15656, XrefRangeEnd = 15669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDeclaration LoadDeclarationNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDeclaration>(intPtr3) : null;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15681, RefRangeEnd = 15682, XrefRangeStart = 15669, XrefRangeEnd = 15681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlDocumentType LoadDocumentTypeNode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlDocumentType>(intPtr3) : null;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x0001DD08 File Offset: 0x0001BF08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15724, RefRangeEnd = 15726, XrefRangeStart = 15682, XrefRangeEnd = 15724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNode LoadNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNode>(intPtr3) : null;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001DD48 File Offset: 0x0001BF48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15767, RefRangeEnd = 15769, XrefRangeStart = 15726, XrefRangeEnd = 15767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlAttribute LoadAttributeNodeDirect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlAttribute>(intPtr3) : null;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001DD88 File Offset: 0x0001BF88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 15769, XrefRangeEnd = 15770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 15798, RefRangeEnd = 15802, XrefRangeStart = 15770, XrefRangeEnd = 15798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseDocumentType(XmlDocumentType dtNode, bool bUseResolver, XmlResolver resolver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bUseResolver;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(resolver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x0001DE30 File Offset: 0x0001C030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15916, RefRangeEnd = 15918, XrefRangeStart = 15802, XrefRangeEnd = 15916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadDocumentType(IDtdInfo dtdInfo, XmlDocumentType dtNode)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtdInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dtNode);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x0001DE84 File Offset: 0x0001C084
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15968, RefRangeEnd = 15969, XrefRangeStart = 15918, XrefRangeEnd = 15968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlParserContext GetContext(XmlNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlParserContext>(intPtr3) : null;
			}
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001DED4 File Offset: 0x0001C0D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 15976, RefRangeEnd = 15981, XrefRangeStart = 15969, XrefRangeEnd = 15976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlNamespaceManager ParsePartialContent(XmlNode parentNode, string innerxmltext, XmlNodeType nt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentNode);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlNamespaceManager>(intPtr3) : null;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x0001DF44 File Offset: 0x0001C144
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15985, RefRangeEnd = 15986, XrefRangeStart = 15981, XrefRangeEnd = 15985, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlElement(XmlElement node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x0001DF98 File Offset: 0x0001C198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 15987, RefRangeEnd = 15988, XrefRangeStart = 15986, XrefRangeEnd = 15987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInnerXmlAttribute(XmlAttribute node, string innerxmltext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(innerxmltext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x0001DFEC File Offset: 0x0001C1EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 15998, RefRangeEnd = 16000, XrefRangeStart = 15988, XrefRangeEnd = 15998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveDuplicateNamespace(XmlElement elem, XmlNamespaceManager mgr, bool fCheckElemAttrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elem);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fCheckElemAttrs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0001E050 File Offset: 0x0001C250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16000, XrefRangeEnd = 16005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string EntitizeName(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_EntitizeName_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x0001E098 File Offset: 0x0001C298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16005, XrefRangeEnd = 16011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntity(XmlEntity ent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x0001E0DC File Offset: 0x0001C2DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16028, RefRangeEnd = 16029, XrefRangeStart = 16011, XrefRangeEnd = 16028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExpandEntityReference(XmlEntityReference eref)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eref);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x0001E120 File Offset: 0x0001C320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 16048, RefRangeEnd = 16049, XrefRangeStart = 16029, XrefRangeEnd = 16048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlReader CreateInnerXmlReader(string xmlFragment, XmlNodeType nt, XmlParserContext context, XmlDocument doc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlFragment);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nt;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(doc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr3) : null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x0001E1A4 File Offset: 0x0001C3A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 16060, RefRangeEnd = 16062, XrefRangeStart = 16049, XrefRangeEnd = 16060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ParseXmlDeclarationValue(string strValue, out string version, out string encoding, out string standalone)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(strValue);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			version = IL2CPP.Il2CppStringToManaged(intPtr);
			encoding = IL2CPP.Il2CppStringToManaged(intPtr2);
			standalone = IL2CPP.Il2CppStringToManaged(intPtr3);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x0001E22C File Offset: 0x0001C42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 16062, XrefRangeEnd = 16078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnexpectedNodeType(XmlNodeType nodetype)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodetype;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlLoader.NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00003BAB File Offset: 0x00001DAB
		public XmlLoader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001E26C File Offset: 0x0001C46C
		// (set) Token: 0x0600050D RID: 1293 RVA: 0x00003BB4 File Offset: 0x00001DB4
		public unsafe XmlDocument doc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlDocument>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_doc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600050E RID: 1294 RVA: 0x0001E29C File Offset: 0x0001C49C
		// (set) Token: 0x0600050F RID: 1295 RVA: 0x00003BD3 File Offset: 0x00001DD3
		public unsafe XmlReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001E2CC File Offset: 0x0001C4CC
		// (set) Token: 0x06000511 RID: 1297 RVA: 0x00003BF2 File Offset: 0x00001DF2
		public unsafe bool preserveWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlLoader.NativeFieldInfoPtr_preserveWhitespace)) = value;
			}
		}

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_doc;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeFieldInfoPtr_preserveWhitespace;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr_Load_Internal_Void_XmlDocument_XmlReader_Boolean_0;

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocSequence_Private_Void_XmlDocument_0;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_LoadNode_Private_XmlNode_Boolean_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNode_Private_XmlAttribute_0;

		// Token: 0x040003DA RID: 986
		private static readonly IntPtr NativeMethodInfoPtr_LoadDefaultAttribute_Private_XmlAttribute_0;

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeValue_Private_Void_XmlNode_Boolean_0;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeMethodInfoPtr_LoadEntityReferenceNode_Private_XmlEntityReference_Boolean_0;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeMethodInfoPtr_LoadDeclarationNode_Private_XmlDeclaration_0;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentTypeNode_Private_XmlDocumentType_0;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_LoadNodeDirect_Private_XmlNode_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr_LoadAttributeNodeDirect_Private_XmlAttribute_0;

		// Token: 0x040003E1 RID: 993
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Internal_Void_XmlDocumentType_0;

		// Token: 0x040003E2 RID: 994
		private static readonly IntPtr NativeMethodInfoPtr_ParseDocumentType_Private_Void_XmlDocumentType_Boolean_XmlResolver_0;

		// Token: 0x040003E3 RID: 995
		private static readonly IntPtr NativeMethodInfoPtr_LoadDocumentType_Private_Void_IDtdInfo_XmlDocumentType_0;

		// Token: 0x040003E4 RID: 996
		private static readonly IntPtr NativeMethodInfoPtr_GetContext_Private_XmlParserContext_XmlNode_0;

		// Token: 0x040003E5 RID: 997
		private static readonly IntPtr NativeMethodInfoPtr_ParsePartialContent_Internal_XmlNamespaceManager_XmlNode_String_XmlNodeType_0;

		// Token: 0x040003E6 RID: 998
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlElement_Internal_Void_XmlElement_String_0;

		// Token: 0x040003E7 RID: 999
		private static readonly IntPtr NativeMethodInfoPtr_LoadInnerXmlAttribute_Internal_Void_XmlAttribute_String_0;

		// Token: 0x040003E8 RID: 1000
		private static readonly IntPtr NativeMethodInfoPtr_RemoveDuplicateNamespace_Private_Void_XmlElement_XmlNamespaceManager_Boolean_0;

		// Token: 0x040003E9 RID: 1001
		private static readonly IntPtr NativeMethodInfoPtr_EntitizeName_Private_String_String_0;

		// Token: 0x040003EA RID: 1002
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntity_Internal_Void_XmlEntity_0;

		// Token: 0x040003EB RID: 1003
		private static readonly IntPtr NativeMethodInfoPtr_ExpandEntityReference_Internal_Void_XmlEntityReference_0;

		// Token: 0x040003EC RID: 1004
		private static readonly IntPtr NativeMethodInfoPtr_CreateInnerXmlReader_Private_XmlReader_String_XmlNodeType_XmlParserContext_XmlDocument_0;

		// Token: 0x040003ED RID: 1005
		private static readonly IntPtr NativeMethodInfoPtr_ParseXmlDeclarationValue_Internal_Static_Void_String_byref_String_byref_String_byref_String_0;

		// Token: 0x040003EE RID: 1006
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedNodeType_Internal_Static_Exception_XmlNodeType_0;
	}
}
