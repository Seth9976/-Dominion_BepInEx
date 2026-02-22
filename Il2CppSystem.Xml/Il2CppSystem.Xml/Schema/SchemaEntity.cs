using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000DD RID: 221
	public sealed class SchemaEntity : Object
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x000413E0 File Offset: 0x0003F5E0
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaEntity()
		{
			Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr);
			SchemaEntity.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "qname");
			SchemaEntity.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "url");
			SchemaEntity.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "pubid");
			SchemaEntity.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "text");
			SchemaEntity.NativeFieldInfoPtr_ndata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "ndata");
			SchemaEntity.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "lineNumber");
			SchemaEntity.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "linePosition");
			SchemaEntity.NativeFieldInfoPtr_isParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isParameter");
			SchemaEntity.NativeFieldInfoPtr_isExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isExternal");
			SchemaEntity.NativeFieldInfoPtr_parsingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "parsingInProgress");
			SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isDeclaredInExternal");
			SchemaEntity.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "baseURI");
			SchemaEntity.NativeFieldInfoPtr_declaredURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "declaredURI");
			SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665306);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665307);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665308);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665309);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665310);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665311);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665312);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665313);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665314);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665315);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665316);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665317);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665318);
			SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665319);
			SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665320);
			SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665321);
			SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665322);
			SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665323);
			SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665324);
			SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665325);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665326);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665327);
			SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665328);
			SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665329);
			SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665330);
			SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665331);
			SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665332);
			SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665333);
			SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665334);
			SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665335);
			SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665336);
			SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665337);
			SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665338);
			SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665339);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665340);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100665341);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x000417E4 File Offset: 0x0003F9E4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 24207, RefRangeEnd = 24210, XrefRangeStart = 24202, XrefRangeEnd = 24207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity(XmlQualifiedName qname, bool isParameter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParameter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000D9A RID: 3482 RVA: 0x00041840 File Offset: 0x0003FA40
		public unsafe string System.Xml.IDtdEntityInfo.Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x00041878 File Offset: 0x0003FA78
		public unsafe bool System.Xml.IDtdEntityInfo.IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000418B4 File Offset: 0x0003FAB4
		public unsafe bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x000418F0 File Offset: 0x0003FAF0
		public unsafe bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24210, XrefRangeEnd = 24211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06000D9E RID: 3486 RVA: 0x0004192C File Offset: 0x0003FB2C
		public unsafe bool System.Xml.IDtdEntityInfo.IsParameterEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x00041968 File Offset: 0x0003FB68
		public unsafe string System.Xml.IDtdEntityInfo.BaseUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24211, XrefRangeEnd = 24213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000419A0 File Offset: 0x0003FBA0
		public unsafe string System.Xml.IDtdEntityInfo.DeclaredUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24213, XrefRangeEnd = 24215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x000419D8 File Offset: 0x0003FBD8
		public unsafe string System.Xml.IDtdEntityInfo.SystemId
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06000DA2 RID: 3490 RVA: 0x00041A10 File Offset: 0x0003FC10
		public unsafe string System.Xml.IDtdEntityInfo.PublicId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x00041A48 File Offset: 0x0003FC48
		public unsafe string System.Xml.IDtdEntityInfo.Text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00041A80 File Offset: 0x0003FC80
		public unsafe int System.Xml.IDtdEntityInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00041ABC File Offset: 0x0003FCBC
		public unsafe int System.Xml.IDtdEntityInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06000DA6 RID: 3494 RVA: 0x00041AF8 File Offset: 0x0003FCF8
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00041B38 File Offset: 0x0003FD38
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00041B70 File Offset: 0x0003FD70
		public unsafe string Url
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 24215, RefRangeEnd = 24216, XrefRangeStart = 24215, XrefRangeEnd = 24215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00041BB4 File Offset: 0x0003FDB4
		// (set) Token: 0x06000DAA RID: 3498 RVA: 0x00041BEC File Offset: 0x0003FDEC
		public unsafe string Pubid
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00041C30 File Offset: 0x0003FE30
		// (set) Token: 0x06000DAC RID: 3500 RVA: 0x00041C6C File Offset: 0x0003FE6C
		public unsafe bool IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06000DAD RID: 3501 RVA: 0x00041CAC File Offset: 0x0003FEAC
		// (set) Token: 0x06000DAE RID: 3502 RVA: 0x00041CE8 File Offset: 0x0003FEE8
		public unsafe bool DeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00041D28 File Offset: 0x0003FF28
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00041D68 File Offset: 0x0003FF68
		public unsafe XmlQualifiedName NData
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 8044, RefRangeEnd = 8045, XrefRangeStart = 8044, XrefRangeEnd = 8045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x00041DAC File Offset: 0x0003FFAC
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00041DE4 File Offset: 0x0003FFE4
		public unsafe string Text
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 24216, RefRangeEnd = 24219, XrefRangeStart = 24216, XrefRangeEnd = 24216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00041E28 File Offset: 0x00040028
		// (set) Token: 0x06000DB4 RID: 3508 RVA: 0x00041E64 File Offset: 0x00040064
		public unsafe int Line
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06000DB5 RID: 3509 RVA: 0x00041EA4 File Offset: 0x000400A4
		// (set) Token: 0x06000DB6 RID: 3510 RVA: 0x00041EE0 File Offset: 0x000400E0
		public unsafe int Pos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 24219, RefRangeEnd = 24226, XrefRangeStart = 24219, XrefRangeEnd = 24219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x00041F20 File Offset: 0x00040120
		// (set) Token: 0x06000DB8 RID: 3512 RVA: 0x00041F58 File Offset: 0x00040158
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 24226, XrefRangeEnd = 24228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00041F9C File Offset: 0x0004019C
		// (set) Token: 0x06000DBA RID: 3514 RVA: 0x00041FD8 File Offset: 0x000401D8
		public unsafe bool ParsingInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00042018 File Offset: 0x00040218
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00042050 File Offset: 0x00040250
		public unsafe string DeclaredURI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 24230, RefRangeEnd = 24232, XrefRangeStart = 24228, XrefRangeEnd = 24230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00006749 File Offset: 0x00004949
		public SchemaEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06000DBE RID: 3518 RVA: 0x00042094 File Offset: 0x00040294
		// (set) Token: 0x06000DBF RID: 3519 RVA: 0x00006752 File Offset: 0x00004952
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06000DC0 RID: 3520 RVA: 0x000420C4 File Offset: 0x000402C4
		// (set) Token: 0x06000DC1 RID: 3521 RVA: 0x00006771 File Offset: 0x00004971
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06000DC2 RID: 3522 RVA: 0x000420EC File Offset: 0x000402EC
		// (set) Token: 0x06000DC3 RID: 3523 RVA: 0x00006790 File Offset: 0x00004990
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06000DC4 RID: 3524 RVA: 0x00042114 File Offset: 0x00040314
		// (set) Token: 0x06000DC5 RID: 3525 RVA: 0x000067AF File Offset: 0x000049AF
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06000DC6 RID: 3526 RVA: 0x0004213C File Offset: 0x0004033C
		// (set) Token: 0x06000DC7 RID: 3527 RVA: 0x000067CE File Offset: 0x000049CE
		public unsafe XmlQualifiedName ndata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06000DC8 RID: 3528 RVA: 0x0004216C File Offset: 0x0004036C
		// (set) Token: 0x06000DC9 RID: 3529 RVA: 0x000067ED File Offset: 0x000049ED
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06000DCA RID: 3530 RVA: 0x00042194 File Offset: 0x00040394
		// (set) Token: 0x06000DCB RID: 3531 RVA: 0x00006808 File Offset: 0x00004A08
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000421BC File Offset: 0x000403BC
		// (set) Token: 0x06000DCD RID: 3533 RVA: 0x00006823 File Offset: 0x00004A23
		public unsafe bool isParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter)) = value;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000421E4 File Offset: 0x000403E4
		// (set) Token: 0x06000DCF RID: 3535 RVA: 0x0000683E File Offset: 0x00004A3E
		public unsafe bool isExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal)) = value;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06000DD0 RID: 3536 RVA: 0x0004220C File Offset: 0x0004040C
		// (set) Token: 0x06000DD1 RID: 3537 RVA: 0x00006859 File Offset: 0x00004A59
		public unsafe bool parsingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress)) = value;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000DD2 RID: 3538 RVA: 0x00042234 File Offset: 0x00040434
		// (set) Token: 0x06000DD3 RID: 3539 RVA: 0x00006874 File Offset: 0x00004A74
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x0004225C File Offset: 0x0004045C
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x0000688F File Offset: 0x00004A8F
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000DD6 RID: 3542 RVA: 0x00042284 File Offset: 0x00040484
		// (set) Token: 0x06000DD7 RID: 3543 RVA: 0x000068AE File Offset: 0x00004AAE
		public unsafe string declaredURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A0D RID: 2573
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04000A0E RID: 2574
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04000A0F RID: 2575
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x04000A10 RID: 2576
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000A11 RID: 2577
		private static readonly IntPtr NativeFieldInfoPtr_ndata;

		// Token: 0x04000A12 RID: 2578
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000A13 RID: 2579
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000A14 RID: 2580
		private static readonly IntPtr NativeFieldInfoPtr_isParameter;

		// Token: 0x04000A15 RID: 2581
		private static readonly IntPtr NativeFieldInfoPtr_isExternal;

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr_parsingInProgress;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeFieldInfoPtr_declaredURI;

		// Token: 0x04000A1A RID: 2586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0;

		// Token: 0x04000A1B RID: 2587
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A1C RID: 2588
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A1D RID: 2589
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A24 RID: 2596
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04000A25 RID: 2597
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000A26 RID: 2598
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000A27 RID: 2599
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x04000A28 RID: 2600
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Internal_get_String_0;

		// Token: 0x04000A29 RID: 2601
		private static readonly IntPtr NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0;

		// Token: 0x04000A2A RID: 2602
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x04000A2B RID: 2603
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;

		// Token: 0x04000A2C RID: 2604
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0;

		// Token: 0x04000A2D RID: 2605
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0;

		// Token: 0x04000A2E RID: 2606
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x04000A2F RID: 2607
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x04000A30 RID: 2608
		private static readonly IntPtr NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0;

		// Token: 0x04000A31 RID: 2609
		private static readonly IntPtr NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x04000A32 RID: 2610
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Internal_get_String_0;

		// Token: 0x04000A33 RID: 2611
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0;

		// Token: 0x04000A34 RID: 2612
		private static readonly IntPtr NativeMethodInfoPtr_get_Line_Internal_get_Int32_0;

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0;
	}
}
